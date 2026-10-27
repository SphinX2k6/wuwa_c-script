using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020054E5 RID: 21733
	public struct ILevelPrefabParamsConfig : IFlatbufferObject
	{
		// Token: 0x1700A04B RID: 41035
		// (get) Token: 0x06023D90 RID: 146832 RVA: 0x004F4BB3 File Offset: 0x004F2DB3
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06023D91 RID: 146833 RVA: 0x004F4BC0 File Offset: 0x004F2DC0
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06023D92 RID: 146834 RVA: 0x004F4BC8 File Offset: 0x004F2DC8
		public static ILevelPrefabParamsConfig GetRootAsILevelPrefabParamsConfig(ByteBuffer _bb)
		{
			return ILevelPrefabParamsConfig.GetRootAsILevelPrefabParamsConfig(_bb, default(ILevelPrefabParamsConfig));
		}

		// Token: 0x06023D93 RID: 146835 RVA: 0x004F4BE4 File Offset: 0x004F2DE4
		public static ILevelPrefabParamsConfig GetRootAsILevelPrefabParamsConfig(ByteBuffer _bb, ILevelPrefabParamsConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06023D94 RID: 146836 RVA: 0x004F4C01 File Offset: 0x004F2E01
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06023D95 RID: 146837 RVA: 0x004F4C10 File Offset: 0x004F2E10
		public ILevelPrefabParamsConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A04C RID: 41036
		// (get) Token: 0x06023D96 RID: 146838 RVA: 0x004F4C20 File Offset: 0x004F2E20
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

		// Token: 0x06023D97 RID: 146839 RVA: 0x004F4C57 File Offset: 0x004F2E57
		public Span<byte> GetReferenceActorKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06023D98 RID: 146840 RVA: 0x004F4C66 File Offset: 0x004F2E66
		public byte[] GetReferenceActorKeyArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700A04D RID: 41037
		// (get) Token: 0x06023D99 RID: 146841 RVA: 0x004F4C74 File Offset: 0x004F2E74
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

		// Token: 0x06023D9A RID: 146842 RVA: 0x004F4CB0 File Offset: 0x004F2EB0
		public TTable? Params<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06023D9B RID: 146843 RVA: 0x004F4CF4 File Offset: 0x004F2EF4
		public IDecalParams ParamsAsIDecalParams()
		{
			return this.Params<IDecalParams>().Value;
		}

		// Token: 0x06023D9C RID: 146844 RVA: 0x004F4D10 File Offset: 0x004F2F10
		public IFireBoxLampParams ParamsAsIFireBoxLampParams()
		{
			return this.Params<IFireBoxLampParams>().Value;
		}

		// Token: 0x06023D9D RID: 146845 RVA: 0x004F4D2C File Offset: 0x004F2F2C
		public ILightPlateParams ParamsAsILightPlateParams()
		{
			return this.Params<ILightPlateParams>().Value;
		}

		// Token: 0x06023D9E RID: 146846 RVA: 0x004F4D48 File Offset: 0x004F2F48
		public IRushWarningEffectParams ParamsAsIRushWarningEffectParams()
		{
			return this.Params<IRushWarningEffectParams>().Value;
		}

		// Token: 0x06023D9F RID: 146847 RVA: 0x004F4D64 File Offset: 0x004F2F64
		public IScoreDisplayMaterialParams ParamsAsIScoreDisplayMaterialParams()
		{
			return this.Params<IScoreDisplayMaterialParams>().Value;
		}

		// Token: 0x06023DA0 RID: 146848 RVA: 0x004F4D80 File Offset: 0x004F2F80
		public ITimeDisplayMaterialParams ParamsAsITimeDisplayMaterialParams()
		{
			return this.Params<ITimeDisplayMaterialParams>().Value;
		}

		// Token: 0x06023DA1 RID: 146849 RVA: 0x004F4D9C File Offset: 0x004F2F9C
		public IWoodenBoxProliferateParams ParamsAsIWoodenBoxProliferateParams()
		{
			return this.Params<IWoodenBoxProliferateParams>().Value;
		}

		// Token: 0x06023DA2 RID: 146850 RVA: 0x004F4DB7 File Offset: 0x004F2FB7
		public static Offset<ILevelPrefabParamsConfig> CreateILevelPrefabParamsConfig(FlatBufferBuilder builder, StringOffset ReferenceActorKeyOffset = default(StringOffset), TParamsPreset Params_type = TParamsPreset.NONE, int ParamsOffset = 0)
		{
			builder.StartTable(3);
			ILevelPrefabParamsConfig.AddParams(builder, ParamsOffset);
			ILevelPrefabParamsConfig.AddReferenceActorKey(builder, ReferenceActorKeyOffset);
			ILevelPrefabParamsConfig.AddParamsType(builder, Params_type);
			return ILevelPrefabParamsConfig.EndILevelPrefabParamsConfig(builder);
		}

		// Token: 0x06023DA3 RID: 146851 RVA: 0x004F4DDB File Offset: 0x004F2FDB
		public static void StartILevelPrefabParamsConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06023DA4 RID: 146852 RVA: 0x004F4DE4 File Offset: 0x004F2FE4
		public static void AddReferenceActorKey(FlatBufferBuilder builder, StringOffset referenceActorKeyOffset)
		{
			builder.AddOffset(0, referenceActorKeyOffset.Value, 0);
		}

		// Token: 0x06023DA5 RID: 146853 RVA: 0x004F4DF4 File Offset: 0x004F2FF4
		public static void AddParamsType(FlatBufferBuilder builder, TParamsPreset paramsType)
		{
			builder.AddByte(1, (byte)paramsType, 0);
		}

		// Token: 0x06023DA6 RID: 146854 RVA: 0x004F4DFF File Offset: 0x004F2FFF
		public static void AddParams(FlatBufferBuilder builder, int paramsOffset)
		{
			builder.AddOffset(2, paramsOffset, 0);
		}

		// Token: 0x06023DA7 RID: 146855 RVA: 0x004F4E0A File Offset: 0x004F300A
		public static Offset<ILevelPrefabParamsConfig> EndILevelPrefabParamsConfig(FlatBufferBuilder builder)
		{
			return new Offset<ILevelPrefabParamsConfig>(builder.EndTable());
		}

		// Token: 0x06023DA8 RID: 146856 RVA: 0x004F4E18 File Offset: 0x004F3018
		public ILevelPrefabParamsConfigT UnPack()
		{
			ILevelPrefabParamsConfigT levelPrefabParamsConfigT = new ILevelPrefabParamsConfigT();
			this.UnPackTo(levelPrefabParamsConfigT);
			return levelPrefabParamsConfigT;
		}

		// Token: 0x06023DA9 RID: 146857 RVA: 0x004F4E34 File Offset: 0x004F3034
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
			case TParamsPreset.IFireBoxLampParams:
				_o.Params.Value = ((this.Params<IFireBoxLampParams>() != null) ? this.Params<IFireBoxLampParams>().Value.UnPack() : null);
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

		// Token: 0x06023DAA RID: 146858 RVA: 0x004F5018 File Offset: 0x004F3218
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

		// Token: 0x0400E7BC RID: 59324
		private Table __p;
	}
}
