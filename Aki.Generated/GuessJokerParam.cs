using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DF7 RID: 3575
	public struct GuessJokerParam : IFlatbufferObject
	{
		// Token: 0x1700169B RID: 5787
		// (get) Token: 0x06008254 RID: 33364 RVA: 0x0026DC62 File Offset: 0x0026BE62
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008255 RID: 33365 RVA: 0x0026DC6F File Offset: 0x0026BE6F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008256 RID: 33366 RVA: 0x0026DC78 File Offset: 0x0026BE78
		public static GuessJokerParam GetRootAsGuessJokerParam(ByteBuffer _bb)
		{
			return GuessJokerParam.GetRootAsGuessJokerParam(_bb, default(GuessJokerParam));
		}

		// Token: 0x06008257 RID: 33367 RVA: 0x0026DC94 File Offset: 0x0026BE94
		public static GuessJokerParam GetRootAsGuessJokerParam(ByteBuffer _bb, GuessJokerParam obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008258 RID: 33368 RVA: 0x0026DCB1 File Offset: 0x0026BEB1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008259 RID: 33369 RVA: 0x0026DCC0 File Offset: 0x0026BEC0
		public GuessJokerParam __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700169C RID: 5788
		// (get) Token: 0x0600825A RID: 33370 RVA: 0x0026DCD0 File Offset: 0x0026BED0
		public string Key
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

		// Token: 0x0600825B RID: 33371 RVA: 0x0026DD07 File Offset: 0x0026BF07
		public Span<byte> GetKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0600825C RID: 33372 RVA: 0x0026DD16 File Offset: 0x0026BF16
		public byte[] GetKeyArray()
		{
			return this.__p.__vector_as_array<byte>(4) ?? Array.Empty<byte>();
		}

		// Token: 0x1700169D RID: 5789
		// (get) Token: 0x0600825D RID: 33373 RVA: 0x0026DD30 File Offset: 0x0026BF30
		public int Value
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

		// Token: 0x0400536F RID: 21359
		private Table __p;
	}
}
