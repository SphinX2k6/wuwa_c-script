using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F74 RID: 3956
	public struct QuestReviewNode : IFlatbufferObject
	{
		// Token: 0x17002BD0 RID: 11216
		// (get) Token: 0x0600B5EC RID: 46572 RVA: 0x002D0730 File Offset: 0x002CE930
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B5ED RID: 46573 RVA: 0x002D073D File Offset: 0x002CE93D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B5EE RID: 46574 RVA: 0x002D0744 File Offset: 0x002CE944
		public static QuestReviewNode GetRootAsQuestReviewNode(ByteBuffer _bb)
		{
			return QuestReviewNode.GetRootAsQuestReviewNode(_bb, default(QuestReviewNode));
		}

		// Token: 0x0600B5EF RID: 46575 RVA: 0x002D0760 File Offset: 0x002CE960
		public static QuestReviewNode GetRootAsQuestReviewNode(ByteBuffer _bb, QuestReviewNode obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B5F0 RID: 46576 RVA: 0x002D077D File Offset: 0x002CE97D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B5F1 RID: 46577 RVA: 0x002D078C File Offset: 0x002CE98C
		public QuestReviewNode __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002BD1 RID: 11217
		// (get) Token: 0x0600B5F2 RID: 46578 RVA: 0x002D079C File Offset: 0x002CE99C
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

		// Token: 0x17002BD2 RID: 11218
		// (get) Token: 0x0600B5F3 RID: 46579 RVA: 0x002D07D8 File Offset: 0x002CE9D8
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

		// Token: 0x17002BD3 RID: 11219
		// (get) Token: 0x0600B5F4 RID: 46580 RVA: 0x002D0814 File Offset: 0x002CEA14
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

		// Token: 0x17002BD4 RID: 11220
		// (get) Token: 0x0600B5F5 RID: 46581 RVA: 0x002D0850 File Offset: 0x002CEA50
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

		// Token: 0x17002BD5 RID: 11221
		// (get) Token: 0x0600B5F6 RID: 46582 RVA: 0x002D0890 File Offset: 0x002CEA90
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

		// Token: 0x0600B5F7 RID: 46583 RVA: 0x002D08C8 File Offset: 0x002CEAC8
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600B5F8 RID: 46584 RVA: 0x002D08D8 File Offset: 0x002CEAD8
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17002BD6 RID: 11222
		// (get) Token: 0x0600B5F9 RID: 46585 RVA: 0x002D08F0 File Offset: 0x002CEAF0
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

		// Token: 0x0600B5FA RID: 46586 RVA: 0x002D0928 File Offset: 0x002CEB28
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600B5FB RID: 46587 RVA: 0x002D0938 File Offset: 0x002CEB38
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17002BD7 RID: 11223
		// (get) Token: 0x0600B5FC RID: 46588 RVA: 0x002D0950 File Offset: 0x002CEB50
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

		// Token: 0x0600B5FD RID: 46589 RVA: 0x002D0988 File Offset: 0x002CEB88
		public Span<byte> GetDescFemaleBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600B5FE RID: 46590 RVA: 0x002D0998 File Offset: 0x002CEB98
		public byte[] GetDescFemaleArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17002BD8 RID: 11224
		// (get) Token: 0x0600B5FF RID: 46591 RVA: 0x002D09B0 File Offset: 0x002CEBB0
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

		// Token: 0x0600B600 RID: 46592 RVA: 0x002D09E8 File Offset: 0x002CEBE8
		public Span<byte> GetBriefBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600B601 RID: 46593 RVA: 0x002D09F8 File Offset: 0x002CEBF8
		public byte[] GetBriefArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17002BD9 RID: 11225
		// (get) Token: 0x0600B602 RID: 46594 RVA: 0x002D0A10 File Offset: 0x002CEC10
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

		// Token: 0x0600B603 RID: 46595 RVA: 0x002D0A48 File Offset: 0x002CEC48
		public Span<byte> GetImageSmallMaleBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600B604 RID: 46596 RVA: 0x002D0A58 File Offset: 0x002CEC58
		public byte[] GetImageSmallMaleArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x17002BDA RID: 11226
		// (get) Token: 0x0600B605 RID: 46597 RVA: 0x002D0A70 File Offset: 0x002CEC70
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

		// Token: 0x0600B606 RID: 46598 RVA: 0x002D0AA8 File Offset: 0x002CECA8
		public Span<byte> GetImageSmallFemaleBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x0600B607 RID: 46599 RVA: 0x002D0AB8 File Offset: 0x002CECB8
		public byte[] GetImageSmallFemaleArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x17002BDB RID: 11227
		// (get) Token: 0x0600B608 RID: 46600 RVA: 0x002D0AD0 File Offset: 0x002CECD0
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

		// Token: 0x0600B609 RID: 46601 RVA: 0x002D0B08 File Offset: 0x002CED08
		public Span<byte> GetImageLargeMaleBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x0600B60A RID: 46602 RVA: 0x002D0B18 File Offset: 0x002CED18
		public byte[] GetImageLargeMaleArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x17002BDC RID: 11228
		// (get) Token: 0x0600B60B RID: 46603 RVA: 0x002D0B30 File Offset: 0x002CED30
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

		// Token: 0x0600B60C RID: 46604 RVA: 0x002D0B68 File Offset: 0x002CED68
		public Span<byte> GetImageLargeFemaleBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x0600B60D RID: 46605 RVA: 0x002D0B78 File Offset: 0x002CED78
		public byte[] GetImageLargeFemaleArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x17002BDD RID: 11229
		// (get) Token: 0x0600B60E RID: 46606 RVA: 0x002D0B90 File Offset: 0x002CED90
		public bool ShowOnceUnlock
		{
			get
			{
				int num = this.__p.__offset(28);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x04005042 RID: 20546
		private Table __p;
	}
}
