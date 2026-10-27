using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F11 RID: 3857
	public struct PhotoMemoryCollect : IFlatbufferObject
	{
		// Token: 0x17002835 RID: 10293
		// (get) Token: 0x0600AC6E RID: 44142 RVA: 0x002BBE6C File Offset: 0x002BA06C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600AC6F RID: 44143 RVA: 0x002BBE79 File Offset: 0x002BA079
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600AC70 RID: 44144 RVA: 0x002BBE80 File Offset: 0x002BA080
		public static PhotoMemoryCollect GetRootAsPhotoMemoryCollect(ByteBuffer _bb)
		{
			return PhotoMemoryCollect.GetRootAsPhotoMemoryCollect(_bb, default(PhotoMemoryCollect));
		}

		// Token: 0x0600AC71 RID: 44145 RVA: 0x002BBE9C File Offset: 0x002BA09C
		public static PhotoMemoryCollect GetRootAsPhotoMemoryCollect(ByteBuffer _bb, PhotoMemoryCollect obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600AC72 RID: 44146 RVA: 0x002BBEB9 File Offset: 0x002BA0B9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600AC73 RID: 44147 RVA: 0x002BBEC8 File Offset: 0x002BA0C8
		public PhotoMemoryCollect __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002836 RID: 10294
		// (get) Token: 0x0600AC74 RID: 44148 RVA: 0x002BBED8 File Offset: 0x002BA0D8
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

		// Token: 0x17002837 RID: 10295
		// (get) Token: 0x0600AC75 RID: 44149 RVA: 0x002BBF14 File Offset: 0x002BA114
		public int TopicID
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

		// Token: 0x17002838 RID: 10296
		// (get) Token: 0x0600AC76 RID: 44150 RVA: 0x002BBF50 File Offset: 0x002BA150
		public int Type
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002839 RID: 10297
		// (get) Token: 0x0600AC77 RID: 44151 RVA: 0x002BBF8C File Offset: 0x002BA18C
		public int Rank
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

		// Token: 0x1700283A RID: 10298
		// (get) Token: 0x0600AC78 RID: 44152 RVA: 0x002BBFCC File Offset: 0x002BA1CC
		public string ThemeBg
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

		// Token: 0x0600AC79 RID: 44153 RVA: 0x002BC004 File Offset: 0x002BA204
		public Span<byte> GetThemeBgBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600AC7A RID: 44154 RVA: 0x002BC014 File Offset: 0x002BA214
		public byte[] GetThemeBgArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x1700283B RID: 10299
		// (get) Token: 0x0600AC7B RID: 44155 RVA: 0x002BC02C File Offset: 0x002BA22C
		public string BgResourceM
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

		// Token: 0x0600AC7C RID: 44156 RVA: 0x002BC064 File Offset: 0x002BA264
		public Span<byte> GetBgResourceMBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600AC7D RID: 44157 RVA: 0x002BC074 File Offset: 0x002BA274
		public byte[] GetBgResourceMArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x1700283C RID: 10300
		// (get) Token: 0x0600AC7E RID: 44158 RVA: 0x002BC08C File Offset: 0x002BA28C
		public string BgResourceF
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

		// Token: 0x0600AC7F RID: 44159 RVA: 0x002BC0C4 File Offset: 0x002BA2C4
		public Span<byte> GetBgResourceFBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600AC80 RID: 44160 RVA: 0x002BC0D4 File Offset: 0x002BA2D4
		public byte[] GetBgResourceFArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x1700283D RID: 10301
		// (get) Token: 0x0600AC81 RID: 44161 RVA: 0x002BC0EC File Offset: 0x002BA2EC
		public string Title
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

		// Token: 0x0600AC82 RID: 44162 RVA: 0x002BC124 File Offset: 0x002BA324
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600AC83 RID: 44163 RVA: 0x002BC134 File Offset: 0x002BA334
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x1700283E RID: 10302
		// (get) Token: 0x0600AC84 RID: 44164 RVA: 0x002BC14C File Offset: 0x002BA34C
		public string TipsDesc
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

		// Token: 0x0600AC85 RID: 44165 RVA: 0x002BC184 File Offset: 0x002BA384
		public Span<byte> GetTipsDescBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600AC86 RID: 44166 RVA: 0x002BC194 File Offset: 0x002BA394
		public byte[] GetTipsDescArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x1700283F RID: 10303
		// (get) Token: 0x0600AC87 RID: 44167 RVA: 0x002BC1AC File Offset: 0x002BA3AC
		public int ClueId
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

		// Token: 0x17002840 RID: 10304
		// (get) Token: 0x0600AC88 RID: 44168 RVA: 0x002BC1EC File Offset: 0x002BA3EC
		public string Desc
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

		// Token: 0x0600AC89 RID: 44169 RVA: 0x002BC224 File Offset: 0x002BA424
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x0600AC8A RID: 44170 RVA: 0x002BC234 File Offset: 0x002BA434
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x17002841 RID: 10305
		// (get) Token: 0x0600AC8B RID: 44171 RVA: 0x002BC24C File Offset: 0x002BA44C
		public int DropId
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002842 RID: 10306
		// (get) Token: 0x0600AC8C RID: 44172 RVA: 0x002BC28C File Offset: 0x002BA48C
		public int TraceEntityId
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002843 RID: 10307
		// (get) Token: 0x0600AC8D RID: 44173 RVA: 0x002BC2CC File Offset: 0x002BA4CC
		public int TrackMapId
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002844 RID: 10308
		// (get) Token: 0x0600AC8E RID: 44174 RVA: 0x002BC30C File Offset: 0x002BA50C
		public int TraceMarkId
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002845 RID: 10309
		// (get) Token: 0x0600AC8F RID: 44175 RVA: 0x002BC34C File Offset: 0x002BA54C
		public int QuestId
		{
			get
			{
				int num = this.__p.__offset(34);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600AC90 RID: 44176 RVA: 0x002BC38C File Offset: 0x002BA58C
		public int QuestIdList(int j)
		{
			int num = this.__p.__offset(36);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002846 RID: 10310
		// (get) Token: 0x0600AC91 RID: 44177 RVA: 0x002BC3CC File Offset: 0x002BA5CC
		public int QuestIdListLength
		{
			get
			{
				int num = this.__p.__offset(36);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600AC92 RID: 44178 RVA: 0x002BC3F8 File Offset: 0x002BA5F8
		public Span<int> GetQuestIdListBytes()
		{
			return this.__p.__vector_as_span<int>(36, 4);
		}

		// Token: 0x0600AC93 RID: 44179 RVA: 0x002BC408 File Offset: 0x002BA608
		public int[] GetQuestIdListArray()
		{
			return this.__p.__vector_as_array<int>(36) ?? Array.Empty<int>();
		}

		// Token: 0x0600AC94 RID: 44180 RVA: 0x002BC420 File Offset: 0x002BA620
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用QuestIdListIter()或GetQuestIdListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] QuestIdList()
		{
			PhotoMemoryCollect photoMemoryCollect = this;
			return photoMemoryCollect.GetQuestIdListArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600AC95 RID: 44181 RVA: 0x002BC444 File Offset: 0x002BA644
		[NullableContext(1)]
		public readonly IEnumerable<int> QuestIdListIter()
		{
			PhotoMemoryCollect.<QuestIdListIter>d__58 <QuestIdListIter>d__ = new PhotoMemoryCollect.<QuestIdListIter>d__58(-2);
			<QuestIdListIter>d__.<>3__<>4__this = this;
			return <QuestIdListIter>d__;
		}

		// Token: 0x04004FD9 RID: 20441
		private Table __p;
	}
}
