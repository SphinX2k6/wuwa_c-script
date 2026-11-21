using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DB9 RID: 3513
	public struct FunPlayActivityChallenge : IFlatbufferObject
	{
		// Token: 0x170014AF RID: 5295
		// (get) Token: 0x06007D4C RID: 32076 RVA: 0x00262C05 File Offset: 0x00260E05
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007D4D RID: 32077 RVA: 0x00262C12 File Offset: 0x00260E12
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007D4E RID: 32078 RVA: 0x00262C1C File Offset: 0x00260E1C
		public static FunPlayActivityChallenge GetRootAsFunPlayActivityChallenge(ByteBuffer _bb)
		{
			return FunPlayActivityChallenge.GetRootAsFunPlayActivityChallenge(_bb, default(FunPlayActivityChallenge));
		}

		// Token: 0x06007D4F RID: 32079 RVA: 0x00262C38 File Offset: 0x00260E38
		public static FunPlayActivityChallenge GetRootAsFunPlayActivityChallenge(ByteBuffer _bb, FunPlayActivityChallenge obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007D50 RID: 32080 RVA: 0x00262C55 File Offset: 0x00260E55
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007D51 RID: 32081 RVA: 0x00262C64 File Offset: 0x00260E64
		public FunPlayActivityChallenge __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170014B0 RID: 5296
		// (get) Token: 0x06007D52 RID: 32082 RVA: 0x00262C74 File Offset: 0x00260E74
		public int Id
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

		// Token: 0x170014B1 RID: 5297
		// (get) Token: 0x06007D53 RID: 32083 RVA: 0x00262CB0 File Offset: 0x00260EB0
		public int InstId
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

		// Token: 0x170014B2 RID: 5298
		// (get) Token: 0x06007D54 RID: 32084 RVA: 0x00262CEC File Offset: 0x00260EEC
		public int ActivityId
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170014B3 RID: 5299
		// (get) Token: 0x06007D55 RID: 32085 RVA: 0x00262D28 File Offset: 0x00260F28
		public int OpenDay
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170014B4 RID: 5300
		// (get) Token: 0x06007D56 RID: 32086 RVA: 0x00262D68 File Offset: 0x00260F68
		public int RewardId
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

		// Token: 0x170014B5 RID: 5301
		// (get) Token: 0x06007D57 RID: 32087 RVA: 0x00262DA8 File Offset: 0x00260FA8
		public string Title
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06007D58 RID: 32088 RVA: 0x00262DE0 File Offset: 0x00260FE0
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06007D59 RID: 32089 RVA: 0x00262DF0 File Offset: 0x00260FF0
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x170014B6 RID: 5302
		// (get) Token: 0x06007D5A RID: 32090 RVA: 0x00262E08 File Offset: 0x00261008
		public string Desc
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06007D5B RID: 32091 RVA: 0x00262E40 File Offset: 0x00261040
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06007D5C RID: 32092 RVA: 0x00262E50 File Offset: 0x00261050
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x170014B7 RID: 5303
		// (get) Token: 0x06007D5D RID: 32093 RVA: 0x00262E68 File Offset: 0x00261068
		public string TabTitle
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06007D5E RID: 32094 RVA: 0x00262EA0 File Offset: 0x002610A0
		public Span<byte> GetTabTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06007D5F RID: 32095 RVA: 0x00262EB0 File Offset: 0x002610B0
		public byte[] GetTabTitleArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x170014B8 RID: 5304
		// (get) Token: 0x06007D60 RID: 32096 RVA: 0x00262EC8 File Offset: 0x002610C8
		public string BackGroundTexture
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06007D61 RID: 32097 RVA: 0x00262F00 File Offset: 0x00261100
		public Span<byte> GetBackGroundTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x06007D62 RID: 32098 RVA: 0x00262F10 File Offset: 0x00261110
		public byte[] GetBackGroundTextureArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x04005329 RID: 21289
		private Table __p;
	}
}
