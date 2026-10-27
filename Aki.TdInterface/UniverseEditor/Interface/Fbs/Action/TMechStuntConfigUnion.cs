using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007711 RID: 30481
	public class TMechStuntConfigUnion
	{
		// Token: 0x1700E64F RID: 58959
		// (get) Token: 0x060376A4 RID: 226980 RVA: 0x0078115E File Offset: 0x0077F35E
		// (set) Token: 0x060376A5 RID: 226981 RVA: 0x00781166 File Offset: 0x0077F366
		public TMechStuntConfig Type { get; set; }

		// Token: 0x1700E650 RID: 58960
		// (get) Token: 0x060376A6 RID: 226982 RVA: 0x0078116F File Offset: 0x0077F36F
		// (set) Token: 0x060376A7 RID: 226983 RVA: 0x00781177 File Offset: 0x0077F377
		public object Value { get; set; }

		// Token: 0x060376A8 RID: 226984 RVA: 0x00781180 File Offset: 0x0077F380
		public TMechStuntConfigUnion()
		{
			this.Type = TMechStuntConfig.NONE;
			this.Value = null;
		}

		// Token: 0x060376A9 RID: 226985 RVA: 0x00781196 File Offset: 0x0077F396
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060376AA RID: 226986 RVA: 0x007811A8 File Offset: 0x0077F3A8
		public IMechStuntBurrowT AsIMechStuntBurrow()
		{
			return this.As<IMechStuntBurrowT>();
		}

		// Token: 0x060376AB RID: 226987 RVA: 0x007811B0 File Offset: 0x0077F3B0
		public static TMechStuntConfigUnion FromIMechStuntBurrow(IMechStuntBurrowT _imechstuntburrow)
		{
			return new TMechStuntConfigUnion
			{
				Type = TMechStuntConfig.IMechStuntBurrow,
				Value = _imechstuntburrow
			};
		}

		// Token: 0x060376AC RID: 226988 RVA: 0x007811C5 File Offset: 0x0077F3C5
		public IMechStuntClimbFlyT AsIMechStuntClimbFly()
		{
			return this.As<IMechStuntClimbFlyT>();
		}

		// Token: 0x060376AD RID: 226989 RVA: 0x007811CD File Offset: 0x0077F3CD
		public static TMechStuntConfigUnion FromIMechStuntClimbFly(IMechStuntClimbFlyT _imechstuntclimbfly)
		{
			return new TMechStuntConfigUnion
			{
				Type = TMechStuntConfig.IMechStuntClimbFly,
				Value = _imechstuntclimbfly
			};
		}

		// Token: 0x060376AE RID: 226990 RVA: 0x007811E2 File Offset: 0x0077F3E2
		public IMechStuntDiveT AsIMechStuntDive()
		{
			return this.As<IMechStuntDiveT>();
		}

		// Token: 0x060376AF RID: 226991 RVA: 0x007811EA File Offset: 0x0077F3EA
		public static TMechStuntConfigUnion FromIMechStuntDive(IMechStuntDiveT _imechstuntdive)
		{
			return new TMechStuntConfigUnion
			{
				Type = TMechStuntConfig.IMechStuntDive,
				Value = _imechstuntdive
			};
		}

		// Token: 0x060376B0 RID: 226992 RVA: 0x007811FF File Offset: 0x0077F3FF
		public IMechStuntHighSpeedT AsIMechStuntHighSpeed()
		{
			return this.As<IMechStuntHighSpeedT>();
		}

		// Token: 0x060376B1 RID: 226993 RVA: 0x00781207 File Offset: 0x0077F407
		public static TMechStuntConfigUnion FromIMechStuntHighSpeed(IMechStuntHighSpeedT _imechstunthighspeed)
		{
			return new TMechStuntConfigUnion
			{
				Type = TMechStuntConfig.IMechStuntHighSpeed,
				Value = _imechstunthighspeed
			};
		}

		// Token: 0x060376B2 RID: 226994 RVA: 0x0078121C File Offset: 0x0077F41C
		public IMechStuntLevelFlyT AsIMechStuntLevelFly()
		{
			return this.As<IMechStuntLevelFlyT>();
		}

		// Token: 0x060376B3 RID: 226995 RVA: 0x00781224 File Offset: 0x0077F424
		public static TMechStuntConfigUnion FromIMechStuntLevelFly(IMechStuntLevelFlyT _imechstuntlevelfly)
		{
			return new TMechStuntConfigUnion
			{
				Type = TMechStuntConfig.IMechStuntLevelFly,
				Value = _imechstuntlevelfly
			};
		}

		// Token: 0x060376B4 RID: 226996 RVA: 0x00781239 File Offset: 0x0077F439
		public IMechStuntWaterT AsIMechStuntWater()
		{
			return this.As<IMechStuntWaterT>();
		}

		// Token: 0x060376B5 RID: 226997 RVA: 0x00781241 File Offset: 0x0077F441
		public static TMechStuntConfigUnion FromIMechStuntWater(IMechStuntWaterT _imechstuntwater)
		{
			return new TMechStuntConfigUnion
			{
				Type = TMechStuntConfig.IMechStuntWater,
				Value = _imechstuntwater
			};
		}

		// Token: 0x060376B6 RID: 226998 RVA: 0x00781258 File Offset: 0x0077F458
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
