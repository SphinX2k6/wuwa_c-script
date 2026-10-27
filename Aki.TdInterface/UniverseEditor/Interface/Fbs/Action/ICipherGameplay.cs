using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200636D RID: 25453
	public struct ICipherGameplay : IFlatbufferObject
	{
		// Token: 0x1700BDDE RID: 48606
		// (get) Token: 0x0602C07F RID: 180351 RVA: 0x0060CC20 File Offset: 0x0060AE20
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602C080 RID: 180352 RVA: 0x0060CC2D File Offset: 0x0060AE2D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602C081 RID: 180353 RVA: 0x0060CC34 File Offset: 0x0060AE34
		public static ICipherGameplay GetRootAsICipherGameplay(ByteBuffer _bb)
		{
			return ICipherGameplay.GetRootAsICipherGameplay(_bb, default(ICipherGameplay));
		}

		// Token: 0x0602C082 RID: 180354 RVA: 0x0060CC50 File Offset: 0x0060AE50
		public static ICipherGameplay GetRootAsICipherGameplay(ByteBuffer _bb, ICipherGameplay obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602C083 RID: 180355 RVA: 0x0060CC6D File Offset: 0x0060AE6D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602C084 RID: 180356 RVA: 0x0060CC7C File Offset: 0x0060AE7C
		public ICipherGameplay __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BDDF RID: 48607
		// (get) Token: 0x0602C085 RID: 180357 RVA: 0x0060CC8C File Offset: 0x0060AE8C
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

		// Token: 0x1700BDE0 RID: 48608
		// (get) Token: 0x0602C086 RID: 180358 RVA: 0x0060CCC8 File Offset: 0x0060AEC8
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

		// Token: 0x0602C087 RID: 180359 RVA: 0x0060CCFF File Offset: 0x0060AEFF
		public Span<byte> GetCipherIdBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0602C088 RID: 180360 RVA: 0x0060CD0E File Offset: 0x0060AF0E
		public byte[] GetCipherIdArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x0602C089 RID: 180361 RVA: 0x0060CD1C File Offset: 0x0060AF1C
		public static Offset<ICipherGameplay> CreateICipherGameplay(FlatBufferBuilder builder, ESimpleGameplayType Type = ESimpleGameplayType.Cipher, StringOffset CipherIdOffset = default(StringOffset))
		{
			builder.StartTable(2);
			ICipherGameplay.AddCipherId(builder, CipherIdOffset);
			ICipherGameplay.AddType(builder, Type);
			return ICipherGameplay.EndICipherGameplay(builder);
		}

		// Token: 0x0602C08A RID: 180362 RVA: 0x0060CD39 File Offset: 0x0060AF39
		public static void StartICipherGameplay(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602C08B RID: 180363 RVA: 0x0060CD42 File Offset: 0x0060AF42
		public static void AddType(FlatBufferBuilder builder, ESimpleGameplayType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602C08C RID: 180364 RVA: 0x0060CD4D File Offset: 0x0060AF4D
		public static void AddCipherId(FlatBufferBuilder builder, StringOffset cipherIdOffset)
		{
			builder.AddOffset(1, cipherIdOffset.Value, 0);
		}

		// Token: 0x0602C08D RID: 180365 RVA: 0x0060CD5D File Offset: 0x0060AF5D
		public static Offset<ICipherGameplay> EndICipherGameplay(FlatBufferBuilder builder)
		{
			return new Offset<ICipherGameplay>(builder.EndTable());
		}

		// Token: 0x0602C08E RID: 180366 RVA: 0x0060CD6C File Offset: 0x0060AF6C
		public ICipherGameplayT UnPack()
		{
			ICipherGameplayT cipherGameplayT = new ICipherGameplayT();
			this.UnPackTo(cipherGameplayT);
			return cipherGameplayT;
		}

		// Token: 0x0602C08F RID: 180367 RVA: 0x0060CD87 File Offset: 0x0060AF87
		public void UnPackTo(ICipherGameplayT _o)
		{
			_o.Type = this.Type;
			_o.CipherId = this.CipherId;
		}

		// Token: 0x0602C090 RID: 180368 RVA: 0x0060CDA4 File Offset: 0x0060AFA4
		public static Offset<ICipherGameplay> Pack(FlatBufferBuilder builder, ICipherGameplayT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICipherGameplay>);
			}
			StringOffset cipherIdOffset = (_o.CipherId == null) ? default(StringOffset) : builder.CreateString(_o.CipherId);
			return ICipherGameplay.CreateICipherGameplay(builder, _o.Type, cipherIdOffset);
		}

		// Token: 0x0401093D RID: 67901
		private Table __p;
	}
}
