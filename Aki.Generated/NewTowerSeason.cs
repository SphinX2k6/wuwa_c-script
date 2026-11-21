using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F77 RID: 3959
	public struct NewTowerSeason : IFlatbufferObject
	{
		// Token: 0x170023E3 RID: 9187
		// (get) Token: 0x0600A5F3 RID: 42483 RVA: 0x002BCB9C File Offset: 0x002BAD9C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A5F4 RID: 42484 RVA: 0x002BCBA9 File Offset: 0x002BADA9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A5F5 RID: 42485 RVA: 0x002BCBB0 File Offset: 0x002BADB0
		public static NewTowerSeason GetRootAsNewTowerSeason(ByteBuffer _bb)
		{
			return NewTowerSeason.GetRootAsNewTowerSeason(_bb, default(NewTowerSeason));
		}

		// Token: 0x0600A5F6 RID: 42486 RVA: 0x002BCBCC File Offset: 0x002BADCC
		public static NewTowerSeason GetRootAsNewTowerSeason(ByteBuffer _bb, NewTowerSeason obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A5F7 RID: 42487 RVA: 0x002BCBE9 File Offset: 0x002BADE9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A5F8 RID: 42488 RVA: 0x002BCBF8 File Offset: 0x002BADF8
		public NewTowerSeason __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170023E4 RID: 9188
		// (get) Token: 0x0600A5F9 RID: 42489 RVA: 0x002BCC08 File Offset: 0x002BAE08
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

		// Token: 0x170023E5 RID: 9189
		// (get) Token: 0x0600A5FA RID: 42490 RVA: 0x002BCC44 File Offset: 0x002BAE44
		public int ScoreItem
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

		// Token: 0x170023E6 RID: 9190
		// (get) Token: 0x0600A5FB RID: 42491 RVA: 0x002BCC80 File Offset: 0x002BAE80
		public string Name
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

		// Token: 0x0600A5FC RID: 42492 RVA: 0x002BCCB7 File Offset: 0x002BAEB7
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600A5FD RID: 42493 RVA: 0x002BCCC6 File Offset: 0x002BAEC6
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170023E7 RID: 9191
		// (get) Token: 0x0600A5FE RID: 42494 RVA: 0x002BCCE0 File Offset: 0x002BAEE0
		public string SmallIcon
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

		// Token: 0x0600A5FF RID: 42495 RVA: 0x002BCD18 File Offset: 0x002BAF18
		public Span<byte> GetSmallIconBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600A600 RID: 42496 RVA: 0x002BCD28 File Offset: 0x002BAF28
		public byte[] GetSmallIconArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x170023E8 RID: 9192
		// (get) Token: 0x0600A601 RID: 42497 RVA: 0x002BCD40 File Offset: 0x002BAF40
		public string VersionIcon
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

		// Token: 0x0600A602 RID: 42498 RVA: 0x002BCD78 File Offset: 0x002BAF78
		public Span<byte> GetVersionIconBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600A603 RID: 42499 RVA: 0x002BCD88 File Offset: 0x002BAF88
		public byte[] GetVersionIconArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x170023E9 RID: 9193
		// (get) Token: 0x0600A604 RID: 42500 RVA: 0x002BCDA0 File Offset: 0x002BAFA0
		public string VersionIconMain
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

		// Token: 0x0600A605 RID: 42501 RVA: 0x002BCDD8 File Offset: 0x002BAFD8
		public Span<byte> GetVersionIconMainBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600A606 RID: 42502 RVA: 0x002BCDE8 File Offset: 0x002BAFE8
		public byte[] GetVersionIconMainArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x170023EA RID: 9194
		// (get) Token: 0x0600A607 RID: 42503 RVA: 0x002BCE00 File Offset: 0x002BB000
		public string StartVersionId
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

		// Token: 0x0600A608 RID: 42504 RVA: 0x002BCE38 File Offset: 0x002BB038
		public Span<byte> GetStartVersionIdBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600A609 RID: 42505 RVA: 0x002BCE48 File Offset: 0x002BB048
		public byte[] GetStartVersionIdArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x170023EB RID: 9195
		// (get) Token: 0x0600A60A RID: 42506 RVA: 0x002BCE60 File Offset: 0x002BB060
		public string EndVersionId
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

		// Token: 0x0600A60B RID: 42507 RVA: 0x002BCE98 File Offset: 0x002BB098
		public Span<byte> GetEndVersionIdBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600A60C RID: 42508 RVA: 0x002BCEA8 File Offset: 0x002BB0A8
		public byte[] GetEndVersionIdArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x0600A60D RID: 42509 RVA: 0x002BCEC0 File Offset: 0x002BB0C0
		public int RankIconList(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170023EC RID: 9196
		// (get) Token: 0x0600A60E RID: 42510 RVA: 0x002BCF00 File Offset: 0x002BB100
		public int RankIconListLength
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600A60F RID: 42511 RVA: 0x002BCF2C File Offset: 0x002BB12C
		public Span<int> GetRankIconListBytes()
		{
			return this.__p.__vector_as_span<int>(20, 4);
		}

		// Token: 0x0600A610 RID: 42512 RVA: 0x002BCF3C File Offset: 0x002BB13C
		public int[] GetRankIconListArray()
		{
			return this.__p.__vector_as_array<int>(20) ?? Array.Empty<int>();
		}

		// Token: 0x170023ED RID: 9197
		// (get) Token: 0x0600A611 RID: 42513 RVA: 0x002BCF54 File Offset: 0x002BB154
		public int InfoDisplayId
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

		// Token: 0x170023EE RID: 9198
		// (get) Token: 0x0600A612 RID: 42514 RVA: 0x002BCF94 File Offset: 0x002BB194
		public string BossPortrait
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

		// Token: 0x0600A613 RID: 42515 RVA: 0x002BCFCC File Offset: 0x002BB1CC
		public Span<byte> GetBossPortraitBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x0600A614 RID: 42516 RVA: 0x002BCFDC File Offset: 0x002BB1DC
		public byte[] GetBossPortraitArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x170023EF RID: 9199
		// (get) Token: 0x0600A615 RID: 42517 RVA: 0x002BCFF4 File Offset: 0x002BB1F4
		public string BossBgPrefab
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

		// Token: 0x0600A616 RID: 42518 RVA: 0x002BD02C File Offset: 0x002BB22C
		public Span<byte> GetBossBgPrefabBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x0600A617 RID: 42519 RVA: 0x002BD03C File Offset: 0x002BB23C
		public byte[] GetBossBgPrefabArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x170023F0 RID: 9200
		// (get) Token: 0x0600A618 RID: 42520 RVA: 0x002BD054 File Offset: 0x002BB254
		public string SeasonTag
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600A619 RID: 42521 RVA: 0x002BD08C File Offset: 0x002BB28C
		public Span<byte> GetSeasonTagBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x0600A61A RID: 42522 RVA: 0x002BD09C File Offset: 0x002BB29C
		public byte[] GetSeasonTagArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x0600A61B RID: 42523 RVA: 0x002BD0B4 File Offset: 0x002BB2B4
		[NullableContext(1)]
		public int[] RankIconList()
		{
			return this.GetRankIconListArray();
		}

		// Token: 0x0600A61C RID: 42524 RVA: 0x002BD0BC File Offset: 0x002BB2BC
		[NullableContext(1)]
		public IEnumerable<int> RankIconListIter()
		{
			NewTowerSeason.<RankIconListIter>d__56 <RankIconListIter>d__ = new NewTowerSeason.<RankIconListIter>d__56(-2);
			<RankIconListIter>d__.<>3__<>4__this = this;
			return <RankIconListIter>d__;
		}

		// Token: 0x0400552A RID: 21802
		private Table __p;
	}
}
