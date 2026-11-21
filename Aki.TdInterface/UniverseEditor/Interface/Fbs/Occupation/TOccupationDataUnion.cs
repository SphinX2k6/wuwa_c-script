using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Occupation
{
	// Token: 0x02004838 RID: 18488
	public class TOccupationDataUnion
	{
		// Token: 0x170080FD RID: 33021
		// (get) Token: 0x0601B5FF RID: 112127 RVA: 0x003E076D File Offset: 0x003DE96D
		// (set) Token: 0x0601B600 RID: 112128 RVA: 0x003E0775 File Offset: 0x003DE975
		public TOccupationData Type { get; set; }

		// Token: 0x170080FE RID: 33022
		// (get) Token: 0x0601B601 RID: 112129 RVA: 0x003E077E File Offset: 0x003DE97E
		// (set) Token: 0x0601B602 RID: 112130 RVA: 0x003E0786 File Offset: 0x003DE986
		public object Value { get; set; }

		// Token: 0x0601B603 RID: 112131 RVA: 0x003E078F File Offset: 0x003DE98F
		public TOccupationDataUnion()
		{
			this.Type = TOccupationData.NONE;
			this.Value = null;
		}

		// Token: 0x0601B604 RID: 112132 RVA: 0x003E07A5 File Offset: 0x003DE9A5
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601B605 RID: 112133 RVA: 0x003E07B7 File Offset: 0x003DE9B7
		public IAreaOccupationDataT AsIAreaOccupationData()
		{
			return this.As<IAreaOccupationDataT>();
		}

		// Token: 0x0601B606 RID: 112134 RVA: 0x003E07BF File Offset: 0x003DE9BF
		public static TOccupationDataUnion FromIAreaOccupationData(IAreaOccupationDataT _iareaoccupationdata)
		{
			return new TOccupationDataUnion
			{
				Type = TOccupationData.IAreaOccupationData,
				Value = _iareaoccupationdata
			};
		}

		// Token: 0x0601B607 RID: 112135 RVA: 0x003E07D4 File Offset: 0x003DE9D4
		public IClosedSegmentOccupationDataT AsIClosedSegmentOccupationData()
		{
			return this.As<IClosedSegmentOccupationDataT>();
		}

		// Token: 0x0601B608 RID: 112136 RVA: 0x003E07DC File Offset: 0x003DE9DC
		public static TOccupationDataUnion FromIClosedSegmentOccupationData(IClosedSegmentOccupationDataT _iclosedsegmentoccupationdata)
		{
			return new TOccupationDataUnion
			{
				Type = TOccupationData.IClosedSegmentOccupationData,
				Value = _iclosedsegmentoccupationdata
			};
		}

		// Token: 0x0601B609 RID: 112137 RVA: 0x003E07F1 File Offset: 0x003DE9F1
		public INpcOccupationDataT AsINpcOccupationData()
		{
			return this.As<INpcOccupationDataT>();
		}

		// Token: 0x0601B60A RID: 112138 RVA: 0x003E07F9 File Offset: 0x003DE9F9
		public static TOccupationDataUnion FromINpcOccupationData(INpcOccupationDataT _inpcoccupationdata)
		{
			return new TOccupationDataUnion
			{
				Type = TOccupationData.INpcOccupationData,
				Value = _inpcoccupationdata
			};
		}

		// Token: 0x0601B60B RID: 112139 RVA: 0x003E080E File Offset: 0x003DEA0E
		public IScreenResourceOccupationDataT AsIScreenResourceOccupationData()
		{
			return this.As<IScreenResourceOccupationDataT>();
		}

		// Token: 0x0601B60C RID: 112140 RVA: 0x003E0816 File Offset: 0x003DEA16
		public static TOccupationDataUnion FromIScreenResourceOccupationData(IScreenResourceOccupationDataT _iscreenresourceoccupationdata)
		{
			return new TOccupationDataUnion
			{
				Type = TOccupationData.IScreenResourceOccupationData,
				Value = _iscreenresourceoccupationdata
			};
		}

		// Token: 0x0601B60D RID: 112141 RVA: 0x003E082B File Offset: 0x003DEA2B
		public ISeasonRotationOccupationDataT AsISeasonRotationOccupationData()
		{
			return this.As<ISeasonRotationOccupationDataT>();
		}

		// Token: 0x0601B60E RID: 112142 RVA: 0x003E0833 File Offset: 0x003DEA33
		public static TOccupationDataUnion FromISeasonRotationOccupationData(ISeasonRotationOccupationDataT _iseasonrotationoccupationdata)
		{
			return new TOccupationDataUnion
			{
				Type = TOccupationData.ISeasonRotationOccupationData,
				Value = _iseasonrotationoccupationdata
			};
		}

		// Token: 0x0601B60F RID: 112143 RVA: 0x003E0848 File Offset: 0x003DEA48
		public ISilentAreaOccupationDataT AsISilentAreaOccupationData()
		{
			return this.As<ISilentAreaOccupationDataT>();
		}

		// Token: 0x0601B610 RID: 112144 RVA: 0x003E0850 File Offset: 0x003DEA50
		public static TOccupationDataUnion FromISilentAreaOccupationData(ISilentAreaOccupationDataT _isilentareaoccupationdata)
		{
			return new TOccupationDataUnion
			{
				Type = TOccupationData.ISilentAreaOccupationData,
				Value = _isilentareaoccupationdata
			};
		}

		// Token: 0x0601B611 RID: 112145 RVA: 0x003E0865 File Offset: 0x003DEA65
		public ITimeOccupationDataT AsITimeOccupationData()
		{
			return this.As<ITimeOccupationDataT>();
		}

		// Token: 0x0601B612 RID: 112146 RVA: 0x003E086D File Offset: 0x003DEA6D
		public static TOccupationDataUnion FromITimeOccupationData(ITimeOccupationDataT _itimeoccupationdata)
		{
			return new TOccupationDataUnion
			{
				Type = TOccupationData.ITimeOccupationData,
				Value = _itimeoccupationdata
			};
		}

		// Token: 0x0601B613 RID: 112147 RVA: 0x003E0884 File Offset: 0x003DEA84
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
			case TOccupationData.ISeasonRotationOccupationData:
				return ISeasonRotationOccupationData.Pack(builder, _o.AsISeasonRotationOccupationData()).Value;
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
