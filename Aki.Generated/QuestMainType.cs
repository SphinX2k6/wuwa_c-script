using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F6B RID: 3947
	public struct QuestMainType : IFlatbufferObject
	{
		// Token: 0x17002B9D RID: 11165
		// (get) Token: 0x0600B552 RID: 46418 RVA: 0x002CF475 File Offset: 0x002CD675
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B553 RID: 46419 RVA: 0x002CF482 File Offset: 0x002CD682
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B554 RID: 46420 RVA: 0x002CF48C File Offset: 0x002CD68C
		public static QuestMainType GetRootAsQuestMainType(ByteBuffer _bb)
		{
			return QuestMainType.GetRootAsQuestMainType(_bb, default(QuestMainType));
		}

		// Token: 0x0600B555 RID: 46421 RVA: 0x002CF4A8 File Offset: 0x002CD6A8
		public static QuestMainType GetRootAsQuestMainType(ByteBuffer _bb, QuestMainType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B556 RID: 46422 RVA: 0x002CF4C5 File Offset: 0x002CD6C5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B557 RID: 46423 RVA: 0x002CF4D4 File Offset: 0x002CD6D4
		public QuestMainType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002B9E RID: 11166
		// (get) Token: 0x0600B558 RID: 46424 RVA: 0x002CF4E4 File Offset: 0x002CD6E4
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

		// Token: 0x17002B9F RID: 11167
		// (get) Token: 0x0600B559 RID: 46425 RVA: 0x002CF520 File Offset: 0x002CD720
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

		// Token: 0x0600B55A RID: 46426 RVA: 0x002CF557 File Offset: 0x002CD757
		public Span<byte> GetMainTypeNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600B55B RID: 46427 RVA: 0x002CF566 File Offset: 0x002CD766
		public byte[] GetMainTypeNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17002BA0 RID: 11168
		// (get) Token: 0x0600B55C RID: 46428 RVA: 0x002CF580 File Offset: 0x002CD780
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

		// Token: 0x0600B55D RID: 46429 RVA: 0x002CF5B7 File Offset: 0x002CD7B7
		public Span<byte> GetQuestTabIconBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600B55E RID: 46430 RVA: 0x002CF5C6 File Offset: 0x002CD7C6
		public byte[] GetQuestTabIconArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17002BA1 RID: 11169
		// (get) Token: 0x0600B55F RID: 46431 RVA: 0x002CF5E0 File Offset: 0x002CD7E0
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

		// Token: 0x0600B560 RID: 46432 RVA: 0x002CF618 File Offset: 0x002CD818
		public Span<byte> GetQuestTypeTitleIconBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600B561 RID: 46433 RVA: 0x002CF628 File Offset: 0x002CD828
		public byte[] GetQuestTypeTitleIconArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17002BA2 RID: 11170
		// (get) Token: 0x0600B562 RID: 46434 RVA: 0x002CF640 File Offset: 0x002CD840
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

		// Token: 0x0600B563 RID: 46435 RVA: 0x002CF678 File Offset: 0x002CD878
		public Span<byte> GetQuestChapterBgBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600B564 RID: 46436 RVA: 0x002CF688 File Offset: 0x002CD888
		public byte[] GetQuestChapterBgArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17002BA3 RID: 11171
		// (get) Token: 0x0600B565 RID: 46437 RVA: 0x002CF6A0 File Offset: 0x002CD8A0
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

		// Token: 0x17002BA4 RID: 11172
		// (get) Token: 0x0600B566 RID: 46438 RVA: 0x002CF6E0 File Offset: 0x002CD8E0
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

		// Token: 0x0600B567 RID: 46439 RVA: 0x002CF718 File Offset: 0x002CD918
		public Span<byte> GetTypeColorBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600B568 RID: 46440 RVA: 0x002CF728 File Offset: 0x002CD928
		public byte[] GetTypeColorArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17002BA5 RID: 11173
		// (get) Token: 0x0600B569 RID: 46441 RVA: 0x002CF740 File Offset: 0x002CD940
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

		// Token: 0x0600B56A RID: 46442 RVA: 0x002CF778 File Offset: 0x002CD978
		public Span<byte> GetCircleColorBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600B56B RID: 46443 RVA: 0x002CF788 File Offset: 0x002CD988
		public byte[] GetCircleColorArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17002BA6 RID: 11174
		// (get) Token: 0x0600B56C RID: 46444 RVA: 0x002CF7A0 File Offset: 0x002CD9A0
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

		// Token: 0x0600B56D RID: 46445 RVA: 0x002CF7D8 File Offset: 0x002CD9D8
		public Span<byte> GetTrackBgColorBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600B56E RID: 46446 RVA: 0x002CF7E8 File Offset: 0x002CD9E8
		public byte[] GetTrackBgColorArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x17002BA7 RID: 11175
		// (get) Token: 0x0600B56F RID: 46447 RVA: 0x002CF800 File Offset: 0x002CDA00
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

		// Token: 0x17002BA8 RID: 11176
		// (get) Token: 0x0600B570 RID: 46448 RVA: 0x002CF840 File Offset: 0x002CDA40
		public bool AutoHideTrack
		{
			get
			{
				int num = this.__p.__offset(24);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17002BA9 RID: 11177
		// (get) Token: 0x0600B571 RID: 46449 RVA: 0x002CF880 File Offset: 0x002CDA80
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

		// Token: 0x17002BAA RID: 11178
		// (get) Token: 0x0600B572 RID: 46450 RVA: 0x002CF8C0 File Offset: 0x002CDAC0
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

		// Token: 0x04005039 RID: 20537
		private Table __p;
	}
}
