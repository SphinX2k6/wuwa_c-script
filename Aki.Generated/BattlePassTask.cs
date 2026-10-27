using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B2B RID: 2859
	public struct BattlePassTask : IFlatbufferObject
	{
		// Token: 0x170004F0 RID: 1264
		// (get) Token: 0x06004CA1 RID: 19617 RVA: 0x001E216A File Offset: 0x001E036A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004CA2 RID: 19618 RVA: 0x001E2177 File Offset: 0x001E0377
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004CA3 RID: 19619 RVA: 0x001E2180 File Offset: 0x001E0380
		public static BattlePassTask GetRootAsBattlePassTask(ByteBuffer _bb)
		{
			return BattlePassTask.GetRootAsBattlePassTask(_bb, default(BattlePassTask));
		}

		// Token: 0x06004CA4 RID: 19620 RVA: 0x001E219C File Offset: 0x001E039C
		public static BattlePassTask GetRootAsBattlePassTask(ByteBuffer _bb, BattlePassTask obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004CA5 RID: 19621 RVA: 0x001E21B9 File Offset: 0x001E03B9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004CA6 RID: 19622 RVA: 0x001E21C8 File Offset: 0x001E03C8
		public BattlePassTask __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170004F1 RID: 1265
		// (get) Token: 0x06004CA7 RID: 19623 RVA: 0x001E21D8 File Offset: 0x001E03D8
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

		// Token: 0x170004F2 RID: 1266
		// (get) Token: 0x06004CA8 RID: 19624 RVA: 0x001E2214 File Offset: 0x001E0414
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

		// Token: 0x06004CA9 RID: 19625 RVA: 0x001E224B File Offset: 0x001E044B
		public Span<byte> GetTaskNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06004CAA RID: 19626 RVA: 0x001E225A File Offset: 0x001E045A
		public byte[] GetTaskNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170004F3 RID: 1267
		// (get) Token: 0x06004CAB RID: 19627 RVA: 0x001E2274 File Offset: 0x001E0474
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

		// Token: 0x06004CAC RID: 19628 RVA: 0x001E22B0 File Offset: 0x001E04B0
		public DicIntInt? TaskReward(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170004F4 RID: 1268
		// (get) Token: 0x06004CAD RID: 19629 RVA: 0x001E2314 File Offset: 0x001E0514
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

		// Token: 0x170004F5 RID: 1269
		// (get) Token: 0x06004CAE RID: 19630 RVA: 0x001E2340 File Offset: 0x001E0540
		public int JumpId
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06004CAF RID: 19631 RVA: 0x001E2380 File Offset: 0x001E0580
		[NullableContext(1)]
		[Obsolete("已废弃，请使用TaskRewardFrozenDict()缓存字典，遍历请使用TaskRewardIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> TaskReward()
		{
			return this.TaskRewardIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x06004CB0 RID: 19632 RVA: 0x001E23D6 File Offset: 0x001E05D6
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> TaskRewardIter()
		{
			BattlePassTask.<TaskRewardIter>d__22 <TaskRewardIter>d__ = new BattlePassTask.<TaskRewardIter>d__22(-2);
			<TaskRewardIter>d__.<>3__<>4__this = this;
			return <TaskRewardIter>d__;
		}

		// Token: 0x06004CB1 RID: 19633 RVA: 0x001E23EC File Offset: 0x001E05EC
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

		// Token: 0x06004CB2 RID: 19634 RVA: 0x001E2420 File Offset: 0x001E0620
		private void EnsureTaskRewardCacheIfNeeded()
		{
			if (this.TaskRewardCache != null)
			{
				return;
			}
			this.TaskRewardCache = this.TaskRewardIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x06004CB3 RID: 19635 RVA: 0x001E2486 File Offset: 0x001E0686
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetTaskRewardFrozenDict(int key)
		{
			this.EnsureTaskRewardCacheIfNeeded();
			return this.TaskRewardCache;
		}

		// Token: 0x04004B21 RID: 19233
		private Table __p;

		// Token: 0x04004B22 RID: 19234
		[Nullable(2)]
		private FrozenDictionary<int, int> TaskRewardCache;
	}
}
