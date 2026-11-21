using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E4A RID: 3658
	public struct InfrLevel : IFlatbufferObject
	{
		// Token: 0x1700194B RID: 6475
		// (get) Token: 0x06008959 RID: 35161 RVA: 0x0027CE19 File Offset: 0x0027B019
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600895A RID: 35162 RVA: 0x0027CE26 File Offset: 0x0027B026
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600895B RID: 35163 RVA: 0x0027CE30 File Offset: 0x0027B030
		public static InfrLevel GetRootAsInfrLevel(ByteBuffer _bb)
		{
			return InfrLevel.GetRootAsInfrLevel(_bb, default(InfrLevel));
		}

		// Token: 0x0600895C RID: 35164 RVA: 0x0027CE4C File Offset: 0x0027B04C
		public static InfrLevel GetRootAsInfrLevel(ByteBuffer _bb, InfrLevel obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600895D RID: 35165 RVA: 0x0027CE69 File Offset: 0x0027B069
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600895E RID: 35166 RVA: 0x0027CE78 File Offset: 0x0027B078
		public InfrLevel __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700194C RID: 6476
		// (get) Token: 0x0600895F RID: 35167 RVA: 0x0027CE88 File Offset: 0x0027B088
		public int Level
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

		// Token: 0x1700194D RID: 6477
		// (get) Token: 0x06008960 RID: 35168 RVA: 0x0027CEC4 File Offset: 0x0027B0C4
		public int Exp
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

		// Token: 0x1700194E RID: 6478
		// (get) Token: 0x06008961 RID: 35169 RVA: 0x0027CF00 File Offset: 0x0027B100
		public int ConditionId
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

		// Token: 0x06008962 RID: 35170 RVA: 0x0027CF3C File Offset: 0x0027B13C
		public DicIntInt? Requirement(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700194F RID: 6479
		// (get) Token: 0x06008963 RID: 35171 RVA: 0x0027CFA0 File Offset: 0x0027B1A0
		public int RequirementLength
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

		// Token: 0x17001950 RID: 6480
		// (get) Token: 0x06008964 RID: 35172 RVA: 0x0027CFCC File Offset: 0x0027B1CC
		public int RoadCoinAdd
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

		// Token: 0x17001951 RID: 6481
		// (get) Token: 0x06008965 RID: 35173 RVA: 0x0027D00C File Offset: 0x0027B20C
		public int Reward
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

		// Token: 0x17001952 RID: 6482
		// (get) Token: 0x06008966 RID: 35174 RVA: 0x0027D04C File Offset: 0x0027B24C
		public string Description
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06008967 RID: 35175 RVA: 0x0027D084 File Offset: 0x0027B284
		public Span<byte> GetDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06008968 RID: 35176 RVA: 0x0027D094 File Offset: 0x0027B294
		public byte[] GetDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x06008969 RID: 35177 RVA: 0x0027D0AC File Offset: 0x0027B2AC
		public string QuestDescriptions(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001953 RID: 6483
		// (get) Token: 0x0600896A RID: 35178 RVA: 0x0027D0E8 File Offset: 0x0027B2E8
		public int QuestDescriptionsLength
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600896B RID: 35179 RVA: 0x0027D114 File Offset: 0x0027B314
		public int QuestIds(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001954 RID: 6484
		// (get) Token: 0x0600896C RID: 35180 RVA: 0x0027D154 File Offset: 0x0027B354
		public int QuestIdsLength
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600896D RID: 35181 RVA: 0x0027D180 File Offset: 0x0027B380
		public Span<int> GetQuestIdsBytes()
		{
			return this.__p.__vector_as_span<int>(20, 4);
		}

		// Token: 0x0600896E RID: 35182 RVA: 0x0027D190 File Offset: 0x0027B390
		public int[] GetQuestIdsArray()
		{
			return this.__p.__vector_as_array<int>(20) ?? Array.Empty<int>();
		}

		// Token: 0x17001955 RID: 6485
		// (get) Token: 0x0600896F RID: 35183 RVA: 0x0027D1A8 File Offset: 0x0027B3A8
		public string Name
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06008970 RID: 35184 RVA: 0x0027D1E0 File Offset: 0x0027B3E0
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x06008971 RID: 35185 RVA: 0x0027D1F0 File Offset: 0x0027B3F0
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x06008972 RID: 35186 RVA: 0x0027D208 File Offset: 0x0027B408
		public string EffectDes(int j)
		{
			int num = this.__p.__offset(24);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001956 RID: 6486
		// (get) Token: 0x06008973 RID: 35187 RVA: 0x0027D244 File Offset: 0x0027B444
		public int EffectDesLength
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

		// Token: 0x17001957 RID: 6487
		// (get) Token: 0x06008974 RID: 35188 RVA: 0x0027D270 File Offset: 0x0027B470
		public string StageDescription
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06008975 RID: 35189 RVA: 0x0027D2A8 File Offset: 0x0027B4A8
		public Span<byte> GetStageDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x06008976 RID: 35190 RVA: 0x0027D2B8 File Offset: 0x0027B4B8
		public byte[] GetStageDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x17001958 RID: 6488
		// (get) Token: 0x06008977 RID: 35191 RVA: 0x0027D2D0 File Offset: 0x0027B4D0
		public string InfoPicturePath
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06008978 RID: 35192 RVA: 0x0027D308 File Offset: 0x0027B508
		public Span<byte> GetInfoPicturePathBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x06008979 RID: 35193 RVA: 0x0027D318 File Offset: 0x0027B518
		public byte[] GetInfoPicturePathArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x17001959 RID: 6489
		// (get) Token: 0x0600897A RID: 35194 RVA: 0x0027D330 File Offset: 0x0027B530
		public string MarkStageName
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600897B RID: 35195 RVA: 0x0027D368 File Offset: 0x0027B568
		public Span<byte> GetMarkStageNameBytes()
		{
			return this.__p.__vector_as_span<byte>(30, 1);
		}

		// Token: 0x0600897C RID: 35196 RVA: 0x0027D378 File Offset: 0x0027B578
		public byte[] GetMarkStageNameArray()
		{
			return this.__p.__vector_as_array<byte>(30) ?? Array.Empty<byte>();
		}

		// Token: 0x1700195A RID: 6490
		// (get) Token: 0x0600897D RID: 35197 RVA: 0x0027D390 File Offset: 0x0027B590
		public string BuildSuccessDes
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600897E RID: 35198 RVA: 0x0027D3C8 File Offset: 0x0027B5C8
		public Span<byte> GetBuildSuccessDesBytes()
		{
			return this.__p.__vector_as_span<byte>(32, 1);
		}

		// Token: 0x0600897F RID: 35199 RVA: 0x0027D3D8 File Offset: 0x0027B5D8
		public byte[] GetBuildSuccessDesArray()
		{
			return this.__p.__vector_as_array<byte>(32) ?? Array.Empty<byte>();
		}

		// Token: 0x1700195B RID: 6491
		// (get) Token: 0x06008980 RID: 35200 RVA: 0x0027D3F0 File Offset: 0x0027B5F0
		public string ScenePath
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

		// Token: 0x06008981 RID: 35201 RVA: 0x0027D428 File Offset: 0x0027B628
		public Span<byte> GetScenePathBytes()
		{
			return this.__p.__vector_as_span<byte>(34, 1);
		}

		// Token: 0x06008982 RID: 35202 RVA: 0x0027D438 File Offset: 0x0027B638
		public byte[] GetScenePathArray()
		{
			return this.__p.__vector_as_array<byte>(34) ?? Array.Empty<byte>();
		}

		// Token: 0x1700195C RID: 6492
		// (get) Token: 0x06008983 RID: 35203 RVA: 0x0027D450 File Offset: 0x0027B650
		public int JumpId
		{
			get
			{
				int num = this.__p.__offset(36);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700195D RID: 6493
		// (get) Token: 0x06008984 RID: 35204 RVA: 0x0027D490 File Offset: 0x0027B690
		public string VideoName
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

		// Token: 0x06008985 RID: 35205 RVA: 0x0027D4C8 File Offset: 0x0027B6C8
		public Span<byte> GetVideoNameBytes()
		{
			return this.__p.__vector_as_span<byte>(38, 1);
		}

		// Token: 0x06008986 RID: 35206 RVA: 0x0027D4D8 File Offset: 0x0027B6D8
		public byte[] GetVideoNameArray()
		{
			return this.__p.__vector_as_array<byte>(38) ?? Array.Empty<byte>();
		}

		// Token: 0x1700195E RID: 6494
		// (get) Token: 0x06008987 RID: 35207 RVA: 0x0027D4F0 File Offset: 0x0027B6F0
		public string VideoPath
		{
			get
			{
				int num = this.__p.__offset(40);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06008988 RID: 35208 RVA: 0x0027D528 File Offset: 0x0027B728
		public Span<byte> GetVideoPathBytes()
		{
			return this.__p.__vector_as_span<byte>(40, 1);
		}

		// Token: 0x06008989 RID: 35209 RVA: 0x0027D538 File Offset: 0x0027B738
		public byte[] GetVideoPathArray()
		{
			return this.__p.__vector_as_array<byte>(40) ?? Array.Empty<byte>();
		}

		// Token: 0x0600898A RID: 35210 RVA: 0x0027D550 File Offset: 0x0027B750
		[NullableContext(1)]
		public string[] EffectDes()
		{
			return this.EffectDesIter().ToArray<string>();
		}

		// Token: 0x0600898B RID: 35211 RVA: 0x0027D55D File Offset: 0x0027B75D
		[NullableContext(1)]
		public IEnumerable<string> EffectDesIter()
		{
			InfrLevel.<EffectDesIter>d__71 <EffectDesIter>d__ = new InfrLevel.<EffectDesIter>d__71(-2);
			<EffectDesIter>d__.<>3__<>4__this = this;
			return <EffectDesIter>d__;
		}

		// Token: 0x0600898C RID: 35212 RVA: 0x0027D572 File Offset: 0x0027B772
		[NullableContext(1)]
		public string[] QuestDescriptions()
		{
			return this.QuestDescriptionsIter().ToArray<string>();
		}

		// Token: 0x0600898D RID: 35213 RVA: 0x0027D57F File Offset: 0x0027B77F
		[NullableContext(1)]
		public IEnumerable<string> QuestDescriptionsIter()
		{
			InfrLevel.<QuestDescriptionsIter>d__73 <QuestDescriptionsIter>d__ = new InfrLevel.<QuestDescriptionsIter>d__73(-2);
			<QuestDescriptionsIter>d__.<>3__<>4__this = this;
			return <QuestDescriptionsIter>d__;
		}

		// Token: 0x0600898E RID: 35214 RVA: 0x0027D594 File Offset: 0x0027B794
		[NullableContext(1)]
		public int[] QuestIds()
		{
			return this.GetQuestIdsArray();
		}

		// Token: 0x0600898F RID: 35215 RVA: 0x0027D59C File Offset: 0x0027B79C
		[NullableContext(1)]
		public IEnumerable<int> QuestIdsIter()
		{
			InfrLevel.<QuestIdsIter>d__75 <QuestIdsIter>d__ = new InfrLevel.<QuestIdsIter>d__75(-2);
			<QuestIdsIter>d__.<>3__<>4__this = this;
			return <QuestIdsIter>d__;
		}

		// Token: 0x06008990 RID: 35216 RVA: 0x0027D5B4 File Offset: 0x0027B7B4
		[NullableContext(1)]
		public Dictionary<int, int> Requirement()
		{
			return this.RequirementIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x06008991 RID: 35217 RVA: 0x0027D60A File Offset: 0x0027B80A
		[NullableContext(1)]
		public IEnumerable<DicIntInt> RequirementIter()
		{
			InfrLevel.<RequirementIter>d__77 <RequirementIter>d__ = new InfrLevel.<RequirementIter>d__77(-2);
			<RequirementIter>d__.<>3__<>4__this = this;
			return <RequirementIter>d__;
		}

		// Token: 0x06008992 RID: 35218 RVA: 0x0027D620 File Offset: 0x0027B820
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

		// Token: 0x06008993 RID: 35219 RVA: 0x0027D654 File Offset: 0x0027B854
		private void EnsureRequirementCacheIfNeeded()
		{
			if (this.RequirementCache != null)
			{
				return;
			}
			this.RequirementCache = this.RequirementIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x06008994 RID: 35220 RVA: 0x0027D6BA File Offset: 0x0027B8BA
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetRequirementFrozenDict()
		{
			this.EnsureRequirementCacheIfNeeded();
			return this.RequirementCache;
		}

		// Token: 0x040053C9 RID: 21449
		private Table __p;

		// Token: 0x040053CA RID: 21450
		[Nullable(2)]
		private FrozenDictionary<int, int> RequirementCache;
	}
}
