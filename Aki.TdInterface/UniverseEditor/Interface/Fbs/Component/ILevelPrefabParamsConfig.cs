using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A6B RID: 23147
	public struct ILevelPrefabParamsConfig : IFlatbufferObject
	{
		// Token: 0x1700A885 RID: 43141
		// (get) Token: 0x06025E48 RID: 155208 RVA: 0x00531C27 File Offset: 0x0052FE27
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06025E49 RID: 155209 RVA: 0x00531C34 File Offset: 0x0052FE34
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06025E4A RID: 155210 RVA: 0x00531C3C File Offset: 0x0052FE3C
		public static ILevelPrefabParamsConfig GetRootAsILevelPrefabParamsConfig(ByteBuffer _bb)
		{
			return ILevelPrefabParamsConfig.GetRootAsILevelPrefabParamsConfig(_bb, default(ILevelPrefabParamsConfig));
		}

		// Token: 0x06025E4B RID: 155211 RVA: 0x00531C58 File Offset: 0x0052FE58
		public static ILevelPrefabParamsConfig GetRootAsILevelPrefabParamsConfig(ByteBuffer _bb, ILevelPrefabParamsConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06025E4C RID: 155212 RVA: 0x00531C75 File Offset: 0x0052FE75
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06025E4D RID: 155213 RVA: 0x00531C84 File Offset: 0x0052FE84
		public ILevelPrefabParamsConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A886 RID: 43142
		// (get) Token: 0x06025E4E RID: 155214 RVA: 0x00531C94 File Offset: 0x0052FE94
		public string ReferenceActorKey
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06025E4F RID: 155215 RVA: 0x00531CCB File Offset: 0x0052FECB
		public Span<byte> GetReferenceActorKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06025E50 RID: 155216 RVA: 0x00531CDA File Offset: 0x0052FEDA
		public byte[] GetReferenceActorKeyArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700A887 RID: 43143
		// (get) Token: 0x06025E51 RID: 155217 RVA: 0x00531CE8 File Offset: 0x0052FEE8
		public TParamsPreset ParamsType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return TParamsPreset.NONE;
				}
				return (TParamsPreset)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06025E52 RID: 155218 RVA: 0x00531D24 File Offset: 0x0052FF24
		public TTable? Params<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06025E53 RID: 155219 RVA: 0x00531D68 File Offset: 0x0052FF68
		public IDecalParams ParamsAsIDecalParams()
		{
			return this.Params<IDecalParams>().Value;
		}

		// Token: 0x06025E54 RID: 155220 RVA: 0x00531D84 File Offset: 0x0052FF84
		public IEnergyFishParams ParamsAsIEnergyFishParams()
		{
			return this.Params<IEnergyFishParams>().Value;
		}

		// Token: 0x06025E55 RID: 155221 RVA: 0x00531DA0 File Offset: 0x0052FFA0
		public IFireBoxLampParams ParamsAsIFireBoxLampParams()
		{
			return this.Params<IFireBoxLampParams>().Value;
		}

		// Token: 0x06025E56 RID: 155222 RVA: 0x00531DBC File Offset: 0x0052FFBC
		public IFishParams ParamsAsIFishParams()
		{
			return this.Params<IFishParams>().Value;
		}

		// Token: 0x06025E57 RID: 155223 RVA: 0x00531DD8 File Offset: 0x0052FFD8
		public ILightPlateParams ParamsAsILightPlateParams()
		{
			return this.Params<ILightPlateParams>().Value;
		}

		// Token: 0x06025E58 RID: 155224 RVA: 0x00531DF4 File Offset: 0x0052FFF4
		public IRushWarningEffectParams ParamsAsIRushWarningEffectParams()
		{
			return this.Params<IRushWarningEffectParams>().Value;
		}

		// Token: 0x06025E59 RID: 155225 RVA: 0x00531E10 File Offset: 0x00530010
		public IScoreDisplayMaterialParams ParamsAsIScoreDisplayMaterialParams()
		{
			return this.Params<IScoreDisplayMaterialParams>().Value;
		}

		// Token: 0x06025E5A RID: 155226 RVA: 0x00531E2C File Offset: 0x0053002C
		public ITimeDisplayMaterialParams ParamsAsITimeDisplayMaterialParams()
		{
			return this.Params<ITimeDisplayMaterialParams>().Value;
		}

		// Token: 0x06025E5B RID: 155227 RVA: 0x00531E48 File Offset: 0x00530048
		public IWoodenBoxProliferateParams ParamsAsIWoodenBoxProliferateParams()
		{
			return this.Params<IWoodenBoxProliferateParams>().Value;
		}

		// Token: 0x06025E5C RID: 155228 RVA: 0x00531E63 File Offset: 0x00530063
		public static Offset<ILevelPrefabParamsConfig> CreateILevelPrefabParamsConfig(FlatBufferBuilder builder, StringOffset ReferenceActorKeyOffset = default(StringOffset), TParamsPreset Params_type = TParamsPreset.NONE, int ParamsOffset = 0)
		{
			builder.StartTable(3);
			ILevelPrefabParamsConfig.AddParams(builder, ParamsOffset);
			ILevelPrefabParamsConfig.AddReferenceActorKey(builder, ReferenceActorKeyOffset);
			ILevelPrefabParamsConfig.AddParamsType(builder, Params_type);
			return ILevelPrefabParamsConfig.EndILevelPrefabParamsConfig(builder);
		}

		// Token: 0x06025E5D RID: 155229 RVA: 0x00531E87 File Offset: 0x00530087
		public static void StartILevelPrefabParamsConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06025E5E RID: 155230 RVA: 0x00531E90 File Offset: 0x00530090
		public static void AddReferenceActorKey(FlatBufferBuilder builder, StringOffset referenceActorKeyOffset)
		{
			builder.AddOffset(0, referenceActorKeyOffset.Value, 0);
		}

		// Token: 0x06025E5F RID: 155231 RVA: 0x00531EA0 File Offset: 0x005300A0
		public static void AddParamsType(FlatBufferBuilder builder, TParamsPreset paramsType)
		{
			builder.AddByte(1, (byte)paramsType, 0);
		}

		// Token: 0x06025E60 RID: 155232 RVA: 0x00531EAB File Offset: 0x005300AB
		public static void AddParams(FlatBufferBuilder builder, int paramsOffset)
		{
			builder.AddOffset(2, paramsOffset, 0);
		}

		// Token: 0x06025E61 RID: 155233 RVA: 0x00531EB6 File Offset: 0x005300B6
		public static Offset<ILevelPrefabParamsConfig> EndILevelPrefabParamsConfig(FlatBufferBuilder builder)
		{
			return new Offset<ILevelPrefabParamsConfig>(builder.EndTable());
		}

		// Token: 0x06025E62 RID: 155234 RVA: 0x00531EC4 File Offset: 0x005300C4
		public ILevelPrefabParamsConfigT UnPack()
		{
			ILevelPrefabParamsConfigT levelPrefabParamsConfigT = new ILevelPrefabParamsConfigT();
			this.UnPackTo(levelPrefabParamsConfigT);
			return levelPrefabParamsConfigT;
		}

		// Token: 0x06025E63 RID: 155235 RVA: 0x00531EE0 File Offset: 0x005300E0
		public void UnPackTo(ILevelPrefabParamsConfigT _o)
		{
			_o.ReferenceActorKey = this.ReferenceActorKey;
			_o.Params = new TParamsPresetUnion();
			_o.Params.Type = this.ParamsType;
			switch (this.ParamsType)
			{
			case TParamsPreset.IDecalParams:
				_o.Params.Value = ((this.Params<IDecalParams>() != null) ? this.Params<IDecalParams>().Value.UnPack() : null);
				return;
			case TParamsPreset.IEnergyFishParams:
				_o.Params.Value = ((this.Params<IEnergyFishParams>() != null) ? this.Params<IEnergyFishParams>().Value.UnPack() : null);
				return;
			case TParamsPreset.IFireBoxLampParams:
				_o.Params.Value = ((this.Params<IFireBoxLampParams>() != null) ? this.Params<IFireBoxLampParams>().Value.UnPack() : null);
				return;
			case TParamsPreset.IFishParams:
				_o.Params.Value = ((this.Params<IFishParams>() != null) ? this.Params<IFishParams>().Value.UnPack() : null);
				return;
			case TParamsPreset.ILightPlateParams:
				_o.Params.Value = ((this.Params<ILightPlateParams>() != null) ? this.Params<ILightPlateParams>().Value.UnPack() : null);
				return;
			case TParamsPreset.IRushWarningEffectParams:
				_o.Params.Value = ((this.Params<IRushWarningEffectParams>() != null) ? this.Params<IRushWarningEffectParams>().Value.UnPack() : null);
				return;
			case TParamsPreset.IScoreDisplayMaterialParams:
				_o.Params.Value = ((this.Params<IScoreDisplayMaterialParams>() != null) ? this.Params<IScoreDisplayMaterialParams>().Value.UnPack() : null);
				return;
			case TParamsPreset.ITimeDisplayMaterialParams:
				_o.Params.Value = ((this.Params<ITimeDisplayMaterialParams>() != null) ? this.Params<ITimeDisplayMaterialParams>().Value.UnPack() : null);
				return;
			case TParamsPreset.IWoodenBoxProliferateParams:
				_o.Params.Value = ((this.Params<IWoodenBoxProliferateParams>() != null) ? this.Params<IWoodenBoxProliferateParams>().Value.UnPack() : null);
				return;
			default:
				return;
			}
		}

		// Token: 0x06025E64 RID: 155236 RVA: 0x0053213C File Offset: 0x0053033C
		public static Offset<ILevelPrefabParamsConfig> Pack(FlatBufferBuilder builder, ILevelPrefabParamsConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILevelPrefabParamsConfig>);
			}
			StringOffset referenceActorKeyOffset = (_o.ReferenceActorKey == null) ? default(StringOffset) : builder.CreateString(_o.ReferenceActorKey);
			TParamsPreset params_type = (_o.Params == null) ? TParamsPreset.NONE : _o.Params.Type;
			int paramsOffset = (_o.Params == null) ? 0 : TParamsPresetUnion.Pack(builder, _o.Params);
			return ILevelPrefabParamsConfig.CreateILevelPrefabParamsConfig(builder, referenceActorKeyOffset, params_type, paramsOffset);
		}

		// Token: 0x0400F3ED RID: 62445
		private Table __p;
	}
}
