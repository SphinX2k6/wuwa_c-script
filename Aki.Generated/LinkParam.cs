using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000EB5 RID: 3765
	[NullableContext(1)]
	[Nullable(0)]
	public struct LinkParam : IFlatbufferObject
	{
		// Token: 0x17001D7D RID: 7549
		// (get) Token: 0x060094C4 RID: 38084 RVA: 0x002972E7 File Offset: 0x002954E7
		[Nullable(0)]
		public ByteBuffer ByteBuffer
		{
			[NullableContext(0)]
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060094C5 RID: 38085 RVA: 0x002972F4 File Offset: 0x002954F4
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060094C6 RID: 38086 RVA: 0x002972FC File Offset: 0x002954FC
		[NullableContext(0)]
		public static LinkParam GetRootAsLinkParam(ByteBuffer _bb)
		{
			return LinkParam.GetRootAsLinkParam(_bb, default(LinkParam));
		}

		// Token: 0x060094C7 RID: 38087 RVA: 0x00297318 File Offset: 0x00295518
		[NullableContext(0)]
		public static LinkParam GetRootAsLinkParam(ByteBuffer _bb, LinkParam obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060094C8 RID: 38088 RVA: 0x00297335 File Offset: 0x00295535
		[NullableContext(0)]
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060094C9 RID: 38089 RVA: 0x00297344 File Offset: 0x00295544
		[NullableContext(0)]
		public LinkParam __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001D7E RID: 7550
		// (get) Token: 0x060094CA RID: 38090 RVA: 0x00297354 File Offset: 0x00295554
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

		// Token: 0x060094CB RID: 38091 RVA: 0x00297390 File Offset: 0x00295590
		public int InstSubTypeList(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001D7F RID: 7551
		// (get) Token: 0x060094CC RID: 38092 RVA: 0x002973D0 File Offset: 0x002955D0
		public int InstSubTypeListLength
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

		// Token: 0x060094CD RID: 38093 RVA: 0x002973FB File Offset: 0x002955FB
		[NullableContext(0)]
		public Span<int> GetInstSubTypeListBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x060094CE RID: 38094 RVA: 0x0029740A File Offset: 0x0029560A
		[NullableContext(0)]
		public int[] GetInstSubTypeListArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x060094CF RID: 38095 RVA: 0x00297424 File Offset: 0x00295624
		public int InstIdList(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001D80 RID: 7552
		// (get) Token: 0x060094D0 RID: 38096 RVA: 0x00297464 File Offset: 0x00295664
		public int InstIdListLength
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060094D1 RID: 38097 RVA: 0x0029748F File Offset: 0x0029568F
		[NullableContext(0)]
		public Span<int> GetInstIdListBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x060094D2 RID: 38098 RVA: 0x0029749E File Offset: 0x0029569E
		[NullableContext(0)]
		public int[] GetInstIdListArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x060094D3 RID: 38099 RVA: 0x002974B8 File Offset: 0x002956B8
		public DicIntInt? LinkBuffRoleMap(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17001D81 RID: 7553
		// (get) Token: 0x060094D4 RID: 38100 RVA: 0x0029751C File Offset: 0x0029571C
		public int LinkBuffRoleMapLength
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

		// Token: 0x060094D5 RID: 38101 RVA: 0x00297548 File Offset: 0x00295748
		public DicIntInt? ChangeGenderMap(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17001D82 RID: 7554
		// (get) Token: 0x060094D6 RID: 38102 RVA: 0x002975AC File Offset: 0x002957AC
		public int ChangeGenderMapLength
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

		// Token: 0x060094D7 RID: 38103 RVA: 0x002975D8 File Offset: 0x002957D8
		public DicIntInt? MorphModelIdMap(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17001D83 RID: 7555
		// (get) Token: 0x060094D8 RID: 38104 RVA: 0x0029763C File Offset: 0x0029583C
		public int MorphModelIdMapLength
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

		// Token: 0x060094D9 RID: 38105 RVA: 0x00297668 File Offset: 0x00295868
		public DicIntString? LinkEnergyButtonMap(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return new DicIntString?(default(DicIntString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17001D84 RID: 7556
		// (get) Token: 0x060094DA RID: 38106 RVA: 0x002976CC File Offset: 0x002958CC
		public int LinkEnergyButtonMapLength
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

		// Token: 0x060094DB RID: 38107 RVA: 0x002976F8 File Offset: 0x002958F8
		public Dictionary<int, int> ChangeGenderMap()
		{
			return this.ChangeGenderMapIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x060094DC RID: 38108 RVA: 0x0029774E File Offset: 0x0029594E
		public IEnumerable<DicIntInt> ChangeGenderMapIter()
		{
			LinkParam.<ChangeGenderMapIter>d__33 <ChangeGenderMapIter>d__ = new LinkParam.<ChangeGenderMapIter>d__33(-2);
			<ChangeGenderMapIter>d__.<>3__<>4__this = this;
			return <ChangeGenderMapIter>d__;
		}

		// Token: 0x060094DD RID: 38109 RVA: 0x00297763 File Offset: 0x00295963
		public int[] InstIdList()
		{
			return this.GetInstIdListArray();
		}

		// Token: 0x060094DE RID: 38110 RVA: 0x0029776B File Offset: 0x0029596B
		public IEnumerable<int> InstIdListIter()
		{
			LinkParam.<InstIdListIter>d__35 <InstIdListIter>d__ = new LinkParam.<InstIdListIter>d__35(-2);
			<InstIdListIter>d__.<>3__<>4__this = this;
			return <InstIdListIter>d__;
		}

		// Token: 0x060094DF RID: 38111 RVA: 0x00297780 File Offset: 0x00295980
		public int[] InstSubTypeList()
		{
			return this.GetInstSubTypeListArray();
		}

		// Token: 0x060094E0 RID: 38112 RVA: 0x00297788 File Offset: 0x00295988
		public IEnumerable<int> InstSubTypeListIter()
		{
			LinkParam.<InstSubTypeListIter>d__37 <InstSubTypeListIter>d__ = new LinkParam.<InstSubTypeListIter>d__37(-2);
			<InstSubTypeListIter>d__.<>3__<>4__this = this;
			return <InstSubTypeListIter>d__;
		}

		// Token: 0x060094E1 RID: 38113 RVA: 0x002977A0 File Offset: 0x002959A0
		public Dictionary<int, int> LinkBuffRoleMap()
		{
			return this.LinkBuffRoleMapIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x060094E2 RID: 38114 RVA: 0x002977F6 File Offset: 0x002959F6
		public IEnumerable<DicIntInt> LinkBuffRoleMapIter()
		{
			LinkParam.<LinkBuffRoleMapIter>d__39 <LinkBuffRoleMapIter>d__ = new LinkParam.<LinkBuffRoleMapIter>d__39(-2);
			<LinkBuffRoleMapIter>d__.<>3__<>4__this = this;
			return <LinkBuffRoleMapIter>d__;
		}

		// Token: 0x060094E3 RID: 38115 RVA: 0x0029780C File Offset: 0x00295A0C
		public Dictionary<int, string> LinkEnergyButtonMap()
		{
			return this.LinkEnergyButtonMapIter().ToDictionary((DicIntString element) => element.Key, (DicIntString element) => element.Value);
		}

		// Token: 0x060094E4 RID: 38116 RVA: 0x00297862 File Offset: 0x00295A62
		public IEnumerable<DicIntString> LinkEnergyButtonMapIter()
		{
			LinkParam.<LinkEnergyButtonMapIter>d__41 <LinkEnergyButtonMapIter>d__ = new LinkParam.<LinkEnergyButtonMapIter>d__41(-2);
			<LinkEnergyButtonMapIter>d__.<>3__<>4__this = this;
			return <LinkEnergyButtonMapIter>d__;
		}

		// Token: 0x060094E5 RID: 38117 RVA: 0x00297878 File Offset: 0x00295A78
		public Dictionary<int, int> MorphModelIdMap()
		{
			return this.MorphModelIdMapIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x060094E6 RID: 38118 RVA: 0x002978CE File Offset: 0x00295ACE
		public IEnumerable<DicIntInt> MorphModelIdMapIter()
		{
			LinkParam.<MorphModelIdMapIter>d__43 <MorphModelIdMapIter>d__ = new LinkParam.<MorphModelIdMapIter>d__43(-2);
			<MorphModelIdMapIter>d__.<>3__<>4__this = this;
			return <MorphModelIdMapIter>d__;
		}

		// Token: 0x060094E7 RID: 38119 RVA: 0x002978E4 File Offset: 0x00295AE4
		public int? GetChangeGenderMap(int key)
		{
			this.EnsureChangeGenderMapCacheIfNeeded();
			int value;
			if (!this.ChangeGenderMapCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x060094E8 RID: 38120 RVA: 0x00297918 File Offset: 0x00295B18
		public int? GetLinkBuffRoleMap(int key)
		{
			this.EnsureLinkBuffRoleMapCacheIfNeeded();
			int value;
			if (!this.LinkBuffRoleMapCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x060094E9 RID: 38121 RVA: 0x0029794C File Offset: 0x00295B4C
		[NullableContext(2)]
		public string GetLinkEnergyButtonMap(int key)
		{
			this.EnsureLinkEnergyButtonMapCacheIfNeeded();
			string result;
			if (!this.LinkEnergyButtonMapCache.TryGetValue(key, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x060094EA RID: 38122 RVA: 0x00297974 File Offset: 0x00295B74
		public int? GetMorphModelIdMap(int key)
		{
			this.EnsureMorphModelIdMapCacheIfNeeded();
			int value;
			if (!this.MorphModelIdMapCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x060094EB RID: 38123 RVA: 0x002979A8 File Offset: 0x00295BA8
		private void EnsureChangeGenderMapCacheIfNeeded()
		{
			if (this.ChangeGenderMapCache != null)
			{
				return;
			}
			this.ChangeGenderMapCache = this.ChangeGenderMapIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x060094EC RID: 38124 RVA: 0x00297A10 File Offset: 0x00295C10
		private void EnsureLinkBuffRoleMapCacheIfNeeded()
		{
			if (this.LinkBuffRoleMapCache != null)
			{
				return;
			}
			this.LinkBuffRoleMapCache = this.LinkBuffRoleMapIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x060094ED RID: 38125 RVA: 0x00297A78 File Offset: 0x00295C78
		private void EnsureLinkEnergyButtonMapCacheIfNeeded()
		{
			if (this.LinkEnergyButtonMapCache != null)
			{
				return;
			}
			this.LinkEnergyButtonMapCache = this.LinkEnergyButtonMapIter().ToFrozenDictionary((DicIntString kvp) => kvp.Key, (DicIntString kvp) => kvp.Value, null);
		}

		// Token: 0x060094EE RID: 38126 RVA: 0x00297AE0 File Offset: 0x00295CE0
		private void EnsureMorphModelIdMapCacheIfNeeded()
		{
			if (this.MorphModelIdMapCache != null)
			{
				return;
			}
			this.MorphModelIdMapCache = this.MorphModelIdMapIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x060094EF RID: 38127 RVA: 0x00297B46 File Offset: 0x00295D46
		public FrozenDictionary<int, int> GetChangeGenderMapFrozenDict()
		{
			this.EnsureChangeGenderMapCacheIfNeeded();
			return this.ChangeGenderMapCache;
		}

		// Token: 0x060094F0 RID: 38128 RVA: 0x00297B54 File Offset: 0x00295D54
		public FrozenDictionary<int, int> GetLinkBuffRoleMapFrozenDict()
		{
			this.EnsureLinkBuffRoleMapCacheIfNeeded();
			return this.LinkBuffRoleMapCache;
		}

		// Token: 0x060094F1 RID: 38129 RVA: 0x00297B62 File Offset: 0x00295D62
		public FrozenDictionary<int, string> GetLinkEnergyButtonMapFrozenDict()
		{
			this.EnsureLinkEnergyButtonMapCacheIfNeeded();
			return this.LinkEnergyButtonMapCache;
		}

		// Token: 0x060094F2 RID: 38130 RVA: 0x00297B70 File Offset: 0x00295D70
		public FrozenDictionary<int, int> GetMorphModelIdMapFrozenDict()
		{
			this.EnsureMorphModelIdMapCacheIfNeeded();
			return this.MorphModelIdMapCache;
		}

		// Token: 0x0400544B RID: 21579
		private Table __p;

		// Token: 0x0400544C RID: 21580
		[Nullable(2)]
		private FrozenDictionary<int, int> ChangeGenderMapCache;

		// Token: 0x0400544D RID: 21581
		[Nullable(2)]
		private FrozenDictionary<int, int> LinkBuffRoleMapCache;

		// Token: 0x0400544E RID: 21582
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private FrozenDictionary<int, string> LinkEnergyButtonMapCache;

		// Token: 0x0400544F RID: 21583
		[Nullable(2)]
		private FrozenDictionary<int, int> MorphModelIdMapCache;
	}
}
