using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010CD RID: 4301
	public struct RogueInst : IFlatbufferObject
	{
		// Token: 0x17002FD8 RID: 12248
		// (get) Token: 0x0600C5E1 RID: 50657 RVA: 0x00302480 File Offset: 0x00300680
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C5E2 RID: 50658 RVA: 0x0030248D File Offset: 0x0030068D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C5E3 RID: 50659 RVA: 0x00302494 File Offset: 0x00300694
		public static RogueInst GetRootAsRogueInst(ByteBuffer _bb)
		{
			return RogueInst.GetRootAsRogueInst(_bb, default(RogueInst));
		}

		// Token: 0x0600C5E4 RID: 50660 RVA: 0x003024B0 File Offset: 0x003006B0
		public static RogueInst GetRootAsRogueInst(ByteBuffer _bb, RogueInst obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C5E5 RID: 50661 RVA: 0x003024CD File Offset: 0x003006CD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C5E6 RID: 50662 RVA: 0x003024DC File Offset: 0x003006DC
		public RogueInst __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002FD9 RID: 12249
		// (get) Token: 0x0600C5E7 RID: 50663 RVA: 0x003024EC File Offset: 0x003006EC
		public int InstId
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

		// Token: 0x0600C5E8 RID: 50664 RVA: 0x00302528 File Offset: 0x00300728
		public int FirstReadEntrys(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002FDA RID: 12250
		// (get) Token: 0x0600C5E9 RID: 50665 RVA: 0x00302568 File Offset: 0x00300768
		public int FirstReadEntrysLength
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

		// Token: 0x0600C5EA RID: 50666 RVA: 0x00302593 File Offset: 0x00300793
		public Span<int> GetFirstReadEntrysBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0600C5EB RID: 50667 RVA: 0x003025A2 File Offset: 0x003007A2
		public int[] GetFirstReadEntrysArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x0600C5EC RID: 50668 RVA: 0x003025BC File Offset: 0x003007BC
		public DicIntIntArray? HotEntryUnlockCond(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new DicIntIntArray?(default(DicIntIntArray).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17002FDB RID: 12251
		// (get) Token: 0x0600C5ED RID: 50669 RVA: 0x0030261C File Offset: 0x0030081C
		public int HotEntryUnlockCondLength
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

		// Token: 0x0600C5EE RID: 50670 RVA: 0x00302648 File Offset: 0x00300848
		public DicIntString? UnlockTips(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new DicIntString?(default(DicIntString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17002FDC RID: 12252
		// (get) Token: 0x0600C5EF RID: 50671 RVA: 0x003026AC File Offset: 0x003008AC
		public int UnlockTipsLength
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

		// Token: 0x17002FDD RID: 12253
		// (get) Token: 0x0600C5F0 RID: 50672 RVA: 0x003026D8 File Offset: 0x003008D8
		public string InstIcon
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600C5F1 RID: 50673 RVA: 0x00302710 File Offset: 0x00300910
		public Span<byte> GetInstIconBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600C5F2 RID: 50674 RVA: 0x00302720 File Offset: 0x00300920
		public byte[] GetInstIconArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17002FDE RID: 12254
		// (get) Token: 0x0600C5F3 RID: 50675 RVA: 0x00302738 File Offset: 0x00300938
		public int SpecialBossIndex
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

		// Token: 0x0600C5F4 RID: 50676 RVA: 0x00302775 File Offset: 0x00300975
		[NullableContext(1)]
		public int[] FirstReadEntrys()
		{
			return this.GetFirstReadEntrysArray();
		}

		// Token: 0x0600C5F5 RID: 50677 RVA: 0x0030277D File Offset: 0x0030097D
		[NullableContext(1)]
		public IEnumerable<int> FirstReadEntrysIter()
		{
			RogueInst.<FirstReadEntrysIter>d__28 <FirstReadEntrysIter>d__ = new RogueInst.<FirstReadEntrysIter>d__28(-2);
			<FirstReadEntrysIter>d__.<>3__<>4__this = this;
			return <FirstReadEntrysIter>d__;
		}

		// Token: 0x0600C5F6 RID: 50678 RVA: 0x00302794 File Offset: 0x00300994
		[NullableContext(1)]
		public Dictionary<int, IntArray> HotEntryUnlockCond()
		{
			return this.HotEntryUnlockCondIter().ToDictionary((DicIntIntArray element) => element.Key, (DicIntIntArray element) => element.Value.Value);
		}

		// Token: 0x0600C5F7 RID: 50679 RVA: 0x003027EA File Offset: 0x003009EA
		[NullableContext(1)]
		public IEnumerable<DicIntIntArray> HotEntryUnlockCondIter()
		{
			RogueInst.<HotEntryUnlockCondIter>d__30 <HotEntryUnlockCondIter>d__ = new RogueInst.<HotEntryUnlockCondIter>d__30(-2);
			<HotEntryUnlockCondIter>d__.<>3__<>4__this = this;
			return <HotEntryUnlockCondIter>d__;
		}

		// Token: 0x0600C5F8 RID: 50680 RVA: 0x00302800 File Offset: 0x00300A00
		[NullableContext(1)]
		public Dictionary<int, string> UnlockTips()
		{
			return this.UnlockTipsIter().ToDictionary((DicIntString element) => element.Key, (DicIntString element) => element.Value);
		}

		// Token: 0x0600C5F9 RID: 50681 RVA: 0x00302856 File Offset: 0x00300A56
		[NullableContext(1)]
		public IEnumerable<DicIntString> UnlockTipsIter()
		{
			RogueInst.<UnlockTipsIter>d__32 <UnlockTipsIter>d__ = new RogueInst.<UnlockTipsIter>d__32(-2);
			<UnlockTipsIter>d__.<>3__<>4__this = this;
			return <UnlockTipsIter>d__;
		}

		// Token: 0x0600C5FA RID: 50682 RVA: 0x0030286C File Offset: 0x00300A6C
		public IntArray? GetHotEntryUnlockCond(int key)
		{
			this.EnsureHotEntryUnlockCondCacheIfNeeded();
			IntArray value;
			if (!this.HotEntryUnlockCondCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new IntArray?(value);
		}

		// Token: 0x0600C5FB RID: 50683 RVA: 0x003028A0 File Offset: 0x00300AA0
		[NullableContext(2)]
		public string GetUnlockTips(int key)
		{
			this.EnsureUnlockTipsCacheIfNeeded();
			string result;
			if (!this.UnlockTipsCache.TryGetValue(key, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x0600C5FC RID: 50684 RVA: 0x003028C8 File Offset: 0x00300AC8
		private void EnsureHotEntryUnlockCondCacheIfNeeded()
		{
			if (this.HotEntryUnlockCondCache != null)
			{
				return;
			}
			this.HotEntryUnlockCondCache = this.HotEntryUnlockCondIter().ToFrozenDictionary((DicIntIntArray kvp) => kvp.Key, (DicIntIntArray kvp) => kvp.Value.Value, null);
		}

		// Token: 0x0600C5FD RID: 50685 RVA: 0x00302930 File Offset: 0x00300B30
		private void EnsureUnlockTipsCacheIfNeeded()
		{
			if (this.UnlockTipsCache != null)
			{
				return;
			}
			this.UnlockTipsCache = this.UnlockTipsIter().ToFrozenDictionary((DicIntString kvp) => kvp.Key, (DicIntString kvp) => kvp.Value, null);
		}

		// Token: 0x0600C5FE RID: 50686 RVA: 0x00302996 File Offset: 0x00300B96
		[NullableContext(1)]
		public FrozenDictionary<int, IntArray> GetHotEntryUnlockCondFrozenDict()
		{
			this.EnsureHotEntryUnlockCondCacheIfNeeded();
			return this.HotEntryUnlockCondCache;
		}

		// Token: 0x0600C5FF RID: 50687 RVA: 0x003029A4 File Offset: 0x00300BA4
		[NullableContext(1)]
		public FrozenDictionary<int, string> GetUnlockTipsFrozenDict()
		{
			this.EnsureUnlockTipsCacheIfNeeded();
			return this.UnlockTipsCache;
		}

		// Token: 0x040056AA RID: 22186
		private Table __p;

		// Token: 0x040056AB RID: 22187
		[Nullable(2)]
		private FrozenDictionary<int, IntArray> HotEntryUnlockCondCache;

		// Token: 0x040056AC RID: 22188
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private FrozenDictionary<int, string> UnlockTipsCache;
	}
}
