using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Advice;
using CSharpScript.Game.Module.GenericPrompt;
using CSharpScript.Game.Module.Manufacture.Compose;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020016D6 RID: 5846
public class AdviceMotionItem : UiPanelBase
{
	// Token: 0x0600A759 RID: 42841 RVA: 0x00258894 File Offset: 0x00256A94
	[NullableContext(1)]
	public AdviceMotionItem(UUIItem uiItem)
	{
		base.CreateThenShowByActor(uiItem.GetOwner(), null);
	}

	// Token: 0x0600A75A RID: 42842 RVA: 0x002588AC File Offset: 0x00256AAC
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUITexture)),
			new ValueTuple<int, Type>(3, typeof(UUISprite)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClickToggle))
		};
	}

	// Token: 0x0600A75B RID: 42843 RVA: 0x0025896C File Offset: 0x00256B6C
	protected override void OnStart()
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle != null)
		{
			extendToggle.CanExecuteChange.Unbind();
			extendToggle.CanExecuteChange.Bind(new Func<bool>(this.CanExecuteChange));
		}
		EventSystem.Instance.Add(EEventName.OnClickAdviceMotion, new Action(this.OnClickMotion));
	}

	// Token: 0x0600A75C RID: 42844 RVA: 0x002589C2 File Offset: 0x00256BC2
	private void OnClickToggle(EToggleState state)
	{
		AdviceModel.Instance.PreSelectMotionId = this.CurrentId;
		EventSystem.Instance.Emit(EEventName.OnClickAdviceMotion);
	}

	// Token: 0x0600A75D RID: 42845 RVA: 0x002589E4 File Offset: 0x00256BE4
	private void OnClickMotion()
	{
		this.RefreshToggleState();
	}

	// Token: 0x0600A75E RID: 42846 RVA: 0x002589EC File Offset: 0x00256BEC
	private bool CanExecuteChange()
	{
		bool flag = this.CurrentId == AdviceModel.Instance.PreSelectMotionId;
		if (this.CurrentId == AdviceConfig.Instance.GetAdviceMotionDefaultConfigId())
		{
			return !flag;
		}
		int? motionRoleId = MotionConfig.Instance.GetMotionRoleId(this.CurrentId);
		MotionModel.EMotionState roleMotionState = MotionModel.Instance.GetRoleMotionState(motionRoleId.GetValueOrDefault(), this.CurrentId);
		bool flag2 = roleMotionState == MotionModel.EMotionState.Lock || roleMotionState == MotionModel.EMotionState.CanUnlock;
		if (flag2)
		{
			Motion? motionConfig = MotionConfig.Instance.GetMotionConfig(this.CurrentId);
			if (motionConfig != null)
			{
				ConditionGroup? conditionInfo = ComposeConfig.Instance.GetConditionInfo(motionConfig.Value.CondGroupId);
				if (conditionInfo != null)
				{
					string localText = ComposeConfig.Instance.GetLocalText(conditionInfo.Value.HintText);
					GenericPromptController.Instance.ShowPromptByCode("UnlockCondition", new object[]
					{
						localText
					});
				}
			}
		}
		return !flag && !flag2;
	}

	// Token: 0x0600A75F RID: 42847 RVA: 0x00258AD9 File Offset: 0x00256CD9
	public void Update(int id)
	{
		this.CurrentId = id;
		this.RefreshView();
	}

	// Token: 0x0600A760 RID: 42848 RVA: 0x00258AE8 File Offset: 0x00256CE8
	private void RefreshView()
	{
		this.RefreshSelectState();
		this.RefreshTexture();
		this.RefreshName();
		this.RefreshToggleState();
		this.RefreshLockState();
	}

	// Token: 0x0600A761 RID: 42849 RVA: 0x00258B08 File Offset: 0x00256D08
	private void RefreshName()
	{
		string newText;
		if (this.CurrentId == AdviceConfig.Instance.GetAdviceMotionDefaultConfigId())
		{
			newText = (AdviceConfig.Instance.GetAdviceSpecialParamsContent(this.CurrentId) ?? "");
		}
		else
		{
			newText = (MotionConfig.Instance.GetMotionContent(this.CurrentId) ?? "");
		}
		UUIText text = base.GetText(1);
		if (text == null)
		{
			return;
		}
		text.SetText(newText, true);
	}

	// Token: 0x0600A762 RID: 42850 RVA: 0x00258B78 File Offset: 0x00256D78
	private void RefreshTexture()
	{
		string path;
		if (this.CurrentId == AdviceConfig.Instance.GetAdviceMotionDefaultConfigId())
		{
			AdviceParams? adviceSpecialParams = AdviceConfig.Instance.GetAdviceSpecialParams(this.CurrentId);
			path = (((adviceSpecialParams != null) ? adviceSpecialParams.GetValueOrDefault().MotionImg : null) ?? "");
		}
		else
		{
			Motion? motionConfig = MotionConfig.Instance.GetMotionConfig(this.CurrentId);
			path = (((motionConfig != null) ? motionConfig.GetValueOrDefault().MotionImg : null) ?? "");
		}
		base.SetTextureByPath(path, base.GetTexture(2), null, null);
	}

	// Token: 0x0600A763 RID: 42851 RVA: 0x00258C28 File Offset: 0x00256E28
	private void RefreshSelectState()
	{
		bool uiactive = this.CurrentId == AdviceModel.Instance.CurrentSelectMotionId;
		UUIItem item = base.GetItem(4);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(uiactive);
	}

	// Token: 0x0600A764 RID: 42852 RVA: 0x00258C5C File Offset: 0x00256E5C
	private void RefreshToggleState()
	{
		EToggleState etoggleState = (this.CurrentId == AdviceModel.Instance.PreSelectMotionId) ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
		if (base.GetExtendToggle(0).ToggleState != etoggleState)
		{
			base.GetExtendToggle(0).SetToggleStateForce(etoggleState, false, false, false);
		}
	}

	// Token: 0x0600A765 RID: 42853 RVA: 0x00258CA0 File Offset: 0x00256EA0
	private void RefreshLockState()
	{
		if (this.CurrentId == AdviceConfig.Instance.GetAdviceMotionDefaultConfigId())
		{
			UUISprite sprite = base.GetSprite(3);
			if (sprite != null)
			{
				sprite.SetUIActive(false);
			}
			UUIItem item = base.GetItem(5);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(false);
			return;
		}
		else
		{
			int? motionRoleId = MotionConfig.Instance.GetMotionRoleId(this.CurrentId);
			MotionModel.EMotionState roleMotionState = MotionModel.Instance.GetRoleMotionState(motionRoleId.GetValueOrDefault(), this.CurrentId);
			bool uiactive = roleMotionState == MotionModel.EMotionState.Lock || roleMotionState == MotionModel.EMotionState.CanUnlock;
			UUISprite sprite2 = base.GetSprite(3);
			if (sprite2 != null)
			{
				sprite2.SetUIActive(uiactive);
			}
			UUIItem item2 = base.GetItem(5);
			if (item2 == null)
			{
				return;
			}
			item2.SetUIActive(uiactive);
			return;
		}
	}

	// Token: 0x0600A766 RID: 42854 RVA: 0x00258D3E File Offset: 0x00256F3E
	protected override void OnBeforeDestroy()
	{
		EventSystem.Instance.Remove(EEventName.OnClickAdviceMotion, new Action(this.OnClickMotion));
	}

	// Token: 0x04004B84 RID: 19332
	private int CurrentId;

	// Token: 0x02007CAA RID: 31914
	private static class EChildType
	{
		// Token: 0x04028E46 RID: 167494
		public const int Toggle = 0;

		// Token: 0x04028E47 RID: 167495
		public const int NameText = 1;

		// Token: 0x04028E48 RID: 167496
		public const int MiddleTexture = 2;

		// Token: 0x04028E49 RID: 167497
		public const int GrayTexture = 3;

		// Token: 0x04028E4A RID: 167498
		public const int SelectItem = 4;

		// Token: 0x04028E4B RID: 167499
		public const int LockItem = 5;
	}
}
