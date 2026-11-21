using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200106F RID: 4207
	public struct RacingBetsBulletPool : IFlatbufferObject
	{
		// Token: 0x17002D05 RID: 11525
		// (get) Token: 0x0600BE25 RID: 48677 RVA: 0x002F1678 File Offset: 0x002EF878
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600BE26 RID: 48678 RVA: 0x002F1685 File Offset: 0x002EF885
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600BE27 RID: 48679 RVA: 0x002F168C File Offset: 0x002EF88C
		public static RacingBetsBulletPool GetRootAsRacingBetsBulletPool(ByteBuffer _bb)
		{
			return RacingBetsBulletPool.GetRootAsRacingBetsBulletPool(_bb, default(RacingBetsBulletPool));
		}

		// Token: 0x0600BE28 RID: 48680 RVA: 0x002F16A8 File Offset: 0x002EF8A8
		public static RacingBetsBulletPool GetRootAsRacingBetsBulletPool(ByteBuffer _bb, RacingBetsBulletPool obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600BE29 RID: 48681 RVA: 0x002F16C5 File Offset: 0x002EF8C5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600BE2A RID: 48682 RVA: 0x002F16D4 File Offset: 0x002EF8D4
		public RacingBetsBulletPool __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002D06 RID: 11526
		// (get) Token: 0x0600BE2B RID: 48683 RVA: 0x002F16E4 File Offset: 0x002EF8E4
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

		// Token: 0x17002D07 RID: 11527
		// (get) Token: 0x0600BE2C RID: 48684 RVA: 0x002F1720 File Offset: 0x002EF920
		public int ActivityId
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

		// Token: 0x17002D08 RID: 11528
		// (get) Token: 0x0600BE2D RID: 48685 RVA: 0x002F175C File Offset: 0x002EF95C
		public int Threshold
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

		// Token: 0x0600BE2E RID: 48686 RVA: 0x002F1798 File Offset: 0x002EF998
		public DicIntInt? BulletPool(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17002D09 RID: 11529
		// (get) Token: 0x0600BE2F RID: 48687 RVA: 0x002F17FC File Offset: 0x002EF9FC
		public int BulletPoolLength
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

		// Token: 0x0600BE30 RID: 48688 RVA: 0x002F1828 File Offset: 0x002EFA28
		[NullableContext(1)]
		public Dictionary<int, int> BulletPool()
		{
			return this.BulletPoolIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600BE31 RID: 48689 RVA: 0x002F187E File Offset: 0x002EFA7E
		[NullableContext(1)]
		public IEnumerable<DicIntInt> BulletPoolIter()
		{
			RacingBetsBulletPool.<BulletPoolIter>d__18 <BulletPoolIter>d__ = new RacingBetsBulletPool.<BulletPoolIter>d__18(-2);
			<BulletPoolIter>d__.<>3__<>4__this = this;
			return <BulletPoolIter>d__;
		}

		// Token: 0x0600BE32 RID: 48690 RVA: 0x002F1894 File Offset: 0x002EFA94
		public int? GetBulletPool(int key)
		{
			this.EnsureBulletPoolCacheIfNeeded();
			int value;
			if (!this.BulletPoolCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x0600BE33 RID: 48691 RVA: 0x002F18C8 File Offset: 0x002EFAC8
		private void EnsureBulletPoolCacheIfNeeded()
		{
			if (this.BulletPoolCache != null)
			{
				return;
			}
			this.BulletPoolCache = this.BulletPoolIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600BE34 RID: 48692 RVA: 0x002F192E File Offset: 0x002EFB2E
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetBulletPoolFrozenDict()
		{
			this.EnsureBulletPoolCacheIfNeeded();
			return this.BulletPoolCache;
		}

		// Token: 0x0400563D RID: 22077
		private Table __p;

		// Token: 0x0400563E RID: 22078
		[Nullable(2)]
		private FrozenDictionary<int, int> BulletPoolCache;
	}
}
