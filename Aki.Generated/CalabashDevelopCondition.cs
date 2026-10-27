using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B5B RID: 2907
	public struct CalabashDevelopCondition : IFlatbufferObject
	{
		// Token: 0x170006AB RID: 1707
		// (get) Token: 0x06005191 RID: 20881 RVA: 0x001ED4E4 File Offset: 0x001EB6E4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06005192 RID: 20882 RVA: 0x001ED4F1 File Offset: 0x001EB6F1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06005193 RID: 20883 RVA: 0x001ED4F8 File Offset: 0x001EB6F8
		public static CalabashDevelopCondition GetRootAsCalabashDevelopCondition(ByteBuffer _bb)
		{
			return CalabashDevelopCondition.GetRootAsCalabashDevelopCondition(_bb, default(CalabashDevelopCondition));
		}

		// Token: 0x06005194 RID: 20884 RVA: 0x001ED514 File Offset: 0x001EB714
		public static CalabashDevelopCondition GetRootAsCalabashDevelopCondition(ByteBuffer _bb, CalabashDevelopCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06005195 RID: 20885 RVA: 0x001ED531 File Offset: 0x001EB731
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06005196 RID: 20886 RVA: 0x001ED540 File Offset: 0x001EB740
		public CalabashDevelopCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170006AC RID: 1708
		// (get) Token: 0x06005197 RID: 20887 RVA: 0x001ED550 File Offset: 0x001EB750
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

		// Token: 0x170006AD RID: 1709
		// (get) Token: 0x06005198 RID: 20888 RVA: 0x001ED58C File Offset: 0x001EB78C
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

		// Token: 0x06005199 RID: 20889 RVA: 0x001ED5C8 File Offset: 0x001EB7C8
		public int ConditionParam(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170006AE RID: 1710
		// (get) Token: 0x0600519A RID: 20890 RVA: 0x001ED608 File Offset: 0x001EB808
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

		// Token: 0x0600519B RID: 20891 RVA: 0x001ED633 File Offset: 0x001EB833
		public Span<int> GetConditionParamBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x0600519C RID: 20892 RVA: 0x001ED642 File Offset: 0x001EB842
		public int[] GetConditionParamArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x170006AF RID: 1711
		// (get) Token: 0x0600519D RID: 20893 RVA: 0x001ED65C File Offset: 0x001EB85C
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

		// Token: 0x0600519E RID: 20894 RVA: 0x001ED694 File Offset: 0x001EB894
		public Span<byte> GetDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600519F RID: 20895 RVA: 0x001ED6A4 File Offset: 0x001EB8A4
		public byte[] GetDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x060051A0 RID: 20896 RVA: 0x001ED6BC File Offset: 0x001EB8BC
		public DicIntInt? RewardExp(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170006B0 RID: 1712
		// (get) Token: 0x060051A1 RID: 20897 RVA: 0x001ED720 File Offset: 0x001EB920
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

		// Token: 0x060051A2 RID: 20898 RVA: 0x001ED74C File Offset: 0x001EB94C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ConditionParamIter()或GetConditionParamBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] ConditionParam()
		{
			CalabashDevelopCondition calabashDevelopCondition = this;
			return calabashDevelopCondition.GetConditionParamArray() ?? Array.Empty<int>();
		}

		// Token: 0x060051A3 RID: 20899 RVA: 0x001ED770 File Offset: 0x001EB970
		[NullableContext(1)]
		public readonly IEnumerable<int> ConditionParamIter()
		{
			CalabashDevelopCondition.<ConditionParamIter>d__25 <ConditionParamIter>d__ = new CalabashDevelopCondition.<ConditionParamIter>d__25(-2);
			<ConditionParamIter>d__.<>3__<>4__this = this;
			return <ConditionParamIter>d__;
		}

		// Token: 0x060051A4 RID: 20900 RVA: 0x001ED788 File Offset: 0x001EB988
		[NullableContext(1)]
		[Obsolete("已废弃，请使用RewardExpFrozenDict()缓存字典，遍历请使用RewardExpIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> RewardExp()
		{
			return this.RewardExpIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x060051A5 RID: 20901 RVA: 0x001ED7DE File Offset: 0x001EB9DE
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> RewardExpIter()
		{
			CalabashDevelopCondition.<RewardExpIter>d__27 <RewardExpIter>d__ = new CalabashDevelopCondition.<RewardExpIter>d__27(-2);
			<RewardExpIter>d__.<>3__<>4__this = this;
			return <RewardExpIter>d__;
		}

		// Token: 0x060051A6 RID: 20902 RVA: 0x001ED7F4 File Offset: 0x001EB9F4
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

		// Token: 0x060051A7 RID: 20903 RVA: 0x001ED828 File Offset: 0x001EBA28
		private void EnsureRewardExpCacheIfNeeded()
		{
			if (this.RewardExpCache != null)
			{
				return;
			}
			this.RewardExpCache = this.RewardExpIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x060051A8 RID: 20904 RVA: 0x001ED88E File Offset: 0x001EBA8E
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetRewardExpFrozenDict(int key)
		{
			this.EnsureRewardExpCacheIfNeeded();
			return this.RewardExpCache;
		}

		// Token: 0x04004B58 RID: 19288
		private Table __p;

		// Token: 0x04004B59 RID: 19289
		[Nullable(2)]
		private FrozenDictionary<int, int> RewardExpCache;
	}
}
