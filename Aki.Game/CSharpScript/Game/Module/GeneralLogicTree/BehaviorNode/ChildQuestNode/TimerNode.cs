using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest;

namespace CSharpScript.Game.Module.GeneralLogicTree.BehaviorNode.ChildQuestNode
{
	// Token: 0x020059E6 RID: 23014
	public class TimerNode : ChildQuestNodeBase
	{
		// Token: 0x0603A52D RID: 238893 RVA: 0x00DDF4C8 File Offset: 0x00DDD6C8
		public TimerNode(int nodeId) : base(nodeId)
		{
		}

		// Token: 0x0603A52E RID: 238894 RVA: 0x00DDF4D4 File Offset: 0x00DDD6D4
		[NullableContext(1)]
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
			IQuestCondition condition = childQuestBtNode.Condition;
			if (condition.Type != EChildQuest.Timer)
			{
				return false;
			}
			this.TimerUiConfig = (condition as ITimerQuestCondition).UiConfig;
			return true;
		}

		// Token: 0x0401E684 RID: 124548
		[Nullable(2)]
		public ITimerUiConfig TimerUiConfig;
	}
}
