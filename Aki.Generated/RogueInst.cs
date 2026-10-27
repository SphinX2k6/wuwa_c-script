using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FE5 RID: 4069
	public struct RogueInst : IFlatbufferObject
	{
		// Token: 0x17002F5D RID: 12125
		// (get) Token: 0x0600BF97 RID: 49047 RVA: 0x002E6084 File Offset: 0x002E4284
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600BF98 RID: 49048 RVA: 0x002E6091 File Offset: 0x002E4291
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600BF99 RID: 49049 RVA: 0x002E6098 File Offset: 0x002E4298
		public static RogueInst GetRootAsRogueInst(ByteBuffer _bb)
		{
			return RogueInst.GetRootAsRogueInst(_bb, default(RogueInst));
		}

		// Token: 0x0600BF9A RID: 49050 RVA: 0x002E60B4 File Offset: 0x002E42B4
		public static RogueInst GetRootAsRogueInst(ByteBuffer _bb, RogueInst obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600BF9B RID: 49051 RVA: 0x002E60D1 File Offset: 0x002E42D1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600BF9C RID: 49052 RVA: 0x002E60E0 File Offset: 0x002E42E0
		public RogueInst __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002F5E RID: 12126
		// (get) Token: 0x0600BF9D RID: 49053 RVA: 0x002E60F0 File Offset: 0x002E42F0
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

		// Token: 0x0600BF9E RID: 49054 RVA: 0x002E612C File Offset: 0x002E432C
		public int FirstReadEntrys(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002F5F RID: 12127
		// (get) Token: 0x0600BF9F RID: 49055 RVA: 0x002E616C File Offset: 0x002E436C
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

		// Token: 0x0600BFA0 RID: 49056 RVA: 0x002E6197 File Offset: 0x002E4397
		public Span<int> GetFirstReadEntrysBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0600BFA1 RID: 49057 RVA: 0x002E61A6 File Offset: 0x002E43A6
		public int[] GetFirstReadEntrysArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x0600BFA2 RID: 49058 RVA: 0x002E61C0 File Offset: 0x002E43C0
		public DicIntIntArray? HotEntryUnlockCond(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new DicIntIntArray?(default(DicIntIntArray).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17002F60 RID: 12128
		// (get) Token: 0x0600BFA3 RID: 49059 RVA: 0x002E6220 File Offset: 0x002E4420
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

		// Token: 0x0600BFA4 RID: 49060 RVA: 0x002E624C File Offset: 0x002E444C
		public DicIntString? UnlockTips(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new DicIntString?(default(DicIntString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17002F61 RID: 12129
		// (get) Token: 0x0600BFA5 RID: 49061 RVA: 0x002E62B0 File Offset: 0x002E44B0
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

		// Token: 0x17002F62 RID: 12130
		// (get) Token: 0x0600BFA6 RID: 49062 RVA: 0x002E62DC File Offset: 0x002E44DC
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

		// Token: 0x0600BFA7 RID: 49063 RVA: 0x002E6314 File Offset: 0x002E4514
		public Span<byte> GetInstIconBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600BFA8 RID: 49064 RVA: 0x002E6324 File Offset: 0x002E4524
		public byte[] GetInstIconArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17002F63 RID: 12131
		// (get) Token: 0x0600BFA9 RID: 49065 RVA: 0x002E633C File Offset: 0x002E453C
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

		// Token: 0x0600BFAA RID: 49066 RVA: 0x002E637C File Offset: 0x002E457C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用FirstReadEntrysIter()或GetFirstReadEntrysBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] FirstReadEntrys()
		{
			RogueInst rogueInst = this;
			return rogueInst.GetFirstReadEntrysArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600BFAB RID: 49067 RVA: 0x002E63A0 File Offset: 0x002E45A0
		[NullableContext(1)]
		public readonly IEnumerable<int> FirstReadEntrysIter()
		{
			RogueInst.<FirstReadEntrysIter>d__28 <FirstReadEntrysIter>d__ = new RogueInst.<FirstReadEntrysIter>d__28(-2);
			<FirstReadEntrysIter>d__.<>3__<>4__this = this;
			return <FirstReadEntrysIter>d__;
		}

		// Token: 0x0600BFAC RID: 49068 RVA: 0x002E63B8 File Offset: 0x002E45B8
		[NullableContext(1)]
		[Obsolete("已废弃，请使用HotEntryUnlockCondFrozenDict()缓存字典，遍历请使用HotEntryUnlockCondIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, IntArray> HotEntryUnlockCond()
		{
			return this.HotEntryUnlockCondIter().ToDictionary((DicIntIntArray element) => element.Key, (DicIntIntArray element) => element.Value.Value);
		}

		// Token: 0x0600BFAD RID: 49069 RVA: 0x002E640E File Offset: 0x002E460E
		[NullableContext(1)]
		public readonly IEnumerable<DicIntIntArray> HotEntryUnlockCondIter()
		{
			RogueInst.<HotEntryUnlockCondIter>d__30 <HotEntryUnlockCondIter>d__ = new RogueInst.<HotEntryUnlockCondIter>d__30(-2);
			<HotEntryUnlockCondIter>d__.<>3__<>4__this = this;
			return <HotEntryUnlockCondIter>d__;
		}

		// Token: 0x0600BFAE RID: 49070 RVA: 0x002E6424 File Offset: 0x002E4624
		[NullableContext(1)]
		[Obsolete("已废弃，请使用UnlockTipsFrozenDict()缓存字典，遍历请使用UnlockTipsIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, string> UnlockTips()
		{
			return this.UnlockTipsIter().ToDictionary((DicIntString element) => element.Key, (DicIntString element) => element.Value);
		}

		// Token: 0x0600BFAF RID: 49071 RVA: 0x002E647A File Offset: 0x002E467A
		[NullableContext(1)]
		public readonly IEnumerable<DicIntString> UnlockTipsIter()
		{
			RogueInst.<UnlockTipsIter>d__32 <UnlockTipsIter>d__ = new RogueInst.<UnlockTipsIter>d__32(-2);
			<UnlockTipsIter>d__.<>3__<>4__this = this;
			return <UnlockTipsIter>d__;
		}

		// Token: 0x0600BFB0 RID: 49072 RVA: 0x002E6490 File Offset: 0x002E4690
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

		// Token: 0x0600BFB1 RID: 49073 RVA: 0x002E64C4 File Offset: 0x002E46C4
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

		// Token: 0x0600BFB2 RID: 49074 RVA: 0x002E64EC File Offset: 0x002E46EC
		private void EnsureHotEntryUnlockCondCacheIfNeeded()
		{
			if (this.HotEntryUnlockCondCache != null)
			{
				return;
			}
			this.HotEntryUnlockCondCache = this.HotEntryUnlockCondIter().ToFrozenDictionary((DicIntIntArray kvp) => kvp.Key, (DicIntIntArray kvp) => kvp.Value.Value, null);
		}

		// Token: 0x0600BFB3 RID: 49075 RVA: 0x002E6554 File Offset: 0x002E4754
		private void EnsureUnlockTipsCacheIfNeeded()
		{
			if (this.UnlockTipsCache != null)
			{
				return;
			}
			this.UnlockTipsCache = this.UnlockTipsIter().ToFrozenDictionary((DicIntString kvp) => kvp.Key, (DicIntString kvp) => kvp.Value, null);
		}

		// Token: 0x0600BFB4 RID: 49076 RVA: 0x002E65BA File Offset: 0x002E47BA
		[NullableContext(2)]
		public FrozenDictionary<int, IntArray> GetHotEntryUnlockCondFrozenDict(int key)
		{
			this.EnsureHotEntryUnlockCondCacheIfNeeded();
			return this.HotEntryUnlockCondCache;
		}

		// Token: 0x0600BFB5 RID: 49077 RVA: 0x002E65C8 File Offset: 0x002E47C8
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public FrozenDictionary<int, string> GetUnlockTipsFrozenDict(int key)
		{
			this.EnsureUnlockTipsCacheIfNeeded();
			return this.UnlockTipsCache;
		}

		// Token: 0x040050C2 RID: 20674
		private Table __p;

		// Token: 0x040050C3 RID: 20675
		[Nullable(2)]
		private FrozenDictionary<int, IntArray> HotEntryUnlockCondCache;

		// Token: 0x040050C4 RID: 20676
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private FrozenDictionary<int, string> UnlockTipsCache;
	}
}
