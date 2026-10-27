using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020042B8 RID: 17080
	public class TBtNodeUnion
	{
		// Token: 0x1700792F RID: 31023
		// (get) Token: 0x060194D9 RID: 103641 RVA: 0x003A1DB2 File Offset: 0x0039FFB2
		// (set) Token: 0x060194DA RID: 103642 RVA: 0x003A1DBA File Offset: 0x0039FFBA
		public TBtNode Type { get; set; }

		// Token: 0x17007930 RID: 31024
		// (get) Token: 0x060194DB RID: 103643 RVA: 0x003A1DC3 File Offset: 0x0039FFC3
		// (set) Token: 0x060194DC RID: 103644 RVA: 0x003A1DCB File Offset: 0x0039FFCB
		public object Value { get; set; }

		// Token: 0x060194DD RID: 103645 RVA: 0x003A1DD4 File Offset: 0x0039FFD4
		public TBtNodeUnion()
		{
			this.Type = TBtNode.NONE;
			this.Value = null;
		}

		// Token: 0x060194DE RID: 103646 RVA: 0x003A1DEA File Offset: 0x0039FFEA
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060194DF RID: 103647 RVA: 0x003A1DFC File Offset: 0x0039FFFC
		public IActionBtNodeT AsIActionBtNode()
		{
			return this.As<IActionBtNodeT>();
		}

		// Token: 0x060194E0 RID: 103648 RVA: 0x003A1E04 File Offset: 0x003A0004
		public static TBtNodeUnion FromIActionBtNode(IActionBtNodeT _iactionbtnode)
		{
			return new TBtNodeUnion
			{
				Type = TBtNode.IActionBtNode,
				Value = _iactionbtnode
			};
		}

		// Token: 0x060194E1 RID: 103649 RVA: 0x003A1E19 File Offset: 0x003A0019
		public IActionWithResultBtNodeT AsIActionWithResultBtNode()
		{
			return this.As<IActionWithResultBtNodeT>();
		}

		// Token: 0x060194E2 RID: 103650 RVA: 0x003A1E21 File Offset: 0x003A0021
		public static TBtNodeUnion FromIActionWithResultBtNode(IActionWithResultBtNodeT _iactionwithresultbtnode)
		{
			return new TBtNodeUnion
			{
				Type = TBtNode.IActionWithResultBtNode,
				Value = _iactionwithresultbtnode
			};
		}

		// Token: 0x060194E3 RID: 103651 RVA: 0x003A1E36 File Offset: 0x003A0036
		public IAlwaysFalseBtNodeT AsIAlwaysFalseBtNode()
		{
			return this.As<IAlwaysFalseBtNodeT>();
		}

		// Token: 0x060194E4 RID: 103652 RVA: 0x003A1E3E File Offset: 0x003A003E
		public static TBtNodeUnion FromIAlwaysFalseBtNode(IAlwaysFalseBtNodeT _ialwaysfalsebtnode)
		{
			return new TBtNodeUnion
			{
				Type = TBtNode.IAlwaysFalseBtNode,
				Value = _ialwaysfalsebtnode
			};
		}

		// Token: 0x060194E5 RID: 103653 RVA: 0x003A1E53 File Offset: 0x003A0053
		public IAlwaysTrueBtNodeT AsIAlwaysTrueBtNode()
		{
			return this.As<IAlwaysTrueBtNodeT>();
		}

		// Token: 0x060194E6 RID: 103654 RVA: 0x003A1E5B File Offset: 0x003A005B
		public static TBtNodeUnion FromIAlwaysTrueBtNode(IAlwaysTrueBtNodeT _ialwaystruebtnode)
		{
			return new TBtNodeUnion
			{
				Type = TBtNode.IAlwaysTrueBtNode,
				Value = _ialwaystruebtnode
			};
		}

		// Token: 0x060194E7 RID: 103655 RVA: 0x003A1E70 File Offset: 0x003A0070
		public IChildQuestBtNodeT AsIChildQuestBtNode()
		{
			return this.As<IChildQuestBtNodeT>();
		}

		// Token: 0x060194E8 RID: 103656 RVA: 0x003A1E78 File Offset: 0x003A0078
		public static TBtNodeUnion FromIChildQuestBtNode(IChildQuestBtNodeT _ichildquestbtnode)
		{
			return new TBtNodeUnion
			{
				Type = TBtNode.IChildQuestBtNode,
				Value = _ichildquestbtnode
			};
		}

		// Token: 0x060194E9 RID: 103657 RVA: 0x003A1E8D File Offset: 0x003A008D
		public IConditionBtNodeT AsIConditionBtNode()
		{
			return this.As<IConditionBtNodeT>();
		}

		// Token: 0x060194EA RID: 103658 RVA: 0x003A1E95 File Offset: 0x003A0095
		public static TBtNodeUnion FromIConditionBtNode(IConditionBtNodeT _iconditionbtnode)
		{
			return new TBtNodeUnion
			{
				Type = TBtNode.IConditionBtNode,
				Value = _iconditionbtnode
			};
		}

		// Token: 0x060194EB RID: 103659 RVA: 0x003A1EAA File Offset: 0x003A00AA
		public IConditionSelectorBtNodeT AsIConditionSelectorBtNode()
		{
			return this.As<IConditionSelectorBtNodeT>();
		}

		// Token: 0x060194EC RID: 103660 RVA: 0x003A1EB2 File Offset: 0x003A00B2
		public static TBtNodeUnion FromIConditionSelectorBtNode(IConditionSelectorBtNodeT _iconditionselectorbtnode)
		{
			return new TBtNodeUnion
			{
				Type = TBtNode.IConditionSelectorBtNode,
				Value = _iconditionselectorbtnode
			};
		}

		// Token: 0x060194ED RID: 103661 RVA: 0x003A1EC7 File Offset: 0x003A00C7
		public IParallelSelectBtNodeT AsIParallelSelectBtNode()
		{
			return this.As<IParallelSelectBtNodeT>();
		}

		// Token: 0x060194EE RID: 103662 RVA: 0x003A1ECF File Offset: 0x003A00CF
		public static TBtNodeUnion FromIParallelSelectBtNode(IParallelSelectBtNodeT _iparallelselectbtnode)
		{
			return new TBtNodeUnion
			{
				Type = TBtNode.IParallelSelectBtNode,
				Value = _iparallelselectbtnode
			};
		}

		// Token: 0x060194EF RID: 103663 RVA: 0x003A1EE4 File Offset: 0x003A00E4
		public IQuestFailedBtNodeT AsIQuestFailedBtNode()
		{
			return this.As<IQuestFailedBtNodeT>();
		}

		// Token: 0x060194F0 RID: 103664 RVA: 0x003A1EEC File Offset: 0x003A00EC
		public static TBtNodeUnion FromIQuestFailedBtNode(IQuestFailedBtNodeT _iquestfailedbtnode)
		{
			return new TBtNodeUnion
			{
				Type = TBtNode.IQuestFailedBtNode,
				Value = _iquestfailedbtnode
			};
		}

		// Token: 0x060194F1 RID: 103665 RVA: 0x003A1F02 File Offset: 0x003A0102
		public IQuestSucceedBtNodeT AsIQuestSucceedBtNode()
		{
			return this.As<IQuestSucceedBtNodeT>();
		}

		// Token: 0x060194F2 RID: 103666 RVA: 0x003A1F0A File Offset: 0x003A010A
		public static TBtNodeUnion FromIQuestSucceedBtNode(IQuestSucceedBtNodeT _iquestsucceedbtnode)
		{
			return new TBtNodeUnion
			{
				Type = TBtNode.IQuestSucceedBtNode,
				Value = _iquestsucceedbtnode
			};
		}

		// Token: 0x060194F3 RID: 103667 RVA: 0x003A1F20 File Offset: 0x003A0120
		public IRepeaterBtNodeT AsIRepeaterBtNode()
		{
			return this.As<IRepeaterBtNodeT>();
		}

		// Token: 0x060194F4 RID: 103668 RVA: 0x003A1F28 File Offset: 0x003A0128
		public static TBtNodeUnion FromIRepeaterBtNode(IRepeaterBtNodeT _irepeaterbtnode)
		{
			return new TBtNodeUnion
			{
				Type = TBtNode.IRepeaterBtNode,
				Value = _irepeaterbtnode
			};
		}

		// Token: 0x060194F5 RID: 103669 RVA: 0x003A1F3E File Offset: 0x003A013E
		public ISelectBtNodeT AsISelectBtNode()
		{
			return this.As<ISelectBtNodeT>();
		}

		// Token: 0x060194F6 RID: 103670 RVA: 0x003A1F46 File Offset: 0x003A0146
		public static TBtNodeUnion FromISelectBtNode(ISelectBtNodeT _iselectbtnode)
		{
			return new TBtNodeUnion
			{
				Type = TBtNode.ISelectBtNode,
				Value = _iselectbtnode
			};
		}

		// Token: 0x060194F7 RID: 103671 RVA: 0x003A1F5C File Offset: 0x003A015C
		public ISequenceBtNodeT AsISequenceBtNode()
		{
			return this.As<ISequenceBtNodeT>();
		}

		// Token: 0x060194F8 RID: 103672 RVA: 0x003A1F64 File Offset: 0x003A0164
		public static TBtNodeUnion FromISequenceBtNode(ISequenceBtNodeT _isequencebtnode)
		{
			return new TBtNodeUnion
			{
				Type = TBtNode.ISequenceBtNode,
				Value = _isequencebtnode
			};
		}

		// Token: 0x060194F9 RID: 103673 RVA: 0x003A1F7A File Offset: 0x003A017A
		public IStartBtNodeT AsIStartBtNode()
		{
			return this.As<IStartBtNodeT>();
		}

		// Token: 0x060194FA RID: 103674 RVA: 0x003A1F82 File Offset: 0x003A0182
		public static TBtNodeUnion FromIStartBtNode(IStartBtNodeT _istartbtnode)
		{
			return new TBtNodeUnion
			{
				Type = TBtNode.IStartBtNode,
				Value = _istartbtnode
			};
		}

		// Token: 0x060194FB RID: 103675 RVA: 0x003A1F98 File Offset: 0x003A0198
		public static int Pack(FlatBufferBuilder builder, TBtNodeUnion _o)
		{
			switch (_o.Type)
			{
			case TBtNode.IActionBtNode:
				return IActionBtNode.Pack(builder, _o.AsIActionBtNode()).Value;
			case TBtNode.IActionWithResultBtNode:
				return IActionWithResultBtNode.Pack(builder, _o.AsIActionWithResultBtNode()).Value;
			case TBtNode.IAlwaysFalseBtNode:
				return IAlwaysFalseBtNode.Pack(builder, _o.AsIAlwaysFalseBtNode()).Value;
			case TBtNode.IAlwaysTrueBtNode:
				return IAlwaysTrueBtNode.Pack(builder, _o.AsIAlwaysTrueBtNode()).Value;
			case TBtNode.IChildQuestBtNode:
				return IChildQuestBtNode.Pack(builder, _o.AsIChildQuestBtNode()).Value;
			case TBtNode.IConditionBtNode:
				return IConditionBtNode.Pack(builder, _o.AsIConditionBtNode()).Value;
			case TBtNode.IConditionSelectorBtNode:
				return IConditionSelectorBtNode.Pack(builder, _o.AsIConditionSelectorBtNode()).Value;
			case TBtNode.IParallelSelectBtNode:
				return IParallelSelectBtNode.Pack(builder, _o.AsIParallelSelectBtNode()).Value;
			case TBtNode.IQuestFailedBtNode:
				return IQuestFailedBtNode.Pack(builder, _o.AsIQuestFailedBtNode()).Value;
			case TBtNode.IQuestSucceedBtNode:
				return IQuestSucceedBtNode.Pack(builder, _o.AsIQuestSucceedBtNode()).Value;
			case TBtNode.IRepeaterBtNode:
				return IRepeaterBtNode.Pack(builder, _o.AsIRepeaterBtNode()).Value;
			case TBtNode.ISelectBtNode:
				return ISelectBtNode.Pack(builder, _o.AsISelectBtNode()).Value;
			case TBtNode.ISequenceBtNode:
				return ISequenceBtNode.Pack(builder, _o.AsISequenceBtNode()).Value;
			case TBtNode.IStartBtNode:
				return IStartBtNode.Pack(builder, _o.AsIStartBtNode()).Value;
			default:
				return 0;
			}
		}
	}
}
