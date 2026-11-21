using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020005CE RID: 1486
[Nullable(new byte[]
{
	0,
	1
})]
public class BabelTowerBuffSelectViewLevelItem : GridProxyAbstract<IBabelTowerBuffSelectViewLevelItemData>
{
	// Token: 0x06004627 RID: 17959 RVA: 0x001803BC File Offset: 0x0017E5BC
	protected unsafe override void OnRegisterComponent()
	{
		int num = 6;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIButtonComponent));
		this.ComponentRegisterInfos = list;
		num2 = 2;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(5, new Action(this.OnClickJumpToBtn));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(4, new Action(this.OnClickOccupyBtn));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06004628 RID: 17960 RVA: 0x0018050C File Offset: 0x0017E70C
	[NullableContext(1)]
	public override void Refresh(IBabelTowerBuffSelectViewLevelItemData data, bool isSelected, int gridIndex)
	{
		BabelTowerData babelTowerData = BabelTowerController.Instance.GetBabelTowerData();
		double serverTimeStamp = TimeUtil.Instance.GetServerTimeStamp();
		this.TargetLevelId = data.LevelId;
		BabelActivityLevelInfo babelActivityLevelInfo;
		BabelActivityLevelInfo babelActivityLevelInfo2;
		long num = BabelTowerConfig.Instance.GetBabelTowerLevelConfig(data.LevelId).IsDifficult ? MathUtils.Instance.LongToNumber(babelTowerData.HardLevelDataMap.TryGetValue(data.LevelId, out babelActivityLevelInfo) ? babelActivityLevelInfo.UnlockTime : 0L) : MathUtils.Instance.LongToNumber(babelTowerData.NormalLevelDataMap.TryGetValue(data.LevelId, out babelActivityLevelInfo2) ? babelActivityLevelInfo2.UnlockTime : 0L);
		this.IsUnlock = (num <= 0L || (double)num <= serverTimeStamp);
		this.BuffId = data.BuffId;
		this.RefreshState(data.State);
	}

	// Token: 0x06004629 RID: 17961 RVA: 0x001805DC File Offset: 0x0017E7DC
	public void RefreshState(EBabelTowerBuffState state)
	{
		if (state == EBabelTowerBuffState.Use)
		{
			base.GetItem(0).SetUIActive(true);
			base.GetItem(2).SetUIActive(false);
			base.GetItem(3).SetUIActive(false);
			base.GetButton(4).RootUIComp.Get().SetUIActive(true);
			base.GetButton(5).SetSelfInteractive(false);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), "BabelTowerBuffUse", Array.Empty<object>());
			return;
		}
		if (state == EBabelTowerBuffState.Lock)
		{
			base.GetItem(0).SetUIActive(true);
			base.GetItem(2).SetUIActive(false);
			base.GetItem(3).SetUIActive(true);
			base.GetButton(5).SetSelfInteractive(true);
			base.GetButton(4).RootUIComp.Get().SetUIActive(false);
			BabelTowerLevel babelTowerLevelConfig = BabelTowerConfig.Instance.GetBabelTowerLevelConfig(this.TargetLevelId);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), babelTowerLevelConfig.NameText, Array.Empty<object>());
			return;
		}
		if (state == EBabelTowerBuffState.Normal)
		{
			base.GetItem(0).SetUIActive(true);
			base.GetItem(2).SetUIActive(true);
			base.GetItem(3).SetUIActive(false);
			base.GetButton(4).RootUIComp.Get().SetUIActive(false);
			base.GetButton(5).SetSelfInteractive(false);
			BabelTowerLevel babelTowerLevelConfig2 = BabelTowerConfig.Instance.GetBabelTowerLevelConfig(this.TargetLevelId);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), babelTowerLevelConfig2.NameText, Array.Empty<object>());
		}
	}

	// Token: 0x0600462A RID: 17962 RVA: 0x00180758 File Offset: 0x0017E958
	private void OnClickJumpToBtn()
	{
		if (!this.IsUnlock)
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("BabelTowerLevelUnlock", Array.Empty<object>());
			return;
		}
		BabelTowerModel.Instance.LevelChoseHandle = this.TargetLevelId;
		if (BabelTowerConfig.Instance.GetBabelTowerLevelConfig(this.TargetLevelId).IsDifficult)
		{
			if (UiManager.Instance.IsViewHide(EUiViewName.BabelTowerHardLevelChoseView))
			{
				UiManager.Instance.NormalResetToView(EUiViewName.BabelTowerHardLevelChoseView, null, true);
				return;
			}
			UiManager.Instance.NormalResetToView(EUiViewName.BabelTowerMainView, delegate(bool _)
			{
				UiManager.Instance.OpenView(EUiViewName.BabelTowerHardLevelChoseView, null, null);
			}, true);
			return;
		}
		else
		{
			if (UiManager.Instance.IsViewHide(EUiViewName.BabelTowerNormalLevelChoseView))
			{
				UiManager.Instance.NormalResetToView(EUiViewName.BabelTowerNormalLevelChoseView, null, true);
				return;
			}
			UiManager.Instance.NormalResetToView(EUiViewName.BabelTowerMainView, delegate(bool _)
			{
				UiManager.Instance.OpenView(EUiViewName.BabelTowerNormalLevelChoseView, null, null);
			}, true);
			return;
		}
	}

	// Token: 0x0600462B RID: 17963 RVA: 0x00180854 File Offset: 0x0017EA54
	private void OnClickOccupyBtn()
	{
		int buffIsUse = BabelTowerController.Instance.GetBabelTowerData().GetBuffIsUse(this.BuffId);
		if (buffIsUse > 0)
		{
			UiManager.Instance.OpenView(EUiViewName.BabelTowerResetView, buffIsUse, null);
		}
	}

	// Token: 0x040035A0 RID: 13728
	private bool IsUnlock;

	// Token: 0x040035A1 RID: 13729
	private int TargetLevelId;

	// Token: 0x040035A2 RID: 13730
	private int BuffId;

	// Token: 0x02006872 RID: 26738
	private class EBabelTowerBuffSelectViewLevelItemDefine
	{
		// Token: 0x040226E3 RID: 141027
		public const int InfoBgItem = 0;

		// Token: 0x040226E4 RID: 141028
		public const int InfoText = 1;

		// Token: 0x040226E5 RID: 141029
		public const int DoneItem = 2;

		// Token: 0x040226E6 RID: 141030
		public const int JumpToItem = 3;

		// Token: 0x040226E7 RID: 141031
		public const int OccupyBtn = 4;

		// Token: 0x040226E8 RID: 141032
		public const int JumpToBtn = 5;
	}
}
