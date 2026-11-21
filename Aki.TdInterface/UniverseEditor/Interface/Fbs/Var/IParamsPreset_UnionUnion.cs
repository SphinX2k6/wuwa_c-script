using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003EB1 RID: 16049
	public class IParamsPreset_UnionUnion
	{
		// Token: 0x17006C9D RID: 27805
		// (get) Token: 0x06015B3A RID: 88890 RVA: 0x0031FE95 File Offset: 0x0031E095
		// (set) Token: 0x06015B3B RID: 88891 RVA: 0x0031FE9D File Offset: 0x0031E09D
		public IParamsPreset_Union Type { get; set; }

		// Token: 0x17006C9E RID: 27806
		// (get) Token: 0x06015B3C RID: 88892 RVA: 0x0031FEA6 File Offset: 0x0031E0A6
		// (set) Token: 0x06015B3D RID: 88893 RVA: 0x0031FEAE File Offset: 0x0031E0AE
		public object Value { get; set; }

		// Token: 0x06015B3E RID: 88894 RVA: 0x0031FEB7 File Offset: 0x0031E0B7
		public IParamsPreset_UnionUnion()
		{
			this.Type = IParamsPreset_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06015B3F RID: 88895 RVA: 0x0031FECD File Offset: 0x0031E0CD
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06015B40 RID: 88896 RVA: 0x0031FEDF File Offset: 0x0031E0DF
		public IParamsPresetT AsIParamsPreset()
		{
			return this.As<IParamsPresetT>();
		}

		// Token: 0x06015B41 RID: 88897 RVA: 0x0031FEE7 File Offset: 0x0031E0E7
		public static IParamsPreset_UnionUnion FromIParamsPreset(IParamsPresetT _iparamspreset)
		{
			return new IParamsPreset_UnionUnion
			{
				Type = IParamsPreset_Union.IParamsPreset,
				Value = _iparamspreset
			};
		}

		// Token: 0x06015B42 RID: 88898 RVA: 0x0031FEFC File Offset: 0x0031E0FC
		public IDecalParamsT AsIDecalParams()
		{
			return this.As<IDecalParamsT>();
		}

		// Token: 0x06015B43 RID: 88899 RVA: 0x0031FF04 File Offset: 0x0031E104
		public static IParamsPreset_UnionUnion FromIDecalParams(IDecalParamsT _idecalparams)
		{
			return new IParamsPreset_UnionUnion
			{
				Type = IParamsPreset_Union.IDecalParams,
				Value = _idecalparams
			};
		}

		// Token: 0x06015B44 RID: 88900 RVA: 0x0031FF19 File Offset: 0x0031E119
		public IRushWarningEffectParamsT AsIRushWarningEffectParams()
		{
			return this.As<IRushWarningEffectParamsT>();
		}

		// Token: 0x06015B45 RID: 88901 RVA: 0x0031FF21 File Offset: 0x0031E121
		public static IParamsPreset_UnionUnion FromIRushWarningEffectParams(IRushWarningEffectParamsT _irushwarningeffectparams)
		{
			return new IParamsPreset_UnionUnion
			{
				Type = IParamsPreset_Union.IRushWarningEffectParams,
				Value = _irushwarningeffectparams
			};
		}

		// Token: 0x06015B46 RID: 88902 RVA: 0x0031FF36 File Offset: 0x0031E136
		public ITimeDisplayMaterialParamsT AsITimeDisplayMaterialParams()
		{
			return this.As<ITimeDisplayMaterialParamsT>();
		}

		// Token: 0x06015B47 RID: 88903 RVA: 0x0031FF3E File Offset: 0x0031E13E
		public static IParamsPreset_UnionUnion FromITimeDisplayMaterialParams(ITimeDisplayMaterialParamsT _itimedisplaymaterialparams)
		{
			return new IParamsPreset_UnionUnion
			{
				Type = IParamsPreset_Union.ITimeDisplayMaterialParams,
				Value = _itimedisplaymaterialparams
			};
		}

		// Token: 0x06015B48 RID: 88904 RVA: 0x0031FF53 File Offset: 0x0031E153
		public IScoreDisplayMaterialParamsT AsIScoreDisplayMaterialParams()
		{
			return this.As<IScoreDisplayMaterialParamsT>();
		}

		// Token: 0x06015B49 RID: 88905 RVA: 0x0031FF5B File Offset: 0x0031E15B
		public static IParamsPreset_UnionUnion FromIScoreDisplayMaterialParams(IScoreDisplayMaterialParamsT _iscoredisplaymaterialparams)
		{
			return new IParamsPreset_UnionUnion
			{
				Type = IParamsPreset_Union.IScoreDisplayMaterialParams,
				Value = _iscoredisplaymaterialparams
			};
		}

		// Token: 0x06015B4A RID: 88906 RVA: 0x0031FF70 File Offset: 0x0031E170
		public ILightPlateParamsT AsILightPlateParams()
		{
			return this.As<ILightPlateParamsT>();
		}

		// Token: 0x06015B4B RID: 88907 RVA: 0x0031FF78 File Offset: 0x0031E178
		public static IParamsPreset_UnionUnion FromILightPlateParams(ILightPlateParamsT _ilightplateparams)
		{
			return new IParamsPreset_UnionUnion
			{
				Type = IParamsPreset_Union.ILightPlateParams,
				Value = _ilightplateparams
			};
		}

		// Token: 0x06015B4C RID: 88908 RVA: 0x0031FF8D File Offset: 0x0031E18D
		public IFireBoxLampParamsT AsIFireBoxLampParams()
		{
			return this.As<IFireBoxLampParamsT>();
		}

		// Token: 0x06015B4D RID: 88909 RVA: 0x0031FF95 File Offset: 0x0031E195
		public static IParamsPreset_UnionUnion FromIFireBoxLampParams(IFireBoxLampParamsT _ifireboxlampparams)
		{
			return new IParamsPreset_UnionUnion
			{
				Type = IParamsPreset_Union.IFireBoxLampParams,
				Value = _ifireboxlampparams
			};
		}

		// Token: 0x06015B4E RID: 88910 RVA: 0x0031FFAA File Offset: 0x0031E1AA
		public IWoodenBoxProliferateParamsT AsIWoodenBoxProliferateParams()
		{
			return this.As<IWoodenBoxProliferateParamsT>();
		}

		// Token: 0x06015B4F RID: 88911 RVA: 0x0031FFB2 File Offset: 0x0031E1B2
		public static IParamsPreset_UnionUnion FromIWoodenBoxProliferateParams(IWoodenBoxProliferateParamsT _iwoodenboxproliferateparams)
		{
			return new IParamsPreset_UnionUnion
			{
				Type = IParamsPreset_Union.IWoodenBoxProliferateParams,
				Value = _iwoodenboxproliferateparams
			};
		}

		// Token: 0x06015B50 RID: 88912 RVA: 0x0031FFC7 File Offset: 0x0031E1C7
		public IFishParamsT AsIFishParams()
		{
			return this.As<IFishParamsT>();
		}

		// Token: 0x06015B51 RID: 88913 RVA: 0x0031FFCF File Offset: 0x0031E1CF
		public static IParamsPreset_UnionUnion FromIFishParams(IFishParamsT _ifishparams)
		{
			return new IParamsPreset_UnionUnion
			{
				Type = IParamsPreset_Union.IFishParams,
				Value = _ifishparams
			};
		}

		// Token: 0x06015B52 RID: 88914 RVA: 0x0031FFE5 File Offset: 0x0031E1E5
		public IEnergyFishParamsT AsIEnergyFishParams()
		{
			return this.As<IEnergyFishParamsT>();
		}

		// Token: 0x06015B53 RID: 88915 RVA: 0x0031FFED File Offset: 0x0031E1ED
		public static IParamsPreset_UnionUnion FromIEnergyFishParams(IEnergyFishParamsT _ienergyfishparams)
		{
			return new IParamsPreset_UnionUnion
			{
				Type = IParamsPreset_Union.IEnergyFishParams,
				Value = _ienergyfishparams
			};
		}

		// Token: 0x06015B54 RID: 88916 RVA: 0x00320004 File Offset: 0x0031E204
		public static int Pack(FlatBufferBuilder builder, IParamsPreset_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IParamsPreset_Union.IParamsPreset:
				return IParamsPreset.Pack(builder, _o.AsIParamsPreset()).Value;
			case IParamsPreset_Union.IDecalParams:
				return IDecalParams.Pack(builder, _o.AsIDecalParams()).Value;
			case IParamsPreset_Union.IRushWarningEffectParams:
				return IRushWarningEffectParams.Pack(builder, _o.AsIRushWarningEffectParams()).Value;
			case IParamsPreset_Union.ITimeDisplayMaterialParams:
				return ITimeDisplayMaterialParams.Pack(builder, _o.AsITimeDisplayMaterialParams()).Value;
			case IParamsPreset_Union.IScoreDisplayMaterialParams:
				return IScoreDisplayMaterialParams.Pack(builder, _o.AsIScoreDisplayMaterialParams()).Value;
			case IParamsPreset_Union.ILightPlateParams:
				return ILightPlateParams.Pack(builder, _o.AsILightPlateParams()).Value;
			case IParamsPreset_Union.IFireBoxLampParams:
				return IFireBoxLampParams.Pack(builder, _o.AsIFireBoxLampParams()).Value;
			case IParamsPreset_Union.IWoodenBoxProliferateParams:
				return IWoodenBoxProliferateParams.Pack(builder, _o.AsIWoodenBoxProliferateParams()).Value;
			case IParamsPreset_Union.IFishParams:
				return IFishParams.Pack(builder, _o.AsIFishParams()).Value;
			case IParamsPreset_Union.IEnergyFishParams:
				return IEnergyFishParams.Pack(builder, _o.AsIEnergyFishParams()).Value;
			default:
				return 0;
			}
		}
	}
}
