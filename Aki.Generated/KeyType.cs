using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D8B RID: 3467
	public struct KeyType : IFlatbufferObject
	{
		// Token: 0x17001A79 RID: 6777
		// (get) Token: 0x0600878D RID: 34701 RVA: 0x00268ACD File Offset: 0x00266CCD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600878E RID: 34702 RVA: 0x00268ADA File Offset: 0x00266CDA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600878F RID: 34703 RVA: 0x00268AE4 File Offset: 0x00266CE4
		public static KeyType GetRootAsKeyType(ByteBuffer _bb)
		{
			return KeyType.GetRootAsKeyType(_bb, default(KeyType));
		}

		// Token: 0x06008790 RID: 34704 RVA: 0x00268B00 File Offset: 0x00266D00
		public static KeyType GetRootAsKeyType(ByteBuffer _bb, KeyType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008791 RID: 34705 RVA: 0x00268B1D File Offset: 0x00266D1D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008792 RID: 34706 RVA: 0x00268B2C File Offset: 0x00266D2C
		public KeyType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001A7A RID: 6778
		// (get) Token: 0x06008793 RID: 34707 RVA: 0x00268B3C File Offset: 0x00266D3C
		public int TypeId
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001A7B RID: 6779
		// (get) Token: 0x06008794 RID: 34708 RVA: 0x00268B78 File Offset: 0x00266D78
		public string Name
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

		// Token: 0x06008795 RID: 34709 RVA: 0x00268BAF File Offset: 0x00266DAF
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06008796 RID: 34710 RVA: 0x00268BBE File Offset: 0x00266DBE
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17001A7C RID: 6780
		// (get) Token: 0x06008797 RID: 34711 RVA: 0x00268BD8 File Offset: 0x00266DD8
		public string IconSpritePath
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

		// Token: 0x06008798 RID: 34712 RVA: 0x00268C0F File Offset: 0x00266E0F
		public Span<byte> GetIconSpritePathBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06008799 RID: 34713 RVA: 0x00268C1E File Offset: 0x00266E1E
		public byte[] GetIconSpritePathArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x04004E17 RID: 19991
		private Table __p;
	}
}
