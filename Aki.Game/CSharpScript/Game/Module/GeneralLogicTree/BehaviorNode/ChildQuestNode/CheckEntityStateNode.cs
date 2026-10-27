using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Aki.TDConfigMgr.Quest;
using Google.Protobuf.Collections;

namespace CSharpScript.Game.Module.GeneralLogicTree.BehaviorNode.ChildQuestNode
{
	// Token: 0x020059C9 RID: 22985
	[NullableContext(1)]
	[Nullable(0)]
	public class CheckEntityStateNode : ChildQuestNodeBase
	{
		// Token: 0x0603A442 RID: 238658 RVA: 0x00DDAF4C File Offset: 0x00DD914C
		public CheckEntityStateNode(int nodeId) : base(nodeId)
		{
		}

		// Token: 0x17008B91 RID: 35729
		// (get) Token: 0x0603A443 RID: 238659 RVA: 0x00DDAF60 File Offset: 0x00DD9160
		protected override List<int> CorrelativeEntities
		{
			get
			{
				return this.InnerCorrelativeEntities;
			}
		}

		// Token: 0x0603A444 RID: 238660 RVA: 0x00DDAF68 File Offset: 0x00DD9168
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
			ICheckEntityStateQuestCondition checkEntityStateQuestCondition = childQuestBtNode.Condition as ICheckEntityStateQuestCondition;
			if (checkEntityStateQuestCondition == null)
			{
				return false;
			}
			this.InnerCorrelativeEntities.Clear();
			if (checkEntityStateQuestCondition.Conditions != null)
			{
				this.InnerCorrelativeEntities.EnsureCapacity(checkEntityStateQuestCondition.Conditions.Count);
				foreach (IEntityStateCondition entityStateCondition in checkEntityStateQuestCondition.Conditions)
				{
					this.InnerCorrelativeEntities.Add(entityStateCondition.EntityId);
				}
			}
			this.TrackTextRuleInner = ENodeTrackTextRule.Progress;
			return true;
		}

		// Token: 0x0603A445 RID: 238661 RVA: 0x00DDB020 File Offset: 0x00DD9220
		protected override bool OnUpdateProgress(ChildQuestNodeProgress progress)
		{
			if (progress.EntityStateList == null)
			{
				return false;
			}
			this.Progress = progress.EntityStateList;
			return true;
		}

		// Token: 0x0603A446 RID: 238662 RVA: 0x00DDB03C File Offset: 0x00DD923C
		public override string GetProgress()
		{
			EntityStateProgress progress = this.Progress;
			string text;
			if (progress == null)
			{
				text = null;
			}
			else
			{
				RepeatedField<int> entityId = progress.EntityId;
				text = ((entityId != null) ? entityId.Count.ToString() : null);
			}
			return text ?? "0";
		}

		// Token: 0x0603A447 RID: 238663 RVA: 0x00DDB078 File Offset: 0x00DD9278
		public override string GetProgressMax()
		{
			return this.InnerCorrelativeEntities.Count.ToString();
		}

		// Token: 0x0401E616 RID: 124438
		[Nullable(2)]
		private EntityStateProgress Progress;

		// Token: 0x0401E617 RID: 124439
		private readonly List<int> InnerCorrelativeEntities = new List<int>();
	}
}
