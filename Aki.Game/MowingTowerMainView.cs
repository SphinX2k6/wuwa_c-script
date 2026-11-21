using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.InstanceDungeon;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000838 RID: 2104
[NullableContext(2)]
[Nullable(0)]
public class MowingTowerMainView : UiViewBase
{
	// Token: 0x06005F8A RID: 24458 RVA: 0x001E81CF File Offset: 0x001E63CF
	[NullableContext(1)]
	public MowingTowerMainView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x06005F8B RID: 24459 RVA: 0x001E81D8 File Offset: 0x001E63D8
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIScrollViewWithScrollbarComponent)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUITexture)),
			new ValueTuple<int, Type>(7, typeof(UUIItem)),
			new ValueTuple<int, Type>(8, typeof(UUIItem)),
			new ValueTuple<int, Type>(9, typeof(UUIItem)),
			new ValueTuple<int, Type>(10, typeof(UUIText)),
			new ValueTuple<int, Type>(11, typeof(UUIItem)),
			new ValueTuple<int, Type>(12, typeof(UUIText)),
			new ValueTuple<int, Type>(13, typeof(UUIItem)),
			new ValueTuple<int, Type>(14, typeof(UUIText)),
			new ValueTuple<int, Type>(15, typeof(UUIText)),
			new ValueTuple<int, Type>(16, typeof(UUIText)),
			new ValueTuple<int, Type>(17, typeof(UUIItem)),
			new ValueTuple<int, Type>(18, typeof(UUIItem)),
			new ValueTuple<int, Type>(19, typeof(UUIItem)),
			new ValueTuple<int, Type>(20, typeof(UUIItem)),
			new ValueTuple<int, Type>(21, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(22, typeof(UUIItem)),
			new ValueTuple<int, Type>(23, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(24, typeof(UUIText)),
			new ValueTuple<int, Type>(25, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(1, new Action(this.OnClickSelectViewRewardBtn)),
			new ValueTuple<int, Delegate>(21, new Action(this.OnClickLevelViewConfirmBtn)),
			new ValueTuple<int, Delegate>(23, new Action(this.OnClickLevelViewMonsterBtn))
		};
	}

	// Token: 0x06005F8C RID: 24460 RVA: 0x001E8492 File Offset: 0x001E6692
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<int>(EEventName.ChangeMowingTowerMainView, new Action<int>(this.OnChangeMowingTowerMainView));
		EventSystem.Instance.Add(EEventName.ChangeMowingTowerBuff, new Action(this.OnSelectBuff));
	}

	// Token: 0x06005F8D RID: 24461 RVA: 0x001E84CC File Offset: 0x001E66CC
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.ChangeMowingTowerMainView, new Action<int>(this.OnChangeMowingTowerMainView));
		EventSystem.Instance.Remove(EEventName.ChangeMowingTowerBuff, new Action(this.OnSelectBuff));
	}

	// Token: 0x06005F8E RID: 24462 RVA: 0x001E8508 File Offset: 0x001E6708
	protected override UniTask OnBeforeStartAsync()
	{
		MowingTowerMainView.<OnBeforeStartAsync>d__15 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<MowingTowerMainView.<OnBeforeStartAsync>d__15>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06005F8F RID: 24463 RVA: 0x001E854C File Offset: 0x001E674C
	protected override void OnStart()
	{
		MowingTowerModel.Instance.CurrentSelectActivityId = (int)this.OpenParam;
		MowingTowerData mowingTowerData = ActivityModel.Instance.GetActivityById(MowingTowerModel.Instance.CurrentSelectActivityId) as MowingTowerData;
		this.MowingTowerData = mowingTowerData;
		this.CaptionItem.SetCloseCallBack(delegate
		{
			if (this.CurrentShowView != EMowingTowerSubViewName.SelectView)
			{
				this.CurrentShowView = EMowingTowerSubViewName.SelectView;
				LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
				if (levelSequencePlayer != null)
				{
					levelSequencePlayer.PlaySequencePurely("SwitchOut", false, false, null, null, false);
				}
				this.RefreshSubView(false);
				return;
			}
			if (GameModeController.Instance.IsInInstance())
			{
				InstanceDungeonEntranceController.Instance.LeaveInstanceDungeon();
				return;
			}
			base.CloseMe(null);
		});
		this.CurrentShowView = EMowingTowerSubViewName.SelectView;
		this.RefreshSubView(true);
	}

	// Token: 0x06005F90 RID: 24464 RVA: 0x001E85B4 File Offset: 0x001E67B4
	protected override void OnBeforeShow()
	{
		if (this.CurrentShowView == EMowingTowerSubViewName.LevelView)
		{
			this.RefreshBuffEntry();
		}
		RedDotController.Instance.BindRedDot(ERedDotName.MowingTowerReward, base.GetItem(25), null, this.MowingTowerData.Id);
		EventSystem.Instance.Emit<int>(EEventName.RefreshMowingTowerRewardRedDot, this.MowingTowerData.Id);
	}

	// Token: 0x06005F91 RID: 24465 RVA: 0x001E860E File Offset: 0x001E680E
	protected override void OnBeforeHide()
	{
		RedDotController.Instance.UnBindGivenUi(ERedDotName.MowingTowerReward, base.GetItem(25), this.MowingTowerData.Id);
	}

	// Token: 0x06005F92 RID: 24466 RVA: 0x001E8634 File Offset: 0x001E6834
	private void RefreshSelectLevelView(bool scrollToUnFinishItem = false)
	{
		this.CaptionItem.SetTitleByTextIdAndArgNew("MowingTowerSelectViewTitle", Array.Empty<object>());
		List<MowingTowerLevelDetailInfo> data = new List<MowingTowerLevelDetailInfo>(this.MowingTowerData.GetMowingTowerLevelDetailInfo());
		GenericScrollViewNew<MowingTowerMainLevelItem, MowingTowerLevelDetailInfo> levelScrollView = this.LevelScrollView;
		if (levelScrollView != null)
		{
			levelScrollView.RefreshByData(data, null, false);
		}
		UUIText text = base.GetText(2);
		if (text == null)
		{
			return;
		}
		text.SetText(this.MowingTowerData.GetFullScore().ToString() ?? "", true);
	}

	// Token: 0x06005F93 RID: 24467 RVA: 0x001E86AC File Offset: 0x001E68AC
	private void RefreshLevelView()
	{
		this.CaptionItem.SetTitleByTextIdAndArgNew("MowingTowerLevelViewTitle", Array.Empty<object>());
		this.CurrentTeamInfo = MowingTowerModel.Instance.CurrentTeamInfo;
		TeamListItem firstPartTeamListItem = this.FirstPartTeamListItem;
		if (firstPartTeamListItem != null)
		{
			firstPartTeamListItem.RefreshTeamRole(this.CurrentTeamInfo, ETeamBelong.FirstPart);
		}
		TeamListItem lowPartTeamListItem = this.LowPartTeamListItem;
		if (lowPartTeamListItem != null)
		{
			lowPartTeamListItem.RefreshTeamRole(this.CurrentTeamInfo, ETeamBelong.LowPart);
		}
		MowingTowerLevelDetailInfo currentSelectLevel = this.CurrentTeamInfo.GetCurrentSelectLevel();
		this.RefreshLevelViewScore(currentSelectLevel);
		this.RefreshLevelViewTexture(currentSelectLevel);
		this.RefreshLevelViewMonsterDes(currentSelectLevel);
		this.RefreshBuffEntry();
		this.RefreshLowLevelTips();
	}

	// Token: 0x06005F94 RID: 24468 RVA: 0x001E873C File Offset: 0x001E693C
	[NullableContext(1)]
	private void RefreshLevelViewTexture(MowingTowerLevelDetailInfo data)
	{
		base.SetTextureByPath(data.GetNormalTexturePath(), base.GetTexture(6), null, null);
		bool isInfinite = data.GetIsInfinite();
		if (data.GetId() % 2 == 0 || isInfinite)
		{
			UUIItem item = base.GetItem(7);
			if (item != null)
			{
				item.SetUIActive(false);
			}
			UUIItem item2 = base.GetItem(8);
			if (item2 != null)
			{
				item2.SetUIActive(true);
			}
		}
		else
		{
			UUIItem item3 = base.GetItem(7);
			if (item3 != null)
			{
				item3.SetUIActive(true);
			}
			UUIItem item4 = base.GetItem(8);
			if (item4 != null)
			{
				item4.SetUIActive(false);
			}
		}
		if (isInfinite)
		{
			UUIItem item5 = base.GetItem(9);
			if (item5 != null)
			{
				item5.SetColor(MowingTowerColors.bgInfiniteMowingTowerColor.Value);
			}
			UUIText text = base.GetText(10);
			if (text != null)
			{
				text.SetColor(MowingTowerColors.infiniteMowingTowerColor.Value);
			}
			UUIItem item6 = base.GetItem(7);
			if (item6 != null)
			{
				item6.SetColor(MowingTowerColors.infiniteMowingTowerColor.Value);
			}
			UUIItem item7 = base.GetItem(8);
			if (item7 == null)
			{
				return;
			}
			item7.SetColor(MowingTowerColors.infiniteMowingTowerColor.Value);
			return;
		}
		else
		{
			UUIItem item8 = base.GetItem(9);
			if (item8 != null)
			{
				item8.SetColor(MowingTowerColors.bgNormalMowingTowerColor.Value);
			}
			UUIText text2 = base.GetText(10);
			if (text2 != null)
			{
				text2.SetColor(MowingTowerColors.normalMowingTowerColor.Value);
			}
			UUIItem item9 = base.GetItem(7);
			if (item9 != null)
			{
				item9.SetColor(MowingTowerColors.normalMowingTowerColor.Value);
			}
			UUIItem item10 = base.GetItem(8);
			if (item10 == null)
			{
				return;
			}
			item10.SetColor(MowingTowerColors.normalMowingTowerColor.Value);
			return;
		}
	}

	// Token: 0x06005F95 RID: 24469 RVA: 0x001E88B0 File Offset: 0x001E6AB0
	[NullableContext(1)]
	private void RefreshLevelViewScore(MowingTowerLevelDetailInfo data)
	{
		int score = data.GetScore();
		bool flag = score > 0;
		UUIText text = base.GetText(12);
		text.SetUIActive(flag);
		text.SetText(score.ToString(), true);
		base.GetItem(13).SetUIActive(!flag);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(10), data.GetLevelDesc(), Array.Empty<object>());
		UUIText text2 = base.GetText(14);
		if (text2 != null)
		{
			text2.SetText(data.GetFirstScore().ToString() ?? "", true);
		}
		UUIText text3 = base.GetText(15);
		if (text3 != null)
		{
			text3.SetText(data.GetLowScore().ToString() ?? "", true);
		}
		LguiUtil.Instance.SetLocalTextNew(base.GetText(16), data.GetLevelTips() ?? "", Array.Empty<object>());
	}

	// Token: 0x06005F96 RID: 24470 RVA: 0x001E8990 File Offset: 0x001E6B90
	private void RefreshLowLevelTips()
	{
		bool ifLevelTooLow = this.CurrentTeamInfo.GetIfLevelTooLow();
		base.GetItem(20).SetUIActive(ifLevelTooLow);
	}

	// Token: 0x06005F97 RID: 24471 RVA: 0x001E89B7 File Offset: 0x001E6BB7
	private void OnSelectBuff()
	{
		this.RefreshBuffEntry();
	}

	// Token: 0x06005F98 RID: 24472 RVA: 0x001E89C0 File Offset: 0x001E6BC0
	private void RefreshBuffEntry()
	{
		List<MowingTowerBuffInfo> prepareSelectBuff = this.CurrentTeamInfo.GetPrepareSelectBuff();
		MowingBuffEntry buffEntryItem = this.BuffEntryItem;
		if (buffEntryItem == null)
		{
			return;
		}
		buffEntryItem.Refresh(prepareSelectBuff[0]);
	}

	// Token: 0x06005F99 RID: 24473 RVA: 0x001E89F0 File Offset: 0x001E6BF0
	[NullableContext(1)]
	private void RefreshLevelViewMonsterDes(MowingTowerLevelDetailInfo data)
	{
		MowTowerLevelsRe? mowTowerLevelsRe;
		LguiUtil.Instance.SetLocalTextNew(base.GetText(24), "MowingTowerMonsterTimes", new <>z__ReadOnlySingleElementList<object>((data.GetConfig() != null) ? mowTowerLevelsRe.GetValueOrDefault().MonsterDes : null));
	}

	// Token: 0x06005F9A RID: 24474 RVA: 0x001E8A3C File Offset: 0x001E6C3C
	private void RefreshSubView(bool scrollToUnFinishItem = false)
	{
		if (this.CurrentShowView == EMowingTowerSubViewName.SelectView)
		{
			UUIItem item = base.GetItem(5);
			if (item != null)
			{
				item.SetUIActive(true);
			}
			UUIItem item2 = base.GetItem(22);
			if (item2 != null)
			{
				item2.SetUIActive(false);
			}
			this.RefreshSelectLevelView(scrollToUnFinishItem);
		}
		if (this.CurrentShowView == EMowingTowerSubViewName.LevelView)
		{
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer != null)
			{
				levelSequencePlayer.PlaySequencePurely("SwitchIn", false, false, null, null, false);
			}
			UUIItem item3 = base.GetItem(5);
			if (item3 != null)
			{
				item3.SetUIActive(false);
			}
			UUIItem item4 = base.GetItem(22);
			if (item4 != null)
			{
				item4.SetUIActive(true);
			}
			this.RefreshLevelView();
		}
	}

	// Token: 0x06005F9B RID: 24475 RVA: 0x001E8AD8 File Offset: 0x001E6CD8
	[NullableContext(1)]
	private MowingTowerMainLevelItem OnCreateItem()
	{
		return new MowingTowerMainLevelItem();
	}

	// Token: 0x06005F9C RID: 24476 RVA: 0x001E8ADF File Offset: 0x001E6CDF
	private void OnChangeMowingTowerMainView(int view)
	{
		this.CurrentShowView = (EMowingTowerSubViewName)view;
		this.RefreshSubView(false);
	}

	// Token: 0x06005F9D RID: 24477 RVA: 0x001E8AEF File Offset: 0x001E6CEF
	private void OnClickSelectViewRewardBtn()
	{
		if (!UiManager.Instance.IsViewOpen(EUiViewName.MowingTowerRewardView))
		{
			UiManager.Instance.OpenView(EUiViewName.MowingTowerRewardView, null, null);
		}
	}

	// Token: 0x06005F9E RID: 24478 RVA: 0x001E8B14 File Offset: 0x001E6D14
	private void OnClickLevelViewConfirmBtn()
	{
		MowingTowerTeamInfo currentTeamInfo = this.CurrentTeamInfo;
		ValueTuple<List<int>, List<int>> valueTuple = (currentTeamInfo != null) ? currentTeamInfo.GetCurrentTeamMembers() : new ValueTuple<List<int>, List<int>>(new List<int>(), new List<int>());
		if (valueTuple.Item1.Count != 3 || valueTuple.Item2.Count != 3 || valueTuple.Item1.Contains(0) || valueTuple.Item2.Contains(0))
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("MowingTowerNeedThreeRole", Array.Empty<object>());
			return;
		}
		MowingTowerController.Instance.RequestStartMowingTowerByTeamData(this.CurrentTeamInfo);
	}

	// Token: 0x06005F9F RID: 24479 RVA: 0x001E8BA4 File Offset: 0x001E6DA4
	private void OnClickLevelViewMonsterBtn()
	{
		UiManager instance = UiManager.Instance;
		EUiViewName instanceDungeonMonsterPreView = EUiViewName.InstanceDungeonMonsterPreView;
		MowingTowerTeamInfo currentTeamInfo = this.CurrentTeamInfo;
		int? num;
		if (currentTeamInfo == null)
		{
			num = null;
		}
		else
		{
			MowingTowerLevelDetailInfo currentSelectLevel = currentTeamInfo.GetCurrentSelectLevel();
			num = ((currentSelectLevel != null) ? new int?(currentSelectLevel.GetInstanceDungeonId()) : null);
		}
		instance.OpenView(instanceDungeonMonsterPreView, num, null);
	}

	// Token: 0x04003EA4 RID: 16036
	private MowingTowerData MowingTowerData;

	// Token: 0x04003EA5 RID: 16037
	private MowingTowerTeamInfo CurrentTeamInfo;

	// Token: 0x04003EA6 RID: 16038
	private EMowingTowerSubViewName CurrentShowView;

	// Token: 0x04003EA7 RID: 16039
	private PopupCaptionItem CaptionItem;

	// Token: 0x04003EA8 RID: 16040
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericScrollViewNew<MowingTowerMainLevelItem, MowingTowerLevelDetailInfo> LevelScrollView;

	// Token: 0x04003EA9 RID: 16041
	private MowingBuffEntry BuffEntryItem;

	// Token: 0x04003EAA RID: 16042
	private TeamListItem FirstPartTeamListItem;

	// Token: 0x04003EAB RID: 16043
	private TeamListItem LowPartTeamListItem;

	// Token: 0x04003EAC RID: 16044
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x04003EAD RID: 16045
	private const int ROLE_TEAM_SIZE = 3;

	// Token: 0x02006B81 RID: 27521
	[NullableContext(0)]
	private static class EComponent
	{
		// Token: 0x04023569 RID: 144745
		public const int CaptionItem = 0;

		// Token: 0x0402356A RID: 144746
		public const int SelectViewRewardBtn = 1;

		// Token: 0x0402356B RID: 144747
		public const int SelectViewScoreText = 2;

		// Token: 0x0402356C RID: 144748
		public const int SelectViewLevelScrollView = 3;

		// Token: 0x0402356D RID: 144749
		public const int SelectViewLevelItem = 4;

		// Token: 0x0402356E RID: 144750
		public const int SelectViewRootItem = 5;

		// Token: 0x0402356F RID: 144751
		public const int LevelViewLevelTexture = 6;

		// Token: 0x04023570 RID: 144752
		public const int LevelViewSingleItem = 7;

		// Token: 0x04023571 RID: 144753
		public const int LevelViewDoubleItem = 8;

		// Token: 0x04023572 RID: 144754
		public const int LevelViewBgItem = 9;

		// Token: 0x04023573 RID: 144755
		public const int LevelViewLevelText = 10;

		// Token: 0x04023574 RID: 144756
		public const int LevelViewHaveScoreItem = 11;

		// Token: 0x04023575 RID: 144757
		public const int LevelViewScoreText = 12;

		// Token: 0x04023576 RID: 144758
		public const int LevelViewUnFinishScoreItem = 13;

		// Token: 0x04023577 RID: 144759
		public const int LevelViewFirstHalfScoreText = 14;

		// Token: 0x04023578 RID: 144760
		public const int LevelViewLowerHalfScoreText = 15;

		// Token: 0x04023579 RID: 144761
		public const int LevelViewLevelDesText = 16;

		// Token: 0x0402357A RID: 144762
		public const int LevelViewLevelBuffItem = 17;

		// Token: 0x0402357B RID: 144763
		public const int LevelViewFormationItem1 = 18;

		// Token: 0x0402357C RID: 144764
		public const int LevelViewFormationItem2 = 19;

		// Token: 0x0402357D RID: 144765
		public const int LevelViewLowLevelTipItem = 20;

		// Token: 0x0402357E RID: 144766
		public const int LevelViewConfirmBtn = 21;

		// Token: 0x0402357F RID: 144767
		public const int LevelViewRootItem = 22;

		// Token: 0x04023580 RID: 144768
		public const int LevelViewMonsterBtn = 23;

		// Token: 0x04023581 RID: 144769
		public const int LevelViewMonsterText = 24;

		// Token: 0x04023582 RID: 144770
		public const int SelectViewRewardRedDotItem = 25;
	}
}
