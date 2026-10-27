using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006AEE RID: 27374
	public struct IMontageAsset : IFlatbufferObject
	{
		// Token: 0x1700CB14 RID: 51988
		// (get) Token: 0x0602FFB8 RID: 196536 RVA: 0x00686230 File Offset: 0x00684430
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602FFB9 RID: 196537 RVA: 0x0068623D File Offset: 0x0068443D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602FFBA RID: 196538 RVA: 0x00686244 File Offset: 0x00684444
		public static IMontageAsset GetRootAsIMontageAsset(ByteBuffer _bb)
		{
			return IMontageAsset.GetRootAsIMontageAsset(_bb, default(IMontageAsset));
		}

		// Token: 0x0602FFBB RID: 196539 RVA: 0x00686260 File Offset: 0x00684460
		public static IMontageAsset GetRootAsIMontageAsset(ByteBuffer _bb, IMontageAsset obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602FFBC RID: 196540 RVA: 0x0068627D File Offset: 0x0068447D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602FFBD RID: 196541 RVA: 0x0068628C File Offset: 0x0068448C
		public IMontageAsset __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CB15 RID: 51989
		// (get) Token: 0x0602FFBE RID: 196542 RVA: 0x0068629C File Offset: 0x0068449C
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

		// Token: 0x1700CB16 RID: 51990
		// (get) Token: 0x0602FFBF RID: 196543 RVA: 0x006862D8 File Offset: 0x006844D8
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

		// Token: 0x0602FFC0 RID: 196544 RVA: 0x0068630F File Offset: 0x0068450F
		public Span<byte> GetAssetBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0602FFC1 RID: 196545 RVA: 0x0068631E File Offset: 0x0068451E
		public byte[] GetAssetArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x0602FFC2 RID: 196546 RVA: 0x0068632C File Offset: 0x0068452C
		public static Offset<IMontageAsset> CreateIMontageAsset(FlatBufferBuilder builder, EMontageConfigType Type = EMontageConfigType.Asset, StringOffset AssetOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IMontageAsset.AddAsset(builder, AssetOffset);
			IMontageAsset.AddType(builder, Type);
			return IMontageAsset.EndIMontageAsset(builder);
		}

		// Token: 0x0602FFC3 RID: 196547 RVA: 0x00686349 File Offset: 0x00684549
		public static void StartIMontageAsset(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602FFC4 RID: 196548 RVA: 0x00686352 File Offset: 0x00684552
		public static void AddType(FlatBufferBuilder builder, EMontageConfigType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602FFC5 RID: 196549 RVA: 0x0068635D File Offset: 0x0068455D
		public static void AddAsset(FlatBufferBuilder builder, StringOffset assetOffset)
		{
			builder.AddOffset(1, assetOffset.Value, 0);
		}

		// Token: 0x0602FFC6 RID: 196550 RVA: 0x0068636D File Offset: 0x0068456D
		public static Offset<IMontageAsset> EndIMontageAsset(FlatBufferBuilder builder)
		{
			return new Offset<IMontageAsset>(builder.EndTable());
		}

		// Token: 0x0602FFC7 RID: 196551 RVA: 0x0068637C File Offset: 0x0068457C
		public IMontageAssetT UnPack()
		{
			IMontageAssetT montageAssetT = new IMontageAssetT();
			this.UnPackTo(montageAssetT);
			return montageAssetT;
		}

		// Token: 0x0602FFC8 RID: 196552 RVA: 0x00686397 File Offset: 0x00684597
		public void UnPackTo(IMontageAssetT _o)
		{
			_o.Type = this.Type;
			_o.Asset = this.Asset;
		}

		// Token: 0x0602FFC9 RID: 196553 RVA: 0x006863B4 File Offset: 0x006845B4
		public static Offset<IMontageAsset> Pack(FlatBufferBuilder builder, IMontageAssetT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMontageAsset>);
			}
			StringOffset assetOffset = (_o.Asset == null) ? default(StringOffset) : builder.CreateString(_o.Asset);
			return IMontageAsset.CreateIMontageAsset(builder, _o.Type, assetOffset);
		}

		// Token: 0x04011343 RID: 70467
		private Table __p;
	}
}
