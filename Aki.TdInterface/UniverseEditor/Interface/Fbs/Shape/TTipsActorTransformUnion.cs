using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02004092 RID: 16530
	public class TTipsActorTransformUnion
	{
		// Token: 0x1700707E RID: 28798
		// (get) Token: 0x06016C55 RID: 93269 RVA: 0x00340761 File Offset: 0x0033E961
		// (set) Token: 0x06016C56 RID: 93270 RVA: 0x00340769 File Offset: 0x0033E969
		public TTipsActorTransform Type { get; set; }

		// Token: 0x1700707F RID: 28799
		// (get) Token: 0x06016C57 RID: 93271 RVA: 0x00340772 File Offset: 0x0033E972
		// (set) Token: 0x06016C58 RID: 93272 RVA: 0x0034077A File Offset: 0x0033E97A
		public object Value { get; set; }

		// Token: 0x06016C59 RID: 93273 RVA: 0x00340783 File Offset: 0x0033E983
		public TTipsActorTransformUnion()
		{
			this.Type = TTipsActorTransform.NONE;
			this.Value = null;
		}

		// Token: 0x06016C5A RID: 93274 RVA: 0x00340799 File Offset: 0x0033E999
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06016C5B RID: 93275 RVA: 0x003407AB File Offset: 0x0033E9AB
		public IAbsoluteTipActorTransformT AsIAbsoluteTipActorTransform()
		{
			return this.As<IAbsoluteTipActorTransformT>();
		}

		// Token: 0x06016C5C RID: 93276 RVA: 0x003407B3 File Offset: 0x0033E9B3
		public static TTipsActorTransformUnion FromIAbsoluteTipActorTransform(IAbsoluteTipActorTransformT _iabsolutetipactortransform)
		{
			return new TTipsActorTransformUnion
			{
				Type = TTipsActorTransform.IAbsoluteTipActorTransform,
				Value = _iabsolutetipactortransform
			};
		}

		// Token: 0x06016C5D RID: 93277 RVA: 0x003407C8 File Offset: 0x0033E9C8
		public IRelativeTipActorTransformT AsIRelativeTipActorTransform()
		{
			return this.As<IRelativeTipActorTransformT>();
		}

		// Token: 0x06016C5E RID: 93278 RVA: 0x003407D0 File Offset: 0x0033E9D0
		public static TTipsActorTransformUnion FromIRelativeTipActorTransform(IRelativeTipActorTransformT _irelativetipactortransform)
		{
			return new TTipsActorTransformUnion
			{
				Type = TTipsActorTransform.IRelativeTipActorTransform,
				Value = _irelativetipactortransform
			};
		}

		// Token: 0x06016C5F RID: 93279 RVA: 0x003407E8 File Offset: 0x0033E9E8
		public static int Pack(FlatBufferBuilder builder, TTipsActorTransformUnion _o)
		{
			TTipsActorTransform type = _o.Type;
			if (type == TTipsActorTransform.IAbsoluteTipActorTransform)
			{
				return IAbsoluteTipActorTransform.Pack(builder, _o.AsIAbsoluteTipActorTransform()).Value;
			}
			if (type != TTipsActorTransform.IRelativeTipActorTransform)
			{
				return 0;
			}
			return IRelativeTipActorTransform.Pack(builder, _o.AsIRelativeTipActorTransform()).Value;
		}
	}
}
