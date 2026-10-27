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

// Token: 0x02001384 RID: 4996
[NullableContext(2)]
[Nullable(0)]
public class MowingTowerMainView : UiViewBase
{
	// Token: 0x06008BEF RID: 35823 RVA: 0x001DF37B File Offset: 0x001DD57B
	[NullableContext(1)]
	public MowingTowerMainView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x06008BF0 RID: 35824 RVA: 0x001DF384 File Offset: 0x001DD584
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

	// Token: 0x06008BF1 RID: 35825 RVA: 0x001DF63E File Offset: 0x001DD83E
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<int>(EEventName.ChangeMowingTowerMainView, new Action<int>(this.OnChangeMowingTowerMainView));
		EventSystem.Instance.Add(EEventName.ChangeMowingTowerBuff, new Action(this.OnSelectBuff));
	}

	// Token: 0x06008BF2 RID: 35826 RVA: 0x001DF678 File Offset: 0x001DD878
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.ChangeMowingTowerMainView, new Action<int>(this.OnChangeMowingTowerMainView));
		EventSystem.Instance.Remove(EEventName.ChangeMowingTowerBuff, new Action(this.OnSelectBuff));
	}

	// Token: 0x06008BF3 RID: 35827 RVA: 0x001DF6B4 File Offset: 0x001DD8B4
	protected override UniTask OnBeforeStartAsync()
	{
		MowingTowerMainView.<OnBeforeStartAsync>d__15 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<MowingTowerMainView.<OnBeforeStartAsync>d__15>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06008BF4 RID: 35828 RVA: 0x001DF6F8 File Offset: 0x001DD8F8
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

	// Token: 0x06008BF5 RID: 35829 RVA: 0x001DF760 File Offset: 0x001DD960
	protected override void OnBeforeShow()
	{
		if (this.CurrentShowView == EMowingTowerSubViewName.LevelView)
		{
			this.RefreshBuffEntry();
		}
		RedDotController.Instance.BindRedDot(ERedDotName.MowingTowerReward, base.GetItem(25), null, this.MowingTowerData.Id);
		EventSystem.Instance.Emit<int>(EEventName.RefreshMowingTowerRewardRedDot, this.MowingTowerData.Id);
	}

	// Token: 0x06008BF6 RID: 35830 RVA: 0x001DF7BA File Offset: 0x001DD9BA
	protected override void OnBeforeHide()
	{
		RedDotController.Instance.UnBindGivenUi(ERedDotName.MowingTowerReward, base.GetItem(25), this.MowingTowerData.Id);
	}

	// Token: 0x06008BF7 RID: 35831 RVA: 0x001DF7E0 File Offset: 0x001DD9E0
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

	// Token: 0x06008BF8 RID: 35832 RVA: 0x001DF858 File Offset: 0x001DDA58
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

	// Token: 0x06008BF9 RID: 35833 RVA: 0x001DF8E8 File Offset: 0x001DDAE8
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

	// Token: 0x06008BFA RID: 35834 RVA: 0x001DFA5C File Offset: 0x001DDC5C
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

	// Token: 0x06008BFB RID: 35835 RVA: 0x001DFB3C File Offset: 0x001DDD3C
	private void RefreshLowLevelTips()
	{
		bool ifLevelTooLow = this.CurrentTeamInfo.GetIfLevelTooLow();
		base.GetItem(20).SetUIActive(ifLevelTooLow);
	}

	// Token: 0x06008BFC RID: 35836 RVA: 0x001DFB63 File Offset: 0x001DDD63
	private void OnSelectBuff()
	{
		this.RefreshBuffEntry();
	}

	// Token: 0x06008BFD RID: 35837 RVA: 0x001DFB6C File Offset: 0x001DDD6C
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

	// Token: 0x06008BFE RID: 35838 RVA: 0x001DFB9C File Offset: 0x001DDD9C
	[NullableContext(1)]
	private void RefreshLevelViewMonsterDes(MowingTowerLevelDetailInfo data)
	{
		MowTowerLevelsRe? mowTowerLevelsRe;
		LguiUtil.Instance.SetLocalTextNew(base.GetText(24), "MowingTowerMonsterTimes", new <>z__ReadOnlySingleElementList<object>((data.GetConfig() != null) ? mowTowerLevelsRe.GetValueOrDefault().MonsterDes : null));
	}

	// Token: 0x06008BFF RID: 35839 RVA: 0x001DFBE8 File Offset: 0x001DDDE8
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

	// Token: 0x06008C00 RID: 35840 RVA: 0x001DFC84 File Offset: 0x001DDE84
	[NullableContext(1)]
	private MowingTowerMainLevelItem OnCreateItem()
	{
		return new MowingTowerMainLevelItem();
	}

	// Token: 0x06008C01 RID: 35841 RVA: 0x001DFC8B File Offset: 0x001DDE8B
	private void OnChangeMowingTowerMainView(int view)
	{
		this.CurrentShowView = (EMowingTowerSubViewName)view;
		this.RefreshSubView(false);
	}

	// Token: 0x06008C02 RID: 35842 RVA: 0x001DFC9B File Offset: 0x001DDE9B
	private void OnClickSelectViewRewardBtn()
	{
		if (!UiManager.Instance.IsViewOpen(EUiViewName.MowingTowerRewardView))
		{
			UiManager.Instance.OpenView(EUiViewName.MowingTowerRewardView, null, null);
		}
	}

	// Token: 0x06008C03 RID: 35843 RVA: 0x001DFCC0 File Offset: 0x001DDEC0
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

	// Token: 0x06008C04 RID: 35844 RVA: 0x001DFD50 File Offset: 0x001DDF50
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

	// Token: 0x04003E0C RID: 15884
	private MowingTowerData MowingTowerData;

	// Token: 0x04003E0D RID: 15885
	private MowingTowerTeamInfo CurrentTeamInfo;

	// Token: 0x04003E0E RID: 15886
	private EMowingTowerSubViewName CurrentShowView;

	// Token: 0x04003E0F RID: 15887
	private PopupCaptionItem CaptionItem;

	// Token: 0x04003E10 RID: 15888
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericScrollViewNew<MowingTowerMainLevelItem, MowingTowerLevelDetailInfo> LevelScrollView;

	// Token: 0x04003E11 RID: 15889
	private MowingBuffEntry BuffEntryItem;

	// Token: 0x04003E12 RID: 15890
	private TeamListItem FirstPartTeamListItem;

	// Token: 0x04003E13 RID: 15891
	private TeamListItem LowPartTeamListItem;

	// Token: 0x04003E14 RID: 15892
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x04003E15 RID: 15893
	private const int ROLE_TEAM_SIZE = 3;

	// Token: 0x020079F7 RID: 31223
	[NullableContext(0)]
	private static class EComponent
	{
		// Token: 0x0402823C RID: 164412
		public const int CaptionItem = 0;

		// Token: 0x0402823D RID: 164413
		public const int SelectViewRewardBtn = 1;

		// Token: 0x0402823E RID: 164414
		public const int SelectViewScoreText = 2;

		// Token: 0x0402823F RID: 164415
		public const int SelectViewLevelScrollView = 3;

		// Token: 0x04028240 RID: 164416
		public const int SelectViewLevelItem = 4;

		// Token: 0x04028241 RID: 164417
		public const int SelectViewRootItem = 5;

		// Token: 0x04028242 RID: 164418
		public const int LevelViewLevelTexture = 6;

		// Token: 0x04028243 RID: 164419
		public const int LevelViewSingleItem = 7;

		// Token: 0x04028244 RID: 164420
		public const int LevelViewDoubleItem = 8;

		// Token: 0x04028245 RID: 164421
		public const int LevelViewBgItem = 9;

		// Token: 0x04028246 RID: 164422
		public const int LevelViewLevelText = 10;

		// Token: 0x04028247 RID: 164423
		public const int LevelViewHaveScoreItem = 11;

		// Token: 0x04028248 RID: 164424
		public const int LevelViewScoreText = 12;

		// Token: 0x04028249 RID: 164425
		public const int LevelViewUnFinishScoreItem = 13;

		// Token: 0x0402824A RID: 164426
		public const int LevelViewFirstHalfScoreText = 14;

		// Token: 0x0402824B RID: 164427
		public const int LevelViewLowerHalfScoreText = 15;

		// Token: 0x0402824C RID: 164428
		public const int LevelViewLevelDesText = 16;

		// Token: 0x0402824D RID: 164429
		public const int LevelViewLevelBuffItem = 17;

		// Token: 0x0402824E RID: 164430
		public const int LevelViewFormationItem1 = 18;

		// Token: 0x0402824F RID: 164431
		public const int LevelViewFormationItem2 = 19;

		// Token: 0x04028250 RID: 164432
		public const int LevelViewLowLevelTipItem = 20;

		// Token: 0x04028251 RID: 164433
		public const int LevelViewConfirmBtn = 21;

		// Token: 0x04028252 RID: 164434
		public const int LevelViewRootItem = 22;

		// Token: 0x04028253 RID: 164435
		public const int LevelViewMonsterBtn = 23;

		// Token: 0x04028254 RID: 164436
		public const int LevelViewMonsterText = 24;

		// Token: 0x04028255 RID: 164437
		public const int SelectViewRewardRedDotItem = 25;
	}
}
