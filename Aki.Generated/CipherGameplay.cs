using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B7D RID: 2941
	public struct CipherGameplay : IFlatbufferObject
	{
		// Token: 0x1700082A RID: 2090
		// (get) Token: 0x060055AF RID: 21935 RVA: 0x001F6521 File Offset: 0x001F4721
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060055B0 RID: 21936 RVA: 0x001F652E File Offset: 0x001F472E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060055B1 RID: 21937 RVA: 0x001F6538 File Offset: 0x001F4738
		public static CipherGameplay GetRootAsCipherGameplay(ByteBuffer _bb)
		{
			return CipherGameplay.GetRootAsCipherGameplay(_bb, default(CipherGameplay));
		}

		// Token: 0x060055B2 RID: 21938 RVA: 0x001F6554 File Offset: 0x001F4754
		public static CipherGameplay GetRootAsCipherGameplay(ByteBuffer _bb, CipherGameplay obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060055B3 RID: 21939 RVA: 0x001F6571 File Offset: 0x001F4771
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060055B4 RID: 21940 RVA: 0x001F6580 File Offset: 0x001F4780
		public CipherGameplay __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700082B RID: 2091
		// (get) Token: 0x060055B5 RID: 21941 RVA: 0x001F6590 File Offset: 0x001F4790
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

		// Token: 0x060055B6 RID: 21942 RVA: 0x001F65C7 File Offset: 0x001F47C7
		public Span<byte> GetIdBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x060055B7 RID: 21943 RVA: 0x001F65D6 File Offset: 0x001F47D6
		public byte[] GetIdArray()
		{
			return this.__p.__vector_as_array<byte>(4) ?? Array.Empty<byte>();
		}

		// Token: 0x1700082C RID: 2092
		// (get) Token: 0x060055B8 RID: 21944 RVA: 0x001F65F0 File Offset: 0x001F47F0
		public int Password
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x04004B81 RID: 19329
		private Table __p;
	}
}
