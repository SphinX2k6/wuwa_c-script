using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010D6 RID: 4310
	[NullableContext(1)]
	[Nullable(0)]
	public struct RogueResBond : IFlatbufferObject
	{
		// Token: 0x17003021 RID: 12321
		// (get) Token: 0x0600C6BB RID: 50875 RVA: 0x0030438C File Offset: 0x0030258C
		[Nullable(0)]
		public ByteBuffer ByteBuffer
		{
			[NullableContext(0)]
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C6BC RID: 50876 RVA: 0x00304399 File Offset: 0x00302599
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C6BD RID: 50877 RVA: 0x003043A0 File Offset: 0x003025A0
		[NullableContext(0)]
		public static RogueResBond GetRootAsRogueResBond(ByteBuffer _bb)
		{
			return RogueResBond.GetRootAsRogueResBond(_bb, default(RogueResBond));
		}

		// Token: 0x0600C6BE RID: 50878 RVA: 0x003043BC File Offset: 0x003025BC
		[NullableContext(0)]
		public static RogueResBond GetRootAsRogueResBond(ByteBuffer _bb, RogueResBond obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C6BF RID: 50879 RVA: 0x003043D9 File Offset: 0x003025D9
		[NullableContext(0)]
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C6C0 RID: 50880 RVA: 0x003043E8 File Offset: 0x003025E8
		[NullableContext(0)]
		public RogueResBond __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003022 RID: 12322
		// (get) Token: 0x0600C6C1 RID: 50881 RVA: 0x003043F8 File Offset: 0x003025F8
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

		// Token: 0x17003023 RID: 12323
		// (get) Token: 0x0600C6C2 RID: 50882 RVA: 0x00304434 File Offset: 0x00302634
		public int Rarity
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

		// Token: 0x17003024 RID: 12324
		// (get) Token: 0x0600C6C3 RID: 50883 RVA: 0x00304470 File Offset: 0x00302670
		public int ActLinkNum
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 3;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003025 RID: 12325
		// (get) Token: 0x0600C6C4 RID: 50884 RVA: 0x003044AC File Offset: 0x003026AC
		public int StarMapType
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600C6C5 RID: 50885 RVA: 0x003044EC File Offset: 0x003026EC
		public DicIntInt? StarMap(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17003026 RID: 12326
		// (get) Token: 0x0600C6C6 RID: 50886 RVA: 0x00304550 File Offset: 0x00302750
		public int StarMapLength
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

		// Token: 0x0600C6C7 RID: 50887 RVA: 0x0030457C File Offset: 0x0030277C
		public DicIntIntArray? BattleEffect(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new DicIntIntArray?(default(DicIntIntArray).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17003027 RID: 12327
		// (get) Token: 0x0600C6C8 RID: 50888 RVA: 0x003045E0 File Offset: 0x003027E0
		public int BattleEffectLength
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600C6C9 RID: 50889 RVA: 0x0030460C File Offset: 0x0030280C
		public DicIntInt? ExploreEffect(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17003028 RID: 12328
		// (get) Token: 0x0600C6CA RID: 50890 RVA: 0x00304670 File Offset: 0x00302870
		public int ExploreEffectLength
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600C6CB RID: 50891 RVA: 0x0030469C File Offset: 0x0030289C
		public int LinkRule(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003029 RID: 12329
		// (get) Token: 0x0600C6CC RID: 50892 RVA: 0x003046DC File Offset: 0x003028DC
		public int LinkRuleLength
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600C6CD RID: 50893 RVA: 0x00304708 File Offset: 0x00302908
		[NullableContext(0)]
		public Span<int> GetLinkRuleBytes()
		{
			return this.__p.__vector_as_span<int>(18, 4);
		}

		// Token: 0x0600C6CE RID: 50894 RVA: 0x00304718 File Offset: 0x00302918
		[NullableContext(0)]
		public int[] GetLinkRuleArray()
		{
			return this.__p.__vector_as_array<int>(18) ?? Array.Empty<int>();
		}

		// Token: 0x0600C6CF RID: 50895 RVA: 0x00304730 File Offset: 0x00302930
		public DicIntInt? LinkEffect(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700302A RID: 12330
		// (get) Token: 0x0600C6D0 RID: 50896 RVA: 0x00304794 File Offset: 0x00302994
		public int LinkEffectLength
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

		// Token: 0x1700302B RID: 12331
		// (get) Token: 0x0600C6D1 RID: 50897 RVA: 0x003047C0 File Offset: 0x003029C0
		public int Cond
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

		// Token: 0x1700302C RID: 12332
		// (get) Token: 0x0600C6D2 RID: 50898 RVA: 0x00304800 File Offset: 0x00302A00
		[Nullable(0)]
		public string Icon
		{
			[NullableContext(0)]
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

		// Token: 0x0600C6D3 RID: 50899 RVA: 0x00304838 File Offset: 0x00302A38
		[NullableContext(0)]
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x0600C6D4 RID: 50900 RVA: 0x00304848 File Offset: 0x00302A48
		[NullableContext(0)]
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x1700302D RID: 12333
		// (get) Token: 0x0600C6D5 RID: 50901 RVA: 0x00304860 File Offset: 0x00302A60
		[Nullable(0)]
		public string Name
		{
			[NullableContext(0)]
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

		// Token: 0x0600C6D6 RID: 50902 RVA: 0x00304898 File Offset: 0x00302A98
		[NullableContext(0)]
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x0600C6D7 RID: 50903 RVA: 0x003048A8 File Offset: 0x00302AA8
		[NullableContext(0)]
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x0600C6D8 RID: 50904 RVA: 0x003048C0 File Offset: 0x00302AC0
		[NullableContext(0)]
		public string FightEffectDesc(int j)
		{
			int num = this.__p.__offset(28);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700302E RID: 12334
		// (get) Token: 0x0600C6D9 RID: 50905 RVA: 0x003048FC File Offset: 0x00302AFC
		public int FightEffectDescLength
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

		// Token: 0x0600C6DA RID: 50906 RVA: 0x00304928 File Offset: 0x00302B28
		[NullableContext(0)]
		public string FightEffectDescParam(int j)
		{
			int num = this.__p.__offset(30);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700302F RID: 12335
		// (get) Token: 0x0600C6DB RID: 50907 RVA: 0x00304964 File Offset: 0x00302B64
		public int FightEffectDescParamLength
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600C6DC RID: 50908 RVA: 0x00304990 File Offset: 0x00302B90
		[NullableContext(0)]
		public string ExploreEffectDesc(int j)
		{
			int num = this.__p.__offset(32);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003030 RID: 12336
		// (get) Token: 0x0600C6DD RID: 50909 RVA: 0x003049CC File Offset: 0x00302BCC
		public int ExploreEffectDescLength
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

		// Token: 0x0600C6DE RID: 50910 RVA: 0x003049F8 File Offset: 0x00302BF8
		[NullableContext(0)]
		public string ExploreEffectDescParam(int j)
		{
			int num = this.__p.__offset(34);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003031 RID: 12337
		// (get) Token: 0x0600C6DF RID: 50911 RVA: 0x00304A34 File Offset: 0x00302C34
		public int ExploreEffectDescParamLength
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

		// Token: 0x0600C6E0 RID: 50912 RVA: 0x00304A60 File Offset: 0x00302C60
		public DicIntString? LinkEffectDesc(int j)
		{
			int num = this.__p.__offset(36);
			if (num == 0)
			{
				return null;
			}
			return new DicIntString?(default(DicIntString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17003032 RID: 12338
		// (get) Token: 0x0600C6E1 RID: 50913 RVA: 0x00304AC4 File Offset: 0x00302CC4
		public int LinkEffectDescLength
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

		// Token: 0x0600C6E2 RID: 50914 RVA: 0x00304AF0 File Offset: 0x00302CF0
		public DicIntString? LinkEffectDescParam(int j)
		{
			int num = this.__p.__offset(38);
			if (num == 0)
			{
				return null;
			}
			return new DicIntString?(default(DicIntString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17003033 RID: 12339
		// (get) Token: 0x0600C6E3 RID: 50915 RVA: 0x00304B54 File Offset: 0x00302D54
		public int LinkEffectDescParamLength
		{
			get
			{
				int num = this.__p.__offset(38);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600C6E4 RID: 50916 RVA: 0x00304B80 File Offset: 0x00302D80
		public Dictionary<int, IntArray> BattleEffect()
		{
			return this.BattleEffectIter().ToDictionary((DicIntIntArray element) => element.Key, (DicIntIntArray element) => element.Value.Value);
		}

		// Token: 0x0600C6E5 RID: 50917 RVA: 0x00304BD6 File Offset: 0x00302DD6
		public IEnumerable<DicIntIntArray> BattleEffectIter()
		{
			RogueResBond.<BattleEffectIter>d__62 <BattleEffectIter>d__ = new RogueResBond.<BattleEffectIter>d__62(-2);
			<BattleEffectIter>d__.<>3__<>4__this = this;
			return <BattleEffectIter>d__;
		}

		// Token: 0x0600C6E6 RID: 50918 RVA: 0x00304BEC File Offset: 0x00302DEC
		public Dictionary<int, int> ExploreEffect()
		{
			return this.ExploreEffectIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600C6E7 RID: 50919 RVA: 0x00304C42 File Offset: 0x00302E42
		public IEnumerable<DicIntInt> ExploreEffectIter()
		{
			RogueResBond.<ExploreEffectIter>d__64 <ExploreEffectIter>d__ = new RogueResBond.<ExploreEffectIter>d__64(-2);
			<ExploreEffectIter>d__.<>3__<>4__this = this;
			return <ExploreEffectIter>d__;
		}

		// Token: 0x0600C6E8 RID: 50920 RVA: 0x00304C57 File Offset: 0x00302E57
		public string[] ExploreEffectDesc()
		{
			return this.ExploreEffectDescIter().ToArray<string>();
		}

		// Token: 0x0600C6E9 RID: 50921 RVA: 0x00304C64 File Offset: 0x00302E64
		public IEnumerable<string> ExploreEffectDescIter()
		{
			RogueResBond.<ExploreEffectDescIter>d__66 <ExploreEffectDescIter>d__ = new RogueResBond.<ExploreEffectDescIter>d__66(-2);
			<ExploreEffectDescIter>d__.<>3__<>4__this = this;
			return <ExploreEffectDescIter>d__;
		}

		// Token: 0x0600C6EA RID: 50922 RVA: 0x00304C79 File Offset: 0x00302E79
		public string[] ExploreEffectDescParam()
		{
			return this.ExploreEffectDescParamIter().ToArray<string>();
		}

		// Token: 0x0600C6EB RID: 50923 RVA: 0x00304C86 File Offset: 0x00302E86
		public IEnumerable<string> ExploreEffectDescParamIter()
		{
			RogueResBond.<ExploreEffectDescParamIter>d__68 <ExploreEffectDescParamIter>d__ = new RogueResBond.<ExploreEffectDescParamIter>d__68(-2);
			<ExploreEffectDescParamIter>d__.<>3__<>4__this = this;
			return <ExploreEffectDescParamIter>d__;
		}

		// Token: 0x0600C6EC RID: 50924 RVA: 0x00304C9B File Offset: 0x00302E9B
		public string[] FightEffectDesc()
		{
			return this.FightEffectDescIter().ToArray<string>();
		}

		// Token: 0x0600C6ED RID: 50925 RVA: 0x00304CA8 File Offset: 0x00302EA8
		public IEnumerable<string> FightEffectDescIter()
		{
			RogueResBond.<FightEffectDescIter>d__70 <FightEffectDescIter>d__ = new RogueResBond.<FightEffectDescIter>d__70(-2);
			<FightEffectDescIter>d__.<>3__<>4__this = this;
			return <FightEffectDescIter>d__;
		}

		// Token: 0x0600C6EE RID: 50926 RVA: 0x00304CBD File Offset: 0x00302EBD
		public string[] FightEffectDescParam()
		{
			return this.FightEffectDescParamIter().ToArray<string>();
		}

		// Token: 0x0600C6EF RID: 50927 RVA: 0x00304CCA File Offset: 0x00302ECA
		public IEnumerable<string> FightEffectDescParamIter()
		{
			RogueResBond.<FightEffectDescParamIter>d__72 <FightEffectDescParamIter>d__ = new RogueResBond.<FightEffectDescParamIter>d__72(-2);
			<FightEffectDescParamIter>d__.<>3__<>4__this = this;
			return <FightEffectDescParamIter>d__;
		}

		// Token: 0x0600C6F0 RID: 50928 RVA: 0x00304CE0 File Offset: 0x00302EE0
		public Dictionary<int, int> LinkEffect()
		{
			return this.LinkEffectIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600C6F1 RID: 50929 RVA: 0x00304D36 File Offset: 0x00302F36
		public IEnumerable<DicIntInt> LinkEffectIter()
		{
			RogueResBond.<LinkEffectIter>d__74 <LinkEffectIter>d__ = new RogueResBond.<LinkEffectIter>d__74(-2);
			<LinkEffectIter>d__.<>3__<>4__this = this;
			return <LinkEffectIter>d__;
		}

		// Token: 0x0600C6F2 RID: 50930 RVA: 0x00304D4C File Offset: 0x00302F4C
		public Dictionary<int, string> LinkEffectDesc()
		{
			return this.LinkEffectDescIter().ToDictionary((DicIntString element) => element.Key, (DicIntString element) => element.Value);
		}

		// Token: 0x0600C6F3 RID: 50931 RVA: 0x00304DA2 File Offset: 0x00302FA2
		public IEnumerable<DicIntString> LinkEffectDescIter()
		{
			RogueResBond.<LinkEffectDescIter>d__76 <LinkEffectDescIter>d__ = new RogueResBond.<LinkEffectDescIter>d__76(-2);
			<LinkEffectDescIter>d__.<>3__<>4__this = this;
			return <LinkEffectDescIter>d__;
		}

		// Token: 0x0600C6F4 RID: 50932 RVA: 0x00304DB8 File Offset: 0x00302FB8
		public Dictionary<int, string> LinkEffectDescParam()
		{
			return this.LinkEffectDescParamIter().ToDictionary((DicIntString element) => element.Key, (DicIntString element) => element.Value);
		}

		// Token: 0x0600C6F5 RID: 50933 RVA: 0x00304E0E File Offset: 0x0030300E
		public IEnumerable<DicIntString> LinkEffectDescParamIter()
		{
			RogueResBond.<LinkEffectDescParamIter>d__78 <LinkEffectDescParamIter>d__ = new RogueResBond.<LinkEffectDescParamIter>d__78(-2);
			<LinkEffectDescParamIter>d__.<>3__<>4__this = this;
			return <LinkEffectDescParamIter>d__;
		}

		// Token: 0x0600C6F6 RID: 50934 RVA: 0x00304E23 File Offset: 0x00303023
		public int[] LinkRule()
		{
			return this.GetLinkRuleArray();
		}

		// Token: 0x0600C6F7 RID: 50935 RVA: 0x00304E2B File Offset: 0x0030302B
		public IEnumerable<int> LinkRuleIter()
		{
			RogueResBond.<LinkRuleIter>d__80 <LinkRuleIter>d__ = new RogueResBond.<LinkRuleIter>d__80(-2);
			<LinkRuleIter>d__.<>3__<>4__this = this;
			return <LinkRuleIter>d__;
		}

		// Token: 0x0600C6F8 RID: 50936 RVA: 0x00304E40 File Offset: 0x00303040
		public Dictionary<int, int> StarMap()
		{
			return this.StarMapIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600C6F9 RID: 50937 RVA: 0x00304E96 File Offset: 0x00303096
		public IEnumerable<DicIntInt> StarMapIter()
		{
			RogueResBond.<StarMapIter>d__82 <StarMapIter>d__ = new RogueResBond.<StarMapIter>d__82(-2);
			<StarMapIter>d__.<>3__<>4__this = this;
			return <StarMapIter>d__;
		}

		// Token: 0x0600C6FA RID: 50938 RVA: 0x00304EAC File Offset: 0x003030AC
		public IntArray? GetBattleEffect(int key)
		{
			this.EnsureBattleEffectCacheIfNeeded();
			IntArray value;
			if (!this.BattleEffectCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new IntArray?(value);
		}

		// Token: 0x0600C6FB RID: 50939 RVA: 0x00304EE0 File Offset: 0x003030E0
		public int? GetExploreEffect(int key)
		{
			this.EnsureExploreEffectCacheIfNeeded();
			int value;
			if (!this.ExploreEffectCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x0600C6FC RID: 50940 RVA: 0x00304F14 File Offset: 0x00303114
		public int? GetLinkEffect(int key)
		{
			this.EnsureLinkEffectCacheIfNeeded();
			int value;
			if (!this.LinkEffectCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x0600C6FD RID: 50941 RVA: 0x00304F48 File Offset: 0x00303148
		[NullableContext(2)]
		public string GetLinkEffectDesc(int key)
		{
			this.EnsureLinkEffectDescCacheIfNeeded();
			string result;
			if (!this.LinkEffectDescCache.TryGetValue(key, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x0600C6FE RID: 50942 RVA: 0x00304F70 File Offset: 0x00303170
		[NullableContext(2)]
		public string GetLinkEffectDescParam(int key)
		{
			this.EnsureLinkEffectDescParamCacheIfNeeded();
			string result;
			if (!this.LinkEffectDescParamCache.TryGetValue(key, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x0600C6FF RID: 50943 RVA: 0x00304F98 File Offset: 0x00303198
		public int? GetStarMap(int key)
		{
			this.EnsureStarMapCacheIfNeeded();
			int value;
			if (!this.StarMapCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x0600C700 RID: 50944 RVA: 0x00304FCC File Offset: 0x003031CC
		private void EnsureBattleEffectCacheIfNeeded()
		{
			if (this.BattleEffectCache != null)
			{
				return;
			}
			this.BattleEffectCache = this.BattleEffectIter().ToFrozenDictionary((DicIntIntArray kvp) => kvp.Key, (DicIntIntArray kvp) => kvp.Value.Value, null);
		}

		// Token: 0x0600C701 RID: 50945 RVA: 0x00305034 File Offset: 0x00303234
		private void EnsureExploreEffectCacheIfNeeded()
		{
			if (this.ExploreEffectCache != null)
			{
				return;
			}
			this.ExploreEffectCache = this.ExploreEffectIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600C702 RID: 50946 RVA: 0x0030509C File Offset: 0x0030329C
		private void EnsureLinkEffectCacheIfNeeded()
		{
			if (this.LinkEffectCache != null)
			{
				return;
			}
			this.LinkEffectCache = this.LinkEffectIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600C703 RID: 50947 RVA: 0x00305104 File Offset: 0x00303304
		private void EnsureLinkEffectDescCacheIfNeeded()
		{
			if (this.LinkEffectDescCache != null)
			{
				return;
			}
			this.LinkEffectDescCache = this.LinkEffectDescIter().ToFrozenDictionary((DicIntString kvp) => kvp.Key, (DicIntString kvp) => kvp.Value, null);
		}

		// Token: 0x0600C704 RID: 50948 RVA: 0x0030516C File Offset: 0x0030336C
		private void EnsureLinkEffectDescParamCacheIfNeeded()
		{
			if (this.LinkEffectDescParamCache != null)
			{
				return;
			}
			this.LinkEffectDescParamCache = this.LinkEffectDescParamIter().ToFrozenDictionary((DicIntString kvp) => kvp.Key, (DicIntString kvp) => kvp.Value, null);
		}

		// Token: 0x0600C705 RID: 50949 RVA: 0x003051D4 File Offset: 0x003033D4
		private void EnsureStarMapCacheIfNeeded()
		{
			if (this.StarMapCache != null)
			{
				return;
			}
			this.StarMapCache = this.StarMapIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600C706 RID: 50950 RVA: 0x0030523A File Offset: 0x0030343A
		public FrozenDictionary<int, IntArray> GetBattleEffectFrozenDict()
		{
			this.EnsureBattleEffectCacheIfNeeded();
			return this.BattleEffectCache;
		}

		// Token: 0x0600C707 RID: 50951 RVA: 0x00305248 File Offset: 0x00303448
		public FrozenDictionary<int, int> GetExploreEffectFrozenDict()
		{
			this.EnsureExploreEffectCacheIfNeeded();
			return this.ExploreEffectCache;
		}

		// Token: 0x0600C708 RID: 50952 RVA: 0x00305256 File Offset: 0x00303456
		public FrozenDictionary<int, int> GetLinkEffectFrozenDict()
		{
			this.EnsureLinkEffectCacheIfNeeded();
			return this.LinkEffectCache;
		}

		// Token: 0x0600C709 RID: 50953 RVA: 0x00305264 File Offset: 0x00303464
		public FrozenDictionary<int, string> GetLinkEffectDescFrozenDict()
		{
			this.EnsureLinkEffectDescCacheIfNeeded();
			return this.LinkEffectDescCache;
		}

		// Token: 0x0600C70A RID: 50954 RVA: 0x00305272 File Offset: 0x00303472
		public FrozenDictionary<int, string> GetLinkEffectDescParamFrozenDict()
		{
			this.EnsureLinkEffectDescParamCacheIfNeeded();
			return this.LinkEffectDescParamCache;
		}

		// Token: 0x0600C70B RID: 50955 RVA: 0x00305280 File Offset: 0x00303480
		public FrozenDictionary<int, int> GetStarMapFrozenDict()
		{
			this.EnsureStarMapCacheIfNeeded();
			return this.StarMapCache;
		}

		// Token: 0x040056B7 RID: 22199
		private Table __p;

		// Token: 0x040056B8 RID: 22200
		[Nullable(2)]
		private FrozenDictionary<int, IntArray> BattleEffectCache;

		// Token: 0x040056B9 RID: 22201
		[Nullable(2)]
		private FrozenDictionary<int, int> ExploreEffectCache;

		// Token: 0x040056BA RID: 22202
		[Nullable(2)]
		private FrozenDictionary<int, int> LinkEffectCache;

		// Token: 0x040056BB RID: 22203
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private FrozenDictionary<int, string> LinkEffectDescCache;

		// Token: 0x040056BC RID: 22204
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private FrozenDictionary<int, string> LinkEffectDescParamCache;

		// Token: 0x040056BD RID: 22205
		[Nullable(2)]
		private FrozenDictionary<int, int> StarMapCache;
	}
}
