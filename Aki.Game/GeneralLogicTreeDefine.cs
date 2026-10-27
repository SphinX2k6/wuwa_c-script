using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02001D8D RID: 7565
[NullableContext(1)]
[Nullable(0)]
public class GeneralLogicTreeDefine
{
	// Token: 0x04006A2E RID: 27182
	public const int INVALID_INTERACTOPTION_ID = -1;

	// Token: 0x04006A2F RID: 27183
	public const int COMMONLEVELPLAY_TRACKICONID = 8;

	// Token: 0x04006A30 RID: 27184
	public const int CHALLENGELEVELPLAY_TRACKICONID = 9;

	// Token: 0x04006A31 RID: 27185
	public const string OUTRANGEFAILED_TIMERTYPE = "FailedNodeOutRangeTimerType";

	// Token: 0x04006A32 RID: 27186
	public const string NPCFARAWAY_TIMERTYPE = "NpcFarAwayOutRangeTimerType";

	// Token: 0x04006A33 RID: 27187
	public const int TEMP_INSTANCE_TREE_CUSTOM_MARK_ID = 29;

	// Token: 0x04006A34 RID: 27188
	[StaticVariableRuleIgnore]
	public static readonly HashSet<int> tempInstanceTreeIdSetNeedCustomMark = new HashSet<int>
	{
		193000007,
		193000008,
		193000010,
		193000011,
		193000012,
		193700000,
		171700001,
		171700006
	};

	// Token: 0x04006A35 RID: 27189
	[StaticVariableRuleIgnore]
	public static IReadOnlyDictionary<BtType, string> btTypeLogString = new Dictionary<BtType, string>
	{
		{
			BtType.Invalid,
			"无效"
		},
		{
			BtType.Quest,
			"任务"
		},
		{
			BtType.LevelPlay,
			"玩法"
		},
		{
			BtType.Inst,
			"副本"
		}
	};

	// Token: 0x04006A36 RID: 27190
	[StaticVariableRuleIgnore]
	public static IReadOnlyDictionary<NodeStatus, string> btNodeStatusLogString = new Dictionary<NodeStatus, string>
	{
		{
			NodeStatus.NotActive,
			"0-未激活"
		},
		{
			NodeStatus.Activated,
			"1-激活"
		},
		{
			NodeStatus.Completing,
			"2-完成中"
		},
		{
			NodeStatus.CompletedSuccess,
			"3-成功完成"
		},
		{
			NodeStatus.CompletedFailed,
			"4-失败完成"
		},
		{
			NodeStatus.Destroy,
			"6-销毁"
		},
		{
			NodeStatus.BeforeActivate,
			"BeforeActivate"
		},
		{
			NodeStatus.Suspend,
			"Suspend"
		}
	};

	// Token: 0x04006A37 RID: 27191
	[StaticVariableRuleIgnore]
	public static IReadOnlyDictionary<ChildQuestNodeStatus, string> btChildQuestNodeStatusLogString = new Dictionary<ChildQuestNodeStatus, string>
	{
		{
			ChildQuestNodeStatus.CqnsNotActive,
			"0-未激活"
		},
		{
			ChildQuestNodeStatus.CqnsEnter,
			"1-进入"
		},
		{
			ChildQuestNodeStatus.CqnsEnterAction,
			"2-执行进入行为中"
		},
		{
			ChildQuestNodeStatus.CqnsProgress,
			"3-进行中"
		},
		{
			ChildQuestNodeStatus.CqnsFinished,
			"4-完成"
		}
	};
}
