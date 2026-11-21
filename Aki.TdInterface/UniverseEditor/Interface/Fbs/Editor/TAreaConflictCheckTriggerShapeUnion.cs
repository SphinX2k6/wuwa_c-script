using System;
using Aki.UniverseEditor.Interface.Fbs.Shape;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004D46 RID: 19782
	public class TAreaConflictCheckTriggerShapeUnion
	{
		// Token: 0x17008DB6 RID: 36278
		// (get) Token: 0x0601EAD1 RID: 125649 RVA: 0x0044ACBD File Offset: 0x00448EBD
		// (set) Token: 0x0601EAD2 RID: 125650 RVA: 0x0044ACC5 File Offset: 0x00448EC5
		public TAreaConflictCheckTriggerShape Type { get; set; }

		// Token: 0x17008DB7 RID: 36279
		// (get) Token: 0x0601EAD3 RID: 125651 RVA: 0x0044ACCE File Offset: 0x00448ECE
		// (set) Token: 0x0601EAD4 RID: 125652 RVA: 0x0044ACD6 File Offset: 0x00448ED6
		public object Value { get; set; }

		// Token: 0x0601EAD5 RID: 125653 RVA: 0x0044ACDF File Offset: 0x00448EDF
		public TAreaConflictCheckTriggerShapeUnion()
		{
			this.Type = TAreaConflictCheckTriggerShape.NONE;
			this.Value = null;
		}

		// Token: 0x0601EAD6 RID: 125654 RVA: 0x0044ACF5 File Offset: 0x00448EF5
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601EAD7 RID: 125655 RVA: 0x0044AD07 File Offset: 0x00448F07
		public IBoxTriggerShapeT AsAki_UniverseEditor_Interface_Fbs_Shape_IBoxTriggerShape()
		{
			return this.As<IBoxTriggerShapeT>();
		}

		// Token: 0x0601EAD8 RID: 125656 RVA: 0x0044AD0F File Offset: 0x00448F0F
		public static TAreaConflictCheckTriggerShapeUnion FromAki_UniverseEditor_Interface_Fbs_Shape_IBoxTriggerShape(IBoxTriggerShapeT _aki_universeeditor_interface_fbs_shape_iboxtriggershape)
		{
			return new TAreaConflictCheckTriggerShapeUnion
			{
				Type = TAreaConflictCheckTriggerShape.Aki_UniverseEditor_Interface_Fbs_Shape_IBoxTriggerShape,
				Value = _aki_universeeditor_interface_fbs_shape_iboxtriggershape
			};
		}

		// Token: 0x0601EAD9 RID: 125657 RVA: 0x0044AD24 File Offset: 0x00448F24
		public ICylinderTriggerShapeT AsAki_UniverseEditor_Interface_Fbs_Shape_ICylinderTriggerShape()
		{
			return this.As<ICylinderTriggerShapeT>();
		}

		// Token: 0x0601EADA RID: 125658 RVA: 0x0044AD2C File Offset: 0x00448F2C
		public static TAreaConflictCheckTriggerShapeUnion FromAki_UniverseEditor_Interface_Fbs_Shape_ICylinderTriggerShape(ICylinderTriggerShapeT _aki_universeeditor_interface_fbs_shape_icylindertriggershape)
		{
			return new TAreaConflictCheckTriggerShapeUnion
			{
				Type = TAreaConflictCheckTriggerShape.Aki_UniverseEditor_Interface_Fbs_Shape_ICylinderTriggerShape,
				Value = _aki_universeeditor_interface_fbs_shape_icylindertriggershape
			};
		}

		// Token: 0x0601EADB RID: 125659 RVA: 0x0044AD41 File Offset: 0x00448F41
		public ISphereTriggerShapeT AsAki_UniverseEditor_Interface_Fbs_Shape_ISphereTriggerShape()
		{
			return this.As<ISphereTriggerShapeT>();
		}

		// Token: 0x0601EADC RID: 125660 RVA: 0x0044AD49 File Offset: 0x00448F49
		public static TAreaConflictCheckTriggerShapeUnion FromAki_UniverseEditor_Interface_Fbs_Shape_ISphereTriggerShape(ISphereTriggerShapeT _aki_universeeditor_interface_fbs_shape_ispheretriggershape)
		{
			return new TAreaConflictCheckTriggerShapeUnion
			{
				Type = TAreaConflictCheckTriggerShape.Aki_UniverseEditor_Interface_Fbs_Shape_ISphereTriggerShape,
				Value = _aki_universeeditor_interface_fbs_shape_ispheretriggershape
			};
		}

		// Token: 0x0601EADD RID: 125661 RVA: 0x0044AD60 File Offset: 0x00448F60
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
