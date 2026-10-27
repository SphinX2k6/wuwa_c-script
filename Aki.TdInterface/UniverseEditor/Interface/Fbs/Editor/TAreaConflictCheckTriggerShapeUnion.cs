using System;
using Aki.UniverseEditor.Interface.Fbs.Shape;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x020048E1 RID: 18657
	public class TAreaConflictCheckTriggerShapeUnion
	{
		// Token: 0x1700876E RID: 34670
		// (get) Token: 0x0601D2E4 RID: 119524 RVA: 0x0041E521 File Offset: 0x0041C721
		// (set) Token: 0x0601D2E5 RID: 119525 RVA: 0x0041E529 File Offset: 0x0041C729
		public TAreaConflictCheckTriggerShape Type { get; set; }

		// Token: 0x1700876F RID: 34671
		// (get) Token: 0x0601D2E6 RID: 119526 RVA: 0x0041E532 File Offset: 0x0041C732
		// (set) Token: 0x0601D2E7 RID: 119527 RVA: 0x0041E53A File Offset: 0x0041C73A
		public object Value { get; set; }

		// Token: 0x0601D2E8 RID: 119528 RVA: 0x0041E543 File Offset: 0x0041C743
		public TAreaConflictCheckTriggerShapeUnion()
		{
			this.Type = TAreaConflictCheckTriggerShape.NONE;
			this.Value = null;
		}

		// Token: 0x0601D2E9 RID: 119529 RVA: 0x0041E559 File Offset: 0x0041C759
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601D2EA RID: 119530 RVA: 0x0041E56B File Offset: 0x0041C76B
		public IBoxTriggerShapeT AsAki_UniverseEditor_Interface_Fbs_Shape_IBoxTriggerShape()
		{
			return this.As<IBoxTriggerShapeT>();
		}

		// Token: 0x0601D2EB RID: 119531 RVA: 0x0041E573 File Offset: 0x0041C773
		public static TAreaConflictCheckTriggerShapeUnion FromAki_UniverseEditor_Interface_Fbs_Shape_IBoxTriggerShape(IBoxTriggerShapeT _aki_universeeditor_interface_fbs_shape_iboxtriggershape)
		{
			return new TAreaConflictCheckTriggerShapeUnion
			{
				Type = TAreaConflictCheckTriggerShape.Aki_UniverseEditor_Interface_Fbs_Shape_IBoxTriggerShape,
				Value = _aki_universeeditor_interface_fbs_shape_iboxtriggershape
			};
		}

		// Token: 0x0601D2EC RID: 119532 RVA: 0x0041E588 File Offset: 0x0041C788
		public ICylinderTriggerShapeT AsAki_UniverseEditor_Interface_Fbs_Shape_ICylinderTriggerShape()
		{
			return this.As<ICylinderTriggerShapeT>();
		}

		// Token: 0x0601D2ED RID: 119533 RVA: 0x0041E590 File Offset: 0x0041C790
		public static TAreaConflictCheckTriggerShapeUnion FromAki_UniverseEditor_Interface_Fbs_Shape_ICylinderTriggerShape(ICylinderTriggerShapeT _aki_universeeditor_interface_fbs_shape_icylindertriggershape)
		{
			return new TAreaConflictCheckTriggerShapeUnion
			{
				Type = TAreaConflictCheckTriggerShape.Aki_UniverseEditor_Interface_Fbs_Shape_ICylinderTriggerShape,
				Value = _aki_universeeditor_interface_fbs_shape_icylindertriggershape
			};
		}

		// Token: 0x0601D2EE RID: 119534 RVA: 0x0041E5A5 File Offset: 0x0041C7A5
		public ISphereTriggerShapeT AsAki_UniverseEditor_Interface_Fbs_Shape_ISphereTriggerShape()
		{
			return this.As<ISphereTriggerShapeT>();
		}

		// Token: 0x0601D2EF RID: 119535 RVA: 0x0041E5AD File Offset: 0x0041C7AD
		public static TAreaConflictCheckTriggerShapeUnion FromAki_UniverseEditor_Interface_Fbs_Shape_ISphereTriggerShape(ISphereTriggerShapeT _aki_universeeditor_interface_fbs_shape_ispheretriggershape)
		{
			return new TAreaConflictCheckTriggerShapeUnion
			{
				Type = TAreaConflictCheckTriggerShape.Aki_UniverseEditor_Interface_Fbs_Shape_ISphereTriggerShape,
				Value = _aki_universeeditor_interface_fbs_shape_ispheretriggershape
			};
		}

		// Token: 0x0601D2F0 RID: 119536 RVA: 0x0041E5C4 File Offset: 0x0041C7C4
		public static int Pack(FlatBufferBuilder builder, TAreaConflictCheckTriggerShapeUnion _o)
		{
			switch (_o.Type)
			{
			case TAreaConflictCheckTriggerShape.Aki_UniverseEditor_Interface_Fbs_Shape_IBoxTriggerShape:
				return IBoxTriggerShape.Pack(builder, _o.AsAki_UniverseEditor_Interface_Fbs_Shape_IBoxTriggerShape()).Value;
			case TAreaConflictCheckTriggerShape.Aki_UniverseEditor_Interface_Fbs_Shape_ICylinderTriggerShape:
				return ICylinderTriggerShape.Pack(builder, _o.AsAki_UniverseEditor_Interface_Fbs_Shape_ICylinderTriggerShape()).Value;
			case TAreaConflictCheckTriggerShape.Aki_UniverseEditor_Interface_Fbs_Shape_ISphereTriggerShape:
				return ISphereTriggerShape.Pack(builder, _o.AsAki_UniverseEditor_Interface_Fbs_Shape_ISphereTriggerShape()).Value;
			default:
				return 0;
			}
		}
	}
}
