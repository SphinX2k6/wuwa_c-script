using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004418 RID: 17432
	public struct IQuestFailedCondition : IFlatbufferObject
	{
		// Token: 0x1700788A RID: 30858
		// (get) Token: 0x06018E6C RID: 101996 RVA: 0x0038CF7E File Offset: 0x0038B17E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06018E6D RID: 101997 RVA: 0x0038CF8B File Offset: 0x0038B18B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06018E6E RID: 101998 RVA: 0x0038CF94 File Offset: 0x0038B194
		public static IQuestFailedCondition GetRootAsIQuestFailedCondition(ByteBuffer _bb)
		{
			return IQuestFailedCondition.GetRootAsIQuestFailedCondition(_bb, default(IQuestFailedCondition));
		}

		// Token: 0x06018E6F RID: 101999 RVA: 0x0038CFB0 File Offset: 0x0038B1B0
		public static IQuestFailedCondition GetRootAsIQuestFailedCondition(ByteBuffer _bb, IQuestFailedCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06018E70 RID: 102000 RVA: 0x0038CFCD File Offset: 0x0038B1CD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06018E71 RID: 102001 RVA: 0x0038CFDC File Offset: 0x0038B1DC
		public IQuestFailedCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700788B RID: 30859
		// (get) Token: 0x06018E72 RID: 102002 RVA: 0x0038CFEC File Offset: 0x0038B1EC
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

		// Token: 0x1700788C RID: 30860
		// (get) Token: 0x06018E73 RID: 102003 RVA: 0x0038D04C File Offset: 0x0038B24C
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

		// Token: 0x1700788D RID: 30861
		// (get) Token: 0x06018E74 RID: 102004 RVA: 0x0038D0AC File Offset: 0x0038B2AC
		public bool CanGiveUp
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700788E RID: 30862
		// (get) Token: 0x06018E75 RID: 102005 RVA: 0x0038D0EC File Offset: 0x0038B2EC
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

		// Token: 0x06018E76 RID: 102006 RVA: 0x0038D124 File Offset: 0x0038B324
		public Span<byte> GetTidGiveUpTextBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06018E77 RID: 102007 RVA: 0x0038D134 File Offset: 0x0038B334
		public byte[] GetTidGiveUpTextArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x1700788F RID: 30863
		// (get) Token: 0x06018E78 RID: 102008 RVA: 0x0038D144 File Offset: 0x0038B344
		public string TidGiveUpConfirmText
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06018E79 RID: 102009 RVA: 0x0038D17C File Offset: 0x0038B37C
		public Span<byte> GetTidGiveUpConfirmTextBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06018E7A RID: 102010 RVA: 0x0038D18C File Offset: 0x0038B38C
		public byte[] GetTidGiveUpConfirmTextArray()
		{
			return this.__p.__vector_as_array<byte>(12);
		}

		// Token: 0x17007890 RID: 30864
		// (get) Token: 0x06018E7B RID: 102011 RVA: 0x0038D19C File Offset: 0x0038B39C
		public bool IsTransferFailure
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17007891 RID: 30865
		// (get) Token: 0x06018E7C RID: 102012 RVA: 0x0038D1DC File Offset: 0x0038B3DC
		public bool IsTeamDeathFailure
		{
			get
			{
				int num = this.__p.__offset(16);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17007892 RID: 30866
		// (get) Token: 0x06018E7D RID: 102013 RVA: 0x0038D21C File Offset: 0x0038B41C
		public bool IsNonAiTeamDeathFailure
		{
			get
			{
				int num = this.__p.__offset(18);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17007893 RID: 30867
		// (get) Token: 0x06018E7E RID: 102014 RVA: 0x0038D25C File Offset: 0x0038B45C
		public bool IsLeaveDungeonFailure
		{
			get
			{
				int num = this.__p.__offset(20);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06018E7F RID: 102015 RVA: 0x0038D29C File Offset: 0x0038B49C
		public int CheckDungeonFailure(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17007894 RID: 30868
		// (get) Token: 0x06018E80 RID: 102016 RVA: 0x0038D2DC File Offset: 0x0038B4DC
		public int CheckDungeonFailureLength
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

		// Token: 0x06018E81 RID: 102017 RVA: 0x0038D308 File Offset: 0x0038B508
		public Span<int> GetCheckDungeonFailureBytes()
		{
			return this.__p.__vector_as_span<int>(22, 4);
		}

		// Token: 0x06018E82 RID: 102018 RVA: 0x0038D318 File Offset: 0x0038B518
		public int[] GetCheckDungeonFailureArray()
		{
			return this.__p.__vector_as_array<int>(22);
		}

		// Token: 0x17007895 RID: 30869
		// (get) Token: 0x06018E83 RID: 102019 RVA: 0x0038D328 File Offset: 0x0038B528
		public IRangeLimitingCondition? RangeLimiting
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return null;
				}
				return new IRangeLimitingCondition?(default(IRangeLimitingCondition).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17007896 RID: 30870
		// (get) Token: 0x06018E84 RID: 102020 RVA: 0x0038D388 File Offset: 0x0038B588
		public IEntityDistanceLimitingCondition? EntityDistanceLimiting
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return null;
				}
				return new IEntityDistanceLimitingCondition?(default(IEntityDistanceLimitingCondition).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17007897 RID: 30871
		// (get) Token: 0x06018E85 RID: 102021 RVA: 0x0038D3E8 File Offset: 0x0038B5E8
		public IQuestFailedConditionEntityAlert? EntityAlert
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return null;
				}
				return new IQuestFailedConditionEntityAlert?(default(IQuestFailedConditionEntityAlert).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17007898 RID: 30872
		// (get) Token: 0x06018E86 RID: 102022 RVA: 0x0038D448 File Offset: 0x0038B648
		public IQuestFailedConditionEntityDeath? EntityDeathCondition
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return null;
				}
				return new IQuestFailedConditionEntityDeath?(default(IQuestFailedConditionEntityDeath).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17007899 RID: 30873
		// (get) Token: 0x06018E87 RID: 102023 RVA: 0x0038D4A8 File Offset: 0x0038B6A8
		public IQuestFailedConditionEntityState? EntityStateCondition
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return null;
				}
				return new IQuestFailedConditionEntityState?(default(IQuestFailedConditionEntityState).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700789A RID: 30874
		// (get) Token: 0x06018E88 RID: 102024 RVA: 0x0038D508 File Offset: 0x0038B708
		public ISneakPlayCondition? SneakPlayCondition
		{
			get
			{
				int num = this.__p.__offset(34);
				if (num == 0)
				{
					return null;
				}
				return new ISneakPlayCondition?(default(ISneakPlayCondition).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700789B RID: 30875
		// (get) Token: 0x06018E89 RID: 102025 RVA: 0x0038D568 File Offset: 0x0038B768
		public IQuestFailedConditionPlayerMotionState? PlayerMotionStateCondition
		{
			get
			{
				int num = this.__p.__offset(36);
				if (num == 0)
				{
					return null;
				}
				return new IQuestFailedConditionPlayerMotionState?(default(IQuestFailedConditionPlayerMotionState).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700789C RID: 30876
		// (get) Token: 0x06018E8A RID: 102026 RVA: 0x0038D5C8 File Offset: 0x0038B7C8
		public IQuestFailedConditionPlayerMovementMode? PlayerMovementModeCondition
		{
			get
			{
				int num = this.__p.__offset(38);
				if (num == 0)
				{
					return null;
				}
				return new IQuestFailedConditionPlayerMovementMode?(default(IQuestFailedConditionPlayerMovementMode).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700789D RID: 30877
		// (get) Token: 0x06018E8B RID: 102027 RVA: 0x0038D628 File Offset: 0x0038B828
		public ICheckDataLayer? CheckDataLayer
		{
			get
			{
				int num = this.__p.__offset(40);
				if (num == 0)
				{
					return null;
				}
				return new ICheckDataLayer?(default(ICheckDataLayer).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700789E RID: 30878
		// (get) Token: 0x06018E8C RID: 102028 RVA: 0x0038D688 File Offset: 0x0038B888
		public IFailedTeleport? FailedTeleport
		{
			get
			{
				int num = this.__p.__offset(42);
				if (num == 0)
				{
					return null;
				}
				return new IFailedTeleport?(default(IFailedTeleport).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700789F RID: 30879
		// (get) Token: 0x06018E8D RID: 102029 RVA: 0x0038D6E8 File Offset: 0x0038B8E8
		public IAddTimeConfig? AddTimeConfig
		{
			get
			{
				int num = this.__p.__offset(44);
				if (num == 0)
				{
					return null;
				}
				return new IAddTimeConfig?(default(IAddTimeConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x170078A0 RID: 30880
		// (get) Token: 0x06018E8E RID: 102030 RVA: 0x0038D748 File Offset: 0x0038B948
		public ICompareVarConditionInQuestFailed? CompareVar
		{
			get
			{
				int num = this.__p.__offset(46);
				if (num == 0)
				{
					return null;
				}
				return new ICompareVarConditionInQuestFailed?(default(ICompareVarConditionInQuestFailed).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x170078A1 RID: 30881
		// (get) Token: 0x06018E8F RID: 102031 RVA: 0x0038D7A8 File Offset: 0x0038B9A8
		public IRecallFishingBoat? RecallVehicle
		{
			get
			{
				int num = this.__p.__offset(48);
				if (num == 0)
				{
					return null;
				}
				return new IRecallFishingBoat?(default(IRecallFishingBoat).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x170078A2 RID: 30882
		// (get) Token: 0x06018E90 RID: 102032 RVA: 0x0038D808 File Offset: 0x0038BA08
		public bool SwitchGameDifficulty
		{
			get
			{
				int num = this.__p.__offset(50);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170078A3 RID: 30883
		// (get) Token: 0x06018E91 RID: 102033 RVA: 0x0038D848 File Offset: 0x0038BA48
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(52);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06018E92 RID: 102034 RVA: 0x0038D888 File Offset: 0x0038BA88
		public static Offset<IQuestFailedCondition> CreateIQuestFailedCondition(FlatBufferBuilder builder, Offset<ITimerConfig> TimerOffset = default(Offset<ITimerConfig>), Offset<ITimeRange> TimeRangeOffset = default(Offset<ITimeRange>), bool CanGiveUp = false, StringOffset TidGiveUpTextOffset = default(StringOffset), StringOffset TidGiveUpConfirmTextOffset = default(StringOffset), bool IsTransferFailure = false, bool IsTeamDeathFailure = false, bool IsNonAiTeamDeathFailure = false, bool IsLeaveDungeonFailure = false, VectorOffset CheckDungeonFailureOffset = default(VectorOffset), Offset<IRangeLimitingCondition> RangeLimitingOffset = default(Offset<IRangeLimitingCondition>), Offset<IEntityDistanceLimitingCondition> EntityDistanceLimitingOffset = default(Offset<IEntityDistanceLimitingCondition>), Offset<IQuestFailedConditionEntityAlert> EntityAlertOffset = default(Offset<IQuestFailedConditionEntityAlert>), Offset<IQuestFailedConditionEntityDeath> EntityDeathConditionOffset = default(Offset<IQuestFailedConditionEntityDeath>), Offset<IQuestFailedConditionEntityState> EntityStateConditionOffset = default(Offset<IQuestFailedConditionEntityState>), Offset<ISneakPlayCondition> SneakPlayConditionOffset = default(Offset<ISneakPlayCondition>), Offset<IQuestFailedConditionPlayerMotionState> PlayerMotionStateConditionOffset = default(Offset<IQuestFailedConditionPlayerMotionState>), Offset<IQuestFailedConditionPlayerMovementMode> PlayerMovementModeConditionOffset = default(Offset<IQuestFailedConditionPlayerMovementMode>), Offset<ICheckDataLayer> CheckDataLayerOffset = default(Offset<ICheckDataLayer>), Offset<IFailedTeleport> FailedTeleportOffset = default(Offset<IFailedTeleport>), Offset<IAddTimeConfig> AddTimeConfigOffset = default(Offset<IAddTimeConfig>), Offset<ICompareVarConditionInQuestFailed> CompareVarOffset = default(Offset<ICompareVarConditionInQuestFailed>), Offset<IRecallFishingBoat> RecallVehicleOffset = default(Offset<IRecallFishingBoat>), bool SwitchGameDifficulty = false, byte NullMask = 0)
		{
			builder.StartTable(25);
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
			IQuestFailedCondition.AddTidGiveUpConfirmText(builder, TidGiveUpConfirmTextOffset);
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

		// Token: 0x06018E93 RID: 102035 RVA: 0x0038D968 File Offset: 0x0038BB68
		public static void StartIQuestFailedCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(25);
		}

		// Token: 0x06018E94 RID: 102036 RVA: 0x0038D972 File Offset: 0x0038BB72
		public static void AddTimer(FlatBufferBuilder builder, Offset<ITimerConfig> timerOffset)
		{
			builder.AddOffset(0, timerOffset.Value, 0);
		}

		// Token: 0x06018E95 RID: 102037 RVA: 0x0038D982 File Offset: 0x0038BB82
		public static void AddTimeRange(FlatBufferBuilder builder, Offset<ITimeRange> timeRangeOffset)
		{
			builder.AddOffset(1, timeRangeOffset.Value, 0);
		}

		// Token: 0x06018E96 RID: 102038 RVA: 0x0038D992 File Offset: 0x0038BB92
		public static void AddCanGiveUp(FlatBufferBuilder builder, bool canGiveUp)
		{
			builder.AddBool(2, canGiveUp, false);
		}

		// Token: 0x06018E97 RID: 102039 RVA: 0x0038D99D File Offset: 0x0038BB9D
		public static void AddTidGiveUpText(FlatBufferBuilder builder, StringOffset tidGiveUpTextOffset)
		{
			builder.AddOffset(3, tidGiveUpTextOffset.Value, 0);
		}

		// Token: 0x06018E98 RID: 102040 RVA: 0x0038D9AD File Offset: 0x0038BBAD
		public static void AddTidGiveUpConfirmText(FlatBufferBuilder builder, StringOffset tidGiveUpConfirmTextOffset)
		{
			builder.AddOffset(4, tidGiveUpConfirmTextOffset.Value, 0);
		}

		// Token: 0x06018E99 RID: 102041 RVA: 0x0038D9BD File Offset: 0x0038BBBD
		public static void AddIsTransferFailure(FlatBufferBuilder builder, bool isTransferFailure)
		{
			builder.AddBool(5, isTransferFailure, false);
		}

		// Token: 0x06018E9A RID: 102042 RVA: 0x0038D9C8 File Offset: 0x0038BBC8
		public static void AddIsTeamDeathFailure(FlatBufferBuilder builder, bool isTeamDeathFailure)
		{
			builder.AddBool(6, isTeamDeathFailure, false);
		}

		// Token: 0x06018E9B RID: 102043 RVA: 0x0038D9D3 File Offset: 0x0038BBD3
		public static void AddIsNonAiTeamDeathFailure(FlatBufferBuilder builder, bool isNonAiTeamDeathFailure)
		{
			builder.AddBool(7, isNonAiTeamDeathFailure, false);
		}

		// Token: 0x06018E9C RID: 102044 RVA: 0x0038D9DE File Offset: 0x0038BBDE
		public static void AddIsLeaveDungeonFailure(FlatBufferBuilder builder, bool isLeaveDungeonFailure)
		{
			builder.AddBool(8, isLeaveDungeonFailure, false);
		}

		// Token: 0x06018E9D RID: 102045 RVA: 0x0038D9E9 File Offset: 0x0038BBE9
		public static void AddCheckDungeonFailure(FlatBufferBuilder builder, VectorOffset checkDungeonFailureOffset)
		{
			builder.AddOffset(9, checkDungeonFailureOffset.Value, 0);
		}

		// Token: 0x06018E9E RID: 102046 RVA: 0x0038D9FC File Offset: 0x0038BBFC
		public static VectorOffset CreateCheckDungeonFailureVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06018E9F RID: 102047 RVA: 0x0038DA33 File Offset: 0x0038BC33
		public static VectorOffset CreateCheckDungeonFailureVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06018EA0 RID: 102048 RVA: 0x0038DA4D File Offset: 0x0038BC4D
		public static VectorOffset CreateCheckDungeonFailureVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06018EA1 RID: 102049 RVA: 0x0038DA6B File Offset: 0x0038BC6B
		public static VectorOffset CreateCheckDungeonFailureVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06018EA2 RID: 102050 RVA: 0x0038DA84 File Offset: 0x0038BC84
		public static void StartCheckDungeonFailureVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06018EA3 RID: 102051 RVA: 0x0038DA8F File Offset: 0x0038BC8F
		public static void AddRangeLimiting(FlatBufferBuilder builder, Offset<IRangeLimitingCondition> rangeLimitingOffset)
		{
			builder.AddOffset(10, rangeLimitingOffset.Value, 0);
		}

		// Token: 0x06018EA4 RID: 102052 RVA: 0x0038DAA0 File Offset: 0x0038BCA0
		public static void AddEntityDistanceLimiting(FlatBufferBuilder builder, Offset<IEntityDistanceLimitingCondition> entityDistanceLimitingOffset)
		{
			builder.AddOffset(11, entityDistanceLimitingOffset.Value, 0);
		}

		// Token: 0x06018EA5 RID: 102053 RVA: 0x0038DAB1 File Offset: 0x0038BCB1
		public static void AddEntityAlert(FlatBufferBuilder builder, Offset<IQuestFailedConditionEntityAlert> entityAlertOffset)
		{
			builder.AddOffset(12, entityAlertOffset.Value, 0);
		}

		// Token: 0x06018EA6 RID: 102054 RVA: 0x0038DAC2 File Offset: 0x0038BCC2
		public static void AddEntityDeathCondition(FlatBufferBuilder builder, Offset<IQuestFailedConditionEntityDeath> entityDeathConditionOffset)
		{
			builder.AddOffset(13, entityDeathConditionOffset.Value, 0);
		}

		// Token: 0x06018EA7 RID: 102055 RVA: 0x0038DAD3 File Offset: 0x0038BCD3
		public static void AddEntityStateCondition(FlatBufferBuilder builder, Offset<IQuestFailedConditionEntityState> entityStateConditionOffset)
		{
			builder.AddOffset(14, entityStateConditionOffset.Value, 0);
		}

		// Token: 0x06018EA8 RID: 102056 RVA: 0x0038DAE4 File Offset: 0x0038BCE4
		public static void AddSneakPlayCondition(FlatBufferBuilder builder, Offset<ISneakPlayCondition> sneakPlayConditionOffset)
		{
			builder.AddOffset(15, sneakPlayConditionOffset.Value, 0);
		}

		// Token: 0x06018EA9 RID: 102057 RVA: 0x0038DAF5 File Offset: 0x0038BCF5
		public static void AddPlayerMotionStateCondition(FlatBufferBuilder builder, Offset<IQuestFailedConditionPlayerMotionState> playerMotionStateConditionOffset)
		{
			builder.AddOffset(16, playerMotionStateConditionOffset.Value, 0);
		}

		// Token: 0x06018EAA RID: 102058 RVA: 0x0038DB06 File Offset: 0x0038BD06
		public static void AddPlayerMovementModeCondition(FlatBufferBuilder builder, Offset<IQuestFailedConditionPlayerMovementMode> playerMovementModeConditionOffset)
		{
			builder.AddOffset(17, playerMovementModeConditionOffset.Value, 0);
		}

		// Token: 0x06018EAB RID: 102059 RVA: 0x0038DB17 File Offset: 0x0038BD17
		public static void AddCheckDataLayer(FlatBufferBuilder builder, Offset<ICheckDataLayer> checkDataLayerOffset)
		{
			builder.AddOffset(18, checkDataLayerOffset.Value, 0);
		}

		// Token: 0x06018EAC RID: 102060 RVA: 0x0038DB28 File Offset: 0x0038BD28
		public static void AddFailedTeleport(FlatBufferBuilder builder, Offset<IFailedTeleport> failedTeleportOffset)
		{
			builder.AddOffset(19, failedTeleportOffset.Value, 0);
		}

		// Token: 0x06018EAD RID: 102061 RVA: 0x0038DB39 File Offset: 0x0038BD39
		public static void AddAddTimeConfig(FlatBufferBuilder builder, Offset<IAddTimeConfig> addTimeConfigOffset)
		{
			builder.AddOffset(20, addTimeConfigOffset.Value, 0);
		}

		// Token: 0x06018EAE RID: 102062 RVA: 0x0038DB4A File Offset: 0x0038BD4A
		public static void AddCompareVar(FlatBufferBuilder builder, Offset<ICompareVarConditionInQuestFailed> compareVarOffset)
		{
			builder.AddOffset(21, compareVarOffset.Value, 0);
		}

		// Token: 0x06018EAF RID: 102063 RVA: 0x0038DB5B File Offset: 0x0038BD5B
		public static void AddRecallVehicle(FlatBufferBuilder builder, Offset<IRecallFishingBoat> recallVehicleOffset)
		{
			builder.AddOffset(22, recallVehicleOffset.Value, 0);
		}

		// Token: 0x06018EB0 RID: 102064 RVA: 0x0038DB6C File Offset: 0x0038BD6C
		public static void AddSwitchGameDifficulty(FlatBufferBuilder builder, bool switchGameDifficulty)
		{
			builder.AddBool(23, switchGameDifficulty, false);
		}

		// Token: 0x06018EB1 RID: 102065 RVA: 0x0038DB78 File Offset: 0x0038BD78
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(24, nullMask, 0);
		}

		// Token: 0x06018EB2 RID: 102066 RVA: 0x0038DB84 File Offset: 0x0038BD84
		public static Offset<IQuestFailedCondition> EndIQuestFailedCondition(FlatBufferBuilder builder)
		{
			return new Offset<IQuestFailedCondition>(builder.EndTable());
		}

		// Token: 0x06018EB3 RID: 102067 RVA: 0x0038DB94 File Offset: 0x0038BD94
		public IQuestFailedConditionT UnPack()
		{
			IQuestFailedConditionT questFailedConditionT = new IQuestFailedConditionT();
			this.UnPackTo(questFailedConditionT);
			return questFailedConditionT;
		}

		// Token: 0x06018EB4 RID: 102068 RVA: 0x0038DBB0 File Offset: 0x0038BDB0
		public void UnPackTo(IQuestFailedConditionT _o)
		{
			_o.Timer = ((this.Timer != null) ? this.Timer.Value.UnPack() : null);
			_o.TimeRange = ((this.TimeRange != null) ? this.TimeRange.Value.UnPack() : null);
			_o.CanGiveUp = this.CanGiveUp;
			_o.TidGiveUpText = this.TidGiveUpText;
			_o.TidGiveUpConfirmText = this.TidGiveUpConfirmText;
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

		// Token: 0x06018EB5 RID: 102069 RVA: 0x0038DF44 File Offset: 0x0038C144
		public static Offset<IQuestFailedCondition> Pack(FlatBufferBuilder builder, IQuestFailedConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IQuestFailedCondition>);
			}
			Offset<ITimerConfig> timerOffset = (_o.Timer == null) ? default(Offset<ITimerConfig>) : ITimerConfig.Pack(builder, _o.Timer);
			Offset<ITimeRange> timeRangeOffset = (_o.TimeRange == null) ? default(Offset<ITimeRange>) : ITimeRange.Pack(builder, _o.TimeRange);
			StringOffset tidGiveUpTextOffset = (_o.TidGiveUpText == null) ? default(StringOffset) : builder.CreateString(_o.TidGiveUpText);
			StringOffset tidGiveUpConfirmTextOffset = (_o.TidGiveUpConfirmText == null) ? default(StringOffset) : builder.CreateString(_o.TidGiveUpConfirmText);
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
			return IQuestFailedCondition.CreateIQuestFailedCondition(builder, timerOffset, timeRangeOffset, _o.CanGiveUp, tidGiveUpTextOffset, tidGiveUpConfirmTextOffset, _o.IsTransferFailure, _o.IsTeamDeathFailure, _o.IsNonAiTeamDeathFailure, _o.IsLeaveDungeonFailure, checkDungeonFailureOffset, rangeLimitingOffset, entityDistanceLimitingOffset, entityAlertOffset, entityDeathConditionOffset, entityStateConditionOffset, sneakPlayConditionOffset, playerMotionStateConditionOffset, playerMovementModeConditionOffset, checkDataLayerOffset, failedTeleportOffset, addTimeConfigOffset, compareVarOffset, recallVehicleOffset, _o.SwitchGameDifficulty, _o.NullMask);
		}

		// Token: 0x0400C4A9 RID: 50345
		private Table __p;
	}
}
