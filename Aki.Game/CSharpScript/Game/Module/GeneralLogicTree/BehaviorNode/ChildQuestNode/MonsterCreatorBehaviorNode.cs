using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Aki.TDConfigMgr.Quest;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.GeneralLogicTree.BehaviorNode.ChildQuestNode
{
	// Token: 0x020059D8 RID: 23000
	[NullableContext(1)]
	[Nullable(0)]
	public class MonsterCreatorBehaviorNode : ChildQuestNodeBase
	{
		// Token: 0x0603A4C8 RID: 238792 RVA: 0x00DDD13A File Offset: 0x00DDB33A
		public MonsterCreatorBehaviorNode(int nodeId) : base(nodeId)
		{
		}

		// Token: 0x17008B9F RID: 35743
		// (get) Token: 0x0603A4C9 RID: 238793 RVA: 0x00DDD14E File Offset: 0x00DDB34E
		protected override List<int> CorrelativeEntities
		{
			get
			{
				return this.InnerCorrelativeEntities;
			}
		}

		// Token: 0x0603A4CA RID: 238794 RVA: 0x00DDD158 File Offset: 0x00DDB358
		protected override bool OnCreate(IBtNode nodeConfig)
		{
			IChildQuestBtNode childQuestBtNode = nodeConfig as IChildQuestBtNode;
			if (childQuestBtNode == null)
			{
				return false;
			}
			if (!base.OnCreate(nodeConfig))
			{
				return false;
			}
			IMonsterCreatorQuestCondition monsterCreatorQuestCondition = childQuestBtNode.Condition as IMonsterCreatorQuestCondition;
			if (monsterCreatorQuestCondition == null || monsterCreatorQuestCondition.MonsterCreatorEntityIds == null)
			{
				return false;
			}
			this.TrackTextRuleInner = ENodeTrackTextRule.Progress;
			this.InnerCorrelativeEntities.Clear();
			this.InnerCorrelativeEntities.AddRange(monsterCreatorQuestCondition.MonsterCreatorEntityIds);
			this.ShowMonsterMergedHpBar = monsterCreatorQuestCondition.ShowMonsterMergedHpBar.GetValueOrDefault();
			this.TidMonsterGroupName = monsterCreatorQuestCondition.TidMonsterGroupName;
			this.KilledCount = 0;
			return true;
		}

		// Token: 0x0603A4CB RID: 238795 RVA: 0x00DDD1E0 File Offset: 0x00DDB3E0
		protected override bool OnUpdateProgress(ChildQuestNodeProgress progress)
		{
			if (progress.MonsterCreator == null)
			{
				return false;
			}
			this.KilledCount = 0;
			this.TotalCount = progress.MonsterCreator.TotalNum;
			foreach (MonsterCreatorProgressSlot monsterCreatorProgressSlot in progress.MonsterCreator.Slots)
			{
				this.KilledCount += monsterCreatorProgressSlot.KillMonIds.Count;
				EventSystem.Instance.Emit<int, IReadOnlyList<int>>(EEventName.GeneralLogicTreeEntityKilled, base.NodeId, monsterCreatorProgressSlot.KillMonIds);
			}
			return true;
		}

		// Token: 0x0603A4CC RID: 238796 RVA: 0x00DDD284 File Offset: 0x00DDB484
		public override string GetProgress()
		{
			return this.KilledCount.ToString();
		}

		// Token: 0x0603A4CD RID: 238797 RVA: 0x00DDD291 File Offset: 0x00DDB491
		public override string GetProgressMax()
		{
			return this.TotalCount.ToString();
		}

		// Token: 0x0603A4CE RID: 238798 RVA: 0x00DDD29E File Offset: 0x00DDB49E
		public bool GetShowMonsterMergedHpBar()
		{
			return this.ShowMonsterMergedHpBar;
		}

		// Token: 0x0603A4CF RID: 238799 RVA: 0x00DDD2A6 File Offset: 0x00DDB4A6
		[NullableContext(2)]
		public string GetTidMonsterGroupName()
		{
			return this.TidMonsterGroupName;
		}

		// Token: 0x0603A4D0 RID: 238800 RVA: 0x00DDD2AE File Offset: 0x00DDB4AE
		public List<int> GetTest()
		{
			return this.InnerCorrelativeEntities;
		}

		// Token: 0x0401E646 RID: 124486
		private int KilledCount;

		// Token: 0x0401E647 RID: 124487
		private int TotalCount;

		// Token: 0x0401E648 RID: 124488
		private readonly List<int> InnerCorrelativeEntities = new List<int>();

		// Token: 0x0401E649 RID: 124489
		private bool ShowMonsterMergedHpBar;

		// Token: 0x0401E64A RID: 124490
		[Nullable(2)]
		private string TidMonsterGroupName;
	}
}
