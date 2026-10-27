using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Aki.UniverseEditor.Interface.Fbs.Match;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020051E6 RID: 20966
	public struct IExploreSkillInteractComponent : IFlatbufferObject
	{
		// Token: 0x17009984 RID: 39300
		// (get) Token: 0x06022064 RID: 139364 RVA: 0x004B8A32 File Offset: 0x004B6C32
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06022065 RID: 139365 RVA: 0x004B8A3F File Offset: 0x004B6C3F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06022066 RID: 139366 RVA: 0x004B8A48 File Offset: 0x004B6C48
		public static IExploreSkillInteractComponent GetRootAsIExploreSkillInteractComponent(ByteBuffer _bb)
		{
			return IExploreSkillInteractComponent.GetRootAsIExploreSkillInteractComponent(_bb, default(IExploreSkillInteractComponent));
		}

		// Token: 0x06022067 RID: 139367 RVA: 0x004B8A64 File Offset: 0x004B6C64
		public static IExploreSkillInteractComponent GetRootAsIExploreSkillInteractComponent(ByteBuffer _bb, IExploreSkillInteractComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06022068 RID: 139368 RVA: 0x004B8A81 File Offset: 0x004B6C81
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06022069 RID: 139369 RVA: 0x004B8A90 File Offset: 0x004B6C90
		public IExploreSkillInteractComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009985 RID: 39301
		// (get) Token: 0x0602206A RID: 139370 RVA: 0x004B8AA0 File Offset: 0x004B6CA0
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17009986 RID: 39302
		// (get) Token: 0x0602206B RID: 139371 RVA: 0x004B8AE0 File Offset: 0x004B6CE0
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

		// Token: 0x0602206C RID: 139372 RVA: 0x004B8B17 File Offset: 0x004B6D17
		public Span<byte> GetExploreSkillUiResourceBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0602206D RID: 139373 RVA: 0x004B8B26 File Offset: 0x004B6D26
		public byte[] GetExploreSkillUiResourceArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x17009987 RID: 39303
		// (get) Token: 0x0602206E RID: 139374 RVA: 0x004B8B34 File Offset: 0x004B6D34
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

		// Token: 0x0602206F RID: 139375 RVA: 0x004B8B70 File Offset: 0x004B6D70
		public TTable? Option<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06022070 RID: 139376 RVA: 0x004B8BB8 File Offset: 0x004B6DB8
		public IExploreSkillArrowInteractPoint OptionAsIExploreSkillArrowInteractPoint()
		{
			return this.Option<IExploreSkillArrowInteractPoint>().Value;
		}

		// Token: 0x06022071 RID: 139377 RVA: 0x004B8BD4 File Offset: 0x004B6DD4
		public IExploreSkillCustom OptionAsIExploreSkillCustom()
		{
			return this.Option<IExploreSkillCustom>().Value;
		}

		// Token: 0x06022072 RID: 139378 RVA: 0x004B8BF0 File Offset: 0x004B6DF0
		public IExploreSkillEavesdrop OptionAsIExploreSkillEavesdrop()
		{
			return this.Option<IExploreSkillEavesdrop>().Value;
		}

		// Token: 0x06022073 RID: 139379 RVA: 0x004B8C0C File Offset: 0x004B6E0C
		public IExploreSkillLonelyDollPollutant OptionAsIExploreSkillLonelyDollPollutant()
		{
			return this.Option<IExploreSkillLonelyDollPollutant>().Value;
		}

		// Token: 0x06022074 RID: 139380 RVA: 0x004B8C28 File Offset: 0x004B6E28
		public IExploreSkillMechascoutDrag OptionAsIExploreSkillMechascoutDrag()
		{
			return this.Option<IExploreSkillMechascoutDrag>().Value;
		}

		// Token: 0x06022075 RID: 139381 RVA: 0x004B8C44 File Offset: 0x004B6E44
		public IExploreSkillPullGiant OptionAsIExploreSkillPullGiant()
		{
			return this.Option<IExploreSkillPullGiant>().Value;
		}

		// Token: 0x06022076 RID: 139382 RVA: 0x004B8C60 File Offset: 0x004B6E60
		public IExploreSkillPullStatue OptionAsIExploreSkillPullStatue()
		{
			return this.Option<IExploreSkillPullStatue>().Value;
		}

		// Token: 0x06022077 RID: 139383 RVA: 0x004B8C7C File Offset: 0x004B6E7C
		public IExploreSkillQuantumDiffusion OptionAsIExploreSkillQuantumDiffusion()
		{
			return this.Option<IExploreSkillQuantumDiffusion>().Value;
		}

		// Token: 0x06022078 RID: 139384 RVA: 0x004B8C98 File Offset: 0x004B6E98
		public IExploreSkillRagDollCrushingRock OptionAsIExploreSkillRagDollCrushingRock()
		{
			return this.Option<IExploreSkillRagDollCrushingRock>().Value;
		}

		// Token: 0x06022079 RID: 139385 RVA: 0x004B8CB4 File Offset: 0x004B6EB4
		public IExploreSkillRagDollDestroySolidRock OptionAsIExploreSkillRagDollDestroySolidRock()
		{
			return this.Option<IExploreSkillRagDollDestroySolidRock>().Value;
		}

		// Token: 0x0602207A RID: 139386 RVA: 0x004B8CD0 File Offset: 0x004B6ED0
		public IExploreSkillStatueInteractPoint OptionAsIExploreSkillStatueInteractPoint()
		{
			return this.Option<IExploreSkillStatueInteractPoint>().Value;
		}

		// Token: 0x0602207B RID: 139387 RVA: 0x004B8CEC File Offset: 0x004B6EEC
		public IFollowShooterInteractPoint OptionAsIFollowShooterInteractPoint()
		{
			return this.Option<IFollowShooterInteractPoint>().Value;
		}

		// Token: 0x0602207C RID: 139388 RVA: 0x004B8D08 File Offset: 0x004B6F08
		public IFoxJumpInteractPoint OptionAsIFoxJumpInteractPoint()
		{
			return this.Option<IFoxJumpInteractPoint>().Value;
		}

		// Token: 0x0602207D RID: 139389 RVA: 0x004B8D24 File Offset: 0x004B6F24
		public IMonsterSummonInteractPoint OptionAsIMonsterSummonInteractPoint()
		{
			return this.Option<IMonsterSummonInteractPoint>().Value;
		}

		// Token: 0x17009988 RID: 39304
		// (get) Token: 0x0602207E RID: 139390 RVA: 0x004B8D40 File Offset: 0x004B6F40
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

		// Token: 0x0602207F RID: 139391 RVA: 0x004B8D80 File Offset: 0x004B6F80
		public TMatchRoleOption MatchRoleOptionType(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return TMatchRoleOption.NONE;
			}
			return (TMatchRoleOption)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x17009989 RID: 39305
		// (get) Token: 0x06022080 RID: 139392 RVA: 0x004B8DC0 File Offset: 0x004B6FC0
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

		// Token: 0x06022081 RID: 139393 RVA: 0x004B8DEC File Offset: 0x004B6FEC
		public Span<TMatchRoleOption> GetMatchRoleOptionTypeBytes()
		{
			return this.__p.__vector_as_span<TMatchRoleOption>(14, 1);
		}

		// Token: 0x06022082 RID: 139394 RVA: 0x004B8DFC File Offset: 0x004B6FFC
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

		// Token: 0x06022083 RID: 139395 RVA: 0x004B8E68 File Offset: 0x004B7068
		public TTable? MatchRoleOption<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x1700998A RID: 39306
		// (get) Token: 0x06022084 RID: 139396 RVA: 0x004B8EB0 File Offset: 0x004B70B0
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

		// Token: 0x1700998B RID: 39307
		// (get) Token: 0x06022085 RID: 139397 RVA: 0x004B8EDC File Offset: 0x004B70DC
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

		// Token: 0x1700998C RID: 39308
		// (get) Token: 0x06022086 RID: 139398 RVA: 0x004B8F3C File Offset: 0x004B713C
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

		// Token: 0x06022087 RID: 139399 RVA: 0x004B8F7C File Offset: 0x004B717C
		public TTable? SearchTargetCfg<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06022088 RID: 139400 RVA: 0x004B8FC4 File Offset: 0x004B71C4
		public IAngleWeight SearchTargetCfgAsIAngleWeight()
		{
			return this.SearchTargetCfg<IAngleWeight>().Value;
		}

		// Token: 0x06022089 RID: 139401 RVA: 0x004B8FE0 File Offset: 0x004B71E0
		public IEnterScreenWeight SearchTargetCfgAsIEnterScreenWeight()
		{
			return this.SearchTargetCfg<IEnterScreenWeight>().Value;
		}

		// Token: 0x1700998D RID: 39309
		// (get) Token: 0x0602208A RID: 139402 RVA: 0x004B8FFC File Offset: 0x004B71FC
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

		// Token: 0x0602208B RID: 139403 RVA: 0x004B905C File Offset: 0x004B725C
		public string SelfInteractBlockDetectionKeys(int j)
		{
			int num = this.__p.__offset(26);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700998E RID: 39310
		// (get) Token: 0x0602208C RID: 139404 RVA: 0x004B9098 File Offset: 0x004B7298
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

		// Token: 0x1700998F RID: 39311
		// (get) Token: 0x0602208D RID: 139405 RVA: 0x004B90C4 File Offset: 0x004B72C4
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

		// Token: 0x0602208E RID: 139406 RVA: 0x004B9104 File Offset: 0x004B7304
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

		// Token: 0x0602208F RID: 139407 RVA: 0x004B9184 File Offset: 0x004B7384
		public static void StartIExploreSkillInteractComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(13);
		}

		// Token: 0x06022090 RID: 139408 RVA: 0x004B918E File Offset: 0x004B738E
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06022091 RID: 139409 RVA: 0x004B9199 File Offset: 0x004B7399
		public static void AddExploreSkillUiResource(FlatBufferBuilder builder, StringOffset exploreSkillUiResourceOffset)
		{
			builder.AddOffset(1, exploreSkillUiResourceOffset.Value, 0);
		}

		// Token: 0x06022092 RID: 139410 RVA: 0x004B91A9 File Offset: 0x004B73A9
		public static void AddOptionType(FlatBufferBuilder builder, TExploreSkillInteractOption optionType)
		{
			builder.AddByte(2, (byte)optionType, 0);
		}

		// Token: 0x06022093 RID: 139411 RVA: 0x004B91B4 File Offset: 0x004B73B4
		public static void AddOption(FlatBufferBuilder builder, int optionOffset)
		{
			builder.AddOffset(3, optionOffset, 0);
		}

		// Token: 0x06022094 RID: 139412 RVA: 0x004B91BF File Offset: 0x004B73BF
		public static void AddPlayerStateRestritionId(FlatBufferBuilder builder, int playerStateRestritionId)
		{
			builder.AddInt(4, playerStateRestritionId, 0);
		}

		// Token: 0x06022095 RID: 139413 RVA: 0x004B91CA File Offset: 0x004B73CA
		public static void AddMatchRoleOptionType(FlatBufferBuilder builder, VectorOffset matchRoleOptionTypeOffset)
		{
			builder.AddOffset(5, matchRoleOptionTypeOffset.Value, 0);
		}

		// Token: 0x06022096 RID: 139414 RVA: 0x004B91DC File Offset: 0x004B73DC
		public static VectorOffset CreateMatchRoleOptionTypeVector(FlatBufferBuilder builder, TMatchRoleOption[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06022097 RID: 139415 RVA: 0x004B9213 File Offset: 0x004B7413
		public static VectorOffset CreateMatchRoleOptionTypeVectorBlock(FlatBufferBuilder builder, TMatchRoleOption[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TMatchRoleOption>(data);
			return builder.EndVector();
		}

		// Token: 0x06022098 RID: 139416 RVA: 0x004B922D File Offset: 0x004B742D
		public static VectorOffset CreateMatchRoleOptionTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TMatchRoleOption> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TMatchRoleOption>(data);
			return builder.EndVector();
		}

		// Token: 0x06022099 RID: 139417 RVA: 0x004B924B File Offset: 0x004B744B
		public static VectorOffset CreateMatchRoleOptionTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TMatchRoleOption>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602209A RID: 139418 RVA: 0x004B9264 File Offset: 0x004B7464
		public static void StartMatchRoleOptionTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x0602209B RID: 139419 RVA: 0x004B926F File Offset: 0x004B746F
		public static void AddMatchRoleOption(FlatBufferBuilder builder, VectorOffset matchRoleOptionOffset)
		{
			builder.AddOffset(6, matchRoleOptionOffset.Value, 0);
		}

		// Token: 0x0602209C RID: 139420 RVA: 0x004B9280 File Offset: 0x004B7480
		public static VectorOffset CreateMatchRoleOptionVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602209D RID: 139421 RVA: 0x004B92B7 File Offset: 0x004B74B7
		public static VectorOffset CreateMatchRoleOptionVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602209E RID: 139422 RVA: 0x004B92D1 File Offset: 0x004B74D1
		public static VectorOffset CreateMatchRoleOptionVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602209F RID: 139423 RVA: 0x004B92EF File Offset: 0x004B74EF
		public static VectorOffset CreateMatchRoleOptionVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060220A0 RID: 139424 RVA: 0x004B9308 File Offset: 0x004B7508
		public static void StartMatchRoleOptionVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060220A1 RID: 139425 RVA: 0x004B9313 File Offset: 0x004B7513
		public static void AddCondition(FlatBufferBuilder builder, Offset<IConditionGroup> conditionOffset)
		{
			builder.AddOffset(7, conditionOffset.Value, 0);
		}

		// Token: 0x060220A2 RID: 139426 RVA: 0x004B9323 File Offset: 0x004B7523
		public static void AddSearchTargetCfgType(FlatBufferBuilder builder, TExploreSkillSearchTargetCfg searchTargetCfgType)
		{
			builder.AddByte(8, (byte)searchTargetCfgType, 0);
		}

		// Token: 0x060220A3 RID: 139427 RVA: 0x004B932E File Offset: 0x004B752E
		public static void AddSearchTargetCfg(FlatBufferBuilder builder, int searchTargetCfgOffset)
		{
			builder.AddOffset(9, searchTargetCfgOffset, 0);
		}

		// Token: 0x060220A4 RID: 139428 RVA: 0x004B933A File Offset: 0x004B753A
		public static void AddIgnoresCollisionCfg(FlatBufferBuilder builder, Offset<IIgnoresCollisionCfg> ignoresCollisionCfgOffset)
		{
			builder.AddOffset(10, ignoresCollisionCfgOffset.Value, 0);
		}

		// Token: 0x060220A5 RID: 139429 RVA: 0x004B934B File Offset: 0x004B754B
		public static void AddSelfInteractBlockDetectionKeys(FlatBufferBuilder builder, VectorOffset selfInteractBlockDetectionKeysOffset)
		{
			builder.AddOffset(11, selfInteractBlockDetectionKeysOffset.Value, 0);
		}

		// Token: 0x060220A6 RID: 139430 RVA: 0x004B935C File Offset: 0x004B755C
		public static VectorOffset CreateSelfInteractBlockDetectionKeysVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060220A7 RID: 139431 RVA: 0x004B939C File Offset: 0x004B759C
		public static VectorOffset CreateSelfInteractBlockDetectionKeysVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x060220A8 RID: 139432 RVA: 0x004B93B6 File Offset: 0x004B75B6
		public static VectorOffset CreateSelfInteractBlockDetectionKeysVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x060220A9 RID: 139433 RVA: 0x004B93D4 File Offset: 0x004B75D4
		public static VectorOffset CreateSelfInteractBlockDetectionKeysVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060220AA RID: 139434 RVA: 0x004B93ED File Offset: 0x004B75ED
		public static void StartSelfInteractBlockDetectionKeysVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060220AB RID: 139435 RVA: 0x004B93F8 File Offset: 0x004B75F8
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(12, nullMask, 0);
		}

		// Token: 0x060220AC RID: 139436 RVA: 0x004B9404 File Offset: 0x004B7604
		public static Offset<IExploreSkillInteractComponent> EndIExploreSkillInteractComponent(FlatBufferBuilder builder)
		{
			return new Offset<IExploreSkillInteractComponent>(builder.EndTable());
		}

		// Token: 0x060220AD RID: 139437 RVA: 0x004B9414 File Offset: 0x004B7614
		public IExploreSkillInteractComponentT UnPack()
		{
			IExploreSkillInteractComponentT exploreSkillInteractComponentT = new IExploreSkillInteractComponentT();
			this.UnPackTo(exploreSkillInteractComponentT);
			return exploreSkillInteractComponentT;
		}

		// Token: 0x060220AE RID: 139438 RVA: 0x004B9430 File Offset: 0x004B7630
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
				TMatchRoleOption tmatchRoleOption = this.MatchRoleOptionType(i);
				if (tmatchRoleOption != TMatchRoleOption.IMatchPhantomRole)
				{
					if (tmatchRoleOption == TMatchRoleOption.IMatchPlayerRole)
					{
						tmatchRoleOptionUnion.Value = ((this.MatchRoleOption<IMatchPlayerRole>(i) != null) ? this.MatchRoleOption<IMatchPlayerRole>(i).Value.UnPack() : null);
					}
				}
				else
				{
					tmatchRoleOptionUnion.Value = ((this.MatchRoleOption<IMatchPhantomRole>(i) != null) ? this.MatchRoleOption<IMatchPhantomRole>(i).Value.UnPack() : null);
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

		// Token: 0x060220AF RID: 139439 RVA: 0x004B9A14 File Offset: 0x004B7C14
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

		// Token: 0x0400E2FB RID: 58107
		private Table __p;
	}
}
