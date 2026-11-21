using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200105A RID: 4186
	public struct QuestReviewLine : IFlatbufferObject
	{
		// Token: 0x17002C3F RID: 11327
		// (get) Token: 0x0600BC11 RID: 48145 RVA: 0x002ECFCB File Offset: 0x002EB1CB
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600BC12 RID: 48146 RVA: 0x002ECFD8 File Offset: 0x002EB1D8
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600BC13 RID: 48147 RVA: 0x002ECFE0 File Offset: 0x002EB1E0
		public static QuestReviewLine GetRootAsQuestReviewLine(ByteBuffer _bb)
		{
			return QuestReviewLine.GetRootAsQuestReviewLine(_bb, default(QuestReviewLine));
		}

		// Token: 0x0600BC14 RID: 48148 RVA: 0x002ECFFC File Offset: 0x002EB1FC
		public static QuestReviewLine GetRootAsQuestReviewLine(ByteBuffer _bb, QuestReviewLine obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600BC15 RID: 48149 RVA: 0x002ED019 File Offset: 0x002EB219
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600BC16 RID: 48150 RVA: 0x002ED028 File Offset: 0x002EB228
		public QuestReviewLine __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002C40 RID: 11328
		// (get) Token: 0x0600BC17 RID: 48151 RVA: 0x002ED038 File Offset: 0x002EB238
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

		// Token: 0x17002C41 RID: 11329
		// (get) Token: 0x0600BC18 RID: 48152 RVA: 0x002ED074 File Offset: 0x002EB274
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

		// Token: 0x17002C42 RID: 11330
		// (get) Token: 0x0600BC19 RID: 48153 RVA: 0x002ED0B0 File Offset: 0x002EB2B0
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

		// Token: 0x17002C43 RID: 11331
		// (get) Token: 0x0600BC1A RID: 48154 RVA: 0x002ED0EC File Offset: 0x002EB2EC
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

		// Token: 0x0600BC1B RID: 48155 RVA: 0x002ED124 File Offset: 0x002EB324
		public Span<byte> GetLineColorBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600BC1C RID: 48156 RVA: 0x002ED134 File Offset: 0x002EB334
		public byte[] GetLineColorArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17002C44 RID: 11332
		// (get) Token: 0x0600BC1D RID: 48157 RVA: 0x002ED14C File Offset: 0x002EB34C
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

		// Token: 0x0600BC1E RID: 48158 RVA: 0x002ED184 File Offset: 0x002EB384
		public Span<byte> GetShowSeqNameBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600BC1F RID: 48159 RVA: 0x002ED194 File Offset: 0x002EB394
		public byte[] GetShowSeqNameArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17002C45 RID: 11333
		// (get) Token: 0x0600BC20 RID: 48160 RVA: 0x002ED1AC File Offset: 0x002EB3AC
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

		// Token: 0x0600BC21 RID: 48161 RVA: 0x002ED1E4 File Offset: 0x002EB3E4
		public Span<byte> GetDestroySeqNameBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600BC22 RID: 48162 RVA: 0x002ED1F4 File Offset: 0x002EB3F4
		public byte[] GetDestroySeqNameArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17002C46 RID: 11334
		// (get) Token: 0x0600BC23 RID: 48163 RVA: 0x002ED20C File Offset: 0x002EB40C
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

		// Token: 0x0600BC24 RID: 48164 RVA: 0x002ED244 File Offset: 0x002EB444
		public Span<byte> GetStarIconBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600BC25 RID: 48165 RVA: 0x002ED254 File Offset: 0x002EB454
		public byte[] GetStarIconArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17002C47 RID: 11335
		// (get) Token: 0x0600BC26 RID: 48166 RVA: 0x002ED26C File Offset: 0x002EB46C
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

		// Token: 0x0600BC27 RID: 48167 RVA: 0x002ED2A4 File Offset: 0x002EB4A4
		public Span<byte> GetRoundIconBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600BC28 RID: 48168 RVA: 0x002ED2B4 File Offset: 0x002EB4B4
		public byte[] GetRoundIconArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x04005628 RID: 22056
		private Table __p;
	}
}
