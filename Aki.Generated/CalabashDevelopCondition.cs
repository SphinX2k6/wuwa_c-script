using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C3B RID: 3131
	public struct CalabashDevelopCondition : IFlatbufferObject
	{
		// Token: 0x170006EB RID: 1771
		// (get) Token: 0x06005753 RID: 22355 RVA: 0x0020D310 File Offset: 0x0020B510
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06005754 RID: 22356 RVA: 0x0020D31D File Offset: 0x0020B51D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06005755 RID: 22357 RVA: 0x0020D324 File Offset: 0x0020B524
		public static CalabashDevelopCondition GetRootAsCalabashDevelopCondition(ByteBuffer _bb)
		{
			return CalabashDevelopCondition.GetRootAsCalabashDevelopCondition(_bb, default(CalabashDevelopCondition));
		}

		// Token: 0x06005756 RID: 22358 RVA: 0x0020D340 File Offset: 0x0020B540
		public static CalabashDevelopCondition GetRootAsCalabashDevelopCondition(ByteBuffer _bb, CalabashDevelopCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06005757 RID: 22359 RVA: 0x0020D35D File Offset: 0x0020B55D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06005758 RID: 22360 RVA: 0x0020D36C File Offset: 0x0020B56C
		public CalabashDevelopCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170006EC RID: 1772
		// (get) Token: 0x06005759 RID: 22361 RVA: 0x0020D37C File Offset: 0x0020B57C
		public int Id
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

		// Token: 0x170006ED RID: 1773
		// (get) Token: 0x0600575A RID: 22362 RVA: 0x0020D3B8 File Offset: 0x0020B5B8
		public int Condition
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

		// Token: 0x0600575B RID: 22363 RVA: 0x0020D3F4 File Offset: 0x0020B5F4
		public int ConditionParam(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170006EE RID: 1774
		// (get) Token: 0x0600575C RID: 22364 RVA: 0x0020D434 File Offset: 0x0020B634
		public int ConditionParamLength
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600575D RID: 22365 RVA: 0x0020D45F File Offset: 0x0020B65F
		public Span<int> GetConditionParamBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x0600575E RID: 22366 RVA: 0x0020D46E File Offset: 0x0020B66E
		public int[] GetConditionParamArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x170006EF RID: 1775
		// (get) Token: 0x0600575F RID: 22367 RVA: 0x0020D488 File Offset: 0x0020B688
		public string Description
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06005760 RID: 22368 RVA: 0x0020D4C0 File Offset: 0x0020B6C0
		public Span<byte> GetDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06005761 RID: 22369 RVA: 0x0020D4D0 File Offset: 0x0020B6D0
		public byte[] GetDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x06005762 RID: 22370 RVA: 0x0020D4E8 File Offset: 0x0020B6E8
		public DicIntInt? RewardExp(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170006F0 RID: 1776
		// (get) Token: 0x06005763 RID: 22371 RVA: 0x0020D54C File Offset: 0x0020B74C
		public int RewardExpLength
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

		// Token: 0x06005764 RID: 22372 RVA: 0x0020D578 File Offset: 0x0020B778
		[NullableContext(1)]
		public int[] ConditionParam()
		{
			return this.GetConditionParamArray();
		}

		// Token: 0x06005765 RID: 22373 RVA: 0x0020D580 File Offset: 0x0020B780
		[NullableContext(1)]
		public IEnumerable<int> ConditionParamIter()
		{
			CalabashDevelopCondition.<ConditionParamIter>d__25 <ConditionParamIter>d__ = new CalabashDevelopCondition.<ConditionParamIter>d__25(-2);
			<ConditionParamIter>d__.<>3__<>4__this = this;
			return <ConditionParamIter>d__;
		}

		// Token: 0x06005766 RID: 22374 RVA: 0x0020D598 File Offset: 0x0020B798
		[NullableContext(1)]
		public Dictionary<int, int> RewardExp()
		{
			return this.RewardExpIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x06005767 RID: 22375 RVA: 0x0020D5EE File Offset: 0x0020B7EE
		[NullableContext(1)]
		public IEnumerable<DicIntInt> RewardExpIter()
		{
			CalabashDevelopCondition.<RewardExpIter>d__27 <RewardExpIter>d__ = new CalabashDevelopCondition.<RewardExpIter>d__27(-2);
			<RewardExpIter>d__.<>3__<>4__this = this;
			return <RewardExpIter>d__;
		}

		// Token: 0x06005768 RID: 22376 RVA: 0x0020D604 File Offset: 0x0020B804
		public int? GetRewardExp(int key)
		{
			this.EnsureRewardExpCacheIfNeeded();
			int value;
			if (!this.RewardExpCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x06005769 RID: 22377 RVA: 0x0020D638 File Offset: 0x0020B838
		private void EnsureRewardExpCacheIfNeeded()
		{
			if (this.RewardExpCache != null)
			{
				return;
			}
			this.RewardExpCache = this.RewardExpIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600576A RID: 22378 RVA: 0x0020D69E File Offset: 0x0020B89E
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetRewardExpFrozenDict()
		{
			this.EnsureRewardExpCacheIfNeeded();
			return this.RewardExpCache;
		}

		// Token: 0x04005138 RID: 20792
		private Table __p;

		// Token: 0x04005139 RID: 20793
		[Nullable(2)]
		private FrozenDictionary<int, int> RewardExpCache;
	}
}
