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

// Token: 0x02002C0E RID: 11278
[NullableContext(2)]
[Nullable(0)]
public class TowerVariationView : UiTickViewBase
{
	// Token: 0x060176A8 RID: 95912 RVA: 0x005F6971 File Offset: 0x005F4B71
	[NullableContext(1)]
	public TowerVariationView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x060176A9 RID: 95913 RVA: 0x005F698C File Offset: 0x005F4B8C
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

	// Token: 0x060176AA RID: 95914 RVA: 0x005F6BE8 File Offset: 0x005F4DE8
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnTowerRewardReceived, new Action(this.RefreshRewardProgress));
		EventSystem.Instance.Add(EEventName.OnTowerReviewGoToReward, new Action(this.OnTowerReviewGoToReward));
	}

	// Token: 0x060176AB RID: 95915 RVA: 0x005F6C22 File Offset: 0x005F4E22
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnTowerRewardReceived, new Action(this.RefreshRewardProgress));
		EventSystem.Instance.Remove(EEventName.OnTowerReviewGoToReward, new Action(this.OnTowerReviewGoToReward));
	}

	// Token: 0x060176AC RID: 95916 RVA: 0x005F6C5C File Offset: 0x005F4E5C
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

	// Token: 0x060176AD RID: 95917 RVA: 0x005F6CFB File Offset: 0x005F4EFB
	protected override void OnBeforeDestroy()
	{
		this.TitleItem.Destroy(null);
		this.TitleItem = null;
		InstanceDungeonEntranceController.Instance.RestoreDungeonEntranceEntity();
	}

	// Token: 0x060176AE RID: 95918 RVA: 0x005F6D1C File Offset: 0x005F4F1C
	private UniTask BackToBattleView()
	{
		TowerVariationView.<BackToBattleView>d__13 <BackToBattleView>d__;
		<BackToBattleView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<BackToBattleView>d__.<>4__this = this;
		<BackToBattleView>d__.<>1__state = -1;
		<BackToBattleView>d__.<>t__builder.Start<TowerVariationView.<BackToBattleView>d__13>(ref <BackToBattleView>d__);
		return <BackToBattleView>d__.<>t__builder.Task;
	}

	// Token: 0x060176AF RID: 95919 RVA: 0x005F6D60 File Offset: 0x005F4F60
	protected override UniTask OnBeforeStartAsync()
	{
		TowerVariationView.<OnBeforeStartAsync>d__14 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<TowerVariationView.<OnBeforeStartAsync>d__14>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060176B0 RID: 95920 RVA: 0x005F6DA4 File Offset: 0x005F4FA4
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

	// Token: 0x060176B1 RID: 95921 RVA: 0x005F6EE0 File Offset: 0x005F50E0
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

	// Token: 0x060176B2 RID: 95922 RVA: 0x005F7004 File Offset: 0x005F5204
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

	// Token: 0x060176B3 RID: 95923 RVA: 0x005F7035 File Offset: 0x005F5235
	protected override void OnBeforeHide()
	{
		RedDotController.Instance.UnBindGivenUi(ERedDotName.TowerReward, base.GetItem(5), 0);
		RedDotController.Instance.UnBindGivenUi(ERedDotName.TowerRewardByDifficulties, base.GetItem(8), 5);
	}

	// Token: 0x060176B4 RID: 95924 RVA: 0x005F7060 File Offset: 0x005F5260
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

	// Token: 0x060176B5 RID: 95925 RVA: 0x005F70DD File Offset: 0x005F52DD
	private void OnTowerReviewGoToReward()
	{
		this.OnClickRewardBtn();
	}

	// Token: 0x060176B6 RID: 95926 RVA: 0x005F70E8 File Offset: 0x005F52E8
	private void OnClickChangeTowerBtn()
	{
		if (UiManager.Instance.GetViewByName(EUiViewName.TowerNormalView) != null)
		{
			base.CloseMe(null);
			return;
		}
		UiManager.Instance.OpenViewAsync(EUiViewName.TowerNormalView, null, null);
	}

	// Token: 0x060176B7 RID: 95927 RVA: 0x005F7128 File Offset: 0x005F5328
	private void OnClickShopBtn()
	{
		PayShopController.Instance.OpenPayShopViewWithTab(PayShopDefine.EPayShopTabType.ActivityShop, 0);
	}

	// Token: 0x060176B8 RID: 95928 RVA: 0x005F7136 File Offset: 0x005F5336
	protected override void OnTick(float deltaTime)
	{
		if (this.NeedTick)
		{
			this.RefreshCountDown();
		}
	}

	// Token: 0x060176B9 RID: 95929 RVA: 0x005F7148 File Offset: 0x005F5348
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

	// Token: 0x060176BA RID: 95930 RVA: 0x005F71E0 File Offset: 0x005F53E0
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

	// Token: 0x0400AF1C RID: 44828
	private bool IsHighRiskClear;

	// Token: 0x0400AF1D RID: 44829
	private bool NeedTick = true;

	// Token: 0x0400AF1E RID: 44830
	private string CountDownString;

	// Token: 0x0400AF1F RID: 44831
	private TowerTitleItem TitleItem;

	// Token: 0x0400AF20 RID: 44832
	private ShareBtnItem ShareBtnItem;

	// Token: 0x0400AF21 RID: 44833
	[Nullable(1)]
	private readonly List<TowerAreaItem> TowerAreaList = new List<TowerAreaItem>();

	// Token: 0x020091DA RID: 37338
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x0402F307 RID: 193287
		TitleItem,
		// Token: 0x0402F308 RID: 193288
		TowerLayout,
		// Token: 0x0402F309 RID: 193289
		RewardBtn,
		// Token: 0x0402F30A RID: 193290
		ChangeTowerBtn,
		// Token: 0x0402F30B RID: 193291
		RemainTimeText,
		// Token: 0x0402F30C RID: 193292
		RedDotItem,
		// Token: 0x0402F30D RID: 193293
		RewardProgressSprite,
		// Token: 0x0402F30E RID: 193294
		ShopBtn,
		// Token: 0x0402F30F RID: 193295
		LowAndHighRiskRedDotItem,
		// Token: 0x0402F310 RID: 193296
		RewardShowItem,
		// Token: 0x0402F311 RID: 193297
		RewardDownItem,
		// Token: 0x0402F312 RID: 193298
		RewardDownBgItem,
		// Token: 0x0402F313 RID: 193299
		ShareBtnItem
	}
}
