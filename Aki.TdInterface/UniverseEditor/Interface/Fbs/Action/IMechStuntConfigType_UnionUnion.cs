using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020071B7 RID: 29111
	public class IMechStuntConfigType_UnionUnion
	{
		// Token: 0x1700D537 RID: 54583
		// (get) Token: 0x06032A2C RID: 207404 RVA: 0x006D78A5 File Offset: 0x006D5AA5
		// (set) Token: 0x06032A2D RID: 207405 RVA: 0x006D78AD File Offset: 0x006D5AAD
		public IMechStuntConfigType_Union Type { get; set; }

		// Token: 0x1700D538 RID: 54584
		// (get) Token: 0x06032A2E RID: 207406 RVA: 0x006D78B6 File Offset: 0x006D5AB6
		// (set) Token: 0x06032A2F RID: 207407 RVA: 0x006D78BE File Offset: 0x006D5ABE
		public object Value { get; set; }

		// Token: 0x06032A30 RID: 207408 RVA: 0x006D78C7 File Offset: 0x006D5AC7
		public IMechStuntConfigType_UnionUnion()
		{
			this.Type = IMechStuntConfigType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06032A31 RID: 207409 RVA: 0x006D78DD File Offset: 0x006D5ADD
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06032A32 RID: 207410 RVA: 0x006D78EF File Offset: 0x006D5AEF
		public IMechStuntConfigTypeT AsIMechStuntConfigType()
		{
			return this.As<IMechStuntConfigTypeT>();
		}

		// Token: 0x06032A33 RID: 207411 RVA: 0x006D78F7 File Offset: 0x006D5AF7
		public static IMechStuntConfigType_UnionUnion FromIMechStuntConfigType(IMechStuntConfigTypeT _imechstuntconfigtype)
		{
			return new IMechStuntConfigType_UnionUnion
			{
				Type = IMechStuntConfigType_Union.IMechStuntConfigType,
				Value = _imechstuntconfigtype
			};
		}

		// Token: 0x06032A34 RID: 207412 RVA: 0x006D790C File Offset: 0x006D5B0C
		public IMechStuntDiveT AsIMechStuntDive()
		{
			return this.As<IMechStuntDiveT>();
		}

		// Token: 0x06032A35 RID: 207413 RVA: 0x006D7914 File Offset: 0x006D5B14
		public static IMechStuntConfigType_UnionUnion FromIMechStuntDive(IMechStuntDiveT _imechstuntdive)
		{
			return new IMechStuntConfigType_UnionUnion
			{
				Type = IMechStuntConfigType_Union.IMechStuntDive,
				Value = _imechstuntdive
			};
		}

		// Token: 0x06032A36 RID: 207414 RVA: 0x006D7929 File Offset: 0x006D5B29
		public IMechStuntClimbFlyT AsIMechStuntClimbFly()
		{
			return this.As<IMechStuntClimbFlyT>();
		}

		// Token: 0x06032A37 RID: 207415 RVA: 0x006D7931 File Offset: 0x006D5B31
		public static IMechStuntConfigType_UnionUnion FromIMechStuntClimbFly(IMechStuntClimbFlyT _imechstuntclimbfly)
		{
			return new IMechStuntConfigType_UnionUnion
			{
				Type = IMechStuntConfigType_Union.IMechStuntClimbFly,
				Value = _imechstuntclimbfly
			};
		}

		// Token: 0x06032A38 RID: 207416 RVA: 0x006D7946 File Offset: 0x006D5B46
		public IMechStuntLevelFlyT AsIMechStuntLevelFly()
		{
			return this.As<IMechStuntLevelFlyT>();
		}

		// Token: 0x06032A39 RID: 207417 RVA: 0x006D794E File Offset: 0x006D5B4E
		public static IMechStuntConfigType_UnionUnion FromIMechStuntLevelFly(IMechStuntLevelFlyT _imechstuntlevelfly)
		{
			return new IMechStuntConfigType_UnionUnion
			{
				Type = IMechStuntConfigType_Union.IMechStuntLevelFly,
				Value = _imechstuntlevelfly
			};
		}

		// Token: 0x06032A3A RID: 207418 RVA: 0x006D7963 File Offset: 0x006D5B63
		public IMechStuntHighSpeedT AsIMechStuntHighSpeed()
		{
			return this.As<IMechStuntHighSpeedT>();
		}

		// Token: 0x06032A3B RID: 207419 RVA: 0x006D796B File Offset: 0x006D5B6B
		public static IMechStuntConfigType_UnionUnion FromIMechStuntHighSpeed(IMechStuntHighSpeedT _imechstunthighspeed)
		{
			return new IMechStuntConfigType_UnionUnion
			{
				Type = IMechStuntConfigType_Union.IMechStuntHighSpeed,
				Value = _imechstunthighspeed
			};
		}

		// Token: 0x06032A3C RID: 207420 RVA: 0x006D7980 File Offset: 0x006D5B80
		public IMechStuntWaterT AsIMechStuntWater()
		{
			return this.As<IMechStuntWaterT>();
		}

		// Token: 0x06032A3D RID: 207421 RVA: 0x006D7988 File Offset: 0x006D5B88
		public static IMechStuntConfigType_UnionUnion FromIMechStuntWater(IMechStuntWaterT _imechstuntwater)
		{
			return new IMechStuntConfigType_UnionUnion
			{
				Type = IMechStuntConfigType_Union.IMechStuntWater,
				Value = _imechstuntwater
			};
		}

		// Token: 0x06032A3E RID: 207422 RVA: 0x006D799D File Offset: 0x006D5B9D
		public IMechStuntBurrowT AsIMechStuntBurrow()
		{
			return this.As<IMechStuntBurrowT>();
		}

		// Token: 0x06032A3F RID: 207423 RVA: 0x006D79A5 File Offset: 0x006D5BA5
		public static IMechStuntConfigType_UnionUnion FromIMechStuntBurrow(IMechStuntBurrowT _imechstuntburrow)
		{
			return new IMechStuntConfigType_UnionUnion
			{
				Type = IMechStuntConfigType_Union.IMechStuntBurrow,
				Value = _imechstuntburrow
			};
		}

		// Token: 0x06032A40 RID: 207424 RVA: 0x006D79BC File Offset: 0x006D5BBC
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
