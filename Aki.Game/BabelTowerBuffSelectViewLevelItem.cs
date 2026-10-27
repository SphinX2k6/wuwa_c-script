using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200111A RID: 4378
[Nullable(new byte[]
{
	0,
	1
})]
public class BabelTowerBuffSelectViewLevelItem : GridProxyAbstract<IBabelTowerBuffSelectViewLevelItemData>
{
	// Token: 0x06007291 RID: 29329 RVA: 0x00177A00 File Offset: 0x00175C00
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

	// Token: 0x06007292 RID: 29330 RVA: 0x00177B50 File Offset: 0x00175D50
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

	// Token: 0x06007293 RID: 29331 RVA: 0x00177C20 File Offset: 0x00175E20
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

	// Token: 0x06007294 RID: 29332 RVA: 0x00177D9C File Offset: 0x00175F9C
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

	// Token: 0x06007295 RID: 29333 RVA: 0x00177E98 File Offset: 0x00176098
	private void OnClickOccupyBtn()
	{
		int buffIsUse = BabelTowerController.Instance.GetBabelTowerData().GetBuffIsUse(this.BuffId);
		if (buffIsUse > 0)
		{
			UiManager.Instance.OpenView(EUiViewName.BabelTowerResetView, buffIsUse, null);
		}
	}

	// Token: 0x04003507 RID: 13575
	private bool IsUnlock;

	// Token: 0x04003508 RID: 13576
	private int TargetLevelId;

	// Token: 0x04003509 RID: 13577
	private int BuffId;

	// Token: 0x020076DE RID: 30430
	private class EBabelTowerBuffSelectViewLevelItemDefine
	{
		// Token: 0x0402739A RID: 160666
		public const int InfoBgItem = 0;

		// Token: 0x0402739B RID: 160667
		public const int InfoText = 1;

		// Token: 0x0402739C RID: 160668
		public const int DoneItem = 2;

		// Token: 0x0402739D RID: 160669
		public const int JumpToItem = 3;

		// Token: 0x0402739E RID: 160670
		public const int OccupyBtn = 4;

		// Token: 0x0402739F RID: 160671
		public const int JumpToBtn = 5;
	}
}
