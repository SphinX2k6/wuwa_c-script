using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F64 RID: 3940
	public struct Quest : IFlatbufferObject
	{
		// Token: 0x17002B6F RID: 11119
		// (get) Token: 0x0600B4C2 RID: 46274 RVA: 0x002CE260 File Offset: 0x002CC460
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B4C3 RID: 46275 RVA: 0x002CE26D File Offset: 0x002CC46D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B4C4 RID: 46276 RVA: 0x002CE274 File Offset: 0x002CC474
		public static Quest GetRootAsQuest(ByteBuffer _bb)
		{
			return Quest.GetRootAsQuest(_bb, default(Quest));
		}

		// Token: 0x0600B4C5 RID: 46277 RVA: 0x002CE290 File Offset: 0x002CC490
		public static Quest GetRootAsQuest(ByteBuffer _bb, Quest obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B4C6 RID: 46278 RVA: 0x002CE2AD File Offset: 0x002CC4AD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B4C7 RID: 46279 RVA: 0x002CE2BC File Offset: 0x002CC4BC
		public Quest __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002B70 RID: 11120
		// (get) Token: 0x0600B4C8 RID: 46280 RVA: 0x002CE2CC File Offset: 0x002CC4CC
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

		// Token: 0x17002B71 RID: 11121
		// (get) Token: 0x0600B4C9 RID: 46281 RVA: 0x002CE308 File Offset: 0x002CC508
		public string QuestKey
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

		// Token: 0x0600B4CA RID: 46282 RVA: 0x002CE33F File Offset: 0x002CC53F
		public Span<byte> GetQuestKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600B4CB RID: 46283 RVA: 0x002CE34E File Offset: 0x002CC54E
		public byte[] GetQuestKeyArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17002B72 RID: 11122
		// (get) Token: 0x0600B4CC RID: 46284 RVA: 0x002CE368 File Offset: 0x002CC568
		public string QuestName
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

		// Token: 0x0600B4CD RID: 46285 RVA: 0x002CE39F File Offset: 0x002CC59F
		public Span<byte> GetQuestNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600B4CE RID: 46286 RVA: 0x002CE3AE File Offset: 0x002CC5AE
		public byte[] GetQuestNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17002B73 RID: 11123
		// (get) Token: 0x0600B4CF RID: 46287 RVA: 0x002CE3C8 File Offset: 0x002CC5C8
		public int QuestType
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

		// Token: 0x17002B74 RID: 11124
		// (get) Token: 0x0600B4D0 RID: 46288 RVA: 0x002CE408 File Offset: 0x002CC608
		public bool IsRepeat
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17002B75 RID: 11125
		// (get) Token: 0x0600B4D1 RID: 46289 RVA: 0x002CE448 File Offset: 0x002CC648
		public bool IsAutoTrack
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17002B76 RID: 11126
		// (get) Token: 0x0600B4D2 RID: 46290 RVA: 0x002CE488 File Offset: 0x002CC688
		public string QuestText
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

		// Token: 0x0600B4D3 RID: 46291 RVA: 0x002CE4C0 File Offset: 0x002CC6C0
		public Span<byte> GetQuestTextBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600B4D4 RID: 46292 RVA: 0x002CE4D0 File Offset: 0x002CC6D0
		public byte[] GetQuestTextArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17002B77 RID: 11127
		// (get) Token: 0x0600B4D5 RID: 46293 RVA: 0x002CE4E8 File Offset: 0x002CC6E8
		public int IsOnline
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002B78 RID: 11128
		// (get) Token: 0x0600B4D6 RID: 46294 RVA: 0x002CE528 File Offset: 0x002CC728
		public int RewardShow
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002B79 RID: 11129
		// (get) Token: 0x0600B4D7 RID: 46295 RVA: 0x002CE568 File Offset: 0x002CC768
		public int AreaId
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002B7A RID: 11130
		// (get) Token: 0x0600B4D8 RID: 46296 RVA: 0x002CE5A8 File Offset: 0x002CC7A8
		public int Duration
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002B7B RID: 11131
		// (get) Token: 0x0600B4D9 RID: 46297 RVA: 0x002CE5E8 File Offset: 0x002CC7E8
		public string PanelTexturePath
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

		// Token: 0x0600B4DA RID: 46298 RVA: 0x002CE620 File Offset: 0x002CC820
		public Span<byte> GetPanelTexturePathBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x0600B4DB RID: 46299 RVA: 0x002CE630 File Offset: 0x002CC830
		public byte[] GetPanelTexturePathArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x04005032 RID: 20530
		private Table __p;
	}
}
