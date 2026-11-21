using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F1C RID: 3868
	public struct MotorDevelopTask : IFlatbufferObject
	{
		// Token: 0x170020BD RID: 8381
		// (get) Token: 0x06009D9A RID: 40346 RVA: 0x002AA728 File Offset: 0x002A8928
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009D9B RID: 40347 RVA: 0x002AA735 File Offset: 0x002A8935
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009D9C RID: 40348 RVA: 0x002AA73C File Offset: 0x002A893C
		public static MotorDevelopTask GetRootAsMotorDevelopTask(ByteBuffer _bb)
		{
			return MotorDevelopTask.GetRootAsMotorDevelopTask(_bb, default(MotorDevelopTask));
		}

		// Token: 0x06009D9D RID: 40349 RVA: 0x002AA758 File Offset: 0x002A8958
		public static MotorDevelopTask GetRootAsMotorDevelopTask(ByteBuffer _bb, MotorDevelopTask obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009D9E RID: 40350 RVA: 0x002AA775 File Offset: 0x002A8975
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009D9F RID: 40351 RVA: 0x002AA784 File Offset: 0x002A8984
		public MotorDevelopTask __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170020BE RID: 8382
		// (get) Token: 0x06009DA0 RID: 40352 RVA: 0x002AA794 File Offset: 0x002A8994
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

		// Token: 0x170020BF RID: 8383
		// (get) Token: 0x06009DA1 RID: 40353 RVA: 0x002AA7D0 File Offset: 0x002A89D0
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

		// Token: 0x170020C0 RID: 8384
		// (get) Token: 0x06009DA2 RID: 40354 RVA: 0x002AA80C File Offset: 0x002A8A0C
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

		// Token: 0x06009DA3 RID: 40355 RVA: 0x002AA843 File Offset: 0x002A8A43
		public Span<byte> GetTaskNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06009DA4 RID: 40356 RVA: 0x002AA852 File Offset: 0x002A8A52
		public byte[] GetTaskNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x06009DA5 RID: 40357 RVA: 0x002AA86C File Offset: 0x002A8A6C
		public DicIntInt? TaskReward(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170020C1 RID: 8385
		// (get) Token: 0x06009DA6 RID: 40358 RVA: 0x002AA8D0 File Offset: 0x002A8AD0
		public int TaskRewardLength
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

		// Token: 0x06009DA7 RID: 40359 RVA: 0x002AA8FC File Offset: 0x002A8AFC
		public DicIntInt? TaskRewardShow(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170020C2 RID: 8386
		// (get) Token: 0x06009DA8 RID: 40360 RVA: 0x002AA960 File Offset: 0x002A8B60
		public int TaskRewardShowLength
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

		// Token: 0x06009DA9 RID: 40361 RVA: 0x002AA98C File Offset: 0x002A8B8C
		[NullableContext(1)]
		public Dictionary<int, int> TaskReward()
		{
			return this.TaskRewardIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x06009DAA RID: 40362 RVA: 0x002AA9E2 File Offset: 0x002A8BE2
		[NullableContext(1)]
		public IEnumerable<DicIntInt> TaskRewardIter()
		{
			MotorDevelopTask.<TaskRewardIter>d__23 <TaskRewardIter>d__ = new MotorDevelopTask.<TaskRewardIter>d__23(-2);
			<TaskRewardIter>d__.<>3__<>4__this = this;
			return <TaskRewardIter>d__;
		}

		// Token: 0x06009DAB RID: 40363 RVA: 0x002AA9F8 File Offset: 0x002A8BF8
		[NullableContext(1)]
		public Dictionary<int, int> TaskRewardShow()
		{
			return this.TaskRewardShowIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x06009DAC RID: 40364 RVA: 0x002AAA4E File Offset: 0x002A8C4E
		[NullableContext(1)]
		public IEnumerable<DicIntInt> TaskRewardShowIter()
		{
			MotorDevelopTask.<TaskRewardShowIter>d__25 <TaskRewardShowIter>d__ = new MotorDevelopTask.<TaskRewardShowIter>d__25(-2);
			<TaskRewardShowIter>d__.<>3__<>4__this = this;
			return <TaskRewardShowIter>d__;
		}

		// Token: 0x06009DAD RID: 40365 RVA: 0x002AAA64 File Offset: 0x002A8C64
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

		// Token: 0x06009DAE RID: 40366 RVA: 0x002AAA98 File Offset: 0x002A8C98
		public int? GetTaskRewardShow(int key)
		{
			this.EnsureTaskRewardShowCacheIfNeeded();
			int value;
			if (!this.TaskRewardShowCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x06009DAF RID: 40367 RVA: 0x002AAACC File Offset: 0x002A8CCC
		private void EnsureTaskRewardCacheIfNeeded()
		{
			if (this.TaskRewardCache != null)
			{
				return;
			}
			this.TaskRewardCache = this.TaskRewardIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x06009DB0 RID: 40368 RVA: 0x002AAB34 File Offset: 0x002A8D34
		private void EnsureTaskRewardShowCacheIfNeeded()
		{
			if (this.TaskRewardShowCache != null)
			{
				return;
			}
			this.TaskRewardShowCache = this.TaskRewardShowIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x06009DB1 RID: 40369 RVA: 0x002AAB9A File Offset: 0x002A8D9A
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetTaskRewardFrozenDict()
		{
			this.EnsureTaskRewardCacheIfNeeded();
			return this.TaskRewardCache;
		}

		// Token: 0x06009DB2 RID: 40370 RVA: 0x002AABA8 File Offset: 0x002A8DA8
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetTaskRewardShowFrozenDict()
		{
			this.EnsureTaskRewardShowCacheIfNeeded();
			return this.TaskRewardShowCache;
		}

		// Token: 0x040054C2 RID: 21698
		private Table __p;

		// Token: 0x040054C3 RID: 21699
		[Nullable(2)]
		private FrozenDictionary<int, int> TaskRewardCache;

		// Token: 0x040054C4 RID: 21700
		[Nullable(2)]
		private FrozenDictionary<int, int> TaskRewardShowCache;
	}
}
