using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E92 RID: 3730
	public struct NewTowerSeason : IFlatbufferObject
	{
		// Token: 0x1700237E RID: 9086
		// (get) Token: 0x06009FD3 RID: 40915 RVA: 0x0029F5FC File Offset: 0x0029D7FC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009FD4 RID: 40916 RVA: 0x0029F609 File Offset: 0x0029D809
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009FD5 RID: 40917 RVA: 0x0029F610 File Offset: 0x0029D810
		public static NewTowerSeason GetRootAsNewTowerSeason(ByteBuffer _bb)
		{
			return NewTowerSeason.GetRootAsNewTowerSeason(_bb, default(NewTowerSeason));
		}

		// Token: 0x06009FD6 RID: 40918 RVA: 0x0029F62C File Offset: 0x0029D82C
		public static NewTowerSeason GetRootAsNewTowerSeason(ByteBuffer _bb, NewTowerSeason obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009FD7 RID: 40919 RVA: 0x0029F649 File Offset: 0x0029D849
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009FD8 RID: 40920 RVA: 0x0029F658 File Offset: 0x0029D858
		public NewTowerSeason __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700237F RID: 9087
		// (get) Token: 0x06009FD9 RID: 40921 RVA: 0x0029F668 File Offset: 0x0029D868
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

		// Token: 0x17002380 RID: 9088
		// (get) Token: 0x06009FDA RID: 40922 RVA: 0x0029F6A4 File Offset: 0x0029D8A4
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

		// Token: 0x17002381 RID: 9089
		// (get) Token: 0x06009FDB RID: 40923 RVA: 0x0029F6E0 File Offset: 0x0029D8E0
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

		// Token: 0x06009FDC RID: 40924 RVA: 0x0029F717 File Offset: 0x0029D917
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06009FDD RID: 40925 RVA: 0x0029F726 File Offset: 0x0029D926
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17002382 RID: 9090
		// (get) Token: 0x06009FDE RID: 40926 RVA: 0x0029F740 File Offset: 0x0029D940
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

		// Token: 0x06009FDF RID: 40927 RVA: 0x0029F778 File Offset: 0x0029D978
		public Span<byte> GetSmallIconBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06009FE0 RID: 40928 RVA: 0x0029F788 File Offset: 0x0029D988
		public byte[] GetSmallIconArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17002383 RID: 9091
		// (get) Token: 0x06009FE1 RID: 40929 RVA: 0x0029F7A0 File Offset: 0x0029D9A0
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

		// Token: 0x06009FE2 RID: 40930 RVA: 0x0029F7D8 File Offset: 0x0029D9D8
		public Span<byte> GetVersionIconBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06009FE3 RID: 40931 RVA: 0x0029F7E8 File Offset: 0x0029D9E8
		public byte[] GetVersionIconArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17002384 RID: 9092
		// (get) Token: 0x06009FE4 RID: 40932 RVA: 0x0029F800 File Offset: 0x0029DA00
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

		// Token: 0x06009FE5 RID: 40933 RVA: 0x0029F838 File Offset: 0x0029DA38
		public Span<byte> GetVersionIconMainBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06009FE6 RID: 40934 RVA: 0x0029F848 File Offset: 0x0029DA48
		public byte[] GetVersionIconMainArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17002385 RID: 9093
		// (get) Token: 0x06009FE7 RID: 40935 RVA: 0x0029F860 File Offset: 0x0029DA60
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

		// Token: 0x06009FE8 RID: 40936 RVA: 0x0029F898 File Offset: 0x0029DA98
		public Span<byte> GetStartVersionIdBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06009FE9 RID: 40937 RVA: 0x0029F8A8 File Offset: 0x0029DAA8
		public byte[] GetStartVersionIdArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17002386 RID: 9094
		// (get) Token: 0x06009FEA RID: 40938 RVA: 0x0029F8C0 File Offset: 0x0029DAC0
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

		// Token: 0x06009FEB RID: 40939 RVA: 0x0029F8F8 File Offset: 0x0029DAF8
		public Span<byte> GetEndVersionIdBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06009FEC RID: 40940 RVA: 0x0029F908 File Offset: 0x0029DB08
		public byte[] GetEndVersionIdArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x06009FED RID: 40941 RVA: 0x0029F920 File Offset: 0x0029DB20
		public int RankIconList(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002387 RID: 9095
		// (get) Token: 0x06009FEE RID: 40942 RVA: 0x0029F960 File Offset: 0x0029DB60
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

		// Token: 0x06009FEF RID: 40943 RVA: 0x0029F98C File Offset: 0x0029DB8C
		public Span<int> GetRankIconListBytes()
		{
			return this.__p.__vector_as_span<int>(20, 4);
		}

		// Token: 0x06009FF0 RID: 40944 RVA: 0x0029F99C File Offset: 0x0029DB9C
		public int[] GetRankIconListArray()
		{
			return this.__p.__vector_as_array<int>(20) ?? Array.Empty<int>();
		}

		// Token: 0x17002388 RID: 9096
		// (get) Token: 0x06009FF1 RID: 40945 RVA: 0x0029F9B4 File Offset: 0x0029DBB4
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

		// Token: 0x17002389 RID: 9097
		// (get) Token: 0x06009FF2 RID: 40946 RVA: 0x0029F9F4 File Offset: 0x0029DBF4
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

		// Token: 0x06009FF3 RID: 40947 RVA: 0x0029FA2C File Offset: 0x0029DC2C
		public Span<byte> GetBossPortraitBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x06009FF4 RID: 40948 RVA: 0x0029FA3C File Offset: 0x0029DC3C
		public byte[] GetBossPortraitArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x1700238A RID: 9098
		// (get) Token: 0x06009FF5 RID: 40949 RVA: 0x0029FA54 File Offset: 0x0029DC54
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

		// Token: 0x06009FF6 RID: 40950 RVA: 0x0029FA8C File Offset: 0x0029DC8C
		public Span<byte> GetBossBgPrefabBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x06009FF7 RID: 40951 RVA: 0x0029FA9C File Offset: 0x0029DC9C
		public byte[] GetBossBgPrefabArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x1700238B RID: 9099
		// (get) Token: 0x06009FF8 RID: 40952 RVA: 0x0029FAB4 File Offset: 0x0029DCB4
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

		// Token: 0x06009FF9 RID: 40953 RVA: 0x0029FAEC File Offset: 0x0029DCEC
		public Span<byte> GetSeasonTagBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x06009FFA RID: 40954 RVA: 0x0029FAFC File Offset: 0x0029DCFC
		public byte[] GetSeasonTagArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x06009FFB RID: 40955 RVA: 0x0029FB14 File Offset: 0x0029DD14
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用RankIconListIter()或GetRankIconListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] RankIconList()
		{
			NewTowerSeason newTowerSeason = this;
			return newTowerSeason.GetRankIconListArray() ?? Array.Empty<int>();
		}

		// Token: 0x06009FFC RID: 40956 RVA: 0x0029FB38 File Offset: 0x0029DD38
		[NullableContext(1)]
		public readonly IEnumerable<int> RankIconListIter()
		{
			NewTowerSeason.<RankIconListIter>d__56 <RankIconListIter>d__ = new NewTowerSeason.<RankIconListIter>d__56(-2);
			<RankIconListIter>d__.<>3__<>4__this = this;
			return <RankIconListIter>d__;
		}

		// Token: 0x04004F45 RID: 20293
		private Table __p;
	}
}
