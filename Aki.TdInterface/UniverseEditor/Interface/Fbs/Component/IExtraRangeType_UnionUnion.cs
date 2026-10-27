using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200521A RID: 21018
	public class IExtraRangeType_UnionUnion
	{
		// Token: 0x170099F0 RID: 39408
		// (get) Token: 0x0602227C RID: 139900 RVA: 0x004BD219 File Offset: 0x004BB419
		// (set) Token: 0x0602227D RID: 139901 RVA: 0x004BD221 File Offset: 0x004BB421
		public IExtraRangeType_Union Type { get; set; }

		// Token: 0x170099F1 RID: 39409
		// (get) Token: 0x0602227E RID: 139902 RVA: 0x004BD22A File Offset: 0x004BB42A
		// (set) Token: 0x0602227F RID: 139903 RVA: 0x004BD232 File Offset: 0x004BB432
		public object Value { get; set; }

		// Token: 0x06022280 RID: 139904 RVA: 0x004BD23B File Offset: 0x004BB43B
		public IExtraRangeType_UnionUnion()
		{
			this.Type = IExtraRangeType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06022281 RID: 139905 RVA: 0x004BD251 File Offset: 0x004BB451
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06022282 RID: 139906 RVA: 0x004BD263 File Offset: 0x004BB463
		public IExtraRangeTypeT AsIExtraRangeType()
		{
			return this.As<IExtraRangeTypeT>();
		}

		// Token: 0x06022283 RID: 139907 RVA: 0x004BD26B File Offset: 0x004BB46B
		public static IExtraRangeType_UnionUnion FromIExtraRangeType(IExtraRangeTypeT _iextrarangetype)
		{
			return new IExtraRangeType_UnionUnion
			{
				Type = IExtraRangeType_Union.IExtraRangeType,
				Value = _iextrarangetype
			};
		}

		// Token: 0x06022284 RID: 139908 RVA: 0x004BD280 File Offset: 0x004BB480
		public ISunSpiritBlockExtraRangeT AsISunSpiritBlockExtraRange()
		{
			return this.As<ISunSpiritBlockExtraRangeT>();
		}

		// Token: 0x06022285 RID: 139909 RVA: 0x004BD288 File Offset: 0x004BB488
		public static IExtraRangeType_UnionUnion FromISunSpiritBlockExtraRange(ISunSpiritBlockExtraRangeT _isunspiritblockextrarange)
		{
			return new IExtraRangeType_UnionUnion
			{
				Type = IExtraRangeType_Union.ISunSpiritBlockExtraRange,
				Value = _isunspiritblockextrarange
			};
		}

		// Token: 0x06022286 RID: 139910 RVA: 0x004BD2A0 File Offset: 0x004BB4A0
		public static int Pack(FlatBufferBuilder builder, IExtraRangeType_UnionUnion _o)
		{
			IExtraRangeType_Union type = _o.Type;
			if (type == IExtraRangeType_Union.IExtraRangeType)
			{
				return IExtraRangeType.Pack(builder, _o.AsIExtraRangeType()).Value;
			}
			if (type != IExtraRangeType_Union.ISunSpiritBlockExtraRange)
			{
				return 0;
			}
			return ISunSpiritBlockExtraRange.Pack(builder, _o.AsISunSpiritBlockExtraRange()).Value;
		}
	}
}
