using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DDC RID: 3548
	public struct LongShanTask : IFlatbufferObject
	{
		// Token: 0x17001D67 RID: 7527
		// (get) Token: 0x06008F8B RID: 36747 RVA: 0x0027B0A9 File Offset: 0x002792A9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008F8C RID: 36748 RVA: 0x0027B0B6 File Offset: 0x002792B6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008F8D RID: 36749 RVA: 0x0027B0C0 File Offset: 0x002792C0
		public static LongShanTask GetRootAsLongShanTask(ByteBuffer _bb)
		{
			return LongShanTask.GetRootAsLongShanTask(_bb, default(LongShanTask));
		}

		// Token: 0x06008F8E RID: 36750 RVA: 0x0027B0DC File Offset: 0x002792DC
		public static LongShanTask GetRootAsLongShanTask(ByteBuffer _bb, LongShanTask obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008F8F RID: 36751 RVA: 0x0027B0F9 File Offset: 0x002792F9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008F90 RID: 36752 RVA: 0x0027B108 File Offset: 0x00279308
		public LongShanTask __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001D68 RID: 7528
		// (get) Token: 0x06008F91 RID: 36753 RVA: 0x0027B118 File Offset: 0x00279318
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

		// Token: 0x17001D69 RID: 7529
		// (get) Token: 0x06008F92 RID: 36754 RVA: 0x0027B154 File Offset: 0x00279354
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

		// Token: 0x17001D6A RID: 7530
		// (get) Token: 0x06008F93 RID: 36755 RVA: 0x0027B190 File Offset: 0x00279390
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

		// Token: 0x06008F94 RID: 36756 RVA: 0x0027B1C7 File Offset: 0x002793C7
		public Span<byte> GetTaskNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06008F95 RID: 36757 RVA: 0x0027B1D6 File Offset: 0x002793D6
		public byte[] GetTaskNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17001D6B RID: 7531
		// (get) Token: 0x06008F96 RID: 36758 RVA: 0x0027B1F0 File Offset: 0x002793F0
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

		// Token: 0x06008F97 RID: 36759 RVA: 0x0027B230 File Offset: 0x00279430
		public DicIntInt? TaskReward(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17001D6C RID: 7532
		// (get) Token: 0x06008F98 RID: 36760 RVA: 0x0027B294 File Offset: 0x00279494
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

		// Token: 0x17001D6D RID: 7533
		// (get) Token: 0x06008F99 RID: 36761 RVA: 0x0027B2C0 File Offset: 0x002794C0
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

		// Token: 0x06008F9A RID: 36762 RVA: 0x0027B300 File Offset: 0x00279500
		[NullableContext(1)]
		[Obsolete("已废弃，请使用TaskRewardFrozenDict()缓存字典，遍历请使用TaskRewardIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> TaskReward()
		{
			return this.TaskRewardIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x06008F9B RID: 36763 RVA: 0x0027B356 File Offset: 0x00279556
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> TaskRewardIter()
		{
			LongShanTask.<TaskRewardIter>d__24 <TaskRewardIter>d__ = new LongShanTask.<TaskRewardIter>d__24(-2);
			<TaskRewardIter>d__.<>3__<>4__this = this;
			return <TaskRewardIter>d__;
		}

		// Token: 0x06008F9C RID: 36764 RVA: 0x0027B36C File Offset: 0x0027956C
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

		// Token: 0x06008F9D RID: 36765 RVA: 0x0027B3A0 File Offset: 0x002795A0
		private void EnsureTaskRewardCacheIfNeeded()
		{
			if (this.TaskRewardCache != null)
			{
				return;
			}
			this.TaskRewardCache = this.TaskRewardIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x06008F9E RID: 36766 RVA: 0x0027B406 File Offset: 0x00279606
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetTaskRewardFrozenDict(int key)
		{
			this.EnsureTaskRewardCacheIfNeeded();
			return this.TaskRewardCache;
		}

		// Token: 0x04004E77 RID: 20087
		private Table __p;

		// Token: 0x04004E78 RID: 20088
		[Nullable(2)]
		private FrozenDictionary<int, int> TaskRewardCache;
	}
}
