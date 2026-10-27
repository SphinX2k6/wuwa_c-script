using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003AAF RID: 15023
	public class IParamsPreset_UnionUnion
	{
		// Token: 0x17006702 RID: 26370
		// (get) Token: 0x06014694 RID: 83604 RVA: 0x002F9C89 File Offset: 0x002F7E89
		// (set) Token: 0x06014695 RID: 83605 RVA: 0x002F9C91 File Offset: 0x002F7E91
		public IParamsPreset_Union Type { get; set; }

		// Token: 0x17006703 RID: 26371
		// (get) Token: 0x06014696 RID: 83606 RVA: 0x002F9C9A File Offset: 0x002F7E9A
		// (set) Token: 0x06014697 RID: 83607 RVA: 0x002F9CA2 File Offset: 0x002F7EA2
		public object Value { get; set; }

		// Token: 0x06014698 RID: 83608 RVA: 0x002F9CAB File Offset: 0x002F7EAB
		public IParamsPreset_UnionUnion()
		{
			this.Type = IParamsPreset_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06014699 RID: 83609 RVA: 0x002F9CC1 File Offset: 0x002F7EC1
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601469A RID: 83610 RVA: 0x002F9CD3 File Offset: 0x002F7ED3
		public IParamsPresetT AsIParamsPreset()
		{
			return this.As<IParamsPresetT>();
		}

		// Token: 0x0601469B RID: 83611 RVA: 0x002F9CDB File Offset: 0x002F7EDB
		public static IParamsPreset_UnionUnion FromIParamsPreset(IParamsPresetT _iparamspreset)
		{
			return new IParamsPreset_UnionUnion
			{
				Type = IParamsPreset_Union.IParamsPreset,
				Value = _iparamspreset
			};
		}

		// Token: 0x0601469C RID: 83612 RVA: 0x002F9CF0 File Offset: 0x002F7EF0
		public IDecalParamsT AsIDecalParams()
		{
			return this.As<IDecalParamsT>();
		}

		// Token: 0x0601469D RID: 83613 RVA: 0x002F9CF8 File Offset: 0x002F7EF8
		public static IParamsPreset_UnionUnion FromIDecalParams(IDecalParamsT _idecalparams)
		{
			return new IParamsPreset_UnionUnion
			{
				Type = IParamsPreset_Union.IDecalParams,
				Value = _idecalparams
			};
		}

		// Token: 0x0601469E RID: 83614 RVA: 0x002F9D0D File Offset: 0x002F7F0D
		public IRushWarningEffectParamsT AsIRushWarningEffectParams()
		{
			return this.As<IRushWarningEffectParamsT>();
		}

		// Token: 0x0601469F RID: 83615 RVA: 0x002F9D15 File Offset: 0x002F7F15
		public static IParamsPreset_UnionUnion FromIRushWarningEffectParams(IRushWarningEffectParamsT _irushwarningeffectparams)
		{
			return new IParamsPreset_UnionUnion
			{
				Type = IParamsPreset_Union.IRushWarningEffectParams,
				Value = _irushwarningeffectparams
			};
		}

		// Token: 0x060146A0 RID: 83616 RVA: 0x002F9D2A File Offset: 0x002F7F2A
		public ITimeDisplayMaterialParamsT AsITimeDisplayMaterialParams()
		{
			return this.As<ITimeDisplayMaterialParamsT>();
		}

		// Token: 0x060146A1 RID: 83617 RVA: 0x002F9D32 File Offset: 0x002F7F32
		public static IParamsPreset_UnionUnion FromITimeDisplayMaterialParams(ITimeDisplayMaterialParamsT _itimedisplaymaterialparams)
		{
			return new IParamsPreset_UnionUnion
			{
				Type = IParamsPreset_Union.ITimeDisplayMaterialParams,
				Value = _itimedisplaymaterialparams
			};
		}

		// Token: 0x060146A2 RID: 83618 RVA: 0x002F9D47 File Offset: 0x002F7F47
		public IScoreDisplayMaterialParamsT AsIScoreDisplayMaterialParams()
		{
			return this.As<IScoreDisplayMaterialParamsT>();
		}

		// Token: 0x060146A3 RID: 83619 RVA: 0x002F9D4F File Offset: 0x002F7F4F
		public static IParamsPreset_UnionUnion FromIScoreDisplayMaterialParams(IScoreDisplayMaterialParamsT _iscoredisplaymaterialparams)
		{
			return new IParamsPreset_UnionUnion
			{
				Type = IParamsPreset_Union.IScoreDisplayMaterialParams,
				Value = _iscoredisplaymaterialparams
			};
		}

		// Token: 0x060146A4 RID: 83620 RVA: 0x002F9D64 File Offset: 0x002F7F64
		public ILightPlateParamsT AsILightPlateParams()
		{
			return this.As<ILightPlateParamsT>();
		}

		// Token: 0x060146A5 RID: 83621 RVA: 0x002F9D6C File Offset: 0x002F7F6C
		public static IParamsPreset_UnionUnion FromILightPlateParams(ILightPlateParamsT _ilightplateparams)
		{
			return new IParamsPreset_UnionUnion
			{
				Type = IParamsPreset_Union.ILightPlateParams,
				Value = _ilightplateparams
			};
		}

		// Token: 0x060146A6 RID: 83622 RVA: 0x002F9D81 File Offset: 0x002F7F81
		public IFireBoxLampParamsT AsIFireBoxLampParams()
		{
			return this.As<IFireBoxLampParamsT>();
		}

		// Token: 0x060146A7 RID: 83623 RVA: 0x002F9D89 File Offset: 0x002F7F89
		public static IParamsPreset_UnionUnion FromIFireBoxLampParams(IFireBoxLampParamsT _ifireboxlampparams)
		{
			return new IParamsPreset_UnionUnion
			{
				Type = IParamsPreset_Union.IFireBoxLampParams,
				Value = _ifireboxlampparams
			};
		}

		// Token: 0x060146A8 RID: 83624 RVA: 0x002F9D9E File Offset: 0x002F7F9E
		public IWoodenBoxProliferateParamsT AsIWoodenBoxProliferateParams()
		{
			return this.As<IWoodenBoxProliferateParamsT>();
		}

		// Token: 0x060146A9 RID: 83625 RVA: 0x002F9DA6 File Offset: 0x002F7FA6
		public static IParamsPreset_UnionUnion FromIWoodenBoxProliferateParams(IWoodenBoxProliferateParamsT _iwoodenboxproliferateparams)
		{
			return new IParamsPreset_UnionUnion
			{
				Type = IParamsPreset_Union.IWoodenBoxProliferateParams,
				Value = _iwoodenboxproliferateparams
			};
		}

		// Token: 0x060146AA RID: 83626 RVA: 0x002F9DBC File Offset: 0x002F7FBC
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
			default:
				return 0;
			}
		}
	}
}
