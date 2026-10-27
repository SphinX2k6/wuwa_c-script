using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B51 RID: 2897
	public struct BrokenRockRing : IFlatbufferObject
	{
		// Token: 0x17000615 RID: 1557
		// (get) Token: 0x06004FDA RID: 20442 RVA: 0x001E91CD File Offset: 0x001E73CD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004FDB RID: 20443 RVA: 0x001E91DA File Offset: 0x001E73DA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004FDC RID: 20444 RVA: 0x001E91E4 File Offset: 0x001E73E4
		public static BrokenRockRing GetRootAsBrokenRockRing(ByteBuffer _bb)
		{
			return BrokenRockRing.GetRootAsBrokenRockRing(_bb, default(BrokenRockRing));
		}

		// Token: 0x06004FDD RID: 20445 RVA: 0x001E9200 File Offset: 0x001E7400
		public static BrokenRockRing GetRootAsBrokenRockRing(ByteBuffer _bb, BrokenRockRing obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004FDE RID: 20446 RVA: 0x001E921D File Offset: 0x001E741D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004FDF RID: 20447 RVA: 0x001E922C File Offset: 0x001E742C
		public BrokenRockRing __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000616 RID: 1558
		// (get) Token: 0x06004FE0 RID: 20448 RVA: 0x001E923C File Offset: 0x001E743C
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

		// Token: 0x06004FE1 RID: 20449 RVA: 0x001E9278 File Offset: 0x001E7478
		public IntArray? InvalidBox(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IntArray?(default(IntArray).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17000617 RID: 1559
		// (get) Token: 0x06004FE2 RID: 20450 RVA: 0x001E92D8 File Offset: 0x001E74D8
		public int InvalidBoxLength
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

		// Token: 0x06004FE3 RID: 20451 RVA: 0x001E9304 File Offset: 0x001E7504
		public int RandomBox(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000618 RID: 1560
		// (get) Token: 0x06004FE4 RID: 20452 RVA: 0x001E9344 File Offset: 0x001E7544
		public int RandomBoxLength
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

		// Token: 0x06004FE5 RID: 20453 RVA: 0x001E936F File Offset: 0x001E756F
		public Span<int> GetRandomBoxBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x06004FE6 RID: 20454 RVA: 0x001E937E File Offset: 0x001E757E
		public int[] GetRandomBoxArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x17000619 RID: 1561
		// (get) Token: 0x06004FE7 RID: 20455 RVA: 0x001E9398 File Offset: 0x001E7598
		public int PerfectBox
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

		// Token: 0x06004FE8 RID: 20456 RVA: 0x001E93D8 File Offset: 0x001E75D8
		public DicIntInt? BonusRate(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700061A RID: 1562
		// (get) Token: 0x06004FE9 RID: 20457 RVA: 0x001E943C File Offset: 0x001E763C
		public int BonusRateLength
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

		// Token: 0x1700061B RID: 1563
		// (get) Token: 0x06004FEA RID: 20458 RVA: 0x001E9468 File Offset: 0x001E7668
		public int GoodScore
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 10;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700061C RID: 1564
		// (get) Token: 0x06004FEB RID: 20459 RVA: 0x001E94A8 File Offset: 0x001E76A8
		public int PerfectScore
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 30;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700061D RID: 1565
		// (get) Token: 0x06004FEC RID: 20460 RVA: 0x001E94E8 File Offset: 0x001E76E8
		public int BonusScore
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 10;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06004FED RID: 20461 RVA: 0x001E9528 File Offset: 0x001E7728
		public DicIntInt? Speed(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700061E RID: 1566
		// (get) Token: 0x06004FEE RID: 20462 RVA: 0x001E958C File Offset: 0x001E778C
		public int SpeedLength
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

		// Token: 0x1700061F RID: 1567
		// (get) Token: 0x06004FEF RID: 20463 RVA: 0x001E95B8 File Offset: 0x001E77B8
		public int ColdTime
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 500;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000620 RID: 1568
		// (get) Token: 0x06004FF0 RID: 20464 RVA: 0x001E95FC File Offset: 0x001E77FC
		public int MultiBoxGroup
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06004FF1 RID: 20465 RVA: 0x001E963C File Offset: 0x001E783C
		public int Offset(int j)
		{
			int num = this.__p.__offset(26);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000621 RID: 1569
		// (get) Token: 0x06004FF2 RID: 20466 RVA: 0x001E967C File Offset: 0x001E787C
		public int OffsetLength
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

		// Token: 0x06004FF3 RID: 20467 RVA: 0x001E96A8 File Offset: 0x001E78A8
		public Span<int> GetOffsetBytes()
		{
			return this.__p.__vector_as_span<int>(26, 4);
		}

		// Token: 0x06004FF4 RID: 20468 RVA: 0x001E96B8 File Offset: 0x001E78B8
		public int[] GetOffsetArray()
		{
			return this.__p.__vector_as_array<int>(26) ?? Array.Empty<int>();
		}

		// Token: 0x17000622 RID: 1570
		// (get) Token: 0x06004FF5 RID: 20469 RVA: 0x001E96D0 File Offset: 0x001E78D0
		public bool IsAnticlockwise
		{
			get
			{
				int num = this.__p.__offset(28);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06004FF6 RID: 20470 RVA: 0x001E9710 File Offset: 0x001E7910
		[NullableContext(1)]
		[Obsolete("已废弃，请使用BonusRateFrozenDict()缓存字典，遍历请使用BonusRateIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> BonusRate()
		{
			return this.BonusRateIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x06004FF7 RID: 20471 RVA: 0x001E9766 File Offset: 0x001E7966
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> BonusRateIter()
		{
			BrokenRockRing.<BonusRateIter>d__44 <BonusRateIter>d__ = new BrokenRockRing.<BonusRateIter>d__44(-2);
			<BonusRateIter>d__.<>3__<>4__this = this;
			return <BonusRateIter>d__;
		}

		// Token: 0x06004FF8 RID: 20472 RVA: 0x001E977B File Offset: 0x001E797B
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用InvalidBoxIter()或GetInvalidBoxBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly IntArray[] InvalidBox()
		{
			return this.InvalidBoxIter().ToArray<IntArray>();
		}

		// Token: 0x06004FF9 RID: 20473 RVA: 0x001E9788 File Offset: 0x001E7988
		[NullableContext(1)]
		public readonly IEnumerable<IntArray> InvalidBoxIter()
		{
			BrokenRockRing.<InvalidBoxIter>d__46 <InvalidBoxIter>d__ = new BrokenRockRing.<InvalidBoxIter>d__46(-2);
			<InvalidBoxIter>d__.<>3__<>4__this = this;
			return <InvalidBoxIter>d__;
		}

		// Token: 0x06004FFA RID: 20474 RVA: 0x001E97A0 File Offset: 0x001E79A0
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用OffsetIter()或GetOffsetBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] Offset()
		{
			BrokenRockRing brokenRockRing = this;
			return brokenRockRing.GetOffsetArray() ?? Array.Empty<int>();
		}

		// Token: 0x06004FFB RID: 20475 RVA: 0x001E97C4 File Offset: 0x001E79C4
		[NullableContext(1)]
		public readonly IEnumerable<int> OffsetIter()
		{
			BrokenRockRing.<OffsetIter>d__48 <OffsetIter>d__ = new BrokenRockRing.<OffsetIter>d__48(-2);
			<OffsetIter>d__.<>3__<>4__this = this;
			return <OffsetIter>d__;
		}

		// Token: 0x06004FFC RID: 20476 RVA: 0x001E97DC File Offset: 0x001E79DC
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用RandomBoxIter()或GetRandomBoxBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] RandomBox()
		{
			BrokenRockRing brokenRockRing = this;
			return brokenRockRing.GetRandomBoxArray() ?? Array.Empty<int>();
		}

		// Token: 0x06004FFD RID: 20477 RVA: 0x001E9800 File Offset: 0x001E7A00
		[NullableContext(1)]
		public readonly IEnumerable<int> RandomBoxIter()
		{
			BrokenRockRing.<RandomBoxIter>d__50 <RandomBoxIter>d__ = new BrokenRockRing.<RandomBoxIter>d__50(-2);
			<RandomBoxIter>d__.<>3__<>4__this = this;
			return <RandomBoxIter>d__;
		}

		// Token: 0x06004FFE RID: 20478 RVA: 0x001E9818 File Offset: 0x001E7A18
		[NullableContext(1)]
		[Obsolete("已废弃，请使用SpeedFrozenDict()缓存字典，遍历请使用SpeedIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> Speed()
		{
			return this.SpeedIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x06004FFF RID: 20479 RVA: 0x001E986E File Offset: 0x001E7A6E
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> SpeedIter()
		{
			BrokenRockRing.<SpeedIter>d__52 <SpeedIter>d__ = new BrokenRockRing.<SpeedIter>d__52(-2);
			<SpeedIter>d__.<>3__<>4__this = this;
			return <SpeedIter>d__;
		}

		// Token: 0x06005000 RID: 20480 RVA: 0x001E9884 File Offset: 0x001E7A84
		public int? GetBonusRate(int key)
		{
			this.EnsureBonusRateCacheIfNeeded();
			int value;
			if (!this.BonusRateCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x06005001 RID: 20481 RVA: 0x001E98B8 File Offset: 0x001E7AB8
		public int? GetSpeed(int key)
		{
			this.EnsureSpeedCacheIfNeeded();
			int value;
			if (!this.SpeedCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x06005002 RID: 20482 RVA: 0x001E98EC File Offset: 0x001E7AEC
		private void EnsureBonusRateCacheIfNeeded()
		{
			if (this.BonusRateCache != null)
			{
				return;
			}
			this.BonusRateCache = this.BonusRateIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x06005003 RID: 20483 RVA: 0x001E9954 File Offset: 0x001E7B54
		private void EnsureSpeedCacheIfNeeded()
		{
			if (this.SpeedCache != null)
			{
				return;
			}
			this.SpeedCache = this.SpeedIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x06005004 RID: 20484 RVA: 0x001E99BA File Offset: 0x001E7BBA
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetBonusRateFrozenDict(int key)
		{
			this.EnsureBonusRateCacheIfNeeded();
			return this.BonusRateCache;
		}

		// Token: 0x06005005 RID: 20485 RVA: 0x001E99C8 File Offset: 0x001E7BC8
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetSpeedFrozenDict(int key)
		{
			this.EnsureSpeedCacheIfNeeded();
			return this.SpeedCache;
		}

		// Token: 0x04004B4C RID: 19276
		private Table __p;

		// Token: 0x04004B4D RID: 19277
		[Nullable(2)]
		private FrozenDictionary<int, int> BonusRateCache;

		// Token: 0x04004B4E RID: 19278
		[Nullable(2)]
		private FrozenDictionary<int, int> SpeedCache;
	}
}
