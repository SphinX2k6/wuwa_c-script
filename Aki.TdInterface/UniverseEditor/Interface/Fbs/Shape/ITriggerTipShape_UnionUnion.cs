using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02003C71 RID: 15473
	public class ITriggerTipShape_UnionUnion
	{
		// Token: 0x17006AB7 RID: 27319
		// (get) Token: 0x060156A1 RID: 87713 RVA: 0x003187DD File Offset: 0x003169DD
		// (set) Token: 0x060156A2 RID: 87714 RVA: 0x003187E5 File Offset: 0x003169E5
		public ITriggerTipShape_Union Type { get; set; }

		// Token: 0x17006AB8 RID: 27320
		// (get) Token: 0x060156A3 RID: 87715 RVA: 0x003187EE File Offset: 0x003169EE
		// (set) Token: 0x060156A4 RID: 87716 RVA: 0x003187F6 File Offset: 0x003169F6
		public object Value { get; set; }

		// Token: 0x060156A5 RID: 87717 RVA: 0x003187FF File Offset: 0x003169FF
		public ITriggerTipShape_UnionUnion()
		{
			this.Type = ITriggerTipShape_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060156A6 RID: 87718 RVA: 0x00318815 File Offset: 0x00316A15
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060156A7 RID: 87719 RVA: 0x00318827 File Offset: 0x00316A27
		public ITriggerTipShapeT AsITriggerTipShape()
		{
			return this.As<ITriggerTipShapeT>();
		}

		// Token: 0x060156A8 RID: 87720 RVA: 0x0031882F File Offset: 0x00316A2F
		public static ITriggerTipShape_UnionUnion FromITriggerTipShape(ITriggerTipShapeT _itriggertipshape)
		{
			return new ITriggerTipShape_UnionUnion
			{
				Type = ITriggerTipShape_Union.ITriggerTipShape,
				Value = _itriggertipshape
			};
		}

		// Token: 0x060156A9 RID: 87721 RVA: 0x00318844 File Offset: 0x00316A44
		public IBoxTriggerTipShapeT AsIBoxTriggerTipShape()
		{
			return this.As<IBoxTriggerTipShapeT>();
		}

		// Token: 0x060156AA RID: 87722 RVA: 0x0031884C File Offset: 0x00316A4C
		public static ITriggerTipShape_UnionUnion FromIBoxTriggerTipShape(IBoxTriggerTipShapeT _iboxtriggertipshape)
		{
			return new ITriggerTipShape_UnionUnion
			{
				Type = ITriggerTipShape_Union.IBoxTriggerTipShape,
				Value = _iboxtriggertipshape
			};
		}

		// Token: 0x060156AB RID: 87723 RVA: 0x00318861 File Offset: 0x00316A61
		public ISphereTriggerTipShapeT AsISphereTriggerTipShape()
		{
			return this.As<ISphereTriggerTipShapeT>();
		}

		// Token: 0x060156AC RID: 87724 RVA: 0x00318869 File Offset: 0x00316A69
		public static ITriggerTipShape_UnionUnion FromISphereTriggerTipShape(ISphereTriggerTipShapeT _ispheretriggertipshape)
		{
			return new ITriggerTipShape_UnionUnion
			{
				Type = ITriggerTipShape_Union.ISphereTriggerTipShape,
				Value = _ispheretriggertipshape
			};
		}

		// Token: 0x060156AD RID: 87725 RVA: 0x00318880 File Offset: 0x00316A80
		public static int Pack(FlatBufferBuilder builder, ITriggerTipShape_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case ITriggerTipShape_Union.ITriggerTipShape:
				return ITriggerTipShape.Pack(builder, _o.AsITriggerTipShape()).Value;
			case ITriggerTipShape_Union.IBoxTriggerTipShape:
				return IBoxTriggerTipShape.Pack(builder, _o.AsIBoxTriggerTipShape()).Value;
			case ITriggerTipShape_Union.ISphereTriggerTipShape:
				return ISphereTriggerTipShape.Pack(builder, _o.AsISphereTriggerTipShape()).Value;
			default:
				return 0;
			}
		}
	}
}
