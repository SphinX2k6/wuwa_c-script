using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020069DE RID: 27102
	public struct ICipherGameplay : IFlatbufferObject
	{
		// Token: 0x1700C766 RID: 51046
		// (get) Token: 0x0602E7E9 RID: 190441 RVA: 0x00657D74 File Offset: 0x00655F74
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602E7EA RID: 190442 RVA: 0x00657D81 File Offset: 0x00655F81
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602E7EB RID: 190443 RVA: 0x00657D88 File Offset: 0x00655F88
		public static ICipherGameplay GetRootAsICipherGameplay(ByteBuffer _bb)
		{
			return ICipherGameplay.GetRootAsICipherGameplay(_bb, default(ICipherGameplay));
		}

		// Token: 0x0602E7EC RID: 190444 RVA: 0x00657DA4 File Offset: 0x00655FA4
		public static ICipherGameplay GetRootAsICipherGameplay(ByteBuffer _bb, ICipherGameplay obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602E7ED RID: 190445 RVA: 0x00657DC1 File Offset: 0x00655FC1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602E7EE RID: 190446 RVA: 0x00657DD0 File Offset: 0x00655FD0
		public ICipherGameplay __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C767 RID: 51047
		// (get) Token: 0x0602E7EF RID: 190447 RVA: 0x00657DE0 File Offset: 0x00655FE0
		public ESimpleGameplayType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESimpleGameplayType.Cipher;
				}
				return (ESimpleGameplayType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C768 RID: 51048
		// (get) Token: 0x0602E7F0 RID: 190448 RVA: 0x00657E1C File Offset: 0x0065601C
		public string CipherId
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

		// Token: 0x0602E7F1 RID: 190449 RVA: 0x00657E53 File Offset: 0x00656053
		public Span<byte> GetCipherIdBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0602E7F2 RID: 190450 RVA: 0x00657E62 File Offset: 0x00656062
		public byte[] GetCipherIdArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x0602E7F3 RID: 190451 RVA: 0x00657E70 File Offset: 0x00656070
		public static Offset<ICipherGameplay> CreateICipherGameplay(FlatBufferBuilder builder, ESimpleGameplayType Type = ESimpleGameplayType.Cipher, StringOffset CipherIdOffset = default(StringOffset))
		{
			builder.StartTable(2);
			ICipherGameplay.AddCipherId(builder, CipherIdOffset);
			ICipherGameplay.AddType(builder, Type);
			return ICipherGameplay.EndICipherGameplay(builder);
		}

		// Token: 0x0602E7F4 RID: 190452 RVA: 0x00657E8D File Offset: 0x0065608D
		public static void StartICipherGameplay(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602E7F5 RID: 190453 RVA: 0x00657E96 File Offset: 0x00656096
		public static void AddType(FlatBufferBuilder builder, ESimpleGameplayType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602E7F6 RID: 190454 RVA: 0x00657EA1 File Offset: 0x006560A1
		public static void AddCipherId(FlatBufferBuilder builder, StringOffset cipherIdOffset)
		{
			builder.AddOffset(1, cipherIdOffset.Value, 0);
		}

		// Token: 0x0602E7F7 RID: 190455 RVA: 0x00657EB1 File Offset: 0x006560B1
		public static Offset<ICipherGameplay> EndICipherGameplay(FlatBufferBuilder builder)
		{
			return new Offset<ICipherGameplay>(builder.EndTable());
		}

		// Token: 0x0602E7F8 RID: 190456 RVA: 0x00657EC0 File Offset: 0x006560C0
		public ICipherGameplayT UnPack()
		{
			ICipherGameplayT cipherGameplayT = new ICipherGameplayT();
			this.UnPackTo(cipherGameplayT);
			return cipherGameplayT;
		}

		// Token: 0x0602E7F9 RID: 190457 RVA: 0x00657EDB File Offset: 0x006560DB
		public void UnPackTo(ICipherGameplayT _o)
		{
			_o.Type = this.Type;
			_o.CipherId = this.CipherId;
		}

		// Token: 0x0602E7FA RID: 190458 RVA: 0x00657EF8 File Offset: 0x006560F8
		public static Offset<ICipherGameplay> Pack(FlatBufferBuilder builder, ICipherGameplayT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICipherGameplay>);
			}
			StringOffset cipherIdOffset = (_o.CipherId == null) ? default(StringOffset) : builder.CreateString(_o.CipherId);
			return ICipherGameplay.CreateICipherGameplay(builder, _o.Type, cipherIdOffset);
		}

		// Token: 0x04011752 RID: 71506
		private Table __p;
	}
}
