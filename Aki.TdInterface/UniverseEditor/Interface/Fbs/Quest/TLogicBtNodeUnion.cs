using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020042E2 RID: 17122
	public class TLogicBtNodeUnion
	{
		// Token: 0x1700794E RID: 31054
		// (get) Token: 0x06019657 RID: 104023 RVA: 0x003A482E File Offset: 0x003A2A2E
		// (set) Token: 0x06019658 RID: 104024 RVA: 0x003A4836 File Offset: 0x003A2A36
		public TLogicBtNode Type { get; set; }

		// Token: 0x1700794F RID: 31055
		// (get) Token: 0x06019659 RID: 104025 RVA: 0x003A483F File Offset: 0x003A2A3F
		// (set) Token: 0x0601965A RID: 104026 RVA: 0x003A4847 File Offset: 0x003A2A47
		public object Value { get; set; }

		// Token: 0x0601965B RID: 104027 RVA: 0x003A4850 File Offset: 0x003A2A50
		public TLogicBtNodeUnion()
		{
			this.Type = TLogicBtNode.NONE;
			this.Value = null;
		}

		// Token: 0x0601965C RID: 104028 RVA: 0x003A4866 File Offset: 0x003A2A66
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601965D RID: 104029 RVA: 0x003A4878 File Offset: 0x003A2A78
		public IConditionSelectorBtNodeT AsIConditionSelectorBtNode()
		{
			return this.As<IConditionSelectorBtNodeT>();
		}

		// Token: 0x0601965E RID: 104030 RVA: 0x003A4880 File Offset: 0x003A2A80
		public static TLogicBtNodeUnion FromIConditionSelectorBtNode(IConditionSelectorBtNodeT _iconditionselectorbtnode)
		{
			return new TLogicBtNodeUnion
			{
				Type = TLogicBtNode.IConditionSelectorBtNode,
				Value = _iconditionselectorbtnode
			};
		}

		// Token: 0x0601965F RID: 104031 RVA: 0x003A4895 File Offset: 0x003A2A95
		public IParallelSelectBtNodeT AsIParallelSelectBtNode()
		{
			return this.As<IParallelSelectBtNodeT>();
		}

		// Token: 0x06019660 RID: 104032 RVA: 0x003A489D File Offset: 0x003A2A9D
		public static TLogicBtNodeUnion FromIParallelSelectBtNode(IParallelSelectBtNodeT _iparallelselectbtnode)
		{
			return new TLogicBtNodeUnion
			{
				Type = TLogicBtNode.IParallelSelectBtNode,
				Value = _iparallelselectbtnode
			};
		}

		// Token: 0x06019661 RID: 104033 RVA: 0x003A48B2 File Offset: 0x003A2AB2
		public ISelectBtNodeT AsISelectBtNode()
		{
			return this.As<ISelectBtNodeT>();
		}

		// Token: 0x06019662 RID: 104034 RVA: 0x003A48BA File Offset: 0x003A2ABA
		public static TLogicBtNodeUnion FromISelectBtNode(ISelectBtNodeT _iselectbtnode)
		{
			return new TLogicBtNodeUnion
			{
				Type = TLogicBtNode.ISelectBtNode,
				Value = _iselectbtnode
			};
		}

		// Token: 0x06019663 RID: 104035 RVA: 0x003A48CF File Offset: 0x003A2ACF
		public ISequenceBtNodeT AsISequenceBtNode()
		{
			return this.As<ISequenceBtNodeT>();
		}

		// Token: 0x06019664 RID: 104036 RVA: 0x003A48D7 File Offset: 0x003A2AD7
		public static TLogicBtNodeUnion FromISequenceBtNode(ISequenceBtNodeT _isequencebtnode)
		{
			return new TLogicBtNodeUnion
			{
				Type = TLogicBtNode.ISequenceBtNode,
				Value = _isequencebtnode
			};
		}

		// Token: 0x06019665 RID: 104037 RVA: 0x003A48EC File Offset: 0x003A2AEC
		public static int Pack(FlatBufferBuilder builder, TLogicBtNodeUnion _o)
		{
			switch (_o.Type)
			{
			case TLogicBtNode.IConditionSelectorBtNode:
				return IConditionSelectorBtNode.Pack(builder, _o.AsIConditionSelectorBtNode()).Value;
			case TLogicBtNode.IParallelSelectBtNode:
				return IParallelSelectBtNode.Pack(builder, _o.AsIParallelSelectBtNode()).Value;
			case TLogicBtNode.ISelectBtNode:
				return ISelectBtNode.Pack(builder, _o.AsISelectBtNode()).Value;
			case TLogicBtNode.ISequenceBtNode:
				return ISequenceBtNode.Pack(builder, _o.AsISequenceBtNode()).Value;
			default:
				return 0;
			}
		}
	}
}
