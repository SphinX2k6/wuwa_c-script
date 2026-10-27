using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Occupation
{
	// Token: 0x020043D3 RID: 17363
	public class TOccupationDataUnion
	{
		// Token: 0x17007AC3 RID: 31427
		// (get) Token: 0x06019E52 RID: 106066 RVA: 0x003B495D File Offset: 0x003B2B5D
		// (set) Token: 0x06019E53 RID: 106067 RVA: 0x003B4965 File Offset: 0x003B2B65
		public TOccupationData Type { get; set; }

		// Token: 0x17007AC4 RID: 31428
		// (get) Token: 0x06019E54 RID: 106068 RVA: 0x003B496E File Offset: 0x003B2B6E
		// (set) Token: 0x06019E55 RID: 106069 RVA: 0x003B4976 File Offset: 0x003B2B76
		public object Value { get; set; }

		// Token: 0x06019E56 RID: 106070 RVA: 0x003B497F File Offset: 0x003B2B7F
		public TOccupationDataUnion()
		{
			this.Type = TOccupationData.NONE;
			this.Value = null;
		}

		// Token: 0x06019E57 RID: 106071 RVA: 0x003B4995 File Offset: 0x003B2B95
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06019E58 RID: 106072 RVA: 0x003B49A7 File Offset: 0x003B2BA7
		public IAreaOccupationDataT AsIAreaOccupationData()
		{
			return this.As<IAreaOccupationDataT>();
		}

		// Token: 0x06019E59 RID: 106073 RVA: 0x003B49AF File Offset: 0x003B2BAF
		public static TOccupationDataUnion FromIAreaOccupationData(IAreaOccupationDataT _iareaoccupationdata)
		{
			return new TOccupationDataUnion
			{
				Type = TOccupationData.IAreaOccupationData,
				Value = _iareaoccupationdata
			};
		}

		// Token: 0x06019E5A RID: 106074 RVA: 0x003B49C4 File Offset: 0x003B2BC4
		public IClosedSegmentOccupationDataT AsIClosedSegmentOccupationData()
		{
			return this.As<IClosedSegmentOccupationDataT>();
		}

		// Token: 0x06019E5B RID: 106075 RVA: 0x003B49CC File Offset: 0x003B2BCC
		public static TOccupationDataUnion FromIClosedSegmentOccupationData(IClosedSegmentOccupationDataT _iclosedsegmentoccupationdata)
		{
			return new TOccupationDataUnion
			{
				Type = TOccupationData.IClosedSegmentOccupationData,
				Value = _iclosedsegmentoccupationdata
			};
		}

		// Token: 0x06019E5C RID: 106076 RVA: 0x003B49E1 File Offset: 0x003B2BE1
		public INpcOccupationDataT AsINpcOccupationData()
		{
			return this.As<INpcOccupationDataT>();
		}

		// Token: 0x06019E5D RID: 106077 RVA: 0x003B49E9 File Offset: 0x003B2BE9
		public static TOccupationDataUnion FromINpcOccupationData(INpcOccupationDataT _inpcoccupationdata)
		{
			return new TOccupationDataUnion
			{
				Type = TOccupationData.INpcOccupationData,
				Value = _inpcoccupationdata
			};
		}

		// Token: 0x06019E5E RID: 106078 RVA: 0x003B49FE File Offset: 0x003B2BFE
		public IScreenResourceOccupationDataT AsIScreenResourceOccupationData()
		{
			return this.As<IScreenResourceOccupationDataT>();
		}

		// Token: 0x06019E5F RID: 106079 RVA: 0x003B4A06 File Offset: 0x003B2C06
		public static TOccupationDataUnion FromIScreenResourceOccupationData(IScreenResourceOccupationDataT _iscreenresourceoccupationdata)
		{
			return new TOccupationDataUnion
			{
				Type = TOccupationData.IScreenResourceOccupationData,
				Value = _iscreenresourceoccupationdata
			};
		}

		// Token: 0x06019E60 RID: 106080 RVA: 0x003B4A1B File Offset: 0x003B2C1B
		public ISilentAreaOccupationDataT AsISilentAreaOccupationData()
		{
			return this.As<ISilentAreaOccupationDataT>();
		}

		// Token: 0x06019E61 RID: 106081 RVA: 0x003B4A23 File Offset: 0x003B2C23
		public static TOccupationDataUnion FromISilentAreaOccupationData(ISilentAreaOccupationDataT _isilentareaoccupationdata)
		{
			return new TOccupationDataUnion
			{
				Type = TOccupationData.ISilentAreaOccupationData,
				Value = _isilentareaoccupationdata
			};
		}

		// Token: 0x06019E62 RID: 106082 RVA: 0x003B4A38 File Offset: 0x003B2C38
		public ITimeOccupationDataT AsITimeOccupationData()
		{
			return this.As<ITimeOccupationDataT>();
		}

		// Token: 0x06019E63 RID: 106083 RVA: 0x003B4A40 File Offset: 0x003B2C40
		public static TOccupationDataUnion FromITimeOccupationData(ITimeOccupationDataT _itimeoccupationdata)
		{
			return new TOccupationDataUnion
			{
				Type = TOccupationData.ITimeOccupationData,
				Value = _itimeoccupationdata
			};
		}

		// Token: 0x06019E64 RID: 106084 RVA: 0x003B4A58 File Offset: 0x003B2C58
		public static int Pack(FlatBufferBuilder builder, TOccupationDataUnion _o)
		{
			switch (_o.Type)
			{
			case TOccupationData.IAreaOccupationData:
				return IAreaOccupationData.Pack(builder, _o.AsIAreaOccupationData()).Value;
			case TOccupationData.IClosedSegmentOccupationData:
				return IClosedSegmentOccupationData.Pack(builder, _o.AsIClosedSegmentOccupationData()).Value;
			case TOccupationData.INpcOccupationData:
				return INpcOccupationData.Pack(builder, _o.AsINpcOccupationData()).Value;
			case TOccupationData.IScreenResourceOccupationData:
				return IScreenResourceOccupationData.Pack(builder, _o.AsIScreenResourceOccupationData()).Value;
			case TOccupationData.ISilentAreaOccupationData:
				return ISilentAreaOccupationData.Pack(builder, _o.AsISilentAreaOccupationData()).Value;
			case TOccupationData.ITimeOccupationData:
				return ITimeOccupationData.Pack(builder, _o.AsITimeOccupationData()).Value;
			default:
				return 0;
			}
		}
	}
}
