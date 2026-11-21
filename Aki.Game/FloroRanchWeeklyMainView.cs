using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200103B RID: 4155
[NullableContext(1)]
[Nullable(0)]
public class FloroRanchWeeklyMainView : UiViewBase
{
	// Token: 0x0600A568 RID: 42344 RVA: 0x0030A4FF File Offset: 0x003086FF
	public FloroRanchWeeklyMainView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x0600A569 RID: 42345 RVA: 0x0030A520 File Offset: 0x00308720
	protected unsafe override void OnRegisterComponent()
	{
		int num = 24;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(USpineSkeletonAnimationComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(16, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(17, typeof(UUIGridLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(18, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(19, typeof(UUIHorizontalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(20, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(21, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(22, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(23, typeof(UUIText));
		this.ComponentRegisterInfos = list;
		num2 = 4;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(2, new Action(this.OnStartBtnClick));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(1, new Action(this.OnCloseBtnClick));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(12, new Action(this.OnArchiveBtnClick));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(11, new Action(this.OnSaveBtnClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600A56A RID: 42346 RVA: 0x0030A918 File Offset: 0x00308B18
	protected override UniTask OnBeforeStartAsync()
	{
		FloroRanchWeeklyMainView.<OnBeforeStartAsync>d__12 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<FloroRanchWeeklyMainView.<OnBeforeStartAsync>d__12>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600A56B RID: 42347 RVA: 0x0030A95B File Offset: 0x00308B5B
	protected override void OnBeforeDestroy()
	{
		TermExplanationController.Instance.UnRegisterTextHyperlink(base.GetText(16));
		this.IsRequesting = false;
	}

	// Token: 0x0600A56C RID: 42348 RVA: 0x0030A978 File Offset: 0x00308B78
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<EFloroRanchActivityDataType, int>(EEventName.FloroRanchSkillChange, new Action<EFloroRanchActivityDataType, int>(this.OnSkillChange));
		EventSystem.Instance.Add<EFloroRanchActivityDataType>(EEventName.FloroRanchSkillRedDotRefresh, new Action<EFloroRanchActivityDataType>(this.OnSkillRedDotRefresh));
		EventSystem.Instance.Add(EEventName.FloroRanchSettlement, new Action(this.OnFloroRanchSettlement));
		EventSystem.Instance.Add(EEventName.FloroRanchSubInsHistoryUpdate, new Action(this.OnSubInsHistoryUpdate));
	}

	// Token: 0x0600A56D RID: 42349 RVA: 0x0030A9F8 File Offset: 0x00308BF8
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.FloroRanchSkillChange, new Action<EFloroRanchActivityDataType, int>(this.OnSkillChange));
		EventSystem.Instance.Remove(EEventName.FloroRanchSkillRedDotRefresh, new Action<EFloroRanchActivityDataType>(this.OnSkillRedDotRefresh));
		EventSystem.Instance.Remove(EEventName.FloroRanchSettlement, new Action(this.OnFloroRanchSettlement));
		EventSystem.Instance.Remove(EEventName.FloroRanchSubInsHistoryUpdate, new Action(this.OnSubInsHistoryUpdate));
	}

	// Token: 0x0600A56E RID: 42350 RVA: 0x0030AA75 File Offset: 0x00308C75
	protected override void OnBeforeShow()
	{
		this.RefreshStartButton();
		this.RefreshWeeklyScore();
		this.RefreshHistoryPanel();
	}

	// Token: 0x0600A56F RID: 42351 RVA: 0x0030AA89 File Offset: 0x00308C89
	protected override void OnBeforeHide()
	{
		this.IsRequesting = false;
	}

	// Token: 0x0600A570 RID: 42352 RVA: 0x0030AA92 File Offset: 0x00308C92
	private FloroRanchHandBookSmallSlotItem CreateRecommendItem()
	{
		FloroRanchHandBookSmallSlotItem floroRanchHandBookSmallSlotItem = new FloroRanchHandBookSmallSlotItem();
		floroRanchHandBookSmallSlotItem.SetActivityDataType(EFloroRanchActivityDataType.Weekly);
		floroRanchHandBookSmallSlotItem.BindClickCallback(new Action<FloroRanchHandBookSmallSlotItem>(this.OnRecommendItemClick));
		return floroRanchHandBookSmallSlotItem;
	}

	// Token: 0x0600A571 RID: 42353 RVA: 0x0030AAB4 File Offset: 0x00308CB4
	private void OnRecommendItemClick(FloroRanchHandBookSmallSlotItem item)
	{
		int num = this.RecommendLayout.GetLayoutItemList().IndexOf(item);
		if (num < 0 || this.RecommendUnlockDataList.Count <= 0)
		{
			return;
		}
		FloroRanchRecommendTipViewParam floroRanchRecommendTipViewParam = new FloroRanchRecommendTipViewParam
		{
			RefreshDataList = new List<FloroRanchUnlockDataBase>(this.RecommendUnlockDataList),
			DefaultIndex = num,
			ActivityDataType = EFloroRanchActivityDataType.Weekly
		};
		UiManager.Instance.OpenView(EUiViewName.FloroRanchRecommendTipView, floroRanchRecommendTipViewParam, null);
		foreach (FloroRanchHandBookSmallSlotItem floroRanchHandBookSmallSlotItem in this.RecommendLayout.GetLayoutItemList())
		{
			floroRanchHandBookSmallSlotItem.OnDeselected(true);
		}
	}

	// Token: 0x0600A572 RID: 42354 RVA: 0x0030AB74 File Offset: 0x00308D74
	private FloroRanchRaceItem CreateRaceItem()
	{
		return new FloroRanchRaceItem();
	}

	// Token: 0x0600A573 RID: 42355 RVA: 0x0030AB7C File Offset: 0x00308D7C
	private UniTask RefreshRightInfoPanel()
	{
		FloroRanchWeeklyMainView.<RefreshRightInfoPanel>d__21 <RefreshRightInfoPanel>d__;
		<RefreshRightInfoPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshRightInfoPanel>d__.<>4__this = this;
		<RefreshRightInfoPanel>d__.<>1__state = -1;
		<RefreshRightInfoPanel>d__.<>t__builder.Start<FloroRanchWeeklyMainView.<RefreshRightInfoPanel>d__21>(ref <RefreshRightInfoPanel>d__);
		return <RefreshRightInfoPanel>d__.<>t__builder.Task;
	}

	// Token: 0x0600A574 RID: 42356 RVA: 0x0030ABC0 File Offset: 0x00308DC0
	private void RefreshHistoryPanel()
	{
		FloroRanchSubDungeonData floroRanchSubDungeonData = this.ActivityData.GetFloroRanchSubDungeonData(this.SubDungeonId);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(5), "FloroRanchDayNum", new <>z__ReadOnlySingleElementList<object>(floroRanchSubDungeonData.MaxDays));
		string coinText = FloroRanchModel.Instance.GetCoinText(floroRanchSubDungeonData.MaxCoin);
		UUIText text = base.GetText(6);
		if (text != null)
		{
			text.SetText(coinText, true);
		}
		UUIItem item = base.GetItem(4);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(floroRanchSubDungeonData.HasHistory);
	}

	// Token: 0x0600A575 RID: 42357 RVA: 0x0030AC41 File Offset: 0x00308E41
	private void RefreshSkillItem(int skillId)
	{
		this.SkillId = skillId;
		FloroRanchSkillItem skillItem = this.SkillItem;
		if (skillItem == null)
		{
			return;
		}
		skillItem.Refresh(skillId);
	}

	// Token: 0x0600A576 RID: 42358 RVA: 0x0030AC5B File Offset: 0x00308E5B
	private void OnSkillChange(EFloroRanchActivityDataType activityDataType, int skillId)
	{
		if (activityDataType != EFloroRanchActivityDataType.Weekly)
		{
			return;
		}
		this.RefreshSkillItem(skillId);
	}

	// Token: 0x0600A577 RID: 42359 RVA: 0x0030AC69 File Offset: 0x00308E69
	private void OnSkillRedDotRefresh(EFloroRanchActivityDataType activityDataType)
	{
		if (activityDataType != EFloroRanchActivityDataType.Weekly)
		{
			return;
		}
		FloroRanchSkillItem skillItem = this.SkillItem;
		if (skillItem == null)
		{
			return;
		}
		skillItem.RefreshRedDot();
	}

	// Token: 0x0600A578 RID: 42360 RVA: 0x0030AC80 File Offset: 0x00308E80
	private void OnFloroRanchSettlement()
	{
		this.RefreshStartButton();
		this.RefreshWeeklyScore();
		this.RefreshHistoryPanel();
	}

	// Token: 0x0600A579 RID: 42361 RVA: 0x0030AC94 File Offset: 0x00308E94
	private void OnSubInsHistoryUpdate()
	{
		this.RefreshHistoryPanel();
	}

	// Token: 0x0600A57A RID: 42362 RVA: 0x0030AC9C File Offset: 0x00308E9C
	private void RefreshStartButton()
	{
		bool flag = this.ActivityData.HasUnFinishedSubIns();
		base.GetButton(2).RootUIComp.Get().SetUIActive(!flag);
		base.GetButton(11).RootUIComp.Get().SetUIActive(flag);
	}

	// Token: 0x0600A57B RID: 42363 RVA: 0x0030ACF0 File Offset: 0x00308EF0
	private void RefreshWeeklyScore()
	{
		int weeklyCurrentScore = WeeklyChallengeModel.Instance.WeeklyCurrentScore;
		int weeklyMaxScore = WeeklyChallengeModel.Instance.WeeklyMaxScore;
		bool flag = weeklyCurrentScore >= weeklyMaxScore;
		base.GetText(23).SetUIActive(flag);
		if (!flag)
		{
			base.GetText(21).SetText(WeeklyChallengeModel.Instance.WeeklyCurrentScore.ToString(), true);
			base.GetText(22).SetText("/" + WeeklyChallengeModel.Instance.WeeklyMaxScore.ToString(), true);
		}
		else
		{
			base.GetText(23).ShowTextNew("WeeklyFarm_ScoreMax");
		}
		base.GetText(21).SetUIActive(!flag);
		base.GetText(22).SetUIActive(!flag);
	}

	// Token: 0x0600A57C RID: 42364 RVA: 0x0030ADAC File Offset: 0x00308FAC
	private void OnGameNewStart()
	{
		if (this.IsRequesting)
		{
			return;
		}
		if (GameModeModel.Instance.IsMulti)
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("Farm_ConnectBan", Array.Empty<object>());
			return;
		}
		if (this.RaceIds.Contains(0))
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("Farm_ChooseRace", Array.Empty<object>());
			return;
		}
		if (this.SkillId == 0)
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("Farm_ChooseSkill", Array.Empty<object>());
			return;
		}
		this.IsRequesting = true;
		UUIButtonComponent button = base.GetButton(2);
		if (button != null)
		{
			UUIItem uuiitem = button.RootUIComp.Get();
			if (uuiitem != null)
			{
				uuiitem.SetUIActive(false);
			}
		}
		FloroRanchController.Instance.SendFloroRanchStartPlayRequest(this.ActivityData.Id, this.SubDungeonId, this.RaceIds.ToArray(), new int?(this.SkillId), delegate(FloroRanchStartPlayResponse response)
		{
			if (response == null)
			{
				this.IsRequesting = false;
				UUIButtonComponent button2 = base.GetButton(2);
				if (button2 == null)
				{
					return;
				}
				UUIItem uuiitem2 = button2.RootUIComp.Get();
				if (uuiitem2 == null)
				{
					return;
				}
				uuiitem2.SetUIActive(true);
			}
		});
	}

	// Token: 0x0600A57D RID: 42365 RVA: 0x0030AE90 File Offset: 0x00309090
	private void OnSaveBtnClick()
	{
		if (this.IsRequesting)
		{
			return;
		}
		if (GameModeModel.Instance.IsMulti)
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("Farm_ConnectBan", Array.Empty<object>());
			return;
		}
		if (!this.ActivityData.HasUnFinishedSubIns())
		{
			return;
		}
		this.IsRequesting = true;
		FloroRanchSubDungeonData subDungeonData = this.ActivityData.GetUnFinishedSubDungeonData();
		ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.FloroRanchWeeklyArchiveConfirm);
		confirmBoxDataNew.SetTextArgs(new string[]
		{
			this.ActivityData.GetSavedStage().ToString()
		});
		confirmBoxDataNew.IsEscViewTriggerCallBack = false;
		bool isConfirmed = false;
		Action<FloroRanchSettleResponse> <>9__3;
		confirmBoxDataNew.FunctionMap[1] = delegate()
		{
			isConfirmed = true;
			FloroRanchController instance = FloroRanchController.Instance;
			int id = this.ActivityData.Id;
			int id2 = subDungeonData.Id;
			Action<FloroRanchSettleResponse> callback;
			if ((callback = <>9__3) == null)
			{
				callback = (<>9__3 = delegate(FloroRanchSettleResponse response)
				{
					this.IsRequesting = false;
					if (response != null)
					{
						this.OnGameNewStart();
					}
				});
			}
			instance.SendFloroRanchAbandonArchiveRequest(id, id2, callback);
		};
		Action<FloroRanchStartPlayResponse> <>9__4;
		confirmBoxDataNew.FunctionMap[2] = delegate()
		{
			isConfirmed = true;
			FloroRanchController instance = FloroRanchController.Instance;
			int id = this.ActivityData.Id;
			int id2 = subDungeonData.Id;
			int[] races = null;
			int? skillId = null;
			Action<FloroRanchStartPlayResponse> callback;
			if ((callback = <>9__4) == null)
			{
				callback = (<>9__4 = delegate(FloroRanchStartPlayResponse response)
				{
					if (response == null)
					{
						this.IsRequesting = false;
					}
				});
			}
			instance.SendFloroRanchStartPlayRequest(id, id2, races, skillId, callback);
		};
		confirmBoxDataNew.DestroyFunction = delegate()
		{
			if (!isConfirmed)
			{
				this.IsRequesting = false;
			}
		};
		ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
	}

	// Token: 0x0600A57E RID: 42366 RVA: 0x0030AF83 File Offset: 0x00309183
	private void OnCloseBtnClick()
	{
		if (this.IsRequesting)
		{
			return;
		}
		base.CloseMe(null);
	}

	// Token: 0x0600A57F RID: 42367 RVA: 0x0030AF95 File Offset: 0x00309195
	private void OnStartBtnClick()
	{
		this.OnGameNewStart();
	}

	// Token: 0x0600A580 RID: 42368 RVA: 0x0030AFA0 File Offset: 0x003091A0
	private void OnArchiveBtnClick()
	{
		FloroRanchHandBookViewParam floroRanchHandBookViewParam = new FloroRanchHandBookViewParam
		{
			ActivityDataType = EFloroRanchActivityDataType.Weekly
		};
		UiManager.Instance.OpenView(EUiViewName.FloroRanchHandBookView, floroRanchHandBookViewParam, null);
	}

	// Token: 0x040060E3 RID: 24803
	[Nullable(2)]
	private global::FloroRanchActivityData ActivityData;

	// Token: 0x040060E4 RID: 24804
	private int SubDungeonId;

	// Token: 0x040060E5 RID: 24805
	private int SkillId;

	// Token: 0x040060E6 RID: 24806
	private List<int> RaceIds = new List<int>();

	// Token: 0x040060E7 RID: 24807
	[Nullable(2)]
	private FloroRanchSkillItem SkillItem;

	// Token: 0x040060E8 RID: 24808
	private GenericLayout<FloroRanchHandBookSmallSlotItem, FloroRanchUnlockDataBase> RecommendLayout;

	// Token: 0x040060E9 RID: 24809
	private readonly List<FloroRanchUnlockDataBase> RecommendUnlockDataList = new List<FloroRanchUnlockDataBase>();

	// Token: 0x040060EA RID: 24810
	private GenericLayout<FloroRanchRaceItem, FloroRanchSelectRaceData> RaceLayout;

	// Token: 0x040060EB RID: 24811
	private bool IsRequesting;

	// Token: 0x0200728B RID: 29323
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x040254AC RID: 152748
		public const int TextTitle = 0;

		// Token: 0x040254AD RID: 152749
		public const int BtnClose = 1;

		// Token: 0x040254AE RID: 152750
		public const int BtnStart = 2;

		// Token: 0x040254AF RID: 152751
		public const int ItemRightPanel = 3;

		// Token: 0x040254B0 RID: 152752
		public const int ItemHistoryPanel = 4;

		// Token: 0x040254B1 RID: 152753
		public const int TextHistoryDay = 5;

		// Token: 0x040254B2 RID: 152754
		public const int TextHistoryCoin = 6;

		// Token: 0x040254B3 RID: 152755
		public const int SpineRole = 7;

		// Token: 0x040254B4 RID: 152756
		public const int ItemSKill = 8;

		// Token: 0x040254B5 RID: 152757
		public const int ItemLockPanel = 9;

		// Token: 0x040254B6 RID: 152758
		public const int ItemQuest = 10;

		// Token: 0x040254B7 RID: 152759
		public const int BtnSave = 11;

		// Token: 0x040254B8 RID: 152760
		public const int BtnArchive = 12;

		// Token: 0x040254B9 RID: 152761
		public const int TextInsName = 13;

		// Token: 0x040254BA RID: 152762
		public const int TextTarget = 14;

		// Token: 0x040254BB RID: 152763
		public const int ItemDescRoot = 15;

		// Token: 0x040254BC RID: 152764
		public const int TextDesc = 16;

		// Token: 0x040254BD RID: 152765
		public const int GridLayoutRecommend = 17;

		// Token: 0x040254BE RID: 152766
		public const int ItemRecommend = 18;

		// Token: 0x040254BF RID: 152767
		public const int HorizontalLayoutRace = 19;

		// Token: 0x040254C0 RID: 152768
		public const int ItemRace = 20;

		// Token: 0x040254C1 RID: 152769
		public const int TextCurWeeklyScore = 21;

		// Token: 0x040254C2 RID: 152770
		public const int TextMaxWeeklyScore = 22;

		// Token: 0x040254C3 RID: 152771
		public const int TextWeekFinish = 23;
	}
}
