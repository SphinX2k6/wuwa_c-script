using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005782 RID: 22402
	public class IExtraRangeType_UnionUnion
	{
		// Token: 0x1700A1EC RID: 41452
		// (get) Token: 0x06024212 RID: 147986 RVA: 0x004F7CDD File Offset: 0x004F5EDD
		// (set) Token: 0x06024213 RID: 147987 RVA: 0x004F7CE5 File Offset: 0x004F5EE5
		public IExtraRangeType_Union Type { get; set; }

		// Token: 0x1700A1ED RID: 41453
		// (get) Token: 0x06024214 RID: 147988 RVA: 0x004F7CEE File Offset: 0x004F5EEE
		// (set) Token: 0x06024215 RID: 147989 RVA: 0x004F7CF6 File Offset: 0x004F5EF6
		public object Value { get; set; }

		// Token: 0x06024216 RID: 147990 RVA: 0x004F7CFF File Offset: 0x004F5EFF
		public IExtraRangeType_UnionUnion()
		{
			this.Type = IExtraRangeType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06024217 RID: 147991 RVA: 0x004F7D15 File Offset: 0x004F5F15
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06024218 RID: 147992 RVA: 0x004F7D27 File Offset: 0x004F5F27
		public IExtraRangeTypeT AsIExtraRangeType()
		{
			return this.As<IExtraRangeTypeT>();
		}

		// Token: 0x06024219 RID: 147993 RVA: 0x004F7D2F File Offset: 0x004F5F2F
		public static IExtraRangeType_UnionUnion FromIExtraRangeType(IExtraRangeTypeT _iextrarangetype)
		{
			return new IExtraRangeType_UnionUnion
			{
				Type = IExtraRangeType_Union.IExtraRangeType,
				Value = _iextrarangetype
			};
		}

		// Token: 0x0602421A RID: 147994 RVA: 0x004F7D44 File Offset: 0x004F5F44
		public ISunSpiritBlockExtraRangeT AsISunSpiritBlockExtraRange()
		{
			return this.As<ISunSpiritBlockExtraRangeT>();
		}

		// Token: 0x0602421B RID: 147995 RVA: 0x004F7D4C File Offset: 0x004F5F4C
		public static IExtraRangeType_UnionUnion FromISunSpiritBlockExtraRange(ISunSpiritBlockExtraRangeT _isunspiritblockextrarange)
		{
			return new IExtraRangeType_UnionUnion
			{
				Type = IExtraRangeType_Union.ISunSpiritBlockExtraRange,
				Value = _isunspiritblockextrarange
			};
		}

		// Token: 0x0602421C RID: 147996 RVA: 0x004F7D64 File Offset: 0x004F5F64
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
