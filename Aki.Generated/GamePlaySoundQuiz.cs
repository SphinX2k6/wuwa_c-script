using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DD3 RID: 3539
	public struct GamePlaySoundQuiz : IFlatbufferObject
	{
		// Token: 0x17001596 RID: 5526
		// (get) Token: 0x06007F90 RID: 32656 RVA: 0x00267B75 File Offset: 0x00265D75
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007F91 RID: 32657 RVA: 0x00267B82 File Offset: 0x00265D82
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007F92 RID: 32658 RVA: 0x00267B8C File Offset: 0x00265D8C
		public static GamePlaySoundQuiz GetRootAsGamePlaySoundQuiz(ByteBuffer _bb)
		{
			return GamePlaySoundQuiz.GetRootAsGamePlaySoundQuiz(_bb, default(GamePlaySoundQuiz));
		}

		// Token: 0x06007F93 RID: 32659 RVA: 0x00267BA8 File Offset: 0x00265DA8
		public static GamePlaySoundQuiz GetRootAsGamePlaySoundQuiz(ByteBuffer _bb, GamePlaySoundQuiz obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007F94 RID: 32660 RVA: 0x00267BC5 File Offset: 0x00265DC5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007F95 RID: 32661 RVA: 0x00267BD4 File Offset: 0x00265DD4
		public GamePlaySoundQuiz __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001597 RID: 5527
		// (get) Token: 0x06007F96 RID: 32662 RVA: 0x00267BE4 File Offset: 0x00265DE4
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

		// Token: 0x17001598 RID: 5528
		// (get) Token: 0x06007F97 RID: 32663 RVA: 0x00267C20 File Offset: 0x00265E20
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

		// Token: 0x17001599 RID: 5529
		// (get) Token: 0x06007F98 RID: 32664 RVA: 0x00267C5C File Offset: 0x00265E5C
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

		// Token: 0x06007F99 RID: 32665 RVA: 0x00267C93 File Offset: 0x00265E93
		public Span<byte> GetTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06007F9A RID: 32666 RVA: 0x00267CA2 File Offset: 0x00265EA2
		public byte[] GetTypeArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x1700159A RID: 5530
		// (get) Token: 0x06007F9B RID: 32667 RVA: 0x00267CBC File Offset: 0x00265EBC
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

		// Token: 0x06007F9C RID: 32668 RVA: 0x00267CF4 File Offset: 0x00265EF4
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06007F9D RID: 32669 RVA: 0x00267D04 File Offset: 0x00265F04
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x1700159B RID: 5531
		// (get) Token: 0x06007F9E RID: 32670 RVA: 0x00267D1C File Offset: 0x00265F1C
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

		// Token: 0x06007F9F RID: 32671 RVA: 0x00267D54 File Offset: 0x00265F54
		public Span<byte> GetInteractIdBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06007FA0 RID: 32672 RVA: 0x00267D64 File Offset: 0x00265F64
		public byte[] GetInteractIdArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x04005344 RID: 21316
		private Table __p;
	}
}
