using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02003C86 RID: 15494
	public class TTriggerShapeUnion
	{
		// Token: 0x17006AC8 RID: 27336
		// (get) Token: 0x06015735 RID: 87861 RVA: 0x003196E2 File Offset: 0x003178E2
		// (set) Token: 0x06015736 RID: 87862 RVA: 0x003196EA File Offset: 0x003178EA
		public TTriggerShape Type { get; set; }

		// Token: 0x17006AC9 RID: 27337
		// (get) Token: 0x06015737 RID: 87863 RVA: 0x003196F3 File Offset: 0x003178F3
		// (set) Token: 0x06015738 RID: 87864 RVA: 0x003196FB File Offset: 0x003178FB
		public object Value { get; set; }

		// Token: 0x06015739 RID: 87865 RVA: 0x00319704 File Offset: 0x00317904
		public TTriggerShapeUnion()
		{
			this.Type = TTriggerShape.NONE;
			this.Value = null;
		}

		// Token: 0x0601573A RID: 87866 RVA: 0x0031971A File Offset: 0x0031791A
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601573B RID: 87867 RVA: 0x0031972C File Offset: 0x0031792C
		public IActorCollisionTriggerShapeT AsIActorCollisionTriggerShape()
		{
			return this.As<IActorCollisionTriggerShapeT>();
		}

		// Token: 0x0601573C RID: 87868 RVA: 0x00319734 File Offset: 0x00317934
		public static TTriggerShapeUnion FromIActorCollisionTriggerShape(IActorCollisionTriggerShapeT _iactorcollisiontriggershape)
		{
			return new TTriggerShapeUnion
			{
				Type = TTriggerShape.IActorCollisionTriggerShape,
				Value = _iactorcollisiontriggershape
			};
		}

		// Token: 0x0601573D RID: 87869 RVA: 0x00319749 File Offset: 0x00317949
		public IActorRefVolumeT AsIActorRefVolume()
		{
			return this.As<IActorRefVolumeT>();
		}

		// Token: 0x0601573E RID: 87870 RVA: 0x00319751 File Offset: 0x00317951
		public static TTriggerShapeUnion FromIActorRefVolume(IActorRefVolumeT _iactorrefvolume)
		{
			return new TTriggerShapeUnion
			{
				Type = TTriggerShape.IActorRefVolume,
				Value = _iactorrefvolume
			};
		}

		// Token: 0x0601573F RID: 87871 RVA: 0x00319766 File Offset: 0x00317966
		public IBoxTriggerShapeT AsIBoxTriggerShape()
		{
			return this.As<IBoxTriggerShapeT>();
		}

		// Token: 0x06015740 RID: 87872 RVA: 0x0031976E File Offset: 0x0031796E
		public static TTriggerShapeUnion FromIBoxTriggerShape(IBoxTriggerShapeT _iboxtriggershape)
		{
			return new TTriggerShapeUnion
			{
				Type = TTriggerShape.IBoxTriggerShape,
				Value = _iboxtriggershape
			};
		}

		// Token: 0x06015741 RID: 87873 RVA: 0x00319783 File Offset: 0x00317983
		public ICombinationTriggerShapeT AsICombinationTriggerShape()
		{
			return this.As<ICombinationTriggerShapeT>();
		}

		// Token: 0x06015742 RID: 87874 RVA: 0x0031978B File Offset: 0x0031798B
		public static TTriggerShapeUnion FromICombinationTriggerShape(ICombinationTriggerShapeT _icombinationtriggershape)
		{
			return new TTriggerShapeUnion
			{
				Type = TTriggerShape.ICombinationTriggerShape,
				Value = _icombinationtriggershape
			};
		}

		// Token: 0x06015743 RID: 87875 RVA: 0x003197A0 File Offset: 0x003179A0
		public IConeTriggerShapeT AsIConeTriggerShape()
		{
			return this.As<IConeTriggerShapeT>();
		}

		// Token: 0x06015744 RID: 87876 RVA: 0x003197A8 File Offset: 0x003179A8
		public static TTriggerShapeUnion FromIConeTriggerShape(IConeTriggerShapeT _iconetriggershape)
		{
			return new TTriggerShapeUnion
			{
				Type = TTriggerShape.IConeTriggerShape,
				Value = _iconetriggershape
			};
		}

		// Token: 0x06015745 RID: 87877 RVA: 0x003197BD File Offset: 0x003179BD
		public ICylinderTriggerShapeT AsICylinderTriggerShape()
		{
			return this.As<ICylinderTriggerShapeT>();
		}

		// Token: 0x06015746 RID: 87878 RVA: 0x003197C5 File Offset: 0x003179C5
		public static TTriggerShapeUnion FromICylinderTriggerShape(ICylinderTriggerShapeT _icylindertriggershape)
		{
			return new TTriggerShapeUnion
			{
				Type = TTriggerShape.ICylinderTriggerShape,
				Value = _icylindertriggershape
			};
		}

		// Token: 0x06015747 RID: 87879 RVA: 0x003197DA File Offset: 0x003179DA
		public IHollowCylinderTriggerShapeT AsIHollowCylinderTriggerShape()
		{
			return this.As<IHollowCylinderTriggerShapeT>();
		}

		// Token: 0x06015748 RID: 87880 RVA: 0x003197E2 File Offset: 0x003179E2
		public static TTriggerShapeUnion FromIHollowCylinderTriggerShape(IHollowCylinderTriggerShapeT _ihollowcylindertriggershape)
		{
			return new TTriggerShapeUnion
			{
				Type = TTriggerShape.IHollowCylinderTriggerShape,
				Value = _ihollowcylindertriggershape
			};
		}

		// Token: 0x06015749 RID: 87881 RVA: 0x003197F7 File Offset: 0x003179F7
		public IHollowSphereTriggerShapeT AsIHollowSphereTriggerShape()
		{
			return this.As<IHollowSphereTriggerShapeT>();
		}

		// Token: 0x0601574A RID: 87882 RVA: 0x003197FF File Offset: 0x003179FF
		public static TTriggerShapeUnion FromIHollowSphereTriggerShape(IHollowSphereTriggerShapeT _ihollowspheretriggershape)
		{
			return new TTriggerShapeUnion
			{
				Type = TTriggerShape.IHollowSphereTriggerShape,
				Value = _ihollowspheretriggershape
			};
		}

		// Token: 0x0601574B RID: 87883 RVA: 0x00319814 File Offset: 0x00317A14
		public ISphereTriggerShapeT AsISphereTriggerShape()
		{
			return this.As<ISphereTriggerShapeT>();
		}

		// Token: 0x0601574C RID: 87884 RVA: 0x0031981C File Offset: 0x00317A1C
		public static TTriggerShapeUnion FromISphereTriggerShape(ISphereTriggerShapeT _ispheretriggershape)
		{
			return new TTriggerShapeUnion
			{
				Type = TTriggerShape.ISphereTriggerShape,
				Value = _ispheretriggershape
			};
		}

		// Token: 0x0601574D RID: 87885 RVA: 0x00319832 File Offset: 0x00317A32
		public ISpotlightTriggerShapeT AsISpotlightTriggerShape()
		{
			return this.As<ISpotlightTriggerShapeT>();
		}

		// Token: 0x0601574E RID: 87886 RVA: 0x0031983A File Offset: 0x00317A3A
		public static TTriggerShapeUnion FromISpotlightTriggerShape(ISpotlightTriggerShapeT _ispotlighttriggershape)
		{
			return new TTriggerShapeUnion
			{
				Type = TTriggerShape.ISpotlightTriggerShape,
				Value = _ispotlighttriggershape
			};
		}

		// Token: 0x0601574F RID: 87887 RVA: 0x00319850 File Offset: 0x00317A50
		public IVolumeTriggerShapeT AsIVolumeTriggerShape()
		{
			return this.As<IVolumeTriggerShapeT>();
		}

		// Token: 0x06015750 RID: 87888 RVA: 0x00319858 File Offset: 0x00317A58
		public static TTriggerShapeUnion FromIVolumeTriggerShape(IVolumeTriggerShapeT _ivolumetriggershape)
		{
			return new TTriggerShapeUnion
			{
				Type = TTriggerShape.IVolumeTriggerShape,
				Value = _ivolumetriggershape
			};
		}

		// Token: 0x06015751 RID: 87889 RVA: 0x00319870 File Offset: 0x00317A70
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
