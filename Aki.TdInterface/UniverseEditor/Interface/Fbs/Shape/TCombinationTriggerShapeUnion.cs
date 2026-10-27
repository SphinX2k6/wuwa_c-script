using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02003C77 RID: 15479
	public class TCombinationTriggerShapeUnion
	{
		// Token: 0x17006ABE RID: 27326
		// (get) Token: 0x060156C7 RID: 87751 RVA: 0x00318B59 File Offset: 0x00316D59
		// (set) Token: 0x060156C8 RID: 87752 RVA: 0x00318B61 File Offset: 0x00316D61
		public TCombinationTriggerShape Type { get; set; }

		// Token: 0x17006ABF RID: 27327
		// (get) Token: 0x060156C9 RID: 87753 RVA: 0x00318B6A File Offset: 0x00316D6A
		// (set) Token: 0x060156CA RID: 87754 RVA: 0x00318B72 File Offset: 0x00316D72
		public object Value { get; set; }

		// Token: 0x060156CB RID: 87755 RVA: 0x00318B7B File Offset: 0x00316D7B
		public TCombinationTriggerShapeUnion()
		{
			this.Type = TCombinationTriggerShape.NONE;
			this.Value = null;
		}

		// Token: 0x060156CC RID: 87756 RVA: 0x00318B91 File Offset: 0x00316D91
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060156CD RID: 87757 RVA: 0x00318BA3 File Offset: 0x00316DA3
		public IBoxTriggerShapeT AsIBoxTriggerShape()
		{
			return this.As<IBoxTriggerShapeT>();
		}

		// Token: 0x060156CE RID: 87758 RVA: 0x00318BAB File Offset: 0x00316DAB
		public static TCombinationTriggerShapeUnion FromIBoxTriggerShape(IBoxTriggerShapeT _iboxtriggershape)
		{
			return new TCombinationTriggerShapeUnion
			{
				Type = TCombinationTriggerShape.IBoxTriggerShape,
				Value = _iboxtriggershape
			};
		}

		// Token: 0x060156CF RID: 87759 RVA: 0x00318BC0 File Offset: 0x00316DC0
		public ISphereTriggerShapeT AsISphereTriggerShape()
		{
			return this.As<ISphereTriggerShapeT>();
		}

		// Token: 0x060156D0 RID: 87760 RVA: 0x00318BC8 File Offset: 0x00316DC8
		public static TCombinationTriggerShapeUnion FromISphereTriggerShape(ISphereTriggerShapeT _ispheretriggershape)
		{
			return new TCombinationTriggerShapeUnion
			{
				Type = TCombinationTriggerShape.ISphereTriggerShape,
				Value = _ispheretriggershape
			};
		}

		// Token: 0x060156D1 RID: 87761 RVA: 0x00318BDD File Offset: 0x00316DDD
		public IHollowSphereTriggerShapeT AsIHollowSphereTriggerShape()
		{
			return this.As<IHollowSphereTriggerShapeT>();
		}

		// Token: 0x060156D2 RID: 87762 RVA: 0x00318BE5 File Offset: 0x00316DE5
		public static TCombinationTriggerShapeUnion FromIHollowSphereTriggerShape(IHollowSphereTriggerShapeT _ihollowspheretriggershape)
		{
			return new TCombinationTriggerShapeUnion
			{
				Type = TCombinationTriggerShape.IHollowSphereTriggerShape,
				Value = _ihollowspheretriggershape
			};
		}

		// Token: 0x060156D3 RID: 87763 RVA: 0x00318BFA File Offset: 0x00316DFA
		public ICylinderTriggerShapeT AsICylinderTriggerShape()
		{
			return this.As<ICylinderTriggerShapeT>();
		}

		// Token: 0x060156D4 RID: 87764 RVA: 0x00318C02 File Offset: 0x00316E02
		public static TCombinationTriggerShapeUnion FromICylinderTriggerShape(ICylinderTriggerShapeT _icylindertriggershape)
		{
			return new TCombinationTriggerShapeUnion
			{
				Type = TCombinationTriggerShape.ICylinderTriggerShape,
				Value = _icylindertriggershape
			};
		}

		// Token: 0x060156D5 RID: 87765 RVA: 0x00318C17 File Offset: 0x00316E17
		public IHollowCylinderTriggerShapeT AsIHollowCylinderTriggerShape()
		{
			return this.As<IHollowCylinderTriggerShapeT>();
		}

		// Token: 0x060156D6 RID: 87766 RVA: 0x00318C1F File Offset: 0x00316E1F
		public static TCombinationTriggerShapeUnion FromIHollowCylinderTriggerShape(IHollowCylinderTriggerShapeT _ihollowcylindertriggershape)
		{
			return new TCombinationTriggerShapeUnion
			{
				Type = TCombinationTriggerShape.IHollowCylinderTriggerShape,
				Value = _ihollowcylindertriggershape
			};
		}

		// Token: 0x060156D7 RID: 87767 RVA: 0x00318C34 File Offset: 0x00316E34
		public IConeTriggerShapeT AsIConeTriggerShape()
		{
			return this.As<IConeTriggerShapeT>();
		}

		// Token: 0x060156D8 RID: 87768 RVA: 0x00318C3C File Offset: 0x00316E3C
		public static TCombinationTriggerShapeUnion FromIConeTriggerShape(IConeTriggerShapeT _iconetriggershape)
		{
			return new TCombinationTriggerShapeUnion
			{
				Type = TCombinationTriggerShape.IConeTriggerShape,
				Value = _iconetriggershape
			};
		}

		// Token: 0x060156D9 RID: 87769 RVA: 0x00318C51 File Offset: 0x00316E51
		public IVolumeTriggerShapeT AsIVolumeTriggerShape()
		{
			return this.As<IVolumeTriggerShapeT>();
		}

		// Token: 0x060156DA RID: 87770 RVA: 0x00318C59 File Offset: 0x00316E59
		public static TCombinationTriggerShapeUnion FromIVolumeTriggerShape(IVolumeTriggerShapeT _ivolumetriggershape)
		{
			return new TCombinationTriggerShapeUnion
			{
				Type = TCombinationTriggerShape.IVolumeTriggerShape,
				Value = _ivolumetriggershape
			};
		}

		// Token: 0x060156DB RID: 87771 RVA: 0x00318C6E File Offset: 0x00316E6E
		public IActorRefVolumeT AsIActorRefVolume()
		{
			return this.As<IActorRefVolumeT>();
		}

		// Token: 0x060156DC RID: 87772 RVA: 0x00318C76 File Offset: 0x00316E76
		public static TCombinationTriggerShapeUnion FromIActorRefVolume(IActorRefVolumeT _iactorrefvolume)
		{
			return new TCombinationTriggerShapeUnion
			{
				Type = TCombinationTriggerShape.IActorRefVolume,
				Value = _iactorrefvolume
			};
		}

		// Token: 0x060156DD RID: 87773 RVA: 0x00318C8B File Offset: 0x00316E8B
		public IActorCollisionTriggerShapeT AsIActorCollisionTriggerShape()
		{
			return this.As<IActorCollisionTriggerShapeT>();
		}

		// Token: 0x060156DE RID: 87774 RVA: 0x00318C93 File Offset: 0x00316E93
		public static TCombinationTriggerShapeUnion FromIActorCollisionTriggerShape(IActorCollisionTriggerShapeT _iactorcollisiontriggershape)
		{
			return new TCombinationTriggerShapeUnion
			{
				Type = TCombinationTriggerShape.IActorCollisionTriggerShape,
				Value = _iactorcollisiontriggershape
			};
		}

		// Token: 0x060156DF RID: 87775 RVA: 0x00318CA9 File Offset: 0x00316EA9
		public ICombinationTriggerShapeT AsICombinationTriggerShape()
		{
			return this.As<ICombinationTriggerShapeT>();
		}

		// Token: 0x060156E0 RID: 87776 RVA: 0x00318CB1 File Offset: 0x00316EB1
		public static TCombinationTriggerShapeUnion FromICombinationTriggerShape(ICombinationTriggerShapeT _icombinationtriggershape)
		{
			return new TCombinationTriggerShapeUnion
			{
				Type = TCombinationTriggerShape.ICombinationTriggerShape,
				Value = _icombinationtriggershape
			};
		}

		// Token: 0x060156E1 RID: 87777 RVA: 0x00318CC7 File Offset: 0x00316EC7
		public ISpotlightTriggerShapeT AsISpotlightTriggerShape()
		{
			return this.As<ISpotlightTriggerShapeT>();
		}

		// Token: 0x060156E2 RID: 87778 RVA: 0x00318CCF File Offset: 0x00316ECF
		public static TCombinationTriggerShapeUnion FromISpotlightTriggerShape(ISpotlightTriggerShapeT _ispotlighttriggershape)
		{
			return new TCombinationTriggerShapeUnion
			{
				Type = TCombinationTriggerShape.ISpotlightTriggerShape,
				Value = _ispotlighttriggershape
			};
		}

		// Token: 0x060156E3 RID: 87779 RVA: 0x00318CE8 File Offset: 0x00316EE8
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
