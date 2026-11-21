using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001685 RID: 5765
public class LordGymDifficultyItem : GridProxyAbstract<int>
{
	// Token: 0x0600E05D RID: 57437 RVA: 0x0041D6B8 File Offset: 0x0041B8B8
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

	// Token: 0x0600E05E RID: 57438 RVA: 0x0041D769 File Offset: 0x0041B969
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

	// Token: 0x0600E05F RID: 57439 RVA: 0x0041D7A4 File Offset: 0x0041B9A4
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

	// Token: 0x0600E060 RID: 57440 RVA: 0x0041D851 File Offset: 0x0041BA51
	protected virtual void SetLevelText(LordGym config)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), config.GymTitle, Array.Empty<object>());
	}

	// Token: 0x0600E061 RID: 57441 RVA: 0x0041D870 File Offset: 0x0041BA70
	public override void OnSelected(bool fireEvent)
	{
		base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_Checked, fireEvent, false, false);
	}

	// Token: 0x0600E062 RID: 57442 RVA: 0x0041D883 File Offset: 0x0041BA83
	public override void OnDeselected(bool fireEvent)
	{
		base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_UnChecked, fireEvent, false, false);
	}

	// Token: 0x0600E064 RID: 57444 RVA: 0x0041D8A5 File Offset: 0x0041BAA5
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

	// Token: 0x040080B7 RID: 32951
	private int LordId = -1;

	// Token: 0x040080B8 RID: 32952
	[Nullable(2)]
	public Action<int> OnToggleClick;

	// Token: 0x040080B9 RID: 32953
	[Nullable(2)]
	public Func<int, bool> CanExecuteChangeCallBack;

	// Token: 0x02007857 RID: 30807
	private class EComponent
	{
		// Token: 0x040270DE RID: 159966
		public const int LordToggle = 0;

		// Token: 0x040270DF RID: 159967
		public const int LevelText = 1;

		// Token: 0x040270E0 RID: 159968
		public const int LockItem = 2;

		// Token: 0x040270E1 RID: 159969
		public const int FinishItem = 3;

		// Token: 0x040270E2 RID: 159970
		public const int RedDotItem = 4;
	}
}
