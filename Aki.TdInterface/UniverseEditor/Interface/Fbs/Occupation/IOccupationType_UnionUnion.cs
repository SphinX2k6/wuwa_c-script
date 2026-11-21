using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Occupation
{
	// Token: 0x0200481C RID: 18460
	public class IOccupationType_UnionUnion
	{
		// Token: 0x170080D4 RID: 32980
		// (get) Token: 0x0601B511 RID: 111889 RVA: 0x003DEC3D File Offset: 0x003DCE3D
		// (set) Token: 0x0601B512 RID: 111890 RVA: 0x003DEC45 File Offset: 0x003DCE45
		public IOccupationType_Union Type { get; set; }

		// Token: 0x170080D5 RID: 32981
		// (get) Token: 0x0601B513 RID: 111891 RVA: 0x003DEC4E File Offset: 0x003DCE4E
		// (set) Token: 0x0601B514 RID: 111892 RVA: 0x003DEC56 File Offset: 0x003DCE56
		public object Value { get; set; }

		// Token: 0x0601B515 RID: 111893 RVA: 0x003DEC5F File Offset: 0x003DCE5F
		public IOccupationType_UnionUnion()
		{
			this.Type = IOccupationType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0601B516 RID: 111894 RVA: 0x003DEC75 File Offset: 0x003DCE75
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601B517 RID: 111895 RVA: 0x003DEC87 File Offset: 0x003DCE87
		public IOccupationTypeT AsIOccupationType()
		{
			return this.As<IOccupationTypeT>();
		}

		// Token: 0x0601B518 RID: 111896 RVA: 0x003DEC8F File Offset: 0x003DCE8F
		public static IOccupationType_UnionUnion FromIOccupationType(IOccupationTypeT _ioccupationtype)
		{
			return new IOccupationType_UnionUnion
			{
				Type = IOccupationType_Union.IOccupationType,
				Value = _ioccupationtype
			};
		}

		// Token: 0x0601B519 RID: 111897 RVA: 0x003DECA4 File Offset: 0x003DCEA4
		public INpcOccupationDataT AsINpcOccupationData()
		{
			return this.As<INpcOccupationDataT>();
		}

		// Token: 0x0601B51A RID: 111898 RVA: 0x003DECAC File Offset: 0x003DCEAC
		public static IOccupationType_UnionUnion FromINpcOccupationData(INpcOccupationDataT _inpcoccupationdata)
		{
			return new IOccupationType_UnionUnion
			{
				Type = IOccupationType_Union.INpcOccupationData,
				Value = _inpcoccupationdata
			};
		}

		// Token: 0x0601B51B RID: 111899 RVA: 0x003DECC1 File Offset: 0x003DCEC1
		public IAreaOccupationDataT AsIAreaOccupationData()
		{
			return this.As<IAreaOccupationDataT>();
		}

		// Token: 0x0601B51C RID: 111900 RVA: 0x003DECC9 File Offset: 0x003DCEC9
		public static IOccupationType_UnionUnion FromIAreaOccupationData(IAreaOccupationDataT _iareaoccupationdata)
		{
			return new IOccupationType_UnionUnion
			{
				Type = IOccupationType_Union.IAreaOccupationData,
				Value = _iareaoccupationdata
			};
		}

		// Token: 0x0601B51D RID: 111901 RVA: 0x003DECDE File Offset: 0x003DCEDE
		public ISilentAreaOccupationDataT AsISilentAreaOccupationData()
		{
			return this.As<ISilentAreaOccupationDataT>();
		}

		// Token: 0x0601B51E RID: 111902 RVA: 0x003DECE6 File Offset: 0x003DCEE6
		public static IOccupationType_UnionUnion FromISilentAreaOccupationData(ISilentAreaOccupationDataT _isilentareaoccupationdata)
		{
			return new IOccupationType_UnionUnion
			{
				Type = IOccupationType_Union.ISilentAreaOccupationData,
				Value = _isilentareaoccupationdata
			};
		}

		// Token: 0x0601B51F RID: 111903 RVA: 0x003DECFB File Offset: 0x003DCEFB
		public IScreenResourceOccupationDataT AsIScreenResourceOccupationData()
		{
			return this.As<IScreenResourceOccupationDataT>();
		}

		// Token: 0x0601B520 RID: 111904 RVA: 0x003DED03 File Offset: 0x003DCF03
		public static IOccupationType_UnionUnion FromIScreenResourceOccupationData(IScreenResourceOccupationDataT _iscreenresourceoccupationdata)
		{
			return new IOccupationType_UnionUnion
			{
				Type = IOccupationType_Union.IScreenResourceOccupationData,
				Value = _iscreenresourceoccupationdata
			};
		}

		// Token: 0x0601B521 RID: 111905 RVA: 0x003DED18 File Offset: 0x003DCF18
		public ITimeOccupationDataT AsITimeOccupationData()
		{
			return this.As<ITimeOccupationDataT>();
		}

		// Token: 0x0601B522 RID: 111906 RVA: 0x003DED20 File Offset: 0x003DCF20
		public static IOccupationType_UnionUnion FromITimeOccupationData(ITimeOccupationDataT _itimeoccupationdata)
		{
			return new IOccupationType_UnionUnion
			{
				Type = IOccupationType_Union.ITimeOccupationData,
				Value = _itimeoccupationdata
			};
		}

		// Token: 0x0601B523 RID: 111907 RVA: 0x003DED35 File Offset: 0x003DCF35
		public IClosedSegmentOccupationDataT AsIClosedSegmentOccupationData()
		{
			return this.As<IClosedSegmentOccupationDataT>();
		}

		// Token: 0x0601B524 RID: 111908 RVA: 0x003DED3D File Offset: 0x003DCF3D
		public static IOccupationType_UnionUnion FromIClosedSegmentOccupationData(IClosedSegmentOccupationDataT _iclosedsegmentoccupationdata)
		{
			return new IOccupationType_UnionUnion
			{
				Type = IOccupationType_Union.IClosedSegmentOccupationData,
				Value = _iclosedsegmentoccupationdata
			};
		}

		// Token: 0x0601B525 RID: 111909 RVA: 0x003DED52 File Offset: 0x003DCF52
		public ISeasonRotationOccupationDataT AsISeasonRotationOccupationData()
		{
			return this.As<ISeasonRotationOccupationDataT>();
		}

		// Token: 0x0601B526 RID: 111910 RVA: 0x003DED5A File Offset: 0x003DCF5A
		public static IOccupationType_UnionUnion FromISeasonRotationOccupationData(ISeasonRotationOccupationDataT _iseasonrotationoccupationdata)
		{
			return new IOccupationType_UnionUnion
			{
				Type = IOccupationType_Union.ISeasonRotationOccupationData,
				Value = _iseasonrotationoccupationdata
			};
		}

		// Token: 0x0601B527 RID: 111911 RVA: 0x003DED70 File Offset: 0x003DCF70
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
			case IOccupationType_Union.ISeasonRotationOccupationData:
				return ISeasonRotationOccupationData.Pack(builder, _o.AsISeasonRotationOccupationData()).Value;
			default:
				return 0;
			}
		}
	}
}
