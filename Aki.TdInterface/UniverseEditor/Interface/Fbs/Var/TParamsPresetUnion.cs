using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003F59 RID: 16217
	public class TParamsPresetUnion
	{
		// Token: 0x17006DBE RID: 28094
		// (get) Token: 0x060160EB RID: 90347 RVA: 0x0032AA62 File Offset: 0x00328C62
		// (set) Token: 0x060160EC RID: 90348 RVA: 0x0032AA6A File Offset: 0x00328C6A
		public TParamsPreset Type { get; set; }

		// Token: 0x17006DBF RID: 28095
		// (get) Token: 0x060160ED RID: 90349 RVA: 0x0032AA73 File Offset: 0x00328C73
		// (set) Token: 0x060160EE RID: 90350 RVA: 0x0032AA7B File Offset: 0x00328C7B
		public object Value { get; set; }

		// Token: 0x060160EF RID: 90351 RVA: 0x0032AA84 File Offset: 0x00328C84
		public TParamsPresetUnion()
		{
			this.Type = TParamsPreset.NONE;
			this.Value = null;
		}

		// Token: 0x060160F0 RID: 90352 RVA: 0x0032AA9A File Offset: 0x00328C9A
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060160F1 RID: 90353 RVA: 0x0032AAAC File Offset: 0x00328CAC
		public IDecalParamsT AsIDecalParams()
		{
			return this.As<IDecalParamsT>();
		}

		// Token: 0x060160F2 RID: 90354 RVA: 0x0032AAB4 File Offset: 0x00328CB4
		public static TParamsPresetUnion FromIDecalParams(IDecalParamsT _idecalparams)
		{
			return new TParamsPresetUnion
			{
				Type = TParamsPreset.IDecalParams,
				Value = _idecalparams
			};
		}

		// Token: 0x060160F3 RID: 90355 RVA: 0x0032AAC9 File Offset: 0x00328CC9
		public IEnergyFishParamsT AsIEnergyFishParams()
		{
			return this.As<IEnergyFishParamsT>();
		}

		// Token: 0x060160F4 RID: 90356 RVA: 0x0032AAD1 File Offset: 0x00328CD1
		public static TParamsPresetUnion FromIEnergyFishParams(IEnergyFishParamsT _ienergyfishparams)
		{
			return new TParamsPresetUnion
			{
				Type = TParamsPreset.IEnergyFishParams,
				Value = _ienergyfishparams
			};
		}

		// Token: 0x060160F5 RID: 90357 RVA: 0x0032AAE6 File Offset: 0x00328CE6
		public IFireBoxLampParamsT AsIFireBoxLampParams()
		{
			return this.As<IFireBoxLampParamsT>();
		}

		// Token: 0x060160F6 RID: 90358 RVA: 0x0032AAEE File Offset: 0x00328CEE
		public static TParamsPresetUnion FromIFireBoxLampParams(IFireBoxLampParamsT _ifireboxlampparams)
		{
			return new TParamsPresetUnion
			{
				Type = TParamsPreset.IFireBoxLampParams,
				Value = _ifireboxlampparams
			};
		}

		// Token: 0x060160F7 RID: 90359 RVA: 0x0032AB03 File Offset: 0x00328D03
		public IFishParamsT AsIFishParams()
		{
			return this.As<IFishParamsT>();
		}

		// Token: 0x060160F8 RID: 90360 RVA: 0x0032AB0B File Offset: 0x00328D0B
		public static TParamsPresetUnion FromIFishParams(IFishParamsT _ifishparams)
		{
			return new TParamsPresetUnion
			{
				Type = TParamsPreset.IFishParams,
				Value = _ifishparams
			};
		}

		// Token: 0x060160F9 RID: 90361 RVA: 0x0032AB20 File Offset: 0x00328D20
		public ILightPlateParamsT AsILightPlateParams()
		{
			return this.As<ILightPlateParamsT>();
		}

		// Token: 0x060160FA RID: 90362 RVA: 0x0032AB28 File Offset: 0x00328D28
		public static TParamsPresetUnion FromILightPlateParams(ILightPlateParamsT _ilightplateparams)
		{
			return new TParamsPresetUnion
			{
				Type = TParamsPreset.ILightPlateParams,
				Value = _ilightplateparams
			};
		}

		// Token: 0x060160FB RID: 90363 RVA: 0x0032AB3D File Offset: 0x00328D3D
		public IRushWarningEffectParamsT AsIRushWarningEffectParams()
		{
			return this.As<IRushWarningEffectParamsT>();
		}

		// Token: 0x060160FC RID: 90364 RVA: 0x0032AB45 File Offset: 0x00328D45
		public static TParamsPresetUnion FromIRushWarningEffectParams(IRushWarningEffectParamsT _irushwarningeffectparams)
		{
			return new TParamsPresetUnion
			{
				Type = TParamsPreset.IRushWarningEffectParams,
				Value = _irushwarningeffectparams
			};
		}

		// Token: 0x060160FD RID: 90365 RVA: 0x0032AB5A File Offset: 0x00328D5A
		public IScoreDisplayMaterialParamsT AsIScoreDisplayMaterialParams()
		{
			return this.As<IScoreDisplayMaterialParamsT>();
		}

		// Token: 0x060160FE RID: 90366 RVA: 0x0032AB62 File Offset: 0x00328D62
		public static TParamsPresetUnion FromIScoreDisplayMaterialParams(IScoreDisplayMaterialParamsT _iscoredisplaymaterialparams)
		{
			return new TParamsPresetUnion
			{
				Type = TParamsPreset.IScoreDisplayMaterialParams,
				Value = _iscoredisplaymaterialparams
			};
		}

		// Token: 0x060160FF RID: 90367 RVA: 0x0032AB77 File Offset: 0x00328D77
		public ITimeDisplayMaterialParamsT AsITimeDisplayMaterialParams()
		{
			return this.As<ITimeDisplayMaterialParamsT>();
		}

		// Token: 0x06016100 RID: 90368 RVA: 0x0032AB7F File Offset: 0x00328D7F
		public static TParamsPresetUnion FromITimeDisplayMaterialParams(ITimeDisplayMaterialParamsT _itimedisplaymaterialparams)
		{
			return new TParamsPresetUnion
			{
				Type = TParamsPreset.ITimeDisplayMaterialParams,
				Value = _itimedisplaymaterialparams
			};
		}

		// Token: 0x06016101 RID: 90369 RVA: 0x0032AB94 File Offset: 0x00328D94
		public IWoodenBoxProliferateParamsT AsIWoodenBoxProliferateParams()
		{
			return this.As<IWoodenBoxProliferateParamsT>();
		}

		// Token: 0x06016102 RID: 90370 RVA: 0x0032AB9C File Offset: 0x00328D9C
		public static TParamsPresetUnion FromIWoodenBoxProliferateParams(IWoodenBoxProliferateParamsT _iwoodenboxproliferateparams)
		{
			return new TParamsPresetUnion
			{
				Type = TParamsPreset.IWoodenBoxProliferateParams,
				Value = _iwoodenboxproliferateparams
			};
		}

		// Token: 0x06016103 RID: 90371 RVA: 0x0032ABB4 File Offset: 0x00328DB4
		public static int Pack(FlatBufferBuilder builder, TParamsPresetUnion _o)
		{
			switch (_o.Type)
			{
			case TParamsPreset.IDecalParams:
				return IDecalParams.Pack(builder, _o.AsIDecalParams()).Value;
			case TParamsPreset.IEnergyFishParams:
				return IEnergyFishParams.Pack(builder, _o.AsIEnergyFishParams()).Value;
			case TParamsPreset.IFireBoxLampParams:
				return IFireBoxLampParams.Pack(builder, _o.AsIFireBoxLampParams()).Value;
			case TParamsPreset.IFishParams:
				return IFishParams.Pack(builder, _o.AsIFishParams()).Value;
			case TParamsPreset.ILightPlateParams:
				return ILightPlateParams.Pack(builder, _o.AsILightPlateParams()).Value;
			case TParamsPreset.IRushWarningEffectParams:
				return IRushWarningEffectParams.Pack(builder, _o.AsIRushWarningEffectParams()).Value;
			case TParamsPreset.IScoreDisplayMaterialParams:
				return IScoreDisplayMaterialParams.Pack(builder, _o.AsIScoreDisplayMaterialParams()).Value;
			case TParamsPreset.ITimeDisplayMaterialParams:
				return ITimeDisplayMaterialParams.Pack(builder, _o.AsITimeDisplayMaterialParams()).Value;
			case TParamsPreset.IWoodenBoxProliferateParams:
				return IWoodenBoxProliferateParams.Pack(builder, _o.AsIWoodenBoxProliferateParams()).Value;
			default:
				return 0;
			}
		}
	}
}
