using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Aki.TDConfigMgr.Quest;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.GeneralLogicTree.BehaviorNode.ChildQuestNode
{
	// Token: 0x020049B1 RID: 18865
	[NullableContext(1)]
	[Nullable(0)]
	public class MonsterCreatorBehaviorNode : ChildQuestNodeBase
	{
		// Token: 0x0602F3F0 RID: 193520 RVA: 0x00D2C95A File Offset: 0x00D2AB5A
		public MonsterCreatorBehaviorNode(int nodeId) : base(nodeId)
		{
		}

		// Token: 0x17005F6C RID: 24428
		// (get) Token: 0x0602F3F1 RID: 193521 RVA: 0x00D2C96E File Offset: 0x00D2AB6E
		protected override List<int> CorrelativeEntities
		{
			get
			{
				return this.InnerCorrelativeEntities;
			}
		}

		// Token: 0x0602F3F2 RID: 193522 RVA: 0x00D2C978 File Offset: 0x00D2AB78
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

		// Token: 0x0602F3F3 RID: 193523 RVA: 0x00D2CA00 File Offset: 0x00D2AC00
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

		// Token: 0x0602F3F4 RID: 193524 RVA: 0x00D2CAA4 File Offset: 0x00D2ACA4
		public override string GetProgress()
		{
			return this.KilledCount.ToString();
		}

		// Token: 0x0602F3F5 RID: 193525 RVA: 0x00D2CAB1 File Offset: 0x00D2ACB1
		public override string GetProgressMax()
		{
			return this.TotalCount.ToString();
		}

		// Token: 0x0602F3F6 RID: 193526 RVA: 0x00D2CABE File Offset: 0x00D2ACBE
		public bool GetShowMonsterMergedHpBar()
		{
			return this.ShowMonsterMergedHpBar;
		}

		// Token: 0x0602F3F7 RID: 193527 RVA: 0x00D2CAC6 File Offset: 0x00D2ACC6
		[NullableContext(2)]
		public string GetTidMonsterGroupName()
		{
			return this.TidMonsterGroupName;
		}

		// Token: 0x0602F3F8 RID: 193528 RVA: 0x00D2CACE File Offset: 0x00D2ACCE
		public List<int> GetTest()
		{
			return this.InnerCorrelativeEntities;
		}

		// Token: 0x040190E5 RID: 102629
		private int KilledCount;

		// Token: 0x040190E6 RID: 102630
		private int TotalCount;

		// Token: 0x040190E7 RID: 102631
		private readonly List<int> InnerCorrelativeEntities = new List<int>();

		// Token: 0x040190E8 RID: 102632
		private bool ShowMonsterMergedHpBar;

		// Token: 0x040190E9 RID: 102633
		[Nullable(2)]
		private string TidMonsterGroupName;
	}
}
