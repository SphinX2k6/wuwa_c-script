using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200726B RID: 29291
	public class IMotorRadioDisableRange_UnionUnion
	{
		// Token: 0x1700D6C2 RID: 54978
		// (get) Token: 0x0603309E RID: 209054 RVA: 0x006E39A1 File Offset: 0x006E1BA1
		// (set) Token: 0x0603309F RID: 209055 RVA: 0x006E39A9 File Offset: 0x006E1BA9
		public IMotorRadioDisableRange_Union Type { get; set; }

		// Token: 0x1700D6C3 RID: 54979
		// (get) Token: 0x060330A0 RID: 209056 RVA: 0x006E39B2 File Offset: 0x006E1BB2
		// (set) Token: 0x060330A1 RID: 209057 RVA: 0x006E39BA File Offset: 0x006E1BBA
		public object Value { get; set; }

		// Token: 0x060330A2 RID: 209058 RVA: 0x006E39C3 File Offset: 0x006E1BC3
		public IMotorRadioDisableRange_UnionUnion()
		{
			this.Type = IMotorRadioDisableRange_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060330A3 RID: 209059 RVA: 0x006E39D9 File Offset: 0x006E1BD9
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060330A4 RID: 209060 RVA: 0x006E39EB File Offset: 0x006E1BEB
		public IMotorRadioDisableRangeT AsIMotorRadioDisableRange()
		{
			return this.As<IMotorRadioDisableRangeT>();
		}

		// Token: 0x060330A5 RID: 209061 RVA: 0x006E39F3 File Offset: 0x006E1BF3
		public static IMotorRadioDisableRange_UnionUnion FromIMotorRadioDisableRange(IMotorRadioDisableRangeT _imotorradiodisablerange)
		{
			return new IMotorRadioDisableRange_UnionUnion
			{
				Type = IMotorRadioDisableRange_Union.IMotorRadioDisableRange,
				Value = _imotorradiodisablerange
			};
		}

		// Token: 0x060330A6 RID: 209062 RVA: 0x006E3A08 File Offset: 0x006E1C08
		public IMotorRadioDisableByAreaIdT AsIMotorRadioDisableByAreaId()
		{
			return this.As<IMotorRadioDisableByAreaIdT>();
		}

		// Token: 0x060330A7 RID: 209063 RVA: 0x006E3A10 File Offset: 0x006E1C10
		public static IMotorRadioDisableRange_UnionUnion FromIMotorRadioDisableByAreaId(IMotorRadioDisableByAreaIdT _imotorradiodisablebyareaid)
		{
			return new IMotorRadioDisableRange_UnionUnion
			{
				Type = IMotorRadioDisableRange_Union.IMotorRadioDisableByAreaId,
				Value = _imotorradiodisablebyareaid
			};
		}

		// Token: 0x060330A8 RID: 209064 RVA: 0x006E3A25 File Offset: 0x006E1C25
		public IMotorRadioDisableByAbsoluteRangeT AsIMotorRadioDisableByAbsoluteRange()
		{
			return this.As<IMotorRadioDisableByAbsoluteRangeT>();
		}

		// Token: 0x060330A9 RID: 209065 RVA: 0x006E3A2D File Offset: 0x006E1C2D
		public static IMotorRadioDisableRange_UnionUnion FromIMotorRadioDisableByAbsoluteRange(IMotorRadioDisableByAbsoluteRangeT _imotorradiodisablebyabsoluterange)
		{
			return new IMotorRadioDisableRange_UnionUnion
			{
				Type = IMotorRadioDisableRange_Union.IMotorRadioDisableByAbsoluteRange,
				Value = _imotorradiodisablebyabsoluterange
			};
		}

		// Token: 0x060330AA RID: 209066 RVA: 0x006E3A42 File Offset: 0x006E1C42
		public IMotorRadioDisableByRangeEntitiesT AsIMotorRadioDisableByRangeEntities()
		{
			return this.As<IMotorRadioDisableByRangeEntitiesT>();
		}

		// Token: 0x060330AB RID: 209067 RVA: 0x006E3A4A File Offset: 0x006E1C4A
		public static IMotorRadioDisableRange_UnionUnion FromIMotorRadioDisableByRangeEntities(IMotorRadioDisableByRangeEntitiesT _imotorradiodisablebyrangeentities)
		{
			return new IMotorRadioDisableRange_UnionUnion
			{
				Type = IMotorRadioDisableRange_Union.IMotorRadioDisableByRangeEntities,
				Value = _imotorradiodisablebyrangeentities
			};
		}

		// Token: 0x060330AC RID: 209068 RVA: 0x006E3A60 File Offset: 0x006E1C60
		public static int Pack(FlatBufferBuilder builder, IMotorRadioDisableRange_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IMotorRadioDisableRange_Union.IMotorRadioDisableRange:
				return IMotorRadioDisableRange.Pack(builder, _o.AsIMotorRadioDisableRange()).Value;
			case IMotorRadioDisableRange_Union.IMotorRadioDisableByAreaId:
				return IMotorRadioDisableByAreaId.Pack(builder, _o.AsIMotorRadioDisableByAreaId()).Value;
			case IMotorRadioDisableRange_Union.IMotorRadioDisableByAbsoluteRange:
				return IMotorRadioDisableByAbsoluteRange.Pack(builder, _o.AsIMotorRadioDisableByAbsoluteRange()).Value;
			case IMotorRadioDisableRange_Union.IMotorRadioDisableByRangeEntities:
				return IMotorRadioDisableByRangeEntities.Pack(builder, _o.AsIMotorRadioDisableByRangeEntities()).Value;
			default:
				return 0;
			}
		}
	}
}
