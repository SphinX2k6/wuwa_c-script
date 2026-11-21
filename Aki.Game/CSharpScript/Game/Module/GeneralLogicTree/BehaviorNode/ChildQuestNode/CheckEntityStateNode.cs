using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Aki.TDConfigMgr.Quest;
using Google.Protobuf.Collections;

namespace CSharpScript.Game.Module.GeneralLogicTree.BehaviorNode.ChildQuestNode
{
	// Token: 0x020049A2 RID: 18850
	[NullableContext(1)]
	[Nullable(0)]
	public class CheckEntityStateNode : ChildQuestNodeBase
	{
		// Token: 0x0602F369 RID: 193385 RVA: 0x00D2A7D4 File Offset: 0x00D289D4
		public CheckEntityStateNode(int nodeId) : base(nodeId)
		{
		}

		// Token: 0x17005F5E RID: 24414
		// (get) Token: 0x0602F36A RID: 193386 RVA: 0x00D2A7E8 File Offset: 0x00D289E8
		protected override List<int> CorrelativeEntities
		{
			get
			{
				return this.InnerCorrelativeEntities;
			}
		}

		// Token: 0x0602F36B RID: 193387 RVA: 0x00D2A7F0 File Offset: 0x00D289F0
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

		// Token: 0x0602F36C RID: 193388 RVA: 0x00D2A8A8 File Offset: 0x00D28AA8
		protected override bool OnUpdateProgress(ChildQuestNodeProgress progress)
		{
			if (progress.EntityStateList == null)
			{
				return false;
			}
			this.Progress = progress.EntityStateList;
			return true;
		}

		// Token: 0x0602F36D RID: 193389 RVA: 0x00D2A8C4 File Offset: 0x00D28AC4
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

		// Token: 0x0602F36E RID: 193390 RVA: 0x00D2A900 File Offset: 0x00D28B00
		public override string GetProgressMax()
		{
			return this.InnerCorrelativeEntities.Count.ToString();
		}

		// Token: 0x040190B5 RID: 102581
		[Nullable(2)]
		private EntityStateProgress Progress;

		// Token: 0x040190B6 RID: 102582
		private readonly List<int> InnerCorrelativeEntities = new List<int>();
	}
}
