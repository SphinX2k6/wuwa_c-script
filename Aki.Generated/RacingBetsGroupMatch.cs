using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F8A RID: 3978
	public struct RacingBetsGroupMatch : IFlatbufferObject
	{
		// Token: 0x17002C99 RID: 11417
		// (get) Token: 0x0600B808 RID: 47112 RVA: 0x002D51D0 File Offset: 0x002D33D0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B809 RID: 47113 RVA: 0x002D51DD File Offset: 0x002D33DD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B80A RID: 47114 RVA: 0x002D51E4 File Offset: 0x002D33E4
		public static RacingBetsGroupMatch GetRootAsRacingBetsGroupMatch(ByteBuffer _bb)
		{
			return RacingBetsGroupMatch.GetRootAsRacingBetsGroupMatch(_bb, default(RacingBetsGroupMatch));
		}

		// Token: 0x0600B80B RID: 47115 RVA: 0x002D5200 File Offset: 0x002D3400
		public static RacingBetsGroupMatch GetRootAsRacingBetsGroupMatch(ByteBuffer _bb, RacingBetsGroupMatch obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B80C RID: 47116 RVA: 0x002D521D File Offset: 0x002D341D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B80D RID: 47117 RVA: 0x002D522C File Offset: 0x002D342C
		public RacingBetsGroupMatch __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002C9A RID: 11418
		// (get) Token: 0x0600B80E RID: 47118 RVA: 0x002D523C File Offset: 0x002D343C
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

		// Token: 0x17002C9B RID: 11419
		// (get) Token: 0x0600B80F RID: 47119 RVA: 0x002D5278 File Offset: 0x002D3478
		public int SeasonId
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

		// Token: 0x17002C9C RID: 11420
		// (get) Token: 0x0600B810 RID: 47120 RVA: 0x002D52B4 File Offset: 0x002D34B4
		public int AdvancedGroupId
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

		// Token: 0x17002C9D RID: 11421
		// (get) Token: 0x0600B811 RID: 47121 RVA: 0x002D52F0 File Offset: 0x002D34F0
		public int LoseGroupId
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

		// Token: 0x17002C9E RID: 11422
		// (get) Token: 0x0600B812 RID: 47122 RVA: 0x002D5330 File Offset: 0x002D3530
		public int Type
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002C9F RID: 11423
		// (get) Token: 0x0600B813 RID: 47123 RVA: 0x002D5370 File Offset: 0x002D3570
		public int SortId
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002CA0 RID: 11424
		// (get) Token: 0x0600B814 RID: 47124 RVA: 0x002D53B0 File Offset: 0x002D35B0
		public string Name
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

		// Token: 0x0600B815 RID: 47125 RVA: 0x002D53E8 File Offset: 0x002D35E8
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600B816 RID: 47126 RVA: 0x002D53F8 File Offset: 0x002D35F8
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17002CA1 RID: 11425
		// (get) Token: 0x0600B817 RID: 47127 RVA: 0x002D5410 File Offset: 0x002D3610
		public string ShortName
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

		// Token: 0x0600B818 RID: 47128 RVA: 0x002D5448 File Offset: 0x002D3648
		public Span<byte> GetShortNameBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600B819 RID: 47129 RVA: 0x002D5458 File Offset: 0x002D3658
		public byte[] GetShortNameArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x0600B81A RID: 47130 RVA: 0x002D5470 File Offset: 0x002D3670
		public int LegMatches(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002CA2 RID: 11426
		// (get) Token: 0x0600B81B RID: 47131 RVA: 0x002D54B0 File Offset: 0x002D36B0
		public int LegMatchesLength
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

		// Token: 0x0600B81C RID: 47132 RVA: 0x002D54DC File Offset: 0x002D36DC
		public Span<int> GetLegMatchesBytes()
		{
			return this.__p.__vector_as_span<int>(20, 4);
		}

		// Token: 0x0600B81D RID: 47133 RVA: 0x002D54EC File Offset: 0x002D36EC
		public int[] GetLegMatchesArray()
		{
			return this.__p.__vector_as_array<int>(20) ?? Array.Empty<int>();
		}

		// Token: 0x0600B81E RID: 47134 RVA: 0x002D5504 File Offset: 0x002D3704
		public int DangoList(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002CA3 RID: 11427
		// (get) Token: 0x0600B81F RID: 47135 RVA: 0x002D5544 File Offset: 0x002D3744
		public int DangoListLength
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600B820 RID: 47136 RVA: 0x002D5570 File Offset: 0x002D3770
		public Span<int> GetDangoListBytes()
		{
			return this.__p.__vector_as_span<int>(22, 4);
		}

		// Token: 0x0600B821 RID: 47137 RVA: 0x002D5580 File Offset: 0x002D3780
		public int[] GetDangoListArray()
		{
			return this.__p.__vector_as_array<int>(22) ?? Array.Empty<int>();
		}

		// Token: 0x17002CA4 RID: 11428
		// (get) Token: 0x0600B822 RID: 47138 RVA: 0x002D5598 File Offset: 0x002D3798
		public int AdvancedDangoCount
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

		// Token: 0x17002CA5 RID: 11429
		// (get) Token: 0x0600B823 RID: 47139 RVA: 0x002D55D8 File Offset: 0x002D37D8
		public int NextMatchId
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

		// Token: 0x17002CA6 RID: 11430
		// (get) Token: 0x0600B824 RID: 47140 RVA: 0x002D5618 File Offset: 0x002D3818
		public int ResultShowType
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

		// Token: 0x17002CA7 RID: 11431
		// (get) Token: 0x0600B825 RID: 47141 RVA: 0x002D5658 File Offset: 0x002D3858
		public bool DangoIsOnlyReadServerData
		{
			get
			{
				int num = this.__p.__offset(30);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17002CA8 RID: 11432
		// (get) Token: 0x0600B826 RID: 47142 RVA: 0x002D5698 File Offset: 0x002D3898
		public int DangoSourceMatchScheduleId
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

		// Token: 0x0600B827 RID: 47143 RVA: 0x002D56D8 File Offset: 0x002D38D8
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用DangoListIter()或GetDangoListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] DangoList()
		{
			RacingBetsGroupMatch racingBetsGroupMatch = this;
			return racingBetsGroupMatch.GetDangoListArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600B828 RID: 47144 RVA: 0x002D56FC File Offset: 0x002D38FC
		[NullableContext(1)]
		public readonly IEnumerable<int> DangoListIter()
		{
			RacingBetsGroupMatch.<DangoListIter>d__49 <DangoListIter>d__ = new RacingBetsGroupMatch.<DangoListIter>d__49(-2);
			<DangoListIter>d__.<>3__<>4__this = this;
			return <DangoListIter>d__;
		}

		// Token: 0x0600B829 RID: 47145 RVA: 0x002D5714 File Offset: 0x002D3914
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用LegMatchesIter()或GetLegMatchesBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] LegMatches()
		{
			RacingBetsGroupMatch racingBetsGroupMatch = this;
			return racingBetsGroupMatch.GetLegMatchesArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600B82A RID: 47146 RVA: 0x002D5738 File Offset: 0x002D3938
		[NullableContext(1)]
		public readonly IEnumerable<int> LegMatchesIter()
		{
			RacingBetsGroupMatch.<LegMatchesIter>d__51 <LegMatchesIter>d__ = new RacingBetsGroupMatch.<LegMatchesIter>d__51(-2);
			<LegMatchesIter>d__.<>3__<>4__this = this;
			return <LegMatchesIter>d__;
		}

		// Token: 0x04005059 RID: 20569
		private Table __p;
	}
}
