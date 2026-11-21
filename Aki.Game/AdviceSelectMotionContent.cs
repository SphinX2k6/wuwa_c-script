using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Advice;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000B91 RID: 2961
internal class AdviceSelectMotionContent : UiPanelBase
{
	// Token: 0x06007B61 RID: 31585 RVA: 0x002639C4 File Offset: 0x00261BC4
	[NullableContext(1)]
	public AdviceSelectMotionContent(UUIItem uiItem)
	{
		base.CreateThenShowByActor(uiItem.GetOwner(), null);
	}

	// Token: 0x06007B62 RID: 31586 RVA: 0x002639DC File Offset: 0x00261BDC
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

	// Token: 0x06007B63 RID: 31587 RVA: 0x00263A5C File Offset: 0x00261C5C
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

	// Token: 0x06007B64 RID: 31588 RVA: 0x00263AB4 File Offset: 0x00261CB4
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

	// Token: 0x06007B65 RID: 31589 RVA: 0x00263B44 File Offset: 0x00261D44
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

	// Token: 0x06007B66 RID: 31590 RVA: 0x00263B94 File Offset: 0x00261D94
	private void OnClickMotion()
	{
		this.RefreshToggleState();
	}

	// Token: 0x06007B67 RID: 31591 RVA: 0x00263B9C File Offset: 0x00261D9C
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

	// Token: 0x06007B68 RID: 31592 RVA: 0x00263C3C File Offset: 0x00261E3C
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

	// Token: 0x06007B69 RID: 31593 RVA: 0x00263C90 File Offset: 0x00261E90
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

	// Token: 0x06007B6A RID: 31594 RVA: 0x00263D20 File Offset: 0x00261F20
	protected override void OnBeforeDestroy()
	{
		EventSystem.Instance.Remove(EEventName.OnClickAdviceMotion, new Action(this.OnClickMotion));
	}

	// Token: 0x04004C35 RID: 19509
	[Nullable(2)]
	private AdviceMotionSelectData Data;

	// Token: 0x02006E32 RID: 28210
	private static class EAdviceSelectMotionContent
	{
		// Token: 0x04024180 RID: 147840
		public const int Toggle = 0;

		// Token: 0x04024181 RID: 147841
		public const int LockImg = 1;

		// Token: 0x04024182 RID: 147842
		public const int Text = 2;
	}
}
