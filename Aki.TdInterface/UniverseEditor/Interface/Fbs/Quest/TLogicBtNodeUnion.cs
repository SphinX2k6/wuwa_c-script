using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004741 RID: 18241
	public class TLogicBtNodeUnion
	{
		// Token: 0x17007F81 RID: 32641
		// (get) Token: 0x0601ADD9 RID: 110041 RVA: 0x003D015E File Offset: 0x003CE35E
		// (set) Token: 0x0601ADDA RID: 110042 RVA: 0x003D0166 File Offset: 0x003CE366
		public TLogicBtNode Type { get; set; }

		// Token: 0x17007F82 RID: 32642
		// (get) Token: 0x0601ADDB RID: 110043 RVA: 0x003D016F File Offset: 0x003CE36F
		// (set) Token: 0x0601ADDC RID: 110044 RVA: 0x003D0177 File Offset: 0x003CE377
		public object Value { get; set; }

		// Token: 0x0601ADDD RID: 110045 RVA: 0x003D0180 File Offset: 0x003CE380
		public TLogicBtNodeUnion()
		{
			this.Type = TLogicBtNode.NONE;
			this.Value = null;
		}

		// Token: 0x0601ADDE RID: 110046 RVA: 0x003D0196 File Offset: 0x003CE396
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601ADDF RID: 110047 RVA: 0x003D01A8 File Offset: 0x003CE3A8
		public IConditionSelectorBtNodeT AsIConditionSelectorBtNode()
		{
			return this.As<IConditionSelectorBtNodeT>();
		}

		// Token: 0x0601ADE0 RID: 110048 RVA: 0x003D01B0 File Offset: 0x003CE3B0
		public static TLogicBtNodeUnion FromIConditionSelectorBtNode(IConditionSelectorBtNodeT _iconditionselectorbtnode)
		{
			return new TLogicBtNodeUnion
			{
				Type = TLogicBtNode.IConditionSelectorBtNode,
				Value = _iconditionselectorbtnode
			};
		}

		// Token: 0x0601ADE1 RID: 110049 RVA: 0x003D01C5 File Offset: 0x003CE3C5
		public IParallelSelectBtNodeT AsIParallelSelectBtNode()
		{
			return this.As<IParallelSelectBtNodeT>();
		}

		// Token: 0x0601ADE2 RID: 110050 RVA: 0x003D01CD File Offset: 0x003CE3CD
		public static TLogicBtNodeUnion FromIParallelSelectBtNode(IParallelSelectBtNodeT _iparallelselectbtnode)
		{
			return new TLogicBtNodeUnion
			{
				Type = TLogicBtNode.IParallelSelectBtNode,
				Value = _iparallelselectbtnode
			};
		}

		// Token: 0x0601ADE3 RID: 110051 RVA: 0x003D01E2 File Offset: 0x003CE3E2
		public ISelectBtNodeT AsISelectBtNode()
		{
			return this.As<ISelectBtNodeT>();
		}

		// Token: 0x0601ADE4 RID: 110052 RVA: 0x003D01EA File Offset: 0x003CE3EA
		public static TLogicBtNodeUnion FromISelectBtNode(ISelectBtNodeT _iselectbtnode)
		{
			return new TLogicBtNodeUnion
			{
				Type = TLogicBtNode.ISelectBtNode,
				Value = _iselectbtnode
			};
		}

		// Token: 0x0601ADE5 RID: 110053 RVA: 0x003D01FF File Offset: 0x003CE3FF
		public ISequenceBtNodeT AsISequenceBtNode()
		{
			return this.As<ISequenceBtNodeT>();
		}

		// Token: 0x0601ADE6 RID: 110054 RVA: 0x003D0207 File Offset: 0x003CE407
		public static TLogicBtNodeUnion FromISequenceBtNode(ISequenceBtNodeT _isequencebtnode)
		{
			return new TLogicBtNodeUnion
			{
				Type = TLogicBtNode.ISequenceBtNode,
				Value = _isequencebtnode
			};
		}

		// Token: 0x0601ADE7 RID: 110055 RVA: 0x003D021C File Offset: 0x003CE41C
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
