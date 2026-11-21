using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001102 RID: 4354
	public struct RogueResTheme : IFlatbufferObject
	{
		// Token: 0x17003163 RID: 12643
		// (get) Token: 0x0600CAB1 RID: 51889 RVA: 0x0030CBC7 File Offset: 0x0030ADC7
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600CAB2 RID: 51890 RVA: 0x0030CBD4 File Offset: 0x0030ADD4
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600CAB3 RID: 51891 RVA: 0x0030CBDC File Offset: 0x0030ADDC
		public static RogueResTheme GetRootAsRogueResTheme(ByteBuffer _bb)
		{
			return RogueResTheme.GetRootAsRogueResTheme(_bb, default(RogueResTheme));
		}

		// Token: 0x0600CAB4 RID: 51892 RVA: 0x0030CBF8 File Offset: 0x0030ADF8
		public static RogueResTheme GetRootAsRogueResTheme(ByteBuffer _bb, RogueResTheme obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600CAB5 RID: 51893 RVA: 0x0030CC15 File Offset: 0x0030AE15
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600CAB6 RID: 51894 RVA: 0x0030CC24 File Offset: 0x0030AE24
		public RogueResTheme __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003164 RID: 12644
		// (get) Token: 0x0600CAB7 RID: 51895 RVA: 0x0030CC34 File Offset: 0x0030AE34
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

		// Token: 0x17003165 RID: 12645
		// (get) Token: 0x0600CAB8 RID: 51896 RVA: 0x0030CC70 File Offset: 0x0030AE70
		public int ActivityId
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

		// Token: 0x17003166 RID: 12646
		// (get) Token: 0x0600CAB9 RID: 51897 RVA: 0x0030CCAC File Offset: 0x0030AEAC
		public int TimerId
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

		// Token: 0x0600CABA RID: 51898 RVA: 0x0030CCE8 File Offset: 0x0030AEE8
		public int Insts(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003167 RID: 12647
		// (get) Token: 0x0600CABB RID: 51899 RVA: 0x0030CD28 File Offset: 0x0030AF28
		public int InstsLength
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600CABC RID: 51900 RVA: 0x0030CD54 File Offset: 0x0030AF54
		public Span<int> GetInstsBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x0600CABD RID: 51901 RVA: 0x0030CD64 File Offset: 0x0030AF64
		public int[] GetInstsArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x0600CABE RID: 51902 RVA: 0x0030CD7C File Offset: 0x0030AF7C
		public DicIntInt? PreInsts(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17003168 RID: 12648
		// (get) Token: 0x0600CABF RID: 51903 RVA: 0x0030CDE0 File Offset: 0x0030AFE0
		public int PreInstsLength
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17003169 RID: 12649
		// (get) Token: 0x0600CAC0 RID: 51904 RVA: 0x0030CE0C File Offset: 0x0030B00C
		public int SkillItem
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

		// Token: 0x1700316A RID: 12650
		// (get) Token: 0x0600CAC1 RID: 51905 RVA: 0x0030CE4C File Offset: 0x0030B04C
		public int SkillMax
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

		// Token: 0x1700316B RID: 12651
		// (get) Token: 0x0600CAC2 RID: 51906 RVA: 0x0030CE8C File Offset: 0x0030B08C
		public int PointItem
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

		// Token: 0x1700316C RID: 12652
		// (get) Token: 0x0600CAC3 RID: 51907 RVA: 0x0030CECC File Offset: 0x0030B0CC
		public int PointItemMax
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

		// Token: 0x1700316D RID: 12653
		// (get) Token: 0x0600CAC4 RID: 51908 RVA: 0x0030CF0C File Offset: 0x0030B10C
		public int ShopId
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

		// Token: 0x1700316E RID: 12654
		// (get) Token: 0x0600CAC5 RID: 51909 RVA: 0x0030CF4C File Offset: 0x0030B14C
		public string Name
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

		// Token: 0x0600CAC6 RID: 51910 RVA: 0x0030CF84 File Offset: 0x0030B184
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x0600CAC7 RID: 51911 RVA: 0x0030CF94 File Offset: 0x0030B194
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x1700316F RID: 12655
		// (get) Token: 0x0600CAC8 RID: 51912 RVA: 0x0030CFAC File Offset: 0x0030B1AC
		public int HelpId
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

		// Token: 0x17003170 RID: 12656
		// (get) Token: 0x0600CAC9 RID: 51913 RVA: 0x0030CFEC File Offset: 0x0030B1EC
		public string Icon
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

		// Token: 0x0600CACA RID: 51914 RVA: 0x0030D024 File Offset: 0x0030B224
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x0600CACB RID: 51915 RVA: 0x0030D034 File Offset: 0x0030B234
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x17003171 RID: 12657
		// (get) Token: 0x0600CACC RID: 51916 RVA: 0x0030D04C File Offset: 0x0030B24C
		public string ViewName
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

		// Token: 0x0600CACD RID: 51917 RVA: 0x0030D084 File Offset: 0x0030B284
		public Span<byte> GetViewNameBytes()
		{
			return this.__p.__vector_as_span<byte>(30, 1);
		}

		// Token: 0x0600CACE RID: 51918 RVA: 0x0030D094 File Offset: 0x0030B294
		public byte[] GetViewNameArray()
		{
			return this.__p.__vector_as_array<byte>(30) ?? Array.Empty<byte>();
		}

		// Token: 0x17003172 RID: 12658
		// (get) Token: 0x0600CACF RID: 51919 RVA: 0x0030D0AC File Offset: 0x0030B2AC
		public string CoverF
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600CAD0 RID: 51920 RVA: 0x0030D0E4 File Offset: 0x0030B2E4
		public Span<byte> GetCoverFBytes()
		{
			return this.__p.__vector_as_span<byte>(32, 1);
		}

		// Token: 0x0600CAD1 RID: 51921 RVA: 0x0030D0F4 File Offset: 0x0030B2F4
		public byte[] GetCoverFArray()
		{
			return this.__p.__vector_as_array<byte>(32) ?? Array.Empty<byte>();
		}

		// Token: 0x17003173 RID: 12659
		// (get) Token: 0x0600CAD2 RID: 51922 RVA: 0x0030D10C File Offset: 0x0030B30C
		public string CoverM
		{
			get
			{
				int num = this.__p.__offset(34);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600CAD3 RID: 51923 RVA: 0x0030D144 File Offset: 0x0030B344
		public Span<byte> GetCoverMBytes()
		{
			return this.__p.__vector_as_span<byte>(34, 1);
		}

		// Token: 0x0600CAD4 RID: 51924 RVA: 0x0030D154 File Offset: 0x0030B354
		public byte[] GetCoverMArray()
		{
			return this.__p.__vector_as_array<byte>(34) ?? Array.Empty<byte>();
		}

		// Token: 0x0600CAD5 RID: 51925 RVA: 0x0030D16C File Offset: 0x0030B36C
		[NullableContext(1)]
		public int[] Insts()
		{
			return this.GetInstsArray();
		}

		// Token: 0x0600CAD6 RID: 51926 RVA: 0x0030D174 File Offset: 0x0030B374
		[NullableContext(1)]
		public IEnumerable<int> InstsIter()
		{
			RogueResTheme.<InstsIter>d__55 <InstsIter>d__ = new RogueResTheme.<InstsIter>d__55(-2);
			<InstsIter>d__.<>3__<>4__this = this;
			return <InstsIter>d__;
		}

		// Token: 0x0600CAD7 RID: 51927 RVA: 0x0030D18C File Offset: 0x0030B38C
		[NullableContext(1)]
		public Dictionary<int, int> PreInsts()
		{
			return this.PreInstsIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600CAD8 RID: 51928 RVA: 0x0030D1E2 File Offset: 0x0030B3E2
		[NullableContext(1)]
		public IEnumerable<DicIntInt> PreInstsIter()
		{
			RogueResTheme.<PreInstsIter>d__57 <PreInstsIter>d__ = new RogueResTheme.<PreInstsIter>d__57(-2);
			<PreInstsIter>d__.<>3__<>4__this = this;
			return <PreInstsIter>d__;
		}

		// Token: 0x0600CAD9 RID: 51929 RVA: 0x0030D1F8 File Offset: 0x0030B3F8
		public int? GetPreInsts(int key)
		{
			this.EnsurePreInstsCacheIfNeeded();
			int value;
			if (!this.PreInstsCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x0600CADA RID: 51930 RVA: 0x0030D22C File Offset: 0x0030B42C
		private void EnsurePreInstsCacheIfNeeded()
		{
			if (this.PreInstsCache != null)
			{
				return;
			}
			this.PreInstsCache = this.PreInstsIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600CADB RID: 51931 RVA: 0x0030D292 File Offset: 0x0030B492
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetPreInstsFrozenDict()
		{
			this.EnsurePreInstsCacheIfNeeded();
			return this.PreInstsCache;
		}

		// Token: 0x040056F1 RID: 22257
		private Table __p;

		// Token: 0x040056F2 RID: 22258
		[Nullable(2)]
		private FrozenDictionary<int, int> PreInstsCache;
	}
}
