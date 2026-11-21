using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02004095 RID: 16533
	public class TTipsActorTransformResultUnion
	{
		// Token: 0x17007080 RID: 28800
		// (get) Token: 0x06016C61 RID: 93281 RVA: 0x0034085E File Offset: 0x0033EA5E
		// (set) Token: 0x06016C62 RID: 93282 RVA: 0x00340866 File Offset: 0x0033EA66
		public TTipsActorTransformResult Type { get; set; }

		// Token: 0x17007081 RID: 28801
		// (get) Token: 0x06016C63 RID: 93283 RVA: 0x0034086F File Offset: 0x0033EA6F
		// (set) Token: 0x06016C64 RID: 93284 RVA: 0x00340877 File Offset: 0x0033EA77
		public object Value { get; set; }

		// Token: 0x06016C65 RID: 93285 RVA: 0x00340880 File Offset: 0x0033EA80
		public TTipsActorTransformResultUnion()
		{
			this.Type = TTipsActorTransformResult.NONE;
			this.Value = null;
		}

		// Token: 0x06016C66 RID: 93286 RVA: 0x00340896 File Offset: 0x0033EA96
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06016C67 RID: 93287 RVA: 0x003408A8 File Offset: 0x0033EAA8
		public IAbsoluteTipsActorTransformResultT AsIAbsoluteTipsActorTransformResult()
		{
			return this.As<IAbsoluteTipsActorTransformResultT>();
		}

		// Token: 0x06016C68 RID: 93288 RVA: 0x003408B0 File Offset: 0x0033EAB0
		public static TTipsActorTransformResultUnion FromIAbsoluteTipsActorTransformResult(IAbsoluteTipsActorTransformResultT _iabsolutetipsactortransformresult)
		{
			return new TTipsActorTransformResultUnion
			{
				Type = TTipsActorTransformResult.IAbsoluteTipsActorTransformResult,
				Value = _iabsolutetipsactortransformresult
			};
		}

		// Token: 0x06016C69 RID: 93289 RVA: 0x003408C5 File Offset: 0x0033EAC5
		public IRelativeTipsActorTransformResultT AsIRelativeTipsActorTransformResult()
		{
			return this.As<IRelativeTipsActorTransformResultT>();
		}

		// Token: 0x06016C6A RID: 93290 RVA: 0x003408CD File Offset: 0x0033EACD
		public static TTipsActorTransformResultUnion FromIRelativeTipsActorTransformResult(IRelativeTipsActorTransformResultT _irelativetipsactortransformresult)
		{
			return new TTipsActorTransformResultUnion
			{
				Type = TTipsActorTransformResult.IRelativeTipsActorTransformResult,
				Value = _irelativetipsactortransformresult
			};
		}

		// Token: 0x06016C6B RID: 93291 RVA: 0x003408E4 File Offset: 0x0033EAE4
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
