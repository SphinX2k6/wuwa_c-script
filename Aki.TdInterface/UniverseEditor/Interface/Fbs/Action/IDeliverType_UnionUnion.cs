using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200657A RID: 25978
	public class IDeliverType_UnionUnion
	{
		// Token: 0x1700C0FF RID: 49407
		// (get) Token: 0x0602D108 RID: 184584 RVA: 0x0062EDED File Offset: 0x0062CFED
		// (set) Token: 0x0602D109 RID: 184585 RVA: 0x0062EDF5 File Offset: 0x0062CFF5
		public IDeliverType_Union Type { get; set; }

		// Token: 0x1700C100 RID: 49408
		// (get) Token: 0x0602D10A RID: 184586 RVA: 0x0062EDFE File Offset: 0x0062CFFE
		// (set) Token: 0x0602D10B RID: 184587 RVA: 0x0062EE06 File Offset: 0x0062D006
		public object Value { get; set; }

		// Token: 0x0602D10C RID: 184588 RVA: 0x0062EE0F File Offset: 0x0062D00F
		public IDeliverType_UnionUnion()
		{
			this.Type = IDeliverType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602D10D RID: 184589 RVA: 0x0062EE25 File Offset: 0x0062D025
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602D10E RID: 184590 RVA: 0x0062EE37 File Offset: 0x0062D037
		public IDeliverTypeT AsIDeliverType()
		{
			return this.As<IDeliverTypeT>();
		}

		// Token: 0x0602D10F RID: 184591 RVA: 0x0062EE3F File Offset: 0x0062D03F
		public static IDeliverType_UnionUnion FromIDeliverType(IDeliverTypeT _idelivertype)
		{
			return new IDeliverType_UnionUnion
			{
				Type = IDeliverType_Union.IDeliverType,
				Value = _idelivertype
			};
		}

		// Token: 0x0602D110 RID: 184592 RVA: 0x0062EE54 File Offset: 0x0062D054
		public IItemCellIndependentDeliverTypeT AsIItemCellIndependentDeliverType()
		{
			return this.As<IItemCellIndependentDeliverTypeT>();
		}

		// Token: 0x0602D111 RID: 184593 RVA: 0x0062EE5C File Offset: 0x0062D05C
		public static IDeliverType_UnionUnion FromIItemCellIndependentDeliverType(IItemCellIndependentDeliverTypeT _iitemcellindependentdelivertype)
		{
			return new IDeliverType_UnionUnion
			{
				Type = IDeliverType_Union.IItemCellIndependentDeliverType,
				Value = _iitemcellindependentdelivertype
			};
		}

		// Token: 0x0602D112 RID: 184594 RVA: 0x0062EE74 File Offset: 0x0062D074
		public static int Pack(FlatBufferBuilder builder, IDeliverType_UnionUnion _o)
		{
			IDeliverType_Union type = _o.Type;
			if (type == IDeliverType_Union.IDeliverType)
			{
				return IDeliverType.Pack(builder, _o.AsIDeliverType()).Value;
			}
			if (type != IDeliverType_Union.IItemCellIndependentDeliverType)
			{
				return 0;
			}
			return IItemCellIndependentDeliverType.Pack(builder, _o.AsIItemCellIndependentDeliverType()).Value;
		}
	}
}
