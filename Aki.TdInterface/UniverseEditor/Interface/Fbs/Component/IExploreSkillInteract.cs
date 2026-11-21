using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Aki.UniverseEditor.Interface.Fbs.Match;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200574B RID: 22347
	public struct IExploreSkillInteract : IFlatbufferObject
	{
		// Token: 0x1700A16C RID: 41324
		// (get) Token: 0x06023F98 RID: 147352 RVA: 0x004F1FBE File Offset: 0x004F01BE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06023F99 RID: 147353 RVA: 0x004F1FCB File Offset: 0x004F01CB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06023F9A RID: 147354 RVA: 0x004F1FD4 File Offset: 0x004F01D4
		public static IExploreSkillInteract GetRootAsIExploreSkillInteract(ByteBuffer _bb)
		{
			return IExploreSkillInteract.GetRootAsIExploreSkillInteract(_bb, default(IExploreSkillInteract));
		}

		// Token: 0x06023F9B RID: 147355 RVA: 0x004F1FF0 File Offset: 0x004F01F0
		public static IExploreSkillInteract GetRootAsIExploreSkillInteract(ByteBuffer _bb, IExploreSkillInteract obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06023F9C RID: 147356 RVA: 0x004F200D File Offset: 0x004F020D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06023F9D RID: 147357 RVA: 0x004F201C File Offset: 0x004F021C
		public IExploreSkillInteract __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A16D RID: 41325
		// (get) Token: 0x06023F9E RID: 147358 RVA: 0x004F202C File Offset: 0x004F022C
		public string ExploreSkillUiResource
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06023F9F RID: 147359 RVA: 0x004F2063 File Offset: 0x004F0263
		public Span<byte> GetExploreSkillUiResourceBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06023FA0 RID: 147360 RVA: 0x004F2072 File Offset: 0x004F0272
		public byte[] GetExploreSkillUiResourceArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700A16E RID: 41326
		// (get) Token: 0x06023FA1 RID: 147361 RVA: 0x004F2080 File Offset: 0x004F0280
		public TExploreSkillInteractOption OptionType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return TExploreSkillInteractOption.NONE;
				}
				return (TExploreSkillInteractOption)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06023FA2 RID: 147362 RVA: 0x004F20BC File Offset: 0x004F02BC
		public TTable? Option<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06023FA3 RID: 147363 RVA: 0x004F2100 File Offset: 0x004F0300
		public IExploreSkillArrowInteractPoint OptionAsIExploreSkillArrowInteractPoint()
		{
			return this.Option<IExploreSkillArrowInteractPoint>().Value;
		}

		// Token: 0x06023FA4 RID: 147364 RVA: 0x004F211C File Offset: 0x004F031C
		public IExploreSkillCustom OptionAsIExploreSkillCustom()
		{
			return this.Option<IExploreSkillCustom>().Value;
		}

		// Token: 0x06023FA5 RID: 147365 RVA: 0x004F2138 File Offset: 0x004F0338
		public IExploreSkillEavesdrop OptionAsIExploreSkillEavesdrop()
		{
			return this.Option<IExploreSkillEavesdrop>().Value;
		}

		// Token: 0x06023FA6 RID: 147366 RVA: 0x004F2154 File Offset: 0x004F0354
		public IExploreSkillGraffitiPuzzle OptionAsIExploreSkillGraffitiPuzzle()
		{
			return this.Option<IExploreSkillGraffitiPuzzle>().Value;
		}

		// Token: 0x06023FA7 RID: 147367 RVA: 0x004F2170 File Offset: 0x004F0370
		public IExploreSkillLonelyDollPollutant OptionAsIExploreSkillLonelyDollPollutant()
		{
			return this.Option<IExploreSkillLonelyDollPollutant>().Value;
		}

		// Token: 0x06023FA8 RID: 147368 RVA: 0x004F218C File Offset: 0x004F038C
		public IExploreSkillMechascoutDrag OptionAsIExploreSkillMechascoutDrag()
		{
			return this.Option<IExploreSkillMechascoutDrag>().Value;
		}

		// Token: 0x06023FA9 RID: 147369 RVA: 0x004F21A8 File Offset: 0x004F03A8
		public IExploreSkillPullGiant OptionAsIExploreSkillPullGiant()
		{
			return this.Option<IExploreSkillPullGiant>().Value;
		}

		// Token: 0x06023FAA RID: 147370 RVA: 0x004F21C4 File Offset: 0x004F03C4
		public IExploreSkillPullStatue OptionAsIExploreSkillPullStatue()
		{
			return this.Option<IExploreSkillPullStatue>().Value;
		}

		// Token: 0x06023FAB RID: 147371 RVA: 0x004F21E0 File Offset: 0x004F03E0
		public IExploreSkillQuantumDiffusion OptionAsIExploreSkillQuantumDiffusion()
		{
			return this.Option<IExploreSkillQuantumDiffusion>().Value;
		}

		// Token: 0x06023FAC RID: 147372 RVA: 0x004F21FC File Offset: 0x004F03FC
		public IExploreSkillRagDollCrushingRock OptionAsIExploreSkillRagDollCrushingRock()
		{
			return this.Option<IExploreSkillRagDollCrushingRock>().Value;
		}

		// Token: 0x06023FAD RID: 147373 RVA: 0x004F2218 File Offset: 0x004F0418
		public IExploreSkillRagDollDestroySolidRock OptionAsIExploreSkillRagDollDestroySolidRock()
		{
			return this.Option<IExploreSkillRagDollDestroySolidRock>().Value;
		}

		// Token: 0x06023FAE RID: 147374 RVA: 0x004F2234 File Offset: 0x004F0434
		public IExploreSkillStatueInteractPoint OptionAsIExploreSkillStatueInteractPoint()
		{
			return this.Option<IExploreSkillStatueInteractPoint>().Value;
		}

		// Token: 0x06023FAF RID: 147375 RVA: 0x004F2250 File Offset: 0x004F0450
		public IFollowShooterInteractPoint OptionAsIFollowShooterInteractPoint()
		{
			return this.Option<IFollowShooterInteractPoint>().Value;
		}

		// Token: 0x06023FB0 RID: 147376 RVA: 0x004F226C File Offset: 0x004F046C
		public IFoxJumpInteractPoint OptionAsIFoxJumpInteractPoint()
		{
			return this.Option<IFoxJumpInteractPoint>().Value;
		}

		// Token: 0x06023FB1 RID: 147377 RVA: 0x004F2288 File Offset: 0x004F0488
		public IMonsterSummonInteractPoint OptionAsIMonsterSummonInteractPoint()
		{
			return this.Option<IMonsterSummonInteractPoint>().Value;
		}

		// Token: 0x1700A16F RID: 41327
		// (get) Token: 0x06023FB2 RID: 147378 RVA: 0x004F22A4 File Offset: 0x004F04A4
		public int PlayerStateRestritionId
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

		// Token: 0x06023FB3 RID: 147379 RVA: 0x004F22E4 File Offset: 0x004F04E4
		public TMatchRoleOption MatchRoleOptionType(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return TMatchRoleOption.NONE;
			}
			return (TMatchRoleOption)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x1700A170 RID: 41328
		// (get) Token: 0x06023FB4 RID: 147380 RVA: 0x004F2324 File Offset: 0x004F0524
		public int MatchRoleOptionTypeLength
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

		// Token: 0x06023FB5 RID: 147381 RVA: 0x004F2350 File Offset: 0x004F0550
		public Span<TMatchRoleOption> GetMatchRoleOptionTypeBytes()
		{
			return this.__p.__vector_as_span<TMatchRoleOption>(12, 1);
		}

		// Token: 0x06023FB6 RID: 147382 RVA: 0x004F2360 File Offset: 0x004F0560
		public TMatchRoleOption[] GetMatchRoleOptionTypeArray()
		{
			int num = this.__p.__offset(12);
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

		// Token: 0x06023FB7 RID: 147383 RVA: 0x004F23CC File Offset: 0x004F05CC
		public TTable? MatchRoleOption<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x1700A171 RID: 41329
		// (get) Token: 0x06023FB8 RID: 147384 RVA: 0x004F2414 File Offset: 0x004F0614
		public int MatchRoleOptionLength
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

		// Token: 0x1700A172 RID: 41330
		// (get) Token: 0x06023FB9 RID: 147385 RVA: 0x004F2440 File Offset: 0x004F0640
		public IConditionGroup? Condition
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return new IConditionGroup?(default(IConditionGroup).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700A173 RID: 41331
		// (get) Token: 0x06023FBA RID: 147386 RVA: 0x004F24A0 File Offset: 0x004F06A0
		public TExploreSkillSearchTargetCfg SearchTargetCfgType
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return TExploreSkillSearchTargetCfg.NONE;
				}
				return (TExploreSkillSearchTargetCfg)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06023FBB RID: 147387 RVA: 0x004F24E0 File Offset: 0x004F06E0
		public TTable? SearchTargetCfg<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06023FBC RID: 147388 RVA: 0x004F2528 File Offset: 0x004F0728
		public IAngleWeight SearchTargetCfgAsIAngleWeight()
		{
			return this.SearchTargetCfg<IAngleWeight>().Value;
		}

		// Token: 0x06023FBD RID: 147389 RVA: 0x004F2544 File Offset: 0x004F0744
		public IEnterScreenWeight SearchTargetCfgAsIEnterScreenWeight()
		{
			return this.SearchTargetCfg<IEnterScreenWeight>().Value;
		}

		// Token: 0x1700A174 RID: 41332
		// (get) Token: 0x06023FBE RID: 147390 RVA: 0x004F2560 File Offset: 0x004F0760
		public IIgnoresCollisionCfg? IgnoresCollisionCfg
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return null;
				}
				return new IIgnoresCollisionCfg?(default(IIgnoresCollisionCfg).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06023FBF RID: 147391 RVA: 0x004F25C0 File Offset: 0x004F07C0
		public string SelfInteractBlockDetectionKeys(int j)
		{
			int num = this.__p.__offset(24);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700A175 RID: 41333
		// (get) Token: 0x06023FC0 RID: 147392 RVA: 0x004F25FC File Offset: 0x004F07FC
		public int SelfInteractBlockDetectionKeysLength
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

		// Token: 0x1700A176 RID: 41334
		// (get) Token: 0x06023FC1 RID: 147393 RVA: 0x004F2628 File Offset: 0x004F0828
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06023FC2 RID: 147394 RVA: 0x004F2668 File Offset: 0x004F0868
		public static Offset<IExploreSkillInteract> CreateIExploreSkillInteract(FlatBufferBuilder builder, StringOffset ExploreSkillUiResourceOffset = default(StringOffset), TExploreSkillInteractOption Option_type = TExploreSkillInteractOption.NONE, int OptionOffset = 0, int PlayerStateRestritionId = 0, VectorOffset MatchRoleOption_typeOffset = default(VectorOffset), VectorOffset MatchRoleOptionOffset = default(VectorOffset), Offset<IConditionGroup> ConditionOffset = default(Offset<IConditionGroup>), TExploreSkillSearchTargetCfg SearchTargetCfg_type = TExploreSkillSearchTargetCfg.NONE, int SearchTargetCfgOffset = 0, Offset<IIgnoresCollisionCfg> IgnoresCollisionCfgOffset = default(Offset<IIgnoresCollisionCfg>), VectorOffset SelfInteractBlockDetectionKeysOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(12);
			IExploreSkillInteract.AddSelfInteractBlockDetectionKeys(builder, SelfInteractBlockDetectionKeysOffset);
			IExploreSkillInteract.AddIgnoresCollisionCfg(builder, IgnoresCollisionCfgOffset);
			IExploreSkillInteract.AddSearchTargetCfg(builder, SearchTargetCfgOffset);
			IExploreSkillInteract.AddCondition(builder, ConditionOffset);
			IExploreSkillInteract.AddMatchRoleOption(builder, MatchRoleOptionOffset);
			IExploreSkillInteract.AddMatchRoleOptionType(builder, MatchRoleOption_typeOffset);
			IExploreSkillInteract.AddPlayerStateRestritionId(builder, PlayerStateRestritionId);
			IExploreSkillInteract.AddOption(builder, OptionOffset);
			IExploreSkillInteract.AddExploreSkillUiResource(builder, ExploreSkillUiResourceOffset);
			IExploreSkillInteract.AddNullMask(builder, NullMask);
			IExploreSkillInteract.AddSearchTargetCfgType(builder, SearchTargetCfg_type);
			IExploreSkillInteract.AddOptionType(builder, Option_type);
			return IExploreSkillInteract.EndIExploreSkillInteract(builder);
		}

		// Token: 0x06023FC3 RID: 147395 RVA: 0x004F26E0 File Offset: 0x004F08E0
		public static void StartIExploreSkillInteract(FlatBufferBuilder builder)
		{
			builder.StartTable(12);
		}

		// Token: 0x06023FC4 RID: 147396 RVA: 0x004F26EA File Offset: 0x004F08EA
		public static void AddExploreSkillUiResource(FlatBufferBuilder builder, StringOffset exploreSkillUiResourceOffset)
		{
			builder.AddOffset(0, exploreSkillUiResourceOffset.Value, 0);
		}

		// Token: 0x06023FC5 RID: 147397 RVA: 0x004F26FA File Offset: 0x004F08FA
		public static void AddOptionType(FlatBufferBuilder builder, TExploreSkillInteractOption optionType)
		{
			builder.AddByte(1, (byte)optionType, 0);
		}

		// Token: 0x06023FC6 RID: 147398 RVA: 0x004F2705 File Offset: 0x004F0905
		public static void AddOption(FlatBufferBuilder builder, int optionOffset)
		{
			builder.AddOffset(2, optionOffset, 0);
		}

		// Token: 0x06023FC7 RID: 147399 RVA: 0x004F2710 File Offset: 0x004F0910
		public static void AddPlayerStateRestritionId(FlatBufferBuilder builder, int playerStateRestritionId)
		{
			builder.AddInt(3, playerStateRestritionId, 0);
		}

		// Token: 0x06023FC8 RID: 147400 RVA: 0x004F271B File Offset: 0x004F091B
		public static void AddMatchRoleOptionType(FlatBufferBuilder builder, VectorOffset matchRoleOptionTypeOffset)
		{
			builder.AddOffset(4, matchRoleOptionTypeOffset.Value, 0);
		}

		// Token: 0x06023FC9 RID: 147401 RVA: 0x004F272C File Offset: 0x004F092C
		public static VectorOffset CreateMatchRoleOptionTypeVector(FlatBufferBuilder builder, TMatchRoleOption[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06023FCA RID: 147402 RVA: 0x004F2763 File Offset: 0x004F0963
		public static VectorOffset CreateMatchRoleOptionTypeVectorBlock(FlatBufferBuilder builder, TMatchRoleOption[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TMatchRoleOption>(data);
			return builder.EndVector();
		}

		// Token: 0x06023FCB RID: 147403 RVA: 0x004F277D File Offset: 0x004F097D
		public static VectorOffset CreateMatchRoleOptionTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TMatchRoleOption> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TMatchRoleOption>(data);
			return builder.EndVector();
		}

		// Token: 0x06023FCC RID: 147404 RVA: 0x004F279B File Offset: 0x004F099B
		public static VectorOffset CreateMatchRoleOptionTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TMatchRoleOption>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06023FCD RID: 147405 RVA: 0x004F27B4 File Offset: 0x004F09B4
		public static void StartMatchRoleOptionTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x06023FCE RID: 147406 RVA: 0x004F27BF File Offset: 0x004F09BF
		public static void AddMatchRoleOption(FlatBufferBuilder builder, VectorOffset matchRoleOptionOffset)
		{
			builder.AddOffset(5, matchRoleOptionOffset.Value, 0);
		}

		// Token: 0x06023FCF RID: 147407 RVA: 0x004F27D0 File Offset: 0x004F09D0
		public static VectorOffset CreateMatchRoleOptionVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06023FD0 RID: 147408 RVA: 0x004F2807 File Offset: 0x004F0A07
		public static VectorOffset CreateMatchRoleOptionVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06023FD1 RID: 147409 RVA: 0x004F2821 File Offset: 0x004F0A21
		public static VectorOffset CreateMatchRoleOptionVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06023FD2 RID: 147410 RVA: 0x004F283F File Offset: 0x004F0A3F
		public static VectorOffset CreateMatchRoleOptionVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06023FD3 RID: 147411 RVA: 0x004F2858 File Offset: 0x004F0A58
		public static void StartMatchRoleOptionVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06023FD4 RID: 147412 RVA: 0x004F2863 File Offset: 0x004F0A63
		public static void AddCondition(FlatBufferBuilder builder, Offset<IConditionGroup> conditionOffset)
		{
			builder.AddOffset(6, conditionOffset.Value, 0);
		}

		// Token: 0x06023FD5 RID: 147413 RVA: 0x004F2873 File Offset: 0x004F0A73
		public static void AddSearchTargetCfgType(FlatBufferBuilder builder, TExploreSkillSearchTargetCfg searchTargetCfgType)
		{
			builder.AddByte(7, (byte)searchTargetCfgType, 0);
		}

		// Token: 0x06023FD6 RID: 147414 RVA: 0x004F287E File Offset: 0x004F0A7E
		public static void AddSearchTargetCfg(FlatBufferBuilder builder, int searchTargetCfgOffset)
		{
			builder.AddOffset(8, searchTargetCfgOffset, 0);
		}

		// Token: 0x06023FD7 RID: 147415 RVA: 0x004F2889 File Offset: 0x004F0A89
		public static void AddIgnoresCollisionCfg(FlatBufferBuilder builder, Offset<IIgnoresCollisionCfg> ignoresCollisionCfgOffset)
		{
			builder.AddOffset(9, ignoresCollisionCfgOffset.Value, 0);
		}

		// Token: 0x06023FD8 RID: 147416 RVA: 0x004F289A File Offset: 0x004F0A9A
		public static void AddSelfInteractBlockDetectionKeys(FlatBufferBuilder builder, VectorOffset selfInteractBlockDetectionKeysOffset)
		{
			builder.AddOffset(10, selfInteractBlockDetectionKeysOffset.Value, 0);
		}

		// Token: 0x06023FD9 RID: 147417 RVA: 0x004F28AC File Offset: 0x004F0AAC
		public static VectorOffset CreateSelfInteractBlockDetectionKeysVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06023FDA RID: 147418 RVA: 0x004F28EC File Offset: 0x004F0AEC
		public static VectorOffset CreateSelfInteractBlockDetectionKeysVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x06023FDB RID: 147419 RVA: 0x004F2906 File Offset: 0x004F0B06
		public static VectorOffset CreateSelfInteractBlockDetectionKeysVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x06023FDC RID: 147420 RVA: 0x004F2924 File Offset: 0x004F0B24
		public static VectorOffset CreateSelfInteractBlockDetectionKeysVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06023FDD RID: 147421 RVA: 0x004F293D File Offset: 0x004F0B3D
		public static void StartSelfInteractBlockDetectionKeysVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06023FDE RID: 147422 RVA: 0x004F2948 File Offset: 0x004F0B48
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(11, nullMask, 0);
		}

		// Token: 0x06023FDF RID: 147423 RVA: 0x004F2954 File Offset: 0x004F0B54
		public static Offset<IExploreSkillInteract> EndIExploreSkillInteract(FlatBufferBuilder builder)
		{
			return new Offset<IExploreSkillInteract>(builder.EndTable());
		}

		// Token: 0x06023FE0 RID: 147424 RVA: 0x004F2964 File Offset: 0x004F0B64
		public IExploreSkillInteractT UnPack()
		{
			IExploreSkillInteractT exploreSkillInteractT = new IExploreSkillInteractT();
			this.UnPackTo(exploreSkillInteractT);
			return exploreSkillInteractT;
		}

		// Token: 0x06023FE1 RID: 147425 RVA: 0x004F2980 File Offset: 0x004F0B80
		public void UnPackTo(IExploreSkillInteractT _o)
		{
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

		// Token: 0x06023FE2 RID: 147426 RVA: 0x004F2FE0 File Offset: 0x004F11E0
		public static Offset<IExploreSkillInteract> Pack(FlatBufferBuilder builder, IExploreSkillInteractT _o)
		{
			if (_o == null)
			{
				return default(Offset<IExploreSkillInteract>);
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
				matchRoleOption_typeOffset = IExploreSkillInteract.CreateMatchRoleOptionTypeVector(builder, array);
			}
			VectorOffset matchRoleOptionOffset = default(VectorOffset);
			if (_o.MatchRoleOption != null)
			{
				int[] array2 = new int[_o.MatchRoleOption.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = TMatchRoleOptionUnion.Pack(builder, _o.MatchRoleOption[j]);
				}
				matchRoleOptionOffset = IExploreSkillInteract.CreateMatchRoleOptionVector(builder, array2);
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
				selfInteractBlockDetectionKeysOffset = IExploreSkillInteract.CreateSelfInteractBlockDetectionKeysVector(builder, array3);
			}
			return IExploreSkillInteract.CreateIExploreSkillInteract(builder, exploreSkillUiResourceOffset, option_type, optionOffset, _o.PlayerStateRestritionId, matchRoleOption_typeOffset, matchRoleOptionOffset, conditionOffset, searchTargetCfg_type, searchTargetCfgOffset, ignoresCollisionCfgOffset, selfInteractBlockDetectionKeysOffset, _o.NullMask);
		}

		// Token: 0x0400EEF6 RID: 61174
		private Table __p;
	}
}
