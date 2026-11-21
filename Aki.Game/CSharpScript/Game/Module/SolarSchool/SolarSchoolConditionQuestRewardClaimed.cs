using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.ActivityCondition;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x0200589F RID: 22687
	[NullableContext(1)]
	[Nullable(0)]
	public class SolarSchoolConditionQuestRewardClaimed : ActivityConditionProgressBase
	{
		// Token: 0x17006B44 RID: 27460
		// (get) Token: 0x06037E4E RID: 228942 RVA: 0x00FA0B65 File Offset: 0x00F9ED65
		protected override bool CanListenInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06037E4F RID: 228943 RVA: 0x00FA0B68 File Offset: 0x00F9ED68
		protected override bool OnInitialize(ConditionParams p)
		{
			this.QuestIds = p.GetIntList("QuestId").ToArray();
			this.TargetCount = p.GetInt("Count", this.QuestIds.Length);
			return true;
		}

		// Token: 0x06037E50 RID: 228944 RVA: 0x00FA0B9C File Offset: 0x00F9ED9C
		public override int GetCurrent()
		{
			int num = 0;
			SolarSchoolQuestData questData = SolarSchoolGamePlayModel.Instance.QuestData;
			foreach (int questId in this.QuestIds)
			{
				SolarSchoolSingleQuestData questData2 = questData.GetQuestData(questId);
				if (questData2 != null && questData2.ProgressRewarded)
				{
					num++;
				}
			}
			return num;
		}

		// Token: 0x06037E51 RID: 228945 RVA: 0x00FA0BEB File Offset: 0x00F9EDEB
		public override int GetTarget()
		{
			return this.TargetCount;
		}

		// Token: 0x06037E52 RID: 228946 RVA: 0x00FA0BF3 File Offset: 0x00F9EDF3
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<int>(EEventName.SolarSchoolQuestRewardClaimed, new Action<int>(this.OnQuestRewardClaimed));
		}

		// Token: 0x06037E53 RID: 228947 RVA: 0x00FA0C11 File Offset: 0x00F9EE11
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove<int>(EEventName.SolarSchoolQuestRewardClaimed, new Action<int>(this.OnQuestRewardClaimed));
		}

		// Token: 0x06037E54 RID: 228948 RVA: 0x00FA0C2F File Offset: 0x00F9EE2F
		protected override void OnClear()
		{
			this.QuestIds = Array.Empty<int>();
			this.TargetCount = 0;
		}

		// Token: 0x06037E55 RID: 228949 RVA: 0x00FA0C43 File Offset: 0x00F9EE43
		private void OnQuestRewardClaimed(int questId)
		{
			if (Array.IndexOf<int>(this.QuestIds, questId) >= 0)
			{
				base.FinishExecute();
			}
		}

		// Token: 0x0401D7E4 RID: 120804
		private int[] QuestIds = Array.Empty<int>();

		// Token: 0x0401D7E5 RID: 120805
		private int TargetCount;
	}
}
