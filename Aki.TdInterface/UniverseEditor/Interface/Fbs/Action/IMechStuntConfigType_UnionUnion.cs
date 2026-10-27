using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A92 RID: 27282
	public class IMechStuntConfigType_UnionUnion
	{
		// Token: 0x1700CA87 RID: 51847
		// (get) Token: 0x0602FCF0 RID: 195824 RVA: 0x006815E5 File Offset: 0x0067F7E5
		// (set) Token: 0x0602FCF1 RID: 195825 RVA: 0x006815ED File Offset: 0x0067F7ED
		public IMechStuntConfigType_Union Type { get; set; }

		// Token: 0x1700CA88 RID: 51848
		// (get) Token: 0x0602FCF2 RID: 195826 RVA: 0x006815F6 File Offset: 0x0067F7F6
		// (set) Token: 0x0602FCF3 RID: 195827 RVA: 0x006815FE File Offset: 0x0067F7FE
		public object Value { get; set; }

		// Token: 0x0602FCF4 RID: 195828 RVA: 0x00681607 File Offset: 0x0067F807
		public IMechStuntConfigType_UnionUnion()
		{
			this.Type = IMechStuntConfigType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602FCF5 RID: 195829 RVA: 0x0068161D File Offset: 0x0067F81D
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602FCF6 RID: 195830 RVA: 0x0068162F File Offset: 0x0067F82F
		public IMechStuntConfigTypeT AsIMechStuntConfigType()
		{
			return this.As<IMechStuntConfigTypeT>();
		}

		// Token: 0x0602FCF7 RID: 195831 RVA: 0x00681637 File Offset: 0x0067F837
		public static IMechStuntConfigType_UnionUnion FromIMechStuntConfigType(IMechStuntConfigTypeT _imechstuntconfigtype)
		{
			return new IMechStuntConfigType_UnionUnion
			{
				Type = IMechStuntConfigType_Union.IMechStuntConfigType,
				Value = _imechstuntconfigtype
			};
		}

		// Token: 0x0602FCF8 RID: 195832 RVA: 0x0068164C File Offset: 0x0067F84C
		public IMechStuntDiveT AsIMechStuntDive()
		{
			return this.As<IMechStuntDiveT>();
		}

		// Token: 0x0602FCF9 RID: 195833 RVA: 0x00681654 File Offset: 0x0067F854
		public static IMechStuntConfigType_UnionUnion FromIMechStuntDive(IMechStuntDiveT _imechstuntdive)
		{
			return new IMechStuntConfigType_UnionUnion
			{
				Type = IMechStuntConfigType_Union.IMechStuntDive,
				Value = _imechstuntdive
			};
		}

		// Token: 0x0602FCFA RID: 195834 RVA: 0x00681669 File Offset: 0x0067F869
		public IMechStuntClimbFlyT AsIMechStuntClimbFly()
		{
			return this.As<IMechStuntClimbFlyT>();
		}

		// Token: 0x0602FCFB RID: 195835 RVA: 0x00681671 File Offset: 0x0067F871
		public static IMechStuntConfigType_UnionUnion FromIMechStuntClimbFly(IMechStuntClimbFlyT _imechstuntclimbfly)
		{
			return new IMechStuntConfigType_UnionUnion
			{
				Type = IMechStuntConfigType_Union.IMechStuntClimbFly,
				Value = _imechstuntclimbfly
			};
		}

		// Token: 0x0602FCFC RID: 195836 RVA: 0x00681686 File Offset: 0x0067F886
		public IMechStuntLevelFlyT AsIMechStuntLevelFly()
		{
			return this.As<IMechStuntLevelFlyT>();
		}

		// Token: 0x0602FCFD RID: 195837 RVA: 0x0068168E File Offset: 0x0067F88E
		public static IMechStuntConfigType_UnionUnion FromIMechStuntLevelFly(IMechStuntLevelFlyT _imechstuntlevelfly)
		{
			return new IMechStuntConfigType_UnionUnion
			{
				Type = IMechStuntConfigType_Union.IMechStuntLevelFly,
				Value = _imechstuntlevelfly
			};
		}

		// Token: 0x0602FCFE RID: 195838 RVA: 0x006816A3 File Offset: 0x0067F8A3
		public IMechStuntHighSpeedT AsIMechStuntHighSpeed()
		{
			return this.As<IMechStuntHighSpeedT>();
		}

		// Token: 0x0602FCFF RID: 195839 RVA: 0x006816AB File Offset: 0x0067F8AB
		public static IMechStuntConfigType_UnionUnion FromIMechStuntHighSpeed(IMechStuntHighSpeedT _imechstunthighspeed)
		{
			return new IMechStuntConfigType_UnionUnion
			{
				Type = IMechStuntConfigType_Union.IMechStuntHighSpeed,
				Value = _imechstunthighspeed
			};
		}

		// Token: 0x0602FD00 RID: 195840 RVA: 0x006816C0 File Offset: 0x0067F8C0
		public IMechStuntWaterT AsIMechStuntWater()
		{
			return this.As<IMechStuntWaterT>();
		}

		// Token: 0x0602FD01 RID: 195841 RVA: 0x006816C8 File Offset: 0x0067F8C8
		public static IMechStuntConfigType_UnionUnion FromIMechStuntWater(IMechStuntWaterT _imechstuntwater)
		{
			return new IMechStuntConfigType_UnionUnion
			{
				Type = IMechStuntConfigType_Union.IMechStuntWater,
				Value = _imechstuntwater
			};
		}

		// Token: 0x0602FD02 RID: 195842 RVA: 0x006816DD File Offset: 0x0067F8DD
		public IMechStuntBurrowT AsIMechStuntBurrow()
		{
			return this.As<IMechStuntBurrowT>();
		}

		// Token: 0x0602FD03 RID: 195843 RVA: 0x006816E5 File Offset: 0x0067F8E5
		public static IMechStuntConfigType_UnionUnion FromIMechStuntBurrow(IMechStuntBurrowT _imechstuntburrow)
		{
			return new IMechStuntConfigType_UnionUnion
			{
				Type = IMechStuntConfigType_Union.IMechStuntBurrow,
				Value = _imechstuntburrow
			};
		}

		// Token: 0x0602FD04 RID: 195844 RVA: 0x006816FC File Offset: 0x0067F8FC
		public static int Pack(FlatBufferBuilder builder, IMechStuntConfigType_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IMechStuntConfigType_Union.IMechStuntConfigType:
				return IMechStuntConfigType.Pack(builder, _o.AsIMechStuntConfigType()).Value;
			case IMechStuntConfigType_Union.IMechStuntDive:
				return IMechStuntDive.Pack(builder, _o.AsIMechStuntDive()).Value;
			case IMechStuntConfigType_Union.IMechStuntClimbFly:
				return IMechStuntClimbFly.Pack(builder, _o.AsIMechStuntClimbFly()).Value;
			case IMechStuntConfigType_Union.IMechStuntLevelFly:
				return IMechStuntLevelFly.Pack(builder, _o.AsIMechStuntLevelFly()).Value;
			case IMechStuntConfigType_Union.IMechStuntHighSpeed:
				return IMechStuntHighSpeed.Pack(builder, _o.AsIMechStuntHighSpeed()).Value;
			case IMechStuntConfigType_Union.IMechStuntWater:
				return IMechStuntWater.Pack(builder, _o.AsIMechStuntWater()).Value;
			case IMechStuntConfigType_Union.IMechStuntBurrow:
				return IMechStuntBurrow.Pack(builder, _o.AsIMechStuntBurrow()).Value;
			default:
				return 0;
			}
		}
	}
}
