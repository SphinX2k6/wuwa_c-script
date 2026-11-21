using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Aki.TDConfigMgr.Quest;
using CSharpScript.Game.Common.Event;
using Google.Protobuf.Collections;

namespace CSharpScript.Game.Module.GeneralLogicTree.BehaviorNode.ChildQuestNode
{
	// Token: 0x020049AF RID: 18863
	[NullableContext(1)]
	[Nullable(0)]
	public class KillBehaviorNode : ChildQuestNodeBase
	{
		// Token: 0x0602F3E4 RID: 193508 RVA: 0x00D2C728 File Offset: 0x00D2A928
		public KillBehaviorNode(int nodeId) : base(nodeId)
		{
		}

		// Token: 0x17005F6B RID: 24427
		// (get) Token: 0x0602F3E5 RID: 193509 RVA: 0x00D2C73C File Offset: 0x00D2A93C
		protected override List<int> CorrelativeEntities
		{
			get
			{
				return this.InnerCorrelativeEntities;
			}
		}

		// Token: 0x0602F3E6 RID: 193510 RVA: 0x00D2C744 File Offset: 0x00D2A944
		protected override bool OnCreate(IBtNode config)
		{
			IChildQuestBtNode childQuestBtNode = config as IChildQuestBtNode;
			if (childQuestBtNode == null)
			{
				return false;
			}
			if (!base.OnCreate(config))
			{
				return false;
			}
			IKillChildQuestCondition killChildQuestCondition = childQuestBtNode.Condition as IKillChildQuestCondition;
			if (killChildQuestCondition == null)
			{
				return false;
			}
			this.TrackTextRuleInner = ENodeTrackTextRule.Progress;
			this.MaxCount = killChildQuestCondition.ExistTargets.Count + killChildQuestCondition.TargetsToAwake.Count;
			this.InnerCorrelativeEntities.Clear();
			this.InnerCorrelativeEntities.EnsureCapacity(this.MaxCount);
			this.InnerCorrelativeEntities.AddRange(killChildQuestCondition.ExistTargets);
			this.InnerCorrelativeEntities.AddRange(killChildQuestCondition.TargetsToAwake);
			return true;
		}

		// Token: 0x0602F3E7 RID: 193511 RVA: 0x00D2C7DD File Offset: 0x00D2A9DD
		protected override bool OnUpdateProgress(ChildQuestNodeProgress progress)
		{
			if (progress.Kill == null)
			{
				return false;
			}
			this.Progress = progress.Kill;
			EventSystem.Instance.Emit<int, IReadOnlyList<int>>(EEventName.GeneralLogicTreeEntityKilled, base.NodeId, this.Progress.MonId);
			return true;
		}

		// Token: 0x0602F3E8 RID: 193512 RVA: 0x00D2C818 File Offset: 0x00D2AA18
		public override string GetProgress()
		{
			if (base.IsSuccess)
			{
				return this.GetProgressMax();
			}
			KillProgress progress = this.Progress;
			string text;
			if (progress == null)
			{
				text = null;
			}
			else
			{
				RepeatedField<int> monId = progress.MonId;
				text = ((monId != null) ? monId.Count.ToString() : null);
			}
			return text ?? "0";
		}

		// Token: 0x0602F3E9 RID: 193513 RVA: 0x00D2C864 File Offset: 0x00D2AA64
		public override string GetProgressMax()
		{
			if (this.Progress == null)
			{
				return this.MaxCount.ToString();
			}
			return this.Progress.TotalNum.ToString();
		}

		// Token: 0x0602F3EA RID: 193514 RVA: 0x00D2C898 File Offset: 0x00D2AA98
		public string GetRoleTowerKillCount()
		{
			if (this.Progress == null)
			{
				return "0";
			}
			int num = this.Progress.TotalNum - this.Progress.CurrNum;
			return ((num > 0) ? num : 0).ToString();
		}

		// Token: 0x040190E1 RID: 102625
		[Nullable(2)]
		private KillProgress Progress;

		// Token: 0x040190E2 RID: 102626
		private readonly List<int> InnerCorrelativeEntities = new List<int>();

		// Token: 0x040190E3 RID: 102627
		private int MaxCount;
	}
}
