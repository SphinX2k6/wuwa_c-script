using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020077E0 RID: 30688
	public class ISetJigsawItemType_UnionUnion
	{
		// Token: 0x1700E0E5 RID: 57573
		// (get) Token: 0x06035E69 RID: 220777 RVA: 0x00738969 File Offset: 0x00736B69
		// (set) Token: 0x06035E6A RID: 220778 RVA: 0x00738971 File Offset: 0x00736B71
		public ISetJigsawItemType_Union Type { get; set; }

		// Token: 0x1700E0E6 RID: 57574
		// (get) Token: 0x06035E6B RID: 220779 RVA: 0x0073897A File Offset: 0x00736B7A
		// (set) Token: 0x06035E6C RID: 220780 RVA: 0x00738982 File Offset: 0x00736B82
		public object Value { get; set; }

		// Token: 0x06035E6D RID: 220781 RVA: 0x0073898B File Offset: 0x00736B8B
		public ISetJigsawItemType_UnionUnion()
		{
			this.Type = ISetJigsawItemType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06035E6E RID: 220782 RVA: 0x007389A1 File Offset: 0x00736BA1
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06035E6F RID: 220783 RVA: 0x007389B3 File Offset: 0x00736BB3
		public ISetJigsawItemTypeT AsISetJigsawItemType()
		{
			return this.As<ISetJigsawItemTypeT>();
		}

		// Token: 0x06035E70 RID: 220784 RVA: 0x007389BB File Offset: 0x00736BBB
		public static ISetJigsawItemType_UnionUnion FromISetJigsawItemType(ISetJigsawItemTypeT _isetjigsawitemtype)
		{
			return new ISetJigsawItemType_UnionUnion
			{
				Type = ISetJigsawItemType_Union.ISetJigsawItemType,
				Value = _isetjigsawitemtype
			};
		}

		// Token: 0x06035E71 RID: 220785 RVA: 0x007389D0 File Offset: 0x00736BD0
		public IMoveJigsawItemT AsIMoveJigsawItem()
		{
			return this.As<IMoveJigsawItemT>();
		}

		// Token: 0x06035E72 RID: 220786 RVA: 0x007389D8 File Offset: 0x00736BD8
		public static ISetJigsawItemType_UnionUnion FromIMoveJigsawItem(IMoveJigsawItemT _imovejigsawitem)
		{
			return new ISetJigsawItemType_UnionUnion
			{
				Type = ISetJigsawItemType_Union.IMoveJigsawItem,
				Value = _imovejigsawitem
			};
		}

		// Token: 0x06035E73 RID: 220787 RVA: 0x007389F0 File Offset: 0x00736BF0
		public static int Pack(FlatBufferBuilder builder, ISetJigsawItemType_UnionUnion _o)
		{
			ISetJigsawItemType_Union type = _o.Type;
			if (type == ISetJigsawItemType_Union.ISetJigsawItemType)
			{
				return ISetJigsawItemType.Pack(builder, _o.AsISetJigsawItemType()).Value;
			}
			if (type != ISetJigsawItemType_Union.IMoveJigsawItem)
			{
				return 0;
			}
			return IMoveJigsawItem.Pack(builder, _o.AsIMoveJigsawItem()).Value;
		}
	}
}
