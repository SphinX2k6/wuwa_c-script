using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x0200409B RID: 16539
	public class TTriggerTipShapeUnion
	{
		// Token: 0x17007084 RID: 28804
		// (get) Token: 0x06016C8B RID: 93323 RVA: 0x00340CB0 File Offset: 0x0033EEB0
		// (set) Token: 0x06016C8C RID: 93324 RVA: 0x00340CB8 File Offset: 0x0033EEB8
		public TTriggerTipShape Type { get; set; }

		// Token: 0x17007085 RID: 28805
		// (get) Token: 0x06016C8D RID: 93325 RVA: 0x00340CC1 File Offset: 0x0033EEC1
		// (set) Token: 0x06016C8E RID: 93326 RVA: 0x00340CC9 File Offset: 0x0033EEC9
		public object Value { get; set; }

		// Token: 0x06016C8F RID: 93327 RVA: 0x00340CD2 File Offset: 0x0033EED2
		public TTriggerTipShapeUnion()
		{
			this.Type = TTriggerTipShape.NONE;
			this.Value = null;
		}

		// Token: 0x06016C90 RID: 93328 RVA: 0x00340CE8 File Offset: 0x0033EEE8
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06016C91 RID: 93329 RVA: 0x00340CFA File Offset: 0x0033EEFA
		public IBoxTriggerTipShapeT AsIBoxTriggerTipShape()
		{
			return this.As<IBoxTriggerTipShapeT>();
		}

		// Token: 0x06016C92 RID: 93330 RVA: 0x00340D02 File Offset: 0x0033EF02
		public static TTriggerTipShapeUnion FromIBoxTriggerTipShape(IBoxTriggerTipShapeT _iboxtriggertipshape)
		{
			return new TTriggerTipShapeUnion
			{
				Type = TTriggerTipShape.IBoxTriggerTipShape,
				Value = _iboxtriggertipshape
			};
		}

		// Token: 0x06016C93 RID: 93331 RVA: 0x00340D17 File Offset: 0x0033EF17
		public ISphereTriggerTipShapeT AsISphereTriggerTipShape()
		{
			return this.As<ISphereTriggerTipShapeT>();
		}

		// Token: 0x06016C94 RID: 93332 RVA: 0x00340D1F File Offset: 0x0033EF1F
		public static TTriggerTipShapeUnion FromISphereTriggerTipShape(ISphereTriggerTipShapeT _ispheretriggertipshape)
		{
			return new TTriggerTipShapeUnion
			{
				Type = TTriggerTipShape.ISphereTriggerTipShape,
				Value = _ispheretriggertipshape
			};
		}

		// Token: 0x06016C95 RID: 93333 RVA: 0x00340D34 File Offset: 0x0033EF34
		public static int Pack(FlatBufferBuilder builder, TTriggerTipShapeUnion _o)
		{
			TTriggerTipShape type = _o.Type;
			if (type == TTriggerTipShape.IBoxTriggerTipShape)
			{
				return IBoxTriggerTipShape.Pack(builder, _o.AsIBoxTriggerTipShape()).Value;
			}
			if (type != TTriggerTipShape.ISphereTriggerTipShape)
			{
				return 0;
			}
			return ISphereTriggerTipShape.Pack(builder, _o.AsISphereTriggerTipShape()).Value;
		}
	}
}
