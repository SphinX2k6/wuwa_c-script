using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BB2 RID: 2994
	public struct DailyAdventureTask : IFlatbufferObject
	{
		// Token: 0x17000A01 RID: 2561
		// (get) Token: 0x06005AF7 RID: 23287 RVA: 0x002031B8 File Offset: 0x002013B8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06005AF8 RID: 23288 RVA: 0x002031C5 File Offset: 0x002013C5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06005AF9 RID: 23289 RVA: 0x002031CC File Offset: 0x002013CC
		public static DailyAdventureTask GetRootAsDailyAdventureTask(ByteBuffer _bb)
		{
			return DailyAdventureTask.GetRootAsDailyAdventureTask(_bb, default(DailyAdventureTask));
		}

		// Token: 0x06005AFA RID: 23290 RVA: 0x002031E8 File Offset: 0x002013E8
		public static DailyAdventureTask GetRootAsDailyAdventureTask(ByteBuffer _bb, DailyAdventureTask obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06005AFB RID: 23291 RVA: 0x00203205 File Offset: 0x00201405
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06005AFC RID: 23292 RVA: 0x00203214 File Offset: 0x00201414
		public DailyAdventureTask __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000A02 RID: 2562
		// (get) Token: 0x06005AFD RID: 23293 RVA: 0x00203224 File Offset: 0x00201424
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

		// Token: 0x17000A03 RID: 2563
		// (get) Token: 0x06005AFE RID: 23294 RVA: 0x00203260 File Offset: 0x00201460
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

		// Token: 0x06005AFF RID: 23295 RVA: 0x00203297 File Offset: 0x00201497
		public Span<byte> GetTaskTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06005B00 RID: 23296 RVA: 0x002032A6 File Offset: 0x002014A6
		public byte[] GetTaskTitleArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17000A04 RID: 2564
		// (get) Token: 0x06005B01 RID: 23297 RVA: 0x002032C0 File Offset: 0x002014C0
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

		// Token: 0x06005B02 RID: 23298 RVA: 0x002032F7 File Offset: 0x002014F7
		public Span<byte> GetTaskDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06005B03 RID: 23299 RVA: 0x00203306 File Offset: 0x00201506
		public byte[] GetTaskDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x06005B04 RID: 23300 RVA: 0x00203320 File Offset: 0x00201520
		public DicIntInt? TaskReward(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17000A05 RID: 2565
		// (get) Token: 0x06005B05 RID: 23301 RVA: 0x00203384 File Offset: 0x00201584
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

		// Token: 0x06005B06 RID: 23302 RVA: 0x002033B0 File Offset: 0x002015B0
		public string TaskFunc(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000A06 RID: 2566
		// (get) Token: 0x06005B07 RID: 23303 RVA: 0x002033EC File Offset: 0x002015EC
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

		// Token: 0x06005B08 RID: 23304 RVA: 0x00203418 File Offset: 0x00201618
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用TaskFuncIter()或GetTaskFuncBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] TaskFunc()
		{
			return this.TaskFuncIter().ToArray<string>();
		}

		// Token: 0x06005B09 RID: 23305 RVA: 0x00203425 File Offset: 0x00201625
		[NullableContext(1)]
		public readonly IEnumerable<string> TaskFuncIter()
		{
			DailyAdventureTask.<TaskFuncIter>d__25 <TaskFuncIter>d__ = new DailyAdventureTask.<TaskFuncIter>d__25(-2);
			<TaskFuncIter>d__.<>3__<>4__this = this;
			return <TaskFuncIter>d__;
		}

		// Token: 0x06005B0A RID: 23306 RVA: 0x0020343C File Offset: 0x0020163C
		[NullableContext(1)]
		[Obsolete("已废弃，请使用TaskRewardFrozenDict()缓存字典，遍历请使用TaskRewardIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> TaskReward()
		{
			return this.TaskRewardIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x06005B0B RID: 23307 RVA: 0x00203492 File Offset: 0x00201692
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> TaskRewardIter()
		{
			DailyAdventureTask.<TaskRewardIter>d__27 <TaskRewardIter>d__ = new DailyAdventureTask.<TaskRewardIter>d__27(-2);
			<TaskRewardIter>d__.<>3__<>4__this = this;
			return <TaskRewardIter>d__;
		}

		// Token: 0x06005B0C RID: 23308 RVA: 0x002034A8 File Offset: 0x002016A8
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

		// Token: 0x06005B0D RID: 23309 RVA: 0x002034DC File Offset: 0x002016DC
		private void EnsureTaskRewardCacheIfNeeded()
		{
			if (this.TaskRewardCache != null)
			{
				return;
			}
			this.TaskRewardCache = this.TaskRewardIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x06005B0E RID: 23310 RVA: 0x00203542 File Offset: 0x00201742
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetTaskRewardFrozenDict(int key)
		{
			this.EnsureTaskRewardCacheIfNeeded();
			return this.TaskRewardCache;
		}

		// Token: 0x04004BD5 RID: 19413
		private Table __p;

		// Token: 0x04004BD6 RID: 19414
		[Nullable(2)]
		private FrozenDictionary<int, int> TaskRewardCache;
	}
}
