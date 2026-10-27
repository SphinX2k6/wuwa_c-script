using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x020048F7 RID: 18679
	public class TTwoDimensionOutlineNodeUnion
	{
		// Token: 0x17008778 RID: 34680
		// (get) Token: 0x0601D326 RID: 119590 RVA: 0x0041EAFA File Offset: 0x0041CCFA
		// (set) Token: 0x0601D327 RID: 119591 RVA: 0x0041EB02 File Offset: 0x0041CD02
		public TTwoDimensionOutlineNode Type { get; set; }

		// Token: 0x17008779 RID: 34681
		// (get) Token: 0x0601D328 RID: 119592 RVA: 0x0041EB0B File Offset: 0x0041CD0B
		// (set) Token: 0x0601D329 RID: 119593 RVA: 0x0041EB13 File Offset: 0x0041CD13
		public object Value { get; set; }

		// Token: 0x0601D32A RID: 119594 RVA: 0x0041EB1C File Offset: 0x0041CD1C
		public TTwoDimensionOutlineNodeUnion()
		{
			this.Type = TTwoDimensionOutlineNode.NONE;
			this.Value = null;
		}

		// Token: 0x0601D32B RID: 119595 RVA: 0x0041EB32 File Offset: 0x0041CD32
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601D32C RID: 119596 RVA: 0x0041EB44 File Offset: 0x0041CD44
		public ITwoDimensionOutlineFolderNodeT AsITwoDimensionOutlineFolderNode()
		{
			return this.As<ITwoDimensionOutlineFolderNodeT>();
		}

		// Token: 0x0601D32D RID: 119597 RVA: 0x0041EB4C File Offset: 0x0041CD4C
		public static TTwoDimensionOutlineNodeUnion FromITwoDimensionOutlineFolderNode(ITwoDimensionOutlineFolderNodeT _itwodimensionoutlinefoldernode)
		{
			return new TTwoDimensionOutlineNodeUnion
			{
				Type = TTwoDimensionOutlineNode.ITwoDimensionOutlineFolderNode,
				Value = _itwodimensionoutlinefoldernode
			};
		}

		// Token: 0x0601D32E RID: 119598 RVA: 0x0041EB61 File Offset: 0x0041CD61
		public ITwoDimensionOutlineItemNodeT AsITwoDimensionOutlineItemNode()
		{
			return this.As<ITwoDimensionOutlineItemNodeT>();
		}

		// Token: 0x0601D32F RID: 119599 RVA: 0x0041EB69 File Offset: 0x0041CD69
		public static TTwoDimensionOutlineNodeUnion FromITwoDimensionOutlineItemNode(ITwoDimensionOutlineItemNodeT _itwodimensionoutlineitemnode)
		{
			return new TTwoDimensionOutlineNodeUnion
			{
				Type = TTwoDimensionOutlineNode.ITwoDimensionOutlineItemNode,
				Value = _itwodimensionoutlineitemnode
			};
		}

		// Token: 0x0601D330 RID: 119600 RVA: 0x0041EB80 File Offset: 0x0041CD80
		public static int Pack(FlatBufferBuilder builder, TTwoDimensionOutlineNodeUnion _o)
		{
			TTwoDimensionOutlineNode type = _o.Type;
			if (type == TTwoDimensionOutlineNode.ITwoDimensionOutlineFolderNode)
			{
				return ITwoDimensionOutlineFolderNode.Pack(builder, _o.AsITwoDimensionOutlineFolderNode()).Value;
			}
			if (type != TTwoDimensionOutlineNode.ITwoDimensionOutlineItemNode)
			{
				return 0;
			}
			return ITwoDimensionOutlineItemNode.Pack(builder, _o.AsITwoDimensionOutlineItemNode()).Value;
		}
	}
}
