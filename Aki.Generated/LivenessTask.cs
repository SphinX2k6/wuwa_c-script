using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DD4 RID: 3540
	public struct LivenessTask : IFlatbufferObject
	{
		// Token: 0x17001D2B RID: 7467
		// (get) Token: 0x06008EF7 RID: 36599 RVA: 0x00279B28 File Offset: 0x00277D28
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008EF8 RID: 36600 RVA: 0x00279B35 File Offset: 0x00277D35
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008EF9 RID: 36601 RVA: 0x00279B3C File Offset: 0x00277D3C
		public static LivenessTask GetRootAsLivenessTask(ByteBuffer _bb)
		{
			return LivenessTask.GetRootAsLivenessTask(_bb, default(LivenessTask));
		}

		// Token: 0x06008EFA RID: 36602 RVA: 0x00279B58 File Offset: 0x00277D58
		public static LivenessTask GetRootAsLivenessTask(ByteBuffer _bb, LivenessTask obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008EFB RID: 36603 RVA: 0x00279B75 File Offset: 0x00277D75
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008EFC RID: 36604 RVA: 0x00279B84 File Offset: 0x00277D84
		public LivenessTask __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001D2C RID: 7468
		// (get) Token: 0x06008EFD RID: 36605 RVA: 0x00279B94 File Offset: 0x00277D94
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

		// Token: 0x17001D2D RID: 7469
		// (get) Token: 0x06008EFE RID: 36606 RVA: 0x00279BD0 File Offset: 0x00277DD0
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

		// Token: 0x06008EFF RID: 36607 RVA: 0x00279C07 File Offset: 0x00277E07
		public Span<byte> GetTaskNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06008F00 RID: 36608 RVA: 0x00279C16 File Offset: 0x00277E16
		public byte[] GetTaskNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17001D2E RID: 7470
		// (get) Token: 0x06008F01 RID: 36609 RVA: 0x00279C30 File Offset: 0x00277E30
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

		// Token: 0x06008F02 RID: 36610 RVA: 0x00279C6C File Offset: 0x00277E6C
		public DicIntInt? TaskReward(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17001D2F RID: 7471
		// (get) Token: 0x06008F03 RID: 36611 RVA: 0x00279CD0 File Offset: 0x00277ED0
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

		// Token: 0x06008F04 RID: 36612 RVA: 0x00279CFC File Offset: 0x00277EFC
		public string TaskFunc(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001D30 RID: 7472
		// (get) Token: 0x06008F05 RID: 36613 RVA: 0x00279D38 File Offset: 0x00277F38
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

		// Token: 0x17001D31 RID: 7473
		// (get) Token: 0x06008F06 RID: 36614 RVA: 0x00279D64 File Offset: 0x00277F64
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

		// Token: 0x17001D32 RID: 7474
		// (get) Token: 0x06008F07 RID: 36615 RVA: 0x00279DA4 File Offset: 0x00277FA4
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

		// Token: 0x17001D33 RID: 7475
		// (get) Token: 0x06008F08 RID: 36616 RVA: 0x00279DE4 File Offset: 0x00277FE4
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

		// Token: 0x06008F09 RID: 36617 RVA: 0x00279E21 File Offset: 0x00278021
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用TaskFuncIter()或GetTaskFuncBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] TaskFunc()
		{
			return this.TaskFuncIter().ToArray<string>();
		}

		// Token: 0x06008F0A RID: 36618 RVA: 0x00279E2E File Offset: 0x0027802E
		[NullableContext(1)]
		public readonly IEnumerable<string> TaskFuncIter()
		{
			LivenessTask.<TaskFuncIter>d__29 <TaskFuncIter>d__ = new LivenessTask.<TaskFuncIter>d__29(-2);
			<TaskFuncIter>d__.<>3__<>4__this = this;
			return <TaskFuncIter>d__;
		}

		// Token: 0x06008F0B RID: 36619 RVA: 0x00279E44 File Offset: 0x00278044
		[NullableContext(1)]
		[Obsolete("已废弃，请使用TaskRewardFrozenDict()缓存字典，遍历请使用TaskRewardIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> TaskReward()
		{
			return this.TaskRewardIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x06008F0C RID: 36620 RVA: 0x00279E9A File Offset: 0x0027809A
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> TaskRewardIter()
		{
			LivenessTask.<TaskRewardIter>d__31 <TaskRewardIter>d__ = new LivenessTask.<TaskRewardIter>d__31(-2);
			<TaskRewardIter>d__.<>3__<>4__this = this;
			return <TaskRewardIter>d__;
		}

		// Token: 0x06008F0D RID: 36621 RVA: 0x00279EB0 File Offset: 0x002780B0
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

		// Token: 0x06008F0E RID: 36622 RVA: 0x00279EE4 File Offset: 0x002780E4
		private void EnsureTaskRewardCacheIfNeeded()
		{
			if (this.TaskRewardCache != null)
			{
				return;
			}
			this.TaskRewardCache = this.TaskRewardIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x06008F0F RID: 36623 RVA: 0x00279F4A File Offset: 0x0027814A
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetTaskRewardFrozenDict(int key)
		{
			this.EnsureTaskRewardCacheIfNeeded();
			return this.TaskRewardCache;
		}

		// Token: 0x04004E6E RID: 20078
		private Table __p;

		// Token: 0x04004E6F RID: 20079
		[Nullable(2)]
		private FrozenDictionary<int, int> TaskRewardCache;
	}
}
