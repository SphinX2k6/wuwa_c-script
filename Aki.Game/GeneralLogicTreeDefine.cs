using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x0200124F RID: 4687
[NullableContext(1)]
[Nullable(0)]
public class GeneralLogicTreeDefine
{
	// Token: 0x04006B0F RID: 27407
	public const int INVALID_INTERACTOPTION_ID = -1;

	// Token: 0x04006B10 RID: 27408
	public const int COMMONLEVELPLAY_TRACKICONID = 8;

	// Token: 0x04006B11 RID: 27409
	public const int CHALLENGELEVELPLAY_TRACKICONID = 9;

	// Token: 0x04006B12 RID: 27410
	public const string OUTRANGEFAILED_TIMERTYPE = "FailedNodeOutRangeTimerType";

	// Token: 0x04006B13 RID: 27411
	public const string NPCFARAWAY_TIMERTYPE = "NpcFarAwayOutRangeTimerType";

	// Token: 0x04006B14 RID: 27412
	public const int TEMP_INSTANCE_TREE_CUSTOM_MARK_ID = 29;

	// Token: 0x04006B15 RID: 27413
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

	// Token: 0x04006B16 RID: 27414
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

	// Token: 0x04006B17 RID: 27415
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

	// Token: 0x04006B18 RID: 27416
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
