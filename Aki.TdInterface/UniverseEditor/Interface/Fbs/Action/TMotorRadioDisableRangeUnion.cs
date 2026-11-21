using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007F49 RID: 32585
	public class TMotorRadioDisableRangeUnion
	{
		// Token: 0x1700F2A9 RID: 62121
		// (get) Token: 0x0603AC1D RID: 240669 RVA: 0x007E660E File Offset: 0x007E480E
		// (set) Token: 0x0603AC1E RID: 240670 RVA: 0x007E6616 File Offset: 0x007E4816
		public TMotorRadioDisableRange Type { get; set; }

		// Token: 0x1700F2AA RID: 62122
		// (get) Token: 0x0603AC1F RID: 240671 RVA: 0x007E661F File Offset: 0x007E481F
		// (set) Token: 0x0603AC20 RID: 240672 RVA: 0x007E6627 File Offset: 0x007E4827
		public object Value { get; set; }

		// Token: 0x0603AC21 RID: 240673 RVA: 0x007E6630 File Offset: 0x007E4830
		public TMotorRadioDisableRangeUnion()
		{
			this.Type = TMotorRadioDisableRange.NONE;
			this.Value = null;
		}

		// Token: 0x0603AC22 RID: 240674 RVA: 0x007E6646 File Offset: 0x007E4846
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603AC23 RID: 240675 RVA: 0x007E6658 File Offset: 0x007E4858
		public IMotorRadioDisableByAbsoluteRangeT AsIMotorRadioDisableByAbsoluteRange()
		{
			return this.As<IMotorRadioDisableByAbsoluteRangeT>();
		}

		// Token: 0x0603AC24 RID: 240676 RVA: 0x007E6660 File Offset: 0x007E4860
		public static TMotorRadioDisableRangeUnion FromIMotorRadioDisableByAbsoluteRange(IMotorRadioDisableByAbsoluteRangeT _imotorradiodisablebyabsoluterange)
		{
			return new TMotorRadioDisableRangeUnion
			{
				Type = TMotorRadioDisableRange.IMotorRadioDisableByAbsoluteRange,
				Value = _imotorradiodisablebyabsoluterange
			};
		}

		// Token: 0x0603AC25 RID: 240677 RVA: 0x007E6675 File Offset: 0x007E4875
		public IMotorRadioDisableByAreaIdT AsIMotorRadioDisableByAreaId()
		{
			return this.As<IMotorRadioDisableByAreaIdT>();
		}

		// Token: 0x0603AC26 RID: 240678 RVA: 0x007E667D File Offset: 0x007E487D
		public static TMotorRadioDisableRangeUnion FromIMotorRadioDisableByAreaId(IMotorRadioDisableByAreaIdT _imotorradiodisablebyareaid)
		{
			return new TMotorRadioDisableRangeUnion
			{
				Type = TMotorRadioDisableRange.IMotorRadioDisableByAreaId,
				Value = _imotorradiodisablebyareaid
			};
		}

		// Token: 0x0603AC27 RID: 240679 RVA: 0x007E6692 File Offset: 0x007E4892
		public IMotorRadioDisableByRangeEntitiesT AsIMotorRadioDisableByRangeEntities()
		{
			return this.As<IMotorRadioDisableByRangeEntitiesT>();
		}

		// Token: 0x0603AC28 RID: 240680 RVA: 0x007E669A File Offset: 0x007E489A
		public static TMotorRadioDisableRangeUnion FromIMotorRadioDisableByRangeEntities(IMotorRadioDisableByRangeEntitiesT _imotorradiodisablebyrangeentities)
		{
			return new TMotorRadioDisableRangeUnion
			{
				Type = TMotorRadioDisableRange.IMotorRadioDisableByRangeEntities,
				Value = _imotorradiodisablebyrangeentities
			};
		}

		// Token: 0x0603AC29 RID: 240681 RVA: 0x007E66B0 File Offset: 0x007E48B0
		public static int Pack(FlatBufferBuilder builder, TMotorRadioDisableRangeUnion _o)
		{
			switch (_o.Type)
			{
			case TMotorRadioDisableRange.IMotorRadioDisableByAbsoluteRange:
				return IMotorRadioDisableByAbsoluteRange.Pack(builder, _o.AsIMotorRadioDisableByAbsoluteRange()).Value;
			case TMotorRadioDisableRange.IMotorRadioDisableByAreaId:
				return IMotorRadioDisableByAreaId.Pack(builder, _o.AsIMotorRadioDisableByAreaId()).Value;
			case TMotorRadioDisableRange.IMotorRadioDisableByRangeEntities:
				return IMotorRadioDisableByRangeEntities.Pack(builder, _o.AsIMotorRadioDisableByRangeEntities()).Value;
			default:
				return 0;
			}
		}
	}
}
