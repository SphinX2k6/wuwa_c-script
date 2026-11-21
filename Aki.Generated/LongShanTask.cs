using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000EC1 RID: 3777
	public struct LongShanTask : IFlatbufferObject
	{
		// Token: 0x17001DCB RID: 7627
		// (get) Token: 0x060095A7 RID: 38311 RVA: 0x002993E1 File Offset: 0x002975E1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060095A8 RID: 38312 RVA: 0x002993EE File Offset: 0x002975EE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060095A9 RID: 38313 RVA: 0x002993F8 File Offset: 0x002975F8
		public static LongShanTask GetRootAsLongShanTask(ByteBuffer _bb)
		{
			return LongShanTask.GetRootAsLongShanTask(_bb, default(LongShanTask));
		}

		// Token: 0x060095AA RID: 38314 RVA: 0x00299414 File Offset: 0x00297614
		public static LongShanTask GetRootAsLongShanTask(ByteBuffer _bb, LongShanTask obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060095AB RID: 38315 RVA: 0x00299431 File Offset: 0x00297631
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060095AC RID: 38316 RVA: 0x00299440 File Offset: 0x00297640
		public LongShanTask __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001DCC RID: 7628
		// (get) Token: 0x060095AD RID: 38317 RVA: 0x00299450 File Offset: 0x00297650
		public int TaskId
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

		// Token: 0x17001DCD RID: 7629
		// (get) Token: 0x060095AE RID: 38318 RVA: 0x0029948C File Offset: 0x0029768C
		public int StageId
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

		// Token: 0x17001DCE RID: 7630
		// (get) Token: 0x060095AF RID: 38319 RVA: 0x002994C8 File Offset: 0x002976C8
		public string TaskName
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060095B0 RID: 38320 RVA: 0x002994FF File Offset: 0x002976FF
		public Span<byte> GetTaskNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060095B1 RID: 38321 RVA: 0x0029950E File Offset: 0x0029770E
		public byte[] GetTaskNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17001DCF RID: 7631
		// (get) Token: 0x060095B2 RID: 38322 RVA: 0x00299528 File Offset: 0x00297728
		public int SortId
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

		// Token: 0x060095B3 RID: 38323 RVA: 0x00299568 File Offset: 0x00297768
		public DicIntInt? TaskReward(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17001DD0 RID: 7632
		// (get) Token: 0x060095B4 RID: 38324 RVA: 0x002995CC File Offset: 0x002977CC
		public int TaskRewardLength
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

		// Token: 0x17001DD1 RID: 7633
		// (get) Token: 0x060095B5 RID: 38325 RVA: 0x002995F8 File Offset: 0x002977F8
		public int JumpId
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

		// Token: 0x060095B6 RID: 38326 RVA: 0x00299638 File Offset: 0x00297838
		[NullableContext(1)]
		public Dictionary<int, int> TaskReward()
		{
			return this.TaskRewardIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x060095B7 RID: 38327 RVA: 0x0029968E File Offset: 0x0029788E
		[NullableContext(1)]
		public IEnumerable<DicIntInt> TaskRewardIter()
		{
			LongShanTask.<TaskRewardIter>d__24 <TaskRewardIter>d__ = new LongShanTask.<TaskRewardIter>d__24(-2);
			<TaskRewardIter>d__.<>3__<>4__this = this;
			return <TaskRewardIter>d__;
		}

		// Token: 0x060095B8 RID: 38328 RVA: 0x002996A4 File Offset: 0x002978A4
		public int? GetTaskReward(int key)
		{
			this.EnsureTaskRewardCacheIfNeeded();
			int value;
			if (!this.TaskRewardCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x060095B9 RID: 38329 RVA: 0x002996D8 File Offset: 0x002978D8
		private void EnsureTaskRewardCacheIfNeeded()
		{
			if (this.TaskRewardCache != null)
			{
				return;
			}
			this.TaskRewardCache = this.TaskRewardIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x060095BA RID: 38330 RVA: 0x0029973E File Offset: 0x0029793E
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetTaskRewardFrozenDict()
		{
			this.EnsureTaskRewardCacheIfNeeded();
			return this.TaskRewardCache;
		}

		// Token: 0x0400545C RID: 21596
		private Table __p;

		// Token: 0x0400545D RID: 21597
		[Nullable(2)]
		private FrozenDictionary<int, int> TaskRewardCache;
	}
}
