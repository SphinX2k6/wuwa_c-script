using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest;
using CSharpScript.Game.Module.GeneralLogicTree.BehaviorNode.ChildQuestNode;

namespace CSharpScript.Game.Module
{
	// Token: 0x020046F4 RID: 18164
	[NullableContext(2)]
	[Nullable(0)]
	public class TimerNode : ChildQuestNodeBase
	{
		// Token: 0x0602F811 RID: 194577 RVA: 0x00B034E7 File Offset: 0x00B016E7
		public TimerNode(int nodeId) : base(nodeId)
		{
		}

		// Token: 0x1700768B RID: 30347
		// (get) Token: 0x0602F812 RID: 194578 RVA: 0x00B034F0 File Offset: 0x00B016F0
		protected override List<int> CorrelativeEntities
		{
			get
			{
				return null;
			}
		}

		// Token: 0x0602F813 RID: 194579 RVA: 0x00B034F4 File Offset: 0x00B016F4
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

		// Token: 0x04019AA3 RID: 105123
		public ITimerUiConfig TimerUiConfig;
	}
}
