using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.CsvData
{
	// Token: 0x02004D6D RID: 19821
	public struct ICircuitConnectAssetConfig : IFlatbufferObject
	{
		// Token: 0x17008DD2 RID: 36306
		// (get) Token: 0x0601EB77 RID: 125815 RVA: 0x0044BE44 File Offset: 0x0044A044
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601EB78 RID: 125816 RVA: 0x0044BE51 File Offset: 0x0044A051
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601EB79 RID: 125817 RVA: 0x0044BE58 File Offset: 0x0044A058
		public static ICircuitConnectAssetConfig GetRootAsICircuitConnectAssetConfig(ByteBuffer _bb)
		{
			return ICircuitConnectAssetConfig.GetRootAsICircuitConnectAssetConfig(_bb, default(ICircuitConnectAssetConfig));
		}

		// Token: 0x0601EB7A RID: 125818 RVA: 0x0044BE74 File Offset: 0x0044A074
		public static ICircuitConnectAssetConfig GetRootAsICircuitConnectAssetConfig(ByteBuffer _bb, ICircuitConnectAssetConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601EB7B RID: 125819 RVA: 0x0044BE91 File Offset: 0x0044A091
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601EB7C RID: 125820 RVA: 0x0044BEA0 File Offset: 0x0044A0A0
		public ICircuitConnectAssetConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008DD3 RID: 36307
		// (get) Token: 0x0601EB7D RID: 125821 RVA: 0x0044BEB0 File Offset: 0x0044A0B0
		public string AssetPath
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

		// Token: 0x0601EB7E RID: 125822 RVA: 0x0044BEE7 File Offset: 0x0044A0E7
		public Span<byte> GetAssetPathBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0601EB7F RID: 125823 RVA: 0x0044BEF6 File Offset: 0x0044A0F6
		public byte[] GetAssetPathArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x17008DD4 RID: 36308
		// (get) Token: 0x0601EB80 RID: 125824 RVA: 0x0044BF04 File Offset: 0x0044A104
		public TCircuitConnectAssetType AssetTypeType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return TCircuitConnectAssetType.NONE;
				}
				return (TCircuitConnectAssetType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601EB81 RID: 125825 RVA: 0x0044BF40 File Offset: 0x0044A140
		public TTable? AssetType<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0601EB82 RID: 125826 RVA: 0x0044BF84 File Offset: 0x0044A184
		public ICircuitConnectCurveAsset AssetTypeAsICircuitConnectCurveAsset()
		{
			return this.AssetType<ICircuitConnectCurveAsset>().Value;
		}

		// Token: 0x0601EB83 RID: 125827 RVA: 0x0044BFA0 File Offset: 0x0044A1A0
		public ICircuitConnectOutputPortAsset AssetTypeAsICircuitConnectOutputPortAsset()
		{
			return this.AssetType<ICircuitConnectOutputPortAsset>().Value;
		}

		// Token: 0x0601EB84 RID: 125828 RVA: 0x0044BFBC File Offset: 0x0044A1BC
		public ICircuitConnectPowerPortAsset AssetTypeAsICircuitConnectPowerPortAsset()
		{
			return this.AssetType<ICircuitConnectPowerPortAsset>().Value;
		}

		// Token: 0x0601EB85 RID: 125829 RVA: 0x0044BFD8 File Offset: 0x0044A1D8
		public ICircuitConnectStraightAsset AssetTypeAsICircuitConnectStraightAsset()
		{
			return this.AssetType<ICircuitConnectStraightAsset>().Value;
		}

		// Token: 0x0601EB86 RID: 125830 RVA: 0x0044BFF3 File Offset: 0x0044A1F3
		public static Offset<ICircuitConnectAssetConfig> CreateICircuitConnectAssetConfig(FlatBufferBuilder builder, StringOffset AssetPathOffset = default(StringOffset), TCircuitConnectAssetType AssetType_type = TCircuitConnectAssetType.NONE, int AssetTypeOffset = 0)
		{
			builder.StartTable(3);
			ICircuitConnectAssetConfig.AddAssetType(builder, AssetTypeOffset);
			ICircuitConnectAssetConfig.AddAssetPath(builder, AssetPathOffset);
			ICircuitConnectAssetConfig.AddAssetTypeType(builder, AssetType_type);
			return ICircuitConnectAssetConfig.EndICircuitConnectAssetConfig(builder);
		}

		// Token: 0x0601EB87 RID: 125831 RVA: 0x0044C017 File Offset: 0x0044A217
		public static void StartICircuitConnectAssetConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601EB88 RID: 125832 RVA: 0x0044C020 File Offset: 0x0044A220
		public static void AddAssetPath(FlatBufferBuilder builder, StringOffset assetPathOffset)
		{
			builder.AddOffset(0, assetPathOffset.Value, 0);
		}

		// Token: 0x0601EB89 RID: 125833 RVA: 0x0044C030 File Offset: 0x0044A230
		public static void AddAssetTypeType(FlatBufferBuilder builder, TCircuitConnectAssetType assetTypeType)
		{
			builder.AddByte(1, (byte)assetTypeType, 0);
		}

		// Token: 0x0601EB8A RID: 125834 RVA: 0x0044C03B File Offset: 0x0044A23B
		public static void AddAssetType(FlatBufferBuilder builder, int assetTypeOffset)
		{
			builder.AddOffset(2, assetTypeOffset, 0);
		}

		// Token: 0x0601EB8B RID: 125835 RVA: 0x0044C046 File Offset: 0x0044A246
		public static Offset<ICircuitConnectAssetConfig> EndICircuitConnectAssetConfig(FlatBufferBuilder builder)
		{
			return new Offset<ICircuitConnectAssetConfig>(builder.EndTable());
		}

		// Token: 0x0601EB8C RID: 125836 RVA: 0x0044C054 File Offset: 0x0044A254
		public ICircuitConnectAssetConfigT UnPack()
		{
			ICircuitConnectAssetConfigT circuitConnectAssetConfigT = new ICircuitConnectAssetConfigT();
			this.UnPackTo(circuitConnectAssetConfigT);
			return circuitConnectAssetConfigT;
		}

		// Token: 0x0601EB8D RID: 125837 RVA: 0x0044C070 File Offset: 0x0044A270
		public void UnPackTo(ICircuitConnectAssetConfigT _o)
		{
			_o.AssetPath = this.AssetPath;
			_o.AssetType = new TCircuitConnectAssetTypeUnion();
			_o.AssetType.Type = this.AssetTypeType;
			switch (this.AssetTypeType)
			{
			case TCircuitConnectAssetType.ICircuitConnectCurveAsset:
				_o.AssetType.Value = ((this.AssetType<ICircuitConnectCurveAsset>() != null) ? this.AssetType<ICircuitConnectCurveAsset>().Value.UnPack() : null);
				return;
			case TCircuitConnectAssetType.ICircuitConnectOutputPortAsset:
				_o.AssetType.Value = ((this.AssetType<ICircuitConnectOutputPortAsset>() != null) ? this.AssetType<ICircuitConnectOutputPortAsset>().Value.UnPack() : null);
				return;
			case TCircuitConnectAssetType.ICircuitConnectPowerPortAsset:
				_o.AssetType.Value = ((this.AssetType<ICircuitConnectPowerPortAsset>() != null) ? this.AssetType<ICircuitConnectPowerPortAsset>().Value.UnPack() : null);
				return;
			case TCircuitConnectAssetType.ICircuitConnectStraightAsset:
				_o.AssetType.Value = ((this.AssetType<ICircuitConnectStraightAsset>() != null) ? this.AssetType<ICircuitConnectStraightAsset>().Value.UnPack() : null);
				return;
			default:
				return;
			}
		}

		// Token: 0x0601EB8E RID: 125838 RVA: 0x0044C1A0 File Offset: 0x0044A3A0
		public static Offset<ICircuitConnectAssetConfig> Pack(FlatBufferBuilder builder, ICircuitConnectAssetConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICircuitConnectAssetConfig>);
			}
			StringOffset assetPathOffset = (_o.AssetPath == null) ? default(StringOffset) : builder.CreateString(_o.AssetPath);
			TCircuitConnectAssetType assetType_type = (_o.AssetType == null) ? TCircuitConnectAssetType.NONE : _o.AssetType.Type;
			int assetTypeOffset = (_o.AssetType == null) ? 0 : TCircuitConnectAssetTypeUnion.Pack(builder, _o.AssetType);
			return ICircuitConnectAssetConfig.CreateICircuitConnectAssetConfig(builder, assetPathOffset, assetType_type, assetTypeOffset);
		}

		// Token: 0x0400D9C0 RID: 55744
		private Table __p;
	}
}
