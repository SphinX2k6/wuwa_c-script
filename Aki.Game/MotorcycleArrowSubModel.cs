using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using UnrealEngine;

// Token: 0x02000353 RID: 851
[NullableContext(1)]
[Nullable(0)]
public class MotorcycleArrowSubModel : KscSubModelBase
{
	// Token: 0x06002FBD RID: 12221 RVA: 0x00117F1C File Offset: 0x0011611C
	public MotorcycleArrowSubModel()
	{
		this.ViewModeCollectionSelect = MotorcycleArrowCollectionSelectViewModel.Create(this);
	}

	// Token: 0x06002FBE RID: 12222 RVA: 0x00118005 File Offset: 0x00116205
	public override string GetSkillDtPath()
	{
		return MotorcycleArrowSubModel.SkillDtPath;
	}

	// Token: 0x06002FBF RID: 12223 RVA: 0x0011800C File Offset: 0x0011620C
	public override string GetEntityDtPath()
	{
		return MotorcycleArrowSubModel.EntityDtPath;
	}

	// Token: 0x06002FC0 RID: 12224 RVA: 0x00118013 File Offset: 0x00116213
	public string SceneSegmentDtPathMethod()
	{
		return MotorcycleArrowSubModel.SceneSegmentDtPath;
	}

	// Token: 0x06002FC1 RID: 12225 RVA: 0x0011801A File Offset: 0x0011621A
	public void SetMotorcycleKscEntity(AKSC_Entity entity)
	{
		this.MotorcycleKscEntity = entity;
		this.MotorcycleKscEntityId = entity.EntityId_;
	}

	// Token: 0x06002FC2 RID: 12226 RVA: 0x0011802F File Offset: 0x0011622F
	public MotorcycleArrowBattleSkillData GetMotorcycleArrowBattleSkillData()
	{
		if (this.MotorcycleArrowBattleSkillData == null)
		{
			this.MotorcycleArrowBattleSkillData = new MotorcycleArrowBattleSkillData(220003);
			this.MotorcycleArrowBattleSkillData.InitData("载具漂移");
		}
		return this.MotorcycleArrowBattleSkillData;
	}

	// Token: 0x06002FC3 RID: 12227 RVA: 0x0011805F File Offset: 0x0011625F
	protected override bool OnInit()
	{
		this.HeadStateManager.Init();
		return true;
	}

	// Token: 0x06002FC4 RID: 12228 RVA: 0x00118070 File Offset: 0x00116270
	protected override bool OnClear()
	{
		this.SubLevelIndex = 0;
		this.CurrentGroupWaveIndex = 0;
		this.LevelConfig = null;
		this.SceneSegmentDataDt.Clear();
		this.Generate.Clear();
		this.HeadStateManager.Clear();
		this.MotorcycleCreatureDataId = 0L;
		this.MotorcycleKscEntityId = 0;
		this.MotorcycleKscEntity = null;
		this.Score = 0;
		this.LevelStartTime = 0;
		this.MotorFightRoundInfo = null;
		this.WaveGroupCount.Clear();
		this.PendingMotorFightRefreshNotify = null;
		this.MotorPropertyConfigs.Clear();
		this.MotorHorizontalMoveDistance = 0;
		this.BossFightTime = 0;
		this.IsInBossBattle = false;
		this.ActiveBossCount = 0;
		this.InLoopSceneSegment = false;
		this.SubLevelConfig = null;
		this.CurrentSubLevelId = 0;
		this.EndDistance = 0;
		this.BossCreatureDataId = 0;
		this.ViewModeCollectionSelect.Clear();
		MotorcycleArrowBattleSkillData motorcycleArrowBattleSkillData = this.MotorcycleArrowBattleSkillData;
		if (motorcycleArrowBattleSkillData != null)
		{
			motorcycleArrowBattleSkillData.Clear();
		}
		this.MotorcycleArrowBattleSkillData = null;
		this.MotorRollRot = 0;
		this.IsCountDownEnd = false;
		this.IsGameOver = false;
		this.PendingPlayerBuff.Clear();
		this.BossIconPathList.Clear();
		this.DelayShowCollectionSelectViewTimer = null;
		this.MotorArrowCurSpeed = 0;
		this.AudioEventHandle = 0;
		return true;
	}

	// Token: 0x04002A91 RID: 10897
	public const int TRACK_HALF_WIDTH = 500;

	// Token: 0x04002A92 RID: 10898
	public const int MOTOR_HORIZONTAL_MOVE_LIMIT = 1000;

	// Token: 0x04002A93 RID: 10899
	private const int ACTIVE_SKILL_ID = 220003;

	// Token: 0x04002A94 RID: 10900
	public MotorcycleArrowCollectionSelectViewModel ViewModeCollectionSelect;

	// Token: 0x04002A95 RID: 10901
	public float DelayShowCollectionSelectView;

	// Token: 0x04002A96 RID: 10902
	[Nullable(2)]
	public TimerHandle DelayShowCollectionSelectViewTimer;

	// Token: 0x04002A97 RID: 10903
	public static readonly string SceneSegmentDtPath = "/Game/Aki/Data/SimpleCombat/3_1Jianjianjian/Scene/DT_KSCSceneSegment.DT_KSCSceneSegment";

	// Token: 0x04002A98 RID: 10904
	public static readonly string SkillDtPath = "/Game/Aki/Data/SimpleCombat/3_1Jianjianjian/Player/DT_KscSkill.DT_KscSkill";

	// Token: 0x04002A99 RID: 10905
	public static readonly string EntityDtPath = "/Game/Aki/Data/SimpleCombat/3_1Jianjianjian/Player/DT_KscEntity.DT_KscEntity";

	// Token: 0x04002A9A RID: 10906
	[Nullable(new byte[]
	{
		1,
		0,
		1,
		1
	})]
	public readonly Dictionary<int, ValueTuple<FKSCSceneSegmentTableRow, string>> SceneSegmentDataDt = new Dictionary<int, ValueTuple<FKSCSceneSegmentTableRow, string>>();

	// Token: 0x04002A9B RID: 10907
	public static readonly string BulletDtPath = "/Game/Aki/Data/SimpleCombat/3_1Jianjianjian/DT_KuroBulletData_Jianjianjian.DT_KuroBulletData_Jianjianjian";

	// Token: 0x04002A9C RID: 10908
	[Nullable(2)]
	public UDataTable BulletDataTable;

	// Token: 0x04002A9D RID: 10909
	public MotorFightMainLevel? LevelConfig;

	// Token: 0x04002A9E RID: 10910
	public global::Vector PlayerBornPos = global::Vector.Create(0.0, 0.0, 0.0);

	// Token: 0x04002A9F RID: 10911
	public global::Vector PlayerDirect = global::Vector.Create(0.0, 0.0, 0.0);

	// Token: 0x04002AA0 RID: 10912
	public global::Vector PlayerRight = global::Vector.Create(0.0, 0.0, 0.0);

	// Token: 0x04002AA1 RID: 10913
	public global::Rotator PlayerBornRot = global::Rotator.Create();

	// Token: 0x04002AA2 RID: 10914
	public int MotorPosZ;

	// Token: 0x04002AA3 RID: 10915
	public int Score;

	// Token: 0x04002AA4 RID: 10916
	public int LevelStartTime;

	// Token: 0x04002AA5 RID: 10917
	[Nullable(2)]
	public MotorFightRoundInfoNotify MotorFightRoundInfo;

	// Token: 0x04002AA6 RID: 10918
	public List<MotorFightRoundBuffPb> PendingPlayerBuff = new List<MotorFightRoundBuffPb>();

	// Token: 0x04002AA7 RID: 10919
	public int MotorArrowDropThreshold;

	// Token: 0x04002AA8 RID: 10920
	public bool IsCountDownEnd;

	// Token: 0x04002AA9 RID: 10921
	public bool IsGameOver;

	// Token: 0x04002AAA RID: 10922
	public List<string> BossIconPathList = new List<string>();

	// Token: 0x04002AAB RID: 10923
	public MotorcycleArrowGenerate Generate = new MotorcycleArrowGenerate();

	// Token: 0x04002AAC RID: 10924
	[Nullable(2)]
	public MotorFightRefreshSubLevelNotify PendingMotorFightRefreshNotify;

	// Token: 0x04002AAD RID: 10925
	public int SubLevelIndex;

	// Token: 0x04002AAE RID: 10926
	public int CurrentSubLevelId;

	// Token: 0x04002AAF RID: 10927
	public List<int> WaveGroupCount = new List<int>();

	// Token: 0x04002AB0 RID: 10928
	public int CurrentGroupWaveIndex;

	// Token: 0x04002AB1 RID: 10929
	public MotorFightSubLevel? SubLevelConfig;

	// Token: 0x04002AB2 RID: 10930
	public bool InLoopSceneSegment;

	// Token: 0x04002AB3 RID: 10931
	public int EndDistance;

	// Token: 0x04002AB4 RID: 10932
	public bool IsInBossBattle;

	// Token: 0x04002AB5 RID: 10933
	public int ActiveBossCount;

	// Token: 0x04002AB6 RID: 10934
	public int BossFightTime;

	// Token: 0x04002AB7 RID: 10935
	public int BossFightStartTime;

	// Token: 0x04002AB8 RID: 10936
	public int BossCreatureDataId;

	// Token: 0x04002AB9 RID: 10937
	public MotorcycleHeadStateManager HeadStateManager = new MotorcycleHeadStateManager();

	// Token: 0x04002ABA RID: 10938
	public Dictionary<int, MotorFightAttr> MotorPropertyConfigs = new Dictionary<int, MotorFightAttr>();

	// Token: 0x04002ABB RID: 10939
	public long MotorcycleCreatureDataId;

	// Token: 0x04002ABC RID: 10940
	public int MotorcycleKscEntityId;

	// Token: 0x04002ABD RID: 10941
	[Nullable(2)]
	public AKSC_Entity MotorcycleKscEntity;

	// Token: 0x04002ABE RID: 10942
	public int MotorHorizontalMoveDistance;

	// Token: 0x04002ABF RID: 10943
	public float MotorArrowAccelerateTime;

	// Token: 0x04002AC0 RID: 10944
	public int MotorRollRot;

	// Token: 0x04002AC1 RID: 10945
	public float MotorArrowDecelerateTime;

	// Token: 0x04002AC2 RID: 10946
	public int MotorArrowCurSpeed;

	// Token: 0x04002AC3 RID: 10947
	public int AudioEventHandle;

	// Token: 0x04002AC4 RID: 10948
	[Nullable(2)]
	private MotorcycleArrowBattleSkillData MotorcycleArrowBattleSkillData;
}
