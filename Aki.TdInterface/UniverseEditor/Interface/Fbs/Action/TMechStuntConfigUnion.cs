using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007F34 RID: 32564
	public class TMechStuntConfigUnion
	{
		// Token: 0x1700F29B RID: 62107
		// (get) Token: 0x0603ABC1 RID: 240577 RVA: 0x007E5E16 File Offset: 0x007E4016
		// (set) Token: 0x0603ABC2 RID: 240578 RVA: 0x007E5E1E File Offset: 0x007E401E
		public TMechStuntConfig Type { get; set; }

		// Token: 0x1700F29C RID: 62108
		// (get) Token: 0x0603ABC3 RID: 240579 RVA: 0x007E5E27 File Offset: 0x007E4027
		// (set) Token: 0x0603ABC4 RID: 240580 RVA: 0x007E5E2F File Offset: 0x007E402F
		public object Value { get; set; }

		// Token: 0x0603ABC5 RID: 240581 RVA: 0x007E5E38 File Offset: 0x007E4038
		public TMechStuntConfigUnion()
		{
			this.Type = TMechStuntConfig.NONE;
			this.Value = null;
		}

		// Token: 0x0603ABC6 RID: 240582 RVA: 0x007E5E4E File Offset: 0x007E404E
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603ABC7 RID: 240583 RVA: 0x007E5E60 File Offset: 0x007E4060
		public IMechStuntBurrowT AsIMechStuntBurrow()
		{
			return this.As<IMechStuntBurrowT>();
		}

		// Token: 0x0603ABC8 RID: 240584 RVA: 0x007E5E68 File Offset: 0x007E4068
		public static TMechStuntConfigUnion FromIMechStuntBurrow(IMechStuntBurrowT _imechstuntburrow)
		{
			return new TMechStuntConfigUnion
			{
				Type = TMechStuntConfig.IMechStuntBurrow,
				Value = _imechstuntburrow
			};
		}

		// Token: 0x0603ABC9 RID: 240585 RVA: 0x007E5E7D File Offset: 0x007E407D
		public IMechStuntClimbFlyT AsIMechStuntClimbFly()
		{
			return this.As<IMechStuntClimbFlyT>();
		}

		// Token: 0x0603ABCA RID: 240586 RVA: 0x007E5E85 File Offset: 0x007E4085
		public static TMechStuntConfigUnion FromIMechStuntClimbFly(IMechStuntClimbFlyT _imechstuntclimbfly)
		{
			return new TMechStuntConfigUnion
			{
				Type = TMechStuntConfig.IMechStuntClimbFly,
				Value = _imechstuntclimbfly
			};
		}

		// Token: 0x0603ABCB RID: 240587 RVA: 0x007E5E9A File Offset: 0x007E409A
		public IMechStuntDiveT AsIMechStuntDive()
		{
			return this.As<IMechStuntDiveT>();
		}

		// Token: 0x0603ABCC RID: 240588 RVA: 0x007E5EA2 File Offset: 0x007E40A2
		public static TMechStuntConfigUnion FromIMechStuntDive(IMechStuntDiveT _imechstuntdive)
		{
			return new TMechStuntConfigUnion
			{
				Type = TMechStuntConfig.IMechStuntDive,
				Value = _imechstuntdive
			};
		}

		// Token: 0x0603ABCD RID: 240589 RVA: 0x007E5EB7 File Offset: 0x007E40B7
		public IMechStuntHighSpeedT AsIMechStuntHighSpeed()
		{
			return this.As<IMechStuntHighSpeedT>();
		}

		// Token: 0x0603ABCE RID: 240590 RVA: 0x007E5EBF File Offset: 0x007E40BF
		public static TMechStuntConfigUnion FromIMechStuntHighSpeed(IMechStuntHighSpeedT _imechstunthighspeed)
		{
			return new TMechStuntConfigUnion
			{
				Type = TMechStuntConfig.IMechStuntHighSpeed,
				Value = _imechstunthighspeed
			};
		}

		// Token: 0x0603ABCF RID: 240591 RVA: 0x007E5ED4 File Offset: 0x007E40D4
		public IMechStuntLevelFlyT AsIMechStuntLevelFly()
		{
			return this.As<IMechStuntLevelFlyT>();
		}

		// Token: 0x0603ABD0 RID: 240592 RVA: 0x007E5EDC File Offset: 0x007E40DC
		public static TMechStuntConfigUnion FromIMechStuntLevelFly(IMechStuntLevelFlyT _imechstuntlevelfly)
		{
			return new TMechStuntConfigUnion
			{
				Type = TMechStuntConfig.IMechStuntLevelFly,
				Value = _imechstuntlevelfly
			};
		}

		// Token: 0x0603ABD1 RID: 240593 RVA: 0x007E5EF1 File Offset: 0x007E40F1
		public IMechStuntWaterT AsIMechStuntWater()
		{
			return this.As<IMechStuntWaterT>();
		}

		// Token: 0x0603ABD2 RID: 240594 RVA: 0x007E5EF9 File Offset: 0x007E40F9
		public static TMechStuntConfigUnion FromIMechStuntWater(IMechStuntWaterT _imechstuntwater)
		{
			return new TMechStuntConfigUnion
			{
				Type = TMechStuntConfig.IMechStuntWater,
				Value = _imechstuntwater
			};
		}

		// Token: 0x0603ABD3 RID: 240595 RVA: 0x007E5F10 File Offset: 0x007E4110
		public static int Pack(FlatBufferBuilder builder, TMechStuntConfigUnion _o)
		{
			switch (_o.Type)
			{
			case TMechStuntConfig.IMechStuntBurrow:
				return IMechStuntBurrow.Pack(builder, _o.AsIMechStuntBurrow()).Value;
			case TMechStuntConfig.IMechStuntClimbFly:
				return IMechStuntClimbFly.Pack(builder, _o.AsIMechStuntClimbFly()).Value;
			case TMechStuntConfig.IMechStuntDive:
				return IMechStuntDive.Pack(builder, _o.AsIMechStuntDive()).Value;
			case TMechStuntConfig.IMechStuntHighSpeed:
				return IMechStuntHighSpeed.Pack(builder, _o.AsIMechStuntHighSpeed()).Value;
			case TMechStuntConfig.IMechStuntLevelFly:
				return IMechStuntLevelFly.Pack(builder, _o.AsIMechStuntLevelFly()).Value;
			case TMechStuntConfig.IMechStuntWater:
				return IMechStuntWater.Pack(builder, _o.AsIMechStuntWater()).Value;
			default:
				return 0;
			}
		}
	}
}
