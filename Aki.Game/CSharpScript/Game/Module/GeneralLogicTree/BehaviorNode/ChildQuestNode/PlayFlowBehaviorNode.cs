using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest;

namespace CSharpScript.Game.Module.GeneralLogicTree.BehaviorNode.ChildQuestNode
{
	// Token: 0x020059DB RID: 23003
	public class PlayFlowBehaviorNode : ChildQuestNodeBase
	{
		// Token: 0x0603A4DC RID: 238812 RVA: 0x00DDD9E6 File Offset: 0x00DDBBE6
		public PlayFlowBehaviorNode(int nodeId) : base(nodeId)
		{
		}

		// Token: 0x0603A4DD RID: 238813 RVA: 0x00DDD9F0 File Offset: 0x00DDBBF0
		[NullableContext(1)]
		protected override bool OnCreate(IBtNode nodeConfig)
		{
			IChildQuestBtNode childQuestBtNode = nodeConfig as IChildQuestBtNode;
			return childQuestBtNode != null && base.OnCreate(nodeConfig) && childQuestBtNode.Condition.Type == EChildQuest.PlayFlow;
		}
	}
}
