using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004714 RID: 18196
	public class TBtNodeUnion
	{
		// Token: 0x17007F60 RID: 32608
		// (get) Token: 0x0601AC45 RID: 109637 RVA: 0x003CD48A File Offset: 0x003CB68A
		// (set) Token: 0x0601AC46 RID: 109638 RVA: 0x003CD492 File Offset: 0x003CB692
		public TBtNode Type { get; set; }

		// Token: 0x17007F61 RID: 32609
		// (get) Token: 0x0601AC47 RID: 109639 RVA: 0x003CD49B File Offset: 0x003CB69B
		// (set) Token: 0x0601AC48 RID: 109640 RVA: 0x003CD4A3 File Offset: 0x003CB6A3
		public object Value { get; set; }

		// Token: 0x0601AC49 RID: 109641 RVA: 0x003CD4AC File Offset: 0x003CB6AC
		public TBtNodeUnion()
		{
			this.Type = TBtNode.NONE;
			this.Value = null;
		}

		// Token: 0x0601AC4A RID: 109642 RVA: 0x003CD4C2 File Offset: 0x003CB6C2
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601AC4B RID: 109643 RVA: 0x003CD4D4 File Offset: 0x003CB6D4
		public IActionBtNodeT AsIActionBtNode()
		{
			return this.As<IActionBtNodeT>();
		}

		// Token: 0x0601AC4C RID: 109644 RVA: 0x003CD4DC File Offset: 0x003CB6DC
		public static TBtNodeUnion FromIActionBtNode(IActionBtNodeT _iactionbtnode)
		{
			return new TBtNodeUnion
			{
				Type = TBtNode.IActionBtNode,
				Value = _iactionbtnode
			};
		}

		// Token: 0x0601AC4D RID: 109645 RVA: 0x003CD4F1 File Offset: 0x003CB6F1
		public IActionWithResultBtNodeT AsIActionWithResultBtNode()
		{
			return this.As<IActionWithResultBtNodeT>();
		}

		// Token: 0x0601AC4E RID: 109646 RVA: 0x003CD4F9 File Offset: 0x003CB6F9
		public static TBtNodeUnion FromIActionWithResultBtNode(IActionWithResultBtNodeT _iactionwithresultbtnode)
		{
			return new TBtNodeUnion
			{
				Type = TBtNode.IActionWithResultBtNode,
				Value = _iactionwithresultbtnode
			};
		}

		// Token: 0x0601AC4F RID: 109647 RVA: 0x003CD50E File Offset: 0x003CB70E
		public IAlwaysFalseBtNodeT AsIAlwaysFalseBtNode()
		{
			return this.As<IAlwaysFalseBtNodeT>();
		}

		// Token: 0x0601AC50 RID: 109648 RVA: 0x003CD516 File Offset: 0x003CB716
		public static TBtNodeUnion FromIAlwaysFalseBtNode(IAlwaysFalseBtNodeT _ialwaysfalsebtnode)
		{
			return new TBtNodeUnion
			{
				Type = TBtNode.IAlwaysFalseBtNode,
				Value = _ialwaysfalsebtnode
			};
		}

		// Token: 0x0601AC51 RID: 109649 RVA: 0x003CD52B File Offset: 0x003CB72B
		public IAlwaysTrueBtNodeT AsIAlwaysTrueBtNode()
		{
			return this.As<IAlwaysTrueBtNodeT>();
		}

		// Token: 0x0601AC52 RID: 109650 RVA: 0x003CD533 File Offset: 0x003CB733
		public static TBtNodeUnion FromIAlwaysTrueBtNode(IAlwaysTrueBtNodeT _ialwaystruebtnode)
		{
			return new TBtNodeUnion
			{
				Type = TBtNode.IAlwaysTrueBtNode,
				Value = _ialwaystruebtnode
			};
		}

		// Token: 0x0601AC53 RID: 109651 RVA: 0x003CD548 File Offset: 0x003CB748
		public IChildQuestBtNodeT AsIChildQuestBtNode()
		{
			return this.As<IChildQuestBtNodeT>();
		}

		// Token: 0x0601AC54 RID: 109652 RVA: 0x003CD550 File Offset: 0x003CB750
		public static TBtNodeUnion FromIChildQuestBtNode(IChildQuestBtNodeT _ichildquestbtnode)
		{
			return new TBtNodeUnion
			{
				Type = TBtNode.IChildQuestBtNode,
				Value = _ichildquestbtnode
			};
		}

		// Token: 0x0601AC55 RID: 109653 RVA: 0x003CD565 File Offset: 0x003CB765
		public IConditionBtNodeT AsIConditionBtNode()
		{
			return this.As<IConditionBtNodeT>();
		}

		// Token: 0x0601AC56 RID: 109654 RVA: 0x003CD56D File Offset: 0x003CB76D
		public static TBtNodeUnion FromIConditionBtNode(IConditionBtNodeT _iconditionbtnode)
		{
			return new TBtNodeUnion
			{
				Type = TBtNode.IConditionBtNode,
				Value = _iconditionbtnode
			};
		}

		// Token: 0x0601AC57 RID: 109655 RVA: 0x003CD582 File Offset: 0x003CB782
		public IConditionSelectorBtNodeT AsIConditionSelectorBtNode()
		{
			return this.As<IConditionSelectorBtNodeT>();
		}

		// Token: 0x0601AC58 RID: 109656 RVA: 0x003CD58A File Offset: 0x003CB78A
		public static TBtNodeUnion FromIConditionSelectorBtNode(IConditionSelectorBtNodeT _iconditionselectorbtnode)
		{
			return new TBtNodeUnion
			{
				Type = TBtNode.IConditionSelectorBtNode,
				Value = _iconditionselectorbtnode
			};
		}

		// Token: 0x0601AC59 RID: 109657 RVA: 0x003CD59F File Offset: 0x003CB79F
		public IParallelSelectBtNodeT AsIParallelSelectBtNode()
		{
			return this.As<IParallelSelectBtNodeT>();
		}

		// Token: 0x0601AC5A RID: 109658 RVA: 0x003CD5A7 File Offset: 0x003CB7A7
		public static TBtNodeUnion FromIParallelSelectBtNode(IParallelSelectBtNodeT _iparallelselectbtnode)
		{
			return new TBtNodeUnion
			{
				Type = TBtNode.IParallelSelectBtNode,
				Value = _iparallelselectbtnode
			};
		}

		// Token: 0x0601AC5B RID: 109659 RVA: 0x003CD5BC File Offset: 0x003CB7BC
		public IQuestFailedBtNodeT AsIQuestFailedBtNode()
		{
			return this.As<IQuestFailedBtNodeT>();
		}

		// Token: 0x0601AC5C RID: 109660 RVA: 0x003CD5C4 File Offset: 0x003CB7C4
		public static TBtNodeUnion FromIQuestFailedBtNode(IQuestFailedBtNodeT _iquestfailedbtnode)
		{
			return new TBtNodeUnion
			{
				Type = TBtNode.IQuestFailedBtNode,
				Value = _iquestfailedbtnode
			};
		}

		// Token: 0x0601AC5D RID: 109661 RVA: 0x003CD5DA File Offset: 0x003CB7DA
		public IQuestSucceedBtNodeT AsIQuestSucceedBtNode()
		{
			return this.As<IQuestSucceedBtNodeT>();
		}

		// Token: 0x0601AC5E RID: 109662 RVA: 0x003CD5E2 File Offset: 0x003CB7E2
		public static TBtNodeUnion FromIQuestSucceedBtNode(IQuestSucceedBtNodeT _iquestsucceedbtnode)
		{
			return new TBtNodeUnion
			{
				Type = TBtNode.IQuestSucceedBtNode,
				Value = _iquestsucceedbtnode
			};
		}

		// Token: 0x0601AC5F RID: 109663 RVA: 0x003CD5F8 File Offset: 0x003CB7F8
		public IRepeaterBtNodeT AsIRepeaterBtNode()
		{
			return this.As<IRepeaterBtNodeT>();
		}

		// Token: 0x0601AC60 RID: 109664 RVA: 0x003CD600 File Offset: 0x003CB800
		public static TBtNodeUnion FromIRepeaterBtNode(IRepeaterBtNodeT _irepeaterbtnode)
		{
			return new TBtNodeUnion
			{
				Type = TBtNode.IRepeaterBtNode,
				Value = _irepeaterbtnode
			};
		}

		// Token: 0x0601AC61 RID: 109665 RVA: 0x003CD616 File Offset: 0x003CB816
		public ISelectBtNodeT AsISelectBtNode()
		{
			return this.As<ISelectBtNodeT>();
		}

		// Token: 0x0601AC62 RID: 109666 RVA: 0x003CD61E File Offset: 0x003CB81E
		public static TBtNodeUnion FromISelectBtNode(ISelectBtNodeT _iselectbtnode)
		{
			return new TBtNodeUnion
			{
				Type = TBtNode.ISelectBtNode,
				Value = _iselectbtnode
			};
		}

		// Token: 0x0601AC63 RID: 109667 RVA: 0x003CD634 File Offset: 0x003CB834
		public ISequenceBtNodeT AsISequenceBtNode()
		{
			return this.As<ISequenceBtNodeT>();
		}

		// Token: 0x0601AC64 RID: 109668 RVA: 0x003CD63C File Offset: 0x003CB83C
		public static TBtNodeUnion FromISequenceBtNode(ISequenceBtNodeT _isequencebtnode)
		{
			return new TBtNodeUnion
			{
				Type = TBtNode.ISequenceBtNode,
				Value = _isequencebtnode
			};
		}

		// Token: 0x0601AC65 RID: 109669 RVA: 0x003CD652 File Offset: 0x003CB852
		public IStartBtNodeT AsIStartBtNode()
		{
			return this.As<IStartBtNodeT>();
		}

		// Token: 0x0601AC66 RID: 109670 RVA: 0x003CD65A File Offset: 0x003CB85A
		public static TBtNodeUnion FromIStartBtNode(IStartBtNodeT _istartbtnode)
		{
			return new TBtNodeUnion
			{
				Type = TBtNode.IStartBtNode,
				Value = _istartbtnode
			};
		}

		// Token: 0x0601AC67 RID: 109671 RVA: 0x003CD670 File Offset: 0x003CB870
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
