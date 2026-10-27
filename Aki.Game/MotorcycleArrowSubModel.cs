using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using UnrealEngine;

// Token: 0x02000E9E RID: 3742
[NullableContext(1)]
[Nullable(0)]
public class MotorcycleArrowSubModel : KscSubModelBase
{
	// Token: 0x06005C26 RID: 23590 RVA: 0x00110280 File Offset: 0x0010E480
	public MotorcycleArrowSubModel()
	{
		this.ViewModeCollectionSelect = MotorcycleArrowCollectionSelectViewModel.Create(this);
	}

	// Token: 0x06005C27 RID: 23591 RVA: 0x00110369 File Offset: 0x0010E569
	public override string GetSkillDtPath()
	{
		return MotorcycleArrowSubModel.SkillDtPath;
	}

	// Token: 0x06005C28 RID: 23592 RVA: 0x00110370 File Offset: 0x0010E570
	public override string GetEntityDtPath()
	{
		return MotorcycleArrowSubModel.EntityDtPath;
	}

	// Token: 0x06005C29 RID: 23593 RVA: 0x00110377 File Offset: 0x0010E577
	public string SceneSegmentDtPathMethod()
	{
		return MotorcycleArrowSubModel.SceneSegmentDtPath;
	}

	// Token: 0x06005C2A RID: 23594 RVA: 0x0011037E File Offset: 0x0010E57E
	public void SetMotorcycleKscEntity(AKSC_Entity entity)
	{
		this.MotorcycleKscEntity = entity;
		this.MotorcycleKscEntityId = entity.EntityId_;
	}

	// Token: 0x06005C2B RID: 23595 RVA: 0x00110393 File Offset: 0x0010E593
	public MotorcycleArrowBattleSkillData GetMotorcycleArrowBattleSkillData()
	{
		if (this.MotorcycleArrowBattleSkillData == null)
		{
			this.MotorcycleArrowBattleSkillData = new MotorcycleArrowBattleSkillData(220003);
			this.MotorcycleArrowBattleSkillData.InitData("载具漂移");
		}
		return this.MotorcycleArrowBattleSkillData;
	}

	// Token: 0x06005C2C RID: 23596 RVA: 0x001103C3 File Offset: 0x0010E5C3
	protected override bool OnInit()
	{
		this.HeadStateManager.Init();
		return true;
	}

	// Token: 0x06005C2D RID: 23597 RVA: 0x001103D4 File Offset: 0x0010E5D4
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

	// Token: 0x040029F6 RID: 10742
	public const int TRACK_HALF_WIDTH = 500;

	// Token: 0x040029F7 RID: 10743
	public const int MOTOR_HORIZONTAL_MOVE_LIMIT = 1000;

	// Token: 0x040029F8 RID: 10744
	private const int ACTIVE_SKILL_ID = 220003;

	// Token: 0x040029F9 RID: 10745
	public MotorcycleArrowCollectionSelectViewModel ViewModeCollectionSelect;

	// Token: 0x040029FA RID: 10746
	public float DelayShowCollectionSelectView;

	// Token: 0x040029FB RID: 10747
	[Nullable(2)]
	public TimerHandle DelayShowCollectionSelectViewTimer;

	// Token: 0x040029FC RID: 10748
	public static readonly string SceneSegmentDtPath = "/Game/Aki/Data/SimpleCombat/3_1Jianjianjian/Scene/DT_KSCSceneSegment.DT_KSCSceneSegment";

	// Token: 0x040029FD RID: 10749
	public static readonly string SkillDtPath = "/Game/Aki/Data/SimpleCombat/3_1Jianjianjian/Player/DT_KscSkill.DT_KscSkill";

	// Token: 0x040029FE RID: 10750
	public static readonly string EntityDtPath = "/Game/Aki/Data/SimpleCombat/3_1Jianjianjian/Player/DT_KscEntity.DT_KscEntity";

	// Token: 0x040029FF RID: 10751
	[Nullable(new byte[]
	{
		1,
		0,
		1,
		1
	})]
	public readonly Dictionary<int, ValueTuple<FKSCSceneSegmentTableRow, string>> SceneSegmentDataDt = new Dictionary<int, ValueTuple<FKSCSceneSegmentTableRow, string>>();

	// Token: 0x04002A00 RID: 10752
	public static readonly string BulletDtPath = "/Game/Aki/Data/SimpleCombat/3_1Jianjianjian/DT_KuroBulletData_Jianjianjian.DT_KuroBulletData_Jianjianjian";

	// Token: 0x04002A01 RID: 10753
	[Nullable(2)]
	public UDataTable BulletDataTable;

	// Token: 0x04002A02 RID: 10754
	public MotorFightMainLevel? LevelConfig;

	// Token: 0x04002A03 RID: 10755
	public global::Vector PlayerBornPos = global::Vector.Create(0.0, 0.0, 0.0);

	// Token: 0x04002A04 RID: 10756
	public global::Vector PlayerDirect = global::Vector.Create(0.0, 0.0, 0.0);

	// Token: 0x04002A05 RID: 10757
	public global::Vector PlayerRight = global::Vector.Create(0.0, 0.0, 0.0);

	// Token: 0x04002A06 RID: 10758
	public global::Rotator PlayerBornRot = global::Rotator.Create();

	// Token: 0x04002A07 RID: 10759
	public int MotorPosZ;

	// Token: 0x04002A08 RID: 10760
	public int Score;

	// Token: 0x04002A09 RID: 10761
	public int LevelStartTime;

	// Token: 0x04002A0A RID: 10762
	[Nullable(2)]
	public MotorFightRoundInfoNotify MotorFightRoundInfo;

	// Token: 0x04002A0B RID: 10763
	public List<MotorFightRoundBuffPb> PendingPlayerBuff = new List<MotorFightRoundBuffPb>();

	// Token: 0x04002A0C RID: 10764
	public int MotorArrowDropThreshold;

	// Token: 0x04002A0D RID: 10765
	public bool IsCountDownEnd;

	// Token: 0x04002A0E RID: 10766
	public bool IsGameOver;

	// Token: 0x04002A0F RID: 10767
	public List<string> BossIconPathList = new List<string>();

	// Token: 0x04002A10 RID: 10768
	public MotorcycleArrowGenerate Generate = new MotorcycleArrowGenerate();

	// Token: 0x04002A11 RID: 10769
	[Nullable(2)]
	public MotorFightRefreshSubLevelNotify PendingMotorFightRefreshNotify;

	// Token: 0x04002A12 RID: 10770
	public int SubLevelIndex;

	// Token: 0x04002A13 RID: 10771
	public int CurrentSubLevelId;

	// Token: 0x04002A14 RID: 10772
	public List<int> WaveGroupCount = new List<int>();

	// Token: 0x04002A15 RID: 10773
	public int CurrentGroupWaveIndex;

	// Token: 0x04002A16 RID: 10774
	public MotorFightSubLevel? SubLevelConfig;

	// Token: 0x04002A17 RID: 10775
	public bool InLoopSceneSegment;

	// Token: 0x04002A18 RID: 10776
	public int EndDistance;

	// Token: 0x04002A19 RID: 10777
	public bool IsInBossBattle;

	// Token: 0x04002A1A RID: 10778
	public int ActiveBossCount;

	// Token: 0x04002A1B RID: 10779
	public int BossFightTime;

	// Token: 0x04002A1C RID: 10780
	public int BossFightStartTime;

	// Token: 0x04002A1D RID: 10781
	public int BossCreatureDataId;

	// Token: 0x04002A1E RID: 10782
	public MotorcycleHeadStateManager HeadStateManager = new MotorcycleHeadStateManager();

	// Token: 0x04002A1F RID: 10783
	public Dictionary<int, MotorFightAttr> MotorPropertyConfigs = new Dictionary<int, MotorFightAttr>();

	// Token: 0x04002A20 RID: 10784
	public long MotorcycleCreatureDataId;

	// Token: 0x04002A21 RID: 10785
	public int MotorcycleKscEntityId;

	// Token: 0x04002A22 RID: 10786
	[Nullable(2)]
	public AKSC_Entity MotorcycleKscEntity;

	// Token: 0x04002A23 RID: 10787
	public int MotorHorizontalMoveDistance;

	// Token: 0x04002A24 RID: 10788
	public float MotorArrowAccelerateTime;

	// Token: 0x04002A25 RID: 10789
	public int MotorRollRot;

	// Token: 0x04002A26 RID: 10790
	public float MotorArrowDecelerateTime;

	// Token: 0x04002A27 RID: 10791
	public int MotorArrowCurSpeed;

	// Token: 0x04002A28 RID: 10792
	public int AudioEventHandle;

	// Token: 0x04002A29 RID: 10793
	[Nullable(2)]
	private MotorcycleArrowBattleSkillData MotorcycleArrowBattleSkillData;
}
