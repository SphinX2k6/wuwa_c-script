using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02003C89 RID: 15497
	public class TTriggerTipShapeUnion
	{
		// Token: 0x17006ACA RID: 27338
		// (get) Token: 0x06015753 RID: 87891 RVA: 0x00319A38 File Offset: 0x00317C38
		// (set) Token: 0x06015754 RID: 87892 RVA: 0x00319A40 File Offset: 0x00317C40
		public TTriggerTipShape Type { get; set; }

		// Token: 0x17006ACB RID: 27339
		// (get) Token: 0x06015755 RID: 87893 RVA: 0x00319A49 File Offset: 0x00317C49
		// (set) Token: 0x06015756 RID: 87894 RVA: 0x00319A51 File Offset: 0x00317C51
		public object Value { get; set; }

		// Token: 0x06015757 RID: 87895 RVA: 0x00319A5A File Offset: 0x00317C5A
		public TTriggerTipShapeUnion()
		{
			this.Type = TTriggerTipShape.NONE;
			this.Value = null;
		}

		// Token: 0x06015758 RID: 87896 RVA: 0x00319A70 File Offset: 0x00317C70
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06015759 RID: 87897 RVA: 0x00319A82 File Offset: 0x00317C82
		public IBoxTriggerTipShapeT AsIBoxTriggerTipShape()
		{
			return this.As<IBoxTriggerTipShapeT>();
		}

		// Token: 0x0601575A RID: 87898 RVA: 0x00319A8A File Offset: 0x00317C8A
		public static TTriggerTipShapeUnion FromIBoxTriggerTipShape(IBoxTriggerTipShapeT _iboxtriggertipshape)
		{
			return new TTriggerTipShapeUnion
			{
				Type = TTriggerTipShape.IBoxTriggerTipShape,
				Value = _iboxtriggertipshape
			};
		}

		// Token: 0x0601575B RID: 87899 RVA: 0x00319A9F File Offset: 0x00317C9F
		public ISphereTriggerTipShapeT AsISphereTriggerTipShape()
		{
			return this.As<ISphereTriggerTipShapeT>();
		}

		// Token: 0x0601575C RID: 87900 RVA: 0x00319AA7 File Offset: 0x00317CA7
		public static TTriggerTipShapeUnion FromISphereTriggerTipShape(ISphereTriggerTipShapeT _ispheretriggertipshape)
		{
			return new TTriggerTipShapeUnion
			{
				Type = TTriggerTipShape.ISphereTriggerTipShape,
				Value = _ispheretriggertipshape
			};
		}

		// Token: 0x0601575D RID: 87901 RVA: 0x00319ABC File Offset: 0x00317CBC
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
