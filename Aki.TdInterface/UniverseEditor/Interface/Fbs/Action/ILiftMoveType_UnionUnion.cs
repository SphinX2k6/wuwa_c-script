using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020070BF RID: 28863
	public class ILiftMoveType_UnionUnion
	{
		// Token: 0x1700D372 RID: 54130
		// (get) Token: 0x060321EB RID: 205291 RVA: 0x006C85C4 File Offset: 0x006C67C4
		// (set) Token: 0x060321EC RID: 205292 RVA: 0x006C85CC File Offset: 0x006C67CC
		public ILiftMoveType_Union Type { get; set; }

		// Token: 0x1700D373 RID: 54131
		// (get) Token: 0x060321ED RID: 205293 RVA: 0x006C85D5 File Offset: 0x006C67D5
		// (set) Token: 0x060321EE RID: 205294 RVA: 0x006C85DD File Offset: 0x006C67DD
		public object Value { get; set; }

		// Token: 0x060321EF RID: 205295 RVA: 0x006C85E6 File Offset: 0x006C67E6
		public ILiftMoveType_UnionUnion()
		{
			this.Type = ILiftMoveType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060321F0 RID: 205296 RVA: 0x006C85FC File Offset: 0x006C67FC
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060321F1 RID: 205297 RVA: 0x006C860E File Offset: 0x006C680E
		public ILiftMoveTypeT AsILiftMoveType()
		{
			return this.As<ILiftMoveTypeT>();
		}

		// Token: 0x060321F2 RID: 205298 RVA: 0x006C8616 File Offset: 0x006C6816
		public static ILiftMoveType_UnionUnion FromILiftMoveType(ILiftMoveTypeT _iliftmovetype)
		{
			return new ILiftMoveType_UnionUnion
			{
				Type = ILiftMoveType_Union.ILiftMoveType,
				Value = _iliftmovetype
			};
		}

		// Token: 0x060321F3 RID: 205299 RVA: 0x006C862B File Offset: 0x006C682B
		public ILiftMoveTypeDefaultT AsILiftMoveTypeDefault()
		{
			return this.As<ILiftMoveTypeDefaultT>();
		}

		// Token: 0x060321F4 RID: 205300 RVA: 0x006C8633 File Offset: 0x006C6833
		public static ILiftMoveType_UnionUnion FromILiftMoveTypeDefault(ILiftMoveTypeDefaultT _iliftmovetypedefault)
		{
			return new ILiftMoveType_UnionUnion
			{
				Type = ILiftMoveType_Union.ILiftMoveTypeDefault,
				Value = _iliftmovetypedefault
			};
		}

		// Token: 0x060321F5 RID: 205301 RVA: 0x006C8648 File Offset: 0x006C6848
		public ILiftMoveTypeTeleportT AsILiftMoveTypeTeleport()
		{
			return this.As<ILiftMoveTypeTeleportT>();
		}

		// Token: 0x060321F6 RID: 205302 RVA: 0x006C8650 File Offset: 0x006C6850
		public static ILiftMoveType_UnionUnion FromILiftMoveTypeTeleport(ILiftMoveTypeTeleportT _iliftmovetypeteleport)
		{
			return new ILiftMoveType_UnionUnion
			{
				Type = ILiftMoveType_Union.ILiftMoveTypeTeleport,
				Value = _iliftmovetypeteleport
			};
		}

		// Token: 0x060321F7 RID: 205303 RVA: 0x006C8665 File Offset: 0x006C6865
		public ILiftMoveTypeCustomSpeedT AsILiftMoveTypeCustomSpeed()
		{
			return this.As<ILiftMoveTypeCustomSpeedT>();
		}

		// Token: 0x060321F8 RID: 205304 RVA: 0x006C866D File Offset: 0x006C686D
		public static ILiftMoveType_UnionUnion FromILiftMoveTypeCustomSpeed(ILiftMoveTypeCustomSpeedT _iliftmovetypecustomspeed)
		{
			return new ILiftMoveType_UnionUnion
			{
				Type = ILiftMoveType_Union.ILiftMoveTypeCustomSpeed,
				Value = _iliftmovetypecustomspeed
			};
		}

		// Token: 0x060321F9 RID: 205305 RVA: 0x006C8682 File Offset: 0x006C6882
		public ILiftMoveTypeCircularT AsILiftMoveTypeCircular()
		{
			return this.As<ILiftMoveTypeCircularT>();
		}

		// Token: 0x060321FA RID: 205306 RVA: 0x006C868A File Offset: 0x006C688A
		public static ILiftMoveType_UnionUnion FromILiftMoveTypeCircular(ILiftMoveTypeCircularT _iliftmovetypecircular)
		{
			return new ILiftMoveType_UnionUnion
			{
				Type = ILiftMoveType_Union.ILiftMoveTypeCircular,
				Value = _iliftmovetypecircular
			};
		}

		// Token: 0x060321FB RID: 205307 RVA: 0x006C86A0 File Offset: 0x006C68A0
		public static int Pack(FlatBufferBuilder builder, ILiftMoveType_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case ILiftMoveType_Union.ILiftMoveType:
				return ILiftMoveType.Pack(builder, _o.AsILiftMoveType()).Value;
			case ILiftMoveType_Union.ILiftMoveTypeDefault:
				return ILiftMoveTypeDefault.Pack(builder, _o.AsILiftMoveTypeDefault()).Value;
			case ILiftMoveType_Union.ILiftMoveTypeTeleport:
				return ILiftMoveTypeTeleport.Pack(builder, _o.AsILiftMoveTypeTeleport()).Value;
			case ILiftMoveType_Union.ILiftMoveTypeCustomSpeed:
				return ILiftMoveTypeCustomSpeed.Pack(builder, _o.AsILiftMoveTypeCustomSpeed()).Value;
			case ILiftMoveType_Union.ILiftMoveTypeCircular:
				return ILiftMoveTypeCircular.Pack(builder, _o.AsILiftMoveTypeCircular()).Value;
			default:
				return 0;
			}
		}
	}
}
