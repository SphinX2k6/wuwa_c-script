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

// Token: 0x02001B7C RID: 7036
[NullableContext(1)]
[Nullable(0)]
public class FloroRanchWeeklyMainView : UiViewBase
{
	// Token: 0x0600D157 RID: 53591 RVA: 0x002FF427 File Offset: 0x002FD627
	public FloroRanchWeeklyMainView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x0600D158 RID: 53592 RVA: 0x002FF448 File Offset: 0x002FD648
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

	// Token: 0x0600D159 RID: 53593 RVA: 0x002FF840 File Offset: 0x002FDA40
	protected override UniTask OnBeforeStartAsync()
	{
		FloroRanchWeeklyMainView.<OnBeforeStartAsync>d__12 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<FloroRanchWeeklyMainView.<OnBeforeStartAsync>d__12>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600D15A RID: 53594 RVA: 0x002FF883 File Offset: 0x002FDA83
	protected override void OnBeforeDestroy()
	{
		TermExplanationController.Instance.UnRegisterTextHyperlink(base.GetText(16));
		this.IsRequesting = false;
	}

	// Token: 0x0600D15B RID: 53595 RVA: 0x002FF8A0 File Offset: 0x002FDAA0
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<EFloroRanchActivityDataType, int>(EEventName.FloroRanchSkillChange, new Action<EFloroRanchActivityDataType, int>(this.OnSkillChange));
		EventSystem.Instance.Add<EFloroRanchActivityDataType>(EEventName.FloroRanchSkillRedDotRefresh, new Action<EFloroRanchActivityDataType>(this.OnSkillRedDotRefresh));
		EventSystem.Instance.Add(EEventName.FloroRanchSettlement, new Action(this.OnFloroRanchSettlement));
		EventSystem.Instance.Add(EEventName.FloroRanchSubInsHistoryUpdate, new Action(this.OnSubInsHistoryUpdate));
	}

	// Token: 0x0600D15C RID: 53596 RVA: 0x002FF920 File Offset: 0x002FDB20
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.FloroRanchSkillChange, new Action<EFloroRanchActivityDataType, int>(this.OnSkillChange));
		EventSystem.Instance.Remove(EEventName.FloroRanchSkillRedDotRefresh, new Action<EFloroRanchActivityDataType>(this.OnSkillRedDotRefresh));
		EventSystem.Instance.Remove(EEventName.FloroRanchSettlement, new Action(this.OnFloroRanchSettlement));
		EventSystem.Instance.Remove(EEventName.FloroRanchSubInsHistoryUpdate, new Action(this.OnSubInsHistoryUpdate));
	}

	// Token: 0x0600D15D RID: 53597 RVA: 0x002FF99D File Offset: 0x002FDB9D
	protected override void OnBeforeShow()
	{
		this.RefreshStartButton();
		this.RefreshWeeklyScore();
		this.RefreshHistoryPanel();
	}

	// Token: 0x0600D15E RID: 53598 RVA: 0x002FF9B1 File Offset: 0x002FDBB1
	protected override void OnBeforeHide()
	{
		this.IsRequesting = false;
	}

	// Token: 0x0600D15F RID: 53599 RVA: 0x002FF9BA File Offset: 0x002FDBBA
	private FloroRanchHandBookSmallSlotItem CreateRecommendItem()
	{
		FloroRanchHandBookSmallSlotItem floroRanchHandBookSmallSlotItem = new FloroRanchHandBookSmallSlotItem();
		floroRanchHandBookSmallSlotItem.SetActivityDataType(EFloroRanchActivityDataType.Weekly);
		floroRanchHandBookSmallSlotItem.BindClickCallback(new Action<FloroRanchHandBookSmallSlotItem>(this.OnRecommendItemClick));
		return floroRanchHandBookSmallSlotItem;
	}

	// Token: 0x0600D160 RID: 53600 RVA: 0x002FF9DC File Offset: 0x002FDBDC
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

	// Token: 0x0600D161 RID: 53601 RVA: 0x002FFA9C File Offset: 0x002FDC9C
	private FloroRanchRaceItem CreateRaceItem()
	{
		return new FloroRanchRaceItem();
	}

	// Token: 0x0600D162 RID: 53602 RVA: 0x002FFAA4 File Offset: 0x002FDCA4
	private UniTask RefreshRightInfoPanel()
	{
		FloroRanchWeeklyMainView.<RefreshRightInfoPanel>d__21 <RefreshRightInfoPanel>d__;
		<RefreshRightInfoPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshRightInfoPanel>d__.<>4__this = this;
		<RefreshRightInfoPanel>d__.<>1__state = -1;
		<RefreshRightInfoPanel>d__.<>t__builder.Start<FloroRanchWeeklyMainView.<RefreshRightInfoPanel>d__21>(ref <RefreshRightInfoPanel>d__);
		return <RefreshRightInfoPanel>d__.<>t__builder.Task;
	}

	// Token: 0x0600D163 RID: 53603 RVA: 0x002FFAE8 File Offset: 0x002FDCE8
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

	// Token: 0x0600D164 RID: 53604 RVA: 0x002FFB69 File Offset: 0x002FDD69
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

	// Token: 0x0600D165 RID: 53605 RVA: 0x002FFB83 File Offset: 0x002FDD83
	private void OnSkillChange(EFloroRanchActivityDataType activityDataType, int skillId)
	{
		if (activityDataType != EFloroRanchActivityDataType.Weekly)
		{
			return;
		}
		this.RefreshSkillItem(skillId);
	}

	// Token: 0x0600D166 RID: 53606 RVA: 0x002FFB91 File Offset: 0x002FDD91
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

	// Token: 0x0600D167 RID: 53607 RVA: 0x002FFBA8 File Offset: 0x002FDDA8
	private void OnFloroRanchSettlement()
	{
		this.RefreshStartButton();
		this.RefreshWeeklyScore();
		this.RefreshHistoryPanel();
	}

	// Token: 0x0600D168 RID: 53608 RVA: 0x002FFBBC File Offset: 0x002FDDBC
	private void OnSubInsHistoryUpdate()
	{
		this.RefreshHistoryPanel();
	}

	// Token: 0x0600D169 RID: 53609 RVA: 0x002FFBC4 File Offset: 0x002FDDC4
	private void RefreshStartButton()
	{
		bool flag = this.ActivityData.HasUnFinishedSubIns();
		base.GetButton(2).RootUIComp.Get().SetUIActive(!flag);
		base.GetButton(11).RootUIComp.Get().SetUIActive(flag);
	}

	// Token: 0x0600D16A RID: 53610 RVA: 0x002FFC18 File Offset: 0x002FDE18
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

	// Token: 0x0600D16B RID: 53611 RVA: 0x002FFCD4 File Offset: 0x002FDED4
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

	// Token: 0x0600D16C RID: 53612 RVA: 0x002FFDB8 File Offset: 0x002FDFB8
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

	// Token: 0x0600D16D RID: 53613 RVA: 0x002FFEAB File Offset: 0x002FE0AB
	private void OnCloseBtnClick()
	{
		if (this.IsRequesting)
		{
			return;
		}
		base.CloseMe(null);
	}

	// Token: 0x0600D16E RID: 53614 RVA: 0x002FFEBD File Offset: 0x002FE0BD
	private void OnStartBtnClick()
	{
		this.OnGameNewStart();
	}

	// Token: 0x0600D16F RID: 53615 RVA: 0x002FFEC8 File Offset: 0x002FE0C8
	private void OnArchiveBtnClick()
	{
		FloroRanchHandBookViewParam floroRanchHandBookViewParam = new FloroRanchHandBookViewParam
		{
			ActivityDataType = EFloroRanchActivityDataType.Weekly
		};
		UiManager.Instance.OpenView(EUiViewName.FloroRanchHandBookView, floroRanchHandBookViewParam, null);
	}

	// Token: 0x04006014 RID: 24596
	[Nullable(2)]
	private global::FloroRanchActivityData ActivityData;

	// Token: 0x04006015 RID: 24597
	private int SubDungeonId;

	// Token: 0x04006016 RID: 24598
	private int SkillId;

	// Token: 0x04006017 RID: 24599
	private List<int> RaceIds = new List<int>();

	// Token: 0x04006018 RID: 24600
	[Nullable(2)]
	private FloroRanchSkillItem SkillItem;

	// Token: 0x04006019 RID: 24601
	private GenericLayout<FloroRanchHandBookSmallSlotItem, FloroRanchUnlockDataBase> RecommendLayout;

	// Token: 0x0400601A RID: 24602
	private readonly List<FloroRanchUnlockDataBase> RecommendUnlockDataList = new List<FloroRanchUnlockDataBase>();

	// Token: 0x0400601B RID: 24603
	private GenericLayout<FloroRanchRaceItem, FloroRanchSelectRaceData> RaceLayout;

	// Token: 0x0400601C RID: 24604
	private bool IsRequesting;

	// Token: 0x020080FD RID: 33021
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x0402A178 RID: 172408
		public const int TextTitle = 0;

		// Token: 0x0402A179 RID: 172409
		public const int BtnClose = 1;

		// Token: 0x0402A17A RID: 172410
		public const int BtnStart = 2;

		// Token: 0x0402A17B RID: 172411
		public const int ItemRightPanel = 3;

		// Token: 0x0402A17C RID: 172412
		public const int ItemHistoryPanel = 4;

		// Token: 0x0402A17D RID: 172413
		public const int TextHistoryDay = 5;

		// Token: 0x0402A17E RID: 172414
		public const int TextHistoryCoin = 6;

		// Token: 0x0402A17F RID: 172415
		public const int SpineRole = 7;

		// Token: 0x0402A180 RID: 172416
		public const int ItemSKill = 8;

		// Token: 0x0402A181 RID: 172417
		public const int ItemLockPanel = 9;

		// Token: 0x0402A182 RID: 172418
		public const int ItemQuest = 10;

		// Token: 0x0402A183 RID: 172419
		public const int BtnSave = 11;

		// Token: 0x0402A184 RID: 172420
		public const int BtnArchive = 12;

		// Token: 0x0402A185 RID: 172421
		public const int TextInsName = 13;

		// Token: 0x0402A186 RID: 172422
		public const int TextTarget = 14;

		// Token: 0x0402A187 RID: 172423
		public const int ItemDescRoot = 15;

		// Token: 0x0402A188 RID: 172424
		public const int TextDesc = 16;

		// Token: 0x0402A189 RID: 172425
		public const int GridLayoutRecommend = 17;

		// Token: 0x0402A18A RID: 172426
		public const int ItemRecommend = 18;

		// Token: 0x0402A18B RID: 172427
		public const int HorizontalLayoutRace = 19;

		// Token: 0x0402A18C RID: 172428
		public const int ItemRace = 20;

		// Token: 0x0402A18D RID: 172429
		public const int TextCurWeeklyScore = 21;

		// Token: 0x0402A18E RID: 172430
		public const int TextMaxWeeklyScore = 22;

		// Token: 0x0402A18F RID: 172431
		public const int TextWeekFinish = 23;
	}
}
