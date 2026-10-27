using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02003C83 RID: 15491
	public class TTipsActorTransformResultUnion
	{
		// Token: 0x17006AC6 RID: 27334
		// (get) Token: 0x06015729 RID: 87849 RVA: 0x003195E6 File Offset: 0x003177E6
		// (set) Token: 0x0601572A RID: 87850 RVA: 0x003195EE File Offset: 0x003177EE
		public TTipsActorTransformResult Type { get; set; }

		// Token: 0x17006AC7 RID: 27335
		// (get) Token: 0x0601572B RID: 87851 RVA: 0x003195F7 File Offset: 0x003177F7
		// (set) Token: 0x0601572C RID: 87852 RVA: 0x003195FF File Offset: 0x003177FF
		public object Value { get; set; }

		// Token: 0x0601572D RID: 87853 RVA: 0x00319608 File Offset: 0x00317808
		public TTipsActorTransformResultUnion()
		{
			this.Type = TTipsActorTransformResult.NONE;
			this.Value = null;
		}

		// Token: 0x0601572E RID: 87854 RVA: 0x0031961E File Offset: 0x0031781E
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601572F RID: 87855 RVA: 0x00319630 File Offset: 0x00317830
		public IAbsoluteTipsActorTransformResultT AsIAbsoluteTipsActorTransformResult()
		{
			return this.As<IAbsoluteTipsActorTransformResultT>();
		}

		// Token: 0x06015730 RID: 87856 RVA: 0x00319638 File Offset: 0x00317838
		public static TTipsActorTransformResultUnion FromIAbsoluteTipsActorTransformResult(IAbsoluteTipsActorTransformResultT _iabsolutetipsactortransformresult)
		{
			return new TTipsActorTransformResultUnion
			{
				Type = TTipsActorTransformResult.IAbsoluteTipsActorTransformResult,
				Value = _iabsolutetipsactortransformresult
			};
		}

		// Token: 0x06015731 RID: 87857 RVA: 0x0031964D File Offset: 0x0031784D
		public IRelativeTipsActorTransformResultT AsIRelativeTipsActorTransformResult()
		{
			return this.As<IRelativeTipsActorTransformResultT>();
		}

		// Token: 0x06015732 RID: 87858 RVA: 0x00319655 File Offset: 0x00317855
		public static TTipsActorTransformResultUnion FromIRelativeTipsActorTransformResult(IRelativeTipsActorTransformResultT _irelativetipsactortransformresult)
		{
			return new TTipsActorTransformResultUnion
			{
				Type = TTipsActorTransformResult.IRelativeTipsActorTransformResult,
				Value = _irelativetipsactortransformresult
			};
		}

		// Token: 0x06015733 RID: 87859 RVA: 0x0031966C File Offset: 0x0031786C
		public static int Pack(FlatBufferBuilder builder, TTipsActorTransformResultUnion _o)
		{
			TTipsActorTransformResult type = _o.Type;
			if (type == TTipsActorTransformResult.IAbsoluteTipsActorTransformResult)
			{
				return IAbsoluteTipsActorTransformResult.Pack(builder, _o.AsIAbsoluteTipsActorTransformResult()).Value;
			}
			if (type != TTipsActorTransformResult.IRelativeTipsActorTransformResult)
			{
				return 0;
			}
			return IRelativeTipsActorTransformResult.Pack(builder, _o.AsIRelativeTipsActorTransformResult()).Value;
		}
	}
}
