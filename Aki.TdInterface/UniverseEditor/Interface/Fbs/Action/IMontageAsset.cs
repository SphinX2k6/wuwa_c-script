using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007225 RID: 29221
	public struct IMontageAsset : IFlatbufferObject
	{
		// Token: 0x1700D5E3 RID: 54755
		// (get) Token: 0x06032D8C RID: 208268 RVA: 0x006DD8E8 File Offset: 0x006DBAE8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06032D8D RID: 208269 RVA: 0x006DD8F5 File Offset: 0x006DBAF5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06032D8E RID: 208270 RVA: 0x006DD8FC File Offset: 0x006DBAFC
		public static IMontageAsset GetRootAsIMontageAsset(ByteBuffer _bb)
		{
			return IMontageAsset.GetRootAsIMontageAsset(_bb, default(IMontageAsset));
		}

		// Token: 0x06032D8F RID: 208271 RVA: 0x006DD918 File Offset: 0x006DBB18
		public static IMontageAsset GetRootAsIMontageAsset(ByteBuffer _bb, IMontageAsset obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06032D90 RID: 208272 RVA: 0x006DD935 File Offset: 0x006DBB35
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06032D91 RID: 208273 RVA: 0x006DD944 File Offset: 0x006DBB44
		public IMontageAsset __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D5E4 RID: 54756
		// (get) Token: 0x06032D92 RID: 208274 RVA: 0x006DD954 File Offset: 0x006DBB54
		public EMontageConfigType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EMontageConfigType.Asset;
				}
				return (EMontageConfigType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D5E5 RID: 54757
		// (get) Token: 0x06032D93 RID: 208275 RVA: 0x006DD990 File Offset: 0x006DBB90
		public string Asset
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06032D94 RID: 208276 RVA: 0x006DD9C7 File Offset: 0x006DBBC7
		public Span<byte> GetAssetBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06032D95 RID: 208277 RVA: 0x006DD9D6 File Offset: 0x006DBBD6
		public byte[] GetAssetArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x06032D96 RID: 208278 RVA: 0x006DD9E4 File Offset: 0x006DBBE4
		public static Offset<IMontageAsset> CreateIMontageAsset(FlatBufferBuilder builder, EMontageConfigType Type = EMontageConfigType.Asset, StringOffset AssetOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IMontageAsset.AddAsset(builder, AssetOffset);
			IMontageAsset.AddType(builder, Type);
			return IMontageAsset.EndIMontageAsset(builder);
		}

		// Token: 0x06032D97 RID: 208279 RVA: 0x006DDA01 File Offset: 0x006DBC01
		public static void StartIMontageAsset(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06032D98 RID: 208280 RVA: 0x006DDA0A File Offset: 0x006DBC0A
		public static void AddType(FlatBufferBuilder builder, EMontageConfigType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06032D99 RID: 208281 RVA: 0x006DDA15 File Offset: 0x006DBC15
		public static void AddAsset(FlatBufferBuilder builder, StringOffset assetOffset)
		{
			builder.AddOffset(1, assetOffset.Value, 0);
		}

		// Token: 0x06032D9A RID: 208282 RVA: 0x006DDA25 File Offset: 0x006DBC25
		public static Offset<IMontageAsset> EndIMontageAsset(FlatBufferBuilder builder)
		{
			return new Offset<IMontageAsset>(builder.EndTable());
		}

		// Token: 0x06032D9B RID: 208283 RVA: 0x006DDA34 File Offset: 0x006DBC34
		public IMontageAssetT UnPack()
		{
			IMontageAssetT montageAssetT = new IMontageAssetT();
			this.UnPackTo(montageAssetT);
			return montageAssetT;
		}

		// Token: 0x06032D9C RID: 208284 RVA: 0x006DDA4F File Offset: 0x006DBC4F
		public void UnPackTo(IMontageAssetT _o)
		{
			_o.Type = this.Type;
			_o.Asset = this.Asset;
		}

		// Token: 0x06032D9D RID: 208285 RVA: 0x006DDA6C File Offset: 0x006DBC6C
		public static Offset<IMontageAsset> Pack(FlatBufferBuilder builder, IMontageAssetT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMontageAsset>);
			}
			StringOffset assetOffset = (_o.Asset == null) ? default(StringOffset) : builder.CreateString(_o.Asset);
			return IMontageAsset.CreateIMontageAsset(builder, _o.Type, assetOffset);
		}

		// Token: 0x04012256 RID: 74326
		private Table __p;
	}
}
