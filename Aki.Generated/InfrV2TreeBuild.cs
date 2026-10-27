using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D6E RID: 3438
	public struct InfrV2TreeBuild : IFlatbufferObject
	{
		// Token: 0x17001940 RID: 6464
		// (get) Token: 0x0600842B RID: 33835 RVA: 0x00260A65 File Offset: 0x0025EC65
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600842C RID: 33836 RVA: 0x00260A72 File Offset: 0x0025EC72
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600842D RID: 33837 RVA: 0x00260A7C File Offset: 0x0025EC7C
		public static InfrV2TreeBuild GetRootAsInfrV2TreeBuild(ByteBuffer _bb)
		{
			return InfrV2TreeBuild.GetRootAsInfrV2TreeBuild(_bb, default(InfrV2TreeBuild));
		}

		// Token: 0x0600842E RID: 33838 RVA: 0x00260A98 File Offset: 0x0025EC98
		public static InfrV2TreeBuild GetRootAsInfrV2TreeBuild(ByteBuffer _bb, InfrV2TreeBuild obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600842F RID: 33839 RVA: 0x00260AB5 File Offset: 0x0025ECB5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008430 RID: 33840 RVA: 0x00260AC4 File Offset: 0x0025ECC4
		public InfrV2TreeBuild __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001941 RID: 6465
		// (get) Token: 0x06008431 RID: 33841 RVA: 0x00260AD4 File Offset: 0x0025ECD4
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

		// Token: 0x17001942 RID: 6466
		// (get) Token: 0x06008432 RID: 33842 RVA: 0x00260B10 File Offset: 0x0025ED10
		public int MarkId
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

		// Token: 0x17001943 RID: 6467
		// (get) Token: 0x06008433 RID: 33843 RVA: 0x00260B4C File Offset: 0x0025ED4C
		public int AreaId
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

		// Token: 0x17001944 RID: 6468
		// (get) Token: 0x06008434 RID: 33844 RVA: 0x00260B88 File Offset: 0x0025ED88
		public int DungeonId
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

		// Token: 0x17001945 RID: 6469
		// (get) Token: 0x06008435 RID: 33845 RVA: 0x00260BC8 File Offset: 0x0025EDC8
		public int ConditionId
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

		// Token: 0x17001946 RID: 6470
		// (get) Token: 0x06008436 RID: 33846 RVA: 0x00260C08 File Offset: 0x0025EE08
		public int PreQuest
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

		// Token: 0x17001947 RID: 6471
		// (get) Token: 0x06008437 RID: 33847 RVA: 0x00260C48 File Offset: 0x0025EE48
		public int LockJumpId
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

		// Token: 0x17001948 RID: 6472
		// (get) Token: 0x06008438 RID: 33848 RVA: 0x00260C88 File Offset: 0x0025EE88
		public int JumpId
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

		// Token: 0x17001949 RID: 6473
		// (get) Token: 0x06008439 RID: 33849 RVA: 0x00260CC8 File Offset: 0x0025EEC8
		public int BuildQuest
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700194A RID: 6474
		// (get) Token: 0x0600843A RID: 33850 RVA: 0x00260D08 File Offset: 0x0025EF08
		public int BuildConditionQuestId
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600843B RID: 33851 RVA: 0x00260D48 File Offset: 0x0025EF48
		public DicIntInt? Requirement(int j)
		{
			int num = this.__p.__offset(24);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700194B RID: 6475
		// (get) Token: 0x0600843C RID: 33852 RVA: 0x00260DAC File Offset: 0x0025EFAC
		public int RequirementLength
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600843D RID: 33853 RVA: 0x00260DD8 File Offset: 0x0025EFD8
		public DicIntInt? FireExpReward(int j)
		{
			int num = this.__p.__offset(26);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700194C RID: 6476
		// (get) Token: 0x0600843E RID: 33854 RVA: 0x00260E3C File Offset: 0x0025F03C
		public int FireExpRewardLength
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600843F RID: 33855 RVA: 0x00260E68 File Offset: 0x0025F068
		public int FinishCondition(int j)
		{
			int num = this.__p.__offset(28);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700194D RID: 6477
		// (get) Token: 0x06008440 RID: 33856 RVA: 0x00260EA8 File Offset: 0x0025F0A8
		public int FinishConditionLength
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06008441 RID: 33857 RVA: 0x00260ED4 File Offset: 0x0025F0D4
		public Span<int> GetFinishConditionBytes()
		{
			return this.__p.__vector_as_span<int>(28, 4);
		}

		// Token: 0x06008442 RID: 33858 RVA: 0x00260EE4 File Offset: 0x0025F0E4
		public int[] GetFinishConditionArray()
		{
			return this.__p.__vector_as_array<int>(28) ?? Array.Empty<int>();
		}

		// Token: 0x06008443 RID: 33859 RVA: 0x00260EFC File Offset: 0x0025F0FC
		public int QuestAccessPath(int j)
		{
			int num = this.__p.__offset(30);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700194E RID: 6478
		// (get) Token: 0x06008444 RID: 33860 RVA: 0x00260F3C File Offset: 0x0025F13C
		public int QuestAccessPathLength
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06008445 RID: 33861 RVA: 0x00260F68 File Offset: 0x0025F168
		public Span<int> GetQuestAccessPathBytes()
		{
			return this.__p.__vector_as_span<int>(30, 4);
		}

		// Token: 0x06008446 RID: 33862 RVA: 0x00260F78 File Offset: 0x0025F178
		public int[] GetQuestAccessPathArray()
		{
			return this.__p.__vector_as_array<int>(30) ?? Array.Empty<int>();
		}

		// Token: 0x06008447 RID: 33863 RVA: 0x00260F90 File Offset: 0x0025F190
		public int ItemNum(int j)
		{
			int num = this.__p.__offset(32);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700194F RID: 6479
		// (get) Token: 0x06008448 RID: 33864 RVA: 0x00260FD0 File Offset: 0x0025F1D0
		public int ItemNumLength
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06008449 RID: 33865 RVA: 0x00260FFC File Offset: 0x0025F1FC
		public Span<int> GetItemNumBytes()
		{
			return this.__p.__vector_as_span<int>(32, 4);
		}

		// Token: 0x0600844A RID: 33866 RVA: 0x0026100C File Offset: 0x0025F20C
		public int[] GetItemNumArray()
		{
			return this.__p.__vector_as_array<int>(32) ?? Array.Empty<int>();
		}

		// Token: 0x17001950 RID: 6480
		// (get) Token: 0x0600844B RID: 33867 RVA: 0x00261024 File Offset: 0x0025F224
		public string Name
		{
			get
			{
				int num = this.__p.__offset(34);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600844C RID: 33868 RVA: 0x0026105C File Offset: 0x0025F25C
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(34, 1);
		}

		// Token: 0x0600844D RID: 33869 RVA: 0x0026106C File Offset: 0x0025F26C
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(34) ?? Array.Empty<byte>();
		}

		// Token: 0x17001951 RID: 6481
		// (get) Token: 0x0600844E RID: 33870 RVA: 0x00261084 File Offset: 0x0025F284
		public string Description
		{
			get
			{
				int num = this.__p.__offset(36);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600844F RID: 33871 RVA: 0x002610BC File Offset: 0x0025F2BC
		public Span<byte> GetDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(36, 1);
		}

		// Token: 0x06008450 RID: 33872 RVA: 0x002610CC File Offset: 0x0025F2CC
		public byte[] GetDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(36) ?? Array.Empty<byte>();
		}

		// Token: 0x17001952 RID: 6482
		// (get) Token: 0x06008451 RID: 33873 RVA: 0x002610E4 File Offset: 0x0025F2E4
		public string InfoPicturePath
		{
			get
			{
				int num = this.__p.__offset(38);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06008452 RID: 33874 RVA: 0x0026111C File Offset: 0x0025F31C
		public Span<byte> GetInfoPicturePathBytes()
		{
			return this.__p.__vector_as_span<byte>(38, 1);
		}

		// Token: 0x06008453 RID: 33875 RVA: 0x0026112C File Offset: 0x0025F32C
		public byte[] GetInfoPicturePathArray()
		{
			return this.__p.__vector_as_array<byte>(38) ?? Array.Empty<byte>();
		}

		// Token: 0x06008454 RID: 33876 RVA: 0x00261144 File Offset: 0x0025F344
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用FinishConditionIter()或GetFinishConditionBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] FinishCondition()
		{
			InfrV2TreeBuild infrV2TreeBuild = this;
			return infrV2TreeBuild.GetFinishConditionArray() ?? Array.Empty<int>();
		}

		// Token: 0x06008455 RID: 33877 RVA: 0x00261168 File Offset: 0x0025F368
		[NullableContext(1)]
		public readonly IEnumerable<int> FinishConditionIter()
		{
			InfrV2TreeBuild.<FinishConditionIter>d__62 <FinishConditionIter>d__ = new InfrV2TreeBuild.<FinishConditionIter>d__62(-2);
			<FinishConditionIter>d__.<>3__<>4__this = this;
			return <FinishConditionIter>d__;
		}

		// Token: 0x06008456 RID: 33878 RVA: 0x00261180 File Offset: 0x0025F380
		[NullableContext(1)]
		[Obsolete("已废弃，请使用FireExpRewardFrozenDict()缓存字典，遍历请使用FireExpRewardIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> FireExpReward()
		{
			return this.FireExpRewardIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x06008457 RID: 33879 RVA: 0x002611D6 File Offset: 0x0025F3D6
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> FireExpRewardIter()
		{
			InfrV2TreeBuild.<FireExpRewardIter>d__64 <FireExpRewardIter>d__ = new InfrV2TreeBuild.<FireExpRewardIter>d__64(-2);
			<FireExpRewardIter>d__.<>3__<>4__this = this;
			return <FireExpRewardIter>d__;
		}

		// Token: 0x06008458 RID: 33880 RVA: 0x002611EC File Offset: 0x0025F3EC
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ItemNumIter()或GetItemNumBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] ItemNum()
		{
			InfrV2TreeBuild infrV2TreeBuild = this;
			return infrV2TreeBuild.GetItemNumArray() ?? Array.Empty<int>();
		}

		// Token: 0x06008459 RID: 33881 RVA: 0x00261210 File Offset: 0x0025F410
		[NullableContext(1)]
		public readonly IEnumerable<int> ItemNumIter()
		{
			InfrV2TreeBuild.<ItemNumIter>d__66 <ItemNumIter>d__ = new InfrV2TreeBuild.<ItemNumIter>d__66(-2);
			<ItemNumIter>d__.<>3__<>4__this = this;
			return <ItemNumIter>d__;
		}

		// Token: 0x0600845A RID: 33882 RVA: 0x00261228 File Offset: 0x0025F428
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用QuestAccessPathIter()或GetQuestAccessPathBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] QuestAccessPath()
		{
			InfrV2TreeBuild infrV2TreeBuild = this;
			return infrV2TreeBuild.GetQuestAccessPathArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600845B RID: 33883 RVA: 0x0026124C File Offset: 0x0025F44C
		[NullableContext(1)]
		public readonly IEnumerable<int> QuestAccessPathIter()
		{
			InfrV2TreeBuild.<QuestAccessPathIter>d__68 <QuestAccessPathIter>d__ = new InfrV2TreeBuild.<QuestAccessPathIter>d__68(-2);
			<QuestAccessPathIter>d__.<>3__<>4__this = this;
			return <QuestAccessPathIter>d__;
		}

		// Token: 0x0600845C RID: 33884 RVA: 0x00261264 File Offset: 0x0025F464
		[NullableContext(1)]
		[Obsolete("已废弃，请使用RequirementFrozenDict()缓存字典，遍历请使用RequirementIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> Requirement()
		{
			return this.RequirementIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600845D RID: 33885 RVA: 0x002612BA File Offset: 0x0025F4BA
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> RequirementIter()
		{
			InfrV2TreeBuild.<RequirementIter>d__70 <RequirementIter>d__ = new InfrV2TreeBuild.<RequirementIter>d__70(-2);
			<RequirementIter>d__.<>3__<>4__this = this;
			return <RequirementIter>d__;
		}

		// Token: 0x0600845E RID: 33886 RVA: 0x002612D0 File Offset: 0x0025F4D0
		public int? GetFireExpReward(int key)
		{
			this.EnsureFireExpRewardCacheIfNeeded();
			int value;
			if (!this.FireExpRewardCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x0600845F RID: 33887 RVA: 0x00261304 File Offset: 0x0025F504
		public int? GetRequirement(int key)
		{
			this.EnsureRequirementCacheIfNeeded();
			int value;
			if (!this.RequirementCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x06008460 RID: 33888 RVA: 0x00261338 File Offset: 0x0025F538
		private void EnsureFireExpRewardCacheIfNeeded()
		{
			if (this.FireExpRewardCache != null)
			{
				return;
			}
			this.FireExpRewardCache = this.FireExpRewardIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x06008461 RID: 33889 RVA: 0x002613A0 File Offset: 0x0025F5A0
		private void EnsureRequirementCacheIfNeeded()
		{
			if (this.RequirementCache != null)
			{
				return;
			}
			this.RequirementCache = this.RequirementIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x06008462 RID: 33890 RVA: 0x00261406 File Offset: 0x0025F606
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetFireExpRewardFrozenDict(int key)
		{
			this.EnsureFireExpRewardCacheIfNeeded();
			return this.FireExpRewardCache;
		}

		// Token: 0x06008463 RID: 33891 RVA: 0x00261414 File Offset: 0x0025F614
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetRequirementFrozenDict(int key)
		{
			this.EnsureRequirementCacheIfNeeded();
			return this.RequirementCache;
		}

		// Token: 0x04004DF1 RID: 19953
		private Table __p;

		// Token: 0x04004DF2 RID: 19954
		[Nullable(2)]
		private FrozenDictionary<int, int> FireExpRewardCache;

		// Token: 0x04004DF3 RID: 19955
		[Nullable(2)]
		private FrozenDictionary<int, int> RequirementCache;
	}
}
