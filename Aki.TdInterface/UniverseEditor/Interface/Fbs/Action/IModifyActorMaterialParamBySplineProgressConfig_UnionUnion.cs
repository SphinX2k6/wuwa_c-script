using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020071DB RID: 29147
	public class IModifyActorMaterialParamBySplineProgressConfig_UnionUnion
	{
		// Token: 0x1700D564 RID: 54628
		// (get) Token: 0x06032B2E RID: 207662 RVA: 0x006D9478 File Offset: 0x006D7678
		// (set) Token: 0x06032B2F RID: 207663 RVA: 0x006D9480 File Offset: 0x006D7680
		public IModifyActorMaterialParamBySplineProgressConfig_Union Type { get; set; }

		// Token: 0x1700D565 RID: 54629
		// (get) Token: 0x06032B30 RID: 207664 RVA: 0x006D9489 File Offset: 0x006D7689
		// (set) Token: 0x06032B31 RID: 207665 RVA: 0x006D9491 File Offset: 0x006D7691
		public object Value { get; set; }

		// Token: 0x06032B32 RID: 207666 RVA: 0x006D949A File Offset: 0x006D769A
		public IModifyActorMaterialParamBySplineProgressConfig_UnionUnion()
		{
			this.Type = IModifyActorMaterialParamBySplineProgressConfig_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06032B33 RID: 207667 RVA: 0x006D94B0 File Offset: 0x006D76B0
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06032B34 RID: 207668 RVA: 0x006D94C2 File Offset: 0x006D76C2
		public IModifyActorMaterialParamBySplineProgressConfigT AsIModifyActorMaterialParamBySplineProgressConfig()
		{
			return this.As<IModifyActorMaterialParamBySplineProgressConfigT>();
		}

		// Token: 0x06032B35 RID: 207669 RVA: 0x006D94CA File Offset: 0x006D76CA
		public static IModifyActorMaterialParamBySplineProgressConfig_UnionUnion FromIModifyActorMaterialParamBySplineProgressConfig(IModifyActorMaterialParamBySplineProgressConfigT _imodifyactormaterialparambysplineprogressconfig)
		{
			return new IModifyActorMaterialParamBySplineProgressConfig_UnionUnion
			{
				Type = IModifyActorMaterialParamBySplineProgressConfig_Union.IModifyActorMaterialParamBySplineProgressConfig,
				Value = _imodifyactormaterialparambysplineprogressconfig
			};
		}

		// Token: 0x06032B36 RID: 207670 RVA: 0x006D94DF File Offset: 0x006D76DF
		public IModifyActorMaterialParamBySplineProgressEnterSplineT AsIModifyActorMaterialParamBySplineProgressEnterSpline()
		{
			return this.As<IModifyActorMaterialParamBySplineProgressEnterSplineT>();
		}

		// Token: 0x06032B37 RID: 207671 RVA: 0x006D94E7 File Offset: 0x006D76E7
		public static IModifyActorMaterialParamBySplineProgressConfig_UnionUnion FromIModifyActorMaterialParamBySplineProgressEnterSpline(IModifyActorMaterialParamBySplineProgressEnterSplineT _imodifyactormaterialparambysplineprogressenterspline)
		{
			return new IModifyActorMaterialParamBySplineProgressConfig_UnionUnion
			{
				Type = IModifyActorMaterialParamBySplineProgressConfig_Union.IModifyActorMaterialParamBySplineProgressEnterSpline,
				Value = _imodifyactormaterialparambysplineprogressenterspline
			};
		}

		// Token: 0x06032B38 RID: 207672 RVA: 0x006D94FC File Offset: 0x006D76FC
		public IModifyActorMaterialParamBySplineProgressExitSplineT AsIModifyActorMaterialParamBySplineProgressExitSpline()
		{
			return this.As<IModifyActorMaterialParamBySplineProgressExitSplineT>();
		}

		// Token: 0x06032B39 RID: 207673 RVA: 0x006D9504 File Offset: 0x006D7704
		public static IModifyActorMaterialParamBySplineProgressConfig_UnionUnion FromIModifyActorMaterialParamBySplineProgressExitSpline(IModifyActorMaterialParamBySplineProgressExitSplineT _imodifyactormaterialparambysplineprogressexitspline)
		{
			return new IModifyActorMaterialParamBySplineProgressConfig_UnionUnion
			{
				Type = IModifyActorMaterialParamBySplineProgressConfig_Union.IModifyActorMaterialParamBySplineProgressExitSpline,
				Value = _imodifyactormaterialparambysplineprogressexitspline
			};
		}

		// Token: 0x06032B3A RID: 207674 RVA: 0x006D951C File Offset: 0x006D771C
		public static int Pack(FlatBufferBuilder builder, IModifyActorMaterialParamBySplineProgressConfig_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IModifyActorMaterialParamBySplineProgressConfig_Union.IModifyActorMaterialParamBySplineProgressConfig:
				return IModifyActorMaterialParamBySplineProgressConfig.Pack(builder, _o.AsIModifyActorMaterialParamBySplineProgressConfig()).Value;
			case IModifyActorMaterialParamBySplineProgressConfig_Union.IModifyActorMaterialParamBySplineProgressEnterSpline:
				return IModifyActorMaterialParamBySplineProgressEnterSpline.Pack(builder, _o.AsIModifyActorMaterialParamBySplineProgressEnterSpline()).Value;
			case IModifyActorMaterialParamBySplineProgressConfig_Union.IModifyActorMaterialParamBySplineProgressExitSpline:
				return IModifyActorMaterialParamBySplineProgressExitSpline.Pack(builder, _o.AsIModifyActorMaterialParamBySplineProgressExitSpline()).Value;
			default:
				return 0;
			}
		}
	}
}
