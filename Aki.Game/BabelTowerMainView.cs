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

// Token: 0x02001175 RID: 4469
public class BabelTowerMainView : UiViewBase
{
	// Token: 0x06007606 RID: 30214 RVA: 0x001877DC File Offset: 0x001859DC
	[NullableContext(1)]
	public BabelTowerMainView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06007607 RID: 30215 RVA: 0x001877E8 File Offset: 0x001859E8
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

	// Token: 0x06007608 RID: 30216 RVA: 0x00187AD0 File Offset: 0x00185CD0
	protected override UniTask OnBeforeStartAsync()
	{
		BabelTowerMainView.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<BabelTowerMainView.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06007609 RID: 30217 RVA: 0x00187B14 File Offset: 0x00185D14
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

	// Token: 0x0600760A RID: 30218 RVA: 0x00187BD8 File Offset: 0x00185DD8
	protected override void OnBeforeShow()
	{
		this.RefreshView();
	}

	// Token: 0x0600760B RID: 30219 RVA: 0x00187BE0 File Offset: 0x00185DE0
	protected override void OnBeforeDestroy()
	{
		RedDotController.Instance.UnBindGivenUi(ERedDotName.BabelTowerNewLevelDifficulty, base.GetItem(15), 1);
		RedDotController.Instance.UnBindGivenUi(ERedDotName.BabelTowerNewLevelDifficulty, base.GetItem(16), 0);
		RedDotController.Instance.UnBindGivenUi(ERedDotName.BabelTowerQuestRedDot, base.GetItem(4), 0);
		BabelTowerModel.Instance.CurrentSelectLevel = 0;
	}

	// Token: 0x0600760C RID: 30220 RVA: 0x00187C40 File Offset: 0x00185E40
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

	// Token: 0x0600760D RID: 30221 RVA: 0x00187D48 File Offset: 0x00185F48
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

	// Token: 0x0600760E RID: 30222 RVA: 0x00187DC9 File Offset: 0x00185FC9
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

	// Token: 0x0600760F RID: 30223 RVA: 0x00187DF2 File Offset: 0x00185FF2
	private void OnClickQuestBtn()
	{
		if (!BabelTowerController.Instance.GetBabelTowerData().CheckIfInOpenTime())
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("BabelTowerIsNotOpen", Array.Empty<object>());
			return;
		}
		UiManager.Instance.OpenView(EUiViewName.BabelTowerQuestView, null, null);
	}

	// Token: 0x06007610 RID: 30224 RVA: 0x00187E2B File Offset: 0x0018602B
	private void OnClickNormalBtn()
	{
		UiManager.Instance.OpenView(EUiViewName.BabelTowerNormalLevelChoseView, null, null);
	}

	// Token: 0x06007611 RID: 30225 RVA: 0x00187E3E File Offset: 0x0018603E
	private void OnClickHardBtn()
	{
		UiManager.Instance.OpenView(EUiViewName.BabelTowerHardLevelChoseView, null, null);
	}

	// Token: 0x04003624 RID: 13860
	[Nullable(2)]
	private IBabelTowerMainViewData Data;

	// Token: 0x04003625 RID: 13861
	[Nullable(2)]
	private PopupCaptionItem CaptionItem;

	// Token: 0x02007747 RID: 30535
	private class EComponentDefine
	{
		// Token: 0x0402758A RID: 161162
		public const int CaptionItem = 0;

		// Token: 0x0402758B RID: 161163
		public const int ShopBtn = 1;

		// Token: 0x0402758C RID: 161164
		public const int ShopBtnRedDotItem = 2;

		// Token: 0x0402758D RID: 161165
		public const int QuestBtn = 3;

		// Token: 0x0402758E RID: 161166
		public const int QuestRedDotItem = 4;

		// Token: 0x0402758F RID: 161167
		public const int QuestText1 = 5;

		// Token: 0x04027590 RID: 161168
		public const int QuestText2 = 6;

		// Token: 0x04027591 RID: 161169
		public const int NewLevelTimeText = 7;

		// Token: 0x04027592 RID: 161170
		public const int NewLevelTimeItem = 8;

		// Token: 0x04027593 RID: 161171
		public const int NormalProgressText = 9;

		// Token: 0x04027594 RID: 161172
		public const int NormalDesText = 10;

		// Token: 0x04027595 RID: 161173
		public const int NormalTipsText = 11;

		// Token: 0x04027596 RID: 161174
		public const int HardStarText = 12;

		// Token: 0x04027597 RID: 161175
		public const int NormalBtn = 13;

		// Token: 0x04027598 RID: 161176
		public const int HardBtn = 14;

		// Token: 0x04027599 RID: 161177
		public const int HardLevelRedDotItem = 15;

		// Token: 0x0402759A RID: 161178
		public const int NormalLevelRedDotItem = 16;
	}
}
