using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007F1C RID: 32540
	public class TLiftMoveTypeUnion
	{
		// Token: 0x1700F28B RID: 62091
		// (get) Token: 0x0603AB3B RID: 240443 RVA: 0x007E5102 File Offset: 0x007E3302
		// (set) Token: 0x0603AB3C RID: 240444 RVA: 0x007E510A File Offset: 0x007E330A
		public TLiftMoveType Type { get; set; }

		// Token: 0x1700F28C RID: 62092
		// (get) Token: 0x0603AB3D RID: 240445 RVA: 0x007E5113 File Offset: 0x007E3313
		// (set) Token: 0x0603AB3E RID: 240446 RVA: 0x007E511B File Offset: 0x007E331B
		public object Value { get; set; }

		// Token: 0x0603AB3F RID: 240447 RVA: 0x007E5124 File Offset: 0x007E3324
		public TLiftMoveTypeUnion()
		{
			this.Type = TLiftMoveType.NONE;
			this.Value = null;
		}

		// Token: 0x0603AB40 RID: 240448 RVA: 0x007E513A File Offset: 0x007E333A
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603AB41 RID: 240449 RVA: 0x007E514C File Offset: 0x007E334C
		public ILiftMoveTypeCircularT AsILiftMoveTypeCircular()
		{
			return this.As<ILiftMoveTypeCircularT>();
		}

		// Token: 0x0603AB42 RID: 240450 RVA: 0x007E5154 File Offset: 0x007E3354
		public static TLiftMoveTypeUnion FromILiftMoveTypeCircular(ILiftMoveTypeCircularT _iliftmovetypecircular)
		{
			return new TLiftMoveTypeUnion
			{
				Type = TLiftMoveType.ILiftMoveTypeCircular,
				Value = _iliftmovetypecircular
			};
		}

		// Token: 0x0603AB43 RID: 240451 RVA: 0x007E5169 File Offset: 0x007E3369
		public ILiftMoveTypeCustomSpeedT AsILiftMoveTypeCustomSpeed()
		{
			return this.As<ILiftMoveTypeCustomSpeedT>();
		}

		// Token: 0x0603AB44 RID: 240452 RVA: 0x007E5171 File Offset: 0x007E3371
		public static TLiftMoveTypeUnion FromILiftMoveTypeCustomSpeed(ILiftMoveTypeCustomSpeedT _iliftmovetypecustomspeed)
		{
			return new TLiftMoveTypeUnion
			{
				Type = TLiftMoveType.ILiftMoveTypeCustomSpeed,
				Value = _iliftmovetypecustomspeed
			};
		}

		// Token: 0x0603AB45 RID: 240453 RVA: 0x007E5186 File Offset: 0x007E3386
		public ILiftMoveTypeDefaultT AsILiftMoveTypeDefault()
		{
			return this.As<ILiftMoveTypeDefaultT>();
		}

		// Token: 0x0603AB46 RID: 240454 RVA: 0x007E518E File Offset: 0x007E338E
		public static TLiftMoveTypeUnion FromILiftMoveTypeDefault(ILiftMoveTypeDefaultT _iliftmovetypedefault)
		{
			return new TLiftMoveTypeUnion
			{
				Type = TLiftMoveType.ILiftMoveTypeDefault,
				Value = _iliftmovetypedefault
			};
		}

		// Token: 0x0603AB47 RID: 240455 RVA: 0x007E51A3 File Offset: 0x007E33A3
		public ILiftMoveTypeTeleportT AsILiftMoveTypeTeleport()
		{
			return this.As<ILiftMoveTypeTeleportT>();
		}

		// Token: 0x0603AB48 RID: 240456 RVA: 0x007E51AB File Offset: 0x007E33AB
		public static TLiftMoveTypeUnion FromILiftMoveTypeTeleport(ILiftMoveTypeTeleportT _iliftmovetypeteleport)
		{
			return new TLiftMoveTypeUnion
			{
				Type = TLiftMoveType.ILiftMoveTypeTeleport,
				Value = _iliftmovetypeteleport
			};
		}

		// Token: 0x0603AB49 RID: 240457 RVA: 0x007E51C0 File Offset: 0x007E33C0
		public static int Pack(FlatBufferBuilder builder, TLiftMoveTypeUnion _o)
		{
			switch (_o.Type)
			{
			case TLiftMoveType.ILiftMoveTypeCircular:
				return ILiftMoveTypeCircular.Pack(builder, _o.AsILiftMoveTypeCircular()).Value;
			case TLiftMoveType.ILiftMoveTypeCustomSpeed:
				return ILiftMoveTypeCustomSpeed.Pack(builder, _o.AsILiftMoveTypeCustomSpeed()).Value;
			case TLiftMoveType.ILiftMoveTypeDefault:
				return ILiftMoveTypeDefault.Pack(builder, _o.AsILiftMoveTypeDefault()).Value;
			case TLiftMoveType.ILiftMoveTypeTeleport:
				return ILiftMoveTypeTeleport.Pack(builder, _o.AsILiftMoveTypeTeleport()).Value;
			default:
				return 0;
			}
		}
	}
}
