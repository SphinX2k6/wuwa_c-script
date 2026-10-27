using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Occupation
{
	// Token: 0x020043BA RID: 17338
	public class IOccupationType_UnionUnion
	{
		// Token: 0x17007A9D RID: 31389
		// (get) Token: 0x06019D78 RID: 105848 RVA: 0x003B2FE9 File Offset: 0x003B11E9
		// (set) Token: 0x06019D79 RID: 105849 RVA: 0x003B2FF1 File Offset: 0x003B11F1
		public IOccupationType_Union Type { get; set; }

		// Token: 0x17007A9E RID: 31390
		// (get) Token: 0x06019D7A RID: 105850 RVA: 0x003B2FFA File Offset: 0x003B11FA
		// (set) Token: 0x06019D7B RID: 105851 RVA: 0x003B3002 File Offset: 0x003B1202
		public object Value { get; set; }

		// Token: 0x06019D7C RID: 105852 RVA: 0x003B300B File Offset: 0x003B120B
		public IOccupationType_UnionUnion()
		{
			this.Type = IOccupationType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06019D7D RID: 105853 RVA: 0x003B3021 File Offset: 0x003B1221
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06019D7E RID: 105854 RVA: 0x003B3033 File Offset: 0x003B1233
		public IOccupationTypeT AsIOccupationType()
		{
			return this.As<IOccupationTypeT>();
		}

		// Token: 0x06019D7F RID: 105855 RVA: 0x003B303B File Offset: 0x003B123B
		public static IOccupationType_UnionUnion FromIOccupationType(IOccupationTypeT _ioccupationtype)
		{
			return new IOccupationType_UnionUnion
			{
				Type = IOccupationType_Union.IOccupationType,
				Value = _ioccupationtype
			};
		}

		// Token: 0x06019D80 RID: 105856 RVA: 0x003B3050 File Offset: 0x003B1250
		public INpcOccupationDataT AsINpcOccupationData()
		{
			return this.As<INpcOccupationDataT>();
		}

		// Token: 0x06019D81 RID: 105857 RVA: 0x003B3058 File Offset: 0x003B1258
		public static IOccupationType_UnionUnion FromINpcOccupationData(INpcOccupationDataT _inpcoccupationdata)
		{
			return new IOccupationType_UnionUnion
			{
				Type = IOccupationType_Union.INpcOccupationData,
				Value = _inpcoccupationdata
			};
		}

		// Token: 0x06019D82 RID: 105858 RVA: 0x003B306D File Offset: 0x003B126D
		public IAreaOccupationDataT AsIAreaOccupationData()
		{
			return this.As<IAreaOccupationDataT>();
		}

		// Token: 0x06019D83 RID: 105859 RVA: 0x003B3075 File Offset: 0x003B1275
		public static IOccupationType_UnionUnion FromIAreaOccupationData(IAreaOccupationDataT _iareaoccupationdata)
		{
			return new IOccupationType_UnionUnion
			{
				Type = IOccupationType_Union.IAreaOccupationData,
				Value = _iareaoccupationdata
			};
		}

		// Token: 0x06019D84 RID: 105860 RVA: 0x003B308A File Offset: 0x003B128A
		public ISilentAreaOccupationDataT AsISilentAreaOccupationData()
		{
			return this.As<ISilentAreaOccupationDataT>();
		}

		// Token: 0x06019D85 RID: 105861 RVA: 0x003B3092 File Offset: 0x003B1292
		public static IOccupationType_UnionUnion FromISilentAreaOccupationData(ISilentAreaOccupationDataT _isilentareaoccupationdata)
		{
			return new IOccupationType_UnionUnion
			{
				Type = IOccupationType_Union.ISilentAreaOccupationData,
				Value = _isilentareaoccupationdata
			};
		}

		// Token: 0x06019D86 RID: 105862 RVA: 0x003B30A7 File Offset: 0x003B12A7
		public IScreenResourceOccupationDataT AsIScreenResourceOccupationData()
		{
			return this.As<IScreenResourceOccupationDataT>();
		}

		// Token: 0x06019D87 RID: 105863 RVA: 0x003B30AF File Offset: 0x003B12AF
		public static IOccupationType_UnionUnion FromIScreenResourceOccupationData(IScreenResourceOccupationDataT _iscreenresourceoccupationdata)
		{
			return new IOccupationType_UnionUnion
			{
				Type = IOccupationType_Union.IScreenResourceOccupationData,
				Value = _iscreenresourceoccupationdata
			};
		}

		// Token: 0x06019D88 RID: 105864 RVA: 0x003B30C4 File Offset: 0x003B12C4
		public ITimeOccupationDataT AsITimeOccupationData()
		{
			return this.As<ITimeOccupationDataT>();
		}

		// Token: 0x06019D89 RID: 105865 RVA: 0x003B30CC File Offset: 0x003B12CC
		public static IOccupationType_UnionUnion FromITimeOccupationData(ITimeOccupationDataT _itimeoccupationdata)
		{
			return new IOccupationType_UnionUnion
			{
				Type = IOccupationType_Union.ITimeOccupationData,
				Value = _itimeoccupationdata
			};
		}

		// Token: 0x06019D8A RID: 105866 RVA: 0x003B30E1 File Offset: 0x003B12E1
		public IClosedSegmentOccupationDataT AsIClosedSegmentOccupationData()
		{
			return this.As<IClosedSegmentOccupationDataT>();
		}

		// Token: 0x06019D8B RID: 105867 RVA: 0x003B30E9 File Offset: 0x003B12E9
		public static IOccupationType_UnionUnion FromIClosedSegmentOccupationData(IClosedSegmentOccupationDataT _iclosedsegmentoccupationdata)
		{
			return new IOccupationType_UnionUnion
			{
				Type = IOccupationType_Union.IClosedSegmentOccupationData,
				Value = _iclosedsegmentoccupationdata
			};
		}

		// Token: 0x06019D8C RID: 105868 RVA: 0x003B3100 File Offset: 0x003B1300
		public static int Pack(FlatBufferBuilder builder, IOccupationType_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IOccupationType_Union.IOccupationType:
				return IOccupationType.Pack(builder, _o.AsIOccupationType()).Value;
			case IOccupationType_Union.INpcOccupationData:
				return INpcOccupationData.Pack(builder, _o.AsINpcOccupationData()).Value;
			case IOccupationType_Union.IAreaOccupationData:
				return IAreaOccupationData.Pack(builder, _o.AsIAreaOccupationData()).Value;
			case IOccupationType_Union.ISilentAreaOccupationData:
				return ISilentAreaOccupationData.Pack(builder, _o.AsISilentAreaOccupationData()).Value;
			case IOccupationType_Union.IScreenResourceOccupationData:
				return IScreenResourceOccupationData.Pack(builder, _o.AsIScreenResourceOccupationData()).Value;
			case IOccupationType_Union.ITimeOccupationData:
				return ITimeOccupationData.Pack(builder, _o.AsITimeOccupationData()).Value;
			case IOccupationType_Union.IClosedSegmentOccupationData:
				return IClosedSegmentOccupationData.Pack(builder, _o.AsIClosedSegmentOccupationData()).Value;
			default:
				return 0;
			}
		}
	}
}
