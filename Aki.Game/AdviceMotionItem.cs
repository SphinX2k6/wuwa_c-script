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

// Token: 0x02000B8E RID: 2958
public class AdviceMotionItem : UiPanelBase
{
	// Token: 0x06007B39 RID: 31545 RVA: 0x00262CA0 File Offset: 0x00260EA0
	[NullableContext(1)]
	public AdviceMotionItem(UUIItem uiItem)
	{
		base.CreateThenShowByActor(uiItem.GetOwner(), null);
	}

	// Token: 0x06007B3A RID: 31546 RVA: 0x00262CB8 File Offset: 0x00260EB8
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

	// Token: 0x06007B3B RID: 31547 RVA: 0x00262D78 File Offset: 0x00260F78
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

	// Token: 0x06007B3C RID: 31548 RVA: 0x00262DCE File Offset: 0x00260FCE
	private void OnClickToggle(EToggleState state)
	{
		AdviceModel.Instance.PreSelectMotionId = this.CurrentId;
		EventSystem.Instance.Emit(EEventName.OnClickAdviceMotion);
	}

	// Token: 0x06007B3D RID: 31549 RVA: 0x00262DF0 File Offset: 0x00260FF0
	private void OnClickMotion()
	{
		this.RefreshToggleState();
	}

	// Token: 0x06007B3E RID: 31550 RVA: 0x00262DF8 File Offset: 0x00260FF8
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

	// Token: 0x06007B3F RID: 31551 RVA: 0x00262EE5 File Offset: 0x002610E5
	public void Update(int id)
	{
		this.CurrentId = id;
		this.RefreshView();
	}

	// Token: 0x06007B40 RID: 31552 RVA: 0x00262EF4 File Offset: 0x002610F4
	private void RefreshView()
	{
		this.RefreshSelectState();
		this.RefreshTexture();
		this.RefreshName();
		this.RefreshToggleState();
		this.RefreshLockState();
	}

	// Token: 0x06007B41 RID: 31553 RVA: 0x00262F14 File Offset: 0x00261114
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

	// Token: 0x06007B42 RID: 31554 RVA: 0x00262F84 File Offset: 0x00261184
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

	// Token: 0x06007B43 RID: 31555 RVA: 0x00263034 File Offset: 0x00261234
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

	// Token: 0x06007B44 RID: 31556 RVA: 0x00263068 File Offset: 0x00261268
	private void RefreshToggleState()
	{
		EToggleState etoggleState = (this.CurrentId == AdviceModel.Instance.PreSelectMotionId) ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
		if (base.GetExtendToggle(0).ToggleState != etoggleState)
		{
			base.GetExtendToggle(0).SetToggleStateForce(etoggleState, false, false, false);
		}
	}

	// Token: 0x06007B45 RID: 31557 RVA: 0x002630AC File Offset: 0x002612AC
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

	// Token: 0x06007B46 RID: 31558 RVA: 0x0026314A File Offset: 0x0026134A
	protected override void OnBeforeDestroy()
	{
		EventSystem.Instance.Remove(EEventName.OnClickAdviceMotion, new Action(this.OnClickMotion));
	}

	// Token: 0x04004C2B RID: 19499
	private int CurrentId;

	// Token: 0x02006E2F RID: 28207
	private static class EChildType
	{
		// Token: 0x0402416F RID: 147823
		public const int Toggle = 0;

		// Token: 0x04024170 RID: 147824
		public const int NameText = 1;

		// Token: 0x04024171 RID: 147825
		public const int MiddleTexture = 2;

		// Token: 0x04024172 RID: 147826
		public const int GrayTexture = 3;

		// Token: 0x04024173 RID: 147827
		public const int SelectItem = 4;

		// Token: 0x04024174 RID: 147828
		public const int LockItem = 5;
	}
}
