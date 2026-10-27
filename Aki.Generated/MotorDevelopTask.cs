using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E37 RID: 3639
	public struct MotorDevelopTask : IFlatbufferObject
	{
		// Token: 0x17002058 RID: 8280
		// (get) Token: 0x0600977A RID: 38778 RVA: 0x0028CAA8 File Offset: 0x0028ACA8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600977B RID: 38779 RVA: 0x0028CAB5 File Offset: 0x0028ACB5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600977C RID: 38780 RVA: 0x0028CABC File Offset: 0x0028ACBC
		public static MotorDevelopTask GetRootAsMotorDevelopTask(ByteBuffer _bb)
		{
			return MotorDevelopTask.GetRootAsMotorDevelopTask(_bb, default(MotorDevelopTask));
		}

		// Token: 0x0600977D RID: 38781 RVA: 0x0028CAD8 File Offset: 0x0028ACD8
		public static MotorDevelopTask GetRootAsMotorDevelopTask(ByteBuffer _bb, MotorDevelopTask obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600977E RID: 38782 RVA: 0x0028CAF5 File Offset: 0x0028ACF5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600977F RID: 38783 RVA: 0x0028CB04 File Offset: 0x0028AD04
		public MotorDevelopTask __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002059 RID: 8281
		// (get) Token: 0x06009780 RID: 38784 RVA: 0x0028CB14 File Offset: 0x0028AD14
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

		// Token: 0x1700205A RID: 8282
		// (get) Token: 0x06009781 RID: 38785 RVA: 0x0028CB50 File Offset: 0x0028AD50
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

		// Token: 0x1700205B RID: 8283
		// (get) Token: 0x06009782 RID: 38786 RVA: 0x0028CB8C File Offset: 0x0028AD8C
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

		// Token: 0x06009783 RID: 38787 RVA: 0x0028CBC3 File Offset: 0x0028ADC3
		public Span<byte> GetTaskNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06009784 RID: 38788 RVA: 0x0028CBD2 File Offset: 0x0028ADD2
		public byte[] GetTaskNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x06009785 RID: 38789 RVA: 0x0028CBEC File Offset: 0x0028ADEC
		public DicIntInt? TaskReward(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700205C RID: 8284
		// (get) Token: 0x06009786 RID: 38790 RVA: 0x0028CC50 File Offset: 0x0028AE50
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

		// Token: 0x06009787 RID: 38791 RVA: 0x0028CC7C File Offset: 0x0028AE7C
		public DicIntInt? TaskRewardShow(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700205D RID: 8285
		// (get) Token: 0x06009788 RID: 38792 RVA: 0x0028CCE0 File Offset: 0x0028AEE0
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

		// Token: 0x06009789 RID: 38793 RVA: 0x0028CD0C File Offset: 0x0028AF0C
		[NullableContext(1)]
		[Obsolete("已废弃，请使用TaskRewardFrozenDict()缓存字典，遍历请使用TaskRewardIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> TaskReward()
		{
			return this.TaskRewardIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600978A RID: 38794 RVA: 0x0028CD62 File Offset: 0x0028AF62
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> TaskRewardIter()
		{
			MotorDevelopTask.<TaskRewardIter>d__23 <TaskRewardIter>d__ = new MotorDevelopTask.<TaskRewardIter>d__23(-2);
			<TaskRewardIter>d__.<>3__<>4__this = this;
			return <TaskRewardIter>d__;
		}

		// Token: 0x0600978B RID: 38795 RVA: 0x0028CD78 File Offset: 0x0028AF78
		[NullableContext(1)]
		[Obsolete("已废弃，请使用TaskRewardShowFrozenDict()缓存字典，遍历请使用TaskRewardShowIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> TaskRewardShow()
		{
			return this.TaskRewardShowIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600978C RID: 38796 RVA: 0x0028CDCE File Offset: 0x0028AFCE
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> TaskRewardShowIter()
		{
			MotorDevelopTask.<TaskRewardShowIter>d__25 <TaskRewardShowIter>d__ = new MotorDevelopTask.<TaskRewardShowIter>d__25(-2);
			<TaskRewardShowIter>d__.<>3__<>4__this = this;
			return <TaskRewardShowIter>d__;
		}

		// Token: 0x0600978D RID: 38797 RVA: 0x0028CDE4 File Offset: 0x0028AFE4
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

		// Token: 0x0600978E RID: 38798 RVA: 0x0028CE18 File Offset: 0x0028B018
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

		// Token: 0x0600978F RID: 38799 RVA: 0x0028CE4C File Offset: 0x0028B04C
		private void EnsureTaskRewardCacheIfNeeded()
		{
			if (this.TaskRewardCache != null)
			{
				return;
			}
			this.TaskRewardCache = this.TaskRewardIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x06009790 RID: 38800 RVA: 0x0028CEB4 File Offset: 0x0028B0B4
		private void EnsureTaskRewardShowCacheIfNeeded()
		{
			if (this.TaskRewardShowCache != null)
			{
				return;
			}
			this.TaskRewardShowCache = this.TaskRewardShowIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x06009791 RID: 38801 RVA: 0x0028CF1A File Offset: 0x0028B11A
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetTaskRewardFrozenDict(int key)
		{
			this.EnsureTaskRewardCacheIfNeeded();
			return this.TaskRewardCache;
		}

		// Token: 0x06009792 RID: 38802 RVA: 0x0028CF28 File Offset: 0x0028B128
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetTaskRewardShowFrozenDict(int key)
		{
			this.EnsureTaskRewardShowCacheIfNeeded();
			return this.TaskRewardShowCache;
		}

		// Token: 0x04004EDD RID: 20189
		private Table __p;

		// Token: 0x04004EDE RID: 20190
		[Nullable(2)]
		private FrozenDictionary<int, int> TaskRewardCache;

		// Token: 0x04004EDF RID: 20191
		[Nullable(2)]
		private FrozenDictionary<int, int> TaskRewardShowCache;
	}
}
