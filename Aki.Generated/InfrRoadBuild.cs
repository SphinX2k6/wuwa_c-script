using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E4E RID: 3662
	public struct InfrRoadBuild : IFlatbufferObject
	{
		// Token: 0x1700196A RID: 6506
		// (get) Token: 0x060089B5 RID: 35253 RVA: 0x0027DA58 File Offset: 0x0027BC58
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060089B6 RID: 35254 RVA: 0x0027DA65 File Offset: 0x0027BC65
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060089B7 RID: 35255 RVA: 0x0027DA6C File Offset: 0x0027BC6C
		public static InfrRoadBuild GetRootAsInfrRoadBuild(ByteBuffer _bb)
		{
			return InfrRoadBuild.GetRootAsInfrRoadBuild(_bb, default(InfrRoadBuild));
		}

		// Token: 0x060089B8 RID: 35256 RVA: 0x0027DA88 File Offset: 0x0027BC88
		public static InfrRoadBuild GetRootAsInfrRoadBuild(ByteBuffer _bb, InfrRoadBuild obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060089B9 RID: 35257 RVA: 0x0027DAA5 File Offset: 0x0027BCA5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060089BA RID: 35258 RVA: 0x0027DAB4 File Offset: 0x0027BCB4
		public InfrRoadBuild __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700196B RID: 6507
		// (get) Token: 0x060089BB RID: 35259 RVA: 0x0027DAC4 File Offset: 0x0027BCC4
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

		// Token: 0x1700196C RID: 6508
		// (get) Token: 0x060089BC RID: 35260 RVA: 0x0027DB00 File Offset: 0x0027BD00
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

		// Token: 0x1700196D RID: 6509
		// (get) Token: 0x060089BD RID: 35261 RVA: 0x0027DB3C File Offset: 0x0027BD3C
		public int DungeonId
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

		// Token: 0x1700196E RID: 6510
		// (get) Token: 0x060089BE RID: 35262 RVA: 0x0027DB78 File Offset: 0x0027BD78
		public int ConditionId
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

		// Token: 0x1700196F RID: 6511
		// (get) Token: 0x060089BF RID: 35263 RVA: 0x0027DBB8 File Offset: 0x0027BDB8
		public int BuildQuest
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

		// Token: 0x17001970 RID: 6512
		// (get) Token: 0x060089C0 RID: 35264 RVA: 0x0027DBF8 File Offset: 0x0027BDF8
		public int BuildConditionQuestId
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

		// Token: 0x17001971 RID: 6513
		// (get) Token: 0x060089C1 RID: 35265 RVA: 0x0027DC38 File Offset: 0x0027BE38
		public int JumpId
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

		// Token: 0x17001972 RID: 6514
		// (get) Token: 0x060089C2 RID: 35266 RVA: 0x0027DC78 File Offset: 0x0027BE78
		public int Difficulty
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060089C3 RID: 35267 RVA: 0x0027DCB8 File Offset: 0x0027BEB8
		public DicIntInt? Requirement(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17001973 RID: 6515
		// (get) Token: 0x060089C4 RID: 35268 RVA: 0x0027DD1C File Offset: 0x0027BF1C
		public int RequirementLength
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

		// Token: 0x17001974 RID: 6516
		// (get) Token: 0x060089C5 RID: 35269 RVA: 0x0027DD48 File Offset: 0x0027BF48
		public int FireExpReward
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

		// Token: 0x17001975 RID: 6517
		// (get) Token: 0x060089C6 RID: 35270 RVA: 0x0027DD88 File Offset: 0x0027BF88
		public int GiftCount
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001976 RID: 6518
		// (get) Token: 0x060089C7 RID: 35271 RVA: 0x0027DDC8 File Offset: 0x0027BFC8
		public int GiftCD
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060089C8 RID: 35272 RVA: 0x0027DE08 File Offset: 0x0027C008
		public DicIntInt? WeightPasser(int j)
		{
			int num = this.__p.__offset(28);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17001977 RID: 6519
		// (get) Token: 0x060089C9 RID: 35273 RVA: 0x0027DE6C File Offset: 0x0027C06C
		public int WeightPasserLength
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

		// Token: 0x060089CA RID: 35274 RVA: 0x0027DE98 File Offset: 0x0027C098
		public int LoadDataLayers(int j)
		{
			int num = this.__p.__offset(30);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001978 RID: 6520
		// (get) Token: 0x060089CB RID: 35275 RVA: 0x0027DED8 File Offset: 0x0027C0D8
		public int LoadDataLayersLength
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

		// Token: 0x060089CC RID: 35276 RVA: 0x0027DF04 File Offset: 0x0027C104
		public Span<int> GetLoadDataLayersBytes()
		{
			return this.__p.__vector_as_span<int>(30, 4);
		}

		// Token: 0x060089CD RID: 35277 RVA: 0x0027DF14 File Offset: 0x0027C114
		public int[] GetLoadDataLayersArray()
		{
			return this.__p.__vector_as_array<int>(30) ?? Array.Empty<int>();
		}

		// Token: 0x060089CE RID: 35278 RVA: 0x0027DF2C File Offset: 0x0027C12C
		public int UnloadDataLayers(int j)
		{
			int num = this.__p.__offset(32);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001979 RID: 6521
		// (get) Token: 0x060089CF RID: 35279 RVA: 0x0027DF6C File Offset: 0x0027C16C
		public int UnloadDataLayersLength
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

		// Token: 0x060089D0 RID: 35280 RVA: 0x0027DF98 File Offset: 0x0027C198
		public Span<int> GetUnloadDataLayersBytes()
		{
			return this.__p.__vector_as_span<int>(32, 4);
		}

		// Token: 0x060089D1 RID: 35281 RVA: 0x0027DFA8 File Offset: 0x0027C1A8
		public int[] GetUnloadDataLayersArray()
		{
			return this.__p.__vector_as_array<int>(32) ?? Array.Empty<int>();
		}

		// Token: 0x1700197A RID: 6522
		// (get) Token: 0x060089D2 RID: 35282 RVA: 0x0027DFC0 File Offset: 0x0027C1C0
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

		// Token: 0x060089D3 RID: 35283 RVA: 0x0027DFF8 File Offset: 0x0027C1F8
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(34, 1);
		}

		// Token: 0x060089D4 RID: 35284 RVA: 0x0027E008 File Offset: 0x0027C208
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(34) ?? Array.Empty<byte>();
		}

		// Token: 0x1700197B RID: 6523
		// (get) Token: 0x060089D5 RID: 35285 RVA: 0x0027E020 File Offset: 0x0027C220
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

		// Token: 0x060089D6 RID: 35286 RVA: 0x0027E058 File Offset: 0x0027C258
		public Span<byte> GetDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(36, 1);
		}

		// Token: 0x060089D7 RID: 35287 RVA: 0x0027E068 File Offset: 0x0027C268
		public byte[] GetDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(36) ?? Array.Empty<byte>();
		}

		// Token: 0x1700197C RID: 6524
		// (get) Token: 0x060089D8 RID: 35288 RVA: 0x0027E080 File Offset: 0x0027C280
		public string BuildDoneDes
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

		// Token: 0x060089D9 RID: 35289 RVA: 0x0027E0B8 File Offset: 0x0027C2B8
		public Span<byte> GetBuildDoneDesBytes()
		{
			return this.__p.__vector_as_span<byte>(38, 1);
		}

		// Token: 0x060089DA RID: 35290 RVA: 0x0027E0C8 File Offset: 0x0027C2C8
		public byte[] GetBuildDoneDesArray()
		{
			return this.__p.__vector_as_array<byte>(38) ?? Array.Empty<byte>();
		}

		// Token: 0x060089DB RID: 35291 RVA: 0x0027E0E0 File Offset: 0x0027C2E0
		public string EffectDes(int j)
		{
			int num = this.__p.__offset(40);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700197D RID: 6525
		// (get) Token: 0x060089DC RID: 35292 RVA: 0x0027E11C File Offset: 0x0027C31C
		public int EffectDesLength
		{
			get
			{
				int num = this.__p.__offset(40);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700197E RID: 6526
		// (get) Token: 0x060089DD RID: 35293 RVA: 0x0027E148 File Offset: 0x0027C348
		public string BuildDoneEffectDes
		{
			get
			{
				int num = this.__p.__offset(42);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060089DE RID: 35294 RVA: 0x0027E180 File Offset: 0x0027C380
		public Span<byte> GetBuildDoneEffectDesBytes()
		{
			return this.__p.__vector_as_span<byte>(42, 1);
		}

		// Token: 0x060089DF RID: 35295 RVA: 0x0027E190 File Offset: 0x0027C390
		public byte[] GetBuildDoneEffectDesArray()
		{
			return this.__p.__vector_as_array<byte>(42) ?? Array.Empty<byte>();
		}

		// Token: 0x1700197F RID: 6527
		// (get) Token: 0x060089E0 RID: 35296 RVA: 0x0027E1A8 File Offset: 0x0027C3A8
		public string QuestDescription
		{
			get
			{
				int num = this.__p.__offset(44);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060089E1 RID: 35297 RVA: 0x0027E1E0 File Offset: 0x0027C3E0
		public Span<byte> GetQuestDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(44, 1);
		}

		// Token: 0x060089E2 RID: 35298 RVA: 0x0027E1F0 File Offset: 0x0027C3F0
		public byte[] GetQuestDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(44) ?? Array.Empty<byte>();
		}

		// Token: 0x17001980 RID: 6528
		// (get) Token: 0x060089E3 RID: 35299 RVA: 0x0027E208 File Offset: 0x0027C408
		public int Length
		{
			get
			{
				int num = this.__p.__offset(46);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001981 RID: 6529
		// (get) Token: 0x060089E4 RID: 35300 RVA: 0x0027E248 File Offset: 0x0027C448
		public string InfoPicturePath
		{
			get
			{
				int num = this.__p.__offset(48);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060089E5 RID: 35301 RVA: 0x0027E280 File Offset: 0x0027C480
		public Span<byte> GetInfoPicturePathBytes()
		{
			return this.__p.__vector_as_span<byte>(48, 1);
		}

		// Token: 0x060089E6 RID: 35302 RVA: 0x0027E290 File Offset: 0x0027C490
		public byte[] GetInfoPicturePathArray()
		{
			return this.__p.__vector_as_array<byte>(48) ?? Array.Empty<byte>();
		}

		// Token: 0x17001982 RID: 6530
		// (get) Token: 0x060089E7 RID: 35303 RVA: 0x0027E2A8 File Offset: 0x0027C4A8
		public string BodyCameraSettingsName
		{
			get
			{
				int num = this.__p.__offset(50);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060089E8 RID: 35304 RVA: 0x0027E2E0 File Offset: 0x0027C4E0
		public Span<byte> GetBodyCameraSettingsNameBytes()
		{
			return this.__p.__vector_as_span<byte>(50, 1);
		}

		// Token: 0x060089E9 RID: 35305 RVA: 0x0027E2F0 File Offset: 0x0027C4F0
		public byte[] GetBodyCameraSettingsNameArray()
		{
			return this.__p.__vector_as_array<byte>(50) ?? Array.Empty<byte>();
		}

		// Token: 0x17001983 RID: 6531
		// (get) Token: 0x060089EA RID: 35306 RVA: 0x0027E308 File Offset: 0x0027C508
		public bool DisableMark
		{
			get
			{
				int num = this.__p.__offset(52);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x060089EB RID: 35307 RVA: 0x0027E348 File Offset: 0x0027C548
		[NullableContext(1)]
		public string[] EffectDes()
		{
			return this.EffectDesIter().ToArray<string>();
		}

		// Token: 0x060089EC RID: 35308 RVA: 0x0027E355 File Offset: 0x0027C555
		[NullableContext(1)]
		public IEnumerable<string> EffectDesIter()
		{
			InfrRoadBuild.<EffectDesIter>d__82 <EffectDesIter>d__ = new InfrRoadBuild.<EffectDesIter>d__82(-2);
			<EffectDesIter>d__.<>3__<>4__this = this;
			return <EffectDesIter>d__;
		}

		// Token: 0x060089ED RID: 35309 RVA: 0x0027E36A File Offset: 0x0027C56A
		[NullableContext(1)]
		public int[] LoadDataLayers()
		{
			return this.GetLoadDataLayersArray();
		}

		// Token: 0x060089EE RID: 35310 RVA: 0x0027E372 File Offset: 0x0027C572
		[NullableContext(1)]
		public IEnumerable<int> LoadDataLayersIter()
		{
			InfrRoadBuild.<LoadDataLayersIter>d__84 <LoadDataLayersIter>d__ = new InfrRoadBuild.<LoadDataLayersIter>d__84(-2);
			<LoadDataLayersIter>d__.<>3__<>4__this = this;
			return <LoadDataLayersIter>d__;
		}

		// Token: 0x060089EF RID: 35311 RVA: 0x0027E388 File Offset: 0x0027C588
		[NullableContext(1)]
		public Dictionary<int, int> Requirement()
		{
			return this.RequirementIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x060089F0 RID: 35312 RVA: 0x0027E3DE File Offset: 0x0027C5DE
		[NullableContext(1)]
		public IEnumerable<DicIntInt> RequirementIter()
		{
			InfrRoadBuild.<RequirementIter>d__86 <RequirementIter>d__ = new InfrRoadBuild.<RequirementIter>d__86(-2);
			<RequirementIter>d__.<>3__<>4__this = this;
			return <RequirementIter>d__;
		}

		// Token: 0x060089F1 RID: 35313 RVA: 0x0027E3F3 File Offset: 0x0027C5F3
		[NullableContext(1)]
		public int[] UnloadDataLayers()
		{
			return this.GetUnloadDataLayersArray();
		}

		// Token: 0x060089F2 RID: 35314 RVA: 0x0027E3FB File Offset: 0x0027C5FB
		[NullableContext(1)]
		public IEnumerable<int> UnloadDataLayersIter()
		{
			InfrRoadBuild.<UnloadDataLayersIter>d__88 <UnloadDataLayersIter>d__ = new InfrRoadBuild.<UnloadDataLayersIter>d__88(-2);
			<UnloadDataLayersIter>d__.<>3__<>4__this = this;
			return <UnloadDataLayersIter>d__;
		}

		// Token: 0x060089F3 RID: 35315 RVA: 0x0027E410 File Offset: 0x0027C610
		[NullableContext(1)]
		public Dictionary<int, int> WeightPasser()
		{
			return this.WeightPasserIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x060089F4 RID: 35316 RVA: 0x0027E466 File Offset: 0x0027C666
		[NullableContext(1)]
		public IEnumerable<DicIntInt> WeightPasserIter()
		{
			InfrRoadBuild.<WeightPasserIter>d__90 <WeightPasserIter>d__ = new InfrRoadBuild.<WeightPasserIter>d__90(-2);
			<WeightPasserIter>d__.<>3__<>4__this = this;
			return <WeightPasserIter>d__;
		}

		// Token: 0x060089F5 RID: 35317 RVA: 0x0027E47C File Offset: 0x0027C67C
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

		// Token: 0x060089F6 RID: 35318 RVA: 0x0027E4B0 File Offset: 0x0027C6B0
		public int? GetWeightPasser(int key)
		{
			this.EnsureWeightPasserCacheIfNeeded();
			int value;
			if (!this.WeightPasserCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x060089F7 RID: 35319 RVA: 0x0027E4E4 File Offset: 0x0027C6E4
		private void EnsureRequirementCacheIfNeeded()
		{
			if (this.RequirementCache != null)
			{
				return;
			}
			this.RequirementCache = this.RequirementIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x060089F8 RID: 35320 RVA: 0x0027E54C File Offset: 0x0027C74C
		private void EnsureWeightPasserCacheIfNeeded()
		{
			if (this.WeightPasserCache != null)
			{
				return;
			}
			this.WeightPasserCache = this.WeightPasserIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x060089F9 RID: 35321 RVA: 0x0027E5B2 File Offset: 0x0027C7B2
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetRequirementFrozenDict()
		{
			this.EnsureRequirementCacheIfNeeded();
			return this.RequirementCache;
		}

		// Token: 0x060089FA RID: 35322 RVA: 0x0027E5C0 File Offset: 0x0027C7C0
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetWeightPasserFrozenDict()
		{
			this.EnsureWeightPasserCacheIfNeeded();
			return this.WeightPasserCache;
		}

		// Token: 0x040053CE RID: 21454
		private Table __p;

		// Token: 0x040053CF RID: 21455
		[Nullable(2)]
		private FrozenDictionary<int, int> RequirementCache;

		// Token: 0x040053D0 RID: 21456
		[Nullable(2)]
		private FrozenDictionary<int, int> WeightPasserCache;
	}
}
