using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007F37 RID: 32567
	public class TModifyActorMaterialParamBySplineProgressUnion
	{
		// Token: 0x1700F29D RID: 62109
		// (get) Token: 0x0603ABD5 RID: 240597 RVA: 0x007E6026 File Offset: 0x007E4226
		// (set) Token: 0x0603ABD6 RID: 240598 RVA: 0x007E602E File Offset: 0x007E422E
		public TModifyActorMaterialParamBySplineProgress Type { get; set; }

		// Token: 0x1700F29E RID: 62110
		// (get) Token: 0x0603ABD7 RID: 240599 RVA: 0x007E6037 File Offset: 0x007E4237
		// (set) Token: 0x0603ABD8 RID: 240600 RVA: 0x007E603F File Offset: 0x007E423F
		public object Value { get; set; }

		// Token: 0x0603ABD9 RID: 240601 RVA: 0x007E6048 File Offset: 0x007E4248
		public TModifyActorMaterialParamBySplineProgressUnion()
		{
			this.Type = TModifyActorMaterialParamBySplineProgress.NONE;
			this.Value = null;
		}

		// Token: 0x0603ABDA RID: 240602 RVA: 0x007E605E File Offset: 0x007E425E
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603ABDB RID: 240603 RVA: 0x007E6070 File Offset: 0x007E4270
		public IModifyActorMaterialParamBySplineProgressEnterSplineT AsIModifyActorMaterialParamBySplineProgressEnterSpline()
		{
			return this.As<IModifyActorMaterialParamBySplineProgressEnterSplineT>();
		}

		// Token: 0x0603ABDC RID: 240604 RVA: 0x007E6078 File Offset: 0x007E4278
		public static TModifyActorMaterialParamBySplineProgressUnion FromIModifyActorMaterialParamBySplineProgressEnterSpline(IModifyActorMaterialParamBySplineProgressEnterSplineT _imodifyactormaterialparambysplineprogressenterspline)
		{
			return new TModifyActorMaterialParamBySplineProgressUnion
			{
				Type = TModifyActorMaterialParamBySplineProgress.IModifyActorMaterialParamBySplineProgressEnterSpline,
				Value = _imodifyactormaterialparambysplineprogressenterspline
			};
		}

		// Token: 0x0603ABDD RID: 240605 RVA: 0x007E608D File Offset: 0x007E428D
		public IModifyActorMaterialParamBySplineProgressExitSplineT AsIModifyActorMaterialParamBySplineProgressExitSpline()
		{
			return this.As<IModifyActorMaterialParamBySplineProgressExitSplineT>();
		}

		// Token: 0x0603ABDE RID: 240606 RVA: 0x007E6095 File Offset: 0x007E4295
		public static TModifyActorMaterialParamBySplineProgressUnion FromIModifyActorMaterialParamBySplineProgressExitSpline(IModifyActorMaterialParamBySplineProgressExitSplineT _imodifyactormaterialparambysplineprogressexitspline)
		{
			return new TModifyActorMaterialParamBySplineProgressUnion
			{
				Type = TModifyActorMaterialParamBySplineProgress.IModifyActorMaterialParamBySplineProgressExitSpline,
				Value = _imodifyactormaterialparambysplineprogressexitspline
			};
		}

		// Token: 0x0603ABDF RID: 240607 RVA: 0x007E60AC File Offset: 0x007E42AC
		public static int Pack(FlatBufferBuilder builder, TModifyActorMaterialParamBySplineProgressUnion _o)
		{
			TModifyActorMaterialParamBySplineProgress type = _o.Type;
			if (type == TModifyActorMaterialParamBySplineProgress.IModifyActorMaterialParamBySplineProgressEnterSpline)
			{
				return IModifyActorMaterialParamBySplineProgressEnterSpline.Pack(builder, _o.AsIModifyActorMaterialParamBySplineProgressEnterSpline()).Value;
			}
			if (type != TModifyActorMaterialParamBySplineProgress.IModifyActorMaterialParamBySplineProgressExitSpline)
			{
				return 0;
			}
			return IModifyActorMaterialParamBySplineProgressExitSpline.Pack(builder, _o.AsIModifyActorMaterialParamBySplineProgressExitSpline()).Value;
		}
	}
}
