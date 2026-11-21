using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CEE RID: 3310
	public struct DropCatchDropPool : IFlatbufferObject
	{
		// Token: 0x17000DFC RID: 3580
		// (get) Token: 0x06006B2F RID: 27439 RVA: 0x00239F82 File Offset: 0x00238182
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006B30 RID: 27440 RVA: 0x00239F8F File Offset: 0x0023818F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006B31 RID: 27441 RVA: 0x00239F98 File Offset: 0x00238198
		public static DropCatchDropPool GetRootAsDropCatchDropPool(ByteBuffer _bb)
		{
			return DropCatchDropPool.GetRootAsDropCatchDropPool(_bb, default(DropCatchDropPool));
		}

		// Token: 0x06006B32 RID: 27442 RVA: 0x00239FB4 File Offset: 0x002381B4
		public static DropCatchDropPool GetRootAsDropCatchDropPool(ByteBuffer _bb, DropCatchDropPool obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006B33 RID: 27443 RVA: 0x00239FD1 File Offset: 0x002381D1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006B34 RID: 27444 RVA: 0x00239FE0 File Offset: 0x002381E0
		public DropCatchDropPool __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000DFD RID: 3581
		// (get) Token: 0x06006B35 RID: 27445 RVA: 0x00239FF0 File Offset: 0x002381F0
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

		// Token: 0x06006B36 RID: 27446 RVA: 0x0023A02C File Offset: 0x0023822C
		public DicIntInt? DropItemList(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17000DFE RID: 3582
		// (get) Token: 0x06006B37 RID: 27447 RVA: 0x0023A08C File Offset: 0x0023828C
		public int DropItemListLength
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

		// Token: 0x17000DFF RID: 3583
		// (get) Token: 0x06006B38 RID: 27448 RVA: 0x0023A0B8 File Offset: 0x002382B8
		public float DropInitPosX
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 9999f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000E00 RID: 3584
		// (get) Token: 0x06006B39 RID: 27449 RVA: 0x0023A0F8 File Offset: 0x002382F8
		public float DropTimeInterval
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000E01 RID: 3585
		// (get) Token: 0x06006B3A RID: 27450 RVA: 0x0023A13C File Offset: 0x0023833C
		public float DropPosInterval
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06006B3B RID: 27451 RVA: 0x0023A180 File Offset: 0x00238380
		public float TimeRange(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000E02 RID: 3586
		// (get) Token: 0x06006B3C RID: 27452 RVA: 0x0023A1C4 File Offset: 0x002383C4
		public int TimeRangeLength
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

		// Token: 0x06006B3D RID: 27453 RVA: 0x0023A1F0 File Offset: 0x002383F0
		public Span<float> GetTimeRangeBytes()
		{
			return this.__p.__vector_as_span<float>(14, 4);
		}

		// Token: 0x06006B3E RID: 27454 RVA: 0x0023A200 File Offset: 0x00238400
		public float[] GetTimeRangeArray()
		{
			return this.__p.__vector_as_array<float>(14) ?? Array.Empty<float>();
		}

		// Token: 0x06006B3F RID: 27455 RVA: 0x0023A218 File Offset: 0x00238418
		[NullableContext(1)]
		public Dictionary<int, int> DropItemList()
		{
			return this.DropItemListIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x06006B40 RID: 27456 RVA: 0x0023A26E File Offset: 0x0023846E
		[NullableContext(1)]
		public IEnumerable<DicIntInt> DropItemListIter()
		{
			DropCatchDropPool.<DropItemListIter>d__25 <DropItemListIter>d__ = new DropCatchDropPool.<DropItemListIter>d__25(-2);
			<DropItemListIter>d__.<>3__<>4__this = this;
			return <DropItemListIter>d__;
		}

		// Token: 0x06006B41 RID: 27457 RVA: 0x0023A283 File Offset: 0x00238483
		[NullableContext(1)]
		public float[] TimeRange()
		{
			return this.GetTimeRangeArray();
		}

		// Token: 0x06006B42 RID: 27458 RVA: 0x0023A28B File Offset: 0x0023848B
		[NullableContext(1)]
		public IEnumerable<float> TimeRangeIter()
		{
			DropCatchDropPool.<TimeRangeIter>d__27 <TimeRangeIter>d__ = new DropCatchDropPool.<TimeRangeIter>d__27(-2);
			<TimeRangeIter>d__.<>3__<>4__this = this;
			return <TimeRangeIter>d__;
		}

		// Token: 0x06006B43 RID: 27459 RVA: 0x0023A2A0 File Offset: 0x002384A0
		public int? GetDropItemList(int key)
		{
			this.EnsureDropItemListCacheIfNeeded();
			int value;
			if (!this.DropItemListCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x06006B44 RID: 27460 RVA: 0x0023A2D4 File Offset: 0x002384D4
		private void EnsureDropItemListCacheIfNeeded()
		{
			if (this.DropItemListCache != null)
			{
				return;
			}
			this.DropItemListCache = this.DropItemListIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x06006B45 RID: 27461 RVA: 0x0023A33A File Offset: 0x0023853A
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetDropItemListFrozenDict()
		{
			this.EnsureDropItemListCacheIfNeeded();
			return this.DropItemListCache;
		}

		// Token: 0x0400522A RID: 21034
		private Table __p;

		// Token: 0x0400522B RID: 21035
		[Nullable(2)]
		private FrozenDictionary<int, int> DropItemListCache;
	}
}
