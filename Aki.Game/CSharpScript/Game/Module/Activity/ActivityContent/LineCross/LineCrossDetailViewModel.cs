using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Reward;

namespace CSharpScript.Game.Module.Activity.ActivityContent.LineCross
{
	// Token: 0x020054E0 RID: 21728
	[NullableContext(2)]
	[Nullable(0)]
	public class LineCrossDetailViewModel
	{
		// Token: 0x170068A5 RID: 26789
		// (get) Token: 0x06035D63 RID: 220515 RVA: 0x00F0A54C File Offset: 0x00F0874C
		// (set) Token: 0x06035D64 RID: 220516 RVA: 0x00F0A554 File Offset: 0x00F08754
		public LineCrossActivityData LineCrossActivityData { get; set; }

		// Token: 0x170068A6 RID: 26790
		// (get) Token: 0x06035D65 RID: 220517 RVA: 0x00F0A55D File Offset: 0x00F0875D
		// (set) Token: 0x06035D66 RID: 220518 RVA: 0x00F0A565 File Offset: 0x00F08765
		private LineCrossDetailView Panel { get; set; }

		// Token: 0x06035D67 RID: 220519 RVA: 0x00F0A570 File Offset: 0x00F08770
		[NullableContext(1)]
		public void RegisterView(LineCrossDetailView view)
		{
			this.Panel = view;
			LineCrossGroup value = LineCrossConfig.Instance.GetLineCrossGroupByGroupId(this.GroupId).Value;
			this.SelectChallengeId = value.ChallengeList(0);
			for (int i = 0; i < value.ChallengeListLength; i++)
			{
				int num = value.ChallengeList(i);
				if (!LineCrossModel.Instance.GetChallengeFinishState(this.LineCrossActivityData.Id, num))
				{
					this.SelectChallengeId = num;
					return;
				}
			}
		}

		// Token: 0x06035D68 RID: 220520 RVA: 0x00F0A5E6 File Offset: 0x00F087E6
		public void OnSelectChallenge(int challengeId)
		{
			this.SelectChallengeId = challengeId;
			this.RefreshRewardLayout();
			this.RefreshTitleText();
			this.RefreshDifficultDescText();
			this.RefreshDescText();
			this.RefreshDifficultSelection();
			this.SaveCurrentChallengeRedDotState();
			this.PlaySwitchSequence();
		}

		// Token: 0x06035D69 RID: 220521 RVA: 0x00F0A619 File Offset: 0x00F08819
		public void OnShowView()
		{
			this.RefreshRewardLayout();
			this.RefreshNumSprite();
			this.RefreshDescText();
			this.RefreshTitleText();
			this.RefreshDifficultDescText();
			this.RefreshDifficultItem();
			this.RefreshDifficultSelection();
			this.RefreshMiddle();
			this.SaveCurrentChallengeRedDotState();
		}

		// Token: 0x06035D6A RID: 220522 RVA: 0x00F0A654 File Offset: 0x00F08854
		public bool GetCurrentChallengeFinishRewardState()
		{
			LineCrossActivityData lineCrossActivityData = ActivityModel.Instance.GetActivityById(this.LineCrossActivityData.Id) as LineCrossActivityData;
			return lineCrossActivityData != null && lineCrossActivityData.GetChallengeIfGetReward(this.SelectChallengeId);
		}

		// Token: 0x06035D6B RID: 220523 RVA: 0x00F0A690 File Offset: 0x00F08890
		public void RefreshRewardLayout()
		{
			int rewardId = LineCrossConfig.Instance.GetLineCrossChallengeById(this.SelectChallengeId).Value.RewardId;
			if (rewardId == 0)
			{
				return;
			}
			List<TItem> dropPackagePreviewItemList = CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetDropPackagePreviewItemList(rewardId);
			LineCrossDetailView panel = this.Panel;
			if (panel == null)
			{
				return;
			}
			panel.RefreshRewardLayout(dropPackagePreviewItemList);
		}

		// Token: 0x06035D6C RID: 220524 RVA: 0x00F0A6E0 File Offset: 0x00F088E0
		private void RefreshDifficultItem()
		{
			int[] dataList = LineCrossConfig.Instance.GetLineCrossGroupByGroupId(this.GroupId).Value.GetChallengeListArray() ?? Array.Empty<int>();
			LineCrossDetailView panel = this.Panel;
			if (panel == null)
			{
				return;
			}
			panel.RefreshDifficultItem(dataList, this.SelectChallengeId);
		}

		// Token: 0x06035D6D RID: 220525 RVA: 0x00F0A72E File Offset: 0x00F0892E
		private void RefreshDifficultSelection()
		{
			LineCrossDetailView panel = this.Panel;
			if (panel == null)
			{
				return;
			}
			panel.RefreshDifficultItemSelection(this.SelectChallengeId);
		}

		// Token: 0x06035D6E RID: 220526 RVA: 0x00F0A748 File Offset: 0x00F08948
		private void RefreshNumSprite()
		{
			int num = this.GridIndex + 1;
			LineCrossDetailView panel = this.Panel;
			if (panel == null)
			{
				return;
			}
			panel.RefreshNumText(num);
		}

		// Token: 0x06035D6F RID: 220527 RVA: 0x00F0A770 File Offset: 0x00F08970
		private void RefreshTitleText()
		{
			string name = LineCrossConfig.Instance.GetLineCrossChallengeById(this.SelectChallengeId).Value.Name;
			LineCrossDetailView panel = this.Panel;
			if (panel == null)
			{
				return;
			}
			panel.RefreshTitleText(name);
		}

		// Token: 0x06035D70 RID: 220528 RVA: 0x00F0A7B0 File Offset: 0x00F089B0
		private void RefreshDifficultDescText()
		{
			string difficultDesc = LineCrossConfig.Instance.GetLineCrossChallengeById(this.SelectChallengeId).Value.DifficultDesc;
			LineCrossDetailView panel = this.Panel;
			if (panel == null)
			{
				return;
			}
			panel.RefreshDifficultDescText(difficultDesc);
		}

		// Token: 0x06035D71 RID: 220529 RVA: 0x00F0A7F0 File Offset: 0x00F089F0
		private void RefreshDescText()
		{
			string desc = LineCrossConfig.Instance.GetLineCrossChallengeById(this.SelectChallengeId).Value.Desc;
			LineCrossDetailView panel = this.Panel;
			if (panel == null)
			{
				return;
			}
			panel.ShowDescText(desc);
		}

		// Token: 0x06035D72 RID: 220530 RVA: 0x00F0A830 File Offset: 0x00F08A30
		private void RefreshMiddle()
		{
			bool ifHiddenGroup = LineCrossModel.Instance.GetIfHiddenGroup(this.LineCrossActivityData.Id, this.GroupId);
			ELineCrossGroupState groupState = LineCrossModel.Instance.GetGroupState(this.LineCrossActivityData.Id, this.GroupId);
			LineCrossDetailView panel = this.Panel;
			if (panel == null)
			{
				return;
			}
			panel.RefreshMiddleByChallengeState(ifHiddenGroup, groupState);
		}

		// Token: 0x06035D73 RID: 220531 RVA: 0x00F0A887 File Offset: 0x00F08A87
		private void PlaySwitchSequence()
		{
			LineCrossDetailView panel = this.Panel;
			if (panel == null)
			{
				return;
			}
			panel.PlaySwitchSequence();
		}

		// Token: 0x06035D74 RID: 220532 RVA: 0x00F0A89C File Offset: 0x00F08A9C
		[NullableContext(1)]
		public string GetChallengeTitleId(int challengeId)
		{
			return LineCrossConfig.Instance.GetLineCrossChallengeById(challengeId).Value.SubTitle;
		}

		// Token: 0x06035D75 RID: 220533 RVA: 0x00F0A8C4 File Offset: 0x00F08AC4
		public bool GetChallengeLockState(int challengeId)
		{
			return !LineCrossModel.Instance.GetChallengeRequireFinishState(this.LineCrossActivityData.Id, challengeId);
		}

		// Token: 0x06035D76 RID: 220534 RVA: 0x00F0A8E0 File Offset: 0x00F08AE0
		public bool GetChallengeFinishState(int challengeId)
		{
			LineCrossActivityData lineCrossActivityData = ActivityModel.Instance.GetActivityById(this.LineCrossActivityData.Id) as LineCrossActivityData;
			return lineCrossActivityData != null && lineCrossActivityData.GetChallengeIfGetReward(challengeId);
		}

		// Token: 0x06035D77 RID: 220535 RVA: 0x00F0A914 File Offset: 0x00F08B14
		public int GetCurrentChallengeId()
		{
			return this.SelectChallengeId;
		}

		// Token: 0x06035D78 RID: 220536 RVA: 0x00F0A91C File Offset: 0x00F08B1C
		public void SaveCurrentChallengeRedDotState()
		{
			int currentChallengeId = this.GetCurrentChallengeId();
			LineCrossModel.Instance.SaveChallengeRedDotState(this.LineCrossActivityData.Id, currentChallengeId);
			EventSystem.Instance.Emit<int>(EEventName.RefreshLineCrossGroupRedDot, this.GroupId);
			EventSystem.Instance.Emit<int>(EEventName.RefreshLineCrossChallengeRedDot, currentChallengeId);
		}

		// Token: 0x0401C7A7 RID: 116647
		private int SelectChallengeId;

		// Token: 0x0401C7A8 RID: 116648
		public int GroupId;

		// Token: 0x0401C7A9 RID: 116649
		public int GridIndex;
	}
}
