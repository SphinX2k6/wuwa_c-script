using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02003C80 RID: 15488
	public class TTipsActorTransformUnion
	{
		// Token: 0x17006AC4 RID: 27332
		// (get) Token: 0x0601571D RID: 87837 RVA: 0x003194EB File Offset: 0x003176EB
		// (set) Token: 0x0601571E RID: 87838 RVA: 0x003194F3 File Offset: 0x003176F3
		public TTipsActorTransform Type { get; set; }

		// Token: 0x17006AC5 RID: 27333
		// (get) Token: 0x0601571F RID: 87839 RVA: 0x003194FC File Offset: 0x003176FC
		// (set) Token: 0x06015720 RID: 87840 RVA: 0x00319504 File Offset: 0x00317704
		public object Value { get; set; }

		// Token: 0x06015721 RID: 87841 RVA: 0x0031950D File Offset: 0x0031770D
		public TTipsActorTransformUnion()
		{
			this.Type = TTipsActorTransform.NONE;
			this.Value = null;
		}

		// Token: 0x06015722 RID: 87842 RVA: 0x00319523 File Offset: 0x00317723
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06015723 RID: 87843 RVA: 0x00319535 File Offset: 0x00317735
		public IAbsoluteTipActorTransformT AsIAbsoluteTipActorTransform()
		{
			return this.As<IAbsoluteTipActorTransformT>();
		}

		// Token: 0x06015724 RID: 87844 RVA: 0x0031953D File Offset: 0x0031773D
		public static TTipsActorTransformUnion FromIAbsoluteTipActorTransform(IAbsoluteTipActorTransformT _iabsolutetipactortransform)
		{
			return new TTipsActorTransformUnion
			{
				Type = TTipsActorTransform.IAbsoluteTipActorTransform,
				Value = _iabsolutetipactortransform
			};
		}

		// Token: 0x06015725 RID: 87845 RVA: 0x00319552 File Offset: 0x00317752
		public IRelativeTipActorTransformT AsIRelativeTipActorTransform()
		{
			return this.As<IRelativeTipActorTransformT>();
		}

		// Token: 0x06015726 RID: 87846 RVA: 0x0031955A File Offset: 0x0031775A
		public static TTipsActorTransformUnion FromIRelativeTipActorTransform(IRelativeTipActorTransformT _irelativetipactortransform)
		{
			return new TTipsActorTransformUnion
			{
				Type = TTipsActorTransform.IRelativeTipActorTransform,
				Value = _irelativetipactortransform
			};
		}

		// Token: 0x06015727 RID: 87847 RVA: 0x00319570 File Offset: 0x00317770
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
