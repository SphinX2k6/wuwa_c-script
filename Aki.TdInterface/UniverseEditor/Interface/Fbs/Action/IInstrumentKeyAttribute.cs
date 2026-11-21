using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200701F RID: 28703
	public struct IInstrumentKeyAttribute : IFlatbufferObject
	{
		// Token: 0x1700D227 RID: 53799
		// (get) Token: 0x06031BB4 RID: 203700 RVA: 0x006BBBD7 File Offset: 0x006B9DD7
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06031BB5 RID: 203701 RVA: 0x006BBBE4 File Offset: 0x006B9DE4
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06031BB6 RID: 203702 RVA: 0x006BBBEC File Offset: 0x006B9DEC
		public static IInstrumentKeyAttribute GetRootAsIInstrumentKeyAttribute(ByteBuffer _bb)
		{
			return IInstrumentKeyAttribute.GetRootAsIInstrumentKeyAttribute(_bb, default(IInstrumentKeyAttribute));
		}

		// Token: 0x06031BB7 RID: 203703 RVA: 0x006BBC08 File Offset: 0x006B9E08
		public static IInstrumentKeyAttribute GetRootAsIInstrumentKeyAttribute(ByteBuffer _bb, IInstrumentKeyAttribute obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06031BB8 RID: 203704 RVA: 0x006BBC25 File Offset: 0x006B9E25
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06031BB9 RID: 203705 RVA: 0x006BBC34 File Offset: 0x006B9E34
		public IInstrumentKeyAttribute __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D228 RID: 53800
		// (get) Token: 0x06031BBA RID: 203706 RVA: 0x006BBC44 File Offset: 0x006B9E44
		public string FundamentalToneAssetPath
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

		// Token: 0x06031BBB RID: 203707 RVA: 0x006BBC7B File Offset: 0x006B9E7B
		public Span<byte> GetFundamentalToneAssetPathBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06031BBC RID: 203708 RVA: 0x006BBC8A File Offset: 0x006B9E8A
		public byte[] GetFundamentalToneAssetPathArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700D229 RID: 53801
		// (get) Token: 0x06031BBD RID: 203709 RVA: 0x006BBC98 File Offset: 0x006B9E98
		public string OverToneAssetPath
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

		// Token: 0x06031BBE RID: 203710 RVA: 0x006BBCCF File Offset: 0x006B9ECF
		public Span<byte> GetOverToneAssetPathBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06031BBF RID: 203711 RVA: 0x006BBCDE File Offset: 0x006B9EDE
		public byte[] GetOverToneAssetPathArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700D22A RID: 53802
		// (get) Token: 0x06031BC0 RID: 203712 RVA: 0x006BBCEC File Offset: 0x006B9EEC
		public string TextureAssetPath
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

		// Token: 0x06031BC1 RID: 203713 RVA: 0x006BBD23 File Offset: 0x006B9F23
		public Span<byte> GetTextureAssetPathBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06031BC2 RID: 203714 RVA: 0x006BBD32 File Offset: 0x006B9F32
		public byte[] GetTextureAssetPathArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x06031BC3 RID: 203715 RVA: 0x006BBD40 File Offset: 0x006B9F40
		public static Offset<IInstrumentKeyAttribute> CreateIInstrumentKeyAttribute(FlatBufferBuilder builder, StringOffset FundamentalToneAssetPathOffset = default(StringOffset), StringOffset OverToneAssetPathOffset = default(StringOffset), StringOffset TextureAssetPathOffset = default(StringOffset))
		{
			builder.StartTable(3);
			IInstrumentKeyAttribute.AddTextureAssetPath(builder, TextureAssetPathOffset);
			IInstrumentKeyAttribute.AddOverToneAssetPath(builder, OverToneAssetPathOffset);
			IInstrumentKeyAttribute.AddFundamentalToneAssetPath(builder, FundamentalToneAssetPathOffset);
			return IInstrumentKeyAttribute.EndIInstrumentKeyAttribute(builder);
		}

		// Token: 0x06031BC4 RID: 203716 RVA: 0x006BBD64 File Offset: 0x006B9F64
		public static void StartIInstrumentKeyAttribute(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06031BC5 RID: 203717 RVA: 0x006BBD6D File Offset: 0x006B9F6D
		public static void AddFundamentalToneAssetPath(FlatBufferBuilder builder, StringOffset fundamentalToneAssetPathOffset)
		{
			builder.AddOffset(0, fundamentalToneAssetPathOffset.Value, 0);
		}

		// Token: 0x06031BC6 RID: 203718 RVA: 0x006BBD7D File Offset: 0x006B9F7D
		public static void AddOverToneAssetPath(FlatBufferBuilder builder, StringOffset overToneAssetPathOffset)
		{
			builder.AddOffset(1, overToneAssetPathOffset.Value, 0);
		}

		// Token: 0x06031BC7 RID: 203719 RVA: 0x006BBD8D File Offset: 0x006B9F8D
		public static void AddTextureAssetPath(FlatBufferBuilder builder, StringOffset textureAssetPathOffset)
		{
			builder.AddOffset(2, textureAssetPathOffset.Value, 0);
		}

		// Token: 0x06031BC8 RID: 203720 RVA: 0x006BBD9D File Offset: 0x006B9F9D
		public static Offset<IInstrumentKeyAttribute> EndIInstrumentKeyAttribute(FlatBufferBuilder builder)
		{
			return new Offset<IInstrumentKeyAttribute>(builder.EndTable());
		}

		// Token: 0x06031BC9 RID: 203721 RVA: 0x006BBDAC File Offset: 0x006B9FAC
		public IInstrumentKeyAttributeT UnPack()
		{
			IInstrumentKeyAttributeT instrumentKeyAttributeT = new IInstrumentKeyAttributeT();
			this.UnPackTo(instrumentKeyAttributeT);
			return instrumentKeyAttributeT;
		}

		// Token: 0x06031BCA RID: 203722 RVA: 0x006BBDC7 File Offset: 0x006B9FC7
		public void UnPackTo(IInstrumentKeyAttributeT _o)
		{
			_o.FundamentalToneAssetPath = this.FundamentalToneAssetPath;
			_o.OverToneAssetPath = this.OverToneAssetPath;
			_o.TextureAssetPath = this.TextureAssetPath;
		}

		// Token: 0x06031BCB RID: 203723 RVA: 0x006BBDF0 File Offset: 0x006B9FF0
		public static Offset<IInstrumentKeyAttribute> Pack(FlatBufferBuilder builder, IInstrumentKeyAttributeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IInstrumentKeyAttribute>);
			}
			StringOffset fundamentalToneAssetPathOffset = (_o.FundamentalToneAssetPath == null) ? default(StringOffset) : builder.CreateString(_o.FundamentalToneAssetPath);
			StringOffset overToneAssetPathOffset = (_o.OverToneAssetPath == null) ? default(StringOffset) : builder.CreateString(_o.OverToneAssetPath);
			StringOffset textureAssetPathOffset = (_o.TextureAssetPath == null) ? default(StringOffset) : builder.CreateString(_o.TextureAssetPath);
			return IInstrumentKeyAttribute.CreateIInstrumentKeyAttribute(builder, fundamentalToneAssetPathOffset, overToneAssetPathOffset, textureAssetPathOffset);
		}

		// Token: 0x04011F5B RID: 73563
		private Table __p;
	}
}
