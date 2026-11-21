using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E53 RID: 3667
	public struct InfrV2TreeBuild : IFlatbufferObject
	{
		// Token: 0x170019A3 RID: 6563
		// (get) Token: 0x06008A45 RID: 35397 RVA: 0x0027F09D File Offset: 0x0027D29D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008A46 RID: 35398 RVA: 0x0027F0AA File Offset: 0x0027D2AA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008A47 RID: 35399 RVA: 0x0027F0B4 File Offset: 0x0027D2B4
		public static InfrV2TreeBuild GetRootAsInfrV2TreeBuild(ByteBuffer _bb)
		{
			return InfrV2TreeBuild.GetRootAsInfrV2TreeBuild(_bb, default(InfrV2TreeBuild));
		}

		// Token: 0x06008A48 RID: 35400 RVA: 0x0027F0D0 File Offset: 0x0027D2D0
		public static InfrV2TreeBuild GetRootAsInfrV2TreeBuild(ByteBuffer _bb, InfrV2TreeBuild obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008A49 RID: 35401 RVA: 0x0027F0ED File Offset: 0x0027D2ED
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008A4A RID: 35402 RVA: 0x0027F0FC File Offset: 0x0027D2FC
		public InfrV2TreeBuild __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170019A4 RID: 6564
		// (get) Token: 0x06008A4B RID: 35403 RVA: 0x0027F10C File Offset: 0x0027D30C
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

		// Token: 0x170019A5 RID: 6565
		// (get) Token: 0x06008A4C RID: 35404 RVA: 0x0027F148 File Offset: 0x0027D348
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

		// Token: 0x170019A6 RID: 6566
		// (get) Token: 0x06008A4D RID: 35405 RVA: 0x0027F184 File Offset: 0x0027D384
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

		// Token: 0x170019A7 RID: 6567
		// (get) Token: 0x06008A4E RID: 35406 RVA: 0x0027F1C0 File Offset: 0x0027D3C0
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

		// Token: 0x170019A8 RID: 6568
		// (get) Token: 0x06008A4F RID: 35407 RVA: 0x0027F200 File Offset: 0x0027D400
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

		// Token: 0x170019A9 RID: 6569
		// (get) Token: 0x06008A50 RID: 35408 RVA: 0x0027F240 File Offset: 0x0027D440
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

		// Token: 0x170019AA RID: 6570
		// (get) Token: 0x06008A51 RID: 35409 RVA: 0x0027F280 File Offset: 0x0027D480
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

		// Token: 0x170019AB RID: 6571
		// (get) Token: 0x06008A52 RID: 35410 RVA: 0x0027F2C0 File Offset: 0x0027D4C0
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

		// Token: 0x170019AC RID: 6572
		// (get) Token: 0x06008A53 RID: 35411 RVA: 0x0027F300 File Offset: 0x0027D500
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

		// Token: 0x170019AD RID: 6573
		// (get) Token: 0x06008A54 RID: 35412 RVA: 0x0027F340 File Offset: 0x0027D540
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

		// Token: 0x06008A55 RID: 35413 RVA: 0x0027F380 File Offset: 0x0027D580
		public DicIntInt? Requirement(int j)
		{
			int num = this.__p.__offset(24);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170019AE RID: 6574
		// (get) Token: 0x06008A56 RID: 35414 RVA: 0x0027F3E4 File Offset: 0x0027D5E4
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

		// Token: 0x06008A57 RID: 35415 RVA: 0x0027F410 File Offset: 0x0027D610
		public DicIntInt? FireExpReward(int j)
		{
			int num = this.__p.__offset(26);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170019AF RID: 6575
		// (get) Token: 0x06008A58 RID: 35416 RVA: 0x0027F474 File Offset: 0x0027D674
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

		// Token: 0x06008A59 RID: 35417 RVA: 0x0027F4A0 File Offset: 0x0027D6A0
		public int FinishCondition(int j)
		{
			int num = this.__p.__offset(28);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170019B0 RID: 6576
		// (get) Token: 0x06008A5A RID: 35418 RVA: 0x0027F4E0 File Offset: 0x0027D6E0
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

		// Token: 0x06008A5B RID: 35419 RVA: 0x0027F50C File Offset: 0x0027D70C
		public Span<int> GetFinishConditionBytes()
		{
			return this.__p.__vector_as_span<int>(28, 4);
		}

		// Token: 0x06008A5C RID: 35420 RVA: 0x0027F51C File Offset: 0x0027D71C
		public int[] GetFinishConditionArray()
		{
			return this.__p.__vector_as_array<int>(28) ?? Array.Empty<int>();
		}

		// Token: 0x06008A5D RID: 35421 RVA: 0x0027F534 File Offset: 0x0027D734
		public int QuestAccessPath(int j)
		{
			int num = this.__p.__offset(30);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170019B1 RID: 6577
		// (get) Token: 0x06008A5E RID: 35422 RVA: 0x0027F574 File Offset: 0x0027D774
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

		// Token: 0x06008A5F RID: 35423 RVA: 0x0027F5A0 File Offset: 0x0027D7A0
		public Span<int> GetQuestAccessPathBytes()
		{
			return this.__p.__vector_as_span<int>(30, 4);
		}

		// Token: 0x06008A60 RID: 35424 RVA: 0x0027F5B0 File Offset: 0x0027D7B0
		public int[] GetQuestAccessPathArray()
		{
			return this.__p.__vector_as_array<int>(30) ?? Array.Empty<int>();
		}

		// Token: 0x06008A61 RID: 35425 RVA: 0x0027F5C8 File Offset: 0x0027D7C8
		public int ItemNum(int j)
		{
			int num = this.__p.__offset(32);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170019B2 RID: 6578
		// (get) Token: 0x06008A62 RID: 35426 RVA: 0x0027F608 File Offset: 0x0027D808
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

		// Token: 0x06008A63 RID: 35427 RVA: 0x0027F634 File Offset: 0x0027D834
		public Span<int> GetItemNumBytes()
		{
			return this.__p.__vector_as_span<int>(32, 4);
		}

		// Token: 0x06008A64 RID: 35428 RVA: 0x0027F644 File Offset: 0x0027D844
		public int[] GetItemNumArray()
		{
			return this.__p.__vector_as_array<int>(32) ?? Array.Empty<int>();
		}

		// Token: 0x170019B3 RID: 6579
		// (get) Token: 0x06008A65 RID: 35429 RVA: 0x0027F65C File Offset: 0x0027D85C
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

		// Token: 0x06008A66 RID: 35430 RVA: 0x0027F694 File Offset: 0x0027D894
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(34, 1);
		}

		// Token: 0x06008A67 RID: 35431 RVA: 0x0027F6A4 File Offset: 0x0027D8A4
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(34) ?? Array.Empty<byte>();
		}

		// Token: 0x170019B4 RID: 6580
		// (get) Token: 0x06008A68 RID: 35432 RVA: 0x0027F6BC File Offset: 0x0027D8BC
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

		// Token: 0x06008A69 RID: 35433 RVA: 0x0027F6F4 File Offset: 0x0027D8F4
		public Span<byte> GetDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(36, 1);
		}

		// Token: 0x06008A6A RID: 35434 RVA: 0x0027F704 File Offset: 0x0027D904
		public byte[] GetDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(36) ?? Array.Empty<byte>();
		}

		// Token: 0x170019B5 RID: 6581
		// (get) Token: 0x06008A6B RID: 35435 RVA: 0x0027F71C File Offset: 0x0027D91C
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

		// Token: 0x06008A6C RID: 35436 RVA: 0x0027F754 File Offset: 0x0027D954
		public Span<byte> GetInfoPicturePathBytes()
		{
			return this.__p.__vector_as_span<byte>(38, 1);
		}

		// Token: 0x06008A6D RID: 35437 RVA: 0x0027F764 File Offset: 0x0027D964
		public byte[] GetInfoPicturePathArray()
		{
			return this.__p.__vector_as_array<byte>(38) ?? Array.Empty<byte>();
		}

		// Token: 0x06008A6E RID: 35438 RVA: 0x0027F77C File Offset: 0x0027D97C
		[NullableContext(1)]
		public int[] FinishCondition()
		{
			return this.GetFinishConditionArray();
		}

		// Token: 0x06008A6F RID: 35439 RVA: 0x0027F784 File Offset: 0x0027D984
		[NullableContext(1)]
		public IEnumerable<int> FinishConditionIter()
		{
			InfrV2TreeBuild.<FinishConditionIter>d__62 <FinishConditionIter>d__ = new InfrV2TreeBuild.<FinishConditionIter>d__62(-2);
			<FinishConditionIter>d__.<>3__<>4__this = this;
			return <FinishConditionIter>d__;
		}

		// Token: 0x06008A70 RID: 35440 RVA: 0x0027F79C File Offset: 0x0027D99C
		[NullableContext(1)]
		public Dictionary<int, int> FireExpReward()
		{
			return this.FireExpRewardIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x06008A71 RID: 35441 RVA: 0x0027F7F2 File Offset: 0x0027D9F2
		[NullableContext(1)]
		public IEnumerable<DicIntInt> FireExpRewardIter()
		{
			InfrV2TreeBuild.<FireExpRewardIter>d__64 <FireExpRewardIter>d__ = new InfrV2TreeBuild.<FireExpRewardIter>d__64(-2);
			<FireExpRewardIter>d__.<>3__<>4__this = this;
			return <FireExpRewardIter>d__;
		}

		// Token: 0x06008A72 RID: 35442 RVA: 0x0027F807 File Offset: 0x0027DA07
		[NullableContext(1)]
		public int[] ItemNum()
		{
			return this.GetItemNumArray();
		}

		// Token: 0x06008A73 RID: 35443 RVA: 0x0027F80F File Offset: 0x0027DA0F
		[NullableContext(1)]
		public IEnumerable<int> ItemNumIter()
		{
			InfrV2TreeBuild.<ItemNumIter>d__66 <ItemNumIter>d__ = new InfrV2TreeBuild.<ItemNumIter>d__66(-2);
			<ItemNumIter>d__.<>3__<>4__this = this;
			return <ItemNumIter>d__;
		}

		// Token: 0x06008A74 RID: 35444 RVA: 0x0027F824 File Offset: 0x0027DA24
		[NullableContext(1)]
		public int[] QuestAccessPath()
		{
			return this.GetQuestAccessPathArray();
		}

		// Token: 0x06008A75 RID: 35445 RVA: 0x0027F82C File Offset: 0x0027DA2C
		[NullableContext(1)]
		public IEnumerable<int> QuestAccessPathIter()
		{
			InfrV2TreeBuild.<QuestAccessPathIter>d__68 <QuestAccessPathIter>d__ = new InfrV2TreeBuild.<QuestAccessPathIter>d__68(-2);
			<QuestAccessPathIter>d__.<>3__<>4__this = this;
			return <QuestAccessPathIter>d__;
		}

		// Token: 0x06008A76 RID: 35446 RVA: 0x0027F844 File Offset: 0x0027DA44
		[NullableContext(1)]
		public Dictionary<int, int> Requirement()
		{
			return this.RequirementIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x06008A77 RID: 35447 RVA: 0x0027F89A File Offset: 0x0027DA9A
		[NullableContext(1)]
		public IEnumerable<DicIntInt> RequirementIter()
		{
			InfrV2TreeBuild.<RequirementIter>d__70 <RequirementIter>d__ = new InfrV2TreeBuild.<RequirementIter>d__70(-2);
			<RequirementIter>d__.<>3__<>4__this = this;
			return <RequirementIter>d__;
		}

		// Token: 0x06008A78 RID: 35448 RVA: 0x0027F8B0 File Offset: 0x0027DAB0
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

		// Token: 0x06008A79 RID: 35449 RVA: 0x0027F8E4 File Offset: 0x0027DAE4
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

		// Token: 0x06008A7A RID: 35450 RVA: 0x0027F918 File Offset: 0x0027DB18
		private void EnsureFireExpRewardCacheIfNeeded()
		{
			if (this.FireExpRewardCache != null)
			{
				return;
			}
			this.FireExpRewardCache = this.FireExpRewardIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x06008A7B RID: 35451 RVA: 0x0027F980 File Offset: 0x0027DB80
		private void EnsureRequirementCacheIfNeeded()
		{
			if (this.RequirementCache != null)
			{
				return;
			}
			this.RequirementCache = this.RequirementIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x06008A7C RID: 35452 RVA: 0x0027F9E6 File Offset: 0x0027DBE6
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetFireExpRewardFrozenDict()
		{
			this.EnsureFireExpRewardCacheIfNeeded();
			return this.FireExpRewardCache;
		}

		// Token: 0x06008A7D RID: 35453 RVA: 0x0027F9F4 File Offset: 0x0027DBF4
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetRequirementFrozenDict()
		{
			this.EnsureRequirementCacheIfNeeded();
			return this.RequirementCache;
		}

		// Token: 0x040053D6 RID: 21462
		private Table __p;

		// Token: 0x040053D7 RID: 21463
		[Nullable(2)]
		private FrozenDictionary<int, int> FireExpRewardCache;

		// Token: 0x040053D8 RID: 21464
		[Nullable(2)]
		private FrozenDictionary<int, int> RequirementCache;
	}
}
