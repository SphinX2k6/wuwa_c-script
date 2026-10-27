using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000EF5 RID: 3829
	public struct PhantomQuality : IFlatbufferObject
	{
		// Token: 0x1700273B RID: 10043
		// (get) Token: 0x0600A9E9 RID: 43497 RVA: 0x002B6309 File Offset: 0x002B4509
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A9EA RID: 43498 RVA: 0x002B6316 File Offset: 0x002B4516
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A9EB RID: 43499 RVA: 0x002B6320 File Offset: 0x002B4520
		public static PhantomQuality GetRootAsPhantomQuality(ByteBuffer _bb)
		{
			return PhantomQuality.GetRootAsPhantomQuality(_bb, default(PhantomQuality));
		}

		// Token: 0x0600A9EC RID: 43500 RVA: 0x002B633C File Offset: 0x002B453C
		public static PhantomQuality GetRootAsPhantomQuality(ByteBuffer _bb, PhantomQuality obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A9ED RID: 43501 RVA: 0x002B6359 File Offset: 0x002B4559
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A9EE RID: 43502 RVA: 0x002B6368 File Offset: 0x002B4568
		public PhantomQuality __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700273C RID: 10044
		// (get) Token: 0x0600A9EF RID: 43503 RVA: 0x002B6378 File Offset: 0x002B4578
		public int Quality
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

		// Token: 0x1700273D RID: 10045
		// (get) Token: 0x0600A9F0 RID: 43504 RVA: 0x002B63B4 File Offset: 0x002B45B4
		public int LevelLimit
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

		// Token: 0x0600A9F1 RID: 43505 RVA: 0x002B63F0 File Offset: 0x002B45F0
		public int SlotUnlockLevel(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700273E RID: 10046
		// (get) Token: 0x0600A9F2 RID: 43506 RVA: 0x002B6430 File Offset: 0x002B4630
		public int SlotUnlockLevelLength
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

		// Token: 0x0600A9F3 RID: 43507 RVA: 0x002B645B File Offset: 0x002B465B
		public Span<int> GetSlotUnlockLevelBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x0600A9F4 RID: 43508 RVA: 0x002B646A File Offset: 0x002B466A
		public int[] GetSlotUnlockLevelArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x0600A9F5 RID: 43509 RVA: 0x002B6484 File Offset: 0x002B4684
		public DicIntInt? IdentifyCost(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700273F RID: 10047
		// (get) Token: 0x0600A9F6 RID: 43510 RVA: 0x002B64E8 File Offset: 0x002B46E8
		public int IdentifyCostLength
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

		// Token: 0x17002740 RID: 10048
		// (get) Token: 0x0600A9F7 RID: 43511 RVA: 0x002B6514 File Offset: 0x002B4714
		public int IdentifyCoin
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

		// Token: 0x17002741 RID: 10049
		// (get) Token: 0x0600A9F8 RID: 43512 RVA: 0x002B6554 File Offset: 0x002B4754
		public string QualitySprite
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600A9F9 RID: 43513 RVA: 0x002B658C File Offset: 0x002B478C
		public Span<byte> GetQualitySpriteBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600A9FA RID: 43514 RVA: 0x002B659C File Offset: 0x002B479C
		public byte[] GetQualitySpriteArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x0600A9FB RID: 43515 RVA: 0x002B65B4 File Offset: 0x002B47B4
		[NullableContext(1)]
		[Obsolete("已废弃，请使用IdentifyCostFrozenDict()缓存字典，遍历请使用IdentifyCostIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> IdentifyCost()
		{
			return this.IdentifyCostIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600A9FC RID: 43516 RVA: 0x002B660A File Offset: 0x002B480A
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> IdentifyCostIter()
		{
			PhantomQuality.<IdentifyCostIter>d__27 <IdentifyCostIter>d__ = new PhantomQuality.<IdentifyCostIter>d__27(-2);
			<IdentifyCostIter>d__.<>3__<>4__this = this;
			return <IdentifyCostIter>d__;
		}

		// Token: 0x0600A9FD RID: 43517 RVA: 0x002B6620 File Offset: 0x002B4820
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用SlotUnlockLevelIter()或GetSlotUnlockLevelBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] SlotUnlockLevel()
		{
			PhantomQuality phantomQuality = this;
			return phantomQuality.GetSlotUnlockLevelArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600A9FE RID: 43518 RVA: 0x002B6644 File Offset: 0x002B4844
		[NullableContext(1)]
		public readonly IEnumerable<int> SlotUnlockLevelIter()
		{
			PhantomQuality.<SlotUnlockLevelIter>d__29 <SlotUnlockLevelIter>d__ = new PhantomQuality.<SlotUnlockLevelIter>d__29(-2);
			<SlotUnlockLevelIter>d__.<>3__<>4__this = this;
			return <SlotUnlockLevelIter>d__;
		}

		// Token: 0x0600A9FF RID: 43519 RVA: 0x002B665C File Offset: 0x002B485C
		public int? GetIdentifyCost(int key)
		{
			this.EnsureIdentifyCostCacheIfNeeded();
			int value;
			if (!this.IdentifyCostCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x0600AA00 RID: 43520 RVA: 0x002B6690 File Offset: 0x002B4890
		private void EnsureIdentifyCostCacheIfNeeded()
		{
			if (this.IdentifyCostCache != null)
			{
				return;
			}
			this.IdentifyCostCache = this.IdentifyCostIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600AA01 RID: 43521 RVA: 0x002B66F6 File Offset: 0x002B48F6
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetIdentifyCostFrozenDict(int key)
		{
			this.EnsureIdentifyCostCacheIfNeeded();
			return this.IdentifyCostCache;
		}

		// Token: 0x04004FBA RID: 20410
		private Table __p;

		// Token: 0x04004FBB RID: 20411
		[Nullable(2)]
		private FrozenDictionary<int, int> IdentifyCostCache;
	}
}
