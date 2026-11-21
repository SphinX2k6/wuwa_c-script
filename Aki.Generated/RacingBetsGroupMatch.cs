using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001071 RID: 4209
	public struct RacingBetsGroupMatch : IFlatbufferObject
	{
		// Token: 0x17002D11 RID: 11537
		// (get) Token: 0x0600BE45 RID: 48709 RVA: 0x002F1B5C File Offset: 0x002EFD5C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600BE46 RID: 48710 RVA: 0x002F1B69 File Offset: 0x002EFD69
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600BE47 RID: 48711 RVA: 0x002F1B70 File Offset: 0x002EFD70
		public static RacingBetsGroupMatch GetRootAsRacingBetsGroupMatch(ByteBuffer _bb)
		{
			return RacingBetsGroupMatch.GetRootAsRacingBetsGroupMatch(_bb, default(RacingBetsGroupMatch));
		}

		// Token: 0x0600BE48 RID: 48712 RVA: 0x002F1B8C File Offset: 0x002EFD8C
		public static RacingBetsGroupMatch GetRootAsRacingBetsGroupMatch(ByteBuffer _bb, RacingBetsGroupMatch obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600BE49 RID: 48713 RVA: 0x002F1BA9 File Offset: 0x002EFDA9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600BE4A RID: 48714 RVA: 0x002F1BB8 File Offset: 0x002EFDB8
		public RacingBetsGroupMatch __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002D12 RID: 11538
		// (get) Token: 0x0600BE4B RID: 48715 RVA: 0x002F1BC8 File Offset: 0x002EFDC8
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

		// Token: 0x17002D13 RID: 11539
		// (get) Token: 0x0600BE4C RID: 48716 RVA: 0x002F1C04 File Offset: 0x002EFE04
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

		// Token: 0x17002D14 RID: 11540
		// (get) Token: 0x0600BE4D RID: 48717 RVA: 0x002F1C40 File Offset: 0x002EFE40
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

		// Token: 0x17002D15 RID: 11541
		// (get) Token: 0x0600BE4E RID: 48718 RVA: 0x002F1C7C File Offset: 0x002EFE7C
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

		// Token: 0x17002D16 RID: 11542
		// (get) Token: 0x0600BE4F RID: 48719 RVA: 0x002F1CBC File Offset: 0x002EFEBC
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

		// Token: 0x17002D17 RID: 11543
		// (get) Token: 0x0600BE50 RID: 48720 RVA: 0x002F1CFC File Offset: 0x002EFEFC
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

		// Token: 0x17002D18 RID: 11544
		// (get) Token: 0x0600BE51 RID: 48721 RVA: 0x002F1D3C File Offset: 0x002EFF3C
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

		// Token: 0x0600BE52 RID: 48722 RVA: 0x002F1D74 File Offset: 0x002EFF74
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600BE53 RID: 48723 RVA: 0x002F1D84 File Offset: 0x002EFF84
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17002D19 RID: 11545
		// (get) Token: 0x0600BE54 RID: 48724 RVA: 0x002F1D9C File Offset: 0x002EFF9C
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

		// Token: 0x0600BE55 RID: 48725 RVA: 0x002F1DD4 File Offset: 0x002EFFD4
		public Span<byte> GetShortNameBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600BE56 RID: 48726 RVA: 0x002F1DE4 File Offset: 0x002EFFE4
		public byte[] GetShortNameArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x0600BE57 RID: 48727 RVA: 0x002F1DFC File Offset: 0x002EFFFC
		public int LegMatches(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002D1A RID: 11546
		// (get) Token: 0x0600BE58 RID: 48728 RVA: 0x002F1E3C File Offset: 0x002F003C
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

		// Token: 0x0600BE59 RID: 48729 RVA: 0x002F1E68 File Offset: 0x002F0068
		public Span<int> GetLegMatchesBytes()
		{
			return this.__p.__vector_as_span<int>(20, 4);
		}

		// Token: 0x0600BE5A RID: 48730 RVA: 0x002F1E78 File Offset: 0x002F0078
		public int[] GetLegMatchesArray()
		{
			return this.__p.__vector_as_array<int>(20) ?? Array.Empty<int>();
		}

		// Token: 0x0600BE5B RID: 48731 RVA: 0x002F1E90 File Offset: 0x002F0090
		public int DangoList(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002D1B RID: 11547
		// (get) Token: 0x0600BE5C RID: 48732 RVA: 0x002F1ED0 File Offset: 0x002F00D0
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

		// Token: 0x0600BE5D RID: 48733 RVA: 0x002F1EFC File Offset: 0x002F00FC
		public Span<int> GetDangoListBytes()
		{
			return this.__p.__vector_as_span<int>(22, 4);
		}

		// Token: 0x0600BE5E RID: 48734 RVA: 0x002F1F0C File Offset: 0x002F010C
		public int[] GetDangoListArray()
		{
			return this.__p.__vector_as_array<int>(22) ?? Array.Empty<int>();
		}

		// Token: 0x17002D1C RID: 11548
		// (get) Token: 0x0600BE5F RID: 48735 RVA: 0x002F1F24 File Offset: 0x002F0124
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

		// Token: 0x17002D1D RID: 11549
		// (get) Token: 0x0600BE60 RID: 48736 RVA: 0x002F1F64 File Offset: 0x002F0164
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

		// Token: 0x17002D1E RID: 11550
		// (get) Token: 0x0600BE61 RID: 48737 RVA: 0x002F1FA4 File Offset: 0x002F01A4
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

		// Token: 0x17002D1F RID: 11551
		// (get) Token: 0x0600BE62 RID: 48738 RVA: 0x002F1FE4 File Offset: 0x002F01E4
		public bool DangoIsOnlyReadServerData
		{
			get
			{
				int num = this.__p.__offset(30);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17002D20 RID: 11552
		// (get) Token: 0x0600BE63 RID: 48739 RVA: 0x002F2024 File Offset: 0x002F0224
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

		// Token: 0x0600BE64 RID: 48740 RVA: 0x002F2061 File Offset: 0x002F0261
		[NullableContext(1)]
		public int[] DangoList()
		{
			return this.GetDangoListArray();
		}

		// Token: 0x0600BE65 RID: 48741 RVA: 0x002F2069 File Offset: 0x002F0269
		[NullableContext(1)]
		public IEnumerable<int> DangoListIter()
		{
			RacingBetsGroupMatch.<DangoListIter>d__49 <DangoListIter>d__ = new RacingBetsGroupMatch.<DangoListIter>d__49(-2);
			<DangoListIter>d__.<>3__<>4__this = this;
			return <DangoListIter>d__;
		}

		// Token: 0x0600BE66 RID: 48742 RVA: 0x002F207E File Offset: 0x002F027E
		[NullableContext(1)]
		public int[] LegMatches()
		{
			return this.GetLegMatchesArray();
		}

		// Token: 0x0600BE67 RID: 48743 RVA: 0x002F2086 File Offset: 0x002F0286
		[NullableContext(1)]
		public IEnumerable<int> LegMatchesIter()
		{
			RacingBetsGroupMatch.<LegMatchesIter>d__51 <LegMatchesIter>d__ = new RacingBetsGroupMatch.<LegMatchesIter>d__51(-2);
			<LegMatchesIter>d__.<>3__<>4__this = this;
			return <LegMatchesIter>d__;
		}

		// Token: 0x04005640 RID: 22080
		private Table __p;
	}
}
