using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F73 RID: 3955
	public struct QuestReviewLine : IFlatbufferObject
	{
		// Token: 0x17002BC7 RID: 11207
		// (get) Token: 0x0600B5D4 RID: 46548 RVA: 0x002D042D File Offset: 0x002CE62D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B5D5 RID: 46549 RVA: 0x002D043A File Offset: 0x002CE63A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B5D6 RID: 46550 RVA: 0x002D0444 File Offset: 0x002CE644
		public static QuestReviewLine GetRootAsQuestReviewLine(ByteBuffer _bb)
		{
			return QuestReviewLine.GetRootAsQuestReviewLine(_bb, default(QuestReviewLine));
		}

		// Token: 0x0600B5D7 RID: 46551 RVA: 0x002D0460 File Offset: 0x002CE660
		public static QuestReviewLine GetRootAsQuestReviewLine(ByteBuffer _bb, QuestReviewLine obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B5D8 RID: 46552 RVA: 0x002D047D File Offset: 0x002CE67D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B5D9 RID: 46553 RVA: 0x002D048C File Offset: 0x002CE68C
		public QuestReviewLine __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002BC8 RID: 11208
		// (get) Token: 0x0600B5DA RID: 46554 RVA: 0x002D049C File Offset: 0x002CE69C
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

		// Token: 0x17002BC9 RID: 11209
		// (get) Token: 0x0600B5DB RID: 46555 RVA: 0x002D04D8 File Offset: 0x002CE6D8
		public int DisplayOrder
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

		// Token: 0x17002BCA RID: 11210
		// (get) Token: 0x0600B5DC RID: 46556 RVA: 0x002D0514 File Offset: 0x002CE714
		public int StartNodeId
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

		// Token: 0x17002BCB RID: 11211
		// (get) Token: 0x0600B5DD RID: 46557 RVA: 0x002D0550 File Offset: 0x002CE750
		public string LineColor
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

		// Token: 0x0600B5DE RID: 46558 RVA: 0x002D0588 File Offset: 0x002CE788
		public Span<byte> GetLineColorBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600B5DF RID: 46559 RVA: 0x002D0598 File Offset: 0x002CE798
		public byte[] GetLineColorArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17002BCC RID: 11212
		// (get) Token: 0x0600B5E0 RID: 46560 RVA: 0x002D05B0 File Offset: 0x002CE7B0
		public string ShowSeqName
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

		// Token: 0x0600B5E1 RID: 46561 RVA: 0x002D05E8 File Offset: 0x002CE7E8
		public Span<byte> GetShowSeqNameBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600B5E2 RID: 46562 RVA: 0x002D05F8 File Offset: 0x002CE7F8
		public byte[] GetShowSeqNameArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17002BCD RID: 11213
		// (get) Token: 0x0600B5E3 RID: 46563 RVA: 0x002D0610 File Offset: 0x002CE810
		public string DestroySeqName
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

		// Token: 0x0600B5E4 RID: 46564 RVA: 0x002D0648 File Offset: 0x002CE848
		public Span<byte> GetDestroySeqNameBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600B5E5 RID: 46565 RVA: 0x002D0658 File Offset: 0x002CE858
		public byte[] GetDestroySeqNameArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17002BCE RID: 11214
		// (get) Token: 0x0600B5E6 RID: 46566 RVA: 0x002D0670 File Offset: 0x002CE870
		public string StarIcon
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

		// Token: 0x0600B5E7 RID: 46567 RVA: 0x002D06A8 File Offset: 0x002CE8A8
		public Span<byte> GetStarIconBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600B5E8 RID: 46568 RVA: 0x002D06B8 File Offset: 0x002CE8B8
		public byte[] GetStarIconArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17002BCF RID: 11215
		// (get) Token: 0x0600B5E9 RID: 46569 RVA: 0x002D06D0 File Offset: 0x002CE8D0
		public string RoundIcon
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

		// Token: 0x0600B5EA RID: 46570 RVA: 0x002D0708 File Offset: 0x002CE908
		public Span<byte> GetRoundIconBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600B5EB RID: 46571 RVA: 0x002D0718 File Offset: 0x002CE918
		public byte[] GetRoundIconArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x04005041 RID: 20545
		private Table __p;
	}
}
