using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x0200407A RID: 16506
	public class ITriggerShape_UnionUnion
	{
		// Token: 0x17007063 RID: 28771
		// (get) Token: 0x06016B83 RID: 93059 RVA: 0x0033F16D File Offset: 0x0033D36D
		// (set) Token: 0x06016B84 RID: 93060 RVA: 0x0033F175 File Offset: 0x0033D375
		public ITriggerShape_Union Type { get; set; }

		// Token: 0x17007064 RID: 28772
		// (get) Token: 0x06016B85 RID: 93061 RVA: 0x0033F17E File Offset: 0x0033D37E
		// (set) Token: 0x06016B86 RID: 93062 RVA: 0x0033F186 File Offset: 0x0033D386
		public object Value { get; set; }

		// Token: 0x06016B87 RID: 93063 RVA: 0x0033F18F File Offset: 0x0033D38F
		public ITriggerShape_UnionUnion()
		{
			this.Type = ITriggerShape_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06016B88 RID: 93064 RVA: 0x0033F1A5 File Offset: 0x0033D3A5
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06016B89 RID: 93065 RVA: 0x0033F1B7 File Offset: 0x0033D3B7
		public ITriggerShapeT AsITriggerShape()
		{
			return this.As<ITriggerShapeT>();
		}

		// Token: 0x06016B8A RID: 93066 RVA: 0x0033F1BF File Offset: 0x0033D3BF
		public static ITriggerShape_UnionUnion FromITriggerShape(ITriggerShapeT _itriggershape)
		{
			return new ITriggerShape_UnionUnion
			{
				Type = ITriggerShape_Union.ITriggerShape,
				Value = _itriggershape
			};
		}

		// Token: 0x06016B8B RID: 93067 RVA: 0x0033F1D4 File Offset: 0x0033D3D4
		public IBoxTriggerShapeT AsIBoxTriggerShape()
		{
			return this.As<IBoxTriggerShapeT>();
		}

		// Token: 0x06016B8C RID: 93068 RVA: 0x0033F1DC File Offset: 0x0033D3DC
		public static ITriggerShape_UnionUnion FromIBoxTriggerShape(IBoxTriggerShapeT _iboxtriggershape)
		{
			return new ITriggerShape_UnionUnion
			{
				Type = ITriggerShape_Union.IBoxTriggerShape,
				Value = _iboxtriggershape
			};
		}

		// Token: 0x06016B8D RID: 93069 RVA: 0x0033F1F1 File Offset: 0x0033D3F1
		public ISphereTriggerShapeT AsISphereTriggerShape()
		{
			return this.As<ISphereTriggerShapeT>();
		}

		// Token: 0x06016B8E RID: 93070 RVA: 0x0033F1F9 File Offset: 0x0033D3F9
		public static ITriggerShape_UnionUnion FromISphereTriggerShape(ISphereTriggerShapeT _ispheretriggershape)
		{
			return new ITriggerShape_UnionUnion
			{
				Type = ITriggerShape_Union.ISphereTriggerShape,
				Value = _ispheretriggershape
			};
		}

		// Token: 0x06016B8F RID: 93071 RVA: 0x0033F20E File Offset: 0x0033D40E
		public IHollowSphereTriggerShapeT AsIHollowSphereTriggerShape()
		{
			return this.As<IHollowSphereTriggerShapeT>();
		}

		// Token: 0x06016B90 RID: 93072 RVA: 0x0033F216 File Offset: 0x0033D416
		public static ITriggerShape_UnionUnion FromIHollowSphereTriggerShape(IHollowSphereTriggerShapeT _ihollowspheretriggershape)
		{
			return new ITriggerShape_UnionUnion
			{
				Type = ITriggerShape_Union.IHollowSphereTriggerShape,
				Value = _ihollowspheretriggershape
			};
		}

		// Token: 0x06016B91 RID: 93073 RVA: 0x0033F22B File Offset: 0x0033D42B
		public ICylinderTriggerShapeT AsICylinderTriggerShape()
		{
			return this.As<ICylinderTriggerShapeT>();
		}

		// Token: 0x06016B92 RID: 93074 RVA: 0x0033F233 File Offset: 0x0033D433
		public static ITriggerShape_UnionUnion FromICylinderTriggerShape(ICylinderTriggerShapeT _icylindertriggershape)
		{
			return new ITriggerShape_UnionUnion
			{
				Type = ITriggerShape_Union.ICylinderTriggerShape,
				Value = _icylindertriggershape
			};
		}

		// Token: 0x06016B93 RID: 93075 RVA: 0x0033F248 File Offset: 0x0033D448
		public IHollowCylinderTriggerShapeT AsIHollowCylinderTriggerShape()
		{
			return this.As<IHollowCylinderTriggerShapeT>();
		}

		// Token: 0x06016B94 RID: 93076 RVA: 0x0033F250 File Offset: 0x0033D450
		public static ITriggerShape_UnionUnion FromIHollowCylinderTriggerShape(IHollowCylinderTriggerShapeT _ihollowcylindertriggershape)
		{
			return new ITriggerShape_UnionUnion
			{
				Type = ITriggerShape_Union.IHollowCylinderTriggerShape,
				Value = _ihollowcylindertriggershape
			};
		}

		// Token: 0x06016B95 RID: 93077 RVA: 0x0033F265 File Offset: 0x0033D465
		public IConeTriggerShapeT AsIConeTriggerShape()
		{
			return this.As<IConeTriggerShapeT>();
		}

		// Token: 0x06016B96 RID: 93078 RVA: 0x0033F26D File Offset: 0x0033D46D
		public static ITriggerShape_UnionUnion FromIConeTriggerShape(IConeTriggerShapeT _iconetriggershape)
		{
			return new ITriggerShape_UnionUnion
			{
				Type = ITriggerShape_Union.IConeTriggerShape,
				Value = _iconetriggershape
			};
		}

		// Token: 0x06016B97 RID: 93079 RVA: 0x0033F282 File Offset: 0x0033D482
		public IVolumeTriggerShapeT AsIVolumeTriggerShape()
		{
			return this.As<IVolumeTriggerShapeT>();
		}

		// Token: 0x06016B98 RID: 93080 RVA: 0x0033F28A File Offset: 0x0033D48A
		public static ITriggerShape_UnionUnion FromIVolumeTriggerShape(IVolumeTriggerShapeT _ivolumetriggershape)
		{
			return new ITriggerShape_UnionUnion
			{
				Type = ITriggerShape_Union.IVolumeTriggerShape,
				Value = _ivolumetriggershape
			};
		}

		// Token: 0x06016B99 RID: 93081 RVA: 0x0033F29F File Offset: 0x0033D49F
		public IActorRefVolumeT AsIActorRefVolume()
		{
			return this.As<IActorRefVolumeT>();
		}

		// Token: 0x06016B9A RID: 93082 RVA: 0x0033F2A7 File Offset: 0x0033D4A7
		public static ITriggerShape_UnionUnion FromIActorRefVolume(IActorRefVolumeT _iactorrefvolume)
		{
			return new ITriggerShape_UnionUnion
			{
				Type = ITriggerShape_Union.IActorRefVolume,
				Value = _iactorrefvolume
			};
		}

		// Token: 0x06016B9B RID: 93083 RVA: 0x0033F2BD File Offset: 0x0033D4BD
		public IActorCollisionTriggerShapeT AsIActorCollisionTriggerShape()
		{
			return this.As<IActorCollisionTriggerShapeT>();
		}

		// Token: 0x06016B9C RID: 93084 RVA: 0x0033F2C5 File Offset: 0x0033D4C5
		public static ITriggerShape_UnionUnion FromIActorCollisionTriggerShape(IActorCollisionTriggerShapeT _iactorcollisiontriggershape)
		{
			return new ITriggerShape_UnionUnion
			{
				Type = ITriggerShape_Union.IActorCollisionTriggerShape,
				Value = _iactorcollisiontriggershape
			};
		}

		// Token: 0x06016B9D RID: 93085 RVA: 0x0033F2DB File Offset: 0x0033D4DB
		public ICombinationTriggerShapeT AsICombinationTriggerShape()
		{
			return this.As<ICombinationTriggerShapeT>();
		}

		// Token: 0x06016B9E RID: 93086 RVA: 0x0033F2E3 File Offset: 0x0033D4E3
		public static ITriggerShape_UnionUnion FromICombinationTriggerShape(ICombinationTriggerShapeT _icombinationtriggershape)
		{
			return new ITriggerShape_UnionUnion
			{
				Type = ITriggerShape_Union.ICombinationTriggerShape,
				Value = _icombinationtriggershape
			};
		}

		// Token: 0x06016B9F RID: 93087 RVA: 0x0033F2F9 File Offset: 0x0033D4F9
		public ISpotlightTriggerShapeT AsISpotlightTriggerShape()
		{
			return this.As<ISpotlightTriggerShapeT>();
		}

		// Token: 0x06016BA0 RID: 93088 RVA: 0x0033F301 File Offset: 0x0033D501
		public static ITriggerShape_UnionUnion FromISpotlightTriggerShape(ISpotlightTriggerShapeT _ispotlighttriggershape)
		{
			return new ITriggerShape_UnionUnion
			{
				Type = ITriggerShape_Union.ISpotlightTriggerShape,
				Value = _ispotlighttriggershape
			};
		}

		// Token: 0x06016BA1 RID: 93089 RVA: 0x0033F318 File Offset: 0x0033D518
		public static int Pack(FlatBufferBuilder builder, ITriggerShape_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case ITriggerShape_Union.ITriggerShape:
				return ITriggerShape.Pack(builder, _o.AsITriggerShape()).Value;
			case ITriggerShape_Union.IBoxTriggerShape:
				return IBoxTriggerShape.Pack(builder, _o.AsIBoxTriggerShape()).Value;
			case ITriggerShape_Union.ISphereTriggerShape:
				return ISphereTriggerShape.Pack(builder, _o.AsISphereTriggerShape()).Value;
			case ITriggerShape_Union.IHollowSphereTriggerShape:
				return IHollowSphereTriggerShape.Pack(builder, _o.AsIHollowSphereTriggerShape()).Value;
			case ITriggerShape_Union.ICylinderTriggerShape:
				return ICylinderTriggerShape.Pack(builder, _o.AsICylinderTriggerShape()).Value;
			case ITriggerShape_Union.IHollowCylinderTriggerShape:
				return IHollowCylinderTriggerShape.Pack(builder, _o.AsIHollowCylinderTriggerShape()).Value;
			case ITriggerShape_Union.IConeTriggerShape:
				return IConeTriggerShape.Pack(builder, _o.AsIConeTriggerShape()).Value;
			case ITriggerShape_Union.IVolumeTriggerShape:
				return IVolumeTriggerShape.Pack(builder, _o.AsIVolumeTriggerShape()).Value;
			case ITriggerShape_Union.IActorRefVolume:
				return IActorRefVolume.Pack(builder, _o.AsIActorRefVolume()).Value;
			case ITriggerShape_Union.IActorCollisionTriggerShape:
				return IActorCollisionTriggerShape.Pack(builder, _o.AsIActorCollisionTriggerShape()).Value;
			case ITriggerShape_Union.ICombinationTriggerShape:
				return ICombinationTriggerShape.Pack(builder, _o.AsICombinationTriggerShape()).Value;
			case ITriggerShape_Union.ISpotlightTriggerShape:
				return ISpotlightTriggerShape.Pack(builder, _o.AsISpotlightTriggerShape()).Value;
			default:
				return 0;
			}
		}
	}
}
