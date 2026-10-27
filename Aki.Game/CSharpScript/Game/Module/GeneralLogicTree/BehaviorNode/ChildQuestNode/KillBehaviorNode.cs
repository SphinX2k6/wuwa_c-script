using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Aki.TDConfigMgr.Quest;
using CSharpScript.Game.Common.Event;
using Google.Protobuf.Collections;

namespace CSharpScript.Game.Module.GeneralLogicTree.BehaviorNode.ChildQuestNode
{
	// Token: 0x020059D6 RID: 22998
	[NullableContext(1)]
	[Nullable(0)]
	public class KillBehaviorNode : ChildQuestNodeBase
	{
		// Token: 0x0603A4BD RID: 238781 RVA: 0x00DDCF48 File Offset: 0x00DDB148
		public KillBehaviorNode(int nodeId) : base(nodeId)
		{
		}

		// Token: 0x17008B9E RID: 35742
		// (get) Token: 0x0603A4BE RID: 238782 RVA: 0x00DDCF5C File Offset: 0x00DDB15C
		protected override List<int> CorrelativeEntities
		{
			get
			{
				return this.InnerCorrelativeEntities;
			}
		}

		// Token: 0x0603A4BF RID: 238783 RVA: 0x00DDCF64 File Offset: 0x00DDB164
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

		// Token: 0x0603A4C0 RID: 238784 RVA: 0x00DDCFFD File Offset: 0x00DDB1FD
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

		// Token: 0x0603A4C1 RID: 238785 RVA: 0x00DDD038 File Offset: 0x00DDB238
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

		// Token: 0x0603A4C2 RID: 238786 RVA: 0x00DDD084 File Offset: 0x00DDB284
		public override string GetProgressMax()
		{
			if (this.Progress == null)
			{
				return this.MaxCount.ToString();
			}
			return this.Progress.TotalNum.ToString();
		}

		// Token: 0x0401E642 RID: 124482
		[Nullable(2)]
		private KillProgress Progress;

		// Token: 0x0401E643 RID: 124483
		private readonly List<int> InnerCorrelativeEntities = new List<int>();

		// Token: 0x0401E644 RID: 124484
		private int MaxCount;
	}
}
