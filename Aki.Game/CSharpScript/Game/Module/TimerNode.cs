using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest;
using CSharpScript.Game.Module.GeneralLogicTree.BehaviorNode.ChildQuestNode;

namespace CSharpScript.Game.Module
{
	// Token: 0x02003624 RID: 13860
	[NullableContext(2)]
	[Nullable(0)]
	public class TimerNode : ChildQuestNodeBase
	{
		// Token: 0x06023FD7 RID: 147415 RVA: 0x00A331B7 File Offset: 0x00A313B7
		public TimerNode(int nodeId) : base(nodeId)
		{
		}

		// Token: 0x17004947 RID: 18759
		// (get) Token: 0x06023FD8 RID: 147416 RVA: 0x00A331C0 File Offset: 0x00A313C0
		protected override List<int> CorrelativeEntities
		{
			get
			{
				return null;
			}
		}

		// Token: 0x06023FD9 RID: 147417 RVA: 0x00A331C4 File Offset: 0x00A313C4
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

		// Token: 0x04014152 RID: 82258
		public ITimerUiConfig TimerUiConfig;
	}
}
