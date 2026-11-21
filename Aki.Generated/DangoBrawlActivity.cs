using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C9E RID: 3230
	public struct DangoBrawlActivity : IFlatbufferObject
	{
		// Token: 0x17000AC6 RID: 2758
		// (get) Token: 0x06006274 RID: 25204 RVA: 0x00226647 File Offset: 0x00224847
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006275 RID: 25205 RVA: 0x00226654 File Offset: 0x00224854
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006276 RID: 25206 RVA: 0x0022665C File Offset: 0x0022485C
		public static DangoBrawlActivity GetRootAsDangoBrawlActivity(ByteBuffer _bb)
		{
			return DangoBrawlActivity.GetRootAsDangoBrawlActivity(_bb, default(DangoBrawlActivity));
		}

		// Token: 0x06006277 RID: 25207 RVA: 0x00226678 File Offset: 0x00224878
		public static DangoBrawlActivity GetRootAsDangoBrawlActivity(ByteBuffer _bb, DangoBrawlActivity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006278 RID: 25208 RVA: 0x00226695 File Offset: 0x00224895
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006279 RID: 25209 RVA: 0x002266A4 File Offset: 0x002248A4
		public DangoBrawlActivity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000AC7 RID: 2759
		// (get) Token: 0x0600627A RID: 25210 RVA: 0x002266B4 File Offset: 0x002248B4
		public int ActivityId
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

		// Token: 0x0600627B RID: 25211 RVA: 0x002266F0 File Offset: 0x002248F0
		public int DangoBrawlGridSize(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000AC8 RID: 2760
		// (get) Token: 0x0600627C RID: 25212 RVA: 0x00226730 File Offset: 0x00224930
		public int DangoBrawlGridSizeLength
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600627D RID: 25213 RVA: 0x0022675B File Offset: 0x0022495B
		public Span<int> GetDangoBrawlGridSizeBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0600627E RID: 25214 RVA: 0x0022676A File Offset: 0x0022496A
		public int[] GetDangoBrawlGridSizeArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x17000AC9 RID: 2761
		// (get) Token: 0x0600627F RID: 25215 RVA: 0x00226784 File Offset: 0x00224984
		public int DangoBrawlSellDiscount
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

		// Token: 0x17000ACA RID: 2762
		// (get) Token: 0x06006280 RID: 25216 RVA: 0x002267C0 File Offset: 0x002249C0
		public int HasteBpLimit
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

		// Token: 0x17000ACB RID: 2763
		// (get) Token: 0x06006281 RID: 25217 RVA: 0x00226800 File Offset: 0x00224A00
		public int ShopId
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

		// Token: 0x17000ACC RID: 2764
		// (get) Token: 0x06006282 RID: 25218 RVA: 0x00226840 File Offset: 0x00224A40
		public int LimitCoinId
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

		// Token: 0x17000ACD RID: 2765
		// (get) Token: 0x06006283 RID: 25219 RVA: 0x00226880 File Offset: 0x00224A80
		public int LimitCoinMax
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000ACE RID: 2766
		// (get) Token: 0x06006284 RID: 25220 RVA: 0x002268C0 File Offset: 0x00224AC0
		public int ScoreItemId
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

		// Token: 0x17000ACF RID: 2767
		// (get) Token: 0x06006285 RID: 25221 RVA: 0x00226900 File Offset: 0x00224B00
		public int MinLuckyCoinPer
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

		// Token: 0x17000AD0 RID: 2768
		// (get) Token: 0x06006286 RID: 25222 RVA: 0x00226940 File Offset: 0x00224B40
		public int MaxLuckyCoinPer
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

		// Token: 0x17000AD1 RID: 2769
		// (get) Token: 0x06006287 RID: 25223 RVA: 0x00226980 File Offset: 0x00224B80
		public int BenchItemLimit
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

		// Token: 0x17000AD2 RID: 2770
		// (get) Token: 0x06006288 RID: 25224 RVA: 0x002269C0 File Offset: 0x00224BC0
		public int BuffLimit
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

		// Token: 0x06006289 RID: 25225 RVA: 0x00226A00 File Offset: 0x00224C00
		public int DefaultUnlockRoleId(int j)
		{
			int num = this.__p.__offset(28);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000AD3 RID: 2771
		// (get) Token: 0x0600628A RID: 25226 RVA: 0x00226A40 File Offset: 0x00224C40
		public int DefaultUnlockRoleIdLength
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600628B RID: 25227 RVA: 0x00226A6C File Offset: 0x00224C6C
		public Span<int> GetDefaultUnlockRoleIdBytes()
		{
			return this.__p.__vector_as_span<int>(28, 4);
		}

		// Token: 0x0600628C RID: 25228 RVA: 0x00226A7C File Offset: 0x00224C7C
		public int[] GetDefaultUnlockRoleIdArray()
		{
			return this.__p.__vector_as_array<int>(28) ?? Array.Empty<int>();
		}

		// Token: 0x17000AD4 RID: 2772
		// (get) Token: 0x0600628D RID: 25229 RVA: 0x00226A94 File Offset: 0x00224C94
		public int VisionSkinItemId
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

		// Token: 0x17000AD5 RID: 2773
		// (get) Token: 0x0600628E RID: 25230 RVA: 0x00226AD4 File Offset: 0x00224CD4
		public int LimitScoreRewardId
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

		// Token: 0x17000AD6 RID: 2774
		// (get) Token: 0x0600628F RID: 25231 RVA: 0x00226B14 File Offset: 0x00224D14
		public int RecommendQuestId
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

		// Token: 0x17000AD7 RID: 2775
		// (get) Token: 0x06006290 RID: 25232 RVA: 0x00226B54 File Offset: 0x00224D54
		public int RecommendQuestNodeId
		{
			get
			{
				int num = this.__p.__offset(36);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000AD8 RID: 2776
		// (get) Token: 0x06006291 RID: 25233 RVA: 0x00226B94 File Offset: 0x00224D94
		public int RecommendQuestCondition
		{
			get
			{
				int num = this.__p.__offset(38);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000AD9 RID: 2777
		// (get) Token: 0x06006292 RID: 25234 RVA: 0x00226BD4 File Offset: 0x00224DD4
		public string RecommendQuestLabel
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

		// Token: 0x06006293 RID: 25235 RVA: 0x00226C0C File Offset: 0x00224E0C
		public Span<byte> GetRecommendQuestLabelBytes()
		{
			return this.__p.__vector_as_span<byte>(40, 1);
		}

		// Token: 0x06006294 RID: 25236 RVA: 0x00226C1C File Offset: 0x00224E1C
		public byte[] GetRecommendQuestLabelArray()
		{
			return this.__p.__vector_as_array<byte>(40) ?? Array.Empty<byte>();
		}

		// Token: 0x06006295 RID: 25237 RVA: 0x00226C34 File Offset: 0x00224E34
		public int MainRoleList(int j)
		{
			int num = this.__p.__offset(42);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000ADA RID: 2778
		// (get) Token: 0x06006296 RID: 25238 RVA: 0x00226C74 File Offset: 0x00224E74
		public int MainRoleListLength
		{
			get
			{
				int num = this.__p.__offset(42);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06006297 RID: 25239 RVA: 0x00226CA0 File Offset: 0x00224EA0
		public Span<int> GetMainRoleListBytes()
		{
			return this.__p.__vector_as_span<int>(42, 4);
		}

		// Token: 0x06006298 RID: 25240 RVA: 0x00226CB0 File Offset: 0x00224EB0
		public int[] GetMainRoleListArray()
		{
			return this.__p.__vector_as_array<int>(42) ?? Array.Empty<int>();
		}

		// Token: 0x06006299 RID: 25241 RVA: 0x00226CC8 File Offset: 0x00224EC8
		public DicIntInt? MainRoleSexChange(int j)
		{
			int num = this.__p.__offset(44);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17000ADB RID: 2779
		// (get) Token: 0x0600629A RID: 25242 RVA: 0x00226D2C File Offset: 0x00224F2C
		public int MainRoleSexChangeLength
		{
			get
			{
				int num = this.__p.__offset(44);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17000ADC RID: 2780
		// (get) Token: 0x0600629B RID: 25243 RVA: 0x00226D58 File Offset: 0x00224F58
		public int DamageTxtNormal
		{
			get
			{
				int num = this.__p.__offset(46);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000ADD RID: 2781
		// (get) Token: 0x0600629C RID: 25244 RVA: 0x00226D98 File Offset: 0x00224F98
		public int DamageTxtHeal
		{
			get
			{
				int num = this.__p.__offset(48);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000ADE RID: 2782
		// (get) Token: 0x0600629D RID: 25245 RVA: 0x00226DD8 File Offset: 0x00224FD8
		public int DamageTxtShield
		{
			get
			{
				int num = this.__p.__offset(50);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000ADF RID: 2783
		// (get) Token: 0x0600629E RID: 25246 RVA: 0x00226E18 File Offset: 0x00225018
		public int DamageTxtLifeSteal
		{
			get
			{
				int num = this.__p.__offset(52);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000AE0 RID: 2784
		// (get) Token: 0x0600629F RID: 25247 RVA: 0x00226E58 File Offset: 0x00225058
		public int CoinText
		{
			get
			{
				int num = this.__p.__offset(54);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000AE1 RID: 2785
		// (get) Token: 0x060062A0 RID: 25248 RVA: 0x00226E98 File Offset: 0x00225098
		public int ShopTipsTalkGapTime
		{
			get
			{
				int num = this.__p.__offset(56);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000AE2 RID: 2786
		// (get) Token: 0x060062A1 RID: 25249 RVA: 0x00226ED8 File Offset: 0x002250D8
		public int ShopWeaponTalkQuality
		{
			get
			{
				int num = this.__p.__offset(58);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000AE3 RID: 2787
		// (get) Token: 0x060062A2 RID: 25250 RVA: 0x00226F18 File Offset: 0x00225118
		public int StartFightDuringTime
		{
			get
			{
				int num = this.__p.__offset(60);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000AE4 RID: 2788
		// (get) Token: 0x060062A3 RID: 25251 RVA: 0x00226F58 File Offset: 0x00225158
		public int HpChangeColor
		{
			get
			{
				int num = this.__p.__offset(62);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060062A4 RID: 25252 RVA: 0x00226F95 File Offset: 0x00225195
		[NullableContext(1)]
		public int[] DangoBrawlGridSize()
		{
			return this.GetDangoBrawlGridSizeArray();
		}

		// Token: 0x060062A5 RID: 25253 RVA: 0x00226F9D File Offset: 0x0022519D
		[NullableContext(1)]
		public IEnumerable<int> DangoBrawlGridSizeIter()
		{
			DangoBrawlActivity.<DangoBrawlGridSizeIter>d__81 <DangoBrawlGridSizeIter>d__ = new DangoBrawlActivity.<DangoBrawlGridSizeIter>d__81(-2);
			<DangoBrawlGridSizeIter>d__.<>3__<>4__this = this;
			return <DangoBrawlGridSizeIter>d__;
		}

		// Token: 0x060062A6 RID: 25254 RVA: 0x00226FB2 File Offset: 0x002251B2
		[NullableContext(1)]
		public int[] DefaultUnlockRoleId()
		{
			return this.GetDefaultUnlockRoleIdArray();
		}

		// Token: 0x060062A7 RID: 25255 RVA: 0x00226FBA File Offset: 0x002251BA
		[NullableContext(1)]
		public IEnumerable<int> DefaultUnlockRoleIdIter()
		{
			DangoBrawlActivity.<DefaultUnlockRoleIdIter>d__83 <DefaultUnlockRoleIdIter>d__ = new DangoBrawlActivity.<DefaultUnlockRoleIdIter>d__83(-2);
			<DefaultUnlockRoleIdIter>d__.<>3__<>4__this = this;
			return <DefaultUnlockRoleIdIter>d__;
		}

		// Token: 0x060062A8 RID: 25256 RVA: 0x00226FCF File Offset: 0x002251CF
		[NullableContext(1)]
		public int[] MainRoleList()
		{
			return this.GetMainRoleListArray();
		}

		// Token: 0x060062A9 RID: 25257 RVA: 0x00226FD7 File Offset: 0x002251D7
		[NullableContext(1)]
		public IEnumerable<int> MainRoleListIter()
		{
			DangoBrawlActivity.<MainRoleListIter>d__85 <MainRoleListIter>d__ = new DangoBrawlActivity.<MainRoleListIter>d__85(-2);
			<MainRoleListIter>d__.<>3__<>4__this = this;
			return <MainRoleListIter>d__;
		}

		// Token: 0x060062AA RID: 25258 RVA: 0x00226FEC File Offset: 0x002251EC
		[NullableContext(1)]
		public Dictionary<int, int> MainRoleSexChange()
		{
			return this.MainRoleSexChangeIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x060062AB RID: 25259 RVA: 0x00227042 File Offset: 0x00225242
		[NullableContext(1)]
		public IEnumerable<DicIntInt> MainRoleSexChangeIter()
		{
			DangoBrawlActivity.<MainRoleSexChangeIter>d__87 <MainRoleSexChangeIter>d__ = new DangoBrawlActivity.<MainRoleSexChangeIter>d__87(-2);
			<MainRoleSexChangeIter>d__.<>3__<>4__this = this;
			return <MainRoleSexChangeIter>d__;
		}

		// Token: 0x060062AC RID: 25260 RVA: 0x00227058 File Offset: 0x00225258
		public int? GetMainRoleSexChange(int key)
		{
			this.EnsureMainRoleSexChangeCacheIfNeeded();
			int value;
			if (!this.MainRoleSexChangeCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x060062AD RID: 25261 RVA: 0x0022708C File Offset: 0x0022528C
		private void EnsureMainRoleSexChangeCacheIfNeeded()
		{
			if (this.MainRoleSexChangeCache != null)
			{
				return;
			}
			this.MainRoleSexChangeCache = this.MainRoleSexChangeIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x060062AE RID: 25262 RVA: 0x002270F2 File Offset: 0x002252F2
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetMainRoleSexChangeFrozenDict()
		{
			this.EnsureMainRoleSexChangeCacheIfNeeded();
			return this.MainRoleSexChangeCache;
		}

		// Token: 0x040051C4 RID: 20932
		private Table __p;

		// Token: 0x040051C5 RID: 20933
		[Nullable(2)]
		private FrozenDictionary<int, int> MainRoleSexChangeCache;
	}
}
