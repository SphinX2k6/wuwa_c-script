using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Reward;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Tetris
{
	// Token: 0x02006007 RID: 24583
	[NullableContext(1)]
	[Nullable(0)]
	public class TetrisLevelDetailView : UiViewBase
	{
		// Token: 0x0603E420 RID: 255008 RVA: 0x00F07EC2 File Offset: 0x00F060C2
		public TetrisLevelDetailView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603E421 RID: 255009 RVA: 0x00F07ED8 File Offset: 0x00F060D8
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUIText)),
				new ValueTuple<int, Type>(3, typeof(UUIText)),
				new ValueTuple<int, Type>(4, typeof(UUIVerticalLayout)),
				new ValueTuple<int, Type>(5, typeof(UUIItem)),
				new ValueTuple<int, Type>(6, typeof(UUIItem)),
				new ValueTuple<int, Type>(7, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(8, typeof(UUIVerticalLayout)),
				new ValueTuple<int, Type>(9, typeof(UUIItem)),
				new ValueTuple<int, Type>(10, typeof(UUIItem)),
				new ValueTuple<int, Type>(11, typeof(UUIHorizontalLayout)),
				new ValueTuple<int, Type>(12, typeof(UUIArtText)),
				new ValueTuple<int, Type>(13, typeof(UUIItem))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(7, new Action(this.OnClickedEnterButton))
			};
		}

		// Token: 0x0603E422 RID: 255010 RVA: 0x00F0804C File Offset: 0x00F0624C
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.OnActivityClose, new Action<IReadOnlySet<int>>(this.OnActivityClose));
			EventSystem.Instance.Add(EEventName.OnTetrisChallengeStateUpdate, new Action<int>(this.OnTetrisChallengeStateUpdate));
		}

		// Token: 0x0603E423 RID: 255011 RVA: 0x00F08086 File Offset: 0x00F06286
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnActivityClose, new Action<IReadOnlySet<int>>(this.OnActivityClose));
			EventSystem.Instance.Remove(EEventName.OnTetrisChallengeStateUpdate, new Action<int>(this.OnTetrisChallengeStateUpdate));
		}

		// Token: 0x0603E424 RID: 255012 RVA: 0x00F080C0 File Offset: 0x00F062C0
		private void OnTetrisChallengeStateUpdate(int challengeId)
		{
			this.GetCurrentDifficulty();
			this.RefreshAllGridToggleState();
			this.Refresh(false);
		}

		// Token: 0x0603E425 RID: 255013 RVA: 0x00F080D8 File Offset: 0x00F062D8
		protected override UniTask OnBeforeStartAsync()
		{
			TetrisLevelDetailView.<OnBeforeStartAsync>d__17 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<TetrisLevelDetailView.<OnBeforeStartAsync>d__17>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603E426 RID: 255014 RVA: 0x00F0811C File Offset: 0x00F0631C
		protected override void OnStart()
		{
			this.ViewSequencePlayer = new LevelSequencePlayer(this.RootItem);
			this.CaptionItem = new PopupCaptionItem(base.GetItem(0));
			this.CaptionItem.SetCloseCallBack(new Action(this.OnClickedCloseButton));
			this.CaptionItem.SetHelpCallBack(new Action(this.OnClickHelpBtn));
			this.Param = (this.OpenParam as ITetrisSelectGroupData);
			int activityId = ActivityTetrisController.Instance.ActivityId;
			this.Levels = ActivityTetrisConfig.Instance.GetGroupLevels(activityId, this.Param.GroupId);
			this.DifficultyScroll = new GenericLayout<TetrisLevelDetailGridView, Tetris>(base.GetVerticalLayout(8), new Func<TetrisLevelDetailGridView>(this.InitDifficultyItem), null, false, true);
			this.RewardListScroll = new GenericLayout<CommonItemSmallItemGrid, TItem>(base.GetHorizontalLayout(11), new Func<CommonItemSmallItemGrid>(this.InitRewardItem), null, false, true);
			this.TargetListScroll = new GenericLayout<TetrisTargetItemPanel, ITetrisTargetData>(base.GetVerticalLayout(4), new Func<TetrisTargetItemPanel>(this.InitTargetItem), null, false, true);
		}

		// Token: 0x0603E427 RID: 255015 RVA: 0x00F08218 File Offset: 0x00F06418
		private void GetCurrentDifficulty()
		{
			if (this.Levels == null)
			{
				return;
			}
			ActivityTetrisData tetrisData = ActivityTetrisController.Instance.GetTetrisData();
			if (tetrisData == null)
			{
				return;
			}
			for (int i = 0; i < this.Levels.Count; i++)
			{
				if (this.Levels[i].UnlockId == 0 || tetrisData.CheckChallengeComplete(this.Levels[i].UnlockId))
				{
					this.DifficultyIndex = i;
				}
			}
		}

		// Token: 0x0603E428 RID: 255016 RVA: 0x00F0828F File Offset: 0x00F0648F
		protected override void OnBeforeShow()
		{
			this.GetCurrentDifficulty();
			this.Refresh(false);
			this.RefreshScroller();
		}

		// Token: 0x0603E429 RID: 255017 RVA: 0x00F082A4 File Offset: 0x00F064A4
		public void Refresh(bool isSwitch = false)
		{
			this.RefreshDesc(isSwitch);
			this.RefreshReward();
			this.RefreshTarget();
			this.RefreshLockBtn();
			this.DetailIconItem.Refresh(this.Param);
		}

		// Token: 0x0603E42A RID: 255018 RVA: 0x00F082D0 File Offset: 0x00F064D0
		protected override void OnBeforeDestroy()
		{
			LevelSequencePlayer viewSequencePlayer = this.ViewSequencePlayer;
			if (viewSequencePlayer != null)
			{
				viewSequencePlayer.Clear();
			}
			this.ViewSequencePlayer = null;
		}

		// Token: 0x0603E42B RID: 255019 RVA: 0x00F082EC File Offset: 0x00F064EC
		private void RefreshAllGridToggleState()
		{
			foreach (TetrisLevelDetailGridView tetrisLevelDetailGridView in this.GridViews)
			{
				int? challengeDifficulty = tetrisLevelDetailGridView.GetChallengeDifficulty();
				int? num = challengeDifficulty;
				int difficultyIndex = this.DifficultyIndex;
				tetrisLevelDetailGridView.SetToggleActive(num.GetValueOrDefault() == difficultyIndex & num != null);
			}
		}

		// Token: 0x0603E42C RID: 255020 RVA: 0x00F08360 File Offset: 0x00F06560
		private void RefreshDesc(bool isSwitch = false)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), ActivityTetrisConfig.Instance.GetLevelConfig(this.Param.ChallengeIds[this.DifficultyIndex]).LevelName, Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(3), ActivityTetrisConfig.Instance.GetLevelConfig(this.Param.ChallengeIds[this.DifficultyIndex]).LevelDes, Array.Empty<object>());
			base.GetArtText(12).SetText(this.Param.GroupId.ToString());
		}

		// Token: 0x0603E42D RID: 255021 RVA: 0x00F0840C File Offset: 0x00F0660C
		private void RefreshReward()
		{
			int dropId = this.Levels[this.DifficultyIndex].DropId;
			List<TItem> dropPackagePreviewItemList = CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetDropPackagePreviewItemList(dropId);
			this.RewardListScroll.RefreshByData(dropPackagePreviewItemList, null, false);
		}

		// Token: 0x0603E42E RID: 255022 RVA: 0x00F0844D File Offset: 0x00F0664D
		private void RefreshTarget()
		{
			this.TargetListScroll.RefreshByData(this.GenTargetData(), null, false);
		}

		// Token: 0x0603E42F RID: 255023 RVA: 0x00F08464 File Offset: 0x00F06664
		private void RefreshLockBtn()
		{
			ActivityTetrisData tetrisData = ActivityTetrisController.Instance.GetTetrisData();
			if (tetrisData == null)
			{
				return;
			}
			bool flag = tetrisData.CheckPreChallengeComplete(this.Levels[this.DifficultyIndex].Id);
			base.GetItem(13).SetUIActive(!flag);
			UUIButtonComponent button = base.GetButton(7);
			if (button == null)
			{
				return;
			}
			button.RootUIComp.Get().SetUIActive(flag);
		}

		// Token: 0x0603E430 RID: 255024 RVA: 0x00F084D0 File Offset: 0x00F066D0
		private void RefreshScroller()
		{
			if (TetrisUtils.IsEggLevel(ActivityTetrisConfig.Instance.GetLevelConfig(this.Param.ChallengeIds[this.DifficultyIndex])))
			{
				this.ClearEggLevelRedDot();
				return;
			}
			this.DifficultyScroll.RefreshByData(this.Levels, new Action(this.RefreshAllGridToggleState), false);
		}

		// Token: 0x0603E431 RID: 255025 RVA: 0x00F0852C File Offset: 0x00F0672C
		private void ClearEggLevelRedDot()
		{
			int activityId = ActivityTetrisController.Instance.ActivityId;
			int key = this.Param.ChallengeIds[this.DifficultyIndex];
			ActivityModel.Instance.SaveActivityData(activityId, 10001, key, 0, 1);
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, activityId);
		}

		// Token: 0x0603E432 RID: 255026 RVA: 0x00F08580 File Offset: 0x00F06780
		private List<ITetrisTargetData> GenTargetData()
		{
			List<ITetrisTargetData> list = new List<ITetrisTargetData>();
			IntIntMap value = this.Levels[this.DifficultyIndex].TargetResults(0).Value;
			int mapIntIntLength = value.MapIntIntLength;
			for (int i = 0; i < mapIntIntLength; i++)
			{
				DicIntInt value2 = value.MapIntInt(i).Value;
				list.Add(new TetrisTargetData
				{
					Icon = ActivityTetrisConfig.Instance.GetGemConfig(value2.Key).Value.TargetIconPath,
					Num = value2.Value,
					Tip = ((value2.Key == 0) ? "Tetristext_09" : "Tetristext_10")
				});
			}
			return list;
		}

		// Token: 0x0603E433 RID: 255027 RVA: 0x00F08640 File Offset: 0x00F06840
		private TetrisTargetItemPanel InitTargetItem()
		{
			return new TetrisTargetItemPanel();
		}

		// Token: 0x0603E434 RID: 255028 RVA: 0x00F08647 File Offset: 0x00F06847
		public CommonItemSmallItemGrid InitRewardItem()
		{
			return new CommonItemSmallItemGrid
			{
				ShowReceivedCallBack = ((TItem _) => ActivityTetrisController.Instance.GetTetrisData().CheckChallengeComplete(this.Levels[this.DifficultyIndex].Id))
			};
		}

		// Token: 0x0603E435 RID: 255029 RVA: 0x00F08660 File Offset: 0x00F06860
		private TetrisLevelDetailGridView InitDifficultyItem()
		{
			TetrisLevelDetailGridView tetrisLevelDetailGridView = new TetrisLevelDetailGridView();
			this.GridViews.Add(tetrisLevelDetailGridView);
			return tetrisLevelDetailGridView;
		}

		// Token: 0x0603E436 RID: 255030 RVA: 0x00F08680 File Offset: 0x00F06880
		private void OnClickedEnterButton()
		{
			TetrisController.Instance.OpenActivityTetris(this.Levels[this.DifficultyIndex].Id);
		}

		// Token: 0x0603E437 RID: 255031 RVA: 0x00F086B0 File Offset: 0x00F068B0
		private void OnClickedCloseButton()
		{
			UiManager.Instance.CloseView(EUiViewName.TetrisLevelDetailView, null);
		}

		// Token: 0x0603E438 RID: 255032 RVA: 0x00F086C2 File Offset: 0x00F068C2
		public void ChangeDifficultyIndex(int value)
		{
			this.DifficultyIndex = value;
			this.RefreshAllGridToggleState();
			this.Refresh(true);
		}

		// Token: 0x0603E439 RID: 255033 RVA: 0x00F086D8 File Offset: 0x00F068D8
		private void OnClickHelpBtn()
		{
			HelpController.Instance.OpenHelpById(528);
		}

		// Token: 0x0603E43A RID: 255034 RVA: 0x00F086E9 File Offset: 0x00F068E9
		private void OnActivityClose(IReadOnlySet<int> closeActivities)
		{
			if (closeActivities.Contains(ActivityTetrisController.Instance.ActivityId))
			{
				ActivityController.Instance.ShowActivityRefreshAndBackToBattleView();
			}
		}

		// Token: 0x0402087B RID: 133243
		private const int HELP_ID = 528;

		// Token: 0x0402087C RID: 133244
		[Nullable(2)]
		private ITetrisSelectGroupData Param;

		// Token: 0x0402087D RID: 133245
		[Nullable(2)]
		private PopupCaptionItem CaptionItem;

		// Token: 0x0402087E RID: 133246
		[Nullable(2)]
		private TetrisDetailIconPanel DetailIconItem;

		// Token: 0x0402087F RID: 133247
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<CommonItemSmallItemGrid, TItem> RewardListScroll;

		// Token: 0x04020880 RID: 133248
		private GenericLayout<TetrisLevelDetailGridView, Tetris> DifficultyScroll;

		// Token: 0x04020881 RID: 133249
		private GenericLayout<TetrisTargetItemPanel, ITetrisTargetData> TargetListScroll;

		// Token: 0x04020882 RID: 133250
		private int DifficultyIndex;

		// Token: 0x04020883 RID: 133251
		[Nullable(2)]
		private IReadOnlyList<Tetris> Levels;

		// Token: 0x04020884 RID: 133252
		[Nullable(2)]
		private LevelSequencePlayer ViewSequencePlayer;

		// Token: 0x04020885 RID: 133253
		private readonly List<TetrisLevelDetailGridView> GridViews = new List<TetrisLevelDetailGridView>();

		// Token: 0x04020886 RID: 133254
		[Nullable(2)]
		private LockBtnPanel LockBtnItem;
	}
}
