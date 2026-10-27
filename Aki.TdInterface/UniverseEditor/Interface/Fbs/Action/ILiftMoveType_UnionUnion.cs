using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A0F RID: 27151
	public class ILiftMoveType_UnionUnion
	{
		// Token: 0x1700C972 RID: 51570
		// (get) Token: 0x0602F82B RID: 194603 RVA: 0x0067826C File Offset: 0x0067646C
		// (set) Token: 0x0602F82C RID: 194604 RVA: 0x00678274 File Offset: 0x00676474
		public ILiftMoveType_Union Type { get; set; }

		// Token: 0x1700C973 RID: 51571
		// (get) Token: 0x0602F82D RID: 194605 RVA: 0x0067827D File Offset: 0x0067647D
		// (set) Token: 0x0602F82E RID: 194606 RVA: 0x00678285 File Offset: 0x00676485
		public object Value { get; set; }

		// Token: 0x0602F82F RID: 194607 RVA: 0x0067828E File Offset: 0x0067648E
		public ILiftMoveType_UnionUnion()
		{
			this.Type = ILiftMoveType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602F830 RID: 194608 RVA: 0x006782A4 File Offset: 0x006764A4
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602F831 RID: 194609 RVA: 0x006782B6 File Offset: 0x006764B6
		public ILiftMoveTypeT AsILiftMoveType()
		{
			return this.As<ILiftMoveTypeT>();
		}

		// Token: 0x0602F832 RID: 194610 RVA: 0x006782BE File Offset: 0x006764BE
		public static ILiftMoveType_UnionUnion FromILiftMoveType(ILiftMoveTypeT _iliftmovetype)
		{
			return new ILiftMoveType_UnionUnion
			{
				Type = ILiftMoveType_Union.ILiftMoveType,
				Value = _iliftmovetype
			};
		}

		// Token: 0x0602F833 RID: 194611 RVA: 0x006782D3 File Offset: 0x006764D3
		public ILiftMoveTypeDefaultT AsILiftMoveTypeDefault()
		{
			return this.As<ILiftMoveTypeDefaultT>();
		}

		// Token: 0x0602F834 RID: 194612 RVA: 0x006782DB File Offset: 0x006764DB
		public static ILiftMoveType_UnionUnion FromILiftMoveTypeDefault(ILiftMoveTypeDefaultT _iliftmovetypedefault)
		{
			return new ILiftMoveType_UnionUnion
			{
				Type = ILiftMoveType_Union.ILiftMoveTypeDefault,
				Value = _iliftmovetypedefault
			};
		}

		// Token: 0x0602F835 RID: 194613 RVA: 0x006782F0 File Offset: 0x006764F0
		public ILiftMoveTypeTeleportT AsILiftMoveTypeTeleport()
		{
			return this.As<ILiftMoveTypeTeleportT>();
		}

		// Token: 0x0602F836 RID: 194614 RVA: 0x006782F8 File Offset: 0x006764F8
		public static ILiftMoveType_UnionUnion FromILiftMoveTypeTeleport(ILiftMoveTypeTeleportT _iliftmovetypeteleport)
		{
			return new ILiftMoveType_UnionUnion
			{
				Type = ILiftMoveType_Union.ILiftMoveTypeTeleport,
				Value = _iliftmovetypeteleport
			};
		}

		// Token: 0x0602F837 RID: 194615 RVA: 0x0067830D File Offset: 0x0067650D
		public ILiftMoveTypeCustomSpeedT AsILiftMoveTypeCustomSpeed()
		{
			return this.As<ILiftMoveTypeCustomSpeedT>();
		}

		// Token: 0x0602F838 RID: 194616 RVA: 0x00678315 File Offset: 0x00676515
		public static ILiftMoveType_UnionUnion FromILiftMoveTypeCustomSpeed(ILiftMoveTypeCustomSpeedT _iliftmovetypecustomspeed)
		{
			return new ILiftMoveType_UnionUnion
			{
				Type = ILiftMoveType_Union.ILiftMoveTypeCustomSpeed,
				Value = _iliftmovetypecustomspeed
			};
		}

		// Token: 0x0602F839 RID: 194617 RVA: 0x0067832A File Offset: 0x0067652A
		public ILiftMoveTypeCircularT AsILiftMoveTypeCircular()
		{
			return this.As<ILiftMoveTypeCircularT>();
		}

		// Token: 0x0602F83A RID: 194618 RVA: 0x00678332 File Offset: 0x00676532
		public static ILiftMoveType_UnionUnion FromILiftMoveTypeCircular(ILiftMoveTypeCircularT _iliftmovetypecircular)
		{
			return new ILiftMoveType_UnionUnion
			{
				Type = ILiftMoveType_Union.ILiftMoveTypeCircular,
				Value = _iliftmovetypecircular
			};
		}

		// Token: 0x0602F83B RID: 194619 RVA: 0x00678348 File Offset: 0x00676548
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
