using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D60 RID: 3424
	public struct FishingEntrust : IFlatbufferObject
	{
		// Token: 0x170011A1 RID: 4513
		// (get) Token: 0x0600750F RID: 29967 RVA: 0x0024F66C File Offset: 0x0024D86C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007510 RID: 29968 RVA: 0x0024F679 File Offset: 0x0024D879
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007511 RID: 29969 RVA: 0x0024F680 File Offset: 0x0024D880
		public static FishingEntrust GetRootAsFishingEntrust(ByteBuffer _bb)
		{
			return FishingEntrust.GetRootAsFishingEntrust(_bb, default(FishingEntrust));
		}

		// Token: 0x06007512 RID: 29970 RVA: 0x0024F69C File Offset: 0x0024D89C
		public static FishingEntrust GetRootAsFishingEntrust(ByteBuffer _bb, FishingEntrust obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007513 RID: 29971 RVA: 0x0024F6B9 File Offset: 0x0024D8B9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007514 RID: 29972 RVA: 0x0024F6C8 File Offset: 0x0024D8C8
		public FishingEntrust __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170011A2 RID: 4514
		// (get) Token: 0x06007515 RID: 29973 RVA: 0x0024F6D8 File Offset: 0x0024D8D8
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

		// Token: 0x170011A3 RID: 4515
		// (get) Token: 0x06007516 RID: 29974 RVA: 0x0024F714 File Offset: 0x0024D914
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

		// Token: 0x06007517 RID: 29975 RVA: 0x0024F74B File Offset: 0x0024D94B
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06007518 RID: 29976 RVA: 0x0024F75A File Offset: 0x0024D95A
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170011A4 RID: 4516
		// (get) Token: 0x06007519 RID: 29977 RVA: 0x0024F774 File Offset: 0x0024D974
		public bool IsNight
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170011A5 RID: 4517
		// (get) Token: 0x0600751A RID: 29978 RVA: 0x0024F7B4 File Offset: 0x0024D9B4
		public string Desc
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600751B RID: 29979 RVA: 0x0024F7EC File Offset: 0x0024D9EC
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600751C RID: 29980 RVA: 0x0024F7FC File Offset: 0x0024D9FC
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x170011A6 RID: 4518
		// (get) Token: 0x0600751D RID: 29981 RVA: 0x0024F814 File Offset: 0x0024DA14
		public int PreviewItem
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

		// Token: 0x170011A7 RID: 4519
		// (get) Token: 0x0600751E RID: 29982 RVA: 0x0024F854 File Offset: 0x0024DA54
		public int Star
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

		// Token: 0x170011A8 RID: 4520
		// (get) Token: 0x0600751F RID: 29983 RVA: 0x0024F894 File Offset: 0x0024DA94
		public int EntrustType
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

		// Token: 0x170011A9 RID: 4521
		// (get) Token: 0x06007520 RID: 29984 RVA: 0x0024F8D4 File Offset: 0x0024DAD4
		public int EntrustPool
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

		// Token: 0x170011AA RID: 4522
		// (get) Token: 0x06007521 RID: 29985 RVA: 0x0024F914 File Offset: 0x0024DB14
		public int UnlockCondition
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

		// Token: 0x06007522 RID: 29986 RVA: 0x0024F954 File Offset: 0x0024DB54
		public DicIntInt? EntrustTarget(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170011AB RID: 4523
		// (get) Token: 0x06007523 RID: 29987 RVA: 0x0024F9B8 File Offset: 0x0024DBB8
		public int EntrustTargetLength
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

		// Token: 0x170011AC RID: 4524
		// (get) Token: 0x06007524 RID: 29988 RVA: 0x0024F9E4 File Offset: 0x0024DBE4
		public int EntrustDestination
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

		// Token: 0x06007525 RID: 29989 RVA: 0x0024FA24 File Offset: 0x0024DC24
		public DicIntInt? EntrustReward(int j)
		{
			int num = this.__p.__offset(26);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170011AD RID: 4525
		// (get) Token: 0x06007526 RID: 29990 RVA: 0x0024FA88 File Offset: 0x0024DC88
		public int EntrustRewardLength
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

		// Token: 0x170011AE RID: 4526
		// (get) Token: 0x06007527 RID: 29991 RVA: 0x0024FAB4 File Offset: 0x0024DCB4
		public int AccessPath
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

		// Token: 0x06007528 RID: 29992 RVA: 0x0024FAF4 File Offset: 0x0024DCF4
		public DicIntString? TargetDesText(int j)
		{
			int num = this.__p.__offset(30);
			if (num == 0)
			{
				return null;
			}
			return new DicIntString?(default(DicIntString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170011AF RID: 4527
		// (get) Token: 0x06007529 RID: 29993 RVA: 0x0024FB58 File Offset: 0x0024DD58
		public int TargetDesTextLength
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

		// Token: 0x0600752A RID: 29994 RVA: 0x0024FB84 File Offset: 0x0024DD84
		[NullableContext(1)]
		public Dictionary<int, int> EntrustReward()
		{
			return this.EntrustRewardIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600752B RID: 29995 RVA: 0x0024FBDA File Offset: 0x0024DDDA
		[NullableContext(1)]
		public IEnumerable<DicIntInt> EntrustRewardIter()
		{
			FishingEntrust.<EntrustRewardIter>d__44 <EntrustRewardIter>d__ = new FishingEntrust.<EntrustRewardIter>d__44(-2);
			<EntrustRewardIter>d__.<>3__<>4__this = this;
			return <EntrustRewardIter>d__;
		}

		// Token: 0x0600752C RID: 29996 RVA: 0x0024FBF0 File Offset: 0x0024DDF0
		[NullableContext(1)]
		public Dictionary<int, int> EntrustTarget()
		{
			return this.EntrustTargetIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600752D RID: 29997 RVA: 0x0024FC46 File Offset: 0x0024DE46
		[NullableContext(1)]
		public IEnumerable<DicIntInt> EntrustTargetIter()
		{
			FishingEntrust.<EntrustTargetIter>d__46 <EntrustTargetIter>d__ = new FishingEntrust.<EntrustTargetIter>d__46(-2);
			<EntrustTargetIter>d__.<>3__<>4__this = this;
			return <EntrustTargetIter>d__;
		}

		// Token: 0x0600752E RID: 29998 RVA: 0x0024FC5C File Offset: 0x0024DE5C
		[NullableContext(1)]
		public Dictionary<int, string> TargetDesText()
		{
			return this.TargetDesTextIter().ToDictionary((DicIntString element) => element.Key, (DicIntString element) => element.Value);
		}

		// Token: 0x0600752F RID: 29999 RVA: 0x0024FCB2 File Offset: 0x0024DEB2
		[NullableContext(1)]
		public IEnumerable<DicIntString> TargetDesTextIter()
		{
			FishingEntrust.<TargetDesTextIter>d__48 <TargetDesTextIter>d__ = new FishingEntrust.<TargetDesTextIter>d__48(-2);
			<TargetDesTextIter>d__.<>3__<>4__this = this;
			return <TargetDesTextIter>d__;
		}

		// Token: 0x06007530 RID: 30000 RVA: 0x0024FCC8 File Offset: 0x0024DEC8
		public int? GetEntrustReward(int key)
		{
			this.EnsureEntrustRewardCacheIfNeeded();
			int value;
			if (!this.EntrustRewardCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x06007531 RID: 30001 RVA: 0x0024FCFC File Offset: 0x0024DEFC
		public int? GetEntrustTarget(int key)
		{
			this.EnsureEntrustTargetCacheIfNeeded();
			int value;
			if (!this.EntrustTargetCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x06007532 RID: 30002 RVA: 0x0024FD30 File Offset: 0x0024DF30
		[NullableContext(2)]
		public string GetTargetDesText(int key)
		{
			this.EnsureTargetDesTextCacheIfNeeded();
			string result;
			if (!this.TargetDesTextCache.TryGetValue(key, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x06007533 RID: 30003 RVA: 0x0024FD58 File Offset: 0x0024DF58
		private void EnsureEntrustRewardCacheIfNeeded()
		{
			if (this.EntrustRewardCache != null)
			{
				return;
			}
			this.EntrustRewardCache = this.EntrustRewardIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x06007534 RID: 30004 RVA: 0x0024FDC0 File Offset: 0x0024DFC0
		private void EnsureEntrustTargetCacheIfNeeded()
		{
			if (this.EntrustTargetCache != null)
			{
				return;
			}
			this.EntrustTargetCache = this.EntrustTargetIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x06007535 RID: 30005 RVA: 0x0024FE28 File Offset: 0x0024E028
		private void EnsureTargetDesTextCacheIfNeeded()
		{
			if (this.TargetDesTextCache != null)
			{
				return;
			}
			this.TargetDesTextCache = this.TargetDesTextIter().ToFrozenDictionary((DicIntString kvp) => kvp.Key, (DicIntString kvp) => kvp.Value, null);
		}

		// Token: 0x06007536 RID: 30006 RVA: 0x0024FE8E File Offset: 0x0024E08E
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetEntrustRewardFrozenDict()
		{
			this.EnsureEntrustRewardCacheIfNeeded();
			return this.EntrustRewardCache;
		}

		// Token: 0x06007537 RID: 30007 RVA: 0x0024FE9C File Offset: 0x0024E09C
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetEntrustTargetFrozenDict()
		{
			this.EnsureEntrustTargetCacheIfNeeded();
			return this.EntrustTargetCache;
		}

		// Token: 0x06007538 RID: 30008 RVA: 0x0024FEAA File Offset: 0x0024E0AA
		[NullableContext(1)]
		public FrozenDictionary<int, string> GetTargetDesTextFrozenDict()
		{
			this.EnsureTargetDesTextCacheIfNeeded();
			return this.TargetDesTextCache;
		}

		// Token: 0x040052AC RID: 21164
		private Table __p;

		// Token: 0x040052AD RID: 21165
		[Nullable(2)]
		private FrozenDictionary<int, int> EntrustRewardCache;

		// Token: 0x040052AE RID: 21166
		[Nullable(2)]
		private FrozenDictionary<int, int> EntrustTargetCache;

		// Token: 0x040052AF RID: 21167
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private FrozenDictionary<int, string> TargetDesTextCache;
	}
}
