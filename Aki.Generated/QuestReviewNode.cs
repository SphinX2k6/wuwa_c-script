using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200105B RID: 4187
	public struct QuestReviewNode : IFlatbufferObject
	{
		// Token: 0x17002C48 RID: 11336
		// (get) Token: 0x0600BC29 RID: 48169 RVA: 0x002ED2CC File Offset: 0x002EB4CC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600BC2A RID: 48170 RVA: 0x002ED2D9 File Offset: 0x002EB4D9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600BC2B RID: 48171 RVA: 0x002ED2E0 File Offset: 0x002EB4E0
		public static QuestReviewNode GetRootAsQuestReviewNode(ByteBuffer _bb)
		{
			return QuestReviewNode.GetRootAsQuestReviewNode(_bb, default(QuestReviewNode));
		}

		// Token: 0x0600BC2C RID: 48172 RVA: 0x002ED2FC File Offset: 0x002EB4FC
		public static QuestReviewNode GetRootAsQuestReviewNode(ByteBuffer _bb, QuestReviewNode obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600BC2D RID: 48173 RVA: 0x002ED319 File Offset: 0x002EB519
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600BC2E RID: 48174 RVA: 0x002ED328 File Offset: 0x002EB528
		public QuestReviewNode __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002C49 RID: 11337
		// (get) Token: 0x0600BC2F RID: 48175 RVA: 0x002ED338 File Offset: 0x002EB538
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

		// Token: 0x17002C4A RID: 11338
		// (get) Token: 0x0600BC30 RID: 48176 RVA: 0x002ED374 File Offset: 0x002EB574
		public int QuestLine
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

		// Token: 0x17002C4B RID: 11339
		// (get) Token: 0x0600BC31 RID: 48177 RVA: 0x002ED3B0 File Offset: 0x002EB5B0
		public int PosIndex
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

		// Token: 0x17002C4C RID: 11340
		// (get) Token: 0x0600BC32 RID: 48178 RVA: 0x002ED3EC File Offset: 0x002EB5EC
		public int SuccessorNodeId
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

		// Token: 0x17002C4D RID: 11341
		// (get) Token: 0x0600BC33 RID: 48179 RVA: 0x002ED42C File Offset: 0x002EB62C
		public string Title
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

		// Token: 0x0600BC34 RID: 48180 RVA: 0x002ED464 File Offset: 0x002EB664
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600BC35 RID: 48181 RVA: 0x002ED474 File Offset: 0x002EB674
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17002C4E RID: 11342
		// (get) Token: 0x0600BC36 RID: 48182 RVA: 0x002ED48C File Offset: 0x002EB68C
		public string Desc
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

		// Token: 0x0600BC37 RID: 48183 RVA: 0x002ED4C4 File Offset: 0x002EB6C4
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600BC38 RID: 48184 RVA: 0x002ED4D4 File Offset: 0x002EB6D4
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17002C4F RID: 11343
		// (get) Token: 0x0600BC39 RID: 48185 RVA: 0x002ED4EC File Offset: 0x002EB6EC
		public string DescFemale
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

		// Token: 0x0600BC3A RID: 48186 RVA: 0x002ED524 File Offset: 0x002EB724
		public Span<byte> GetDescFemaleBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600BC3B RID: 48187 RVA: 0x002ED534 File Offset: 0x002EB734
		public byte[] GetDescFemaleArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17002C50 RID: 11344
		// (get) Token: 0x0600BC3C RID: 48188 RVA: 0x002ED54C File Offset: 0x002EB74C
		public string Brief
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

		// Token: 0x0600BC3D RID: 48189 RVA: 0x002ED584 File Offset: 0x002EB784
		public Span<byte> GetBriefBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600BC3E RID: 48190 RVA: 0x002ED594 File Offset: 0x002EB794
		public byte[] GetBriefArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17002C51 RID: 11345
		// (get) Token: 0x0600BC3F RID: 48191 RVA: 0x002ED5AC File Offset: 0x002EB7AC
		public string ImageSmallMale
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

		// Token: 0x0600BC40 RID: 48192 RVA: 0x002ED5E4 File Offset: 0x002EB7E4
		public Span<byte> GetImageSmallMaleBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600BC41 RID: 48193 RVA: 0x002ED5F4 File Offset: 0x002EB7F4
		public byte[] GetImageSmallMaleArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x17002C52 RID: 11346
		// (get) Token: 0x0600BC42 RID: 48194 RVA: 0x002ED60C File Offset: 0x002EB80C
		public string ImageSmallFemale
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600BC43 RID: 48195 RVA: 0x002ED644 File Offset: 0x002EB844
		public Span<byte> GetImageSmallFemaleBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x0600BC44 RID: 48196 RVA: 0x002ED654 File Offset: 0x002EB854
		public byte[] GetImageSmallFemaleArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x17002C53 RID: 11347
		// (get) Token: 0x0600BC45 RID: 48197 RVA: 0x002ED66C File Offset: 0x002EB86C
		public string ImageLargeMale
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600BC46 RID: 48198 RVA: 0x002ED6A4 File Offset: 0x002EB8A4
		public Span<byte> GetImageLargeMaleBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x0600BC47 RID: 48199 RVA: 0x002ED6B4 File Offset: 0x002EB8B4
		public byte[] GetImageLargeMaleArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x17002C54 RID: 11348
		// (get) Token: 0x0600BC48 RID: 48200 RVA: 0x002ED6CC File Offset: 0x002EB8CC
		public string ImageLargeFemale
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600BC49 RID: 48201 RVA: 0x002ED704 File Offset: 0x002EB904
		public Span<byte> GetImageLargeFemaleBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x0600BC4A RID: 48202 RVA: 0x002ED714 File Offset: 0x002EB914
		public byte[] GetImageLargeFemaleArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x17002C55 RID: 11349
		// (get) Token: 0x0600BC4B RID: 48203 RVA: 0x002ED72C File Offset: 0x002EB92C
		public bool ShowOnceUnlock
		{
			get
			{
				int num = this.__p.__offset(28);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x04005629 RID: 22057
		private Table __p;
	}
}
