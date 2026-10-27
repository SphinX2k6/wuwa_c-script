using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007017 RID: 28695
	public class ISetJigsawItemType_UnionUnion
	{
		// Token: 0x1700D511 RID: 54545
		// (get) Token: 0x06032C03 RID: 207875 RVA: 0x006D8D25 File Offset: 0x006D6F25
		// (set) Token: 0x06032C04 RID: 207876 RVA: 0x006D8D2D File Offset: 0x006D6F2D
		public ISetJigsawItemType_Union Type { get; set; }

		// Token: 0x1700D512 RID: 54546
		// (get) Token: 0x06032C05 RID: 207877 RVA: 0x006D8D36 File Offset: 0x006D6F36
		// (set) Token: 0x06032C06 RID: 207878 RVA: 0x006D8D3E File Offset: 0x006D6F3E
		public object Value { get; set; }

		// Token: 0x06032C07 RID: 207879 RVA: 0x006D8D47 File Offset: 0x006D6F47
		public ISetJigsawItemType_UnionUnion()
		{
			this.Type = ISetJigsawItemType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06032C08 RID: 207880 RVA: 0x006D8D5D File Offset: 0x006D6F5D
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06032C09 RID: 207881 RVA: 0x006D8D6F File Offset: 0x006D6F6F
		public ISetJigsawItemTypeT AsISetJigsawItemType()
		{
			return this.As<ISetJigsawItemTypeT>();
		}

		// Token: 0x06032C0A RID: 207882 RVA: 0x006D8D77 File Offset: 0x006D6F77
		public static ISetJigsawItemType_UnionUnion FromISetJigsawItemType(ISetJigsawItemTypeT _isetjigsawitemtype)
		{
			return new ISetJigsawItemType_UnionUnion
			{
				Type = ISetJigsawItemType_Union.ISetJigsawItemType,
				Value = _isetjigsawitemtype
			};
		}

		// Token: 0x06032C0B RID: 207883 RVA: 0x006D8D8C File Offset: 0x006D6F8C
		public IMoveJigsawItemT AsIMoveJigsawItem()
		{
			return this.As<IMoveJigsawItemT>();
		}

		// Token: 0x06032C0C RID: 207884 RVA: 0x006D8D94 File Offset: 0x006D6F94
		public static ISetJigsawItemType_UnionUnion FromIMoveJigsawItem(IMoveJigsawItemT _imovejigsawitem)
		{
			return new ISetJigsawItemType_UnionUnion
			{
				Type = ISetJigsawItemType_Union.IMoveJigsawItem,
				Value = _imovejigsawitem
			};
		}

		// Token: 0x06032C0D RID: 207885 RVA: 0x006D8DAC File Offset: 0x006D6FAC
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
