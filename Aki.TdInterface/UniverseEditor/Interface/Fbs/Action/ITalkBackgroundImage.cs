using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200729B RID: 29339
	public struct ITalkBackgroundImage : IFlatbufferObject
	{
		// Token: 0x1700D998 RID: 55704
		// (get) Token: 0x060340CF RID: 213199 RVA: 0x006FF5CD File Offset: 0x006FD7CD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060340D0 RID: 213200 RVA: 0x006FF5DA File Offset: 0x006FD7DA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060340D1 RID: 213201 RVA: 0x006FF5E4 File Offset: 0x006FD7E4
		public static ITalkBackgroundImage GetRootAsITalkBackgroundImage(ByteBuffer _bb)
		{
			return ITalkBackgroundImage.GetRootAsITalkBackgroundImage(_bb, default(ITalkBackgroundImage));
		}

		// Token: 0x060340D2 RID: 213202 RVA: 0x006FF600 File Offset: 0x006FD800
		public static ITalkBackgroundImage GetRootAsITalkBackgroundImage(ByteBuffer _bb, ITalkBackgroundImage obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060340D3 RID: 213203 RVA: 0x006FF61D File Offset: 0x006FD81D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060340D4 RID: 213204 RVA: 0x006FF62C File Offset: 0x006FD82C
		public ITalkBackgroundImage __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D999 RID: 55705
		// (get) Token: 0x060340D5 RID: 213205 RVA: 0x006FF63C File Offset: 0x006FD83C
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

		// Token: 0x1700D99A RID: 55706
		// (get) Token: 0x060340D6 RID: 213206 RVA: 0x006FF678 File Offset: 0x006FD878
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

		// Token: 0x060340D7 RID: 213207 RVA: 0x006FF6AF File Offset: 0x006FD8AF
		public Span<byte> GetImageAssetBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060340D8 RID: 213208 RVA: 0x006FF6BE File Offset: 0x006FD8BE
		public byte[] GetImageAssetArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x060340D9 RID: 213209 RVA: 0x006FF6CC File Offset: 0x006FD8CC
		public static Offset<ITalkBackgroundImage> CreateITalkBackgroundImage(FlatBufferBuilder builder, ETalkBackgroundType Type = ETalkBackgroundType.Clean, StringOffset ImageAssetOffset = default(StringOffset))
		{
			builder.StartTable(2);
			ITalkBackgroundImage.AddImageAsset(builder, ImageAssetOffset);
			ITalkBackgroundImage.AddType(builder, Type);
			return ITalkBackgroundImage.EndITalkBackgroundImage(builder);
		}

		// Token: 0x060340DA RID: 213210 RVA: 0x006FF6E9 File Offset: 0x006FD8E9
		public static void StartITalkBackgroundImage(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060340DB RID: 213211 RVA: 0x006FF6F2 File Offset: 0x006FD8F2
		public static void AddType(FlatBufferBuilder builder, ETalkBackgroundType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060340DC RID: 213212 RVA: 0x006FF6FD File Offset: 0x006FD8FD
		public static void AddImageAsset(FlatBufferBuilder builder, StringOffset imageAssetOffset)
		{
			builder.AddOffset(1, imageAssetOffset.Value, 0);
		}

		// Token: 0x060340DD RID: 213213 RVA: 0x006FF70D File Offset: 0x006FD90D
		public static Offset<ITalkBackgroundImage> EndITalkBackgroundImage(FlatBufferBuilder builder)
		{
			return new Offset<ITalkBackgroundImage>(builder.EndTable());
		}

		// Token: 0x060340DE RID: 213214 RVA: 0x006FF71C File Offset: 0x006FD91C
		public ITalkBackgroundImageT UnPack()
		{
			ITalkBackgroundImageT talkBackgroundImageT = new ITalkBackgroundImageT();
			this.UnPackTo(talkBackgroundImageT);
			return talkBackgroundImageT;
		}

		// Token: 0x060340DF RID: 213215 RVA: 0x006FF737 File Offset: 0x006FD937
		public void UnPackTo(ITalkBackgroundImageT _o)
		{
			_o.Type = this.Type;
			_o.ImageAsset = this.ImageAsset;
		}

		// Token: 0x060340E0 RID: 213216 RVA: 0x006FF754 File Offset: 0x006FD954
		public static Offset<ITalkBackgroundImage> Pack(FlatBufferBuilder builder, ITalkBackgroundImageT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITalkBackgroundImage>);
			}
			StringOffset imageAssetOffset = (_o.ImageAsset == null) ? default(StringOffset) : builder.CreateString(_o.ImageAsset);
			return ITalkBackgroundImage.CreateITalkBackgroundImage(builder, _o.Type, imageAssetOffset);
		}

		// Token: 0x04011DA5 RID: 73125
		private Table __p;
	}
}
