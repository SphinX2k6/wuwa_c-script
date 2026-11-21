using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common;
using CSharpScript.Game.Module.InstanceDungeon;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000629 RID: 1577
public class BabelTowerMainView : UiViewBase
{
	// Token: 0x0600499D RID: 18845 RVA: 0x0019038C File Offset: 0x0018E58C
	[NullableContext(1)]
	public BabelTowerMainView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600499E RID: 18846 RVA: 0x00190398 File Offset: 0x0018E598
	protected unsafe override void OnRegisterComponent()
	{
		int num = 17;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIArtText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIArtText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(16, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 3;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(3, new Action(this.OnClickQuestBtn));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(13, new Action(this.OnClickNormalBtn));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(14, new Action(this.OnClickHardBtn));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600499F RID: 18847 RVA: 0x00190680 File Offset: 0x0018E880
	protected override UniTask OnBeforeStartAsync()
	{
		BabelTowerMainView.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<BabelTowerMainView.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060049A0 RID: 18848 RVA: 0x001906C4 File Offset: 0x0018E8C4
	protected override void OnStart()
	{
		UUIItem item = base.GetItem(1);
		if (item != null)
		{
			item.SetUIActive(false);
		}
		UUIItem item2 = base.GetItem(2);
		if (item2 != null)
		{
			item2.SetUIActive(false);
		}
		RedDotController.Instance.BindRedDot(ERedDotName.BabelTowerNewLevelDifficulty, base.GetItem(15), null, 1);
		RedDotController.Instance.BindRedDot(ERedDotName.BabelTowerNewLevelDifficulty, base.GetItem(16), null, 0);
		RedDotController.Instance.BindRedDot(ERedDotName.BabelTowerQuestRedDot, base.GetItem(4), null, 0);
		int newLevel = BabelTowerController.Instance.GetBabelTowerData().GetNewLevel();
		if (newLevel == 0)
		{
			return;
		}
		Dictionary<int, bool> player = LocalStorage.GetPlayer<Dictionary<int, bool>>(ELocalStoragePlayerKey.BabelTowerNewLevel, null);
		bool flag;
		if (player != null && player.TryGetValue(newLevel, out flag) && flag)
		{
			return;
		}
		UiManager.Instance.OpenView(EUiViewName.BabelTowerNewLevelTipsView, newLevel, null);
	}

	// Token: 0x060049A1 RID: 18849 RVA: 0x00190788 File Offset: 0x0018E988
	protected override void OnBeforeShow()
	{
		this.RefreshView();
	}

	// Token: 0x060049A2 RID: 18850 RVA: 0x00190790 File Offset: 0x0018E990
	protected override void OnBeforeDestroy()
	{
		RedDotController.Instance.UnBindGivenUi(ERedDotName.BabelTowerNewLevelDifficulty, base.GetItem(15), 1);
		RedDotController.Instance.UnBindGivenUi(ERedDotName.BabelTowerNewLevelDifficulty, base.GetItem(16), 0);
		RedDotController.Instance.UnBindGivenUi(ERedDotName.BabelTowerQuestRedDot, base.GetItem(4), 0);
		BabelTowerModel.Instance.CurrentSelectLevel = 0;
	}

	// Token: 0x060049A3 RID: 18851 RVA: 0x001907F0 File Offset: 0x0018E9F0
	private void RefreshView()
	{
		BabelTowerData babelTowerData = BabelTowerController.Instance.GetBabelTowerData();
		if (babelTowerData == null)
		{
			return;
		}
		string nextLevelOpenTimeText = babelTowerData.GetNextLevelOpenTimeText();
		if (string.IsNullOrEmpty(nextLevelOpenTimeText))
		{
			double remainTime = (babelTowerData.EndOpenTime == 0L) ? 0.0 : ((double)babelTowerData.EndOpenTime - TimeUtil.Instance.GetServerTime());
			string countDownText = TimeUtil.Instance.GetRemainTimeDataFormat(remainTime).CountDownText;
			LguiUtil.Instance.SetLocalTextNew(base.GetText(7), "BabelTowerCloseTime", new <>z__ReadOnlySingleElementList<object>(countDownText));
		}
		else
		{
			base.GetItem(8).SetUIActive(true);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(7), "BabelUiTimeNew", new <>z__ReadOnlySingleElementList<object>(nextLevelOpenTimeText));
		}
		string normalLevelPassText = babelTowerData.GetNormalLevelPassText();
		LguiUtil.Instance.SetLocalTextNew(base.GetText(10), "BabelTowerNormalLevelTips", new <>z__ReadOnlySingleElementList<object>(normalLevelPassText));
		string hardLevelStarText = babelTowerData.GetHardLevelStarText();
		base.GetArtText(12).SetText(hardLevelStarText);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(11), "Babeleasy_pass", Array.Empty<object>());
		this.RefreshQuestText();
	}

	// Token: 0x060049A4 RID: 18852 RVA: 0x001908F8 File Offset: 0x0018EAF8
	private void RefreshQuestText()
	{
		ValueTuple<int, int> normalQuestCount = BabelTowerController.Instance.GetBabelTowerData().GetNormalQuestCount();
		int item = normalQuestCount.Item1;
		int item2 = normalQuestCount.Item2;
		int value = item;
		int value2 = item2;
		UUIText text = base.GetText(5);
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
		defaultInterpolatedStringHandler.AppendLiteral("/");
		defaultInterpolatedStringHandler.AppendFormatted<int>(value2);
		text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
		UUIText text2 = base.GetText(6);
		defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 1);
		defaultInterpolatedStringHandler.AppendFormatted<int>(value);
		text2.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
	}

	// Token: 0x060049A5 RID: 18853 RVA: 0x00190979 File Offset: 0x0018EB79
	private void OnCloseBtnClick()
	{
		IBabelTowerMainViewData data = this.Data;
		if (data != null && data.IfLeaveInstanceDungeonWhenClose)
		{
			InstanceDungeonEntranceController.Instance.LeaveInstanceDungeon();
			return;
		}
		base.CloseMe(null);
	}

	// Token: 0x060049A6 RID: 18854 RVA: 0x001909A2 File Offset: 0x0018EBA2
	private void OnClickQuestBtn()
	{
		if (!BabelTowerController.Instance.GetBabelTowerData().CheckIfInOpenTime())
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("BabelTowerIsNotOpen", Array.Empty<object>());
			return;
		}
		UiManager.Instance.OpenView(EUiViewName.BabelTowerQuestView, null, null);
	}

	// Token: 0x060049A7 RID: 18855 RVA: 0x001909DB File Offset: 0x0018EBDB
	private void OnClickNormalBtn()
	{
		UiManager.Instance.OpenView(EUiViewName.BabelTowerNormalLevelChoseView, null, null);
	}

	// Token: 0x060049A8 RID: 18856 RVA: 0x001909EE File Offset: 0x0018EBEE
	private void OnClickHardBtn()
	{
		UiManager.Instance.OpenView(EUiViewName.BabelTowerHardLevelChoseView, null, null);
	}

	// Token: 0x040036BD RID: 14013
	[Nullable(2)]
	private IBabelTowerMainViewData Data;

	// Token: 0x040036BE RID: 14014
	[Nullable(2)]
	private PopupCaptionItem CaptionItem;

	// Token: 0x020068D4 RID: 26836
	private class EComponentDefine
	{
		// Token: 0x040228C3 RID: 141507
		public const int CaptionItem = 0;

		// Token: 0x040228C4 RID: 141508
		public const int ShopBtn = 1;

		// Token: 0x040228C5 RID: 141509
		public const int ShopBtnRedDotItem = 2;

		// Token: 0x040228C6 RID: 141510
		public const int QuestBtn = 3;

		// Token: 0x040228C7 RID: 141511
		public const int QuestRedDotItem = 4;

		// Token: 0x040228C8 RID: 141512
		public const int QuestText1 = 5;

		// Token: 0x040228C9 RID: 141513
		public const int QuestText2 = 6;

		// Token: 0x040228CA RID: 141514
		public const int NewLevelTimeText = 7;

		// Token: 0x040228CB RID: 141515
		public const int NewLevelTimeItem = 8;

		// Token: 0x040228CC RID: 141516
		public const int NormalProgressText = 9;

		// Token: 0x040228CD RID: 141517
		public const int NormalDesText = 10;

		// Token: 0x040228CE RID: 141518
		public const int NormalTipsText = 11;

		// Token: 0x040228CF RID: 141519
		public const int HardStarText = 12;

		// Token: 0x040228D0 RID: 141520
		public const int NormalBtn = 13;

		// Token: 0x040228D1 RID: 141521
		public const int HardBtn = 14;

		// Token: 0x040228D2 RID: 141522
		public const int HardLevelRedDotItem = 15;

		// Token: 0x040228D3 RID: 141523
		public const int NormalLevelRedDotItem = 16;
	}
}
