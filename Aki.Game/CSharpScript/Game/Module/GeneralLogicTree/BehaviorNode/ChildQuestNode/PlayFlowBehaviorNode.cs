using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest;

namespace CSharpScript.Game.Module.GeneralLogicTree.BehaviorNode.ChildQuestNode
{
	// Token: 0x020049B4 RID: 18868
	public class PlayFlowBehaviorNode : ChildQuestNodeBase
	{
		// Token: 0x0602F404 RID: 193540 RVA: 0x00D2D206 File Offset: 0x00D2B406
		public PlayFlowBehaviorNode(int nodeId) : base(nodeId)
		{
		}

		// Token: 0x0602F405 RID: 193541 RVA: 0x00D2D210 File Offset: 0x00D2B410
		[NullableContext(1)]
		protected override bool OnCreate(IBtNode nodeConfig)
		{
			IChildQuestBtNode childQuestBtNode = nodeConfig as IChildQuestBtNode;
			return childQuestBtNode != null && base.OnCreate(nodeConfig) && childQuestBtNode.Condition.Type == EChildQuest.PlayFlow;
		}
	}
}
