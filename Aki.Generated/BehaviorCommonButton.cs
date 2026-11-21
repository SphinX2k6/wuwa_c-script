using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C11 RID: 3089
	public struct BehaviorCommonButton : IFlatbufferObject
	{
		// Token: 0x17000556 RID: 1366
		// (get) Token: 0x060052C6 RID: 21190 RVA: 0x002033D5 File Offset: 0x002015D5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060052C7 RID: 21191 RVA: 0x002033E2 File Offset: 0x002015E2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060052C8 RID: 21192 RVA: 0x002033EC File Offset: 0x002015EC
		public static BehaviorCommonButton GetRootAsBehaviorCommonButton(ByteBuffer _bb)
		{
			return BehaviorCommonButton.GetRootAsBehaviorCommonButton(_bb, default(BehaviorCommonButton));
		}

		// Token: 0x060052C9 RID: 21193 RVA: 0x00203408 File Offset: 0x00201608
		public static BehaviorCommonButton GetRootAsBehaviorCommonButton(ByteBuffer _bb, BehaviorCommonButton obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060052CA RID: 21194 RVA: 0x00203425 File Offset: 0x00201625
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060052CB RID: 21195 RVA: 0x00203434 File Offset: 0x00201634
		public BehaviorCommonButton __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000557 RID: 1367
		// (get) Token: 0x060052CC RID: 21196 RVA: 0x00203444 File Offset: 0x00201644
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

		// Token: 0x17000558 RID: 1368
		// (get) Token: 0x060052CD RID: 21197 RVA: 0x00203480 File Offset: 0x00201680
		public string Name
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060052CE RID: 21198 RVA: 0x002034B7 File Offset: 0x002016B7
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060052CF RID: 21199 RVA: 0x002034C6 File Offset: 0x002016C6
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17000559 RID: 1369
		// (get) Token: 0x060052D0 RID: 21200 RVA: 0x002034E0 File Offset: 0x002016E0
		public int ButtonType
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

		// Token: 0x1700055A RID: 1370
		// (get) Token: 0x060052D1 RID: 21201 RVA: 0x0020351C File Offset: 0x0020171C
		public int ActionType
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

		// Token: 0x1700055B RID: 1371
		// (get) Token: 0x060052D2 RID: 21202 RVA: 0x0020355C File Offset: 0x0020175C
		public int SkillId
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

		// Token: 0x060052D3 RID: 21203 RVA: 0x0020359C File Offset: 0x0020179C
		public DicIntInt? SkillIdTagMap(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700055C RID: 1372
		// (get) Token: 0x060052D4 RID: 21204 RVA: 0x00203600 File Offset: 0x00201800
		public int SkillIdTagMapLength
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

		// Token: 0x060052D5 RID: 21205 RVA: 0x0020362C File Offset: 0x0020182C
		public string SkillIcons(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700055D RID: 1373
		// (get) Token: 0x060052D6 RID: 21206 RVA: 0x00203668 File Offset: 0x00201868
		public int SkillIconsLength
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

		// Token: 0x060052D7 RID: 21207 RVA: 0x00203694 File Offset: 0x00201894
		public int SkillIconTags(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700055E RID: 1374
		// (get) Token: 0x060052D8 RID: 21208 RVA: 0x002036D4 File Offset: 0x002018D4
		public int SkillIconTagsLength
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

		// Token: 0x060052D9 RID: 21209 RVA: 0x00203700 File Offset: 0x00201900
		public Span<int> GetSkillIconTagsBytes()
		{
			return this.__p.__vector_as_span<int>(18, 4);
		}

		// Token: 0x060052DA RID: 21210 RVA: 0x00203710 File Offset: 0x00201910
		public int[] GetSkillIconTagsArray()
		{
			return this.__p.__vector_as_array<int>(18) ?? Array.Empty<int>();
		}

		// Token: 0x060052DB RID: 21211 RVA: 0x00203728 File Offset: 0x00201928
		public int DisableTags(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700055F RID: 1375
		// (get) Token: 0x060052DC RID: 21212 RVA: 0x00203768 File Offset: 0x00201968
		public int DisableTagsLength
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

		// Token: 0x060052DD RID: 21213 RVA: 0x00203794 File Offset: 0x00201994
		public Span<int> GetDisableTagsBytes()
		{
			return this.__p.__vector_as_span<int>(20, 4);
		}

		// Token: 0x060052DE RID: 21214 RVA: 0x002037A4 File Offset: 0x002019A4
		public int[] GetDisableTagsArray()
		{
			return this.__p.__vector_as_array<int>(20) ?? Array.Empty<int>();
		}

		// Token: 0x060052DF RID: 21215 RVA: 0x002037BC File Offset: 0x002019BC
		public DicIntIntArray? DisableSkillIdTags(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return null;
			}
			return new DicIntIntArray?(default(DicIntIntArray).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17000560 RID: 1376
		// (get) Token: 0x060052E0 RID: 21216 RVA: 0x00203820 File Offset: 0x00201A20
		public int DisableSkillIdTagsLength
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

		// Token: 0x060052E1 RID: 21217 RVA: 0x0020384C File Offset: 0x00201A4C
		public int VisibleTags(int j)
		{
			int num = this.__p.__offset(24);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000561 RID: 1377
		// (get) Token: 0x060052E2 RID: 21218 RVA: 0x0020388C File Offset: 0x00201A8C
		public int VisibleTagsLength
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060052E3 RID: 21219 RVA: 0x002038B8 File Offset: 0x00201AB8
		public Span<int> GetVisibleTagsBytes()
		{
			return this.__p.__vector_as_span<int>(24, 4);
		}

		// Token: 0x060052E4 RID: 21220 RVA: 0x002038C8 File Offset: 0x00201AC8
		public int[] GetVisibleTagsArray()
		{
			return this.__p.__vector_as_array<int>(24) ?? Array.Empty<int>();
		}

		// Token: 0x060052E5 RID: 21221 RVA: 0x002038E0 File Offset: 0x00201AE0
		public int HiddenTags(int j)
		{
			int num = this.__p.__offset(26);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000562 RID: 1378
		// (get) Token: 0x060052E6 RID: 21222 RVA: 0x00203920 File Offset: 0x00201B20
		public int HiddenTagsLength
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060052E7 RID: 21223 RVA: 0x0020394C File Offset: 0x00201B4C
		public Span<int> GetHiddenTagsBytes()
		{
			return this.__p.__vector_as_span<int>(26, 4);
		}

		// Token: 0x060052E8 RID: 21224 RVA: 0x0020395C File Offset: 0x00201B5C
		public int[] GetHiddenTagsArray()
		{
			return this.__p.__vector_as_array<int>(26) ?? Array.Empty<int>();
		}

		// Token: 0x060052E9 RID: 21225 RVA: 0x00203974 File Offset: 0x00201B74
		public DicIntInt? DynamicEffectTagMap(int j)
		{
			int num = this.__p.__offset(28);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17000563 RID: 1379
		// (get) Token: 0x060052EA RID: 21226 RVA: 0x002039D8 File Offset: 0x00201BD8
		public int DynamicEffectTagMapLength
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

		// Token: 0x060052EB RID: 21227 RVA: 0x00203A04 File Offset: 0x00201C04
		[NullableContext(1)]
		public Dictionary<int, IntArray> DisableSkillIdTags()
		{
			return this.DisableSkillIdTagsIter().ToDictionary((DicIntIntArray element) => element.Key, (DicIntIntArray element) => element.Value.Value);
		}

		// Token: 0x060052EC RID: 21228 RVA: 0x00203A5A File Offset: 0x00201C5A
		[NullableContext(1)]
		public IEnumerable<DicIntIntArray> DisableSkillIdTagsIter()
		{
			BehaviorCommonButton.<DisableSkillIdTagsIter>d__53 <DisableSkillIdTagsIter>d__ = new BehaviorCommonButton.<DisableSkillIdTagsIter>d__53(-2);
			<DisableSkillIdTagsIter>d__.<>3__<>4__this = this;
			return <DisableSkillIdTagsIter>d__;
		}

		// Token: 0x060052ED RID: 21229 RVA: 0x00203A6F File Offset: 0x00201C6F
		[NullableContext(1)]
		public int[] DisableTags()
		{
			return this.GetDisableTagsArray();
		}

		// Token: 0x060052EE RID: 21230 RVA: 0x00203A77 File Offset: 0x00201C77
		[NullableContext(1)]
		public IEnumerable<int> DisableTagsIter()
		{
			BehaviorCommonButton.<DisableTagsIter>d__55 <DisableTagsIter>d__ = new BehaviorCommonButton.<DisableTagsIter>d__55(-2);
			<DisableTagsIter>d__.<>3__<>4__this = this;
			return <DisableTagsIter>d__;
		}

		// Token: 0x060052EF RID: 21231 RVA: 0x00203A8C File Offset: 0x00201C8C
		[NullableContext(1)]
		public Dictionary<int, int> DynamicEffectTagMap()
		{
			return this.DynamicEffectTagMapIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x060052F0 RID: 21232 RVA: 0x00203AE2 File Offset: 0x00201CE2
		[NullableContext(1)]
		public IEnumerable<DicIntInt> DynamicEffectTagMapIter()
		{
			BehaviorCommonButton.<DynamicEffectTagMapIter>d__57 <DynamicEffectTagMapIter>d__ = new BehaviorCommonButton.<DynamicEffectTagMapIter>d__57(-2);
			<DynamicEffectTagMapIter>d__.<>3__<>4__this = this;
			return <DynamicEffectTagMapIter>d__;
		}

		// Token: 0x060052F1 RID: 21233 RVA: 0x00203AF7 File Offset: 0x00201CF7
		[NullableContext(1)]
		public int[] HiddenTags()
		{
			return this.GetHiddenTagsArray();
		}

		// Token: 0x060052F2 RID: 21234 RVA: 0x00203AFF File Offset: 0x00201CFF
		[NullableContext(1)]
		public IEnumerable<int> HiddenTagsIter()
		{
			BehaviorCommonButton.<HiddenTagsIter>d__59 <HiddenTagsIter>d__ = new BehaviorCommonButton.<HiddenTagsIter>d__59(-2);
			<HiddenTagsIter>d__.<>3__<>4__this = this;
			return <HiddenTagsIter>d__;
		}

		// Token: 0x060052F3 RID: 21235 RVA: 0x00203B14 File Offset: 0x00201D14
		[NullableContext(1)]
		public int[] SkillIconTags()
		{
			return this.GetSkillIconTagsArray();
		}

		// Token: 0x060052F4 RID: 21236 RVA: 0x00203B1C File Offset: 0x00201D1C
		[NullableContext(1)]
		public IEnumerable<int> SkillIconTagsIter()
		{
			BehaviorCommonButton.<SkillIconTagsIter>d__61 <SkillIconTagsIter>d__ = new BehaviorCommonButton.<SkillIconTagsIter>d__61(-2);
			<SkillIconTagsIter>d__.<>3__<>4__this = this;
			return <SkillIconTagsIter>d__;
		}

		// Token: 0x060052F5 RID: 21237 RVA: 0x00203B31 File Offset: 0x00201D31
		[NullableContext(1)]
		public string[] SkillIcons()
		{
			return this.SkillIconsIter().ToArray<string>();
		}

		// Token: 0x060052F6 RID: 21238 RVA: 0x00203B3E File Offset: 0x00201D3E
		[NullableContext(1)]
		public IEnumerable<string> SkillIconsIter()
		{
			BehaviorCommonButton.<SkillIconsIter>d__63 <SkillIconsIter>d__ = new BehaviorCommonButton.<SkillIconsIter>d__63(-2);
			<SkillIconsIter>d__.<>3__<>4__this = this;
			return <SkillIconsIter>d__;
		}

		// Token: 0x060052F7 RID: 21239 RVA: 0x00203B54 File Offset: 0x00201D54
		[NullableContext(1)]
		public Dictionary<int, int> SkillIdTagMap()
		{
			return this.SkillIdTagMapIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x060052F8 RID: 21240 RVA: 0x00203BAA File Offset: 0x00201DAA
		[NullableContext(1)]
		public IEnumerable<DicIntInt> SkillIdTagMapIter()
		{
			BehaviorCommonButton.<SkillIdTagMapIter>d__65 <SkillIdTagMapIter>d__ = new BehaviorCommonButton.<SkillIdTagMapIter>d__65(-2);
			<SkillIdTagMapIter>d__.<>3__<>4__this = this;
			return <SkillIdTagMapIter>d__;
		}

		// Token: 0x060052F9 RID: 21241 RVA: 0x00203BBF File Offset: 0x00201DBF
		[NullableContext(1)]
		public int[] VisibleTags()
		{
			return this.GetVisibleTagsArray();
		}

		// Token: 0x060052FA RID: 21242 RVA: 0x00203BC7 File Offset: 0x00201DC7
		[NullableContext(1)]
		public IEnumerable<int> VisibleTagsIter()
		{
			BehaviorCommonButton.<VisibleTagsIter>d__67 <VisibleTagsIter>d__ = new BehaviorCommonButton.<VisibleTagsIter>d__67(-2);
			<VisibleTagsIter>d__.<>3__<>4__this = this;
			return <VisibleTagsIter>d__;
		}

		// Token: 0x060052FB RID: 21243 RVA: 0x00203BDC File Offset: 0x00201DDC
		public IntArray? GetDisableSkillIdTags(int key)
		{
			this.EnsureDisableSkillIdTagsCacheIfNeeded();
			IntArray value;
			if (!this.DisableSkillIdTagsCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new IntArray?(value);
		}

		// Token: 0x060052FC RID: 21244 RVA: 0x00203C10 File Offset: 0x00201E10
		public int? GetDynamicEffectTagMap(int key)
		{
			this.EnsureDynamicEffectTagMapCacheIfNeeded();
			int value;
			if (!this.DynamicEffectTagMapCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x060052FD RID: 21245 RVA: 0x00203C44 File Offset: 0x00201E44
		public int? GetSkillIdTagMap(int key)
		{
			this.EnsureSkillIdTagMapCacheIfNeeded();
			int value;
			if (!this.SkillIdTagMapCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x060052FE RID: 21246 RVA: 0x00203C78 File Offset: 0x00201E78
		private void EnsureDisableSkillIdTagsCacheIfNeeded()
		{
			if (this.DisableSkillIdTagsCache != null)
			{
				return;
			}
			this.DisableSkillIdTagsCache = this.DisableSkillIdTagsIter().ToFrozenDictionary((DicIntIntArray kvp) => kvp.Key, (DicIntIntArray kvp) => kvp.Value.Value, null);
		}

		// Token: 0x060052FF RID: 21247 RVA: 0x00203CE0 File Offset: 0x00201EE0
		private void EnsureDynamicEffectTagMapCacheIfNeeded()
		{
			if (this.DynamicEffectTagMapCache != null)
			{
				return;
			}
			this.DynamicEffectTagMapCache = this.DynamicEffectTagMapIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x06005300 RID: 21248 RVA: 0x00203D48 File Offset: 0x00201F48
		private void EnsureSkillIdTagMapCacheIfNeeded()
		{
			if (this.SkillIdTagMapCache != null)
			{
				return;
			}
			this.SkillIdTagMapCache = this.SkillIdTagMapIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x06005301 RID: 21249 RVA: 0x00203DAE File Offset: 0x00201FAE
		[NullableContext(1)]
		public FrozenDictionary<int, IntArray> GetDisableSkillIdTagsFrozenDict()
		{
			this.EnsureDisableSkillIdTagsCacheIfNeeded();
			return this.DisableSkillIdTagsCache;
		}

		// Token: 0x06005302 RID: 21250 RVA: 0x00203DBC File Offset: 0x00201FBC
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetDynamicEffectTagMapFrozenDict()
		{
			this.EnsureDynamicEffectTagMapCacheIfNeeded();
			return this.DynamicEffectTagMapCache;
		}

		// Token: 0x06005303 RID: 21251 RVA: 0x00203DCA File Offset: 0x00201FCA
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetSkillIdTagMapFrozenDict()
		{
			this.EnsureSkillIdTagMapCacheIfNeeded();
			return this.SkillIdTagMapCache;
		}

		// Token: 0x04005109 RID: 20745
		private Table __p;

		// Token: 0x0400510A RID: 20746
		[Nullable(2)]
		private FrozenDictionary<int, IntArray> DisableSkillIdTagsCache;

		// Token: 0x0400510B RID: 20747
		[Nullable(2)]
		private FrozenDictionary<int, int> DynamicEffectTagMapCache;

		// Token: 0x0400510C RID: 20748
		[Nullable(2)]
		private FrozenDictionary<int, int> SkillIdTagMapCache;
	}
}
