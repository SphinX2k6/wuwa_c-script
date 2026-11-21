using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.AdventureGuide;
using CSharpScript.Game.Module.InstanceDungeon;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002189 RID: 8585
[NullableContext(2)]
[Nullable(0)]
public class TowerVariationView : UiTickViewBase
{
	// Token: 0x060150D9 RID: 86233 RVA: 0x00623495 File Offset: 0x00621695
	[NullableContext(1)]
	public TowerVariationView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x060150DA RID: 86234 RVA: 0x006234B0 File Offset: 0x006216B0
	protected unsafe override void OnRegisterComponent()
	{
		int num = 13;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIHorizontalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 3;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(2, new Action(this.OnClickRewardBtn));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(3, new Action(this.OnClickChangeTowerBtn));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(7, new Action(this.OnClickShopBtn));
		this.BtnBindInfo = list2;
	}

	// Token: 0x060150DB RID: 86235 RVA: 0x0062370C File Offset: 0x0062190C
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnTowerRewardReceived, new Action(this.RefreshRewardProgress));
		EventSystem.Instance.Add(EEventName.OnTowerReviewGoToReward, new Action(this.OnTowerReviewGoToReward));
	}

	// Token: 0x060150DC RID: 86236 RVA: 0x00623746 File Offset: 0x00621946
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnTowerRewardReceived, new Action(this.RefreshRewardProgress));
		EventSystem.Instance.Remove(EEventName.OnTowerReviewGoToReward, new Action(this.OnTowerReviewGoToReward));
	}

	// Token: 0x060150DD RID: 86237 RVA: 0x00623780 File Offset: 0x00621980
	protected override void OnBeforeShow()
	{
		TowerModel.Instance.CurrentSelectDifficulties = 3;
		RedDotController.Instance.BindRedDot(ERedDotName.TowerReward, base.GetItem(5), null, 0);
		RedDotController.Instance.BindRedDot(ERedDotName.TowerRewardByDifficulties, base.GetItem(8), null, 5);
		this.RefreshRewardProgress();
		EventSystem.Instance.Emit(EEventName.RedDotTowerReward);
		EventSystem.Instance.Emit<int>(EEventName.RedDotTowerRewardByDifficulties, 5);
		bool flag = !TowerModel.Instance.GetOverLockHasShow();
		bool difficultyIsClear = TowerModel.Instance.GetDifficultyIsClear(3);
		if (flag && difficultyIsClear)
		{
			UUIItem item = base.GetItem(8);
			if (item != null)
			{
				item.SetUIActive(true);
			}
		}
		this.UpdateShareBtnItem();
	}

	// Token: 0x060150DE RID: 86238 RVA: 0x0062381F File Offset: 0x00621A1F
	protected override void OnBeforeDestroy()
	{
		this.TitleItem.Destroy(null);
		this.TitleItem = null;
		InstanceDungeonEntranceController.Instance.RestoreDungeonEntranceEntity();
	}

	// Token: 0x060150DF RID: 86239 RVA: 0x00623840 File Offset: 0x00621A40
	private UniTask BackToBattleView()
	{
		TowerVariationView.<BackToBattleView>d__13 <BackToBattleView>d__;
		<BackToBattleView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<BackToBattleView>d__.<>4__this = this;
		<BackToBattleView>d__.<>1__state = -1;
		<BackToBattleView>d__.<>t__builder.Start<TowerVariationView.<BackToBattleView>d__13>(ref <BackToBattleView>d__);
		return <BackToBattleView>d__.<>t__builder.Task;
	}

	// Token: 0x060150E0 RID: 86240 RVA: 0x00623884 File Offset: 0x00621A84
	protected override UniTask OnBeforeStartAsync()
	{
		TowerVariationView.<OnBeforeStartAsync>d__14 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<TowerVariationView.<OnBeforeStartAsync>d__14>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060150E1 RID: 86241 RVA: 0x006238C8 File Offset: 0x00621AC8
	protected override void OnStart()
	{
		TowerModel.Instance.SetLoopTowerIsClickSeason(TowerModel.Instance.CurrentSeason);
		ActivityLoopTowerData activityLoopTowerData = ActivityModel.Instance.GetActivityById(100300002) as ActivityLoopTowerData;
		bool hasRedPointAfter = activityLoopTowerData != null && activityLoopTowerData.RedPointShowState;
		AdventureGuideModel instance = AdventureGuideModel.Instance;
		if (instance != null)
		{
			instance.ReportPeriodicActivityRedClear(EDungeonSubType.LoopTower, hasRedPointAfter);
		}
		if (TowerModel.Instance.CheckInTower())
		{
			TowerController.Instance.ClearAllHatredInTower();
		}
		this.IsHighRiskClear = TowerModel.Instance.GetDifficultyIsClear(2);
		TowerModel.Instance.CurrentSelectDifficulties = 3;
		this.TitleItem = new TowerTitleItem(base.GetItem(0), delegate()
		{
			if (TowerModel.Instance.CheckInTower())
			{
				ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.LeaveTowerOnTowerView);
				confirmBoxDataNew.FunctionMap.Add(2, delegate
				{
					TowerController.Instance.LeaveTower();
				});
				ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
				return;
			}
			this.BackToBattleView();
		});
		this.TitleItem.RefreshText("InstanceDungeonTitle_31_CommonText", Array.Empty<string>());
		CommonDefine.ICountDown seasonCountDownData = TowerModel.Instance.GetSeasonCountDownData();
		base.GetText(4).SetText(seasonCountDownData.CountDownText, true);
		EventSystem.Instance.Emit<int>(EEventName.RedDotTowerRewardByDifficulties, 3);
		TowerModel.Instance.CurrentTowerLock = !this.IsHighRiskClear;
		int[] difficultyAllAreaFirstFloor = TowerModel.Instance.GetDifficultyAllAreaFirstFloor(3, false);
		for (int i = 0; i < this.TowerAreaList.Count; i++)
		{
			this.TowerAreaList[i].Refresh(difficultyAllAreaFirstFloor[i], false, i);
		}
		this.AddHomeBtnExtraCallback();
	}

	// Token: 0x060150E2 RID: 86242 RVA: 0x00623A04 File Offset: 0x00621C04
	private void UpdateShareBtnItem()
	{
		if (this.ShareBtnItem == null)
		{
			return;
		}
		int num = 0;
		int[] array = new int[]
		{
			0,
			2
		};
		int[] difficultyAllAreaFirstFloor = TowerModel.Instance.GetDifficultyAllAreaFirstFloor(3, false);
		foreach (int num2 in array)
		{
			if (difficultyAllAreaFirstFloor.Length > num2)
			{
				TowerConfig? towerInfo = TowerClimbConfig.Instance.GetTowerInfo(difficultyAllAreaFirstFloor[num2]);
				int areaAllStars = TowerModel.Instance.GetAreaAllStars(towerInfo.Value.Difficulty, towerInfo.Value.AreaNum);
				num = ((TowerModel.Instance.GetAreaStars(towerInfo.Value.Difficulty, towerInfo.Value.AreaNum, false) >= areaAllStars) ? (num + 1) : num);
			}
		}
		bool flag = num >= array.Length;
		ShareBtnItem shareBtnItem = this.ShareBtnItem;
		if (shareBtnItem != null)
		{
			shareBtnItem.SetUiActive(flag);
		}
		if (flag)
		{
			this.ShareBtnItem.SetShareActionId(EShareActionId.TowerVariation);
			this.ShareBtnItem.SetClickCallBack(delegate
			{
				PhotoSaveViewParam param = new PhotoSaveViewParam
				{
					ScreenShot = false,
					IsHiddenBattleView = false,
					ShareId = 14
				};
				UiManager.Instance.OpenView(EUiViewName.PhotoSaveView, param, null);
			});
		}
	}

	// Token: 0x060150E3 RID: 86243 RVA: 0x00623B28 File Offset: 0x00621D28
	private void AddHomeBtnExtraCallback()
	{
		UiBehaviourHomeBtn uiBehaviourHomeBtn = this.UiBehaviourHomeBtn;
		if (uiBehaviourHomeBtn == null)
		{
			return;
		}
		uiBehaviourHomeBtn.AddExtraAsyncCallback(delegate
		{
			TowerVariationView.<>c.<<AddHomeBtnExtraCallback>b__17_0>d <<AddHomeBtnExtraCallback>b__17_0>d;
			<<AddHomeBtnExtraCallback>b__17_0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<<AddHomeBtnExtraCallback>b__17_0>d.<>1__state = -1;
			<<AddHomeBtnExtraCallback>b__17_0>d.<>t__builder.Start<TowerVariationView.<>c.<<AddHomeBtnExtraCallback>b__17_0>d>(ref <<AddHomeBtnExtraCallback>b__17_0>d);
			return <<AddHomeBtnExtraCallback>b__17_0>d.<>t__builder.Task;
		});
	}

	// Token: 0x060150E4 RID: 86244 RVA: 0x00623B59 File Offset: 0x00621D59
	protected override void OnBeforeHide()
	{
		RedDotController.Instance.UnBindGivenUi(ERedDotName.TowerReward, base.GetItem(5), 0);
		RedDotController.Instance.UnBindGivenUi(ERedDotName.TowerRewardByDifficulties, base.GetItem(8), 5);
	}

	// Token: 0x060150E5 RID: 86245 RVA: 0x00623B84 File Offset: 0x00621D84
	private void OnClickRewardBtn()
	{
		TowerModel instance = TowerModel.Instance;
		float? num = (instance != null) ? new float?(instance.GetDifficultyRewardProgress(TowerModel.Instance.CurrentSelectDifficulties)) : null;
		float num2 = (float)1;
		if (num.GetValueOrDefault() == num2 & num != null)
		{
			ScrollingTipsController.Instance.ShowTipsById("HaveAllReward", Array.Empty<object>());
		}
		UiManager.Instance.OpenView(EUiViewName.TowerRewardView, null, delegate(bool success, int viewId)
		{
			base.AddChildViewById(viewId);
		});
	}

	// Token: 0x060150E6 RID: 86246 RVA: 0x00623C01 File Offset: 0x00621E01
	private void OnTowerReviewGoToReward()
	{
		this.OnClickRewardBtn();
	}

	// Token: 0x060150E7 RID: 86247 RVA: 0x00623C0C File Offset: 0x00621E0C
	private void OnClickChangeTowerBtn()
	{
		if (UiManager.Instance.GetViewByName(EUiViewName.TowerNormalView) != null)
		{
			base.CloseMe(null);
			return;
		}
		UiManager.Instance.OpenViewAsync(EUiViewName.TowerNormalView, null, null);
	}

	// Token: 0x060150E8 RID: 86248 RVA: 0x00623C4C File Offset: 0x00621E4C
	private void OnClickShopBtn()
	{
		PayShopController.Instance.OpenPayShopViewWithTab(PayShopDefine.EPayShopTabType.ActivityShop, 0);
	}

	// Token: 0x060150E9 RID: 86249 RVA: 0x00623C5A File Offset: 0x00621E5A
	protected override void OnTick(float deltaTime)
	{
		if (this.NeedTick)
		{
			this.RefreshCountDown();
		}
	}

	// Token: 0x060150EA RID: 86250 RVA: 0x00623C6C File Offset: 0x00621E6C
	private void RefreshCountDown()
	{
		string countDownText = TowerModel.Instance.GetSeasonCountDownData().CountDownText;
		if (this.CountDownString != countDownText)
		{
			this.CountDownString = countDownText;
			base.GetText(4).SetText(countDownText, true);
		}
		if ((double)TowerModel.Instance.TowerEndTime.GetValueOrDefault() - TimeUtil.Instance.GetServerTime() <= 1.0)
		{
			this.NeedTick = false;
			UiManager.Instance.ResetToBattleView(delegate(bool _)
			{
				ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.CycleTowerSeasonRefresh);
				Action value = delegate()
				{
					if (TowerModel.Instance.CheckInTower())
					{
						InstanceDungeonEntranceController.Instance.LeaveInstanceDungeonRequest(LeaveInstWay.Default);
					}
				};
				confirmBoxDataNew.FunctionMap.Add(1, value);
				confirmBoxDataNew.FunctionMap.Add(2, value);
				ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
			});
		}
	}

	// Token: 0x060150EB RID: 86251 RVA: 0x00623D04 File Offset: 0x00621F04
	private void RefreshRewardProgress()
	{
		TowerModel instance = TowerModel.Instance;
		float? num = (instance != null) ? new float?(instance.GetDifficultyRewardProgress(3)) : null;
		UUISprite sprite = base.GetSprite(6);
		if (sprite != null)
		{
			sprite.SetFillAmount(num.Value);
		}
		float? num2 = num;
		float num3 = (float)1;
		if (num2.GetValueOrDefault() == num3 & num2 != null)
		{
			UUIItem item = base.GetItem(10);
			if (item != null)
			{
				item.SetUIActive(true);
			}
			UUIItem item2 = base.GetItem(11);
			if (item2 == null)
			{
				return;
			}
			item2.SetUIActive(true);
			return;
		}
		else
		{
			UUIItem item3 = base.GetItem(10);
			if (item3 != null)
			{
				item3.SetUIActive(false);
			}
			UUIItem item4 = base.GetItem(11);
			if (item4 == null)
			{
				return;
			}
			item4.SetUIActive(false);
			return;
		}
	}

	// Token: 0x0400B321 RID: 45857
	private bool IsHighRiskClear;

	// Token: 0x0400B322 RID: 45858
	private bool NeedTick = true;

	// Token: 0x0400B323 RID: 45859
	private string CountDownString;

	// Token: 0x0400B324 RID: 45860
	private TowerTitleItem TitleItem;

	// Token: 0x0400B325 RID: 45861
	private ShareBtnItem ShareBtnItem;

	// Token: 0x0400B326 RID: 45862
	[Nullable(1)]
	private readonly List<TowerAreaItem> TowerAreaList = new List<TowerAreaItem>();

	// Token: 0x0200841D RID: 33821
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x0402AA08 RID: 174600
		TitleItem,
		// Token: 0x0402AA09 RID: 174601
		TowerLayout,
		// Token: 0x0402AA0A RID: 174602
		RewardBtn,
		// Token: 0x0402AA0B RID: 174603
		ChangeTowerBtn,
		// Token: 0x0402AA0C RID: 174604
		RemainTimeText,
		// Token: 0x0402AA0D RID: 174605
		RedDotItem,
		// Token: 0x0402AA0E RID: 174606
		RewardProgressSprite,
		// Token: 0x0402AA0F RID: 174607
		ShopBtn,
		// Token: 0x0402AA10 RID: 174608
		LowAndHighRiskRedDotItem,
		// Token: 0x0402AA11 RID: 174609
		RewardShowItem,
		// Token: 0x0402AA12 RID: 174610
		RewardDownItem,
		// Token: 0x0402AA13 RID: 174611
		RewardDownBgItem,
		// Token: 0x0402AA14 RID: 174612
		ShareBtnItem
	}
}
