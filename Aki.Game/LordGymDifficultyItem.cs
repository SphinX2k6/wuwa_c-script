using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x020021A1 RID: 8609
public class LordGymDifficultyItem : GridProxyAbstract<int>
{
	// Token: 0x06010BCC RID: 68556 RVA: 0x00410DD0 File Offset: 0x0040EFD0
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIItem))
		};
		if (this.OnToggleClick != null)
		{
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.<OnRegisterComponent>g__CallBack|4_0))
			};
		}
	}

	// Token: 0x06010BCD RID: 68557 RVA: 0x00410E81 File Offset: 0x0040F081
	protected override void OnStart()
	{
		if (this.CanExecuteChangeCallBack != null)
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle != null)
			{
				extendToggle.CanExecuteChange.Bind(delegate()
				{
					Func<int, bool> canExecuteChangeCallBack = this.CanExecuteChangeCallBack;
					return canExecuteChangeCallBack == null || canExecuteChangeCallBack(base.GridIndex);
				});
			}
		}
		base.GetItem(4).SetUIActive(false);
	}

	// Token: 0x06010BCE RID: 68558 RVA: 0x00410EBC File Offset: 0x0040F0BC
	public override void Refresh(int data, bool isSelected, int gridIndex)
	{
		this.LordId = data;
		bool uiactive = !LordGymModel.Instance.GetLordGymIsUnLock(this.LordId) || !LordGymModel.Instance.GetLastGymFinish(this.LordId);
		base.GetItem(2).SetUIActive(uiactive);
		LordGym? lordGymConfig = LordGymConfig.Instance.GetLordGymConfig(this.LordId);
		if (lordGymConfig == null)
		{
			return;
		}
		LordGym value = lordGymConfig.Value;
		bool lordGymIsFinish = LordGymModel.Instance.GetLordGymIsFinish(this.LordId);
		base.GetItem(3).SetUIActive(lordGymIsFinish);
		this.SetLevelText(value);
		EToggleState state = isSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
		base.GetExtendToggle(0).SetToggleState(state, false, false, false);
	}

	// Token: 0x06010BCF RID: 68559 RVA: 0x00410F69 File Offset: 0x0040F169
	protected virtual void SetLevelText(LordGym config)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), config.GymTitle, Array.Empty<object>());
	}

	// Token: 0x06010BD0 RID: 68560 RVA: 0x00410F88 File Offset: 0x0040F188
	public override void OnSelected(bool fireEvent)
	{
		base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_Checked, fireEvent, false, false);
	}

	// Token: 0x06010BD1 RID: 68561 RVA: 0x00410F9B File Offset: 0x0040F19B
	public override void OnDeselected(bool fireEvent)
	{
		base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_UnChecked, fireEvent, false, false);
	}

	// Token: 0x06010BD3 RID: 68563 RVA: 0x00410FBD File Offset: 0x0040F1BD
	[CompilerGenerated]
	private void <OnRegisterComponent>g__CallBack|4_0(EToggleState state)
	{
		Action<int> onToggleClick = this.OnToggleClick;
		if (onToggleClick == null)
		{
			return;
		}
		onToggleClick(base.GridIndex);
	}

	// Token: 0x04007F70 RID: 32624
	private int LordId = -1;

	// Token: 0x04007F71 RID: 32625
	[Nullable(2)]
	public Action<int> OnToggleClick;

	// Token: 0x04007F72 RID: 32626
	[Nullable(2)]
	public Func<int, bool> CanExecuteChangeCallBack;

	// Token: 0x020086CC RID: 34508
	private class EComponent
	{
		// Token: 0x0402BDBD RID: 179645
		public const int LordToggle = 0;

		// Token: 0x0402BDBE RID: 179646
		public const int LevelText = 1;

		// Token: 0x0402BDBF RID: 179647
		public const int LockItem = 2;

		// Token: 0x0402BDC0 RID: 179648
		public const int FinishItem = 3;

		// Token: 0x0402BDC1 RID: 179649
		public const int RedDotItem = 4;
	}
}
