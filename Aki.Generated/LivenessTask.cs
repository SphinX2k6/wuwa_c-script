using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000EB9 RID: 3769
	public struct LivenessTask : IFlatbufferObject
	{
		// Token: 0x17001D8F RID: 7567
		// (get) Token: 0x06009513 RID: 38163 RVA: 0x00297F00 File Offset: 0x00296100
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009514 RID: 38164 RVA: 0x00297F0D File Offset: 0x0029610D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009515 RID: 38165 RVA: 0x00297F14 File Offset: 0x00296114
		public static LivenessTask GetRootAsLivenessTask(ByteBuffer _bb)
		{
			return LivenessTask.GetRootAsLivenessTask(_bb, default(LivenessTask));
		}

		// Token: 0x06009516 RID: 38166 RVA: 0x00297F30 File Offset: 0x00296130
		public static LivenessTask GetRootAsLivenessTask(ByteBuffer _bb, LivenessTask obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009517 RID: 38167 RVA: 0x00297F4D File Offset: 0x0029614D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009518 RID: 38168 RVA: 0x00297F5C File Offset: 0x0029615C
		public LivenessTask __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001D90 RID: 7568
		// (get) Token: 0x06009519 RID: 38169 RVA: 0x00297F6C File Offset: 0x0029616C
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

		// Token: 0x17001D91 RID: 7569
		// (get) Token: 0x0600951A RID: 38170 RVA: 0x00297FA8 File Offset: 0x002961A8
		public string TaskName
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

		// Token: 0x0600951B RID: 38171 RVA: 0x00297FDF File Offset: 0x002961DF
		public Span<byte> GetTaskNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600951C RID: 38172 RVA: 0x00297FEE File Offset: 0x002961EE
		public byte[] GetTaskNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17001D92 RID: 7570
		// (get) Token: 0x0600951D RID: 38173 RVA: 0x00298008 File Offset: 0x00296208
		public int UpdateType
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

		// Token: 0x0600951E RID: 38174 RVA: 0x00298044 File Offset: 0x00296244
		public DicIntInt? TaskReward(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17001D93 RID: 7571
		// (get) Token: 0x0600951F RID: 38175 RVA: 0x002980A8 File Offset: 0x002962A8
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

		// Token: 0x06009520 RID: 38176 RVA: 0x002980D4 File Offset: 0x002962D4
		public string TaskFunc(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001D94 RID: 7572
		// (get) Token: 0x06009521 RID: 38177 RVA: 0x00298110 File Offset: 0x00296310
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

		// Token: 0x17001D95 RID: 7573
		// (get) Token: 0x06009522 RID: 38178 RVA: 0x0029813C File Offset: 0x0029633C
		public int UnlockCondition
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

		// Token: 0x17001D96 RID: 7574
		// (get) Token: 0x06009523 RID: 38179 RVA: 0x0029817C File Offset: 0x0029637C
		public int SortRank
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

		// Token: 0x17001D97 RID: 7575
		// (get) Token: 0x06009524 RID: 38180 RVA: 0x002981BC File Offset: 0x002963BC
		public int AccessId
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

		// Token: 0x06009525 RID: 38181 RVA: 0x002981F9 File Offset: 0x002963F9
		[NullableContext(1)]
		public string[] TaskFunc()
		{
			return this.TaskFuncIter().ToArray<string>();
		}

		// Token: 0x06009526 RID: 38182 RVA: 0x00298206 File Offset: 0x00296406
		[NullableContext(1)]
		public IEnumerable<string> TaskFuncIter()
		{
			LivenessTask.<TaskFuncIter>d__29 <TaskFuncIter>d__ = new LivenessTask.<TaskFuncIter>d__29(-2);
			<TaskFuncIter>d__.<>3__<>4__this = this;
			return <TaskFuncIter>d__;
		}

		// Token: 0x06009527 RID: 38183 RVA: 0x0029821C File Offset: 0x0029641C
		[NullableContext(1)]
		public Dictionary<int, int> TaskReward()
		{
			return this.TaskRewardIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x06009528 RID: 38184 RVA: 0x00298272 File Offset: 0x00296472
		[NullableContext(1)]
		public IEnumerable<DicIntInt> TaskRewardIter()
		{
			LivenessTask.<TaskRewardIter>d__31 <TaskRewardIter>d__ = new LivenessTask.<TaskRewardIter>d__31(-2);
			<TaskRewardIter>d__.<>3__<>4__this = this;
			return <TaskRewardIter>d__;
		}

		// Token: 0x06009529 RID: 38185 RVA: 0x00298288 File Offset: 0x00296488
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

		// Token: 0x0600952A RID: 38186 RVA: 0x002982BC File Offset: 0x002964BC
		private void EnsureTaskRewardCacheIfNeeded()
		{
			if (this.TaskRewardCache != null)
			{
				return;
			}
			this.TaskRewardCache = this.TaskRewardIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600952B RID: 38187 RVA: 0x00298322 File Offset: 0x00296522
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetTaskRewardFrozenDict()
		{
			this.EnsureTaskRewardCacheIfNeeded();
			return this.TaskRewardCache;
		}

		// Token: 0x04005453 RID: 21587
		private Table __p;

		// Token: 0x04005454 RID: 21588
		[Nullable(2)]
		private FrozenDictionary<int, int> TaskRewardCache;
	}
}
