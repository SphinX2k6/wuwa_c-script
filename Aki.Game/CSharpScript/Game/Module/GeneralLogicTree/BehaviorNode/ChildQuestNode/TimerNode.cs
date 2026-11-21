using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest;

namespace CSharpScript.Game.Module.GeneralLogicTree.BehaviorNode.ChildQuestNode
{
	// Token: 0x020049BF RID: 18879
	public class TimerNode : ChildQuestNodeBase
	{
		// Token: 0x0602F454 RID: 193620 RVA: 0x00D2ED34 File Offset: 0x00D2CF34
		public TimerNode(int nodeId) : base(nodeId)
		{
		}

		// Token: 0x0602F455 RID: 193621 RVA: 0x00D2ED40 File Offset: 0x00D2CF40
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

		// Token: 0x04019123 RID: 102691
		[Nullable(2)]
		public ITimerUiConfig TimerUiConfig;
	}
}
