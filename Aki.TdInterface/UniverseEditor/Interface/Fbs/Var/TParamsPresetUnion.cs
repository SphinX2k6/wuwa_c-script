using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003B51 RID: 15185
	public class TParamsPresetUnion
	{
		// Token: 0x1700681F RID: 26655
		// (get) Token: 0x06014C25 RID: 85029 RVA: 0x0030454C File Offset: 0x0030274C
		// (set) Token: 0x06014C26 RID: 85030 RVA: 0x00304554 File Offset: 0x00302754
		public TParamsPreset Type { get; set; }

		// Token: 0x17006820 RID: 26656
		// (get) Token: 0x06014C27 RID: 85031 RVA: 0x0030455D File Offset: 0x0030275D
		// (set) Token: 0x06014C28 RID: 85032 RVA: 0x00304565 File Offset: 0x00302765
		public object Value { get; set; }

		// Token: 0x06014C29 RID: 85033 RVA: 0x0030456E File Offset: 0x0030276E
		public TParamsPresetUnion()
		{
			this.Type = TParamsPreset.NONE;
			this.Value = null;
		}

		// Token: 0x06014C2A RID: 85034 RVA: 0x00304584 File Offset: 0x00302784
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06014C2B RID: 85035 RVA: 0x00304596 File Offset: 0x00302796
		public IDecalParamsT AsIDecalParams()
		{
			return this.As<IDecalParamsT>();
		}

		// Token: 0x06014C2C RID: 85036 RVA: 0x0030459E File Offset: 0x0030279E
		public static TParamsPresetUnion FromIDecalParams(IDecalParamsT _idecalparams)
		{
			return new TParamsPresetUnion
			{
				Type = TParamsPreset.IDecalParams,
				Value = _idecalparams
			};
		}

		// Token: 0x06014C2D RID: 85037 RVA: 0x003045B3 File Offset: 0x003027B3
		public IFireBoxLampParamsT AsIFireBoxLampParams()
		{
			return this.As<IFireBoxLampParamsT>();
		}

		// Token: 0x06014C2E RID: 85038 RVA: 0x003045BB File Offset: 0x003027BB
		public static TParamsPresetUnion FromIFireBoxLampParams(IFireBoxLampParamsT _ifireboxlampparams)
		{
			return new TParamsPresetUnion
			{
				Type = TParamsPreset.IFireBoxLampParams,
				Value = _ifireboxlampparams
			};
		}

		// Token: 0x06014C2F RID: 85039 RVA: 0x003045D0 File Offset: 0x003027D0
		public ILightPlateParamsT AsILightPlateParams()
		{
			return this.As<ILightPlateParamsT>();
		}

		// Token: 0x06014C30 RID: 85040 RVA: 0x003045D8 File Offset: 0x003027D8
		public static TParamsPresetUnion FromILightPlateParams(ILightPlateParamsT _ilightplateparams)
		{
			return new TParamsPresetUnion
			{
				Type = TParamsPreset.ILightPlateParams,
				Value = _ilightplateparams
			};
		}

		// Token: 0x06014C31 RID: 85041 RVA: 0x003045ED File Offset: 0x003027ED
		public IRushWarningEffectParamsT AsIRushWarningEffectParams()
		{
			return this.As<IRushWarningEffectParamsT>();
		}

		// Token: 0x06014C32 RID: 85042 RVA: 0x003045F5 File Offset: 0x003027F5
		public static TParamsPresetUnion FromIRushWarningEffectParams(IRushWarningEffectParamsT _irushwarningeffectparams)
		{
			return new TParamsPresetUnion
			{
				Type = TParamsPreset.IRushWarningEffectParams,
				Value = _irushwarningeffectparams
			};
		}

		// Token: 0x06014C33 RID: 85043 RVA: 0x0030460A File Offset: 0x0030280A
		public IScoreDisplayMaterialParamsT AsIScoreDisplayMaterialParams()
		{
			return this.As<IScoreDisplayMaterialParamsT>();
		}

		// Token: 0x06014C34 RID: 85044 RVA: 0x00304612 File Offset: 0x00302812
		public static TParamsPresetUnion FromIScoreDisplayMaterialParams(IScoreDisplayMaterialParamsT _iscoredisplaymaterialparams)
		{
			return new TParamsPresetUnion
			{
				Type = TParamsPreset.IScoreDisplayMaterialParams,
				Value = _iscoredisplaymaterialparams
			};
		}

		// Token: 0x06014C35 RID: 85045 RVA: 0x00304627 File Offset: 0x00302827
		public ITimeDisplayMaterialParamsT AsITimeDisplayMaterialParams()
		{
			return this.As<ITimeDisplayMaterialParamsT>();
		}

		// Token: 0x06014C36 RID: 85046 RVA: 0x0030462F File Offset: 0x0030282F
		public static TParamsPresetUnion FromITimeDisplayMaterialParams(ITimeDisplayMaterialParamsT _itimedisplaymaterialparams)
		{
			return new TParamsPresetUnion
			{
				Type = TParamsPreset.ITimeDisplayMaterialParams,
				Value = _itimedisplaymaterialparams
			};
		}

		// Token: 0x06014C37 RID: 85047 RVA: 0x00304644 File Offset: 0x00302844
		public IWoodenBoxProliferateParamsT AsIWoodenBoxProliferateParams()
		{
			return this.As<IWoodenBoxProliferateParamsT>();
		}

		// Token: 0x06014C38 RID: 85048 RVA: 0x0030464C File Offset: 0x0030284C
		public static TParamsPresetUnion FromIWoodenBoxProliferateParams(IWoodenBoxProliferateParamsT _iwoodenboxproliferateparams)
		{
			return new TParamsPresetUnion
			{
				Type = TParamsPreset.IWoodenBoxProliferateParams,
				Value = _iwoodenboxproliferateparams
			};
		}

		// Token: 0x06014C39 RID: 85049 RVA: 0x00304664 File Offset: 0x00302864
		public static int Pack(FlatBufferBuilder builder, TParamsPresetUnion _o)
		{
			switch (_o.Type)
			{
			case TParamsPreset.IDecalParams:
				return IDecalParams.Pack(builder, _o.AsIDecalParams()).Value;
			case TParamsPreset.IFireBoxLampParams:
				return IFireBoxLampParams.Pack(builder, _o.AsIFireBoxLampParams()).Value;
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
