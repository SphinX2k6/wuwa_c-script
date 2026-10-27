using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DD0 RID: 3536
	public struct LinkParam : IFlatbufferObject
	{
		// Token: 0x17001D19 RID: 7449
		// (get) Token: 0x06008EA8 RID: 36520 RVA: 0x00278EB1 File Offset: 0x002770B1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008EA9 RID: 36521 RVA: 0x00278EBE File Offset: 0x002770BE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008EAA RID: 36522 RVA: 0x00278EC8 File Offset: 0x002770C8
		public static LinkParam GetRootAsLinkParam(ByteBuffer _bb)
		{
			return LinkParam.GetRootAsLinkParam(_bb, default(LinkParam));
		}

		// Token: 0x06008EAB RID: 36523 RVA: 0x00278EE4 File Offset: 0x002770E4
		public static LinkParam GetRootAsLinkParam(ByteBuffer _bb, LinkParam obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008EAC RID: 36524 RVA: 0x00278F01 File Offset: 0x00277101
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008EAD RID: 36525 RVA: 0x00278F10 File Offset: 0x00277110
		public LinkParam __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001D1A RID: 7450
		// (get) Token: 0x06008EAE RID: 36526 RVA: 0x00278F20 File Offset: 0x00277120
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

		// Token: 0x06008EAF RID: 36527 RVA: 0x00278F5C File Offset: 0x0027715C
		public int InstSubTypeList(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001D1B RID: 7451
		// (get) Token: 0x06008EB0 RID: 36528 RVA: 0x00278F9C File Offset: 0x0027719C
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

		// Token: 0x06008EB1 RID: 36529 RVA: 0x00278FC7 File Offset: 0x002771C7
		public Span<int> GetInstSubTypeListBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x06008EB2 RID: 36530 RVA: 0x00278FD6 File Offset: 0x002771D6
		public int[] GetInstSubTypeListArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x06008EB3 RID: 36531 RVA: 0x00278FF0 File Offset: 0x002771F0
		public int InstIdList(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001D1C RID: 7452
		// (get) Token: 0x06008EB4 RID: 36532 RVA: 0x00279030 File Offset: 0x00277230
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

		// Token: 0x06008EB5 RID: 36533 RVA: 0x0027905B File Offset: 0x0027725B
		public Span<int> GetInstIdListBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x06008EB6 RID: 36534 RVA: 0x0027906A File Offset: 0x0027726A
		public int[] GetInstIdListArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x06008EB7 RID: 36535 RVA: 0x00279084 File Offset: 0x00277284
		public DicIntInt? LinkBuffRoleMap(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17001D1D RID: 7453
		// (get) Token: 0x06008EB8 RID: 36536 RVA: 0x002790E8 File Offset: 0x002772E8
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

		// Token: 0x06008EB9 RID: 36537 RVA: 0x00279114 File Offset: 0x00277314
		public DicIntInt? ChangeGenderMap(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17001D1E RID: 7454
		// (get) Token: 0x06008EBA RID: 36538 RVA: 0x00279178 File Offset: 0x00277378
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

		// Token: 0x06008EBB RID: 36539 RVA: 0x002791A4 File Offset: 0x002773A4
		public DicIntInt? MorphModelIdMap(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17001D1F RID: 7455
		// (get) Token: 0x06008EBC RID: 36540 RVA: 0x00279208 File Offset: 0x00277408
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

		// Token: 0x06008EBD RID: 36541 RVA: 0x00279234 File Offset: 0x00277434
		public DicIntString? LinkEnergyButtonMap(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return new DicIntString?(default(DicIntString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17001D20 RID: 7456
		// (get) Token: 0x06008EBE RID: 36542 RVA: 0x00279298 File Offset: 0x00277498
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

		// Token: 0x06008EBF RID: 36543 RVA: 0x002792C4 File Offset: 0x002774C4
		[NullableContext(1)]
		[Obsolete("已废弃，请使用ChangeGenderMapFrozenDict()缓存字典，遍历请使用ChangeGenderMapIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> ChangeGenderMap()
		{
			return this.ChangeGenderMapIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x06008EC0 RID: 36544 RVA: 0x0027931A File Offset: 0x0027751A
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> ChangeGenderMapIter()
		{
			LinkParam.<ChangeGenderMapIter>d__33 <ChangeGenderMapIter>d__ = new LinkParam.<ChangeGenderMapIter>d__33(-2);
			<ChangeGenderMapIter>d__.<>3__<>4__this = this;
			return <ChangeGenderMapIter>d__;
		}

		// Token: 0x06008EC1 RID: 36545 RVA: 0x00279330 File Offset: 0x00277530
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用InstIdListIter()或GetInstIdListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] InstIdList()
		{
			LinkParam linkParam = this;
			return linkParam.GetInstIdListArray() ?? Array.Empty<int>();
		}

		// Token: 0x06008EC2 RID: 36546 RVA: 0x00279354 File Offset: 0x00277554
		[NullableContext(1)]
		public readonly IEnumerable<int> InstIdListIter()
		{
			LinkParam.<InstIdListIter>d__35 <InstIdListIter>d__ = new LinkParam.<InstIdListIter>d__35(-2);
			<InstIdListIter>d__.<>3__<>4__this = this;
			return <InstIdListIter>d__;
		}

		// Token: 0x06008EC3 RID: 36547 RVA: 0x0027936C File Offset: 0x0027756C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用InstSubTypeListIter()或GetInstSubTypeListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] InstSubTypeList()
		{
			LinkParam linkParam = this;
			return linkParam.GetInstSubTypeListArray() ?? Array.Empty<int>();
		}

		// Token: 0x06008EC4 RID: 36548 RVA: 0x00279390 File Offset: 0x00277590
		[NullableContext(1)]
		public readonly IEnumerable<int> InstSubTypeListIter()
		{
			LinkParam.<InstSubTypeListIter>d__37 <InstSubTypeListIter>d__ = new LinkParam.<InstSubTypeListIter>d__37(-2);
			<InstSubTypeListIter>d__.<>3__<>4__this = this;
			return <InstSubTypeListIter>d__;
		}

		// Token: 0x06008EC5 RID: 36549 RVA: 0x002793A8 File Offset: 0x002775A8
		[NullableContext(1)]
		[Obsolete("已废弃，请使用LinkBuffRoleMapFrozenDict()缓存字典，遍历请使用LinkBuffRoleMapIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> LinkBuffRoleMap()
		{
			return this.LinkBuffRoleMapIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x06008EC6 RID: 36550 RVA: 0x002793FE File Offset: 0x002775FE
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> LinkBuffRoleMapIter()
		{
			LinkParam.<LinkBuffRoleMapIter>d__39 <LinkBuffRoleMapIter>d__ = new LinkParam.<LinkBuffRoleMapIter>d__39(-2);
			<LinkBuffRoleMapIter>d__.<>3__<>4__this = this;
			return <LinkBuffRoleMapIter>d__;
		}

		// Token: 0x06008EC7 RID: 36551 RVA: 0x00279414 File Offset: 0x00277614
		[NullableContext(1)]
		[Obsolete("已废弃，请使用LinkEnergyButtonMapFrozenDict()缓存字典，遍历请使用LinkEnergyButtonMapIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, string> LinkEnergyButtonMap()
		{
			return this.LinkEnergyButtonMapIter().ToDictionary((DicIntString element) => element.Key, (DicIntString element) => element.Value);
		}

		// Token: 0x06008EC8 RID: 36552 RVA: 0x0027946A File Offset: 0x0027766A
		[NullableContext(1)]
		public readonly IEnumerable<DicIntString> LinkEnergyButtonMapIter()
		{
			LinkParam.<LinkEnergyButtonMapIter>d__41 <LinkEnergyButtonMapIter>d__ = new LinkParam.<LinkEnergyButtonMapIter>d__41(-2);
			<LinkEnergyButtonMapIter>d__.<>3__<>4__this = this;
			return <LinkEnergyButtonMapIter>d__;
		}

		// Token: 0x06008EC9 RID: 36553 RVA: 0x00279480 File Offset: 0x00277680
		[NullableContext(1)]
		[Obsolete("已废弃，请使用MorphModelIdMapFrozenDict()缓存字典，遍历请使用MorphModelIdMapIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> MorphModelIdMap()
		{
			return this.MorphModelIdMapIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x06008ECA RID: 36554 RVA: 0x002794D6 File Offset: 0x002776D6
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> MorphModelIdMapIter()
		{
			LinkParam.<MorphModelIdMapIter>d__43 <MorphModelIdMapIter>d__ = new LinkParam.<MorphModelIdMapIter>d__43(-2);
			<MorphModelIdMapIter>d__.<>3__<>4__this = this;
			return <MorphModelIdMapIter>d__;
		}

		// Token: 0x06008ECB RID: 36555 RVA: 0x002794EC File Offset: 0x002776EC
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

		// Token: 0x06008ECC RID: 36556 RVA: 0x00279520 File Offset: 0x00277720
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

		// Token: 0x06008ECD RID: 36557 RVA: 0x00279554 File Offset: 0x00277754
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

		// Token: 0x06008ECE RID: 36558 RVA: 0x0027957C File Offset: 0x0027777C
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

		// Token: 0x06008ECF RID: 36559 RVA: 0x002795B0 File Offset: 0x002777B0
		private void EnsureChangeGenderMapCacheIfNeeded()
		{
			if (this.ChangeGenderMapCache != null)
			{
				return;
			}
			this.ChangeGenderMapCache = this.ChangeGenderMapIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x06008ED0 RID: 36560 RVA: 0x00279618 File Offset: 0x00277818
		private void EnsureLinkBuffRoleMapCacheIfNeeded()
		{
			if (this.LinkBuffRoleMapCache != null)
			{
				return;
			}
			this.LinkBuffRoleMapCache = this.LinkBuffRoleMapIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x06008ED1 RID: 36561 RVA: 0x00279680 File Offset: 0x00277880
		private void EnsureLinkEnergyButtonMapCacheIfNeeded()
		{
			if (this.LinkEnergyButtonMapCache != null)
			{
				return;
			}
			this.LinkEnergyButtonMapCache = this.LinkEnergyButtonMapIter().ToFrozenDictionary((DicIntString kvp) => kvp.Key, (DicIntString kvp) => kvp.Value, null);
		}

		// Token: 0x06008ED2 RID: 36562 RVA: 0x002796E8 File Offset: 0x002778E8
		private void EnsureMorphModelIdMapCacheIfNeeded()
		{
			if (this.MorphModelIdMapCache != null)
			{
				return;
			}
			this.MorphModelIdMapCache = this.MorphModelIdMapIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x06008ED3 RID: 36563 RVA: 0x0027974E File Offset: 0x0027794E
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetChangeGenderMapFrozenDict(int key)
		{
			this.EnsureChangeGenderMapCacheIfNeeded();
			return this.ChangeGenderMapCache;
		}

		// Token: 0x06008ED4 RID: 36564 RVA: 0x0027975C File Offset: 0x0027795C
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetLinkBuffRoleMapFrozenDict(int key)
		{
			this.EnsureLinkBuffRoleMapCacheIfNeeded();
			return this.LinkBuffRoleMapCache;
		}

		// Token: 0x06008ED5 RID: 36565 RVA: 0x0027976A File Offset: 0x0027796A
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public FrozenDictionary<int, string> GetLinkEnergyButtonMapFrozenDict(int key)
		{
			this.EnsureLinkEnergyButtonMapCacheIfNeeded();
			return this.LinkEnergyButtonMapCache;
		}

		// Token: 0x06008ED6 RID: 36566 RVA: 0x00279778 File Offset: 0x00277978
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetMorphModelIdMapFrozenDict(int key)
		{
			this.EnsureMorphModelIdMapCacheIfNeeded();
			return this.MorphModelIdMapCache;
		}

		// Token: 0x04004E66 RID: 20070
		private Table __p;

		// Token: 0x04004E67 RID: 20071
		[Nullable(2)]
		private FrozenDictionary<int, int> ChangeGenderMapCache;

		// Token: 0x04004E68 RID: 20072
		[Nullable(2)]
		private FrozenDictionary<int, int> LinkBuffRoleMapCache;

		// Token: 0x04004E69 RID: 20073
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private FrozenDictionary<int, string> LinkEnergyButtonMapCache;

		// Token: 0x04004E6A RID: 20074
		[Nullable(2)]
		private FrozenDictionary<int, int> MorphModelIdMapCache;
	}
}
