using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02003C6B RID: 15467
	public class ITriggerShape_UnionUnion
	{
		// Token: 0x17006AB2 RID: 27314
		// (get) Token: 0x0601566F RID: 87663 RVA: 0x003182CD File Offset: 0x003164CD
		// (set) Token: 0x06015670 RID: 87664 RVA: 0x003182D5 File Offset: 0x003164D5
		public ITriggerShape_Union Type { get; set; }

		// Token: 0x17006AB3 RID: 27315
		// (get) Token: 0x06015671 RID: 87665 RVA: 0x003182DE File Offset: 0x003164DE
		// (set) Token: 0x06015672 RID: 87666 RVA: 0x003182E6 File Offset: 0x003164E6
		public object Value { get; set; }

		// Token: 0x06015673 RID: 87667 RVA: 0x003182EF File Offset: 0x003164EF
		public ITriggerShape_UnionUnion()
		{
			this.Type = ITriggerShape_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06015674 RID: 87668 RVA: 0x00318305 File Offset: 0x00316505
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06015675 RID: 87669 RVA: 0x00318317 File Offset: 0x00316517
		public ITriggerShapeT AsITriggerShape()
		{
			return this.As<ITriggerShapeT>();
		}

		// Token: 0x06015676 RID: 87670 RVA: 0x0031831F File Offset: 0x0031651F
		public static ITriggerShape_UnionUnion FromITriggerShape(ITriggerShapeT _itriggershape)
		{
			return new ITriggerShape_UnionUnion
			{
				Type = ITriggerShape_Union.ITriggerShape,
				Value = _itriggershape
			};
		}

		// Token: 0x06015677 RID: 87671 RVA: 0x00318334 File Offset: 0x00316534
		public IBoxTriggerShapeT AsIBoxTriggerShape()
		{
			return this.As<IBoxTriggerShapeT>();
		}

		// Token: 0x06015678 RID: 87672 RVA: 0x0031833C File Offset: 0x0031653C
		public static ITriggerShape_UnionUnion FromIBoxTriggerShape(IBoxTriggerShapeT _iboxtriggershape)
		{
			return new ITriggerShape_UnionUnion
			{
				Type = ITriggerShape_Union.IBoxTriggerShape,
				Value = _iboxtriggershape
			};
		}

		// Token: 0x06015679 RID: 87673 RVA: 0x00318351 File Offset: 0x00316551
		public ISphereTriggerShapeT AsISphereTriggerShape()
		{
			return this.As<ISphereTriggerShapeT>();
		}

		// Token: 0x0601567A RID: 87674 RVA: 0x00318359 File Offset: 0x00316559
		public static ITriggerShape_UnionUnion FromISphereTriggerShape(ISphereTriggerShapeT _ispheretriggershape)
		{
			return new ITriggerShape_UnionUnion
			{
				Type = ITriggerShape_Union.ISphereTriggerShape,
				Value = _ispheretriggershape
			};
		}

		// Token: 0x0601567B RID: 87675 RVA: 0x0031836E File Offset: 0x0031656E
		public IHollowSphereTriggerShapeT AsIHollowSphereTriggerShape()
		{
			return this.As<IHollowSphereTriggerShapeT>();
		}

		// Token: 0x0601567C RID: 87676 RVA: 0x00318376 File Offset: 0x00316576
		public static ITriggerShape_UnionUnion FromIHollowSphereTriggerShape(IHollowSphereTriggerShapeT _ihollowspheretriggershape)
		{
			return new ITriggerShape_UnionUnion
			{
				Type = ITriggerShape_Union.IHollowSphereTriggerShape,
				Value = _ihollowspheretriggershape
			};
		}

		// Token: 0x0601567D RID: 87677 RVA: 0x0031838B File Offset: 0x0031658B
		public ICylinderTriggerShapeT AsICylinderTriggerShape()
		{
			return this.As<ICylinderTriggerShapeT>();
		}

		// Token: 0x0601567E RID: 87678 RVA: 0x00318393 File Offset: 0x00316593
		public static ITriggerShape_UnionUnion FromICylinderTriggerShape(ICylinderTriggerShapeT _icylindertriggershape)
		{
			return new ITriggerShape_UnionUnion
			{
				Type = ITriggerShape_Union.ICylinderTriggerShape,
				Value = _icylindertriggershape
			};
		}

		// Token: 0x0601567F RID: 87679 RVA: 0x003183A8 File Offset: 0x003165A8
		public IHollowCylinderTriggerShapeT AsIHollowCylinderTriggerShape()
		{
			return this.As<IHollowCylinderTriggerShapeT>();
		}

		// Token: 0x06015680 RID: 87680 RVA: 0x003183B0 File Offset: 0x003165B0
		public static ITriggerShape_UnionUnion FromIHollowCylinderTriggerShape(IHollowCylinderTriggerShapeT _ihollowcylindertriggershape)
		{
			return new ITriggerShape_UnionUnion
			{
				Type = ITriggerShape_Union.IHollowCylinderTriggerShape,
				Value = _ihollowcylindertriggershape
			};
		}

		// Token: 0x06015681 RID: 87681 RVA: 0x003183C5 File Offset: 0x003165C5
		public IConeTriggerShapeT AsIConeTriggerShape()
		{
			return this.As<IConeTriggerShapeT>();
		}

		// Token: 0x06015682 RID: 87682 RVA: 0x003183CD File Offset: 0x003165CD
		public static ITriggerShape_UnionUnion FromIConeTriggerShape(IConeTriggerShapeT _iconetriggershape)
		{
			return new ITriggerShape_UnionUnion
			{
				Type = ITriggerShape_Union.IConeTriggerShape,
				Value = _iconetriggershape
			};
		}

		// Token: 0x06015683 RID: 87683 RVA: 0x003183E2 File Offset: 0x003165E2
		public IVolumeTriggerShapeT AsIVolumeTriggerShape()
		{
			return this.As<IVolumeTriggerShapeT>();
		}

		// Token: 0x06015684 RID: 87684 RVA: 0x003183EA File Offset: 0x003165EA
		public static ITriggerShape_UnionUnion FromIVolumeTriggerShape(IVolumeTriggerShapeT _ivolumetriggershape)
		{
			return new ITriggerShape_UnionUnion
			{
				Type = ITriggerShape_Union.IVolumeTriggerShape,
				Value = _ivolumetriggershape
			};
		}

		// Token: 0x06015685 RID: 87685 RVA: 0x003183FF File Offset: 0x003165FF
		public IActorRefVolumeT AsIActorRefVolume()
		{
			return this.As<IActorRefVolumeT>();
		}

		// Token: 0x06015686 RID: 87686 RVA: 0x00318407 File Offset: 0x00316607
		public static ITriggerShape_UnionUnion FromIActorRefVolume(IActorRefVolumeT _iactorrefvolume)
		{
			return new ITriggerShape_UnionUnion
			{
				Type = ITriggerShape_Union.IActorRefVolume,
				Value = _iactorrefvolume
			};
		}

		// Token: 0x06015687 RID: 87687 RVA: 0x0031841D File Offset: 0x0031661D
		public IActorCollisionTriggerShapeT AsIActorCollisionTriggerShape()
		{
			return this.As<IActorCollisionTriggerShapeT>();
		}

		// Token: 0x06015688 RID: 87688 RVA: 0x00318425 File Offset: 0x00316625
		public static ITriggerShape_UnionUnion FromIActorCollisionTriggerShape(IActorCollisionTriggerShapeT _iactorcollisiontriggershape)
		{
			return new ITriggerShape_UnionUnion
			{
				Type = ITriggerShape_Union.IActorCollisionTriggerShape,
				Value = _iactorcollisiontriggershape
			};
		}

		// Token: 0x06015689 RID: 87689 RVA: 0x0031843B File Offset: 0x0031663B
		public ICombinationTriggerShapeT AsICombinationTriggerShape()
		{
			return this.As<ICombinationTriggerShapeT>();
		}

		// Token: 0x0601568A RID: 87690 RVA: 0x00318443 File Offset: 0x00316643
		public static ITriggerShape_UnionUnion FromICombinationTriggerShape(ICombinationTriggerShapeT _icombinationtriggershape)
		{
			return new ITriggerShape_UnionUnion
			{
				Type = ITriggerShape_Union.ICombinationTriggerShape,
				Value = _icombinationtriggershape
			};
		}

		// Token: 0x0601568B RID: 87691 RVA: 0x00318459 File Offset: 0x00316659
		public ISpotlightTriggerShapeT AsISpotlightTriggerShape()
		{
			return this.As<ISpotlightTriggerShapeT>();
		}

		// Token: 0x0601568C RID: 87692 RVA: 0x00318461 File Offset: 0x00316661
		public static ITriggerShape_UnionUnion FromISpotlightTriggerShape(ISpotlightTriggerShapeT _ispotlighttriggershape)
		{
			return new ITriggerShape_UnionUnion
			{
				Type = ITriggerShape_Union.ISpotlightTriggerShape,
				Value = _ispotlighttriggershape
			};
		}

		// Token: 0x0601568D RID: 87693 RVA: 0x00318478 File Offset: 0x00316678
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
