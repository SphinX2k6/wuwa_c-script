using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020079D4 RID: 31188
	public struct ISubScreen : IFlatbufferObject
	{
		// Token: 0x1700E4A3 RID: 58531
		// (get) Token: 0x06036F26 RID: 225062 RVA: 0x00758B4D File Offset: 0x00756D4D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06036F27 RID: 225063 RVA: 0x00758B5A File Offset: 0x00756D5A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06036F28 RID: 225064 RVA: 0x00758B64 File Offset: 0x00756D64
		public static ISubScreen GetRootAsISubScreen(ByteBuffer _bb)
		{
			return ISubScreen.GetRootAsISubScreen(_bb, default(ISubScreen));
		}

		// Token: 0x06036F29 RID: 225065 RVA: 0x00758B80 File Offset: 0x00756D80
		public static ISubScreen GetRootAsISubScreen(ByteBuffer _bb, ISubScreen obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06036F2A RID: 225066 RVA: 0x00758B9D File Offset: 0x00756D9D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06036F2B RID: 225067 RVA: 0x00758BAC File Offset: 0x00756DAC
		public ISubScreen __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E4A4 RID: 58532
		// (get) Token: 0x06036F2C RID: 225068 RVA: 0x00758BBC File Offset: 0x00756DBC
		public EScreenType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EScreenType.Main;
				}
				return (EScreenType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700E4A5 RID: 58533
		// (get) Token: 0x06036F2D RID: 225069 RVA: 0x00758BF8 File Offset: 0x00756DF8
		public string SubScreenKey
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

		// Token: 0x06036F2E RID: 225070 RVA: 0x00758C2F File Offset: 0x00756E2F
		public Span<byte> GetSubScreenKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06036F2F RID: 225071 RVA: 0x00758C3E File Offset: 0x00756E3E
		public byte[] GetSubScreenKeyArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x06036F30 RID: 225072 RVA: 0x00758C4C File Offset: 0x00756E4C
		public static Offset<ISubScreen> CreateISubScreen(FlatBufferBuilder builder, EScreenType Type = EScreenType.Main, StringOffset SubScreenKeyOffset = default(StringOffset))
		{
			builder.StartTable(2);
			ISubScreen.AddSubScreenKey(builder, SubScreenKeyOffset);
			ISubScreen.AddType(builder, Type);
			return ISubScreen.EndISubScreen(builder);
		}

		// Token: 0x06036F31 RID: 225073 RVA: 0x00758C69 File Offset: 0x00756E69
		public static void StartISubScreen(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06036F32 RID: 225074 RVA: 0x00758C72 File Offset: 0x00756E72
		public static void AddType(FlatBufferBuilder builder, EScreenType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06036F33 RID: 225075 RVA: 0x00758C7D File Offset: 0x00756E7D
		public static void AddSubScreenKey(FlatBufferBuilder builder, StringOffset subScreenKeyOffset)
		{
			builder.AddOffset(1, subScreenKeyOffset.Value, 0);
		}

		// Token: 0x06036F34 RID: 225076 RVA: 0x00758C8D File Offset: 0x00756E8D
		public static Offset<ISubScreen> EndISubScreen(FlatBufferBuilder builder)
		{
			return new Offset<ISubScreen>(builder.EndTable());
		}

		// Token: 0x06036F35 RID: 225077 RVA: 0x00758C9C File Offset: 0x00756E9C
		public ISubScreenT UnPack()
		{
			ISubScreenT subScreenT = new ISubScreenT();
			this.UnPackTo(subScreenT);
			return subScreenT;
		}

		// Token: 0x06036F36 RID: 225078 RVA: 0x00758CB7 File Offset: 0x00756EB7
		public void UnPackTo(ISubScreenT _o)
		{
			_o.Type = this.Type;
			_o.SubScreenKey = this.SubScreenKey;
		}

		// Token: 0x06036F37 RID: 225079 RVA: 0x00758CD4 File Offset: 0x00756ED4
		public static Offset<ISubScreen> Pack(FlatBufferBuilder builder, ISubScreenT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISubScreen>);
			}
			StringOffset subScreenKeyOffset = (_o.SubScreenKey == null) ? default(StringOffset) : builder.CreateString(_o.SubScreenKey);
			return ISubScreen.CreateISubScreen(builder, _o.Type, subScreenKeyOffset);
		}

		// Token: 0x04012CE5 RID: 77029
		private Table __p;
	}
}
