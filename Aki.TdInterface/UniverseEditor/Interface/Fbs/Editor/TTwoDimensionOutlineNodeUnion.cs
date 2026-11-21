using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004D5C RID: 19804
	public class TTwoDimensionOutlineNodeUnion
	{
		// Token: 0x17008DC0 RID: 36288
		// (get) Token: 0x0601EB13 RID: 125715 RVA: 0x0044B296 File Offset: 0x00449496
		// (set) Token: 0x0601EB14 RID: 125716 RVA: 0x0044B29E File Offset: 0x0044949E
		public TTwoDimensionOutlineNode Type { get; set; }

		// Token: 0x17008DC1 RID: 36289
		// (get) Token: 0x0601EB15 RID: 125717 RVA: 0x0044B2A7 File Offset: 0x004494A7
		// (set) Token: 0x0601EB16 RID: 125718 RVA: 0x0044B2AF File Offset: 0x004494AF
		public object Value { get; set; }

		// Token: 0x0601EB17 RID: 125719 RVA: 0x0044B2B8 File Offset: 0x004494B8
		public TTwoDimensionOutlineNodeUnion()
		{
			this.Type = TTwoDimensionOutlineNode.NONE;
			this.Value = null;
		}

		// Token: 0x0601EB18 RID: 125720 RVA: 0x0044B2CE File Offset: 0x004494CE
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601EB19 RID: 125721 RVA: 0x0044B2E0 File Offset: 0x004494E0
		public ITwoDimensionOutlineFolderNodeT AsITwoDimensionOutlineFolderNode()
		{
			return this.As<ITwoDimensionOutlineFolderNodeT>();
		}

		// Token: 0x0601EB1A RID: 125722 RVA: 0x0044B2E8 File Offset: 0x004494E8
		public static TTwoDimensionOutlineNodeUnion FromITwoDimensionOutlineFolderNode(ITwoDimensionOutlineFolderNodeT _itwodimensionoutlinefoldernode)
		{
			return new TTwoDimensionOutlineNodeUnion
			{
				Type = TTwoDimensionOutlineNode.ITwoDimensionOutlineFolderNode,
				Value = _itwodimensionoutlinefoldernode
			};
		}

		// Token: 0x0601EB1B RID: 125723 RVA: 0x0044B2FD File Offset: 0x004494FD
		public ITwoDimensionOutlineItemNodeT AsITwoDimensionOutlineItemNode()
		{
			return this.As<ITwoDimensionOutlineItemNodeT>();
		}

		// Token: 0x0601EB1C RID: 125724 RVA: 0x0044B305 File Offset: 0x00449505
		public static TTwoDimensionOutlineNodeUnion FromITwoDimensionOutlineItemNode(ITwoDimensionOutlineItemNodeT _itwodimensionoutlineitemnode)
		{
			return new TTwoDimensionOutlineNodeUnion
			{
				Type = TTwoDimensionOutlineNode.ITwoDimensionOutlineItemNode,
				Value = _itwodimensionoutlineitemnode
			};
		}

		// Token: 0x0601EB1D RID: 125725 RVA: 0x0044B31C File Offset: 0x0044951C
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
