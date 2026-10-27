using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Reward;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Encircle
{
	// Token: 0x0200666C RID: 26220
	[NullableContext(1)]
	[Nullable(0)]
	public class EncircleLevelDetailView : UiViewBase
	{
		// Token: 0x06041B63 RID: 269155 RVA: 0x00FEF831 File Offset: 0x00FEDA31
		public EncircleLevelDetailView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06041B64 RID: 269156 RVA: 0x00FEF848 File Offset: 0x00FEDA48
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIArtText)),
				new ValueTuple<int, Type>(2, typeof(UUIVerticalLayout)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUIText)),
				new ValueTuple<int, Type>(5, typeof(UUIText)),
				new ValueTuple<int, Type>(6, typeof(UUIItem)),
				new ValueTuple<int, Type>(7, typeof(UUIItem)),
				new ValueTuple<int, Type>(8, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(9, typeof(UUIItem)),
				new ValueTuple<int, Type>(10, typeof(UUIItem)),
				new ValueTuple<int, Type>(11, typeof(UUIItem)),
				new ValueTuple<int, Type>(12, typeof(UUIItem))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(8, new Action(this.OnClickedEnterButton))
			};
		}

		// Token: 0x06041B65 RID: 269157 RVA: 0x00FEF9A5 File Offset: 0x00FEDBA5
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<IReadOnlySet<int>>(EEventName.OnActivityClose, new Action<IReadOnlySet<int>>(this.OnActivityClose));
		}

		// Token: 0x06041B66 RID: 269158 RVA: 0x00FEF9C3 File Offset: 0x00FEDBC3
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove<IReadOnlySet<int>>(EEventName.OnActivityClose, new Action<IReadOnlySet<int>>(this.OnActivityClose));
		}

		// Token: 0x06041B67 RID: 269159 RVA: 0x00FEF9E4 File Offset: 0x00FEDBE4
		protected override UniTask OnBeforeStartAsync()
		{
			EncircleLevelDetailView.<OnBeforeStartAsync>d__14 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<EncircleLevelDetailView.<OnBeforeStartAsync>d__14>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06041B68 RID: 269160 RVA: 0x00FEFA28 File Offset: 0x00FEDC28
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

		// Token: 0x06041B69 RID: 269161 RVA: 0x00FEFAE8 File Offset: 0x00FEDCE8
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

		// Token: 0x06041B6A RID: 269162 RVA: 0x00FEFB65 File Offset: 0x00FEDD65
		protected override void OnBeforeShow()
		{
			this.GetCurrentDifficulty();
			this.Refresh(false);
		}

		// Token: 0x06041B6B RID: 269163 RVA: 0x00FEFB74 File Offset: 0x00FEDD74
		public void Refresh(bool isSwitch = false)
		{
			this.RefreshDesc(isSwitch);
			this.RefreshReward();
			this.RefreshNewUnlock();
			this.RefreshGridHighLight();
		}

		// Token: 0x06041B6C RID: 269164 RVA: 0x00FEFB8F File Offset: 0x00FEDD8F
		protected override void OnBeforeDestroy()
		{
			LevelSequencePlayer viewSequencePlayer = this.ViewSequencePlayer;
			if (viewSequencePlayer != null)
			{
				viewSequencePlayer.Clear();
			}
			this.ViewSequencePlayer = null;
		}

		// Token: 0x06041B6D RID: 269165 RVA: 0x00FEFBAC File Offset: 0x00FEDDAC
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

		// Token: 0x06041B6E RID: 269166 RVA: 0x00FEFC30 File Offset: 0x00FEDE30
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

		// Token: 0x06041B6F RID: 269167 RVA: 0x00FEFC90 File Offset: 0x00FEDE90
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

		// Token: 0x06041B70 RID: 269168 RVA: 0x00FEFE1C File Offset: 0x00FEE01C
		private void RefreshReward()
		{
			int challengeId = this.Levels[this.DifficultyIndex];
			int rewardId = ActivityEncircleConfig.Instance.GetEncircleChallengeConfig(challengeId).Value.RewardId;
			List<TItem> dropPackagePreviewItemList = CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetDropPackagePreviewItemList(rewardId);
			this.RewardListComponent.RefreshItemLayout(dropPackagePreviewItemList.ToArray(), null);
		}

		// Token: 0x06041B71 RID: 269169 RVA: 0x00FEFE72 File Offset: 0x00FEE072
		private void RefreshScroller()
		{
			this.DifficultyScroll.RefreshByData(this.Levels.ToList<int>(), null, false);
		}

		// Token: 0x06041B72 RID: 269170 RVA: 0x00FEFE8C File Offset: 0x00FEE08C
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

		// Token: 0x06041B73 RID: 269171 RVA: 0x00FEFEA8 File Offset: 0x00FEE0A8
		private EncircleLevelDetailGridView UpdateItem()
		{
			EncircleLevelDetailGridView encircleLevelDetailGridView = new EncircleLevelDetailGridView();
			this.GridViews.Add(encircleLevelDetailGridView);
			return encircleLevelDetailGridView;
		}

		// Token: 0x06041B74 RID: 269172 RVA: 0x00FEFEC8 File Offset: 0x00FEE0C8
		private void OnClickedEnterButton()
		{
			if (!ActivityEncircleController.Instance.GetEncircleData().CheckPreChallengeComplete(this.Levels[this.DifficultyIndex]))
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("Encirle_DifficultyLockTips_Text", Array.Empty<object>());
				return;
			}
			EncirclePlayLevelController.Instance.EnterPlay(this.Param.GroupId, this.Levels[this.DifficultyIndex]);
		}

		// Token: 0x06041B75 RID: 269173 RVA: 0x00FEFF2A File Offset: 0x00FEE12A
		private void OnClickedCloseButton()
		{
			UiManager.Instance.CloseView(EUiViewName.EncircleLevelDetailView, null);
		}

		// Token: 0x06041B76 RID: 269174 RVA: 0x00FEFF3C File Offset: 0x00FEE13C
		public void ChangeDifficultyIndex(int value)
		{
			this.DifficultyIndex = value;
			this.Refresh(true);
		}

		// Token: 0x06041B77 RID: 269175 RVA: 0x00FEFF4C File Offset: 0x00FEE14C
		private void OnClickHelpBtn()
		{
			HelpController.Instance.OpenHelpById(507);
		}

		// Token: 0x06041B78 RID: 269176 RVA: 0x00FEFF5D File Offset: 0x00FEE15D
		private void OnActivityClose(IReadOnlySet<int> closeActivities)
		{
			if (closeActivities.Contains(ActivityEncircleController.Instance.ActivityId))
			{
				ActivityController.Instance.ShowActivityRefreshAndBackToBattleView();
			}
		}

		// Token: 0x040222FC RID: 140028
		private const int HELP_ID = 507;

		// Token: 0x040222FD RID: 140029
		[Nullable(2)]
		private IDetailArgs Param;

		// Token: 0x040222FE RID: 140030
		[Nullable(2)]
		private PopupCaptionItem CaptionItem;

		// Token: 0x040222FF RID: 140031
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private ActivityRewardList<CommonItemSmallItemGrid, TItem> RewardListComponent;

		// Token: 0x04022300 RID: 140032
		private GenericLayout<EncircleLevelDetailGridView, int> DifficultyScroll;

		// Token: 0x04022301 RID: 140033
		private int DifficultyIndex;

		// Token: 0x04022302 RID: 140034
		private int GroupId;

		// Token: 0x04022303 RID: 140035
		[Nullable(2)]
		private int[] Levels;

		// Token: 0x04022304 RID: 140036
		[Nullable(2)]
		private LevelSequencePlayer ViewSequencePlayer;

		// Token: 0x04022305 RID: 140037
		private readonly List<EncircleLevelDetailGridView> GridViews = new List<EncircleLevelDetailGridView>();
	}
}
