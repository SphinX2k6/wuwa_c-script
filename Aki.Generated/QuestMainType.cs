using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001052 RID: 4178
	public struct QuestMainType : IFlatbufferObject
	{
		// Token: 0x17002C15 RID: 11285
		// (get) Token: 0x0600BB8F RID: 48015 RVA: 0x002EC091 File Offset: 0x002EA291
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600BB90 RID: 48016 RVA: 0x002EC09E File Offset: 0x002EA29E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600BB91 RID: 48017 RVA: 0x002EC0A8 File Offset: 0x002EA2A8
		public static QuestMainType GetRootAsQuestMainType(ByteBuffer _bb)
		{
			return QuestMainType.GetRootAsQuestMainType(_bb, default(QuestMainType));
		}

		// Token: 0x0600BB92 RID: 48018 RVA: 0x002EC0C4 File Offset: 0x002EA2C4
		public static QuestMainType GetRootAsQuestMainType(ByteBuffer _bb, QuestMainType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600BB93 RID: 48019 RVA: 0x002EC0E1 File Offset: 0x002EA2E1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600BB94 RID: 48020 RVA: 0x002EC0F0 File Offset: 0x002EA2F0
		public QuestMainType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002C16 RID: 11286
		// (get) Token: 0x0600BB95 RID: 48021 RVA: 0x002EC100 File Offset: 0x002EA300
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

		// Token: 0x17002C17 RID: 11287
		// (get) Token: 0x0600BB96 RID: 48022 RVA: 0x002EC13C File Offset: 0x002EA33C
		public string MainTypeName
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

		// Token: 0x0600BB97 RID: 48023 RVA: 0x002EC173 File Offset: 0x002EA373
		public Span<byte> GetMainTypeNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600BB98 RID: 48024 RVA: 0x002EC182 File Offset: 0x002EA382
		public byte[] GetMainTypeNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17002C18 RID: 11288
		// (get) Token: 0x0600BB99 RID: 48025 RVA: 0x002EC19C File Offset: 0x002EA39C
		public string QuestTabIcon
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

		// Token: 0x0600BB9A RID: 48026 RVA: 0x002EC1D3 File Offset: 0x002EA3D3
		public Span<byte> GetQuestTabIconBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600BB9B RID: 48027 RVA: 0x002EC1E2 File Offset: 0x002EA3E2
		public byte[] GetQuestTabIconArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17002C19 RID: 11289
		// (get) Token: 0x0600BB9C RID: 48028 RVA: 0x002EC1FC File Offset: 0x002EA3FC
		public string QuestTypeTitleIcon
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

		// Token: 0x0600BB9D RID: 48029 RVA: 0x002EC234 File Offset: 0x002EA434
		public Span<byte> GetQuestTypeTitleIconBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600BB9E RID: 48030 RVA: 0x002EC244 File Offset: 0x002EA444
		public byte[] GetQuestTypeTitleIconArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17002C1A RID: 11290
		// (get) Token: 0x0600BB9F RID: 48031 RVA: 0x002EC25C File Offset: 0x002EA45C
		public string QuestChapterBg
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

		// Token: 0x0600BBA0 RID: 48032 RVA: 0x002EC294 File Offset: 0x002EA494
		public Span<byte> GetQuestChapterBgBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600BBA1 RID: 48033 RVA: 0x002EC2A4 File Offset: 0x002EA4A4
		public byte[] GetQuestChapterBgArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17002C1B RID: 11291
		// (get) Token: 0x0600BBA2 RID: 48034 RVA: 0x002EC2BC File Offset: 0x002EA4BC
		public int TrackIconId
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 2;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002C1C RID: 11292
		// (get) Token: 0x0600BBA3 RID: 48035 RVA: 0x002EC2FC File Offset: 0x002EA4FC
		public string TypeColor
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

		// Token: 0x0600BBA4 RID: 48036 RVA: 0x002EC334 File Offset: 0x002EA534
		public Span<byte> GetTypeColorBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600BBA5 RID: 48037 RVA: 0x002EC344 File Offset: 0x002EA544
		public byte[] GetTypeColorArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17002C1D RID: 11293
		// (get) Token: 0x0600BBA6 RID: 48038 RVA: 0x002EC35C File Offset: 0x002EA55C
		public string CircleColor
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

		// Token: 0x0600BBA7 RID: 48039 RVA: 0x002EC394 File Offset: 0x002EA594
		public Span<byte> GetCircleColorBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600BBA8 RID: 48040 RVA: 0x002EC3A4 File Offset: 0x002EA5A4
		public byte[] GetCircleColorArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17002C1E RID: 11294
		// (get) Token: 0x0600BBA9 RID: 48041 RVA: 0x002EC3BC File Offset: 0x002EA5BC
		public string TrackBgColor
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

		// Token: 0x0600BBAA RID: 48042 RVA: 0x002EC3F4 File Offset: 0x002EA5F4
		public Span<byte> GetTrackBgColorBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600BBAB RID: 48043 RVA: 0x002EC404 File Offset: 0x002EA604
		public byte[] GetTrackBgColorArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x17002C1F RID: 11295
		// (get) Token: 0x0600BBAC RID: 48044 RVA: 0x002EC41C File Offset: 0x002EA61C
		public int SortValue
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

		// Token: 0x17002C20 RID: 11296
		// (get) Token: 0x0600BBAD RID: 48045 RVA: 0x002EC45C File Offset: 0x002EA65C
		public bool AutoHideTrack
		{
			get
			{
				int num = this.__p.__offset(24);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17002C21 RID: 11297
		// (get) Token: 0x0600BBAE RID: 48046 RVA: 0x002EC49C File Offset: 0x002EA69C
		public int NewQuestTipTime
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 2;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002C22 RID: 11298
		// (get) Token: 0x0600BBAF RID: 48047 RVA: 0x002EC4DC File Offset: 0x002EA6DC
		public int QuestUpdateTipsTime
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return 2;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x04005620 RID: 22048
		private Table __p;
	}
}
