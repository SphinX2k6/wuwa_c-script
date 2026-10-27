using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020042DF RID: 17119
	public class TLeafBtNodeUnion
	{
		// Token: 0x1700794C RID: 31052
		// (get) Token: 0x0601963B RID: 103995 RVA: 0x003A451A File Offset: 0x003A271A
		// (set) Token: 0x0601963C RID: 103996 RVA: 0x003A4522 File Offset: 0x003A2722
		public TLeafBtNode Type { get; set; }

		// Token: 0x1700794D RID: 31053
		// (get) Token: 0x0601963D RID: 103997 RVA: 0x003A452B File Offset: 0x003A272B
		// (set) Token: 0x0601963E RID: 103998 RVA: 0x003A4533 File Offset: 0x003A2733
		public object Value { get; set; }

		// Token: 0x0601963F RID: 103999 RVA: 0x003A453C File Offset: 0x003A273C
		public TLeafBtNodeUnion()
		{
			this.Type = TLeafBtNode.NONE;
			this.Value = null;
		}

		// Token: 0x06019640 RID: 104000 RVA: 0x003A4552 File Offset: 0x003A2752
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06019641 RID: 104001 RVA: 0x003A4564 File Offset: 0x003A2764
		public IActionBtNodeT AsIActionBtNode()
		{
			return this.As<IActionBtNodeT>();
		}

		// Token: 0x06019642 RID: 104002 RVA: 0x003A456C File Offset: 0x003A276C
		public static TLeafBtNodeUnion FromIActionBtNode(IActionBtNodeT _iactionbtnode)
		{
			return new TLeafBtNodeUnion
			{
				Type = TLeafBtNode.IActionBtNode,
				Value = _iactionbtnode
			};
		}

		// Token: 0x06019643 RID: 104003 RVA: 0x003A4581 File Offset: 0x003A2781
		public IActionWithResultBtNodeT AsIActionWithResultBtNode()
		{
			return this.As<IActionWithResultBtNodeT>();
		}

		// Token: 0x06019644 RID: 104004 RVA: 0x003A4589 File Offset: 0x003A2789
		public static TLeafBtNodeUnion FromIActionWithResultBtNode(IActionWithResultBtNodeT _iactionwithresultbtnode)
		{
			return new TLeafBtNodeUnion
			{
				Type = TLeafBtNode.IActionWithResultBtNode,
				Value = _iactionwithresultbtnode
			};
		}

		// Token: 0x06019645 RID: 104005 RVA: 0x003A459E File Offset: 0x003A279E
		public IChildQuestBtNodeT AsIChildQuestBtNode()
		{
			return this.As<IChildQuestBtNodeT>();
		}

		// Token: 0x06019646 RID: 104006 RVA: 0x003A45A6 File Offset: 0x003A27A6
		public static TLeafBtNodeUnion FromIChildQuestBtNode(IChildQuestBtNodeT _ichildquestbtnode)
		{
			return new TLeafBtNodeUnion
			{
				Type = TLeafBtNode.IChildQuestBtNode,
				Value = _ichildquestbtnode
			};
		}

		// Token: 0x06019647 RID: 104007 RVA: 0x003A45BB File Offset: 0x003A27BB
		public IConditionBtNodeT AsIConditionBtNode()
		{
			return this.As<IConditionBtNodeT>();
		}

		// Token: 0x06019648 RID: 104008 RVA: 0x003A45C3 File Offset: 0x003A27C3
		public static TLeafBtNodeUnion FromIConditionBtNode(IConditionBtNodeT _iconditionbtnode)
		{
			return new TLeafBtNodeUnion
			{
				Type = TLeafBtNode.IConditionBtNode,
				Value = _iconditionbtnode
			};
		}

		// Token: 0x06019649 RID: 104009 RVA: 0x003A45D8 File Offset: 0x003A27D8
		public IQuestFailedBtNodeT AsIQuestFailedBtNode()
		{
			return this.As<IQuestFailedBtNodeT>();
		}

		// Token: 0x0601964A RID: 104010 RVA: 0x003A45E0 File Offset: 0x003A27E0
		public static TLeafBtNodeUnion FromIQuestFailedBtNode(IQuestFailedBtNodeT _iquestfailedbtnode)
		{
			return new TLeafBtNodeUnion
			{
				Type = TLeafBtNode.IQuestFailedBtNode,
				Value = _iquestfailedbtnode
			};
		}

		// Token: 0x0601964B RID: 104011 RVA: 0x003A45F5 File Offset: 0x003A27F5
		public IQuestSucceedBtNodeT AsIQuestSucceedBtNode()
		{
			return this.As<IQuestSucceedBtNodeT>();
		}

		// Token: 0x0601964C RID: 104012 RVA: 0x003A45FD File Offset: 0x003A27FD
		public static TLeafBtNodeUnion FromIQuestSucceedBtNode(IQuestSucceedBtNodeT _iquestsucceedbtnode)
		{
			return new TLeafBtNodeUnion
			{
				Type = TLeafBtNode.IQuestSucceedBtNode,
				Value = _iquestsucceedbtnode
			};
		}

		// Token: 0x0601964D RID: 104013 RVA: 0x003A4612 File Offset: 0x003A2812
		public IStartBtNodeT AsIStartBtNode()
		{
			return this.As<IStartBtNodeT>();
		}

		// Token: 0x0601964E RID: 104014 RVA: 0x003A461A File Offset: 0x003A281A
		public static TLeafBtNodeUnion FromIStartBtNode(IStartBtNodeT _istartbtnode)
		{
			return new TLeafBtNodeUnion
			{
				Type = TLeafBtNode.IStartBtNode,
				Value = _istartbtnode
			};
		}

		// Token: 0x0601964F RID: 104015 RVA: 0x003A462F File Offset: 0x003A282F
		public IAlwaysTrueBtNodeT AsIAlwaysTrueBtNode()
		{
			return this.As<IAlwaysTrueBtNodeT>();
		}

		// Token: 0x06019650 RID: 104016 RVA: 0x003A4637 File Offset: 0x003A2837
		public static TLeafBtNodeUnion FromIAlwaysTrueBtNode(IAlwaysTrueBtNodeT _ialwaystruebtnode)
		{
			return new TLeafBtNodeUnion
			{
				Type = TLeafBtNode.IAlwaysTrueBtNode,
				Value = _ialwaystruebtnode
			};
		}

		// Token: 0x06019651 RID: 104017 RVA: 0x003A464C File Offset: 0x003A284C
		public IAlwaysFalseBtNodeT AsIAlwaysFalseBtNode()
		{
			return this.As<IAlwaysFalseBtNodeT>();
		}

		// Token: 0x06019652 RID: 104018 RVA: 0x003A4654 File Offset: 0x003A2854
		public static TLeafBtNodeUnion FromIAlwaysFalseBtNode(IAlwaysFalseBtNodeT _ialwaysfalsebtnode)
		{
			return new TLeafBtNodeUnion
			{
				Type = TLeafBtNode.IAlwaysFalseBtNode,
				Value = _ialwaysfalsebtnode
			};
		}

		// Token: 0x06019653 RID: 104019 RVA: 0x003A466A File Offset: 0x003A286A
		public IRepeaterBtNodeT AsIRepeaterBtNode()
		{
			return this.As<IRepeaterBtNodeT>();
		}

		// Token: 0x06019654 RID: 104020 RVA: 0x003A4672 File Offset: 0x003A2872
		public static TLeafBtNodeUnion FromIRepeaterBtNode(IRepeaterBtNodeT _irepeaterbtnode)
		{
			return new TLeafBtNodeUnion
			{
				Type = TLeafBtNode.IRepeaterBtNode,
				Value = _irepeaterbtnode
			};
		}

		// Token: 0x06019655 RID: 104021 RVA: 0x003A4688 File Offset: 0x003A2888
		public static int Pack(FlatBufferBuilder builder, TLeafBtNodeUnion _o)
		{
			switch (_o.Type)
			{
			case TLeafBtNode.IActionBtNode:
				return IActionBtNode.Pack(builder, _o.AsIActionBtNode()).Value;
			case TLeafBtNode.IActionWithResultBtNode:
				return IActionWithResultBtNode.Pack(builder, _o.AsIActionWithResultBtNode()).Value;
			case TLeafBtNode.IChildQuestBtNode:
				return IChildQuestBtNode.Pack(builder, _o.AsIChildQuestBtNode()).Value;
			case TLeafBtNode.IConditionBtNode:
				return IConditionBtNode.Pack(builder, _o.AsIConditionBtNode()).Value;
			case TLeafBtNode.IQuestFailedBtNode:
				return IQuestFailedBtNode.Pack(builder, _o.AsIQuestFailedBtNode()).Value;
			case TLeafBtNode.IQuestSucceedBtNode:
				return IQuestSucceedBtNode.Pack(builder, _o.AsIQuestSucceedBtNode()).Value;
			case TLeafBtNode.IStartBtNode:
				return IStartBtNode.Pack(builder, _o.AsIStartBtNode()).Value;
			case TLeafBtNode.IAlwaysTrueBtNode:
				return IAlwaysTrueBtNode.Pack(builder, _o.AsIAlwaysTrueBtNode()).Value;
			case TLeafBtNode.IAlwaysFalseBtNode:
				return IAlwaysFalseBtNode.Pack(builder, _o.AsIAlwaysFalseBtNode()).Value;
			case TLeafBtNode.IRepeaterBtNode:
				return IRepeaterBtNode.Pack(builder, _o.AsIRepeaterBtNode()).Value;
			default:
				return 0;
			}
		}
	}
}
