using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FEE RID: 4078
	public struct RogueResBond : IFlatbufferObject
	{
		// Token: 0x17002FA6 RID: 12198
		// (get) Token: 0x0600C071 RID: 49265 RVA: 0x002E8068 File Offset: 0x002E6268
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C072 RID: 49266 RVA: 0x002E8075 File Offset: 0x002E6275
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C073 RID: 49267 RVA: 0x002E807C File Offset: 0x002E627C
		public static RogueResBond GetRootAsRogueResBond(ByteBuffer _bb)
		{
			return RogueResBond.GetRootAsRogueResBond(_bb, default(RogueResBond));
		}

		// Token: 0x0600C074 RID: 49268 RVA: 0x002E8098 File Offset: 0x002E6298
		public static RogueResBond GetRootAsRogueResBond(ByteBuffer _bb, RogueResBond obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C075 RID: 49269 RVA: 0x002E80B5 File Offset: 0x002E62B5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C076 RID: 49270 RVA: 0x002E80C4 File Offset: 0x002E62C4
		public RogueResBond __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002FA7 RID: 12199
		// (get) Token: 0x0600C077 RID: 49271 RVA: 0x002E80D4 File Offset: 0x002E62D4
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

		// Token: 0x17002FA8 RID: 12200
		// (get) Token: 0x0600C078 RID: 49272 RVA: 0x002E8110 File Offset: 0x002E6310
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

		// Token: 0x17002FA9 RID: 12201
		// (get) Token: 0x0600C079 RID: 49273 RVA: 0x002E814C File Offset: 0x002E634C
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

		// Token: 0x17002FAA RID: 12202
		// (get) Token: 0x0600C07A RID: 49274 RVA: 0x002E8188 File Offset: 0x002E6388
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

		// Token: 0x0600C07B RID: 49275 RVA: 0x002E81C8 File Offset: 0x002E63C8
		public DicIntInt? StarMap(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17002FAB RID: 12203
		// (get) Token: 0x0600C07C RID: 49276 RVA: 0x002E822C File Offset: 0x002E642C
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

		// Token: 0x0600C07D RID: 49277 RVA: 0x002E8258 File Offset: 0x002E6458
		public DicIntIntArray? BattleEffect(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new DicIntIntArray?(default(DicIntIntArray).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17002FAC RID: 12204
		// (get) Token: 0x0600C07E RID: 49278 RVA: 0x002E82BC File Offset: 0x002E64BC
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

		// Token: 0x0600C07F RID: 49279 RVA: 0x002E82E8 File Offset: 0x002E64E8
		public DicIntInt? ExploreEffect(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17002FAD RID: 12205
		// (get) Token: 0x0600C080 RID: 49280 RVA: 0x002E834C File Offset: 0x002E654C
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

		// Token: 0x0600C081 RID: 49281 RVA: 0x002E8378 File Offset: 0x002E6578
		public int LinkRule(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002FAE RID: 12206
		// (get) Token: 0x0600C082 RID: 49282 RVA: 0x002E83B8 File Offset: 0x002E65B8
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

		// Token: 0x0600C083 RID: 49283 RVA: 0x002E83E4 File Offset: 0x002E65E4
		public Span<int> GetLinkRuleBytes()
		{
			return this.__p.__vector_as_span<int>(18, 4);
		}

		// Token: 0x0600C084 RID: 49284 RVA: 0x002E83F4 File Offset: 0x002E65F4
		public int[] GetLinkRuleArray()
		{
			return this.__p.__vector_as_array<int>(18) ?? Array.Empty<int>();
		}

		// Token: 0x0600C085 RID: 49285 RVA: 0x002E840C File Offset: 0x002E660C
		public DicIntInt? LinkEffect(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17002FAF RID: 12207
		// (get) Token: 0x0600C086 RID: 49286 RVA: 0x002E8470 File Offset: 0x002E6670
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

		// Token: 0x17002FB0 RID: 12208
		// (get) Token: 0x0600C087 RID: 49287 RVA: 0x002E849C File Offset: 0x002E669C
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

		// Token: 0x17002FB1 RID: 12209
		// (get) Token: 0x0600C088 RID: 49288 RVA: 0x002E84DC File Offset: 0x002E66DC
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

		// Token: 0x0600C089 RID: 49289 RVA: 0x002E8514 File Offset: 0x002E6714
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x0600C08A RID: 49290 RVA: 0x002E8524 File Offset: 0x002E6724
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x17002FB2 RID: 12210
		// (get) Token: 0x0600C08B RID: 49291 RVA: 0x002E853C File Offset: 0x002E673C
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

		// Token: 0x0600C08C RID: 49292 RVA: 0x002E8574 File Offset: 0x002E6774
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x0600C08D RID: 49293 RVA: 0x002E8584 File Offset: 0x002E6784
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x0600C08E RID: 49294 RVA: 0x002E859C File Offset: 0x002E679C
		public string FightEffectDesc(int j)
		{
			int num = this.__p.__offset(28);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002FB3 RID: 12211
		// (get) Token: 0x0600C08F RID: 49295 RVA: 0x002E85D8 File Offset: 0x002E67D8
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

		// Token: 0x0600C090 RID: 49296 RVA: 0x002E8604 File Offset: 0x002E6804
		public string FightEffectDescParam(int j)
		{
			int num = this.__p.__offset(30);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002FB4 RID: 12212
		// (get) Token: 0x0600C091 RID: 49297 RVA: 0x002E8640 File Offset: 0x002E6840
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

		// Token: 0x0600C092 RID: 49298 RVA: 0x002E866C File Offset: 0x002E686C
		public string ExploreEffectDesc(int j)
		{
			int num = this.__p.__offset(32);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002FB5 RID: 12213
		// (get) Token: 0x0600C093 RID: 49299 RVA: 0x002E86A8 File Offset: 0x002E68A8
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

		// Token: 0x0600C094 RID: 49300 RVA: 0x002E86D4 File Offset: 0x002E68D4
		public string ExploreEffectDescParam(int j)
		{
			int num = this.__p.__offset(34);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002FB6 RID: 12214
		// (get) Token: 0x0600C095 RID: 49301 RVA: 0x002E8710 File Offset: 0x002E6910
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

		// Token: 0x0600C096 RID: 49302 RVA: 0x002E873C File Offset: 0x002E693C
		public DicIntString? LinkEffectDesc(int j)
		{
			int num = this.__p.__offset(36);
			if (num == 0)
			{
				return null;
			}
			return new DicIntString?(default(DicIntString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17002FB7 RID: 12215
		// (get) Token: 0x0600C097 RID: 49303 RVA: 0x002E87A0 File Offset: 0x002E69A0
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

		// Token: 0x0600C098 RID: 49304 RVA: 0x002E87CC File Offset: 0x002E69CC
		public DicIntString? LinkEffectDescParam(int j)
		{
			int num = this.__p.__offset(38);
			if (num == 0)
			{
				return null;
			}
			return new DicIntString?(default(DicIntString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17002FB8 RID: 12216
		// (get) Token: 0x0600C099 RID: 49305 RVA: 0x002E8830 File Offset: 0x002E6A30
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

		// Token: 0x0600C09A RID: 49306 RVA: 0x002E885C File Offset: 0x002E6A5C
		[NullableContext(1)]
		[Obsolete("已废弃，请使用BattleEffectFrozenDict()缓存字典，遍历请使用BattleEffectIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, IntArray> BattleEffect()
		{
			return this.BattleEffectIter().ToDictionary((DicIntIntArray element) => element.Key, (DicIntIntArray element) => element.Value.Value);
		}

		// Token: 0x0600C09B RID: 49307 RVA: 0x002E88B2 File Offset: 0x002E6AB2
		[NullableContext(1)]
		public readonly IEnumerable<DicIntIntArray> BattleEffectIter()
		{
			RogueResBond.<BattleEffectIter>d__62 <BattleEffectIter>d__ = new RogueResBond.<BattleEffectIter>d__62(-2);
			<BattleEffectIter>d__.<>3__<>4__this = this;
			return <BattleEffectIter>d__;
		}

		// Token: 0x0600C09C RID: 49308 RVA: 0x002E88C8 File Offset: 0x002E6AC8
		[NullableContext(1)]
		[Obsolete("已废弃，请使用ExploreEffectFrozenDict()缓存字典，遍历请使用ExploreEffectIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> ExploreEffect()
		{
			return this.ExploreEffectIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600C09D RID: 49309 RVA: 0x002E891E File Offset: 0x002E6B1E
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> ExploreEffectIter()
		{
			RogueResBond.<ExploreEffectIter>d__64 <ExploreEffectIter>d__ = new RogueResBond.<ExploreEffectIter>d__64(-2);
			<ExploreEffectIter>d__.<>3__<>4__this = this;
			return <ExploreEffectIter>d__;
		}

		// Token: 0x0600C09E RID: 49310 RVA: 0x002E8933 File Offset: 0x002E6B33
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ExploreEffectDescIter()或GetExploreEffectDescBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] ExploreEffectDesc()
		{
			return this.ExploreEffectDescIter().ToArray<string>();
		}

		// Token: 0x0600C09F RID: 49311 RVA: 0x002E8940 File Offset: 0x002E6B40
		[NullableContext(1)]
		public readonly IEnumerable<string> ExploreEffectDescIter()
		{
			RogueResBond.<ExploreEffectDescIter>d__66 <ExploreEffectDescIter>d__ = new RogueResBond.<ExploreEffectDescIter>d__66(-2);
			<ExploreEffectDescIter>d__.<>3__<>4__this = this;
			return <ExploreEffectDescIter>d__;
		}

		// Token: 0x0600C0A0 RID: 49312 RVA: 0x002E8955 File Offset: 0x002E6B55
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ExploreEffectDescParamIter()或GetExploreEffectDescParamBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] ExploreEffectDescParam()
		{
			return this.ExploreEffectDescParamIter().ToArray<string>();
		}

		// Token: 0x0600C0A1 RID: 49313 RVA: 0x002E8962 File Offset: 0x002E6B62
		[NullableContext(1)]
		public readonly IEnumerable<string> ExploreEffectDescParamIter()
		{
			RogueResBond.<ExploreEffectDescParamIter>d__68 <ExploreEffectDescParamIter>d__ = new RogueResBond.<ExploreEffectDescParamIter>d__68(-2);
			<ExploreEffectDescParamIter>d__.<>3__<>4__this = this;
			return <ExploreEffectDescParamIter>d__;
		}

		// Token: 0x0600C0A2 RID: 49314 RVA: 0x002E8977 File Offset: 0x002E6B77
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用FightEffectDescIter()或GetFightEffectDescBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] FightEffectDesc()
		{
			return this.FightEffectDescIter().ToArray<string>();
		}

		// Token: 0x0600C0A3 RID: 49315 RVA: 0x002E8984 File Offset: 0x002E6B84
		[NullableContext(1)]
		public readonly IEnumerable<string> FightEffectDescIter()
		{
			RogueResBond.<FightEffectDescIter>d__70 <FightEffectDescIter>d__ = new RogueResBond.<FightEffectDescIter>d__70(-2);
			<FightEffectDescIter>d__.<>3__<>4__this = this;
			return <FightEffectDescIter>d__;
		}

		// Token: 0x0600C0A4 RID: 49316 RVA: 0x002E8999 File Offset: 0x002E6B99
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用FightEffectDescParamIter()或GetFightEffectDescParamBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] FightEffectDescParam()
		{
			return this.FightEffectDescParamIter().ToArray<string>();
		}

		// Token: 0x0600C0A5 RID: 49317 RVA: 0x002E89A6 File Offset: 0x002E6BA6
		[NullableContext(1)]
		public readonly IEnumerable<string> FightEffectDescParamIter()
		{
			RogueResBond.<FightEffectDescParamIter>d__72 <FightEffectDescParamIter>d__ = new RogueResBond.<FightEffectDescParamIter>d__72(-2);
			<FightEffectDescParamIter>d__.<>3__<>4__this = this;
			return <FightEffectDescParamIter>d__;
		}

		// Token: 0x0600C0A6 RID: 49318 RVA: 0x002E89BC File Offset: 0x002E6BBC
		[NullableContext(1)]
		[Obsolete("已废弃，请使用LinkEffectFrozenDict()缓存字典，遍历请使用LinkEffectIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> LinkEffect()
		{
			return this.LinkEffectIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600C0A7 RID: 49319 RVA: 0x002E8A12 File Offset: 0x002E6C12
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> LinkEffectIter()
		{
			RogueResBond.<LinkEffectIter>d__74 <LinkEffectIter>d__ = new RogueResBond.<LinkEffectIter>d__74(-2);
			<LinkEffectIter>d__.<>3__<>4__this = this;
			return <LinkEffectIter>d__;
		}

		// Token: 0x0600C0A8 RID: 49320 RVA: 0x002E8A28 File Offset: 0x002E6C28
		[NullableContext(1)]
		[Obsolete("已废弃，请使用LinkEffectDescFrozenDict()缓存字典，遍历请使用LinkEffectDescIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, string> LinkEffectDesc()
		{
			return this.LinkEffectDescIter().ToDictionary((DicIntString element) => element.Key, (DicIntString element) => element.Value);
		}

		// Token: 0x0600C0A9 RID: 49321 RVA: 0x002E8A7E File Offset: 0x002E6C7E
		[NullableContext(1)]
		public readonly IEnumerable<DicIntString> LinkEffectDescIter()
		{
			RogueResBond.<LinkEffectDescIter>d__76 <LinkEffectDescIter>d__ = new RogueResBond.<LinkEffectDescIter>d__76(-2);
			<LinkEffectDescIter>d__.<>3__<>4__this = this;
			return <LinkEffectDescIter>d__;
		}

		// Token: 0x0600C0AA RID: 49322 RVA: 0x002E8A94 File Offset: 0x002E6C94
		[NullableContext(1)]
		[Obsolete("已废弃，请使用LinkEffectDescParamFrozenDict()缓存字典，遍历请使用LinkEffectDescParamIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, string> LinkEffectDescParam()
		{
			return this.LinkEffectDescParamIter().ToDictionary((DicIntString element) => element.Key, (DicIntString element) => element.Value);
		}

		// Token: 0x0600C0AB RID: 49323 RVA: 0x002E8AEA File Offset: 0x002E6CEA
		[NullableContext(1)]
		public readonly IEnumerable<DicIntString> LinkEffectDescParamIter()
		{
			RogueResBond.<LinkEffectDescParamIter>d__78 <LinkEffectDescParamIter>d__ = new RogueResBond.<LinkEffectDescParamIter>d__78(-2);
			<LinkEffectDescParamIter>d__.<>3__<>4__this = this;
			return <LinkEffectDescParamIter>d__;
		}

		// Token: 0x0600C0AC RID: 49324 RVA: 0x002E8B00 File Offset: 0x002E6D00
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用LinkRuleIter()或GetLinkRuleBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] LinkRule()
		{
			RogueResBond rogueResBond = this;
			return rogueResBond.GetLinkRuleArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600C0AD RID: 49325 RVA: 0x002E8B24 File Offset: 0x002E6D24
		[NullableContext(1)]
		public readonly IEnumerable<int> LinkRuleIter()
		{
			RogueResBond.<LinkRuleIter>d__80 <LinkRuleIter>d__ = new RogueResBond.<LinkRuleIter>d__80(-2);
			<LinkRuleIter>d__.<>3__<>4__this = this;
			return <LinkRuleIter>d__;
		}

		// Token: 0x0600C0AE RID: 49326 RVA: 0x002E8B3C File Offset: 0x002E6D3C
		[NullableContext(1)]
		[Obsolete("已废弃，请使用StarMapFrozenDict()缓存字典，遍历请使用StarMapIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> StarMap()
		{
			return this.StarMapIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600C0AF RID: 49327 RVA: 0x002E8B92 File Offset: 0x002E6D92
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> StarMapIter()
		{
			RogueResBond.<StarMapIter>d__82 <StarMapIter>d__ = new RogueResBond.<StarMapIter>d__82(-2);
			<StarMapIter>d__.<>3__<>4__this = this;
			return <StarMapIter>d__;
		}

		// Token: 0x0600C0B0 RID: 49328 RVA: 0x002E8BA8 File Offset: 0x002E6DA8
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

		// Token: 0x0600C0B1 RID: 49329 RVA: 0x002E8BDC File Offset: 0x002E6DDC
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

		// Token: 0x0600C0B2 RID: 49330 RVA: 0x002E8C10 File Offset: 0x002E6E10
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

		// Token: 0x0600C0B3 RID: 49331 RVA: 0x002E8C44 File Offset: 0x002E6E44
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

		// Token: 0x0600C0B4 RID: 49332 RVA: 0x002E8C6C File Offset: 0x002E6E6C
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

		// Token: 0x0600C0B5 RID: 49333 RVA: 0x002E8C94 File Offset: 0x002E6E94
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

		// Token: 0x0600C0B6 RID: 49334 RVA: 0x002E8CC8 File Offset: 0x002E6EC8
		private void EnsureBattleEffectCacheIfNeeded()
		{
			if (this.BattleEffectCache != null)
			{
				return;
			}
			this.BattleEffectCache = this.BattleEffectIter().ToFrozenDictionary((DicIntIntArray kvp) => kvp.Key, (DicIntIntArray kvp) => kvp.Value.Value, null);
		}

		// Token: 0x0600C0B7 RID: 49335 RVA: 0x002E8D30 File Offset: 0x002E6F30
		private void EnsureExploreEffectCacheIfNeeded()
		{
			if (this.ExploreEffectCache != null)
			{
				return;
			}
			this.ExploreEffectCache = this.ExploreEffectIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600C0B8 RID: 49336 RVA: 0x002E8D98 File Offset: 0x002E6F98
		private void EnsureLinkEffectCacheIfNeeded()
		{
			if (this.LinkEffectCache != null)
			{
				return;
			}
			this.LinkEffectCache = this.LinkEffectIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600C0B9 RID: 49337 RVA: 0x002E8E00 File Offset: 0x002E7000
		private void EnsureLinkEffectDescCacheIfNeeded()
		{
			if (this.LinkEffectDescCache != null)
			{
				return;
			}
			this.LinkEffectDescCache = this.LinkEffectDescIter().ToFrozenDictionary((DicIntString kvp) => kvp.Key, (DicIntString kvp) => kvp.Value, null);
		}

		// Token: 0x0600C0BA RID: 49338 RVA: 0x002E8E68 File Offset: 0x002E7068
		private void EnsureLinkEffectDescParamCacheIfNeeded()
		{
			if (this.LinkEffectDescParamCache != null)
			{
				return;
			}
			this.LinkEffectDescParamCache = this.LinkEffectDescParamIter().ToFrozenDictionary((DicIntString kvp) => kvp.Key, (DicIntString kvp) => kvp.Value, null);
		}

		// Token: 0x0600C0BB RID: 49339 RVA: 0x002E8ED0 File Offset: 0x002E70D0
		private void EnsureStarMapCacheIfNeeded()
		{
			if (this.StarMapCache != null)
			{
				return;
			}
			this.StarMapCache = this.StarMapIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600C0BC RID: 49340 RVA: 0x002E8F36 File Offset: 0x002E7136
		[NullableContext(2)]
		public FrozenDictionary<int, IntArray> GetBattleEffectFrozenDict(int key)
		{
			this.EnsureBattleEffectCacheIfNeeded();
			return this.BattleEffectCache;
		}

		// Token: 0x0600C0BD RID: 49341 RVA: 0x002E8F44 File Offset: 0x002E7144
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetExploreEffectFrozenDict(int key)
		{
			this.EnsureExploreEffectCacheIfNeeded();
			return this.ExploreEffectCache;
		}

		// Token: 0x0600C0BE RID: 49342 RVA: 0x002E8F52 File Offset: 0x002E7152
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetLinkEffectFrozenDict(int key)
		{
			this.EnsureLinkEffectCacheIfNeeded();
			return this.LinkEffectCache;
		}

		// Token: 0x0600C0BF RID: 49343 RVA: 0x002E8F60 File Offset: 0x002E7160
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public FrozenDictionary<int, string> GetLinkEffectDescFrozenDict(int key)
		{
			this.EnsureLinkEffectDescCacheIfNeeded();
			return this.LinkEffectDescCache;
		}

		// Token: 0x0600C0C0 RID: 49344 RVA: 0x002E8F6E File Offset: 0x002E716E
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public FrozenDictionary<int, string> GetLinkEffectDescParamFrozenDict(int key)
		{
			this.EnsureLinkEffectDescParamCacheIfNeeded();
			return this.LinkEffectDescParamCache;
		}

		// Token: 0x0600C0C1 RID: 49345 RVA: 0x002E8F7C File Offset: 0x002E717C
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetStarMapFrozenDict(int key)
		{
			this.EnsureStarMapCacheIfNeeded();
			return this.StarMapCache;
		}

		// Token: 0x040050CF RID: 20687
		private Table __p;

		// Token: 0x040050D0 RID: 20688
		[Nullable(2)]
		private FrozenDictionary<int, IntArray> BattleEffectCache;

		// Token: 0x040050D1 RID: 20689
		[Nullable(2)]
		private FrozenDictionary<int, int> ExploreEffectCache;

		// Token: 0x040050D2 RID: 20690
		[Nullable(2)]
		private FrozenDictionary<int, int> LinkEffectCache;

		// Token: 0x040050D3 RID: 20691
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private FrozenDictionary<int, string> LinkEffectDescCache;

		// Token: 0x040050D4 RID: 20692
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private FrozenDictionary<int, string> LinkEffectDescParamCache;

		// Token: 0x040050D5 RID: 20693
		[Nullable(2)]
		private FrozenDictionary<int, int> StarMapCache;
	}
}
