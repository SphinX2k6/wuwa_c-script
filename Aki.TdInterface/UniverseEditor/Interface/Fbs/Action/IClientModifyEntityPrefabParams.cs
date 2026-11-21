using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A4D RID: 27213
	public struct IClientModifyEntityPrefabParams : IFlatbufferObject
	{
		// Token: 0x1700C7F0 RID: 51184
		// (get) Token: 0x0602EADC RID: 191196 RVA: 0x0065CE04 File Offset: 0x0065B004
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602EADD RID: 191197 RVA: 0x0065CE11 File Offset: 0x0065B011
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602EADE RID: 191198 RVA: 0x0065CE18 File Offset: 0x0065B018
		public static IClientModifyEntityPrefabParams GetRootAsIClientModifyEntityPrefabParams(ByteBuffer _bb)
		{
			return IClientModifyEntityPrefabParams.GetRootAsIClientModifyEntityPrefabParams(_bb, default(IClientModifyEntityPrefabParams));
		}

		// Token: 0x0602EADF RID: 191199 RVA: 0x0065CE34 File Offset: 0x0065B034
		public static IClientModifyEntityPrefabParams GetRootAsIClientModifyEntityPrefabParams(ByteBuffer _bb, IClientModifyEntityPrefabParams obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602EAE0 RID: 191200 RVA: 0x0065CE51 File Offset: 0x0065B051
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602EAE1 RID: 191201 RVA: 0x0065CE60 File Offset: 0x0065B060
		public IClientModifyEntityPrefabParams __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C7F1 RID: 51185
		// (get) Token: 0x0602EAE2 RID: 191202 RVA: 0x0065CE70 File Offset: 0x0065B070
		public EClientExecEntityPrefabOption Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EClientExecEntityPrefabOption.ModifyPrefabParams;
				}
				return (EClientExecEntityPrefabOption)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C7F2 RID: 51186
		// (get) Token: 0x0602EAE3 RID: 191203 RVA: 0x0065CEAC File Offset: 0x0065B0AC
		public int EntityId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C7F3 RID: 51187
		// (get) Token: 0x0602EAE4 RID: 191204 RVA: 0x0065CEE8 File Offset: 0x0065B0E8
		public string ReferenceActorKey
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602EAE5 RID: 191205 RVA: 0x0065CF1F File Offset: 0x0065B11F
		public Span<byte> GetReferenceActorKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0602EAE6 RID: 191206 RVA: 0x0065CF2E File Offset: 0x0065B12E
		public byte[] GetReferenceActorKeyArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x1700C7F4 RID: 51188
		// (get) Token: 0x0602EAE7 RID: 191207 RVA: 0x0065CF3C File Offset: 0x0065B13C
		public TParamsPreset ParamsType
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return TParamsPreset.NONE;
				}
				return (TParamsPreset)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602EAE8 RID: 191208 RVA: 0x0065CF7C File Offset: 0x0065B17C
		public TTable? Params<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602EAE9 RID: 191209 RVA: 0x0065CFC4 File Offset: 0x0065B1C4
		public IDecalParams ParamsAsIDecalParams()
		{
			return this.Params<IDecalParams>().Value;
		}

		// Token: 0x0602EAEA RID: 191210 RVA: 0x0065CFE0 File Offset: 0x0065B1E0
		public IEnergyFishParams ParamsAsIEnergyFishParams()
		{
			return this.Params<IEnergyFishParams>().Value;
		}

		// Token: 0x0602EAEB RID: 191211 RVA: 0x0065CFFC File Offset: 0x0065B1FC
		public IFireBoxLampParams ParamsAsIFireBoxLampParams()
		{
			return this.Params<IFireBoxLampParams>().Value;
		}

		// Token: 0x0602EAEC RID: 191212 RVA: 0x0065D018 File Offset: 0x0065B218
		public IFishParams ParamsAsIFishParams()
		{
			return this.Params<IFishParams>().Value;
		}

		// Token: 0x0602EAED RID: 191213 RVA: 0x0065D034 File Offset: 0x0065B234
		public ILightPlateParams ParamsAsILightPlateParams()
		{
			return this.Params<ILightPlateParams>().Value;
		}

		// Token: 0x0602EAEE RID: 191214 RVA: 0x0065D050 File Offset: 0x0065B250
		public IRushWarningEffectParams ParamsAsIRushWarningEffectParams()
		{
			return this.Params<IRushWarningEffectParams>().Value;
		}

		// Token: 0x0602EAEF RID: 191215 RVA: 0x0065D06C File Offset: 0x0065B26C
		public IScoreDisplayMaterialParams ParamsAsIScoreDisplayMaterialParams()
		{
			return this.Params<IScoreDisplayMaterialParams>().Value;
		}

		// Token: 0x0602EAF0 RID: 191216 RVA: 0x0065D088 File Offset: 0x0065B288
		public ITimeDisplayMaterialParams ParamsAsITimeDisplayMaterialParams()
		{
			return this.Params<ITimeDisplayMaterialParams>().Value;
		}

		// Token: 0x0602EAF1 RID: 191217 RVA: 0x0065D0A4 File Offset: 0x0065B2A4
		public IWoodenBoxProliferateParams ParamsAsIWoodenBoxProliferateParams()
		{
			return this.Params<IWoodenBoxProliferateParams>().Value;
		}

		// Token: 0x0602EAF2 RID: 191218 RVA: 0x0065D0BF File Offset: 0x0065B2BF
		public static Offset<IClientModifyEntityPrefabParams> CreateIClientModifyEntityPrefabParams(FlatBufferBuilder builder, EClientExecEntityPrefabOption Type = EClientExecEntityPrefabOption.ModifyPrefabParams, int EntityId = 0, StringOffset ReferenceActorKeyOffset = default(StringOffset), TParamsPreset Params_type = TParamsPreset.NONE, int ParamsOffset = 0)
		{
			builder.StartTable(5);
			IClientModifyEntityPrefabParams.AddParams(builder, ParamsOffset);
			IClientModifyEntityPrefabParams.AddReferenceActorKey(builder, ReferenceActorKeyOffset);
			IClientModifyEntityPrefabParams.AddEntityId(builder, EntityId);
			IClientModifyEntityPrefabParams.AddParamsType(builder, Params_type);
			IClientModifyEntityPrefabParams.AddType(builder, Type);
			return IClientModifyEntityPrefabParams.EndIClientModifyEntityPrefabParams(builder);
		}

		// Token: 0x0602EAF3 RID: 191219 RVA: 0x0065D0F3 File Offset: 0x0065B2F3
		public static void StartIClientModifyEntityPrefabParams(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0602EAF4 RID: 191220 RVA: 0x0065D0FC File Offset: 0x0065B2FC
		public static void AddType(FlatBufferBuilder builder, EClientExecEntityPrefabOption type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602EAF5 RID: 191221 RVA: 0x0065D107 File Offset: 0x0065B307
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(1, entityId, 0);
		}

		// Token: 0x0602EAF6 RID: 191222 RVA: 0x0065D112 File Offset: 0x0065B312
		public static void AddReferenceActorKey(FlatBufferBuilder builder, StringOffset referenceActorKeyOffset)
		{
			builder.AddOffset(2, referenceActorKeyOffset.Value, 0);
		}

		// Token: 0x0602EAF7 RID: 191223 RVA: 0x0065D122 File Offset: 0x0065B322
		public static void AddParamsType(FlatBufferBuilder builder, TParamsPreset paramsType)
		{
			builder.AddByte(3, (byte)paramsType, 0);
		}

		// Token: 0x0602EAF8 RID: 191224 RVA: 0x0065D12D File Offset: 0x0065B32D
		public static void AddParams(FlatBufferBuilder builder, int paramsOffset)
		{
			builder.AddOffset(4, paramsOffset, 0);
		}

		// Token: 0x0602EAF9 RID: 191225 RVA: 0x0065D138 File Offset: 0x0065B338
		public static Offset<IClientModifyEntityPrefabParams> EndIClientModifyEntityPrefabParams(FlatBufferBuilder builder)
		{
			return new Offset<IClientModifyEntityPrefabParams>(builder.EndTable());
		}

		// Token: 0x0602EAFA RID: 191226 RVA: 0x0065D148 File Offset: 0x0065B348
		public IClientModifyEntityPrefabParamsT UnPack()
		{
			IClientModifyEntityPrefabParamsT clientModifyEntityPrefabParamsT = new IClientModifyEntityPrefabParamsT();
			this.UnPackTo(clientModifyEntityPrefabParamsT);
			return clientModifyEntityPrefabParamsT;
		}

		// Token: 0x0602EAFB RID: 191227 RVA: 0x0065D164 File Offset: 0x0065B364
		public void UnPackTo(IClientModifyEntityPrefabParamsT _o)
		{
			_o.Type = this.Type;
			_o.EntityId = this.EntityId;
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

		// Token: 0x0602EAFC RID: 191228 RVA: 0x0065D3D8 File Offset: 0x0065B5D8
		public static Offset<IClientModifyEntityPrefabParams> Pack(FlatBufferBuilder builder, IClientModifyEntityPrefabParamsT _o)
		{
			if (_o == null)
			{
				return default(Offset<IClientModifyEntityPrefabParams>);
			}
			StringOffset referenceActorKeyOffset = (_o.ReferenceActorKey == null) ? default(StringOffset) : builder.CreateString(_o.ReferenceActorKey);
			TParamsPreset params_type = (_o.Params == null) ? TParamsPreset.NONE : _o.Params.Type;
			int paramsOffset = (_o.Params == null) ? 0 : TParamsPresetUnion.Pack(builder, _o.Params);
			return IClientModifyEntityPrefabParams.CreateIClientModifyEntityPrefabParams(builder, _o.Type, _o.EntityId, referenceActorKeyOffset, params_type, paramsOffset);
		}

		// Token: 0x040117CE RID: 71630
		private Table __p;
	}
}
