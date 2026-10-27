using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CEF RID: 3311
	public struct GamePlaySoundQuiz : IFlatbufferObject
	{
		// Token: 0x17001539 RID: 5433
		// (get) Token: 0x06007985 RID: 31109 RVA: 0x002490F1 File Offset: 0x002472F1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007986 RID: 31110 RVA: 0x002490FE File Offset: 0x002472FE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007987 RID: 31111 RVA: 0x00249108 File Offset: 0x00247308
		public static GamePlaySoundQuiz GetRootAsGamePlaySoundQuiz(ByteBuffer _bb)
		{
			return GamePlaySoundQuiz.GetRootAsGamePlaySoundQuiz(_bb, default(GamePlaySoundQuiz));
		}

		// Token: 0x06007988 RID: 31112 RVA: 0x00249124 File Offset: 0x00247324
		public static GamePlaySoundQuiz GetRootAsGamePlaySoundQuiz(ByteBuffer _bb, GamePlaySoundQuiz obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007989 RID: 31113 RVA: 0x00249141 File Offset: 0x00247341
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600798A RID: 31114 RVA: 0x00249150 File Offset: 0x00247350
		public GamePlaySoundQuiz __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700153A RID: 5434
		// (get) Token: 0x0600798B RID: 31115 RVA: 0x00249160 File Offset: 0x00247360
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

		// Token: 0x1700153B RID: 5435
		// (get) Token: 0x0600798C RID: 31116 RVA: 0x0024919C File Offset: 0x0024739C
		public int SoundNum
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700153C RID: 5436
		// (get) Token: 0x0600798D RID: 31117 RVA: 0x002491D8 File Offset: 0x002473D8
		public string Type
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

		// Token: 0x0600798E RID: 31118 RVA: 0x0024920F File Offset: 0x0024740F
		public Span<byte> GetTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600798F RID: 31119 RVA: 0x0024921E File Offset: 0x0024741E
		public byte[] GetTypeArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x1700153D RID: 5437
		// (get) Token: 0x06007990 RID: 31120 RVA: 0x00249238 File Offset: 0x00247438
		public string Name
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

		// Token: 0x06007991 RID: 31121 RVA: 0x00249270 File Offset: 0x00247470
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06007992 RID: 31122 RVA: 0x00249280 File Offset: 0x00247480
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x1700153E RID: 5438
		// (get) Token: 0x06007993 RID: 31123 RVA: 0x00249298 File Offset: 0x00247498
		public string InteractId
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06007994 RID: 31124 RVA: 0x002492D0 File Offset: 0x002474D0
		public Span<byte> GetInteractIdBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06007995 RID: 31125 RVA: 0x002492E0 File Offset: 0x002474E0
		public byte[] GetInteractIdArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x04004D60 RID: 19808
		private Table __p;
	}
}
