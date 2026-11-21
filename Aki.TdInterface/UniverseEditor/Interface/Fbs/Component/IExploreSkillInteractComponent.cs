using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Aki.UniverseEditor.Interface.Fbs.Match;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200574E RID: 22350
	public struct IExploreSkillInteractComponent : IFlatbufferObject
	{
		// Token: 0x1700A180 RID: 41344
		// (get) Token: 0x06023FF7 RID: 147447 RVA: 0x004F340E File Offset: 0x004F160E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06023FF8 RID: 147448 RVA: 0x004F341B File Offset: 0x004F161B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06023FF9 RID: 147449 RVA: 0x004F3424 File Offset: 0x004F1624
		public static IExploreSkillInteractComponent GetRootAsIExploreSkillInteractComponent(ByteBuffer _bb)
		{
			return IExploreSkillInteractComponent.GetRootAsIExploreSkillInteractComponent(_bb, default(IExploreSkillInteractComponent));
		}

		// Token: 0x06023FFA RID: 147450 RVA: 0x004F3440 File Offset: 0x004F1640
		public static IExploreSkillInteractComponent GetRootAsIExploreSkillInteractComponent(ByteBuffer _bb, IExploreSkillInteractComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06023FFB RID: 147451 RVA: 0x004F345D File Offset: 0x004F165D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06023FFC RID: 147452 RVA: 0x004F346C File Offset: 0x004F166C
		public IExploreSkillInteractComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A181 RID: 41345
		// (get) Token: 0x06023FFD RID: 147453 RVA: 0x004F347C File Offset: 0x004F167C
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A182 RID: 41346
		// (get) Token: 0x06023FFE RID: 147454 RVA: 0x004F34BC File Offset: 0x004F16BC
		public string ExploreSkillUiResource
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

		// Token: 0x06023FFF RID: 147455 RVA: 0x004F34F3 File Offset: 0x004F16F3
		public Span<byte> GetExploreSkillUiResourceBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06024000 RID: 147456 RVA: 0x004F3502 File Offset: 0x004F1702
		public byte[] GetExploreSkillUiResourceArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700A183 RID: 41347
		// (get) Token: 0x06024001 RID: 147457 RVA: 0x004F3510 File Offset: 0x004F1710
		public TExploreSkillInteractOption OptionType
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return TExploreSkillInteractOption.NONE;
				}
				return (TExploreSkillInteractOption)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06024002 RID: 147458 RVA: 0x004F354C File Offset: 0x004F174C
		public TTable? Option<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06024003 RID: 147459 RVA: 0x004F3594 File Offset: 0x004F1794
		public IExploreSkillArrowInteractPoint OptionAsIExploreSkillArrowInteractPoint()
		{
			return this.Option<IExploreSkillArrowInteractPoint>().Value;
		}

		// Token: 0x06024004 RID: 147460 RVA: 0x004F35B0 File Offset: 0x004F17B0
		public IExploreSkillCustom OptionAsIExploreSkillCustom()
		{
			return this.Option<IExploreSkillCustom>().Value;
		}

		// Token: 0x06024005 RID: 147461 RVA: 0x004F35CC File Offset: 0x004F17CC
		public IExploreSkillEavesdrop OptionAsIExploreSkillEavesdrop()
		{
			return this.Option<IExploreSkillEavesdrop>().Value;
		}

		// Token: 0x06024006 RID: 147462 RVA: 0x004F35E8 File Offset: 0x004F17E8
		public IExploreSkillGraffitiPuzzle OptionAsIExploreSkillGraffitiPuzzle()
		{
			return this.Option<IExploreSkillGraffitiPuzzle>().Value;
		}

		// Token: 0x06024007 RID: 147463 RVA: 0x004F3604 File Offset: 0x004F1804
		public IExploreSkillLonelyDollPollutant OptionAsIExploreSkillLonelyDollPollutant()
		{
			return this.Option<IExploreSkillLonelyDollPollutant>().Value;
		}

		// Token: 0x06024008 RID: 147464 RVA: 0x004F3620 File Offset: 0x004F1820
		public IExploreSkillMechascoutDrag OptionAsIExploreSkillMechascoutDrag()
		{
			return this.Option<IExploreSkillMechascoutDrag>().Value;
		}

		// Token: 0x06024009 RID: 147465 RVA: 0x004F363C File Offset: 0x004F183C
		public IExploreSkillPullGiant OptionAsIExploreSkillPullGiant()
		{
			return this.Option<IExploreSkillPullGiant>().Value;
		}

		// Token: 0x0602400A RID: 147466 RVA: 0x004F3658 File Offset: 0x004F1858
		public IExploreSkillPullStatue OptionAsIExploreSkillPullStatue()
		{
			return this.Option<IExploreSkillPullStatue>().Value;
		}

		// Token: 0x0602400B RID: 147467 RVA: 0x004F3674 File Offset: 0x004F1874
		public IExploreSkillQuantumDiffusion OptionAsIExploreSkillQuantumDiffusion()
		{
			return this.Option<IExploreSkillQuantumDiffusion>().Value;
		}

		// Token: 0x0602400C RID: 147468 RVA: 0x004F3690 File Offset: 0x004F1890
		public IExploreSkillRagDollCrushingRock OptionAsIExploreSkillRagDollCrushingRock()
		{
			return this.Option<IExploreSkillRagDollCrushingRock>().Value;
		}

		// Token: 0x0602400D RID: 147469 RVA: 0x004F36AC File Offset: 0x004F18AC
		public IExploreSkillRagDollDestroySolidRock OptionAsIExploreSkillRagDollDestroySolidRock()
		{
			return this.Option<IExploreSkillRagDollDestroySolidRock>().Value;
		}

		// Token: 0x0602400E RID: 147470 RVA: 0x004F36C8 File Offset: 0x004F18C8
		public IExploreSkillStatueInteractPoint OptionAsIExploreSkillStatueInteractPoint()
		{
			return this.Option<IExploreSkillStatueInteractPoint>().Value;
		}

		// Token: 0x0602400F RID: 147471 RVA: 0x004F36E4 File Offset: 0x004F18E4
		public IFollowShooterInteractPoint OptionAsIFollowShooterInteractPoint()
		{
			return this.Option<IFollowShooterInteractPoint>().Value;
		}

		// Token: 0x06024010 RID: 147472 RVA: 0x004F3700 File Offset: 0x004F1900
		public IFoxJumpInteractPoint OptionAsIFoxJumpInteractPoint()
		{
			return this.Option<IFoxJumpInteractPoint>().Value;
		}

		// Token: 0x06024011 RID: 147473 RVA: 0x004F371C File Offset: 0x004F191C
		public IMonsterSummonInteractPoint OptionAsIMonsterSummonInteractPoint()
		{
			return this.Option<IMonsterSummonInteractPoint>().Value;
		}

		// Token: 0x1700A184 RID: 41348
		// (get) Token: 0x06024012 RID: 147474 RVA: 0x004F3738 File Offset: 0x004F1938
		public int PlayerStateRestritionId
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

		// Token: 0x06024013 RID: 147475 RVA: 0x004F3778 File Offset: 0x004F1978
		public TMatchRoleOption MatchRoleOptionType(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return TMatchRoleOption.NONE;
			}
			return (TMatchRoleOption)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x1700A185 RID: 41349
		// (get) Token: 0x06024014 RID: 147476 RVA: 0x004F37B8 File Offset: 0x004F19B8
		public int MatchRoleOptionTypeLength
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

		// Token: 0x06024015 RID: 147477 RVA: 0x004F37E4 File Offset: 0x004F19E4
		public Span<TMatchRoleOption> GetMatchRoleOptionTypeBytes()
		{
			return this.__p.__vector_as_span<TMatchRoleOption>(14, 1);
		}

		// Token: 0x06024016 RID: 147478 RVA: 0x004F37F4 File Offset: 0x004F19F4
		public TMatchRoleOption[] GetMatchRoleOptionTypeArray()
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			int num2 = this.__p.__vector(num);
			int num3 = this.__p.__vector_len(num);
			TMatchRoleOption[] array = new TMatchRoleOption[num3];
			for (int i = 0; i < num3; i++)
			{
				array[i] = (TMatchRoleOption)this.__p.bb.Get(num2 + i);
			}
			return array;
		}

		// Token: 0x06024017 RID: 147479 RVA: 0x004F3860 File Offset: 0x004F1A60
		public TTable? MatchRoleOption<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x1700A186 RID: 41350
		// (get) Token: 0x06024018 RID: 147480 RVA: 0x004F38A8 File Offset: 0x004F1AA8
		public int MatchRoleOptionLength
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

		// Token: 0x1700A187 RID: 41351
		// (get) Token: 0x06024019 RID: 147481 RVA: 0x004F38D4 File Offset: 0x004F1AD4
		public IConditionGroup? Condition
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return null;
				}
				return new IConditionGroup?(default(IConditionGroup).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700A188 RID: 41352
		// (get) Token: 0x0602401A RID: 147482 RVA: 0x004F3934 File Offset: 0x004F1B34
		public TExploreSkillSearchTargetCfg SearchTargetCfgType
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return TExploreSkillSearchTargetCfg.NONE;
				}
				return (TExploreSkillSearchTargetCfg)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602401B RID: 147483 RVA: 0x004F3974 File Offset: 0x004F1B74
		public TTable? SearchTargetCfg<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602401C RID: 147484 RVA: 0x004F39BC File Offset: 0x004F1BBC
		public IAngleWeight SearchTargetCfgAsIAngleWeight()
		{
			return this.SearchTargetCfg<IAngleWeight>().Value;
		}

		// Token: 0x0602401D RID: 147485 RVA: 0x004F39D8 File Offset: 0x004F1BD8
		public IEnterScreenWeight SearchTargetCfgAsIEnterScreenWeight()
		{
			return this.SearchTargetCfg<IEnterScreenWeight>().Value;
		}

		// Token: 0x1700A189 RID: 41353
		// (get) Token: 0x0602401E RID: 147486 RVA: 0x004F39F4 File Offset: 0x004F1BF4
		public IIgnoresCollisionCfg? IgnoresCollisionCfg
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return null;
				}
				return new IIgnoresCollisionCfg?(default(IIgnoresCollisionCfg).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0602401F RID: 147487 RVA: 0x004F3A54 File Offset: 0x004F1C54
		public string SelfInteractBlockDetectionKeys(int j)
		{
			int num = this.__p.__offset(26);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700A18A RID: 41354
		// (get) Token: 0x06024020 RID: 147488 RVA: 0x004F3A90 File Offset: 0x004F1C90
		public int SelfInteractBlockDetectionKeysLength
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

		// Token: 0x1700A18B RID: 41355
		// (get) Token: 0x06024021 RID: 147489 RVA: 0x004F3ABC File Offset: 0x004F1CBC
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06024022 RID: 147490 RVA: 0x004F3AFC File Offset: 0x004F1CFC
		public static Offset<IExploreSkillInteractComponent> CreateIExploreSkillInteractComponent(FlatBufferBuilder builder, bool Disabled = false, StringOffset ExploreSkillUiResourceOffset = default(StringOffset), TExploreSkillInteractOption Option_type = TExploreSkillInteractOption.NONE, int OptionOffset = 0, int PlayerStateRestritionId = 0, VectorOffset MatchRoleOption_typeOffset = default(VectorOffset), VectorOffset MatchRoleOptionOffset = default(VectorOffset), Offset<IConditionGroup> ConditionOffset = default(Offset<IConditionGroup>), TExploreSkillSearchTargetCfg SearchTargetCfg_type = TExploreSkillSearchTargetCfg.NONE, int SearchTargetCfgOffset = 0, Offset<IIgnoresCollisionCfg> IgnoresCollisionCfgOffset = default(Offset<IIgnoresCollisionCfg>), VectorOffset SelfInteractBlockDetectionKeysOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(13);
			IExploreSkillInteractComponent.AddSelfInteractBlockDetectionKeys(builder, SelfInteractBlockDetectionKeysOffset);
			IExploreSkillInteractComponent.AddIgnoresCollisionCfg(builder, IgnoresCollisionCfgOffset);
			IExploreSkillInteractComponent.AddSearchTargetCfg(builder, SearchTargetCfgOffset);
			IExploreSkillInteractComponent.AddCondition(builder, ConditionOffset);
			IExploreSkillInteractComponent.AddMatchRoleOption(builder, MatchRoleOptionOffset);
			IExploreSkillInteractComponent.AddMatchRoleOptionType(builder, MatchRoleOption_typeOffset);
			IExploreSkillInteractComponent.AddPlayerStateRestritionId(builder, PlayerStateRestritionId);
			IExploreSkillInteractComponent.AddOption(builder, OptionOffset);
			IExploreSkillInteractComponent.AddExploreSkillUiResource(builder, ExploreSkillUiResourceOffset);
			IExploreSkillInteractComponent.AddNullMask(builder, NullMask);
			IExploreSkillInteractComponent.AddSearchTargetCfgType(builder, SearchTargetCfg_type);
			IExploreSkillInteractComponent.AddOptionType(builder, Option_type);
			IExploreSkillInteractComponent.AddDisabled(builder, Disabled);
			return IExploreSkillInteractComponent.EndIExploreSkillInteractComponent(builder);
		}

		// Token: 0x06024023 RID: 147491 RVA: 0x004F3B7C File Offset: 0x004F1D7C
		public static void StartIExploreSkillInteractComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(13);
		}

		// Token: 0x06024024 RID: 147492 RVA: 0x004F3B86 File Offset: 0x004F1D86
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06024025 RID: 147493 RVA: 0x004F3B91 File Offset: 0x004F1D91
		public static void AddExploreSkillUiResource(FlatBufferBuilder builder, StringOffset exploreSkillUiResourceOffset)
		{
			builder.AddOffset(1, exploreSkillUiResourceOffset.Value, 0);
		}

		// Token: 0x06024026 RID: 147494 RVA: 0x004F3BA1 File Offset: 0x004F1DA1
		public static void AddOptionType(FlatBufferBuilder builder, TExploreSkillInteractOption optionType)
		{
			builder.AddByte(2, (byte)optionType, 0);
		}

		// Token: 0x06024027 RID: 147495 RVA: 0x004F3BAC File Offset: 0x004F1DAC
		public static void AddOption(FlatBufferBuilder builder, int optionOffset)
		{
			builder.AddOffset(3, optionOffset, 0);
		}

		// Token: 0x06024028 RID: 147496 RVA: 0x004F3BB7 File Offset: 0x004F1DB7
		public static void AddPlayerStateRestritionId(FlatBufferBuilder builder, int playerStateRestritionId)
		{
			builder.AddInt(4, playerStateRestritionId, 0);
		}

		// Token: 0x06024029 RID: 147497 RVA: 0x004F3BC2 File Offset: 0x004F1DC2
		public static void AddMatchRoleOptionType(FlatBufferBuilder builder, VectorOffset matchRoleOptionTypeOffset)
		{
			builder.AddOffset(5, matchRoleOptionTypeOffset.Value, 0);
		}

		// Token: 0x0602402A RID: 147498 RVA: 0x004F3BD4 File Offset: 0x004F1DD4
		public static VectorOffset CreateMatchRoleOptionTypeVector(FlatBufferBuilder builder, TMatchRoleOption[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602402B RID: 147499 RVA: 0x004F3C0B File Offset: 0x004F1E0B
		public static VectorOffset CreateMatchRoleOptionTypeVectorBlock(FlatBufferBuilder builder, TMatchRoleOption[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TMatchRoleOption>(data);
			return builder.EndVector();
		}

		// Token: 0x0602402C RID: 147500 RVA: 0x004F3C25 File Offset: 0x004F1E25
		public static VectorOffset CreateMatchRoleOptionTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TMatchRoleOption> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TMatchRoleOption>(data);
			return builder.EndVector();
		}

		// Token: 0x0602402D RID: 147501 RVA: 0x004F3C43 File Offset: 0x004F1E43
		public static VectorOffset CreateMatchRoleOptionTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TMatchRoleOption>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602402E RID: 147502 RVA: 0x004F3C5C File Offset: 0x004F1E5C
		public static void StartMatchRoleOptionTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x0602402F RID: 147503 RVA: 0x004F3C67 File Offset: 0x004F1E67
		public static void AddMatchRoleOption(FlatBufferBuilder builder, VectorOffset matchRoleOptionOffset)
		{
			builder.AddOffset(6, matchRoleOptionOffset.Value, 0);
		}

		// Token: 0x06024030 RID: 147504 RVA: 0x004F3C78 File Offset: 0x004F1E78
		public static VectorOffset CreateMatchRoleOptionVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06024031 RID: 147505 RVA: 0x004F3CAF File Offset: 0x004F1EAF
		public static VectorOffset CreateMatchRoleOptionVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06024032 RID: 147506 RVA: 0x004F3CC9 File Offset: 0x004F1EC9
		public static VectorOffset CreateMatchRoleOptionVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06024033 RID: 147507 RVA: 0x004F3CE7 File Offset: 0x004F1EE7
		public static VectorOffset CreateMatchRoleOptionVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06024034 RID: 147508 RVA: 0x004F3D00 File Offset: 0x004F1F00
		public static void StartMatchRoleOptionVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06024035 RID: 147509 RVA: 0x004F3D0B File Offset: 0x004F1F0B
		public static void AddCondition(FlatBufferBuilder builder, Offset<IConditionGroup> conditionOffset)
		{
			builder.AddOffset(7, conditionOffset.Value, 0);
		}

		// Token: 0x06024036 RID: 147510 RVA: 0x004F3D1B File Offset: 0x004F1F1B
		public static void AddSearchTargetCfgType(FlatBufferBuilder builder, TExploreSkillSearchTargetCfg searchTargetCfgType)
		{
			builder.AddByte(8, (byte)searchTargetCfgType, 0);
		}

		// Token: 0x06024037 RID: 147511 RVA: 0x004F3D26 File Offset: 0x004F1F26
		public static void AddSearchTargetCfg(FlatBufferBuilder builder, int searchTargetCfgOffset)
		{
			builder.AddOffset(9, searchTargetCfgOffset, 0);
		}

		// Token: 0x06024038 RID: 147512 RVA: 0x004F3D32 File Offset: 0x004F1F32
		public static void AddIgnoresCollisionCfg(FlatBufferBuilder builder, Offset<IIgnoresCollisionCfg> ignoresCollisionCfgOffset)
		{
			builder.AddOffset(10, ignoresCollisionCfgOffset.Value, 0);
		}

		// Token: 0x06024039 RID: 147513 RVA: 0x004F3D43 File Offset: 0x004F1F43
		public static void AddSelfInteractBlockDetectionKeys(FlatBufferBuilder builder, VectorOffset selfInteractBlockDetectionKeysOffset)
		{
			builder.AddOffset(11, selfInteractBlockDetectionKeysOffset.Value, 0);
		}

		// Token: 0x0602403A RID: 147514 RVA: 0x004F3D54 File Offset: 0x004F1F54
		public static VectorOffset CreateSelfInteractBlockDetectionKeysVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602403B RID: 147515 RVA: 0x004F3D94 File Offset: 0x004F1F94
		public static VectorOffset CreateSelfInteractBlockDetectionKeysVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0602403C RID: 147516 RVA: 0x004F3DAE File Offset: 0x004F1FAE
		public static VectorOffset CreateSelfInteractBlockDetectionKeysVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0602403D RID: 147517 RVA: 0x004F3DCC File Offset: 0x004F1FCC
		public static VectorOffset CreateSelfInteractBlockDetectionKeysVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602403E RID: 147518 RVA: 0x004F3DE5 File Offset: 0x004F1FE5
		public static void StartSelfInteractBlockDetectionKeysVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602403F RID: 147519 RVA: 0x004F3DF0 File Offset: 0x004F1FF0
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(12, nullMask, 0);
		}

		// Token: 0x06024040 RID: 147520 RVA: 0x004F3DFC File Offset: 0x004F1FFC
		public static Offset<IExploreSkillInteractComponent> EndIExploreSkillInteractComponent(FlatBufferBuilder builder)
		{
			return new Offset<IExploreSkillInteractComponent>(builder.EndTable());
		}

		// Token: 0x06024041 RID: 147521 RVA: 0x004F3E0C File Offset: 0x004F200C
		public IExploreSkillInteractComponentT UnPack()
		{
			IExploreSkillInteractComponentT exploreSkillInteractComponentT = new IExploreSkillInteractComponentT();
			this.UnPackTo(exploreSkillInteractComponentT);
			return exploreSkillInteractComponentT;
		}

		// Token: 0x06024042 RID: 147522 RVA: 0x004F3E28 File Offset: 0x004F2028
		public void UnPackTo(IExploreSkillInteractComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.ExploreSkillUiResource = this.ExploreSkillUiResource;
			_o.Option = new TExploreSkillInteractOptionUnion();
			_o.Option.Type = this.OptionType;
			switch (this.OptionType)
			{
			case TExploreSkillInteractOption.IExploreSkillArrowInteractPoint:
				_o.Option.Value = ((this.Option<IExploreSkillArrowInteractPoint>() != null) ? this.Option<IExploreSkillArrowInteractPoint>().Value.UnPack() : null);
				break;
			case TExploreSkillInteractOption.IExploreSkillCustom:
				_o.Option.Value = ((this.Option<IExploreSkillCustom>() != null) ? this.Option<IExploreSkillCustom>().Value.UnPack() : null);
				break;
			case TExploreSkillInteractOption.IExploreSkillEavesdrop:
				_o.Option.Value = ((this.Option<IExploreSkillEavesdrop>() != null) ? this.Option<IExploreSkillEavesdrop>().Value.UnPack() : null);
				break;
			case TExploreSkillInteractOption.IExploreSkillGraffitiPuzzle:
				_o.Option.Value = ((this.Option<IExploreSkillGraffitiPuzzle>() != null) ? this.Option<IExploreSkillGraffitiPuzzle>().Value.UnPack() : null);
				break;
			case TExploreSkillInteractOption.IExploreSkillLonelyDollPollutant:
				_o.Option.Value = ((this.Option<IExploreSkillLonelyDollPollutant>() != null) ? this.Option<IExploreSkillLonelyDollPollutant>().Value.UnPack() : null);
				break;
			case TExploreSkillInteractOption.IExploreSkillMechascoutDrag:
				_o.Option.Value = ((this.Option<IExploreSkillMechascoutDrag>() != null) ? this.Option<IExploreSkillMechascoutDrag>().Value.UnPack() : null);
				break;
			case TExploreSkillInteractOption.IExploreSkillPullGiant:
				_o.Option.Value = ((this.Option<IExploreSkillPullGiant>() != null) ? this.Option<IExploreSkillPullGiant>().Value.UnPack() : null);
				break;
			case TExploreSkillInteractOption.IExploreSkillPullStatue:
				_o.Option.Value = ((this.Option<IExploreSkillPullStatue>() != null) ? this.Option<IExploreSkillPullStatue>().Value.UnPack() : null);
				break;
			case TExploreSkillInteractOption.IExploreSkillQuantumDiffusion:
				_o.Option.Value = ((this.Option<IExploreSkillQuantumDiffusion>() != null) ? this.Option<IExploreSkillQuantumDiffusion>().Value.UnPack() : null);
				break;
			case TExploreSkillInteractOption.IExploreSkillRagDollCrushingRock:
				_o.Option.Value = ((this.Option<IExploreSkillRagDollCrushingRock>() != null) ? this.Option<IExploreSkillRagDollCrushingRock>().Value.UnPack() : null);
				break;
			case TExploreSkillInteractOption.IExploreSkillRagDollDestroySolidRock:
				_o.Option.Value = ((this.Option<IExploreSkillRagDollDestroySolidRock>() != null) ? this.Option<IExploreSkillRagDollDestroySolidRock>().Value.UnPack() : null);
				break;
			case TExploreSkillInteractOption.IExploreSkillStatueInteractPoint:
				_o.Option.Value = ((this.Option<IExploreSkillStatueInteractPoint>() != null) ? this.Option<IExploreSkillStatueInteractPoint>().Value.UnPack() : null);
				break;
			case TExploreSkillInteractOption.IFollowShooterInteractPoint:
				_o.Option.Value = ((this.Option<IFollowShooterInteractPoint>() != null) ? this.Option<IFollowShooterInteractPoint>().Value.UnPack() : null);
				break;
			case TExploreSkillInteractOption.IFoxJumpInteractPoint:
				_o.Option.Value = ((this.Option<IFoxJumpInteractPoint>() != null) ? this.Option<IFoxJumpInteractPoint>().Value.UnPack() : null);
				break;
			case TExploreSkillInteractOption.IMonsterSummonInteractPoint:
				_o.Option.Value = ((this.Option<IMonsterSummonInteractPoint>() != null) ? this.Option<IMonsterSummonInteractPoint>().Value.UnPack() : null);
				break;
			}
			_o.PlayerStateRestritionId = this.PlayerStateRestritionId;
			_o.MatchRoleOption = new List<TMatchRoleOptionUnion>();
			for (int i = 0; i < this.MatchRoleOptionLength; i++)
			{
				TMatchRoleOptionUnion tmatchRoleOptionUnion = new TMatchRoleOptionUnion();
				tmatchRoleOptionUnion.Type = this.MatchRoleOptionType(i);
				switch (this.MatchRoleOptionType(i))
				{
				case TMatchRoleOption.IMatchAssistCharacterRole:
					tmatchRoleOptionUnion.Value = ((this.MatchRoleOption<IMatchAssistCharacterRole>(i) != null) ? this.MatchRoleOption<IMatchAssistCharacterRole>(i).Value.UnPack() : null);
					break;
				case TMatchRoleOption.IMatchPhantomRole:
					tmatchRoleOptionUnion.Value = ((this.MatchRoleOption<IMatchPhantomRole>(i) != null) ? this.MatchRoleOption<IMatchPhantomRole>(i).Value.UnPack() : null);
					break;
				case TMatchRoleOption.IMatchPlayerRole:
					tmatchRoleOptionUnion.Value = ((this.MatchRoleOption<IMatchPlayerRole>(i) != null) ? this.MatchRoleOption<IMatchPlayerRole>(i).Value.UnPack() : null);
					break;
				}
				_o.MatchRoleOption.Add(tmatchRoleOptionUnion);
			}
			_o.Condition = ((this.Condition != null) ? this.Condition.Value.UnPack() : null);
			_o.SearchTargetCfg = new TExploreSkillSearchTargetCfgUnion();
			_o.SearchTargetCfg.Type = this.SearchTargetCfgType;
			TExploreSkillSearchTargetCfg searchTargetCfgType = this.SearchTargetCfgType;
			if (searchTargetCfgType != TExploreSkillSearchTargetCfg.IAngleWeight)
			{
				if (searchTargetCfgType == TExploreSkillSearchTargetCfg.IEnterScreenWeight)
				{
					_o.SearchTargetCfg.Value = ((this.SearchTargetCfg<IEnterScreenWeight>() != null) ? this.SearchTargetCfg<IEnterScreenWeight>().Value.UnPack() : null);
				}
			}
			else
			{
				_o.SearchTargetCfg.Value = ((this.SearchTargetCfg<IAngleWeight>() != null) ? this.SearchTargetCfg<IAngleWeight>().Value.UnPack() : null);
			}
			_o.IgnoresCollisionCfg = ((this.IgnoresCollisionCfg != null) ? this.IgnoresCollisionCfg.Value.UnPack() : null);
			_o.SelfInteractBlockDetectionKeys = new List<string>();
			for (int j = 0; j < this.SelfInteractBlockDetectionKeysLength; j++)
			{
				_o.SelfInteractBlockDetectionKeys.Add(this.SelfInteractBlockDetectionKeys(j));
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06024043 RID: 147523 RVA: 0x004F4494 File Offset: 0x004F2694
		public static Offset<IExploreSkillInteractComponent> Pack(FlatBufferBuilder builder, IExploreSkillInteractComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IExploreSkillInteractComponent>);
			}
			StringOffset exploreSkillUiResourceOffset = (_o.ExploreSkillUiResource == null) ? default(StringOffset) : builder.CreateString(_o.ExploreSkillUiResource);
			TExploreSkillInteractOption option_type = (_o.Option == null) ? TExploreSkillInteractOption.NONE : _o.Option.Type;
			int optionOffset = (_o.Option == null) ? 0 : TExploreSkillInteractOptionUnion.Pack(builder, _o.Option);
			VectorOffset matchRoleOption_typeOffset = default(VectorOffset);
			if (_o.MatchRoleOption != null)
			{
				TMatchRoleOption[] array = new TMatchRoleOption[_o.MatchRoleOption.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = _o.MatchRoleOption[i].Type;
				}
				matchRoleOption_typeOffset = IExploreSkillInteractComponent.CreateMatchRoleOptionTypeVector(builder, array);
			}
			VectorOffset matchRoleOptionOffset = default(VectorOffset);
			if (_o.MatchRoleOption != null)
			{
				int[] array2 = new int[_o.MatchRoleOption.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = TMatchRoleOptionUnion.Pack(builder, _o.MatchRoleOption[j]);
				}
				matchRoleOptionOffset = IExploreSkillInteractComponent.CreateMatchRoleOptionVector(builder, array2);
			}
			Offset<IConditionGroup> conditionOffset = (_o.Condition == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.Condition);
			TExploreSkillSearchTargetCfg searchTargetCfg_type = (_o.SearchTargetCfg == null) ? TExploreSkillSearchTargetCfg.NONE : _o.SearchTargetCfg.Type;
			int searchTargetCfgOffset = (_o.SearchTargetCfg == null) ? 0 : TExploreSkillSearchTargetCfgUnion.Pack(builder, _o.SearchTargetCfg);
			Offset<IIgnoresCollisionCfg> ignoresCollisionCfgOffset = (_o.IgnoresCollisionCfg == null) ? default(Offset<IIgnoresCollisionCfg>) : IIgnoresCollisionCfg.Pack(builder, _o.IgnoresCollisionCfg);
			VectorOffset selfInteractBlockDetectionKeysOffset = default(VectorOffset);
			if (_o.SelfInteractBlockDetectionKeys != null)
			{
				StringOffset[] array3 = new StringOffset[_o.SelfInteractBlockDetectionKeys.Count];
				for (int k = 0; k < array3.Length; k++)
				{
					array3[k] = builder.CreateString(_o.SelfInteractBlockDetectionKeys[k]);
				}
				selfInteractBlockDetectionKeysOffset = IExploreSkillInteractComponent.CreateSelfInteractBlockDetectionKeysVector(builder, array3);
			}
			return IExploreSkillInteractComponent.CreateIExploreSkillInteractComponent(builder, _o.Disabled, exploreSkillUiResourceOffset, option_type, optionOffset, _o.PlayerStateRestritionId, matchRoleOption_typeOffset, matchRoleOptionOffset, conditionOffset, searchTargetCfg_type, searchTargetCfgOffset, ignoresCollisionCfgOffset, selfInteractBlockDetectionKeysOffset, _o.NullMask);
		}

		// Token: 0x0400EF00 RID: 61184
		private Table __p;
	}
}
