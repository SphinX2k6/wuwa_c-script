using System;
using Aki.UniverseEditor.Interface.Fbs.Shape;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200624D RID: 25165
	public class TFrequencyPaintRangeUnion
	{
		// Token: 0x1700BB4A RID: 47946
		// (get) Token: 0x0602AD55 RID: 175445 RVA: 0x005D9466 File Offset: 0x005D7666
		// (set) Token: 0x0602AD56 RID: 175446 RVA: 0x005D946E File Offset: 0x005D766E
		public TFrequencyPaintRange Type { get; set; }

		// Token: 0x1700BB4B RID: 47947
		// (get) Token: 0x0602AD57 RID: 175447 RVA: 0x005D9477 File Offset: 0x005D7677
		// (set) Token: 0x0602AD58 RID: 175448 RVA: 0x005D947F File Offset: 0x005D767F
		public object Value { get; set; }

		// Token: 0x0602AD59 RID: 175449 RVA: 0x005D9488 File Offset: 0x005D7688
		public TFrequencyPaintRangeUnion()
		{
			this.Type = TFrequencyPaintRange.NONE;
			this.Value = null;
		}

		// Token: 0x0602AD5A RID: 175450 RVA: 0x005D949E File Offset: 0x005D769E
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602AD5B RID: 175451 RVA: 0x005D94B0 File Offset: 0x005D76B0
		public IBoxTriggerShapeT AsAki_UniverseEditor_Interface_Fbs_Shape_IBoxTriggerShape()
		{
			return this.As<IBoxTriggerShapeT>();
		}

		// Token: 0x0602AD5C RID: 175452 RVA: 0x005D94B8 File Offset: 0x005D76B8
		public static TFrequencyPaintRangeUnion FromAki_UniverseEditor_Interface_Fbs_Shape_IBoxTriggerShape(IBoxTriggerShapeT _aki_universeeditor_interface_fbs_shape_iboxtriggershape)
		{
			return new TFrequencyPaintRangeUnion
			{
				Type = TFrequencyPaintRange.Aki_UniverseEditor_Interface_Fbs_Shape_IBoxTriggerShape,
				Value = _aki_universeeditor_interface_fbs_shape_iboxtriggershape
			};
		}

		// Token: 0x0602AD5D RID: 175453 RVA: 0x005D94CD File Offset: 0x005D76CD
		public ISphereTriggerShapeT AsAki_UniverseEditor_Interface_Fbs_Shape_ISphereTriggerShape()
		{
			return this.As<ISphereTriggerShapeT>();
		}

		// Token: 0x0602AD5E RID: 175454 RVA: 0x005D94D5 File Offset: 0x005D76D5
		public static TFrequencyPaintRangeUnion FromAki_UniverseEditor_Interface_Fbs_Shape_ISphereTriggerShape(ISphereTriggerShapeT _aki_universeeditor_interface_fbs_shape_ispheretriggershape)
		{
			return new TFrequencyPaintRangeUnion
			{
				Type = TFrequencyPaintRange.Aki_UniverseEditor_Interface_Fbs_Shape_ISphereTriggerShape,
				Value = _aki_universeeditor_interface_fbs_shape_ispheretriggershape
			};
		}

		// Token: 0x0602AD5F RID: 175455 RVA: 0x005D94EC File Offset: 0x005D76EC
		public static int Pack(FlatBufferBuilder builder, TFrequencyPaintRangeUnion _o)
		{
			TFrequencyPaintRange type = _o.Type;
			if (type == TFrequencyPaintRange.Aki_UniverseEditor_Interface_Fbs_Shape_IBoxTriggerShape)
			{
				return IBoxTriggerShape.Pack(builder, _o.AsAki_UniverseEditor_Interface_Fbs_Shape_IBoxTriggerShape()).Value;
			}
			if (type != TFrequencyPaintRange.Aki_UniverseEditor_Interface_Fbs_Shape_ISphereTriggerShape)
			{
				return 0;
			}
			return ISphereTriggerShape.Pack(builder, _o.AsAki_UniverseEditor_Interface_Fbs_Shape_ISphereTriggerShape()).Value;
		}
	}
}
