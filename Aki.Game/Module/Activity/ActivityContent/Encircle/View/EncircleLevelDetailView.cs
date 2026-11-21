using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Reward;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace Aki.Game.Module.Activity.ActivityContent.Encircle.View
{
	// Token: 0x0200301C RID: 12316
	[NullableContext(1)]
	[Nullable(0)]
	public class EncircleLevelDetailView : UiViewBase
	{
		// Token: 0x0601D38B RID: 119691 RVA: 0x008EB721 File Offset: 0x008E9921
		public EncircleLevelDetailView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0601D38C RID: 119692 RVA: 0x008EB738 File Offset: 0x008E9938
		protected unsafe override void OnRegisterComponent()
		{
			int num = 13;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIArtText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIVerticalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(8, new Action(this.OnClickedEnterButton));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0601D38D RID: 119693 RVA: 0x008EB94E File Offset: 0x008E9B4E
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<IReadOnlySet<int>>(EEventName.OnActivityClose, new Action<IReadOnlySet<int>>(this.OnActivityClose));
		}

		// Token: 0x0601D38E RID: 119694 RVA: 0x008EB96C File Offset: 0x008E9B6C
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove<IReadOnlySet<int>>(EEventName.OnActivityClose, new Action<IReadOnlySet<int>>(this.OnActivityClose));
		}

		// Token: 0x0601D38F RID: 119695 RVA: 0x008EB98C File Offset: 0x008E9B8C
		protected override UniTask OnBeforeStartAsync()
		{
			EncircleLevelDetailView.<OnBeforeStartAsync>d__14 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<EncircleLevelDetailView.<OnBeforeStartAsync>d__14>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0601D390 RID: 119696 RVA: 0x008EB9D0 File Offset: 0x008E9BD0
		protected override void OnStart()
		{
			this.CaptionItem = new PopupCaptionItem(base.GetItem(0));
			this.CaptionItem.SetCloseCallBack(new Action(this.OnClickedCloseButton));
			this.CaptionItem.SetHelpCallBack(new Action(this.OnClickHelpBtn));
			this.Param = (this.OpenParam as IDetailArgs);
			int activityId = ActivityEncircleController.Instance.ActivityId;
			this.GroupId = this.Param.GroupId;
			this.Levels = ActivityEncircleConfig.Instance.GetEncircleChallenges(activityId, this.Param.GroupId);
			this.DifficultyScroll = new GenericLayout<EncircleLevelDetailGridView, int>(base.GetVerticalLayout(2), new Func<EncircleLevelDetailGridView>(this.UpdateItem), null, false, true);
			this.RefreshScroller();
		}

		// Token: 0x0601D391 RID: 119697 RVA: 0x008EBA90 File Offset: 0x008E9C90
		private void GetCurrentDifficulty()
		{
			if (this.Levels == null)
			{
				return;
			}
			ActivityEncircleData encircleData = ActivityEncircleController.Instance.GetEncircleData();
			if (encircleData == null)
			{
				return;
			}
			for (int i = 0; i < this.Levels.Length; i++)
			{
				EncircleChallenge? encircleChallengeConfig = ActivityEncircleConfig.Instance.GetEncircleChallengeConfig(this.Levels[i]);
				if (encircleChallengeConfig.Value.PreId == 0 || encircleData.CheckChallengeComplete(encircleChallengeConfig.Value.PreId))
				{
					this.DifficultyIndex = i;
				}
			}
		}

		// Token: 0x0601D392 RID: 119698 RVA: 0x008EBB0D File Offset: 0x008E9D0D
		protected override void OnBeforeShow()
		{
			this.GetCurrentDifficulty();
			this.Refresh(false);
		}

		// Token: 0x0601D393 RID: 119699 RVA: 0x008EBB1C File Offset: 0x008E9D1C
		public void Refresh(bool isSwitch = false)
		{
			this.RefreshDesc(isSwitch);
			this.RefreshReward();
			this.RefreshNewUnlock();
			this.RefreshGridHighLight();
		}

		// Token: 0x0601D394 RID: 119700 RVA: 0x008EBB37 File Offset: 0x008E9D37
		protected override void OnBeforeDestroy()
		{
			LevelSequencePlayer viewSequencePlayer = this.ViewSequencePlayer;
			if (viewSequencePlayer != null)
			{
				viewSequencePlayer.Clear();
			}
			this.ViewSequencePlayer = null;
		}

		// Token: 0x0601D395 RID: 119701 RVA: 0x008EBB54 File Offset: 0x008E9D54
		private void RefreshGridHighLight()
		{
			foreach (EncircleLevelDetailGridView encircleLevelDetailGridView in this.GridViews)
			{
				int? challengeDifficulty = encircleLevelDetailGridView.GetChallengeDifficulty();
				if (challengeDifficulty != null)
				{
					int? num = challengeDifficulty;
					int difficultyIndex = this.DifficultyIndex;
					if (num.GetValueOrDefault() == difficultyIndex & num != null)
					{
						encircleLevelDetailGridView.SetToggleActive();
					}
				}
			}
		}

		// Token: 0x0601D396 RID: 119702 RVA: 0x008EBBD8 File Offset: 0x008E9DD8
		private void RefreshNewUnlock()
		{
			ActivityEncircleData encircleData = ActivityEncircleController.Instance.GetEncircleData();
			if (encircleData == null)
			{
				return;
			}
			foreach (int challengeId in this.Levels)
			{
				if (encircleData != null && encircleData.CheckChallengeNewUnlock(challengeId))
				{
					ScrollingTipsController.Instance.ShowTipsByTextId("Encirle_LevelUnlockTips_Text", Array.Empty<object>());
					encircleData.MarkChallengeNewUnlock(challengeId, false);
				}
			}
		}

		// Token: 0x0601D397 RID: 119703 RVA: 0x008EBC38 File Offset: 0x008E9E38
		private void RefreshDesc(bool isSwitch = false)
		{
			int challengeId = this.Levels[this.DifficultyIndex];
			EncircleChallenge? encircleChallengeConfig = ActivityEncircleConfig.Instance.GetEncircleChallengeConfig(challengeId);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(4), encircleChallengeConfig.Value.LevelTitle, Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(5), encircleChallengeConfig.Value.LevelDesc, Array.Empty<object>());
			this.SetSpriteByPath(encircleChallengeConfig.Value.LevelIcon, base.GetSprite(12), false, null, null);
			UUIArtText artText = base.GetArtText(1);
			if (artText != null)
			{
				artText.SetText((this.GroupId >= 10) ? this.GroupId.ToString() : ("0" + this.GroupId.ToString()));
			}
			UUIItem item = base.GetItem(9);
			if (item != null)
			{
				item.SetUIActive(this.DifficultyIndex == 0);
			}
			UUIItem item2 = base.GetItem(10);
			if (item2 != null)
			{
				item2.SetUIActive(this.DifficultyIndex == 1);
			}
			UUIItem item3 = base.GetItem(11);
			if (item3 != null)
			{
				item3.SetUIActive(this.DifficultyIndex == 1);
			}
			UUIItem item4 = base.GetItem(12);
			if (item4 != null)
			{
				item4.SetUIActive(this.DifficultyIndex == 0);
			}
			if (isSwitch)
			{
				LevelSequencePlayer viewSequencePlayer = this.ViewSequencePlayer;
				if (viewSequencePlayer != null)
				{
					viewSequencePlayer.StopCurrentSequence(false, true);
				}
				this.ViewSequencePlayer.PlayLevelSequenceByName((this.DifficultyIndex == 1) ? "Switch" : "Switch02", false, null, false);
			}
		}

		// Token: 0x0601D398 RID: 119704 RVA: 0x008EBDC4 File Offset: 0x008E9FC4
		private void RefreshReward()
		{
			int challengeId = this.Levels[this.DifficultyIndex];
			int rewardId = ActivityEncircleConfig.Instance.GetEncircleChallengeConfig(challengeId).Value.RewardId;
			List<TItem> dropPackagePreviewItemList = CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetDropPackagePreviewItemList(rewardId);
			this.RewardListComponent.RefreshItemLayout(dropPackagePreviewItemList.ToArray(), null);
		}

		// Token: 0x0601D399 RID: 119705 RVA: 0x008EBE1A File Offset: 0x008EA01A
		private void RefreshScroller()
		{
			this.DifficultyScroll.RefreshByData(this.Levels, null, false);
		}

		// Token: 0x0601D39A RID: 119706 RVA: 0x008EBE2F File Offset: 0x008EA02F
		public CommonItemSmallItemGrid InitGridItem()
		{
			return new CommonItemSmallItemGrid
			{
				ShowReceivedCallBack = delegate(TItem _)
				{
					ActivityEncircleData encircleData = ActivityEncircleController.Instance.GetEncircleData();
					int challengeId = this.Levels[this.DifficultyIndex];
					return encircleData.CheckChallengeComplete(challengeId);
				}
			};
		}

		// Token: 0x0601D39B RID: 119707 RVA: 0x008EBE48 File Offset: 0x008EA048
		private EncircleLevelDetailGridView UpdateItem()
		{
			EncircleLevelDetailGridView encircleLevelDetailGridView = new EncircleLevelDetailGridView();
			this.GridViews.Add(encircleLevelDetailGridView);
			return encircleLevelDetailGridView;
		}

		// Token: 0x0601D39C RID: 119708 RVA: 0x008EBE68 File Offset: 0x008EA068
		private void OnClickedEnterButton()
		{
			if (!ActivityEncircleController.Instance.GetEncircleData().CheckPreChallengeComplete(this.Levels[this.DifficultyIndex]))
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("Encirle_DifficultyLockTips_Text", Array.Empty<object>());
				return;
			}
			EncirclePlayLevelController.Instance.EnterPlay(this.Param.GroupId, this.Levels[this.DifficultyIndex]);
		}

		// Token: 0x0601D39D RID: 119709 RVA: 0x008EBECA File Offset: 0x008EA0CA
		private void OnClickedCloseButton()
		{
			UiManager.Instance.CloseView(EUiViewName.EncircleLevelDetailView, null);
		}

		// Token: 0x0601D39E RID: 119710 RVA: 0x008EBEDC File Offset: 0x008EA0DC
		public void ChangeDifficultyIndex(int value)
		{
			this.DifficultyIndex = value;
			this.Refresh(true);
		}

		// Token: 0x0601D39F RID: 119711 RVA: 0x008EBEEC File Offset: 0x008EA0EC
		private void OnClickHelpBtn()
		{
			HelpController.Instance.OpenHelpById(507);
		}

		// Token: 0x0601D3A0 RID: 119712 RVA: 0x008EBEFD File Offset: 0x008EA0FD
		private void OnActivityClose(IReadOnlySet<int> closeActivities)
		{
			if (closeActivities.Contains(ActivityEncircleController.Instance.ActivityId))
			{
				ActivityController.Instance.ShowActivityRefreshAndBackToBattleView();
			}
		}

		// Token: 0x0400F606 RID: 62982
		private const int HELP_ID = 507;

		// Token: 0x0400F607 RID: 62983
		[Nullable(2)]
		private IDetailArgs Param;

		// Token: 0x0400F608 RID: 62984
		[Nullable(2)]
		private PopupCaptionItem CaptionItem;

		// Token: 0x0400F609 RID: 62985
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private ActivityRewardList<CommonItemSmallItemGrid, TItem> RewardListComponent;

		// Token: 0x0400F60A RID: 62986
		private GenericLayout<EncircleLevelDetailGridView, int> DifficultyScroll;

		// Token: 0x0400F60B RID: 62987
		private int DifficultyIndex;

		// Token: 0x0400F60C RID: 62988
		private int GroupId;

		// Token: 0x0400F60D RID: 62989
		[Nullable(2)]
		private int[] Levels;

		// Token: 0x0400F60E RID: 62990
		[Nullable(2)]
		private LevelSequencePlayer ViewSequencePlayer;

		// Token: 0x0400F60F RID: 62991
		private readonly List<EncircleLevelDetailGridView> GridViews = new List<EncircleLevelDetailGridView>();
	}
}
