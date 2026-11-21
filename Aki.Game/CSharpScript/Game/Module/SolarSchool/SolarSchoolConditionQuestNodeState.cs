using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.ActivityCondition;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x0200589E RID: 22686
	[NullableContext(1)]
	[Nullable(0)]
	public class SolarSchoolConditionQuestNodeState : ActivityConditionProgressBase
	{
		// Token: 0x17006B43 RID: 27459
		// (get) Token: 0x06037E45 RID: 228933 RVA: 0x00FA0A5E File Offset: 0x00F9EC5E
		protected override bool CanListenInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06037E46 RID: 228934 RVA: 0x00FA0A61 File Offset: 0x00F9EC61
		protected override bool OnInitialize(ConditionParams p)
		{
			this.QuestNodeIds = p.GetIntList("QuestNodeId").ToArray();
			this.TargetCount = p.GetInt("Count", this.QuestNodeIds.Length);
			return true;
		}

		// Token: 0x06037E47 RID: 228935 RVA: 0x00FA0A94 File Offset: 0x00F9EC94
		public override int GetCurrent()
		{
			int num = 0;
			SolarSchoolQuestData questData = SolarSchoolGamePlayModel.Instance.QuestData;
			foreach (int nodeId in this.QuestNodeIds)
			{
				SolarSchoolQuestNodeData nodeData = questData.GetNodeData(nodeId);
				if (nodeData != null && nodeData.Completed)
				{
					num++;
				}
			}
			return num;
		}

		// Token: 0x06037E48 RID: 228936 RVA: 0x00FA0AE3 File Offset: 0x00F9ECE3
		public override int GetTarget()
		{
			return this.TargetCount;
		}

		// Token: 0x06037E49 RID: 228937 RVA: 0x00FA0AEB File Offset: 0x00F9ECEB
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<int>(EEventName.SolarSchoolQuestNodeStateChanged, new Action<int>(this.OnQuestNodeStateChanged));
		}

		// Token: 0x06037E4A RID: 228938 RVA: 0x00FA0B09 File Offset: 0x00F9ED09
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove<int>(EEventName.SolarSchoolQuestNodeStateChanged, new Action<int>(this.OnQuestNodeStateChanged));
		}

		// Token: 0x06037E4B RID: 228939 RVA: 0x00FA0B27 File Offset: 0x00F9ED27
		protected override void OnClear()
		{
			this.QuestNodeIds = Array.Empty<int>();
			this.TargetCount = 0;
		}

		// Token: 0x06037E4C RID: 228940 RVA: 0x00FA0B3B File Offset: 0x00F9ED3B
		private void OnQuestNodeStateChanged(int nodeId)
		{
			if (Array.IndexOf<int>(this.QuestNodeIds, nodeId) >= 0)
			{
				base.FinishExecute();
			}
		}

		// Token: 0x0401D7E2 RID: 120802
		private int[] QuestNodeIds = Array.Empty<int>();

		// Token: 0x0401D7E3 RID: 120803
		private int TargetCount;
	}
}
