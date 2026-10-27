using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020042EB RID: 17131
	public class TOneChildBtNodeUnion
	{
		// Token: 0x17007954 RID: 31060
		// (get) Token: 0x06019685 RID: 104069 RVA: 0x003A4C90 File Offset: 0x003A2E90
		// (set) Token: 0x06019686 RID: 104070 RVA: 0x003A4C98 File Offset: 0x003A2E98
		public TOneChildBtNode Type { get; set; }

		// Token: 0x17007955 RID: 31061
		// (get) Token: 0x06019687 RID: 104071 RVA: 0x003A4CA1 File Offset: 0x003A2EA1
		// (set) Token: 0x06019688 RID: 104072 RVA: 0x003A4CA9 File Offset: 0x003A2EA9
		public object Value { get; set; }

		// Token: 0x06019689 RID: 104073 RVA: 0x003A4CB2 File Offset: 0x003A2EB2
		public TOneChildBtNodeUnion()
		{
			this.Type = TOneChildBtNode.NONE;
			this.Value = null;
		}

		// Token: 0x0601968A RID: 104074 RVA: 0x003A4CC8 File Offset: 0x003A2EC8
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601968B RID: 104075 RVA: 0x003A4CDA File Offset: 0x003A2EDA
		public IAlwaysFalseBtNodeT AsIAlwaysFalseBtNode()
		{
			return this.As<IAlwaysFalseBtNodeT>();
		}

		// Token: 0x0601968C RID: 104076 RVA: 0x003A4CE2 File Offset: 0x003A2EE2
		public static TOneChildBtNodeUnion FromIAlwaysFalseBtNode(IAlwaysFalseBtNodeT _ialwaysfalsebtnode)
		{
			return new TOneChildBtNodeUnion
			{
				Type = TOneChildBtNode.IAlwaysFalseBtNode,
				Value = _ialwaysfalsebtnode
			};
		}

		// Token: 0x0601968D RID: 104077 RVA: 0x003A4CF7 File Offset: 0x003A2EF7
		public IAlwaysTrueBtNodeT AsIAlwaysTrueBtNode()
		{
			return this.As<IAlwaysTrueBtNodeT>();
		}

		// Token: 0x0601968E RID: 104078 RVA: 0x003A4CFF File Offset: 0x003A2EFF
		public static TOneChildBtNodeUnion FromIAlwaysTrueBtNode(IAlwaysTrueBtNodeT _ialwaystruebtnode)
		{
			return new TOneChildBtNodeUnion
			{
				Type = TOneChildBtNode.IAlwaysTrueBtNode,
				Value = _ialwaystruebtnode
			};
		}

		// Token: 0x0601968F RID: 104079 RVA: 0x003A4D14 File Offset: 0x003A2F14
		public IRepeaterBtNodeT AsIRepeaterBtNode()
		{
			return this.As<IRepeaterBtNodeT>();
		}

		// Token: 0x06019690 RID: 104080 RVA: 0x003A4D1C File Offset: 0x003A2F1C
		public static TOneChildBtNodeUnion FromIRepeaterBtNode(IRepeaterBtNodeT _irepeaterbtnode)
		{
			return new TOneChildBtNodeUnion
			{
				Type = TOneChildBtNode.IRepeaterBtNode,
				Value = _irepeaterbtnode
			};
		}

		// Token: 0x06019691 RID: 104081 RVA: 0x003A4D31 File Offset: 0x003A2F31
		public IStartBtNodeT AsIStartBtNode()
		{
			return this.As<IStartBtNodeT>();
		}

		// Token: 0x06019692 RID: 104082 RVA: 0x003A4D39 File Offset: 0x003A2F39
		public static TOneChildBtNodeUnion FromIStartBtNode(IStartBtNodeT _istartbtnode)
		{
			return new TOneChildBtNodeUnion
			{
				Type = TOneChildBtNode.IStartBtNode,
				Value = _istartbtnode
			};
		}

		// Token: 0x06019693 RID: 104083 RVA: 0x003A4D4E File Offset: 0x003A2F4E
		public IQuestSucceedBtNodeT AsIQuestSucceedBtNode()
		{
			return this.As<IQuestSucceedBtNodeT>();
		}

		// Token: 0x06019694 RID: 104084 RVA: 0x003A4D56 File Offset: 0x003A2F56
		public static TOneChildBtNodeUnion FromIQuestSucceedBtNode(IQuestSucceedBtNodeT _iquestsucceedbtnode)
		{
			return new TOneChildBtNodeUnion
			{
				Type = TOneChildBtNode.IQuestSucceedBtNode,
				Value = _iquestsucceedbtnode
			};
		}

		// Token: 0x06019695 RID: 104085 RVA: 0x003A4D6B File Offset: 0x003A2F6B
		public IQuestFailedBtNodeT AsIQuestFailedBtNode()
		{
			return this.As<IQuestFailedBtNodeT>();
		}

		// Token: 0x06019696 RID: 104086 RVA: 0x003A4D73 File Offset: 0x003A2F73
		public static TOneChildBtNodeUnion FromIQuestFailedBtNode(IQuestFailedBtNodeT _iquestfailedbtnode)
		{
			return new TOneChildBtNodeUnion
			{
				Type = TOneChildBtNode.IQuestFailedBtNode,
				Value = _iquestfailedbtnode
			};
		}

		// Token: 0x06019697 RID: 104087 RVA: 0x003A4D88 File Offset: 0x003A2F88
		public IConditionBtNodeT AsIConditionBtNode()
		{
			return this.As<IConditionBtNodeT>();
		}

		// Token: 0x06019698 RID: 104088 RVA: 0x003A4D90 File Offset: 0x003A2F90
		public static TOneChildBtNodeUnion FromIConditionBtNode(IConditionBtNodeT _iconditionbtnode)
		{
			return new TOneChildBtNodeUnion
			{
				Type = TOneChildBtNode.IConditionBtNode,
				Value = _iconditionbtnode
			};
		}

		// Token: 0x06019699 RID: 104089 RVA: 0x003A4DA5 File Offset: 0x003A2FA5
		public IChildQuestBtNodeT AsIChildQuestBtNode()
		{
			return this.As<IChildQuestBtNodeT>();
		}

		// Token: 0x0601969A RID: 104090 RVA: 0x003A4DAD File Offset: 0x003A2FAD
		public static TOneChildBtNodeUnion FromIChildQuestBtNode(IChildQuestBtNodeT _ichildquestbtnode)
		{
			return new TOneChildBtNodeUnion
			{
				Type = TOneChildBtNode.IChildQuestBtNode,
				Value = _ichildquestbtnode
			};
		}

		// Token: 0x0601969B RID: 104091 RVA: 0x003A4DC2 File Offset: 0x003A2FC2
		public IActionBtNodeT AsIActionBtNode()
		{
			return this.As<IActionBtNodeT>();
		}

		// Token: 0x0601969C RID: 104092 RVA: 0x003A4DCA File Offset: 0x003A2FCA
		public static TOneChildBtNodeUnion FromIActionBtNode(IActionBtNodeT _iactionbtnode)
		{
			return new TOneChildBtNodeUnion
			{
				Type = TOneChildBtNode.IActionBtNode,
				Value = _iactionbtnode
			};
		}

		// Token: 0x0601969D RID: 104093 RVA: 0x003A4DE0 File Offset: 0x003A2FE0
		public IActionWithResultBtNodeT AsIActionWithResultBtNode()
		{
			return this.As<IActionWithResultBtNodeT>();
		}

		// Token: 0x0601969E RID: 104094 RVA: 0x003A4DE8 File Offset: 0x003A2FE8
		public static TOneChildBtNodeUnion FromIActionWithResultBtNode(IActionWithResultBtNodeT _iactionwithresultbtnode)
		{
			return new TOneChildBtNodeUnion
			{
				Type = TOneChildBtNode.IActionWithResultBtNode,
				Value = _iactionwithresultbtnode
			};
		}

		// Token: 0x0601969F RID: 104095 RVA: 0x003A4E00 File Offset: 0x003A3000
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
