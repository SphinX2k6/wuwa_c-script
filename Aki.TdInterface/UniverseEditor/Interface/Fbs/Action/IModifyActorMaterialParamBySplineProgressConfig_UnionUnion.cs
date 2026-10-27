using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006AB0 RID: 27312
	public class IModifyActorMaterialParamBySplineProgressConfig_UnionUnion
	{
		// Token: 0x1700CAAA RID: 51882
		// (get) Token: 0x0602FDC2 RID: 196034 RVA: 0x00682C32 File Offset: 0x00680E32
		// (set) Token: 0x0602FDC3 RID: 196035 RVA: 0x00682C3A File Offset: 0x00680E3A
		public IModifyActorMaterialParamBySplineProgressConfig_Union Type { get; set; }

		// Token: 0x1700CAAB RID: 51883
		// (get) Token: 0x0602FDC4 RID: 196036 RVA: 0x00682C43 File Offset: 0x00680E43
		// (set) Token: 0x0602FDC5 RID: 196037 RVA: 0x00682C4B File Offset: 0x00680E4B
		public object Value { get; set; }

		// Token: 0x0602FDC6 RID: 196038 RVA: 0x00682C54 File Offset: 0x00680E54
		public IModifyActorMaterialParamBySplineProgressConfig_UnionUnion()
		{
			this.Type = IModifyActorMaterialParamBySplineProgressConfig_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602FDC7 RID: 196039 RVA: 0x00682C6A File Offset: 0x00680E6A
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602FDC8 RID: 196040 RVA: 0x00682C7C File Offset: 0x00680E7C
		public IModifyActorMaterialParamBySplineProgressConfigT AsIModifyActorMaterialParamBySplineProgressConfig()
		{
			return this.As<IModifyActorMaterialParamBySplineProgressConfigT>();
		}

		// Token: 0x0602FDC9 RID: 196041 RVA: 0x00682C84 File Offset: 0x00680E84
		public static IModifyActorMaterialParamBySplineProgressConfig_UnionUnion FromIModifyActorMaterialParamBySplineProgressConfig(IModifyActorMaterialParamBySplineProgressConfigT _imodifyactormaterialparambysplineprogressconfig)
		{
			return new IModifyActorMaterialParamBySplineProgressConfig_UnionUnion
			{
				Type = IModifyActorMaterialParamBySplineProgressConfig_Union.IModifyActorMaterialParamBySplineProgressConfig,
				Value = _imodifyactormaterialparambysplineprogressconfig
			};
		}

		// Token: 0x0602FDCA RID: 196042 RVA: 0x00682C99 File Offset: 0x00680E99
		public IModifyActorMaterialParamBySplineProgressEnterSplineT AsIModifyActorMaterialParamBySplineProgressEnterSpline()
		{
			return this.As<IModifyActorMaterialParamBySplineProgressEnterSplineT>();
		}

		// Token: 0x0602FDCB RID: 196043 RVA: 0x00682CA1 File Offset: 0x00680EA1
		public static IModifyActorMaterialParamBySplineProgressConfig_UnionUnion FromIModifyActorMaterialParamBySplineProgressEnterSpline(IModifyActorMaterialParamBySplineProgressEnterSplineT _imodifyactormaterialparambysplineprogressenterspline)
		{
			return new IModifyActorMaterialParamBySplineProgressConfig_UnionUnion
			{
				Type = IModifyActorMaterialParamBySplineProgressConfig_Union.IModifyActorMaterialParamBySplineProgressEnterSpline,
				Value = _imodifyactormaterialparambysplineprogressenterspline
			};
		}

		// Token: 0x0602FDCC RID: 196044 RVA: 0x00682CB6 File Offset: 0x00680EB6
		public IModifyActorMaterialParamBySplineProgressExitSplineT AsIModifyActorMaterialParamBySplineProgressExitSpline()
		{
			return this.As<IModifyActorMaterialParamBySplineProgressExitSplineT>();
		}

		// Token: 0x0602FDCD RID: 196045 RVA: 0x00682CBE File Offset: 0x00680EBE
		public static IModifyActorMaterialParamBySplineProgressConfig_UnionUnion FromIModifyActorMaterialParamBySplineProgressExitSpline(IModifyActorMaterialParamBySplineProgressExitSplineT _imodifyactormaterialparambysplineprogressexitspline)
		{
			return new IModifyActorMaterialParamBySplineProgressConfig_UnionUnion
			{
				Type = IModifyActorMaterialParamBySplineProgressConfig_Union.IModifyActorMaterialParamBySplineProgressExitSpline,
				Value = _imodifyactormaterialparambysplineprogressexitspline
			};
		}

		// Token: 0x0602FDCE RID: 196046 RVA: 0x00682CD4 File Offset: 0x00680ED4
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
