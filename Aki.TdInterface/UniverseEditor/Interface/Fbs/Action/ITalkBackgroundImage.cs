using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007A70 RID: 31344
	public struct ITalkBackgroundImage : IFlatbufferObject
	{
		// Token: 0x1700E591 RID: 58769
		// (get) Token: 0x060373D3 RID: 226259 RVA: 0x00760969 File Offset: 0x0075EB69
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060373D4 RID: 226260 RVA: 0x00760976 File Offset: 0x0075EB76
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060373D5 RID: 226261 RVA: 0x00760980 File Offset: 0x0075EB80
		public static ITalkBackgroundImage GetRootAsITalkBackgroundImage(ByteBuffer _bb)
		{
			return ITalkBackgroundImage.GetRootAsITalkBackgroundImage(_bb, default(ITalkBackgroundImage));
		}

		// Token: 0x060373D6 RID: 226262 RVA: 0x0076099C File Offset: 0x0075EB9C
		public static ITalkBackgroundImage GetRootAsITalkBackgroundImage(ByteBuffer _bb, ITalkBackgroundImage obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060373D7 RID: 226263 RVA: 0x007609B9 File Offset: 0x0075EBB9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060373D8 RID: 226264 RVA: 0x007609C8 File Offset: 0x0075EBC8
		public ITalkBackgroundImage __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E592 RID: 58770
		// (get) Token: 0x060373D9 RID: 226265 RVA: 0x007609D8 File Offset: 0x0075EBD8
		public ETalkBackgroundType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETalkBackgroundType.Clean;
				}
				return (ETalkBackgroundType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700E593 RID: 58771
		// (get) Token: 0x060373DA RID: 226266 RVA: 0x00760A14 File Offset: 0x0075EC14
		public string ImageAsset
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

		// Token: 0x060373DB RID: 226267 RVA: 0x00760A4B File Offset: 0x0075EC4B
		public Span<byte> GetImageAssetBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060373DC RID: 226268 RVA: 0x00760A5A File Offset: 0x0075EC5A
		public byte[] GetImageAssetArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x060373DD RID: 226269 RVA: 0x00760A68 File Offset: 0x0075EC68
		public static Offset<ITalkBackgroundImage> CreateITalkBackgroundImage(FlatBufferBuilder builder, ETalkBackgroundType Type = ETalkBackgroundType.Clean, StringOffset ImageAssetOffset = default(StringOffset))
		{
			builder.StartTable(2);
			ITalkBackgroundImage.AddImageAsset(builder, ImageAssetOffset);
			ITalkBackgroundImage.AddType(builder, Type);
			return ITalkBackgroundImage.EndITalkBackgroundImage(builder);
		}

		// Token: 0x060373DE RID: 226270 RVA: 0x00760A85 File Offset: 0x0075EC85
		public static void StartITalkBackgroundImage(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060373DF RID: 226271 RVA: 0x00760A8E File Offset: 0x0075EC8E
		public static void AddType(FlatBufferBuilder builder, ETalkBackgroundType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060373E0 RID: 226272 RVA: 0x00760A99 File Offset: 0x0075EC99
		public static void AddImageAsset(FlatBufferBuilder builder, StringOffset imageAssetOffset)
		{
			builder.AddOffset(1, imageAssetOffset.Value, 0);
		}

		// Token: 0x060373E1 RID: 226273 RVA: 0x00760AA9 File Offset: 0x0075ECA9
		public static Offset<ITalkBackgroundImage> EndITalkBackgroundImage(FlatBufferBuilder builder)
		{
			return new Offset<ITalkBackgroundImage>(builder.EndTable());
		}

		// Token: 0x060373E2 RID: 226274 RVA: 0x00760AB8 File Offset: 0x0075ECB8
		public ITalkBackgroundImageT UnPack()
		{
			ITalkBackgroundImageT talkBackgroundImageT = new ITalkBackgroundImageT();
			this.UnPackTo(talkBackgroundImageT);
			return talkBackgroundImageT;
		}

		// Token: 0x060373E3 RID: 226275 RVA: 0x00760AD3 File Offset: 0x0075ECD3
		public void UnPackTo(ITalkBackgroundImageT _o)
		{
			_o.Type = this.Type;
			_o.ImageAsset = this.ImageAsset;
		}

		// Token: 0x060373E4 RID: 226276 RVA: 0x00760AF0 File Offset: 0x0075ECF0
		public static Offset<ITalkBackgroundImage> Pack(FlatBufferBuilder builder, ITalkBackgroundImageT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITalkBackgroundImage>);
			}
			StringOffset imageAssetOffset = (_o.ImageAsset == null) ? default(StringOffset) : builder.CreateString(_o.ImageAsset);
			return ITalkBackgroundImage.CreateITalkBackgroundImage(builder, _o.Type, imageAssetOffset);
		}

		// Token: 0x04012DA8 RID: 77224
		private Table __p;
	}
}
