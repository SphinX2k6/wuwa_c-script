using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C0B RID: 3083
	public struct BattlePassTask : IFlatbufferObject
	{
		// Token: 0x17000530 RID: 1328
		// (get) Token: 0x06005263 RID: 21091 RVA: 0x00202566 File Offset: 0x00200766
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06005264 RID: 21092 RVA: 0x00202573 File Offset: 0x00200773
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06005265 RID: 21093 RVA: 0x0020257C File Offset: 0x0020077C
		public static BattlePassTask GetRootAsBattlePassTask(ByteBuffer _bb)
		{
			return BattlePassTask.GetRootAsBattlePassTask(_bb, default(BattlePassTask));
		}

		// Token: 0x06005266 RID: 21094 RVA: 0x00202598 File Offset: 0x00200798
		public static BattlePassTask GetRootAsBattlePassTask(ByteBuffer _bb, BattlePassTask obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06005267 RID: 21095 RVA: 0x002025B5 File Offset: 0x002007B5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06005268 RID: 21096 RVA: 0x002025C4 File Offset: 0x002007C4
		public BattlePassTask __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000531 RID: 1329
		// (get) Token: 0x06005269 RID: 21097 RVA: 0x002025D4 File Offset: 0x002007D4
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

		// Token: 0x17000532 RID: 1330
		// (get) Token: 0x0600526A RID: 21098 RVA: 0x00202610 File Offset: 0x00200810
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

		// Token: 0x0600526B RID: 21099 RVA: 0x00202647 File Offset: 0x00200847
		public Span<byte> GetTaskNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600526C RID: 21100 RVA: 0x00202656 File Offset: 0x00200856
		public byte[] GetTaskNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17000533 RID: 1331
		// (get) Token: 0x0600526D RID: 21101 RVA: 0x00202670 File Offset: 0x00200870
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

		// Token: 0x0600526E RID: 21102 RVA: 0x002026AC File Offset: 0x002008AC
		public DicIntInt? TaskReward(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17000534 RID: 1332
		// (get) Token: 0x0600526F RID: 21103 RVA: 0x00202710 File Offset: 0x00200910
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

		// Token: 0x17000535 RID: 1333
		// (get) Token: 0x06005270 RID: 21104 RVA: 0x0020273C File Offset: 0x0020093C
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

		// Token: 0x06005271 RID: 21105 RVA: 0x0020277C File Offset: 0x0020097C
		[NullableContext(1)]
		public Dictionary<int, int> TaskReward()
		{
			return this.TaskRewardIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x06005272 RID: 21106 RVA: 0x002027D2 File Offset: 0x002009D2
		[NullableContext(1)]
		public IEnumerable<DicIntInt> TaskRewardIter()
		{
			BattlePassTask.<TaskRewardIter>d__22 <TaskRewardIter>d__ = new BattlePassTask.<TaskRewardIter>d__22(-2);
			<TaskRewardIter>d__.<>3__<>4__this = this;
			return <TaskRewardIter>d__;
		}

		// Token: 0x06005273 RID: 21107 RVA: 0x002027E8 File Offset: 0x002009E8
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

		// Token: 0x06005274 RID: 21108 RVA: 0x0020281C File Offset: 0x00200A1C
		private void EnsureTaskRewardCacheIfNeeded()
		{
			if (this.TaskRewardCache != null)
			{
				return;
			}
			this.TaskRewardCache = this.TaskRewardIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x06005275 RID: 21109 RVA: 0x00202882 File Offset: 0x00200A82
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetTaskRewardFrozenDict()
		{
			this.EnsureTaskRewardCacheIfNeeded();
			return this.TaskRewardCache;
		}

		// Token: 0x04005101 RID: 20737
		private Table __p;

		// Token: 0x04005102 RID: 20738
		[Nullable(2)]
		private FrozenDictionary<int, int> TaskRewardCache;
	}
}
