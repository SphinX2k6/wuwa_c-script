using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E97 RID: 3735
	public struct NewTowerWave : IFlatbufferObject
	{
		// Token: 0x170023A9 RID: 9129
		// (get) Token: 0x0600A044 RID: 41028 RVA: 0x002A047D File Offset: 0x0029E67D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A045 RID: 41029 RVA: 0x002A048A File Offset: 0x0029E68A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A046 RID: 41030 RVA: 0x002A0494 File Offset: 0x0029E694
		public static NewTowerWave GetRootAsNewTowerWave(ByteBuffer _bb)
		{
			return NewTowerWave.GetRootAsNewTowerWave(_bb, default(NewTowerWave));
		}

		// Token: 0x0600A047 RID: 41031 RVA: 0x002A04B0 File Offset: 0x0029E6B0
		public static NewTowerWave GetRootAsNewTowerWave(ByteBuffer _bb, NewTowerWave obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A048 RID: 41032 RVA: 0x002A04CD File Offset: 0x0029E6CD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A049 RID: 41033 RVA: 0x002A04DC File Offset: 0x0029E6DC
		public NewTowerWave __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170023AA RID: 9130
		// (get) Token: 0x0600A04A RID: 41034 RVA: 0x002A04EC File Offset: 0x0029E6EC
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

		// Token: 0x170023AB RID: 9131
		// (get) Token: 0x0600A04B RID: 41035 RVA: 0x002A0528 File Offset: 0x0029E728
		public int Level
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

		// Token: 0x170023AC RID: 9132
		// (get) Token: 0x0600A04C RID: 41036 RVA: 0x002A0564 File Offset: 0x0029E764
		public int Round
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

		// Token: 0x170023AD RID: 9133
		// (get) Token: 0x0600A04D RID: 41037 RVA: 0x002A05A0 File Offset: 0x0029E7A0
		public int Wave
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

		// Token: 0x170023AE RID: 9134
		// (get) Token: 0x0600A04E RID: 41038 RVA: 0x002A05E0 File Offset: 0x0029E7E0
		public bool IsShowInView
		{
			get
			{
				int num = this.__p.__offset(12);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170023AF RID: 9135
		// (get) Token: 0x0600A04F RID: 41039 RVA: 0x002A0620 File Offset: 0x0029E820
		public int RecommendId
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

		// Token: 0x170023B0 RID: 9136
		// (get) Token: 0x0600A050 RID: 41040 RVA: 0x002A0660 File Offset: 0x0029E860
		public int KillScore
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 100;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170023B1 RID: 9137
		// (get) Token: 0x0600A051 RID: 41041 RVA: 0x002A06A0 File Offset: 0x0029E8A0
		public int MonsterLevel
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

		// Token: 0x170023B2 RID: 9138
		// (get) Token: 0x0600A052 RID: 41042 RVA: 0x002A06E0 File Offset: 0x0029E8E0
		public int DamegaRate
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 1000000;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170023B3 RID: 9139
		// (get) Token: 0x0600A053 RID: 41043 RVA: 0x002A0724 File Offset: 0x0029E924
		public int MonsterId
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

		// Token: 0x170023B4 RID: 9140
		// (get) Token: 0x0600A054 RID: 41044 RVA: 0x002A0764 File Offset: 0x0029E964
		public string Icon
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

		// Token: 0x0600A055 RID: 41045 RVA: 0x002A079C File Offset: 0x0029E99C
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x0600A056 RID: 41046 RVA: 0x002A07AC File Offset: 0x0029E9AC
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x170023B5 RID: 9141
		// (get) Token: 0x0600A057 RID: 41047 RVA: 0x002A07C4 File Offset: 0x0029E9C4
		public string Name
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

		// Token: 0x0600A058 RID: 41048 RVA: 0x002A07FC File Offset: 0x0029E9FC
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x0600A059 RID: 41049 RVA: 0x002A080C File Offset: 0x0029EA0C
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x170023B6 RID: 9142
		// (get) Token: 0x0600A05A RID: 41050 RVA: 0x002A0824 File Offset: 0x0029EA24
		public string Desc
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

		// Token: 0x0600A05B RID: 41051 RVA: 0x002A085C File Offset: 0x0029EA5C
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x0600A05C RID: 41052 RVA: 0x002A086C File Offset: 0x0029EA6C
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x170023B7 RID: 9143
		// (get) Token: 0x0600A05D RID: 41053 RVA: 0x002A0884 File Offset: 0x0029EA84
		public string SmallIcon
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600A05E RID: 41054 RVA: 0x002A08BC File Offset: 0x0029EABC
		public Span<byte> GetSmallIconBytes()
		{
			return this.__p.__vector_as_span<byte>(30, 1);
		}

		// Token: 0x0600A05F RID: 41055 RVA: 0x002A08CC File Offset: 0x0029EACC
		public byte[] GetSmallIconArray()
		{
			return this.__p.__vector_as_array<byte>(30) ?? Array.Empty<byte>();
		}

		// Token: 0x0600A060 RID: 41056 RVA: 0x002A08E4 File Offset: 0x0029EAE4
		public string BigIcon(int j)
		{
			int num = this.__p.__offset(32);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170023B8 RID: 9144
		// (get) Token: 0x0600A061 RID: 41057 RVA: 0x002A0920 File Offset: 0x0029EB20
		public int BigIconLength
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600A062 RID: 41058 RVA: 0x002A094C File Offset: 0x0029EB4C
		public int TagIdList(int j)
		{
			int num = this.__p.__offset(34);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170023B9 RID: 9145
		// (get) Token: 0x0600A063 RID: 41059 RVA: 0x002A098C File Offset: 0x0029EB8C
		public int TagIdListLength
		{
			get
			{
				int num = this.__p.__offset(34);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600A064 RID: 41060 RVA: 0x002A09B8 File Offset: 0x0029EBB8
		public Span<int> GetTagIdListBytes()
		{
			return this.__p.__vector_as_span<int>(34, 4);
		}

		// Token: 0x0600A065 RID: 41061 RVA: 0x002A09C8 File Offset: 0x0029EBC8
		public int[] GetTagIdListArray()
		{
			return this.__p.__vector_as_array<int>(34) ?? Array.Empty<int>();
		}

		// Token: 0x170023BA RID: 9146
		// (get) Token: 0x0600A066 RID: 41062 RVA: 0x002A09E0 File Offset: 0x0029EBE0
		public string SmallIconInModeView
		{
			get
			{
				int num = this.__p.__offset(36);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600A067 RID: 41063 RVA: 0x002A0A18 File Offset: 0x0029EC18
		public Span<byte> GetSmallIconInModeViewBytes()
		{
			return this.__p.__vector_as_span<byte>(36, 1);
		}

		// Token: 0x0600A068 RID: 41064 RVA: 0x002A0A28 File Offset: 0x0029EC28
		public byte[] GetSmallIconInModeViewArray()
		{
			return this.__p.__vector_as_array<byte>(36) ?? Array.Empty<byte>();
		}

		// Token: 0x170023BB RID: 9147
		// (get) Token: 0x0600A069 RID: 41065 RVA: 0x002A0A40 File Offset: 0x0029EC40
		public string BigIconInModeView
		{
			get
			{
				int num = this.__p.__offset(38);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600A06A RID: 41066 RVA: 0x002A0A78 File Offset: 0x0029EC78
		public Span<byte> GetBigIconInModeViewBytes()
		{
			return this.__p.__vector_as_span<byte>(38, 1);
		}

		// Token: 0x0600A06B RID: 41067 RVA: 0x002A0A88 File Offset: 0x0029EC88
		public byte[] GetBigIconInModeViewArray()
		{
			return this.__p.__vector_as_array<byte>(38) ?? Array.Empty<byte>();
		}

		// Token: 0x170023BC RID: 9148
		// (get) Token: 0x0600A06C RID: 41068 RVA: 0x002A0AA0 File Offset: 0x0029ECA0
		public string SmallIconHandBook
		{
			get
			{
				int num = this.__p.__offset(40);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600A06D RID: 41069 RVA: 0x002A0AD8 File Offset: 0x0029ECD8
		public Span<byte> GetSmallIconHandBookBytes()
		{
			return this.__p.__vector_as_span<byte>(40, 1);
		}

		// Token: 0x0600A06E RID: 41070 RVA: 0x002A0AE8 File Offset: 0x0029ECE8
		public byte[] GetSmallIconHandBookArray()
		{
			return this.__p.__vector_as_array<byte>(40) ?? Array.Empty<byte>();
		}

		// Token: 0x170023BD RID: 9149
		// (get) Token: 0x0600A06F RID: 41071 RVA: 0x002A0B00 File Offset: 0x0029ED00
		public string MonsterPortrait
		{
			get
			{
				int num = this.__p.__offset(42);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600A070 RID: 41072 RVA: 0x002A0B38 File Offset: 0x0029ED38
		public Span<byte> GetMonsterPortraitBytes()
		{
			return this.__p.__vector_as_span<byte>(42, 1);
		}

		// Token: 0x0600A071 RID: 41073 RVA: 0x002A0B48 File Offset: 0x0029ED48
		public byte[] GetMonsterPortraitArray()
		{
			return this.__p.__vector_as_array<byte>(42) ?? Array.Empty<byte>();
		}

		// Token: 0x170023BE RID: 9150
		// (get) Token: 0x0600A072 RID: 41074 RVA: 0x002A0B60 File Offset: 0x0029ED60
		public int ElementId
		{
			get
			{
				int num = this.__p.__offset(44);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600A073 RID: 41075 RVA: 0x002A0BA0 File Offset: 0x0029EDA0
		public int ShowBuffIds(int j)
		{
			int num = this.__p.__offset(46);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170023BF RID: 9151
		// (get) Token: 0x0600A074 RID: 41076 RVA: 0x002A0BE0 File Offset: 0x0029EDE0
		public int ShowBuffIdsLength
		{
			get
			{
				int num = this.__p.__offset(46);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600A075 RID: 41077 RVA: 0x002A0C0C File Offset: 0x0029EE0C
		public Span<int> GetShowBuffIdsBytes()
		{
			return this.__p.__vector_as_span<int>(46, 4);
		}

		// Token: 0x0600A076 RID: 41078 RVA: 0x002A0C1C File Offset: 0x0029EE1C
		public int[] GetShowBuffIdsArray()
		{
			return this.__p.__vector_as_array<int>(46) ?? Array.Empty<int>();
		}

		// Token: 0x0600A077 RID: 41079 RVA: 0x002A0C34 File Offset: 0x0029EE34
		public DicIntIntArray? HandBookBuff(int j)
		{
			int num = this.__p.__offset(48);
			if (num == 0)
			{
				return null;
			}
			return new DicIntIntArray?(default(DicIntIntArray).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170023C0 RID: 9152
		// (get) Token: 0x0600A078 RID: 41080 RVA: 0x002A0C98 File Offset: 0x0029EE98
		public int HandBookBuffLength
		{
			get
			{
				int num = this.__p.__offset(48);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600A079 RID: 41081 RVA: 0x002A0CC4 File Offset: 0x0029EEC4
		public int RecommendTeamFeature(int j)
		{
			int num = this.__p.__offset(50);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170023C1 RID: 9153
		// (get) Token: 0x0600A07A RID: 41082 RVA: 0x002A0D04 File Offset: 0x0029EF04
		public int RecommendTeamFeatureLength
		{
			get
			{
				int num = this.__p.__offset(50);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600A07B RID: 41083 RVA: 0x002A0D30 File Offset: 0x0029EF30
		public Span<int> GetRecommendTeamFeatureBytes()
		{
			return this.__p.__vector_as_span<int>(50, 4);
		}

		// Token: 0x0600A07C RID: 41084 RVA: 0x002A0D40 File Offset: 0x0029EF40
		public int[] GetRecommendTeamFeatureArray()
		{
			return this.__p.__vector_as_array<int>(50) ?? Array.Empty<int>();
		}

		// Token: 0x170023C2 RID: 9154
		// (get) Token: 0x0600A07D RID: 41085 RVA: 0x002A0D58 File Offset: 0x0029EF58
		public float DamegaRateShow
		{
			get
			{
				int num = this.__p.__offset(52);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600A07E RID: 41086 RVA: 0x002A0D99 File Offset: 0x0029EF99
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用BigIconIter()或GetBigIconBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] BigIcon()
		{
			return this.BigIconIter().ToArray<string>();
		}

		// Token: 0x0600A07F RID: 41087 RVA: 0x002A0DA6 File Offset: 0x0029EFA6
		[NullableContext(1)]
		public readonly IEnumerable<string> BigIconIter()
		{
			NewTowerWave.<BigIconIter>d__86 <BigIconIter>d__ = new NewTowerWave.<BigIconIter>d__86(-2);
			<BigIconIter>d__.<>3__<>4__this = this;
			return <BigIconIter>d__;
		}

		// Token: 0x0600A080 RID: 41088 RVA: 0x002A0DBC File Offset: 0x0029EFBC
		[NullableContext(1)]
		[Obsolete("已废弃，请使用HandBookBuffFrozenDict()缓存字典，遍历请使用HandBookBuffIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, IntArray> HandBookBuff()
		{
			return this.HandBookBuffIter().ToDictionary((DicIntIntArray element) => element.Key, (DicIntIntArray element) => element.Value.Value);
		}

		// Token: 0x0600A081 RID: 41089 RVA: 0x002A0E12 File Offset: 0x0029F012
		[NullableContext(1)]
		public readonly IEnumerable<DicIntIntArray> HandBookBuffIter()
		{
			NewTowerWave.<HandBookBuffIter>d__88 <HandBookBuffIter>d__ = new NewTowerWave.<HandBookBuffIter>d__88(-2);
			<HandBookBuffIter>d__.<>3__<>4__this = this;
			return <HandBookBuffIter>d__;
		}

		// Token: 0x0600A082 RID: 41090 RVA: 0x002A0E28 File Offset: 0x0029F028
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用RecommendTeamFeatureIter()或GetRecommendTeamFeatureBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] RecommendTeamFeature()
		{
			NewTowerWave newTowerWave = this;
			return newTowerWave.GetRecommendTeamFeatureArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600A083 RID: 41091 RVA: 0x002A0E4C File Offset: 0x0029F04C
		[NullableContext(1)]
		public readonly IEnumerable<int> RecommendTeamFeatureIter()
		{
			NewTowerWave.<RecommendTeamFeatureIter>d__90 <RecommendTeamFeatureIter>d__ = new NewTowerWave.<RecommendTeamFeatureIter>d__90(-2);
			<RecommendTeamFeatureIter>d__.<>3__<>4__this = this;
			return <RecommendTeamFeatureIter>d__;
		}

		// Token: 0x0600A084 RID: 41092 RVA: 0x002A0E64 File Offset: 0x0029F064
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ShowBuffIdsIter()或GetShowBuffIdsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] ShowBuffIds()
		{
			NewTowerWave newTowerWave = this;
			return newTowerWave.GetShowBuffIdsArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600A085 RID: 41093 RVA: 0x002A0E88 File Offset: 0x0029F088
		[NullableContext(1)]
		public readonly IEnumerable<int> ShowBuffIdsIter()
		{
			NewTowerWave.<ShowBuffIdsIter>d__92 <ShowBuffIdsIter>d__ = new NewTowerWave.<ShowBuffIdsIter>d__92(-2);
			<ShowBuffIdsIter>d__.<>3__<>4__this = this;
			return <ShowBuffIdsIter>d__;
		}

		// Token: 0x0600A086 RID: 41094 RVA: 0x002A0EA0 File Offset: 0x0029F0A0
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用TagIdListIter()或GetTagIdListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] TagIdList()
		{
			NewTowerWave newTowerWave = this;
			return newTowerWave.GetTagIdListArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600A087 RID: 41095 RVA: 0x002A0EC4 File Offset: 0x0029F0C4
		[NullableContext(1)]
		public readonly IEnumerable<int> TagIdListIter()
		{
			NewTowerWave.<TagIdListIter>d__94 <TagIdListIter>d__ = new NewTowerWave.<TagIdListIter>d__94(-2);
			<TagIdListIter>d__.<>3__<>4__this = this;
			return <TagIdListIter>d__;
		}

		// Token: 0x0600A088 RID: 41096 RVA: 0x002A0EDC File Offset: 0x0029F0DC
		public IntArray? GetHandBookBuff(int key)
		{
			this.EnsureHandBookBuffCacheIfNeeded();
			IntArray value;
			if (!this.HandBookBuffCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new IntArray?(value);
		}

		// Token: 0x0600A089 RID: 41097 RVA: 0x002A0F10 File Offset: 0x0029F110
		private void EnsureHandBookBuffCacheIfNeeded()
		{
			if (this.HandBookBuffCache != null)
			{
				return;
			}
			this.HandBookBuffCache = this.HandBookBuffIter().ToFrozenDictionary((DicIntIntArray kvp) => kvp.Key, (DicIntIntArray kvp) => kvp.Value.Value, null);
		}

		// Token: 0x0600A08A RID: 41098 RVA: 0x002A0F76 File Offset: 0x0029F176
		[NullableContext(2)]
		public FrozenDictionary<int, IntArray> GetHandBookBuffFrozenDict(int key)
		{
			this.EnsureHandBookBuffCacheIfNeeded();
			return this.HandBookBuffCache;
		}

		// Token: 0x04004F4A RID: 20298
		private Table __p;

		// Token: 0x04004F4B RID: 20299
		[Nullable(2)]
		private FrozenDictionary<int, IntArray> HandBookBuffCache;
	}
}
