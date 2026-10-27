using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003FD7 RID: 16343
	public struct IQuestFailedCondition : IFlatbufferObject
	{
		// Token: 0x1700728A RID: 29322
		// (get) Token: 0x060177D9 RID: 96217 RVA: 0x00363256 File Offset: 0x00361456
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060177DA RID: 96218 RVA: 0x00363263 File Offset: 0x00361463
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060177DB RID: 96219 RVA: 0x0036326C File Offset: 0x0036146C
		public static IQuestFailedCondition GetRootAsIQuestFailedCondition(ByteBuffer _bb)
		{
			return IQuestFailedCondition.GetRootAsIQuestFailedCondition(_bb, default(IQuestFailedCondition));
		}

		// Token: 0x060177DC RID: 96220 RVA: 0x00363288 File Offset: 0x00361488
		public static IQuestFailedCondition GetRootAsIQuestFailedCondition(ByteBuffer _bb, IQuestFailedCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060177DD RID: 96221 RVA: 0x003632A5 File Offset: 0x003614A5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060177DE RID: 96222 RVA: 0x003632B4 File Offset: 0x003614B4
		public IQuestFailedCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700728B RID: 29323
		// (get) Token: 0x060177DF RID: 96223 RVA: 0x003632C4 File Offset: 0x003614C4
		public ITimerConfig? Timer
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new ITimerConfig?(default(ITimerConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700728C RID: 29324
		// (get) Token: 0x060177E0 RID: 96224 RVA: 0x00363324 File Offset: 0x00361524
		public ITimeRange? TimeRange
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new ITimeRange?(default(ITimeRange).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700728D RID: 29325
		// (get) Token: 0x060177E1 RID: 96225 RVA: 0x00363384 File Offset: 0x00361584
		public bool CanGiveUp
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700728E RID: 29326
		// (get) Token: 0x060177E2 RID: 96226 RVA: 0x003633C4 File Offset: 0x003615C4
		public string TidGiveUpText
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

		// Token: 0x060177E3 RID: 96227 RVA: 0x003633FC File Offset: 0x003615FC
		public Span<byte> GetTidGiveUpTextBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x060177E4 RID: 96228 RVA: 0x0036340C File Offset: 0x0036160C
		public byte[] GetTidGiveUpTextArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x1700728F RID: 29327
		// (get) Token: 0x060177E5 RID: 96229 RVA: 0x0036341C File Offset: 0x0036161C
		public bool IsTransferFailure
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17007290 RID: 29328
		// (get) Token: 0x060177E6 RID: 96230 RVA: 0x0036345C File Offset: 0x0036165C
		public bool IsTeamDeathFailure
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17007291 RID: 29329
		// (get) Token: 0x060177E7 RID: 96231 RVA: 0x0036349C File Offset: 0x0036169C
		public bool IsNonAiTeamDeathFailure
		{
			get
			{
				int num = this.__p.__offset(16);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17007292 RID: 29330
		// (get) Token: 0x060177E8 RID: 96232 RVA: 0x003634DC File Offset: 0x003616DC
		public bool IsLeaveDungeonFailure
		{
			get
			{
				int num = this.__p.__offset(18);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x060177E9 RID: 96233 RVA: 0x0036351C File Offset: 0x0036171C
		public int CheckDungeonFailure(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17007293 RID: 29331
		// (get) Token: 0x060177EA RID: 96234 RVA: 0x0036355C File Offset: 0x0036175C
		public int CheckDungeonFailureLength
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

		// Token: 0x060177EB RID: 96235 RVA: 0x00363588 File Offset: 0x00361788
		public Span<int> GetCheckDungeonFailureBytes()
		{
			return this.__p.__vector_as_span<int>(20, 4);
		}

		// Token: 0x060177EC RID: 96236 RVA: 0x00363598 File Offset: 0x00361798
		public int[] GetCheckDungeonFailureArray()
		{
			return this.__p.__vector_as_array<int>(20);
		}

		// Token: 0x17007294 RID: 29332
		// (get) Token: 0x060177ED RID: 96237 RVA: 0x003635A8 File Offset: 0x003617A8
		public IRangeLimitingCondition? RangeLimiting
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return null;
				}
				return new IRangeLimitingCondition?(default(IRangeLimitingCondition).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17007295 RID: 29333
		// (get) Token: 0x060177EE RID: 96238 RVA: 0x00363608 File Offset: 0x00361808
		public IEntityDistanceLimitingCondition? EntityDistanceLimiting
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return null;
				}
				return new IEntityDistanceLimitingCondition?(default(IEntityDistanceLimitingCondition).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17007296 RID: 29334
		// (get) Token: 0x060177EF RID: 96239 RVA: 0x00363668 File Offset: 0x00361868
		public IQuestFailedConditionEntityAlert? EntityAlert
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return null;
				}
				return new IQuestFailedConditionEntityAlert?(default(IQuestFailedConditionEntityAlert).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17007297 RID: 29335
		// (get) Token: 0x060177F0 RID: 96240 RVA: 0x003636C8 File Offset: 0x003618C8
		public IQuestFailedConditionEntityDeath? EntityDeathCondition
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return null;
				}
				return new IQuestFailedConditionEntityDeath?(default(IQuestFailedConditionEntityDeath).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17007298 RID: 29336
		// (get) Token: 0x060177F1 RID: 96241 RVA: 0x00363728 File Offset: 0x00361928
		public IQuestFailedConditionEntityState? EntityStateCondition
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return null;
				}
				return new IQuestFailedConditionEntityState?(default(IQuestFailedConditionEntityState).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17007299 RID: 29337
		// (get) Token: 0x060177F2 RID: 96242 RVA: 0x00363788 File Offset: 0x00361988
		public ISneakPlayCondition? SneakPlayCondition
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return null;
				}
				return new ISneakPlayCondition?(default(ISneakPlayCondition).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700729A RID: 29338
		// (get) Token: 0x060177F3 RID: 96243 RVA: 0x003637E8 File Offset: 0x003619E8
		public IQuestFailedConditionPlayerMotionState? PlayerMotionStateCondition
		{
			get
			{
				int num = this.__p.__offset(34);
				if (num == 0)
				{
					return null;
				}
				return new IQuestFailedConditionPlayerMotionState?(default(IQuestFailedConditionPlayerMotionState).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700729B RID: 29339
		// (get) Token: 0x060177F4 RID: 96244 RVA: 0x00363848 File Offset: 0x00361A48
		public IQuestFailedConditionPlayerMovementMode? PlayerMovementModeCondition
		{
			get
			{
				int num = this.__p.__offset(36);
				if (num == 0)
				{
					return null;
				}
				return new IQuestFailedConditionPlayerMovementMode?(default(IQuestFailedConditionPlayerMovementMode).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700729C RID: 29340
		// (get) Token: 0x060177F5 RID: 96245 RVA: 0x003638A8 File Offset: 0x00361AA8
		public ICheckDataLayer? CheckDataLayer
		{
			get
			{
				int num = this.__p.__offset(38);
				if (num == 0)
				{
					return null;
				}
				return new ICheckDataLayer?(default(ICheckDataLayer).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700729D RID: 29341
		// (get) Token: 0x060177F6 RID: 96246 RVA: 0x00363908 File Offset: 0x00361B08
		public IFailedTeleport? FailedTeleport
		{
			get
			{
				int num = this.__p.__offset(40);
				if (num == 0)
				{
					return null;
				}
				return new IFailedTeleport?(default(IFailedTeleport).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700729E RID: 29342
		// (get) Token: 0x060177F7 RID: 96247 RVA: 0x00363968 File Offset: 0x00361B68
		public IAddTimeConfig? AddTimeConfig
		{
			get
			{
				int num = this.__p.__offset(42);
				if (num == 0)
				{
					return null;
				}
				return new IAddTimeConfig?(default(IAddTimeConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700729F RID: 29343
		// (get) Token: 0x060177F8 RID: 96248 RVA: 0x003639C8 File Offset: 0x00361BC8
		public ICompareVarConditionInQuestFailed? CompareVar
		{
			get
			{
				int num = this.__p.__offset(44);
				if (num == 0)
				{
					return null;
				}
				return new ICompareVarConditionInQuestFailed?(default(ICompareVarConditionInQuestFailed).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x170072A0 RID: 29344
		// (get) Token: 0x060177F9 RID: 96249 RVA: 0x00363A28 File Offset: 0x00361C28
		public IRecallFishingBoat? RecallVehicle
		{
			get
			{
				int num = this.__p.__offset(46);
				if (num == 0)
				{
					return null;
				}
				return new IRecallFishingBoat?(default(IRecallFishingBoat).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x170072A1 RID: 29345
		// (get) Token: 0x060177FA RID: 96250 RVA: 0x00363A88 File Offset: 0x00361C88
		public bool SwitchGameDifficulty
		{
			get
			{
				int num = this.__p.__offset(48);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170072A2 RID: 29346
		// (get) Token: 0x060177FB RID: 96251 RVA: 0x00363AC8 File Offset: 0x00361CC8
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(50);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060177FC RID: 96252 RVA: 0x00363B08 File Offset: 0x00361D08
		public static Offset<IQuestFailedCondition> CreateIQuestFailedCondition(FlatBufferBuilder builder, Offset<ITimerConfig> TimerOffset = default(Offset<ITimerConfig>), Offset<ITimeRange> TimeRangeOffset = default(Offset<ITimeRange>), bool CanGiveUp = false, StringOffset TidGiveUpTextOffset = default(StringOffset), bool IsTransferFailure = false, bool IsTeamDeathFailure = false, bool IsNonAiTeamDeathFailure = false, bool IsLeaveDungeonFailure = false, VectorOffset CheckDungeonFailureOffset = default(VectorOffset), Offset<IRangeLimitingCondition> RangeLimitingOffset = default(Offset<IRangeLimitingCondition>), Offset<IEntityDistanceLimitingCondition> EntityDistanceLimitingOffset = default(Offset<IEntityDistanceLimitingCondition>), Offset<IQuestFailedConditionEntityAlert> EntityAlertOffset = default(Offset<IQuestFailedConditionEntityAlert>), Offset<IQuestFailedConditionEntityDeath> EntityDeathConditionOffset = default(Offset<IQuestFailedConditionEntityDeath>), Offset<IQuestFailedConditionEntityState> EntityStateConditionOffset = default(Offset<IQuestFailedConditionEntityState>), Offset<ISneakPlayCondition> SneakPlayConditionOffset = default(Offset<ISneakPlayCondition>), Offset<IQuestFailedConditionPlayerMotionState> PlayerMotionStateConditionOffset = default(Offset<IQuestFailedConditionPlayerMotionState>), Offset<IQuestFailedConditionPlayerMovementMode> PlayerMovementModeConditionOffset = default(Offset<IQuestFailedConditionPlayerMovementMode>), Offset<ICheckDataLayer> CheckDataLayerOffset = default(Offset<ICheckDataLayer>), Offset<IFailedTeleport> FailedTeleportOffset = default(Offset<IFailedTeleport>), Offset<IAddTimeConfig> AddTimeConfigOffset = default(Offset<IAddTimeConfig>), Offset<ICompareVarConditionInQuestFailed> CompareVarOffset = default(Offset<ICompareVarConditionInQuestFailed>), Offset<IRecallFishingBoat> RecallVehicleOffset = default(Offset<IRecallFishingBoat>), bool SwitchGameDifficulty = false, byte NullMask = 0)
		{
			builder.StartTable(24);
			IQuestFailedCondition.AddRecallVehicle(builder, RecallVehicleOffset);
			IQuestFailedCondition.AddCompareVar(builder, CompareVarOffset);
			IQuestFailedCondition.AddAddTimeConfig(builder, AddTimeConfigOffset);
			IQuestFailedCondition.AddFailedTeleport(builder, FailedTeleportOffset);
			IQuestFailedCondition.AddCheckDataLayer(builder, CheckDataLayerOffset);
			IQuestFailedCondition.AddPlayerMovementModeCondition(builder, PlayerMovementModeConditionOffset);
			IQuestFailedCondition.AddPlayerMotionStateCondition(builder, PlayerMotionStateConditionOffset);
			IQuestFailedCondition.AddSneakPlayCondition(builder, SneakPlayConditionOffset);
			IQuestFailedCondition.AddEntityStateCondition(builder, EntityStateConditionOffset);
			IQuestFailedCondition.AddEntityDeathCondition(builder, EntityDeathConditionOffset);
			IQuestFailedCondition.AddEntityAlert(builder, EntityAlertOffset);
			IQuestFailedCondition.AddEntityDistanceLimiting(builder, EntityDistanceLimitingOffset);
			IQuestFailedCondition.AddRangeLimiting(builder, RangeLimitingOffset);
			IQuestFailedCondition.AddCheckDungeonFailure(builder, CheckDungeonFailureOffset);
			IQuestFailedCondition.AddTidGiveUpText(builder, TidGiveUpTextOffset);
			IQuestFailedCondition.AddTimeRange(builder, TimeRangeOffset);
			IQuestFailedCondition.AddTimer(builder, TimerOffset);
			IQuestFailedCondition.AddNullMask(builder, NullMask);
			IQuestFailedCondition.AddSwitchGameDifficulty(builder, SwitchGameDifficulty);
			IQuestFailedCondition.AddIsLeaveDungeonFailure(builder, IsLeaveDungeonFailure);
			IQuestFailedCondition.AddIsNonAiTeamDeathFailure(builder, IsNonAiTeamDeathFailure);
			IQuestFailedCondition.AddIsTeamDeathFailure(builder, IsTeamDeathFailure);
			IQuestFailedCondition.AddIsTransferFailure(builder, IsTransferFailure);
			IQuestFailedCondition.AddCanGiveUp(builder, CanGiveUp);
			return IQuestFailedCondition.EndIQuestFailedCondition(builder);
		}

		// Token: 0x060177FD RID: 96253 RVA: 0x00363BE0 File Offset: 0x00361DE0
		public static void StartIQuestFailedCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(24);
		}

		// Token: 0x060177FE RID: 96254 RVA: 0x00363BEA File Offset: 0x00361DEA
		public static void AddTimer(FlatBufferBuilder builder, Offset<ITimerConfig> timerOffset)
		{
			builder.AddOffset(0, timerOffset.Value, 0);
		}

		// Token: 0x060177FF RID: 96255 RVA: 0x00363BFA File Offset: 0x00361DFA
		public static void AddTimeRange(FlatBufferBuilder builder, Offset<ITimeRange> timeRangeOffset)
		{
			builder.AddOffset(1, timeRangeOffset.Value, 0);
		}

		// Token: 0x06017800 RID: 96256 RVA: 0x00363C0A File Offset: 0x00361E0A
		public static void AddCanGiveUp(FlatBufferBuilder builder, bool canGiveUp)
		{
			builder.AddBool(2, canGiveUp, false);
		}

		// Token: 0x06017801 RID: 96257 RVA: 0x00363C15 File Offset: 0x00361E15
		public static void AddTidGiveUpText(FlatBufferBuilder builder, StringOffset tidGiveUpTextOffset)
		{
			builder.AddOffset(3, tidGiveUpTextOffset.Value, 0);
		}

		// Token: 0x06017802 RID: 96258 RVA: 0x00363C25 File Offset: 0x00361E25
		public static void AddIsTransferFailure(FlatBufferBuilder builder, bool isTransferFailure)
		{
			builder.AddBool(4, isTransferFailure, false);
		}

		// Token: 0x06017803 RID: 96259 RVA: 0x00363C30 File Offset: 0x00361E30
		public static void AddIsTeamDeathFailure(FlatBufferBuilder builder, bool isTeamDeathFailure)
		{
			builder.AddBool(5, isTeamDeathFailure, false);
		}

		// Token: 0x06017804 RID: 96260 RVA: 0x00363C3B File Offset: 0x00361E3B
		public static void AddIsNonAiTeamDeathFailure(FlatBufferBuilder builder, bool isNonAiTeamDeathFailure)
		{
			builder.AddBool(6, isNonAiTeamDeathFailure, false);
		}

		// Token: 0x06017805 RID: 96261 RVA: 0x00363C46 File Offset: 0x00361E46
		public static void AddIsLeaveDungeonFailure(FlatBufferBuilder builder, bool isLeaveDungeonFailure)
		{
			builder.AddBool(7, isLeaveDungeonFailure, false);
		}

		// Token: 0x06017806 RID: 96262 RVA: 0x00363C51 File Offset: 0x00361E51
		public static void AddCheckDungeonFailure(FlatBufferBuilder builder, VectorOffset checkDungeonFailureOffset)
		{
			builder.AddOffset(8, checkDungeonFailureOffset.Value, 0);
		}

		// Token: 0x06017807 RID: 96263 RVA: 0x00363C64 File Offset: 0x00361E64
		public static VectorOffset CreateCheckDungeonFailureVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06017808 RID: 96264 RVA: 0x00363C9B File Offset: 0x00361E9B
		public static VectorOffset CreateCheckDungeonFailureVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06017809 RID: 96265 RVA: 0x00363CB5 File Offset: 0x00361EB5
		public static VectorOffset CreateCheckDungeonFailureVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601780A RID: 96266 RVA: 0x00363CD3 File Offset: 0x00361ED3
		public static VectorOffset CreateCheckDungeonFailureVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601780B RID: 96267 RVA: 0x00363CEC File Offset: 0x00361EEC
		public static void StartCheckDungeonFailureVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601780C RID: 96268 RVA: 0x00363CF7 File Offset: 0x00361EF7
		public static void AddRangeLimiting(FlatBufferBuilder builder, Offset<IRangeLimitingCondition> rangeLimitingOffset)
		{
			builder.AddOffset(9, rangeLimitingOffset.Value, 0);
		}

		// Token: 0x0601780D RID: 96269 RVA: 0x00363D08 File Offset: 0x00361F08
		public static void AddEntityDistanceLimiting(FlatBufferBuilder builder, Offset<IEntityDistanceLimitingCondition> entityDistanceLimitingOffset)
		{
			builder.AddOffset(10, entityDistanceLimitingOffset.Value, 0);
		}

		// Token: 0x0601780E RID: 96270 RVA: 0x00363D19 File Offset: 0x00361F19
		public static void AddEntityAlert(FlatBufferBuilder builder, Offset<IQuestFailedConditionEntityAlert> entityAlertOffset)
		{
			builder.AddOffset(11, entityAlertOffset.Value, 0);
		}

		// Token: 0x0601780F RID: 96271 RVA: 0x00363D2A File Offset: 0x00361F2A
		public static void AddEntityDeathCondition(FlatBufferBuilder builder, Offset<IQuestFailedConditionEntityDeath> entityDeathConditionOffset)
		{
			builder.AddOffset(12, entityDeathConditionOffset.Value, 0);
		}

		// Token: 0x06017810 RID: 96272 RVA: 0x00363D3B File Offset: 0x00361F3B
		public static void AddEntityStateCondition(FlatBufferBuilder builder, Offset<IQuestFailedConditionEntityState> entityStateConditionOffset)
		{
			builder.AddOffset(13, entityStateConditionOffset.Value, 0);
		}

		// Token: 0x06017811 RID: 96273 RVA: 0x00363D4C File Offset: 0x00361F4C
		public static void AddSneakPlayCondition(FlatBufferBuilder builder, Offset<ISneakPlayCondition> sneakPlayConditionOffset)
		{
			builder.AddOffset(14, sneakPlayConditionOffset.Value, 0);
		}

		// Token: 0x06017812 RID: 96274 RVA: 0x00363D5D File Offset: 0x00361F5D
		public static void AddPlayerMotionStateCondition(FlatBufferBuilder builder, Offset<IQuestFailedConditionPlayerMotionState> playerMotionStateConditionOffset)
		{
			builder.AddOffset(15, playerMotionStateConditionOffset.Value, 0);
		}

		// Token: 0x06017813 RID: 96275 RVA: 0x00363D6E File Offset: 0x00361F6E
		public static void AddPlayerMovementModeCondition(FlatBufferBuilder builder, Offset<IQuestFailedConditionPlayerMovementMode> playerMovementModeConditionOffset)
		{
			builder.AddOffset(16, playerMovementModeConditionOffset.Value, 0);
		}

		// Token: 0x06017814 RID: 96276 RVA: 0x00363D7F File Offset: 0x00361F7F
		public static void AddCheckDataLayer(FlatBufferBuilder builder, Offset<ICheckDataLayer> checkDataLayerOffset)
		{
			builder.AddOffset(17, checkDataLayerOffset.Value, 0);
		}

		// Token: 0x06017815 RID: 96277 RVA: 0x00363D90 File Offset: 0x00361F90
		public static void AddFailedTeleport(FlatBufferBuilder builder, Offset<IFailedTeleport> failedTeleportOffset)
		{
			builder.AddOffset(18, failedTeleportOffset.Value, 0);
		}

		// Token: 0x06017816 RID: 96278 RVA: 0x00363DA1 File Offset: 0x00361FA1
		public static void AddAddTimeConfig(FlatBufferBuilder builder, Offset<IAddTimeConfig> addTimeConfigOffset)
		{
			builder.AddOffset(19, addTimeConfigOffset.Value, 0);
		}

		// Token: 0x06017817 RID: 96279 RVA: 0x00363DB2 File Offset: 0x00361FB2
		public static void AddCompareVar(FlatBufferBuilder builder, Offset<ICompareVarConditionInQuestFailed> compareVarOffset)
		{
			builder.AddOffset(20, compareVarOffset.Value, 0);
		}

		// Token: 0x06017818 RID: 96280 RVA: 0x00363DC3 File Offset: 0x00361FC3
		public static void AddRecallVehicle(FlatBufferBuilder builder, Offset<IRecallFishingBoat> recallVehicleOffset)
		{
			builder.AddOffset(21, recallVehicleOffset.Value, 0);
		}

		// Token: 0x06017819 RID: 96281 RVA: 0x00363DD4 File Offset: 0x00361FD4
		public static void AddSwitchGameDifficulty(FlatBufferBuilder builder, bool switchGameDifficulty)
		{
			builder.AddBool(22, switchGameDifficulty, false);
		}

		// Token: 0x0601781A RID: 96282 RVA: 0x00363DE0 File Offset: 0x00361FE0
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(23, nullMask, 0);
		}

		// Token: 0x0601781B RID: 96283 RVA: 0x00363DEC File Offset: 0x00361FEC
		public static Offset<IQuestFailedCondition> EndIQuestFailedCondition(FlatBufferBuilder builder)
		{
			return new Offset<IQuestFailedCondition>(builder.EndTable());
		}

		// Token: 0x0601781C RID: 96284 RVA: 0x00363DFC File Offset: 0x00361FFC
		public IQuestFailedConditionT UnPack()
		{
			IQuestFailedConditionT questFailedConditionT = new IQuestFailedConditionT();
			this.UnPackTo(questFailedConditionT);
			return questFailedConditionT;
		}

		// Token: 0x0601781D RID: 96285 RVA: 0x00363E18 File Offset: 0x00362018
		public void UnPackTo(IQuestFailedConditionT _o)
		{
			_o.Timer = ((this.Timer != null) ? this.Timer.Value.UnPack() : null);
			_o.TimeRange = ((this.TimeRange != null) ? this.TimeRange.Value.UnPack() : null);
			_o.CanGiveUp = this.CanGiveUp;
			_o.TidGiveUpText = this.TidGiveUpText;
			_o.IsTransferFailure = this.IsTransferFailure;
			_o.IsTeamDeathFailure = this.IsTeamDeathFailure;
			_o.IsNonAiTeamDeathFailure = this.IsNonAiTeamDeathFailure;
			_o.IsLeaveDungeonFailure = this.IsLeaveDungeonFailure;
			_o.CheckDungeonFailure = new List<int>();
			for (int i = 0; i < this.CheckDungeonFailureLength; i++)
			{
				_o.CheckDungeonFailure.Add(this.CheckDungeonFailure(i));
			}
			_o.RangeLimiting = ((this.RangeLimiting != null) ? this.RangeLimiting.Value.UnPack() : null);
			_o.EntityDistanceLimiting = ((this.EntityDistanceLimiting != null) ? this.EntityDistanceLimiting.Value.UnPack() : null);
			_o.EntityAlert = ((this.EntityAlert != null) ? this.EntityAlert.Value.UnPack() : null);
			_o.EntityDeathCondition = ((this.EntityDeathCondition != null) ? this.EntityDeathCondition.Value.UnPack() : null);
			_o.EntityStateCondition = ((this.EntityStateCondition != null) ? this.EntityStateCondition.Value.UnPack() : null);
			_o.SneakPlayCondition = ((this.SneakPlayCondition != null) ? this.SneakPlayCondition.Value.UnPack() : null);
			_o.PlayerMotionStateCondition = ((this.PlayerMotionStateCondition != null) ? this.PlayerMotionStateCondition.Value.UnPack() : null);
			_o.PlayerMovementModeCondition = ((this.PlayerMovementModeCondition != null) ? this.PlayerMovementModeCondition.Value.UnPack() : null);
			_o.CheckDataLayer = ((this.CheckDataLayer != null) ? this.CheckDataLayer.Value.UnPack() : null);
			_o.FailedTeleport = ((this.FailedTeleport != null) ? this.FailedTeleport.Value.UnPack() : null);
			_o.AddTimeConfig = ((this.AddTimeConfig != null) ? this.AddTimeConfig.Value.UnPack() : null);
			_o.CompareVar = ((this.CompareVar != null) ? this.CompareVar.Value.UnPack() : null);
			_o.RecallVehicle = ((this.RecallVehicle != null) ? this.RecallVehicle.Value.UnPack() : null);
			_o.SwitchGameDifficulty = this.SwitchGameDifficulty;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601781E RID: 96286 RVA: 0x003641A0 File Offset: 0x003623A0
		public static Offset<IQuestFailedCondition> Pack(FlatBufferBuilder builder, IQuestFailedConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IQuestFailedCondition>);
			}
			Offset<ITimerConfig> timerOffset = (_o.Timer == null) ? default(Offset<ITimerConfig>) : ITimerConfig.Pack(builder, _o.Timer);
			Offset<ITimeRange> timeRangeOffset = (_o.TimeRange == null) ? default(Offset<ITimeRange>) : ITimeRange.Pack(builder, _o.TimeRange);
			StringOffset tidGiveUpTextOffset = (_o.TidGiveUpText == null) ? default(StringOffset) : builder.CreateString(_o.TidGiveUpText);
			VectorOffset checkDungeonFailureOffset = default(VectorOffset);
			if (_o.CheckDungeonFailure != null)
			{
				int[] data = _o.CheckDungeonFailure.ToArray();
				checkDungeonFailureOffset = IQuestFailedCondition.CreateCheckDungeonFailureVector(builder, data);
			}
			Offset<IRangeLimitingCondition> rangeLimitingOffset = (_o.RangeLimiting == null) ? default(Offset<IRangeLimitingCondition>) : IRangeLimitingCondition.Pack(builder, _o.RangeLimiting);
			Offset<IEntityDistanceLimitingCondition> entityDistanceLimitingOffset = (_o.EntityDistanceLimiting == null) ? default(Offset<IEntityDistanceLimitingCondition>) : IEntityDistanceLimitingCondition.Pack(builder, _o.EntityDistanceLimiting);
			Offset<IQuestFailedConditionEntityAlert> entityAlertOffset = (_o.EntityAlert == null) ? default(Offset<IQuestFailedConditionEntityAlert>) : IQuestFailedConditionEntityAlert.Pack(builder, _o.EntityAlert);
			Offset<IQuestFailedConditionEntityDeath> entityDeathConditionOffset = (_o.EntityDeathCondition == null) ? default(Offset<IQuestFailedConditionEntityDeath>) : IQuestFailedConditionEntityDeath.Pack(builder, _o.EntityDeathCondition);
			Offset<IQuestFailedConditionEntityState> entityStateConditionOffset = (_o.EntityStateCondition == null) ? default(Offset<IQuestFailedConditionEntityState>) : IQuestFailedConditionEntityState.Pack(builder, _o.EntityStateCondition);
			Offset<ISneakPlayCondition> sneakPlayConditionOffset = (_o.SneakPlayCondition == null) ? default(Offset<ISneakPlayCondition>) : ISneakPlayCondition.Pack(builder, _o.SneakPlayCondition);
			Offset<IQuestFailedConditionPlayerMotionState> playerMotionStateConditionOffset = (_o.PlayerMotionStateCondition == null) ? default(Offset<IQuestFailedConditionPlayerMotionState>) : IQuestFailedConditionPlayerMotionState.Pack(builder, _o.PlayerMotionStateCondition);
			Offset<IQuestFailedConditionPlayerMovementMode> playerMovementModeConditionOffset = (_o.PlayerMovementModeCondition == null) ? default(Offset<IQuestFailedConditionPlayerMovementMode>) : IQuestFailedConditionPlayerMovementMode.Pack(builder, _o.PlayerMovementModeCondition);
			Offset<ICheckDataLayer> checkDataLayerOffset = (_o.CheckDataLayer == null) ? default(Offset<ICheckDataLayer>) : ICheckDataLayer.Pack(builder, _o.CheckDataLayer);
			Offset<IFailedTeleport> failedTeleportOffset = (_o.FailedTeleport == null) ? default(Offset<IFailedTeleport>) : IFailedTeleport.Pack(builder, _o.FailedTeleport);
			Offset<IAddTimeConfig> addTimeConfigOffset = (_o.AddTimeConfig == null) ? default(Offset<IAddTimeConfig>) : IAddTimeConfig.Pack(builder, _o.AddTimeConfig);
			Offset<ICompareVarConditionInQuestFailed> compareVarOffset = (_o.CompareVar == null) ? default(Offset<ICompareVarConditionInQuestFailed>) : ICompareVarConditionInQuestFailed.Pack(builder, _o.CompareVar);
			Offset<IRecallFishingBoat> recallVehicleOffset = (_o.RecallVehicle == null) ? default(Offset<IRecallFishingBoat>) : IRecallFishingBoat.Pack(builder, _o.RecallVehicle);
			return IQuestFailedCondition.CreateIQuestFailedCondition(builder, timerOffset, timeRangeOffset, _o.CanGiveUp, tidGiveUpTextOffset, _o.IsTransferFailure, _o.IsTeamDeathFailure, _o.IsNonAiTeamDeathFailure, _o.IsLeaveDungeonFailure, checkDungeonFailureOffset, rangeLimitingOffset, entityDistanceLimitingOffset, entityAlertOffset, entityDeathConditionOffset, entityStateConditionOffset, sneakPlayConditionOffset, playerMotionStateConditionOffset, playerMovementModeConditionOffset, checkDataLayerOffset, failedTeleportOffset, addTimeConfigOffset, compareVarOffset, recallVehicleOffset, _o.SwitchGameDifficulty, _o.NullMask);
		}

		// Token: 0x0400BAC3 RID: 47811
		private Table __p;
	}
}
