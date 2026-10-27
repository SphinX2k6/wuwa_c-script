using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200696C RID: 26988
	public struct IInstrumentKeyAttribute : IFlatbufferObject
	{
		// Token: 0x1700C824 RID: 51236
		// (get) Token: 0x0602F1E4 RID: 192996 RVA: 0x0066B6EF File Offset: 0x006698EF
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602F1E5 RID: 192997 RVA: 0x0066B6FC File Offset: 0x006698FC
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602F1E6 RID: 192998 RVA: 0x0066B704 File Offset: 0x00669904
		public static IInstrumentKeyAttribute GetRootAsIInstrumentKeyAttribute(ByteBuffer _bb)
		{
			return IInstrumentKeyAttribute.GetRootAsIInstrumentKeyAttribute(_bb, default(IInstrumentKeyAttribute));
		}

		// Token: 0x0602F1E7 RID: 192999 RVA: 0x0066B720 File Offset: 0x00669920
		public static IInstrumentKeyAttribute GetRootAsIInstrumentKeyAttribute(ByteBuffer _bb, IInstrumentKeyAttribute obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602F1E8 RID: 193000 RVA: 0x0066B73D File Offset: 0x0066993D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602F1E9 RID: 193001 RVA: 0x0066B74C File Offset: 0x0066994C
		public IInstrumentKeyAttribute __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C825 RID: 51237
		// (get) Token: 0x0602F1EA RID: 193002 RVA: 0x0066B75C File Offset: 0x0066995C
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

		// Token: 0x0602F1EB RID: 193003 RVA: 0x0066B793 File Offset: 0x00669993
		public Span<byte> GetFundamentalToneAssetPathBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0602F1EC RID: 193004 RVA: 0x0066B7A2 File Offset: 0x006699A2
		public byte[] GetFundamentalToneAssetPathArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700C826 RID: 51238
		// (get) Token: 0x0602F1ED RID: 193005 RVA: 0x0066B7B0 File Offset: 0x006699B0
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

		// Token: 0x0602F1EE RID: 193006 RVA: 0x0066B7E7 File Offset: 0x006699E7
		public Span<byte> GetOverToneAssetPathBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0602F1EF RID: 193007 RVA: 0x0066B7F6 File Offset: 0x006699F6
		public byte[] GetOverToneAssetPathArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700C827 RID: 51239
		// (get) Token: 0x0602F1F0 RID: 193008 RVA: 0x0066B804 File Offset: 0x00669A04
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

		// Token: 0x0602F1F1 RID: 193009 RVA: 0x0066B83B File Offset: 0x00669A3B
		public Span<byte> GetTextureAssetPathBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0602F1F2 RID: 193010 RVA: 0x0066B84A File Offset: 0x00669A4A
		public byte[] GetTextureAssetPathArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x0602F1F3 RID: 193011 RVA: 0x0066B858 File Offset: 0x00669A58
		public static Offset<IInstrumentKeyAttribute> CreateIInstrumentKeyAttribute(FlatBufferBuilder builder, StringOffset FundamentalToneAssetPathOffset = default(StringOffset), StringOffset OverToneAssetPathOffset = default(StringOffset), StringOffset TextureAssetPathOffset = default(StringOffset))
		{
			builder.StartTable(3);
			IInstrumentKeyAttribute.AddTextureAssetPath(builder, TextureAssetPathOffset);
			IInstrumentKeyAttribute.AddOverToneAssetPath(builder, OverToneAssetPathOffset);
			IInstrumentKeyAttribute.AddFundamentalToneAssetPath(builder, FundamentalToneAssetPathOffset);
			return IInstrumentKeyAttribute.EndIInstrumentKeyAttribute(builder);
		}

		// Token: 0x0602F1F4 RID: 193012 RVA: 0x0066B87C File Offset: 0x00669A7C
		public static void StartIInstrumentKeyAttribute(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602F1F5 RID: 193013 RVA: 0x0066B885 File Offset: 0x00669A85
		public static void AddFundamentalToneAssetPath(FlatBufferBuilder builder, StringOffset fundamentalToneAssetPathOffset)
		{
			builder.AddOffset(0, fundamentalToneAssetPathOffset.Value, 0);
		}

		// Token: 0x0602F1F6 RID: 193014 RVA: 0x0066B895 File Offset: 0x00669A95
		public static void AddOverToneAssetPath(FlatBufferBuilder builder, StringOffset overToneAssetPathOffset)
		{
			builder.AddOffset(1, overToneAssetPathOffset.Value, 0);
		}

		// Token: 0x0602F1F7 RID: 193015 RVA: 0x0066B8A5 File Offset: 0x00669AA5
		public static void AddTextureAssetPath(FlatBufferBuilder builder, StringOffset textureAssetPathOffset)
		{
			builder.AddOffset(2, textureAssetPathOffset.Value, 0);
		}

		// Token: 0x0602F1F8 RID: 193016 RVA: 0x0066B8B5 File Offset: 0x00669AB5
		public static Offset<IInstrumentKeyAttribute> EndIInstrumentKeyAttribute(FlatBufferBuilder builder)
		{
			return new Offset<IInstrumentKeyAttribute>(builder.EndTable());
		}

		// Token: 0x0602F1F9 RID: 193017 RVA: 0x0066B8C4 File Offset: 0x00669AC4
		public IInstrumentKeyAttributeT UnPack()
		{
			IInstrumentKeyAttributeT instrumentKeyAttributeT = new IInstrumentKeyAttributeT();
			this.UnPackTo(instrumentKeyAttributeT);
			return instrumentKeyAttributeT;
		}

		// Token: 0x0602F1FA RID: 193018 RVA: 0x0066B8DF File Offset: 0x00669ADF
		public void UnPackTo(IInstrumentKeyAttributeT _o)
		{
			_o.FundamentalToneAssetPath = this.FundamentalToneAssetPath;
			_o.OverToneAssetPath = this.OverToneAssetPath;
			_o.TextureAssetPath = this.TextureAssetPath;
		}

		// Token: 0x0602F1FB RID: 193019 RVA: 0x0066B908 File Offset: 0x00669B08
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

		// Token: 0x040110EF RID: 69871
		private Table __p;
	}
}
