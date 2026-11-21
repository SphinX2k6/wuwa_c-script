using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200474A RID: 18250
	public class TOneChildBtNodeUnion
	{
		// Token: 0x17007F87 RID: 32647
		// (get) Token: 0x0601AE07 RID: 110087 RVA: 0x003D05C0 File Offset: 0x003CE7C0
		// (set) Token: 0x0601AE08 RID: 110088 RVA: 0x003D05C8 File Offset: 0x003CE7C8
		public TOneChildBtNode Type { get; set; }

		// Token: 0x17007F88 RID: 32648
		// (get) Token: 0x0601AE09 RID: 110089 RVA: 0x003D05D1 File Offset: 0x003CE7D1
		// (set) Token: 0x0601AE0A RID: 110090 RVA: 0x003D05D9 File Offset: 0x003CE7D9
		public object Value { get; set; }

		// Token: 0x0601AE0B RID: 110091 RVA: 0x003D05E2 File Offset: 0x003CE7E2
		public TOneChildBtNodeUnion()
		{
			this.Type = TOneChildBtNode.NONE;
			this.Value = null;
		}

		// Token: 0x0601AE0C RID: 110092 RVA: 0x003D05F8 File Offset: 0x003CE7F8
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601AE0D RID: 110093 RVA: 0x003D060A File Offset: 0x003CE80A
		public IAlwaysFalseBtNodeT AsIAlwaysFalseBtNode()
		{
			return this.As<IAlwaysFalseBtNodeT>();
		}

		// Token: 0x0601AE0E RID: 110094 RVA: 0x003D0612 File Offset: 0x003CE812
		public static TOneChildBtNodeUnion FromIAlwaysFalseBtNode(IAlwaysFalseBtNodeT _ialwaysfalsebtnode)
		{
			return new TOneChildBtNodeUnion
			{
				Type = TOneChildBtNode.IAlwaysFalseBtNode,
				Value = _ialwaysfalsebtnode
			};
		}

		// Token: 0x0601AE0F RID: 110095 RVA: 0x003D0627 File Offset: 0x003CE827
		public IAlwaysTrueBtNodeT AsIAlwaysTrueBtNode()
		{
			return this.As<IAlwaysTrueBtNodeT>();
		}

		// Token: 0x0601AE10 RID: 110096 RVA: 0x003D062F File Offset: 0x003CE82F
		public static TOneChildBtNodeUnion FromIAlwaysTrueBtNode(IAlwaysTrueBtNodeT _ialwaystruebtnode)
		{
			return new TOneChildBtNodeUnion
			{
				Type = TOneChildBtNode.IAlwaysTrueBtNode,
				Value = _ialwaystruebtnode
			};
		}

		// Token: 0x0601AE11 RID: 110097 RVA: 0x003D0644 File Offset: 0x003CE844
		public IRepeaterBtNodeT AsIRepeaterBtNode()
		{
			return this.As<IRepeaterBtNodeT>();
		}

		// Token: 0x0601AE12 RID: 110098 RVA: 0x003D064C File Offset: 0x003CE84C
		public static TOneChildBtNodeUnion FromIRepeaterBtNode(IRepeaterBtNodeT _irepeaterbtnode)
		{
			return new TOneChildBtNodeUnion
			{
				Type = TOneChildBtNode.IRepeaterBtNode,
				Value = _irepeaterbtnode
			};
		}

		// Token: 0x0601AE13 RID: 110099 RVA: 0x003D0661 File Offset: 0x003CE861
		public IStartBtNodeT AsIStartBtNode()
		{
			return this.As<IStartBtNodeT>();
		}

		// Token: 0x0601AE14 RID: 110100 RVA: 0x003D0669 File Offset: 0x003CE869
		public static TOneChildBtNodeUnion FromIStartBtNode(IStartBtNodeT _istartbtnode)
		{
			return new TOneChildBtNodeUnion
			{
				Type = TOneChildBtNode.IStartBtNode,
				Value = _istartbtnode
			};
		}

		// Token: 0x0601AE15 RID: 110101 RVA: 0x003D067E File Offset: 0x003CE87E
		public IQuestSucceedBtNodeT AsIQuestSucceedBtNode()
		{
			return this.As<IQuestSucceedBtNodeT>();
		}

		// Token: 0x0601AE16 RID: 110102 RVA: 0x003D0686 File Offset: 0x003CE886
		public static TOneChildBtNodeUnion FromIQuestSucceedBtNode(IQuestSucceedBtNodeT _iquestsucceedbtnode)
		{
			return new TOneChildBtNodeUnion
			{
				Type = TOneChildBtNode.IQuestSucceedBtNode,
				Value = _iquestsucceedbtnode
			};
		}

		// Token: 0x0601AE17 RID: 110103 RVA: 0x003D069B File Offset: 0x003CE89B
		public IQuestFailedBtNodeT AsIQuestFailedBtNode()
		{
			return this.As<IQuestFailedBtNodeT>();
		}

		// Token: 0x0601AE18 RID: 110104 RVA: 0x003D06A3 File Offset: 0x003CE8A3
		public static TOneChildBtNodeUnion FromIQuestFailedBtNode(IQuestFailedBtNodeT _iquestfailedbtnode)
		{
			return new TOneChildBtNodeUnion
			{
				Type = TOneChildBtNode.IQuestFailedBtNode,
				Value = _iquestfailedbtnode
			};
		}

		// Token: 0x0601AE19 RID: 110105 RVA: 0x003D06B8 File Offset: 0x003CE8B8
		public IConditionBtNodeT AsIConditionBtNode()
		{
			return this.As<IConditionBtNodeT>();
		}

		// Token: 0x0601AE1A RID: 110106 RVA: 0x003D06C0 File Offset: 0x003CE8C0
		public static TOneChildBtNodeUnion FromIConditionBtNode(IConditionBtNodeT _iconditionbtnode)
		{
			return new TOneChildBtNodeUnion
			{
				Type = TOneChildBtNode.IConditionBtNode,
				Value = _iconditionbtnode
			};
		}

		// Token: 0x0601AE1B RID: 110107 RVA: 0x003D06D5 File Offset: 0x003CE8D5
		public IChildQuestBtNodeT AsIChildQuestBtNode()
		{
			return this.As<IChildQuestBtNodeT>();
		}

		// Token: 0x0601AE1C RID: 110108 RVA: 0x003D06DD File Offset: 0x003CE8DD
		public static TOneChildBtNodeUnion FromIChildQuestBtNode(IChildQuestBtNodeT _ichildquestbtnode)
		{
			return new TOneChildBtNodeUnion
			{
				Type = TOneChildBtNode.IChildQuestBtNode,
				Value = _ichildquestbtnode
			};
		}

		// Token: 0x0601AE1D RID: 110109 RVA: 0x003D06F2 File Offset: 0x003CE8F2
		public IActionBtNodeT AsIActionBtNode()
		{
			return this.As<IActionBtNodeT>();
		}

		// Token: 0x0601AE1E RID: 110110 RVA: 0x003D06FA File Offset: 0x003CE8FA
		public static TOneChildBtNodeUnion FromIActionBtNode(IActionBtNodeT _iactionbtnode)
		{
			return new TOneChildBtNodeUnion
			{
				Type = TOneChildBtNode.IActionBtNode,
				Value = _iactionbtnode
			};
		}

		// Token: 0x0601AE1F RID: 110111 RVA: 0x003D0710 File Offset: 0x003CE910
		public IActionWithResultBtNodeT AsIActionWithResultBtNode()
		{
			return this.As<IActionWithResultBtNodeT>();
		}

		// Token: 0x0601AE20 RID: 110112 RVA: 0x003D0718 File Offset: 0x003CE918
		public static TOneChildBtNodeUnion FromIActionWithResultBtNode(IActionWithResultBtNodeT _iactionwithresultbtnode)
		{
			return new TOneChildBtNodeUnion
			{
				Type = TOneChildBtNode.IActionWithResultBtNode,
				Value = _iactionwithresultbtnode
			};
		}

		// Token: 0x0601AE21 RID: 110113 RVA: 0x003D0730 File Offset: 0x003CE930
		public static int Pack(FlatBufferBuilder builder, TOneChildBtNodeUnion _o)
		{
			switch (_o.Type)
			{
			case TOneChildBtNode.IAlwaysFalseBtNode:
				return IAlwaysFalseBtNode.Pack(builder, _o.AsIAlwaysFalseBtNode()).Value;
			case TOneChildBtNode.IAlwaysTrueBtNode:
				return IAlwaysTrueBtNode.Pack(builder, _o.AsIAlwaysTrueBtNode()).Value;
			case TOneChildBtNode.IRepeaterBtNode:
				return IRepeaterBtNode.Pack(builder, _o.AsIRepeaterBtNode()).Value;
			case TOneChildBtNode.IStartBtNode:
				return IStartBtNode.Pack(builder, _o.AsIStartBtNode()).Value;
			case TOneChildBtNode.IQuestSucceedBtNode:
				return IQuestSucceedBtNode.Pack(builder, _o.AsIQuestSucceedBtNode()).Value;
			case TOneChildBtNode.IQuestFailedBtNode:
				return IQuestFailedBtNode.Pack(builder, _o.AsIQuestFailedBtNode()).Value;
			case TOneChildBtNode.IConditionBtNode:
				return IConditionBtNode.Pack(builder, _o.AsIConditionBtNode()).Value;
			case TOneChildBtNode.IChildQuestBtNode:
				return IChildQuestBtNode.Pack(builder, _o.AsIChildQuestBtNode()).Value;
			case TOneChildBtNode.IActionBtNode:
				return IActionBtNode.Pack(builder, _o.AsIActionBtNode()).Value;
			case TOneChildBtNode.IActionWithResultBtNode:
				return IActionWithResultBtNode.Pack(builder, _o.AsIActionWithResultBtNode()).Value;
			default:
				return 0;
			}
		}
	}
}
