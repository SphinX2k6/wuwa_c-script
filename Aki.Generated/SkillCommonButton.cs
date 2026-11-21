using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020011B7 RID: 4535
	[NullableContext(1)]
	[Nullable(0)]
	public struct SkillCommonButton : IFlatbufferObject
	{
		// Token: 0x1700379E RID: 14238
		// (get) Token: 0x0600DBFE RID: 56318 RVA: 0x00333FE1 File Offset: 0x003321E1
		[Nullable(0)]
		public ByteBuffer ByteBuffer
		{
			[NullableContext(0)]
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600DBFF RID: 56319 RVA: 0x00333FEE File Offset: 0x003321EE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600DC00 RID: 56320 RVA: 0x00333FF8 File Offset: 0x003321F8
		[NullableContext(0)]
		public static SkillCommonButton GetRootAsSkillCommonButton(ByteBuffer _bb)
		{
			return SkillCommonButton.GetRootAsSkillCommonButton(_bb, default(SkillCommonButton));
		}

		// Token: 0x0600DC01 RID: 56321 RVA: 0x00334014 File Offset: 0x00332214
		[NullableContext(0)]
		public static SkillCommonButton GetRootAsSkillCommonButton(ByteBuffer _bb, SkillCommonButton obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600DC02 RID: 56322 RVA: 0x00334031 File Offset: 0x00332231
		[NullableContext(0)]
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600DC03 RID: 56323 RVA: 0x00334040 File Offset: 0x00332240
		[NullableContext(0)]
		public SkillCommonButton __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700379F RID: 14239
		// (get) Token: 0x0600DC04 RID: 56324 RVA: 0x00334050 File Offset: 0x00332250
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

		// Token: 0x170037A0 RID: 14240
		// (get) Token: 0x0600DC05 RID: 56325 RVA: 0x0033408C File Offset: 0x0033228C
		[Nullable(0)]
		public string Name
		{
			[NullableContext(0)]
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

		// Token: 0x0600DC06 RID: 56326 RVA: 0x003340C3 File Offset: 0x003322C3
		[NullableContext(0)]
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600DC07 RID: 56327 RVA: 0x003340D2 File Offset: 0x003322D2
		[NullableContext(0)]
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170037A1 RID: 14241
		// (get) Token: 0x0600DC08 RID: 56328 RVA: 0x003340EC File Offset: 0x003322EC
		public int ButtonType
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

		// Token: 0x170037A2 RID: 14242
		// (get) Token: 0x0600DC09 RID: 56329 RVA: 0x00334128 File Offset: 0x00332328
		public int ActionType
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

		// Token: 0x170037A3 RID: 14243
		// (get) Token: 0x0600DC0A RID: 56330 RVA: 0x00334168 File Offset: 0x00332368
		public int SkillId
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

		// Token: 0x0600DC0B RID: 56331 RVA: 0x003341A8 File Offset: 0x003323A8
		public DicIntInt? SkillIdTagMap(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170037A4 RID: 14244
		// (get) Token: 0x0600DC0C RID: 56332 RVA: 0x0033420C File Offset: 0x0033240C
		public int SkillIdTagMapLength
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600DC0D RID: 56333 RVA: 0x00334238 File Offset: 0x00332438
		public int SkillIconTags(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170037A5 RID: 14245
		// (get) Token: 0x0600DC0E RID: 56334 RVA: 0x00334278 File Offset: 0x00332478
		public int SkillIconTagsLength
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600DC0F RID: 56335 RVA: 0x003342A4 File Offset: 0x003324A4
		[NullableContext(0)]
		public Span<int> GetSkillIconTagsBytes()
		{
			return this.__p.__vector_as_span<int>(16, 4);
		}

		// Token: 0x0600DC10 RID: 56336 RVA: 0x003342B4 File Offset: 0x003324B4
		[NullableContext(0)]
		public int[] GetSkillIconTagsArray()
		{
			return this.__p.__vector_as_array<int>(16) ?? Array.Empty<int>();
		}

		// Token: 0x0600DC11 RID: 56337 RVA: 0x003342CC File Offset: 0x003324CC
		public int EnableTags(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170037A6 RID: 14246
		// (get) Token: 0x0600DC12 RID: 56338 RVA: 0x0033430C File Offset: 0x0033250C
		public int EnableTagsLength
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

		// Token: 0x0600DC13 RID: 56339 RVA: 0x00334338 File Offset: 0x00332538
		[NullableContext(0)]
		public Span<int> GetEnableTagsBytes()
		{
			return this.__p.__vector_as_span<int>(18, 4);
		}

		// Token: 0x0600DC14 RID: 56340 RVA: 0x00334348 File Offset: 0x00332548
		[NullableContext(0)]
		public int[] GetEnableTagsArray()
		{
			return this.__p.__vector_as_array<int>(18) ?? Array.Empty<int>();
		}

		// Token: 0x0600DC15 RID: 56341 RVA: 0x00334360 File Offset: 0x00332560
		public int DisableTags(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170037A7 RID: 14247
		// (get) Token: 0x0600DC16 RID: 56342 RVA: 0x003343A0 File Offset: 0x003325A0
		public int DisableTagsLength
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

		// Token: 0x0600DC17 RID: 56343 RVA: 0x003343CC File Offset: 0x003325CC
		[NullableContext(0)]
		public Span<int> GetDisableTagsBytes()
		{
			return this.__p.__vector_as_span<int>(20, 4);
		}

		// Token: 0x0600DC18 RID: 56344 RVA: 0x003343DC File Offset: 0x003325DC
		[NullableContext(0)]
		public int[] GetDisableTagsArray()
		{
			return this.__p.__vector_as_array<int>(20) ?? Array.Empty<int>();
		}

		// Token: 0x0600DC19 RID: 56345 RVA: 0x003343F4 File Offset: 0x003325F4
		public DicIntIntArray? DisableSkillIdTags(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return null;
			}
			return new DicIntIntArray?(default(DicIntIntArray).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170037A8 RID: 14248
		// (get) Token: 0x0600DC1A RID: 56346 RVA: 0x00334458 File Offset: 0x00332658
		public int DisableSkillIdTagsLength
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600DC1B RID: 56347 RVA: 0x00334484 File Offset: 0x00332684
		public int VisibleTags(int j)
		{
			int num = this.__p.__offset(24);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170037A9 RID: 14249
		// (get) Token: 0x0600DC1C RID: 56348 RVA: 0x003344C4 File Offset: 0x003326C4
		public int VisibleTagsLength
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

		// Token: 0x0600DC1D RID: 56349 RVA: 0x003344F0 File Offset: 0x003326F0
		[NullableContext(0)]
		public Span<int> GetVisibleTagsBytes()
		{
			return this.__p.__vector_as_span<int>(24, 4);
		}

		// Token: 0x0600DC1E RID: 56350 RVA: 0x00334500 File Offset: 0x00332700
		[NullableContext(0)]
		public int[] GetVisibleTagsArray()
		{
			return this.__p.__vector_as_array<int>(24) ?? Array.Empty<int>();
		}

		// Token: 0x0600DC1F RID: 56351 RVA: 0x00334518 File Offset: 0x00332718
		public int HiddenTags(int j)
		{
			int num = this.__p.__offset(26);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170037AA RID: 14250
		// (get) Token: 0x0600DC20 RID: 56352 RVA: 0x00334558 File Offset: 0x00332758
		public int HiddenTagsLength
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

		// Token: 0x0600DC21 RID: 56353 RVA: 0x00334584 File Offset: 0x00332784
		[NullableContext(0)]
		public Span<int> GetHiddenTagsBytes()
		{
			return this.__p.__vector_as_span<int>(26, 4);
		}

		// Token: 0x0600DC22 RID: 56354 RVA: 0x00334594 File Offset: 0x00332794
		[NullableContext(0)]
		public int[] GetHiddenTagsArray()
		{
			return this.__p.__vector_as_array<int>(26) ?? Array.Empty<int>();
		}

		// Token: 0x170037AB RID: 14251
		// (get) Token: 0x0600DC23 RID: 56355 RVA: 0x003345AC File Offset: 0x003327AC
		public bool IsCdVisible
		{
			get
			{
				int num = this.__p.__offset(28);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170037AC RID: 14252
		// (get) Token: 0x0600DC24 RID: 56356 RVA: 0x003345EC File Offset: 0x003327EC
		public int AttributeId
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170037AD RID: 14253
		// (get) Token: 0x0600DC25 RID: 56357 RVA: 0x0033462C File Offset: 0x0033282C
		public int MaxAttributeId
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600DC26 RID: 56358 RVA: 0x0033466C File Offset: 0x0033286C
		public DicIntIntArray? AttributeIdTagMap(int j)
		{
			int num = this.__p.__offset(34);
			if (num == 0)
			{
				return null;
			}
			return new DicIntIntArray?(default(DicIntIntArray).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170037AE RID: 14254
		// (get) Token: 0x0600DC27 RID: 56359 RVA: 0x003346D0 File Offset: 0x003328D0
		public int AttributeIdTagMapLength
		{
			get
			{
				int num = this.__p.__offset(34);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600DC28 RID: 56360 RVA: 0x003346FC File Offset: 0x003328FC
		public int AttributeEnableTags(int j)
		{
			int num = this.__p.__offset(36);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170037AF RID: 14255
		// (get) Token: 0x0600DC29 RID: 56361 RVA: 0x0033473C File Offset: 0x0033293C
		public int AttributeEnableTagsLength
		{
			get
			{
				int num = this.__p.__offset(36);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600DC2A RID: 56362 RVA: 0x00334768 File Offset: 0x00332968
		[NullableContext(0)]
		public Span<int> GetAttributeEnableTagsBytes()
		{
			return this.__p.__vector_as_span<int>(36, 4);
		}

		// Token: 0x0600DC2B RID: 56363 RVA: 0x00334778 File Offset: 0x00332978
		[NullableContext(0)]
		public int[] GetAttributeEnableTagsArray()
		{
			return this.__p.__vector_as_array<int>(36) ?? Array.Empty<int>();
		}

		// Token: 0x0600DC2C RID: 56364 RVA: 0x00334790 File Offset: 0x00332990
		public DicIntInt? FormationAttributeIdTagMap(int j)
		{
			int num = this.__p.__offset(38);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170037B0 RID: 14256
		// (get) Token: 0x0600DC2D RID: 56365 RVA: 0x003347F4 File Offset: 0x003329F4
		public int FormationAttributeIdTagMapLength
		{
			get
			{
				int num = this.__p.__offset(38);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x170037B1 RID: 14257
		// (get) Token: 0x0600DC2E RID: 56366 RVA: 0x00334820 File Offset: 0x00332A20
		public int MaxAttributeBurstEffectId
		{
			get
			{
				int num = this.__p.__offset(40);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170037B2 RID: 14258
		// (get) Token: 0x0600DC2F RID: 56367 RVA: 0x00334860 File Offset: 0x00332A60
		public int CdCompletedEffectId
		{
			get
			{
				int num = this.__p.__offset(42);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170037B3 RID: 14259
		// (get) Token: 0x0600DC30 RID: 56368 RVA: 0x003348A0 File Offset: 0x00332AA0
		public bool IsLongPressControlCamera
		{
			get
			{
				int num = this.__p.__offset(44);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170037B4 RID: 14260
		// (get) Token: 0x0600DC31 RID: 56369 RVA: 0x003348E0 File Offset: 0x00332AE0
		public int LongPressTime
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

		// Token: 0x0600DC32 RID: 56370 RVA: 0x00334920 File Offset: 0x00332B20
		public DicIntInt? DynamicEffectTagMap(int j)
		{
			int num = this.__p.__offset(48);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170037B5 RID: 14261
		// (get) Token: 0x0600DC33 RID: 56371 RVA: 0x00334984 File Offset: 0x00332B84
		public int DynamicEffectTagMapLength
		{
			get
			{
				int num = this.__p.__offset(48);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600DC34 RID: 56372 RVA: 0x003349B0 File Offset: 0x00332BB0
		public int ShowLongPressTags(int j)
		{
			int num = this.__p.__offset(50);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170037B6 RID: 14262
		// (get) Token: 0x0600DC35 RID: 56373 RVA: 0x003349F0 File Offset: 0x00332BF0
		public int ShowLongPressTagsLength
		{
			get
			{
				int num = this.__p.__offset(50);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600DC36 RID: 56374 RVA: 0x00334A1C File Offset: 0x00332C1C
		[NullableContext(0)]
		public Span<int> GetShowLongPressTagsBytes()
		{
			return this.__p.__vector_as_span<int>(50, 4);
		}

		// Token: 0x0600DC37 RID: 56375 RVA: 0x00334A2C File Offset: 0x00332C2C
		[NullableContext(0)]
		public int[] GetShowLongPressTagsArray()
		{
			return this.__p.__vector_as_array<int>(50) ?? Array.Empty<int>();
		}

		// Token: 0x170037B7 RID: 14263
		// (get) Token: 0x0600DC38 RID: 56376 RVA: 0x00334A44 File Offset: 0x00332C44
		public int CustomHandleId
		{
			get
			{
				int num = this.__p.__offset(52);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600DC39 RID: 56377 RVA: 0x00334A84 File Offset: 0x00332C84
		public int CustomHandleIds(int j)
		{
			int num = this.__p.__offset(54);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170037B8 RID: 14264
		// (get) Token: 0x0600DC3A RID: 56378 RVA: 0x00334AC4 File Offset: 0x00332CC4
		public int CustomHandleIdsLength
		{
			get
			{
				int num = this.__p.__offset(54);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600DC3B RID: 56379 RVA: 0x00334AF0 File Offset: 0x00332CF0
		[NullableContext(0)]
		public Span<int> GetCustomHandleIdsBytes()
		{
			return this.__p.__vector_as_span<int>(54, 4);
		}

		// Token: 0x0600DC3C RID: 56380 RVA: 0x00334B00 File Offset: 0x00332D00
		[NullableContext(0)]
		public int[] GetCustomHandleIdsArray()
		{
			return this.__p.__vector_as_array<int>(54) ?? Array.Empty<int>();
		}

		// Token: 0x0600DC3D RID: 56381 RVA: 0x00334B18 File Offset: 0x00332D18
		public int[] AttributeEnableTags()
		{
			return this.GetAttributeEnableTagsArray();
		}

		// Token: 0x0600DC3E RID: 56382 RVA: 0x00334B20 File Offset: 0x00332D20
		public IEnumerable<int> AttributeEnableTagsIter()
		{
			SkillCommonButton.<AttributeEnableTagsIter>d__92 <AttributeEnableTagsIter>d__ = new SkillCommonButton.<AttributeEnableTagsIter>d__92(-2);
			<AttributeEnableTagsIter>d__.<>3__<>4__this = this;
			return <AttributeEnableTagsIter>d__;
		}

		// Token: 0x0600DC3F RID: 56383 RVA: 0x00334B38 File Offset: 0x00332D38
		public Dictionary<int, IntArray> AttributeIdTagMap()
		{
			return this.AttributeIdTagMapIter().ToDictionary((DicIntIntArray element) => element.Key, (DicIntIntArray element) => element.Value.Value);
		}

		// Token: 0x0600DC40 RID: 56384 RVA: 0x00334B8E File Offset: 0x00332D8E
		public IEnumerable<DicIntIntArray> AttributeIdTagMapIter()
		{
			SkillCommonButton.<AttributeIdTagMapIter>d__94 <AttributeIdTagMapIter>d__ = new SkillCommonButton.<AttributeIdTagMapIter>d__94(-2);
			<AttributeIdTagMapIter>d__.<>3__<>4__this = this;
			return <AttributeIdTagMapIter>d__;
		}

		// Token: 0x0600DC41 RID: 56385 RVA: 0x00334BA3 File Offset: 0x00332DA3
		public int[] CustomHandleIds()
		{
			return this.GetCustomHandleIdsArray();
		}

		// Token: 0x0600DC42 RID: 56386 RVA: 0x00334BAB File Offset: 0x00332DAB
		public IEnumerable<int> CustomHandleIdsIter()
		{
			SkillCommonButton.<CustomHandleIdsIter>d__96 <CustomHandleIdsIter>d__ = new SkillCommonButton.<CustomHandleIdsIter>d__96(-2);
			<CustomHandleIdsIter>d__.<>3__<>4__this = this;
			return <CustomHandleIdsIter>d__;
		}

		// Token: 0x0600DC43 RID: 56387 RVA: 0x00334BC0 File Offset: 0x00332DC0
		public Dictionary<int, IntArray> DisableSkillIdTags()
		{
			return this.DisableSkillIdTagsIter().ToDictionary((DicIntIntArray element) => element.Key, (DicIntIntArray element) => element.Value.Value);
		}

		// Token: 0x0600DC44 RID: 56388 RVA: 0x00334C16 File Offset: 0x00332E16
		public IEnumerable<DicIntIntArray> DisableSkillIdTagsIter()
		{
			SkillCommonButton.<DisableSkillIdTagsIter>d__98 <DisableSkillIdTagsIter>d__ = new SkillCommonButton.<DisableSkillIdTagsIter>d__98(-2);
			<DisableSkillIdTagsIter>d__.<>3__<>4__this = this;
			return <DisableSkillIdTagsIter>d__;
		}

		// Token: 0x0600DC45 RID: 56389 RVA: 0x00334C2B File Offset: 0x00332E2B
		public int[] DisableTags()
		{
			return this.GetDisableTagsArray();
		}

		// Token: 0x0600DC46 RID: 56390 RVA: 0x00334C33 File Offset: 0x00332E33
		public IEnumerable<int> DisableTagsIter()
		{
			SkillCommonButton.<DisableTagsIter>d__100 <DisableTagsIter>d__ = new SkillCommonButton.<DisableTagsIter>d__100(-2);
			<DisableTagsIter>d__.<>3__<>4__this = this;
			return <DisableTagsIter>d__;
		}

		// Token: 0x0600DC47 RID: 56391 RVA: 0x00334C48 File Offset: 0x00332E48
		public Dictionary<int, int> DynamicEffectTagMap()
		{
			return this.DynamicEffectTagMapIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600DC48 RID: 56392 RVA: 0x00334C9E File Offset: 0x00332E9E
		public IEnumerable<DicIntInt> DynamicEffectTagMapIter()
		{
			SkillCommonButton.<DynamicEffectTagMapIter>d__102 <DynamicEffectTagMapIter>d__ = new SkillCommonButton.<DynamicEffectTagMapIter>d__102(-2);
			<DynamicEffectTagMapIter>d__.<>3__<>4__this = this;
			return <DynamicEffectTagMapIter>d__;
		}

		// Token: 0x0600DC49 RID: 56393 RVA: 0x00334CB3 File Offset: 0x00332EB3
		public int[] EnableTags()
		{
			return this.GetEnableTagsArray();
		}

		// Token: 0x0600DC4A RID: 56394 RVA: 0x00334CBB File Offset: 0x00332EBB
		public IEnumerable<int> EnableTagsIter()
		{
			SkillCommonButton.<EnableTagsIter>d__104 <EnableTagsIter>d__ = new SkillCommonButton.<EnableTagsIter>d__104(-2);
			<EnableTagsIter>d__.<>3__<>4__this = this;
			return <EnableTagsIter>d__;
		}

		// Token: 0x0600DC4B RID: 56395 RVA: 0x00334CD0 File Offset: 0x00332ED0
		public Dictionary<int, int> FormationAttributeIdTagMap()
		{
			return this.FormationAttributeIdTagMapIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600DC4C RID: 56396 RVA: 0x00334D26 File Offset: 0x00332F26
		public IEnumerable<DicIntInt> FormationAttributeIdTagMapIter()
		{
			SkillCommonButton.<FormationAttributeIdTagMapIter>d__106 <FormationAttributeIdTagMapIter>d__ = new SkillCommonButton.<FormationAttributeIdTagMapIter>d__106(-2);
			<FormationAttributeIdTagMapIter>d__.<>3__<>4__this = this;
			return <FormationAttributeIdTagMapIter>d__;
		}

		// Token: 0x0600DC4D RID: 56397 RVA: 0x00334D3B File Offset: 0x00332F3B
		public int[] HiddenTags()
		{
			return this.GetHiddenTagsArray();
		}

		// Token: 0x0600DC4E RID: 56398 RVA: 0x00334D43 File Offset: 0x00332F43
		public IEnumerable<int> HiddenTagsIter()
		{
			SkillCommonButton.<HiddenTagsIter>d__108 <HiddenTagsIter>d__ = new SkillCommonButton.<HiddenTagsIter>d__108(-2);
			<HiddenTagsIter>d__.<>3__<>4__this = this;
			return <HiddenTagsIter>d__;
		}

		// Token: 0x0600DC4F RID: 56399 RVA: 0x00334D58 File Offset: 0x00332F58
		public int[] ShowLongPressTags()
		{
			return this.GetShowLongPressTagsArray();
		}

		// Token: 0x0600DC50 RID: 56400 RVA: 0x00334D60 File Offset: 0x00332F60
		public IEnumerable<int> ShowLongPressTagsIter()
		{
			SkillCommonButton.<ShowLongPressTagsIter>d__110 <ShowLongPressTagsIter>d__ = new SkillCommonButton.<ShowLongPressTagsIter>d__110(-2);
			<ShowLongPressTagsIter>d__.<>3__<>4__this = this;
			return <ShowLongPressTagsIter>d__;
		}

		// Token: 0x0600DC51 RID: 56401 RVA: 0x00334D75 File Offset: 0x00332F75
		public int[] SkillIconTags()
		{
			return this.GetSkillIconTagsArray();
		}

		// Token: 0x0600DC52 RID: 56402 RVA: 0x00334D7D File Offset: 0x00332F7D
		public IEnumerable<int> SkillIconTagsIter()
		{
			SkillCommonButton.<SkillIconTagsIter>d__112 <SkillIconTagsIter>d__ = new SkillCommonButton.<SkillIconTagsIter>d__112(-2);
			<SkillIconTagsIter>d__.<>3__<>4__this = this;
			return <SkillIconTagsIter>d__;
		}

		// Token: 0x0600DC53 RID: 56403 RVA: 0x00334D94 File Offset: 0x00332F94
		public Dictionary<int, int> SkillIdTagMap()
		{
			return this.SkillIdTagMapIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600DC54 RID: 56404 RVA: 0x00334DEA File Offset: 0x00332FEA
		public IEnumerable<DicIntInt> SkillIdTagMapIter()
		{
			SkillCommonButton.<SkillIdTagMapIter>d__114 <SkillIdTagMapIter>d__ = new SkillCommonButton.<SkillIdTagMapIter>d__114(-2);
			<SkillIdTagMapIter>d__.<>3__<>4__this = this;
			return <SkillIdTagMapIter>d__;
		}

		// Token: 0x0600DC55 RID: 56405 RVA: 0x00334DFF File Offset: 0x00332FFF
		public int[] VisibleTags()
		{
			return this.GetVisibleTagsArray();
		}

		// Token: 0x0600DC56 RID: 56406 RVA: 0x00334E07 File Offset: 0x00333007
		public IEnumerable<int> VisibleTagsIter()
		{
			SkillCommonButton.<VisibleTagsIter>d__116 <VisibleTagsIter>d__ = new SkillCommonButton.<VisibleTagsIter>d__116(-2);
			<VisibleTagsIter>d__.<>3__<>4__this = this;
			return <VisibleTagsIter>d__;
		}

		// Token: 0x0600DC57 RID: 56407 RVA: 0x00334E1C File Offset: 0x0033301C
		public IntArray? GetAttributeIdTagMap(int key)
		{
			this.EnsureAttributeIdTagMapCacheIfNeeded();
			IntArray value;
			if (!this.AttributeIdTagMapCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new IntArray?(value);
		}

		// Token: 0x0600DC58 RID: 56408 RVA: 0x00334E50 File Offset: 0x00333050
		public IntArray? GetDisableSkillIdTags(int key)
		{
			this.EnsureDisableSkillIdTagsCacheIfNeeded();
			IntArray value;
			if (!this.DisableSkillIdTagsCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new IntArray?(value);
		}

		// Token: 0x0600DC59 RID: 56409 RVA: 0x00334E84 File Offset: 0x00333084
		public int? GetDynamicEffectTagMap(int key)
		{
			this.EnsureDynamicEffectTagMapCacheIfNeeded();
			int value;
			if (!this.DynamicEffectTagMapCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x0600DC5A RID: 56410 RVA: 0x00334EB8 File Offset: 0x003330B8
		public int? GetFormationAttributeIdTagMap(int key)
		{
			this.EnsureFormationAttributeIdTagMapCacheIfNeeded();
			int value;
			if (!this.FormationAttributeIdTagMapCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x0600DC5B RID: 56411 RVA: 0x00334EEC File Offset: 0x003330EC
		public int? GetSkillIdTagMap(int key)
		{
			this.EnsureSkillIdTagMapCacheIfNeeded();
			int value;
			if (!this.SkillIdTagMapCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x0600DC5C RID: 56412 RVA: 0x00334F20 File Offset: 0x00333120
		private void EnsureAttributeIdTagMapCacheIfNeeded()
		{
			if (this.AttributeIdTagMapCache != null)
			{
				return;
			}
			this.AttributeIdTagMapCache = this.AttributeIdTagMapIter().ToFrozenDictionary((DicIntIntArray kvp) => kvp.Key, (DicIntIntArray kvp) => kvp.Value.Value, null);
		}

		// Token: 0x0600DC5D RID: 56413 RVA: 0x00334F88 File Offset: 0x00333188
		private void EnsureDisableSkillIdTagsCacheIfNeeded()
		{
			if (this.DisableSkillIdTagsCache != null)
			{
				return;
			}
			this.DisableSkillIdTagsCache = this.DisableSkillIdTagsIter().ToFrozenDictionary((DicIntIntArray kvp) => kvp.Key, (DicIntIntArray kvp) => kvp.Value.Value, null);
		}

		// Token: 0x0600DC5E RID: 56414 RVA: 0x00334FF0 File Offset: 0x003331F0
		private void EnsureDynamicEffectTagMapCacheIfNeeded()
		{
			if (this.DynamicEffectTagMapCache != null)
			{
				return;
			}
			this.DynamicEffectTagMapCache = this.DynamicEffectTagMapIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600DC5F RID: 56415 RVA: 0x00335058 File Offset: 0x00333258
		private void EnsureFormationAttributeIdTagMapCacheIfNeeded()
		{
			if (this.FormationAttributeIdTagMapCache != null)
			{
				return;
			}
			this.FormationAttributeIdTagMapCache = this.FormationAttributeIdTagMapIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600DC60 RID: 56416 RVA: 0x003350C0 File Offset: 0x003332C0
		private void EnsureSkillIdTagMapCacheIfNeeded()
		{
			if (this.SkillIdTagMapCache != null)
			{
				return;
			}
			this.SkillIdTagMapCache = this.SkillIdTagMapIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600DC61 RID: 56417 RVA: 0x00335126 File Offset: 0x00333326
		public FrozenDictionary<int, IntArray> GetAttributeIdTagMapFrozenDict()
		{
			this.EnsureAttributeIdTagMapCacheIfNeeded();
			return this.AttributeIdTagMapCache;
		}

		// Token: 0x0600DC62 RID: 56418 RVA: 0x00335134 File Offset: 0x00333334
		public FrozenDictionary<int, IntArray> GetDisableSkillIdTagsFrozenDict()
		{
			this.EnsureDisableSkillIdTagsCacheIfNeeded();
			return this.DisableSkillIdTagsCache;
		}

		// Token: 0x0600DC63 RID: 56419 RVA: 0x00335142 File Offset: 0x00333342
		public FrozenDictionary<int, int> GetDynamicEffectTagMapFrozenDict()
		{
			this.EnsureDynamicEffectTagMapCacheIfNeeded();
			return this.DynamicEffectTagMapCache;
		}

		// Token: 0x0600DC64 RID: 56420 RVA: 0x00335150 File Offset: 0x00333350
		public FrozenDictionary<int, int> GetFormationAttributeIdTagMapFrozenDict()
		{
			this.EnsureFormationAttributeIdTagMapCacheIfNeeded();
			return this.FormationAttributeIdTagMapCache;
		}

		// Token: 0x0600DC65 RID: 56421 RVA: 0x0033515E File Offset: 0x0033335E
		public FrozenDictionary<int, int> GetSkillIdTagMapFrozenDict()
		{
			this.EnsureSkillIdTagMapCacheIfNeeded();
			return this.SkillIdTagMapCache;
		}

		// Token: 0x040057DA RID: 22490
		private Table __p;

		// Token: 0x040057DB RID: 22491
		[Nullable(2)]
		private FrozenDictionary<int, IntArray> AttributeIdTagMapCache;

		// Token: 0x040057DC RID: 22492
		[Nullable(2)]
		private FrozenDictionary<int, IntArray> DisableSkillIdTagsCache;

		// Token: 0x040057DD RID: 22493
		[Nullable(2)]
		private FrozenDictionary<int, int> DynamicEffectTagMapCache;

		// Token: 0x040057DE RID: 22494
		[Nullable(2)]
		private FrozenDictionary<int, int> FormationAttributeIdTagMapCache;

		// Token: 0x040057DF RID: 22495
		[Nullable(2)]
		private FrozenDictionary<int, int> SkillIdTagMapCache;
	}
}
