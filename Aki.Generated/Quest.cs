using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200104B RID: 4171
	public struct Quest : IFlatbufferObject
	{
		// Token: 0x17002BE7 RID: 11239
		// (get) Token: 0x0600BAFF RID: 47871 RVA: 0x002EAF14 File Offset: 0x002E9114
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600BB00 RID: 47872 RVA: 0x002EAF21 File Offset: 0x002E9121
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600BB01 RID: 47873 RVA: 0x002EAF28 File Offset: 0x002E9128
		public static Quest GetRootAsQuest(ByteBuffer _bb)
		{
			return Quest.GetRootAsQuest(_bb, default(Quest));
		}

		// Token: 0x0600BB02 RID: 47874 RVA: 0x002EAF44 File Offset: 0x002E9144
		public static Quest GetRootAsQuest(ByteBuffer _bb, Quest obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600BB03 RID: 47875 RVA: 0x002EAF61 File Offset: 0x002E9161
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600BB04 RID: 47876 RVA: 0x002EAF70 File Offset: 0x002E9170
		public Quest __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002BE8 RID: 11240
		// (get) Token: 0x0600BB05 RID: 47877 RVA: 0x002EAF80 File Offset: 0x002E9180
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

		// Token: 0x17002BE9 RID: 11241
		// (get) Token: 0x0600BB06 RID: 47878 RVA: 0x002EAFBC File Offset: 0x002E91BC
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

		// Token: 0x0600BB07 RID: 47879 RVA: 0x002EAFF3 File Offset: 0x002E91F3
		public Span<byte> GetQuestKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600BB08 RID: 47880 RVA: 0x002EB002 File Offset: 0x002E9202
		public byte[] GetQuestKeyArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17002BEA RID: 11242
		// (get) Token: 0x0600BB09 RID: 47881 RVA: 0x002EB01C File Offset: 0x002E921C
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

		// Token: 0x0600BB0A RID: 47882 RVA: 0x002EB053 File Offset: 0x002E9253
		public Span<byte> GetQuestNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600BB0B RID: 47883 RVA: 0x002EB062 File Offset: 0x002E9262
		public byte[] GetQuestNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17002BEB RID: 11243
		// (get) Token: 0x0600BB0C RID: 47884 RVA: 0x002EB07C File Offset: 0x002E927C
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

		// Token: 0x17002BEC RID: 11244
		// (get) Token: 0x0600BB0D RID: 47885 RVA: 0x002EB0BC File Offset: 0x002E92BC
		public bool IsRepeat
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17002BED RID: 11245
		// (get) Token: 0x0600BB0E RID: 47886 RVA: 0x002EB0FC File Offset: 0x002E92FC
		public bool IsAutoTrack
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17002BEE RID: 11246
		// (get) Token: 0x0600BB0F RID: 47887 RVA: 0x002EB13C File Offset: 0x002E933C
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

		// Token: 0x0600BB10 RID: 47888 RVA: 0x002EB174 File Offset: 0x002E9374
		public Span<byte> GetQuestTextBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600BB11 RID: 47889 RVA: 0x002EB184 File Offset: 0x002E9384
		public byte[] GetQuestTextArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17002BEF RID: 11247
		// (get) Token: 0x0600BB12 RID: 47890 RVA: 0x002EB19C File Offset: 0x002E939C
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

		// Token: 0x17002BF0 RID: 11248
		// (get) Token: 0x0600BB13 RID: 47891 RVA: 0x002EB1DC File Offset: 0x002E93DC
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

		// Token: 0x17002BF1 RID: 11249
		// (get) Token: 0x0600BB14 RID: 47892 RVA: 0x002EB21C File Offset: 0x002E941C
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

		// Token: 0x17002BF2 RID: 11250
		// (get) Token: 0x0600BB15 RID: 47893 RVA: 0x002EB25C File Offset: 0x002E945C
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

		// Token: 0x17002BF3 RID: 11251
		// (get) Token: 0x0600BB16 RID: 47894 RVA: 0x002EB29C File Offset: 0x002E949C
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

		// Token: 0x0600BB17 RID: 47895 RVA: 0x002EB2D4 File Offset: 0x002E94D4
		public Span<byte> GetPanelTexturePathBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x0600BB18 RID: 47896 RVA: 0x002EB2E4 File Offset: 0x002E94E4
		public byte[] GetPanelTexturePathArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x04005619 RID: 22041
		private Table __p;
	}
}
