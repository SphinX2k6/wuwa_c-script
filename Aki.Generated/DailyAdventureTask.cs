using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C94 RID: 3220
	public struct DailyAdventureTask : IFlatbufferObject
	{
		// Token: 0x17000A47 RID: 2631
		// (get) Token: 0x060060D0 RID: 24784 RVA: 0x00222E60 File Offset: 0x00221060
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060060D1 RID: 24785 RVA: 0x00222E6D File Offset: 0x0022106D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060060D2 RID: 24786 RVA: 0x00222E74 File Offset: 0x00221074
		public static DailyAdventureTask GetRootAsDailyAdventureTask(ByteBuffer _bb)
		{
			return DailyAdventureTask.GetRootAsDailyAdventureTask(_bb, default(DailyAdventureTask));
		}

		// Token: 0x060060D3 RID: 24787 RVA: 0x00222E90 File Offset: 0x00221090
		public static DailyAdventureTask GetRootAsDailyAdventureTask(ByteBuffer _bb, DailyAdventureTask obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060060D4 RID: 24788 RVA: 0x00222EAD File Offset: 0x002210AD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060060D5 RID: 24789 RVA: 0x00222EBC File Offset: 0x002210BC
		public DailyAdventureTask __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000A48 RID: 2632
		// (get) Token: 0x060060D6 RID: 24790 RVA: 0x00222ECC File Offset: 0x002210CC
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

		// Token: 0x17000A49 RID: 2633
		// (get) Token: 0x060060D7 RID: 24791 RVA: 0x00222F08 File Offset: 0x00221108
		public string TaskTitle
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

		// Token: 0x060060D8 RID: 24792 RVA: 0x00222F3F File Offset: 0x0022113F
		public Span<byte> GetTaskTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060060D9 RID: 24793 RVA: 0x00222F4E File Offset: 0x0022114E
		public byte[] GetTaskTitleArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17000A4A RID: 2634
		// (get) Token: 0x060060DA RID: 24794 RVA: 0x00222F68 File Offset: 0x00221168
		public string TaskDescription
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

		// Token: 0x060060DB RID: 24795 RVA: 0x00222F9F File Offset: 0x0022119F
		public Span<byte> GetTaskDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060060DC RID: 24796 RVA: 0x00222FAE File Offset: 0x002211AE
		public byte[] GetTaskDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x060060DD RID: 24797 RVA: 0x00222FC8 File Offset: 0x002211C8
		public DicIntInt? TaskReward(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17000A4B RID: 2635
		// (get) Token: 0x060060DE RID: 24798 RVA: 0x0022302C File Offset: 0x0022122C
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

		// Token: 0x060060DF RID: 24799 RVA: 0x00223058 File Offset: 0x00221258
		public string TaskFunc(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000A4C RID: 2636
		// (get) Token: 0x060060E0 RID: 24800 RVA: 0x00223094 File Offset: 0x00221294
		public int TaskFuncLength
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

		// Token: 0x060060E1 RID: 24801 RVA: 0x002230C0 File Offset: 0x002212C0
		[NullableContext(1)]
		public string[] TaskFunc()
		{
			return this.TaskFuncIter().ToArray<string>();
		}

		// Token: 0x060060E2 RID: 24802 RVA: 0x002230CD File Offset: 0x002212CD
		[NullableContext(1)]
		public IEnumerable<string> TaskFuncIter()
		{
			DailyAdventureTask.<TaskFuncIter>d__25 <TaskFuncIter>d__ = new DailyAdventureTask.<TaskFuncIter>d__25(-2);
			<TaskFuncIter>d__.<>3__<>4__this = this;
			return <TaskFuncIter>d__;
		}

		// Token: 0x060060E3 RID: 24803 RVA: 0x002230E4 File Offset: 0x002212E4
		[NullableContext(1)]
		public Dictionary<int, int> TaskReward()
		{
			return this.TaskRewardIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x060060E4 RID: 24804 RVA: 0x0022313A File Offset: 0x0022133A
		[NullableContext(1)]
		public IEnumerable<DicIntInt> TaskRewardIter()
		{
			DailyAdventureTask.<TaskRewardIter>d__27 <TaskRewardIter>d__ = new DailyAdventureTask.<TaskRewardIter>d__27(-2);
			<TaskRewardIter>d__.<>3__<>4__this = this;
			return <TaskRewardIter>d__;
		}

		// Token: 0x060060E5 RID: 24805 RVA: 0x00223150 File Offset: 0x00221350
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

		// Token: 0x060060E6 RID: 24806 RVA: 0x00223184 File Offset: 0x00221384
		private void EnsureTaskRewardCacheIfNeeded()
		{
			if (this.TaskRewardCache != null)
			{
				return;
			}
			this.TaskRewardCache = this.TaskRewardIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x060060E7 RID: 24807 RVA: 0x002231EA File Offset: 0x002213EA
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetTaskRewardFrozenDict()
		{
			this.EnsureTaskRewardCacheIfNeeded();
			return this.TaskRewardCache;
		}

		// Token: 0x040051B7 RID: 20919
		private Table __p;

		// Token: 0x040051B8 RID: 20920
		[Nullable(2)]
		private FrozenDictionary<int, int> TaskRewardCache;
	}
}
