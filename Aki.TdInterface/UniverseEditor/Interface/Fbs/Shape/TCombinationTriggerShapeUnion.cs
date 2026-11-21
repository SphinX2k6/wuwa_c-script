using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02004089 RID: 16521
	public class TCombinationTriggerShapeUnion
	{
		// Token: 0x17007078 RID: 28792
		// (get) Token: 0x06016BFB RID: 93179 RVA: 0x0033FD45 File Offset: 0x0033DF45
		// (set) Token: 0x06016BFC RID: 93180 RVA: 0x0033FD4D File Offset: 0x0033DF4D
		public TCombinationTriggerShape Type { get; set; }

		// Token: 0x17007079 RID: 28793
		// (get) Token: 0x06016BFD RID: 93181 RVA: 0x0033FD56 File Offset: 0x0033DF56
		// (set) Token: 0x06016BFE RID: 93182 RVA: 0x0033FD5E File Offset: 0x0033DF5E
		public object Value { get; set; }

		// Token: 0x06016BFF RID: 93183 RVA: 0x0033FD67 File Offset: 0x0033DF67
		public TCombinationTriggerShapeUnion()
		{
			this.Type = TCombinationTriggerShape.NONE;
			this.Value = null;
		}

		// Token: 0x06016C00 RID: 93184 RVA: 0x0033FD7D File Offset: 0x0033DF7D
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06016C01 RID: 93185 RVA: 0x0033FD8F File Offset: 0x0033DF8F
		public IBoxTriggerShapeT AsIBoxTriggerShape()
		{
			return this.As<IBoxTriggerShapeT>();
		}

		// Token: 0x06016C02 RID: 93186 RVA: 0x0033FD97 File Offset: 0x0033DF97
		public static TCombinationTriggerShapeUnion FromIBoxTriggerShape(IBoxTriggerShapeT _iboxtriggershape)
		{
			return new TCombinationTriggerShapeUnion
			{
				Type = TCombinationTriggerShape.IBoxTriggerShape,
				Value = _iboxtriggershape
			};
		}

		// Token: 0x06016C03 RID: 93187 RVA: 0x0033FDAC File Offset: 0x0033DFAC
		public ISphereTriggerShapeT AsISphereTriggerShape()
		{
			return this.As<ISphereTriggerShapeT>();
		}

		// Token: 0x06016C04 RID: 93188 RVA: 0x0033FDB4 File Offset: 0x0033DFB4
		public static TCombinationTriggerShapeUnion FromISphereTriggerShape(ISphereTriggerShapeT _ispheretriggershape)
		{
			return new TCombinationTriggerShapeUnion
			{
				Type = TCombinationTriggerShape.ISphereTriggerShape,
				Value = _ispheretriggershape
			};
		}

		// Token: 0x06016C05 RID: 93189 RVA: 0x0033FDC9 File Offset: 0x0033DFC9
		public IHollowSphereTriggerShapeT AsIHollowSphereTriggerShape()
		{
			return this.As<IHollowSphereTriggerShapeT>();
		}

		// Token: 0x06016C06 RID: 93190 RVA: 0x0033FDD1 File Offset: 0x0033DFD1
		public static TCombinationTriggerShapeUnion FromIHollowSphereTriggerShape(IHollowSphereTriggerShapeT _ihollowspheretriggershape)
		{
			return new TCombinationTriggerShapeUnion
			{
				Type = TCombinationTriggerShape.IHollowSphereTriggerShape,
				Value = _ihollowspheretriggershape
			};
		}

		// Token: 0x06016C07 RID: 93191 RVA: 0x0033FDE6 File Offset: 0x0033DFE6
		public ICylinderTriggerShapeT AsICylinderTriggerShape()
		{
			return this.As<ICylinderTriggerShapeT>();
		}

		// Token: 0x06016C08 RID: 93192 RVA: 0x0033FDEE File Offset: 0x0033DFEE
		public static TCombinationTriggerShapeUnion FromICylinderTriggerShape(ICylinderTriggerShapeT _icylindertriggershape)
		{
			return new TCombinationTriggerShapeUnion
			{
				Type = TCombinationTriggerShape.ICylinderTriggerShape,
				Value = _icylindertriggershape
			};
		}

		// Token: 0x06016C09 RID: 93193 RVA: 0x0033FE03 File Offset: 0x0033E003
		public IHollowCylinderTriggerShapeT AsIHollowCylinderTriggerShape()
		{
			return this.As<IHollowCylinderTriggerShapeT>();
		}

		// Token: 0x06016C0A RID: 93194 RVA: 0x0033FE0B File Offset: 0x0033E00B
		public static TCombinationTriggerShapeUnion FromIHollowCylinderTriggerShape(IHollowCylinderTriggerShapeT _ihollowcylindertriggershape)
		{
			return new TCombinationTriggerShapeUnion
			{
				Type = TCombinationTriggerShape.IHollowCylinderTriggerShape,
				Value = _ihollowcylindertriggershape
			};
		}

		// Token: 0x06016C0B RID: 93195 RVA: 0x0033FE20 File Offset: 0x0033E020
		public IConeTriggerShapeT AsIConeTriggerShape()
		{
			return this.As<IConeTriggerShapeT>();
		}

		// Token: 0x06016C0C RID: 93196 RVA: 0x0033FE28 File Offset: 0x0033E028
		public static TCombinationTriggerShapeUnion FromIConeTriggerShape(IConeTriggerShapeT _iconetriggershape)
		{
			return new TCombinationTriggerShapeUnion
			{
				Type = TCombinationTriggerShape.IConeTriggerShape,
				Value = _iconetriggershape
			};
		}

		// Token: 0x06016C0D RID: 93197 RVA: 0x0033FE3D File Offset: 0x0033E03D
		public IVolumeTriggerShapeT AsIVolumeTriggerShape()
		{
			return this.As<IVolumeTriggerShapeT>();
		}

		// Token: 0x06016C0E RID: 93198 RVA: 0x0033FE45 File Offset: 0x0033E045
		public static TCombinationTriggerShapeUnion FromIVolumeTriggerShape(IVolumeTriggerShapeT _ivolumetriggershape)
		{
			return new TCombinationTriggerShapeUnion
			{
				Type = TCombinationTriggerShape.IVolumeTriggerShape,
				Value = _ivolumetriggershape
			};
		}

		// Token: 0x06016C0F RID: 93199 RVA: 0x0033FE5A File Offset: 0x0033E05A
		public IActorRefVolumeT AsIActorRefVolume()
		{
			return this.As<IActorRefVolumeT>();
		}

		// Token: 0x06016C10 RID: 93200 RVA: 0x0033FE62 File Offset: 0x0033E062
		public static TCombinationTriggerShapeUnion FromIActorRefVolume(IActorRefVolumeT _iactorrefvolume)
		{
			return new TCombinationTriggerShapeUnion
			{
				Type = TCombinationTriggerShape.IActorRefVolume,
				Value = _iactorrefvolume
			};
		}

		// Token: 0x06016C11 RID: 93201 RVA: 0x0033FE77 File Offset: 0x0033E077
		public IActorCollisionTriggerShapeT AsIActorCollisionTriggerShape()
		{
			return this.As<IActorCollisionTriggerShapeT>();
		}

		// Token: 0x06016C12 RID: 93202 RVA: 0x0033FE7F File Offset: 0x0033E07F
		public static TCombinationTriggerShapeUnion FromIActorCollisionTriggerShape(IActorCollisionTriggerShapeT _iactorcollisiontriggershape)
		{
			return new TCombinationTriggerShapeUnion
			{
				Type = TCombinationTriggerShape.IActorCollisionTriggerShape,
				Value = _iactorcollisiontriggershape
			};
		}

		// Token: 0x06016C13 RID: 93203 RVA: 0x0033FE95 File Offset: 0x0033E095
		public ICombinationTriggerShapeT AsICombinationTriggerShape()
		{
			return this.As<ICombinationTriggerShapeT>();
		}

		// Token: 0x06016C14 RID: 93204 RVA: 0x0033FE9D File Offset: 0x0033E09D
		public static TCombinationTriggerShapeUnion FromICombinationTriggerShape(ICombinationTriggerShapeT _icombinationtriggershape)
		{
			return new TCombinationTriggerShapeUnion
			{
				Type = TCombinationTriggerShape.ICombinationTriggerShape,
				Value = _icombinationtriggershape
			};
		}

		// Token: 0x06016C15 RID: 93205 RVA: 0x0033FEB3 File Offset: 0x0033E0B3
		public ISpotlightTriggerShapeT AsISpotlightTriggerShape()
		{
			return this.As<ISpotlightTriggerShapeT>();
		}

		// Token: 0x06016C16 RID: 93206 RVA: 0x0033FEBB File Offset: 0x0033E0BB
		public static TCombinationTriggerShapeUnion FromISpotlightTriggerShape(ISpotlightTriggerShapeT _ispotlighttriggershape)
		{
			return new TCombinationTriggerShapeUnion
			{
				Type = TCombinationTriggerShape.ISpotlightTriggerShape,
				Value = _ispotlighttriggershape
			};
		}

		// Token: 0x06016C17 RID: 93207 RVA: 0x0033FED4 File Offset: 0x0033E0D4
		public static int Pack(FlatBufferBuilder builder, TCombinationTriggerShapeUnion _o)
		{
			switch (_o.Type)
			{
			case TCombinationTriggerShape.IBoxTriggerShape:
				return IBoxTriggerShape.Pack(builder, _o.AsIBoxTriggerShape()).Value;
			case TCombinationTriggerShape.ISphereTriggerShape:
				return ISphereTriggerShape.Pack(builder, _o.AsISphereTriggerShape()).Value;
			case TCombinationTriggerShape.IHollowSphereTriggerShape:
				return IHollowSphereTriggerShape.Pack(builder, _o.AsIHollowSphereTriggerShape()).Value;
			case TCombinationTriggerShape.ICylinderTriggerShape:
				return ICylinderTriggerShape.Pack(builder, _o.AsICylinderTriggerShape()).Value;
			case TCombinationTriggerShape.IHollowCylinderTriggerShape:
				return IHollowCylinderTriggerShape.Pack(builder, _o.AsIHollowCylinderTriggerShape()).Value;
			case TCombinationTriggerShape.IConeTriggerShape:
				return IConeTriggerShape.Pack(builder, _o.AsIConeTriggerShape()).Value;
			case TCombinationTriggerShape.IVolumeTriggerShape:
				return IVolumeTriggerShape.Pack(builder, _o.AsIVolumeTriggerShape()).Value;
			case TCombinationTriggerShape.IActorRefVolume:
				return IActorRefVolume.Pack(builder, _o.AsIActorRefVolume()).Value;
			case TCombinationTriggerShape.IActorCollisionTriggerShape:
				return IActorCollisionTriggerShape.Pack(builder, _o.AsIActorCollisionTriggerShape()).Value;
			case TCombinationTriggerShape.ICombinationTriggerShape:
				return ICombinationTriggerShape.Pack(builder, _o.AsICombinationTriggerShape()).Value;
			case TCombinationTriggerShape.ISpotlightTriggerShape:
				return ISpotlightTriggerShape.Pack(builder, _o.AsISpotlightTriggerShape()).Value;
			default:
				return 0;
			}
		}
	}
}
