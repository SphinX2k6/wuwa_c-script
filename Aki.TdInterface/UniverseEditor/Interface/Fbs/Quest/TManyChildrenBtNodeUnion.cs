using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020042E5 RID: 17125
	public class TManyChildrenBtNodeUnion
	{
		// Token: 0x17007950 RID: 31056
		// (get) Token: 0x06019667 RID: 104039 RVA: 0x003A49BA File Offset: 0x003A2BBA
		// (set) Token: 0x06019668 RID: 104040 RVA: 0x003A49C2 File Offset: 0x003A2BC2
		public TManyChildrenBtNode Type { get; set; }

		// Token: 0x17007951 RID: 31057
		// (get) Token: 0x06019669 RID: 104041 RVA: 0x003A49CB File Offset: 0x003A2BCB
		// (set) Token: 0x0601966A RID: 104042 RVA: 0x003A49D3 File Offset: 0x003A2BD3
		public object Value { get; set; }

		// Token: 0x0601966B RID: 104043 RVA: 0x003A49DC File Offset: 0x003A2BDC
		public TManyChildrenBtNodeUnion()
		{
			this.Type = TManyChildrenBtNode.NONE;
			this.Value = null;
		}

		// Token: 0x0601966C RID: 104044 RVA: 0x003A49F2 File Offset: 0x003A2BF2
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601966D RID: 104045 RVA: 0x003A4A04 File Offset: 0x003A2C04
		public IParallelSelectBtNodeT AsIParallelSelectBtNode()
		{
			return this.As<IParallelSelectBtNodeT>();
		}

		// Token: 0x0601966E RID: 104046 RVA: 0x003A4A0C File Offset: 0x003A2C0C
		public static TManyChildrenBtNodeUnion FromIParallelSelectBtNode(IParallelSelectBtNodeT _iparallelselectbtnode)
		{
			return new TManyChildrenBtNodeUnion
			{
				Type = TManyChildrenBtNode.IParallelSelectBtNode,
				Value = _iparallelselectbtnode
			};
		}

		// Token: 0x0601966F RID: 104047 RVA: 0x003A4A21 File Offset: 0x003A2C21
		public ISelectBtNodeT AsISelectBtNode()
		{
			return this.As<ISelectBtNodeT>();
		}

		// Token: 0x06019670 RID: 104048 RVA: 0x003A4A29 File Offset: 0x003A2C29
		public static TManyChildrenBtNodeUnion FromISelectBtNode(ISelectBtNodeT _iselectbtnode)
		{
			return new TManyChildrenBtNodeUnion
			{
				Type = TManyChildrenBtNode.ISelectBtNode,
				Value = _iselectbtnode
			};
		}

		// Token: 0x06019671 RID: 104049 RVA: 0x003A4A3E File Offset: 0x003A2C3E
		public ISequenceBtNodeT AsISequenceBtNode()
		{
			return this.As<ISequenceBtNodeT>();
		}

		// Token: 0x06019672 RID: 104050 RVA: 0x003A4A46 File Offset: 0x003A2C46
		public static TManyChildrenBtNodeUnion FromISequenceBtNode(ISequenceBtNodeT _isequencebtnode)
		{
			return new TManyChildrenBtNodeUnion
			{
				Type = TManyChildrenBtNode.ISequenceBtNode,
				Value = _isequencebtnode
			};
		}

		// Token: 0x06019673 RID: 104051 RVA: 0x003A4A5B File Offset: 0x003A2C5B
		public IConditionSelectorBtNodeT AsIConditionSelectorBtNode()
		{
			return this.As<IConditionSelectorBtNodeT>();
		}

		// Token: 0x06019674 RID: 104052 RVA: 0x003A4A63 File Offset: 0x003A2C63
		public static TManyChildrenBtNodeUnion FromIConditionSelectorBtNode(IConditionSelectorBtNodeT _iconditionselectorbtnode)
		{
			return new TManyChildrenBtNodeUnion
			{
				Type = TManyChildrenBtNode.IConditionSelectorBtNode,
				Value = _iconditionselectorbtnode
			};
		}

		// Token: 0x06019675 RID: 104053 RVA: 0x003A4A78 File Offset: 0x003A2C78
		public static int Pack(FlatBufferBuilder builder, TManyChildrenBtNodeUnion _o)
		{
			switch (_o.Type)
			{
			case TManyChildrenBtNode.IParallelSelectBtNode:
				return IParallelSelectBtNode.Pack(builder, _o.AsIParallelSelectBtNode()).Value;
			case TManyChildrenBtNode.ISelectBtNode:
				return ISelectBtNode.Pack(builder, _o.AsISelectBtNode()).Value;
			case TManyChildrenBtNode.ISequenceBtNode:
				return ISequenceBtNode.Pack(builder, _o.AsISequenceBtNode()).Value;
			case TManyChildrenBtNode.IConditionSelectorBtNode:
				return IConditionSelectorBtNode.Pack(builder, _o.AsIConditionSelectorBtNode()).Value;
			default:
				return 0;
			}
		}
	}
}
