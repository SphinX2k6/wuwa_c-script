using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B62 RID: 2914
	public struct CatchSignalGameplay : IFlatbufferObject
	{
		// Token: 0x1700070C RID: 1804
		// (get) Token: 0x06005276 RID: 21110 RVA: 0x001EF93A File Offset: 0x001EDB3A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06005277 RID: 21111 RVA: 0x001EF947 File Offset: 0x001EDB47
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06005278 RID: 21112 RVA: 0x001EF950 File Offset: 0x001EDB50
		public static CatchSignalGameplay GetRootAsCatchSignalGameplay(ByteBuffer _bb)
		{
			return CatchSignalGameplay.GetRootAsCatchSignalGameplay(_bb, default(CatchSignalGameplay));
		}

		// Token: 0x06005279 RID: 21113 RVA: 0x001EF96C File Offset: 0x001EDB6C
		public static CatchSignalGameplay GetRootAsCatchSignalGameplay(ByteBuffer _bb, CatchSignalGameplay obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600527A RID: 21114 RVA: 0x001EF989 File Offset: 0x001EDB89
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600527B RID: 21115 RVA: 0x001EF998 File Offset: 0x001EDB98
		public CatchSignalGameplay __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700070D RID: 1805
		// (get) Token: 0x0600527C RID: 21116 RVA: 0x001EF9A8 File Offset: 0x001EDBA8
		public string Id
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

		// Token: 0x0600527D RID: 21117 RVA: 0x001EF9DF File Offset: 0x001EDBDF
		public Span<byte> GetIdBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0600527E RID: 21118 RVA: 0x001EF9EE File Offset: 0x001EDBEE
		public byte[] GetIdArray()
		{
			return this.__p.__vector_as_array<byte>(4) ?? Array.Empty<byte>();
		}

		// Token: 0x1700070E RID: 1806
		// (get) Token: 0x0600527F RID: 21119 RVA: 0x001EFA08 File Offset: 0x001EDC08
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

		// Token: 0x06005280 RID: 21120 RVA: 0x001EFA3F File Offset: 0x001EDC3F
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06005281 RID: 21121 RVA: 0x001EFA4E File Offset: 0x001EDC4E
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x1700070F RID: 1807
		// (get) Token: 0x06005282 RID: 21122 RVA: 0x001EFA68 File Offset: 0x001EDC68
		public int Type
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000710 RID: 1808
		// (get) Token: 0x06005283 RID: 21123 RVA: 0x001EFAA4 File Offset: 0x001EDCA4
		public string MorseCode
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06005284 RID: 21124 RVA: 0x001EFADC File Offset: 0x001EDCDC
		public Span<byte> GetMorseCodeBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06005285 RID: 21125 RVA: 0x001EFAEC File Offset: 0x001EDCEC
		public byte[] GetMorseCodeArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17000711 RID: 1809
		// (get) Token: 0x06005286 RID: 21126 RVA: 0x001EFB04 File Offset: 0x001EDD04
		public int Difficulty
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x04004B62 RID: 19298
		private Table __p;
	}
}
