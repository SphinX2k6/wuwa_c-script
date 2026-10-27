using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Advice;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020016D9 RID: 5849
internal class AdviceSelectMotionContent : UiPanelBase
{
	// Token: 0x0600A781 RID: 42881 RVA: 0x002595BC File Offset: 0x002577BC
	[NullableContext(1)]
	public AdviceSelectMotionContent(UUIItem uiItem)
	{
		base.CreateThenShowByActor(uiItem.GetOwner(), null);
	}

	// Token: 0x0600A782 RID: 42882 RVA: 0x002595D4 File Offset: 0x002577D4
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(1, typeof(UUISprite)),
			new ValueTuple<int, Type>(2, typeof(UUIText))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.ButtonClick))
		};
	}

	// Token: 0x0600A783 RID: 42883 RVA: 0x00259654 File Offset: 0x00257854
	protected override void OnStart()
	{
		EventSystem.Instance.Add(EEventName.OnClickAdviceMotion, new Action(this.OnClickMotion));
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle != null)
		{
			extendToggle.CanExecuteChange.Unbind();
			extendToggle.CanExecuteChange.Bind(new Func<bool>(this.CanClickLikeToggle));
		}
	}

	// Token: 0x0600A784 RID: 42884 RVA: 0x002596AC File Offset: 0x002578AC
	private bool CanClickLikeToggle()
	{
		if (this.Data == null)
		{
			return false;
		}
		int? motionRoleId = MotionConfig.Instance.GetMotionRoleId(this.Data.GetIndex());
		MotionModel.EMotionState roleMotionState = MotionModel.Instance.GetRoleMotionState(motionRoleId.GetValueOrDefault(), this.Data.GetIndex());
		if ((roleMotionState == MotionModel.EMotionState.Lock || roleMotionState == MotionModel.EMotionState.CanUnlock) && this.Data.GetIndex() != -1)
		{
			return false;
		}
		if (AdviceModel.Instance.PreSelectMotionId != this.Data.GetIndex())
		{
			return true;
		}
		EventSystem.Instance.Emit(EEventName.OnClickAdviceMotion);
		return false;
	}

	// Token: 0x0600A785 RID: 42885 RVA: 0x0025973C File Offset: 0x0025793C
	private void ButtonClick(EToggleState state)
	{
		if (this.Data == null)
		{
			return;
		}
		AdviceModel.Instance.PreSelectMotionId = this.Data.GetIndex();
		AdviceModel.Instance.CurrentSelectMotionId = this.Data.GetIndex();
		EventSystem.Instance.Emit(EEventName.OnClickAdviceMotion);
	}

	// Token: 0x0600A786 RID: 42886 RVA: 0x0025978C File Offset: 0x0025798C
	private void OnClickMotion()
	{
		this.RefreshToggleState();
	}

	// Token: 0x0600A787 RID: 42887 RVA: 0x00259794 File Offset: 0x00257994
	[NullableContext(1)]
	public void RefreshView(AdviceMotionSelectData data)
	{
		this.Data = data;
		if (data.GetIndex() == AdviceConfig.Instance.GetAdviceMotionDefaultConfigId())
		{
			string text = AdviceConfig.Instance.GetAdviceSpecialParamsContent(data.GetIndex()) ?? "";
			LguiUtil.Instance.SetLocalText(base.GetText(2), "NoneMotion", Array.Empty<object>());
		}
		else
		{
			string newText = MotionConfig.Instance.GetMotionTitle(data.GetIndex()) ?? "";
			UUIText text2 = base.GetText(2);
			if (text2 != null)
			{
				text2.SetText(newText, true);
			}
		}
		this.RefreshLockImg();
		this.RefreshToggleState();
	}

	// Token: 0x0600A788 RID: 42888 RVA: 0x00259834 File Offset: 0x00257A34
	private void RefreshToggleState()
	{
		if (this.Data == null)
		{
			return;
		}
		EToggleState toggleState = base.GetExtendToggle(0).ToggleState;
		EToggleState etoggleState = (AdviceModel.Instance.PreSelectMotionId == this.Data.GetIndex()) ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
		if (toggleState != etoggleState)
		{
			base.GetExtendToggle(0).SetToggleStateForce(etoggleState, false, false, false);
		}
	}

	// Token: 0x0600A789 RID: 42889 RVA: 0x00259888 File Offset: 0x00257A88
	private void RefreshLockImg()
	{
		if (this.Data == null)
		{
			return;
		}
		if (this.Data.GetIndex() == AdviceConfig.Instance.GetAdviceMotionDefaultConfigId())
		{
			UUISprite sprite = base.GetSprite(1);
			if (sprite == null)
			{
				return;
			}
			sprite.SetUIActive(false);
			return;
		}
		else
		{
			int? motionRoleId = MotionConfig.Instance.GetMotionRoleId(this.Data.GetIndex());
			MotionModel.EMotionState roleMotionState = MotionModel.Instance.GetRoleMotionState(motionRoleId.GetValueOrDefault(), this.Data.GetIndex());
			bool uiactive = roleMotionState == MotionModel.EMotionState.Lock || roleMotionState == MotionModel.EMotionState.CanUnlock;
			UUISprite sprite2 = base.GetSprite(1);
			if (sprite2 == null)
			{
				return;
			}
			sprite2.SetUIActive(uiactive);
			return;
		}
	}

	// Token: 0x0600A78A RID: 42890 RVA: 0x00259918 File Offset: 0x00257B18
	protected override void OnBeforeDestroy()
	{
		EventSystem.Instance.Remove(EEventName.OnClickAdviceMotion, new Action(this.OnClickMotion));
	}

	// Token: 0x04004B8E RID: 19342
	[Nullable(2)]
	private AdviceMotionSelectData Data;

	// Token: 0x02007CAD RID: 31917
	private static class EAdviceSelectMotionContent
	{
		// Token: 0x04028E57 RID: 167511
		public const int Toggle = 0;

		// Token: 0x04028E58 RID: 167512
		public const int LockImg = 1;

		// Token: 0x04028E59 RID: 167513
		public const int Text = 2;
	}
}
