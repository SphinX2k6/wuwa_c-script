using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02004098 RID: 16536
	public class TTriggerShapeUnion
	{
		// Token: 0x17007082 RID: 28802
		// (get) Token: 0x06016C6D RID: 93293 RVA: 0x0034095A File Offset: 0x0033EB5A
		// (set) Token: 0x06016C6E RID: 93294 RVA: 0x00340962 File Offset: 0x0033EB62
		public TTriggerShape Type { get; set; }

		// Token: 0x17007083 RID: 28803
		// (get) Token: 0x06016C6F RID: 93295 RVA: 0x0034096B File Offset: 0x0033EB6B
		// (set) Token: 0x06016C70 RID: 93296 RVA: 0x00340973 File Offset: 0x0033EB73
		public object Value { get; set; }

		// Token: 0x06016C71 RID: 93297 RVA: 0x0034097C File Offset: 0x0033EB7C
		public TTriggerShapeUnion()
		{
			this.Type = TTriggerShape.NONE;
			this.Value = null;
		}

		// Token: 0x06016C72 RID: 93298 RVA: 0x00340992 File Offset: 0x0033EB92
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06016C73 RID: 93299 RVA: 0x003409A4 File Offset: 0x0033EBA4
		public IActorCollisionTriggerShapeT AsIActorCollisionTriggerShape()
		{
			return this.As<IActorCollisionTriggerShapeT>();
		}

		// Token: 0x06016C74 RID: 93300 RVA: 0x003409AC File Offset: 0x0033EBAC
		public static TTriggerShapeUnion FromIActorCollisionTriggerShape(IActorCollisionTriggerShapeT _iactorcollisiontriggershape)
		{
			return new TTriggerShapeUnion
			{
				Type = TTriggerShape.IActorCollisionTriggerShape,
				Value = _iactorcollisiontriggershape
			};
		}

		// Token: 0x06016C75 RID: 93301 RVA: 0x003409C1 File Offset: 0x0033EBC1
		public IActorRefVolumeT AsIActorRefVolume()
		{
			return this.As<IActorRefVolumeT>();
		}

		// Token: 0x06016C76 RID: 93302 RVA: 0x003409C9 File Offset: 0x0033EBC9
		public static TTriggerShapeUnion FromIActorRefVolume(IActorRefVolumeT _iactorrefvolume)
		{
			return new TTriggerShapeUnion
			{
				Type = TTriggerShape.IActorRefVolume,
				Value = _iactorrefvolume
			};
		}

		// Token: 0x06016C77 RID: 93303 RVA: 0x003409DE File Offset: 0x0033EBDE
		public IBoxTriggerShapeT AsIBoxTriggerShape()
		{
			return this.As<IBoxTriggerShapeT>();
		}

		// Token: 0x06016C78 RID: 93304 RVA: 0x003409E6 File Offset: 0x0033EBE6
		public static TTriggerShapeUnion FromIBoxTriggerShape(IBoxTriggerShapeT _iboxtriggershape)
		{
			return new TTriggerShapeUnion
			{
				Type = TTriggerShape.IBoxTriggerShape,
				Value = _iboxtriggershape
			};
		}

		// Token: 0x06016C79 RID: 93305 RVA: 0x003409FB File Offset: 0x0033EBFB
		public ICombinationTriggerShapeT AsICombinationTriggerShape()
		{
			return this.As<ICombinationTriggerShapeT>();
		}

		// Token: 0x06016C7A RID: 93306 RVA: 0x00340A03 File Offset: 0x0033EC03
		public static TTriggerShapeUnion FromICombinationTriggerShape(ICombinationTriggerShapeT _icombinationtriggershape)
		{
			return new TTriggerShapeUnion
			{
				Type = TTriggerShape.ICombinationTriggerShape,
				Value = _icombinationtriggershape
			};
		}

		// Token: 0x06016C7B RID: 93307 RVA: 0x00340A18 File Offset: 0x0033EC18
		public IConeTriggerShapeT AsIConeTriggerShape()
		{
			return this.As<IConeTriggerShapeT>();
		}

		// Token: 0x06016C7C RID: 93308 RVA: 0x00340A20 File Offset: 0x0033EC20
		public static TTriggerShapeUnion FromIConeTriggerShape(IConeTriggerShapeT _iconetriggershape)
		{
			return new TTriggerShapeUnion
			{
				Type = TTriggerShape.IConeTriggerShape,
				Value = _iconetriggershape
			};
		}

		// Token: 0x06016C7D RID: 93309 RVA: 0x00340A35 File Offset: 0x0033EC35
		public ICylinderTriggerShapeT AsICylinderTriggerShape()
		{
			return this.As<ICylinderTriggerShapeT>();
		}

		// Token: 0x06016C7E RID: 93310 RVA: 0x00340A3D File Offset: 0x0033EC3D
		public static TTriggerShapeUnion FromICylinderTriggerShape(ICylinderTriggerShapeT _icylindertriggershape)
		{
			return new TTriggerShapeUnion
			{
				Type = TTriggerShape.ICylinderTriggerShape,
				Value = _icylindertriggershape
			};
		}

		// Token: 0x06016C7F RID: 93311 RVA: 0x00340A52 File Offset: 0x0033EC52
		public IHollowCylinderTriggerShapeT AsIHollowCylinderTriggerShape()
		{
			return this.As<IHollowCylinderTriggerShapeT>();
		}

		// Token: 0x06016C80 RID: 93312 RVA: 0x00340A5A File Offset: 0x0033EC5A
		public static TTriggerShapeUnion FromIHollowCylinderTriggerShape(IHollowCylinderTriggerShapeT _ihollowcylindertriggershape)
		{
			return new TTriggerShapeUnion
			{
				Type = TTriggerShape.IHollowCylinderTriggerShape,
				Value = _ihollowcylindertriggershape
			};
		}

		// Token: 0x06016C81 RID: 93313 RVA: 0x00340A6F File Offset: 0x0033EC6F
		public IHollowSphereTriggerShapeT AsIHollowSphereTriggerShape()
		{
			return this.As<IHollowSphereTriggerShapeT>();
		}

		// Token: 0x06016C82 RID: 93314 RVA: 0x00340A77 File Offset: 0x0033EC77
		public static TTriggerShapeUnion FromIHollowSphereTriggerShape(IHollowSphereTriggerShapeT _ihollowspheretriggershape)
		{
			return new TTriggerShapeUnion
			{
				Type = TTriggerShape.IHollowSphereTriggerShape,
				Value = _ihollowspheretriggershape
			};
		}

		// Token: 0x06016C83 RID: 93315 RVA: 0x00340A8C File Offset: 0x0033EC8C
		public ISphereTriggerShapeT AsISphereTriggerShape()
		{
			return this.As<ISphereTriggerShapeT>();
		}

		// Token: 0x06016C84 RID: 93316 RVA: 0x00340A94 File Offset: 0x0033EC94
		public static TTriggerShapeUnion FromISphereTriggerShape(ISphereTriggerShapeT _ispheretriggershape)
		{
			return new TTriggerShapeUnion
			{
				Type = TTriggerShape.ISphereTriggerShape,
				Value = _ispheretriggershape
			};
		}

		// Token: 0x06016C85 RID: 93317 RVA: 0x00340AAA File Offset: 0x0033ECAA
		public ISpotlightTriggerShapeT AsISpotlightTriggerShape()
		{
			return this.As<ISpotlightTriggerShapeT>();
		}

		// Token: 0x06016C86 RID: 93318 RVA: 0x00340AB2 File Offset: 0x0033ECB2
		public static TTriggerShapeUnion FromISpotlightTriggerShape(ISpotlightTriggerShapeT _ispotlighttriggershape)
		{
			return new TTriggerShapeUnion
			{
				Type = TTriggerShape.ISpotlightTriggerShape,
				Value = _ispotlighttriggershape
			};
		}

		// Token: 0x06016C87 RID: 93319 RVA: 0x00340AC8 File Offset: 0x0033ECC8
		public IVolumeTriggerShapeT AsIVolumeTriggerShape()
		{
			return this.As<IVolumeTriggerShapeT>();
		}

		// Token: 0x06016C88 RID: 93320 RVA: 0x00340AD0 File Offset: 0x0033ECD0
		public static TTriggerShapeUnion FromIVolumeTriggerShape(IVolumeTriggerShapeT _ivolumetriggershape)
		{
			return new TTriggerShapeUnion
			{
				Type = TTriggerShape.IVolumeTriggerShape,
				Value = _ivolumetriggershape
			};
		}

		// Token: 0x06016C89 RID: 93321 RVA: 0x00340AE8 File Offset: 0x0033ECE8
		public static int Pack(FlatBufferBuilder builder, TTriggerShapeUnion _o)
		{
			switch (_o.Type)
			{
			case TTriggerShape.IActorCollisionTriggerShape:
				return IActorCollisionTriggerShape.Pack(builder, _o.AsIActorCollisionTriggerShape()).Value;
			case TTriggerShape.IActorRefVolume:
				return IActorRefVolume.Pack(builder, _o.AsIActorRefVolume()).Value;
			case TTriggerShape.IBoxTriggerShape:
				return IBoxTriggerShape.Pack(builder, _o.AsIBoxTriggerShape()).Value;
			case TTriggerShape.ICombinationTriggerShape:
				return ICombinationTriggerShape.Pack(builder, _o.AsICombinationTriggerShape()).Value;
			case TTriggerShape.IConeTriggerShape:
				return IConeTriggerShape.Pack(builder, _o.AsIConeTriggerShape()).Value;
			case TTriggerShape.ICylinderTriggerShape:
				return ICylinderTriggerShape.Pack(builder, _o.AsICylinderTriggerShape()).Value;
			case TTriggerShape.IHollowCylinderTriggerShape:
				return IHollowCylinderTriggerShape.Pack(builder, _o.AsIHollowCylinderTriggerShape()).Value;
			case TTriggerShape.IHollowSphereTriggerShape:
				return IHollowSphereTriggerShape.Pack(builder, _o.AsIHollowSphereTriggerShape()).Value;
			case TTriggerShape.ISphereTriggerShape:
				return ISphereTriggerShape.Pack(builder, _o.AsISphereTriggerShape()).Value;
			case TTriggerShape.ISpotlightTriggerShape:
				return ISpotlightTriggerShape.Pack(builder, _o.AsISpotlightTriggerShape()).Value;
			case TTriggerShape.IVolumeTriggerShape:
				return IVolumeTriggerShape.Pack(builder, _o.AsIVolumeTriggerShape()).Value;
			default:
				return 0;
			}
		}
	}
}
