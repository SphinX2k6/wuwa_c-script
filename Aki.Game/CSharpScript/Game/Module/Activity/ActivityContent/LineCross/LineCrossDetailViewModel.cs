using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Reward;

namespace CSharpScript.Game.Module.Activity.ActivityContent.LineCross
{
	// Token: 0x02006562 RID: 25954
	[NullableContext(2)]
	[Nullable(0)]
	public class LineCrossDetailViewModel
	{
		// Token: 0x17009543 RID: 38211
		// (get) Token: 0x0604109E RID: 266398 RVA: 0x00FC3564 File Offset: 0x00FC1764
		// (set) Token: 0x0604109F RID: 266399 RVA: 0x00FC356C File Offset: 0x00FC176C
		public LineCrossActivityData LineCrossActivityData { get; set; }

		// Token: 0x17009544 RID: 38212
		// (get) Token: 0x060410A0 RID: 266400 RVA: 0x00FC3575 File Offset: 0x00FC1775
		// (set) Token: 0x060410A1 RID: 266401 RVA: 0x00FC357D File Offset: 0x00FC177D
		private LineCrossDetailView Panel { get; set; }

		// Token: 0x060410A2 RID: 266402 RVA: 0x00FC3588 File Offset: 0x00FC1788
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

		// Token: 0x060410A3 RID: 266403 RVA: 0x00FC35FE File Offset: 0x00FC17FE
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

		// Token: 0x060410A4 RID: 266404 RVA: 0x00FC3631 File Offset: 0x00FC1831
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

		// Token: 0x060410A5 RID: 266405 RVA: 0x00FC366C File Offset: 0x00FC186C
		public bool GetCurrentChallengeFinishRewardState()
		{
			LineCrossActivityData lineCrossActivityData = ActivityModel.Instance.GetActivityById(this.LineCrossActivityData.Id) as LineCrossActivityData;
			return lineCrossActivityData != null && lineCrossActivityData.GetChallengeIfGetReward(this.SelectChallengeId);
		}

		// Token: 0x060410A6 RID: 266406 RVA: 0x00FC36A8 File Offset: 0x00FC18A8
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

		// Token: 0x060410A7 RID: 266407 RVA: 0x00FC36F8 File Offset: 0x00FC18F8
		private void RefreshDifficultItem()
		{
			int[] source = LineCrossConfig.Instance.GetLineCrossGroupByGroupId(this.GroupId).Value.GetChallengeListArray() ?? Array.Empty<int>();
			LineCrossDetailView panel = this.Panel;
			if (panel == null)
			{
				return;
			}
			panel.RefreshDifficultItem(source.ToList<int>(), this.SelectChallengeId);
		}

		// Token: 0x060410A8 RID: 266408 RVA: 0x00FC374B File Offset: 0x00FC194B
		private void RefreshDifficultSelection()
		{
			LineCrossDetailView panel = this.Panel;
			if (panel == null)
			{
				return;
			}
			panel.RefreshDifficultItemSelection(this.SelectChallengeId);
		}

		// Token: 0x060410A9 RID: 266409 RVA: 0x00FC3764 File Offset: 0x00FC1964
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

		// Token: 0x060410AA RID: 266410 RVA: 0x00FC378C File Offset: 0x00FC198C
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

		// Token: 0x060410AB RID: 266411 RVA: 0x00FC37CC File Offset: 0x00FC19CC
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

		// Token: 0x060410AC RID: 266412 RVA: 0x00FC380C File Offset: 0x00FC1A0C
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

		// Token: 0x060410AD RID: 266413 RVA: 0x00FC384C File Offset: 0x00FC1A4C
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

		// Token: 0x060410AE RID: 266414 RVA: 0x00FC38A3 File Offset: 0x00FC1AA3
		private void PlaySwitchSequence()
		{
			LineCrossDetailView panel = this.Panel;
			if (panel == null)
			{
				return;
			}
			panel.PlaySwitchSequence();
		}

		// Token: 0x060410AF RID: 266415 RVA: 0x00FC38B8 File Offset: 0x00FC1AB8
		[NullableContext(1)]
		public string GetChallengeTitleId(int challengeId)
		{
			return LineCrossConfig.Instance.GetLineCrossChallengeById(challengeId).Value.SubTitle;
		}

		// Token: 0x060410B0 RID: 266416 RVA: 0x00FC38E0 File Offset: 0x00FC1AE0
		public bool GetChallengeLockState(int challengeId)
		{
			return !LineCrossModel.Instance.GetChallengeRequireFinishState(this.LineCrossActivityData.Id, challengeId);
		}

		// Token: 0x060410B1 RID: 266417 RVA: 0x00FC38FC File Offset: 0x00FC1AFC
		public bool GetChallengeFinishState(int challengeId)
		{
			LineCrossActivityData lineCrossActivityData = ActivityModel.Instance.GetActivityById(this.LineCrossActivityData.Id) as LineCrossActivityData;
			return lineCrossActivityData != null && lineCrossActivityData.GetChallengeIfGetReward(challengeId);
		}

		// Token: 0x060410B2 RID: 266418 RVA: 0x00FC3930 File Offset: 0x00FC1B30
		public int GetCurrentChallengeId()
		{
			return this.SelectChallengeId;
		}

		// Token: 0x060410B3 RID: 266419 RVA: 0x00FC3938 File Offset: 0x00FC1B38
		public void SaveCurrentChallengeRedDotState()
		{
			int currentChallengeId = this.GetCurrentChallengeId();
			LineCrossModel.Instance.SaveChallengeRedDotState(this.LineCrossActivityData.Id, currentChallengeId);
			EventSystem.Instance.Emit<int>(EEventName.RefreshLineCrossGroupRedDot, this.GroupId);
			EventSystem.Instance.Emit<int>(EEventName.RefreshLineCrossChallengeRedDot, currentChallengeId);
		}

		// Token: 0x04021E76 RID: 138870
		private int SelectChallengeId;

		// Token: 0x04021E77 RID: 138871
		public int GroupId;

		// Token: 0x04021E78 RID: 138872
		public int GridIndex;
	}
}
