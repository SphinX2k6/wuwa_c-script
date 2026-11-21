using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Gameplay.RhythmGame;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

// Token: 0x0200053B RID: 1339
[NullableContext(2)]
[Nullable(0)]
[Model(0)]
public class RhythmGameModel : ModelBase
{
	// Token: 0x17000941 RID: 2369
	// (get) Token: 0x06004197 RID: 16791 RVA: 0x0016E5C2 File Offset: 0x0016C7C2
	// (set) Token: 0x06004198 RID: 16792 RVA: 0x0016E5CA File Offset: 0x0016C7CA
	public int CurSpeedLevelConfigIndex
	{
		get
		{
			return this.CurSpeedLevelConfigIndexValue;
		}
		set
		{
			if (this.CurSpeedLevelConfigIndexValue == value)
			{
				return;
			}
			this.CurSpeedLevelConfigIndexValue = value;
			EventSystem.Instance.Emit<int>(EEventName.OnRhythmGameSpeedLevelConfigIndexChanged, value);
		}
	}

	// Token: 0x06004199 RID: 16793 RVA: 0x0016E5EE File Offset: 0x0016C7EE
	private void ClearCache()
	{
		this.ForceTargetActor = null;
		this.CurSplineComponent = null;
		this.RhythmGameConfig = null;
	}

	// Token: 0x0600419A RID: 16794 RVA: 0x0016E605 File Offset: 0x0016C805
	protected override bool OnLeaveLevel()
	{
		this.ClearCache();
		return true;
	}

	// Token: 0x0600419B RID: 16795 RVA: 0x0016E60E File Offset: 0x0016C80E
	protected override bool OnChangeMode()
	{
		this.ClearCache();
		return true;
	}

	// Token: 0x0600419C RID: 16796 RVA: 0x0016E617 File Offset: 0x0016C817
	public RhythmGameSpeedLevelConfig GetCurrentSpeedLevelConfig()
	{
		return this.RhythmGameConfig.SpeedLevelConfig.Get(this.CurSpeedLevelConfigIndex);
	}

	// Token: 0x0600419D RID: 16797 RVA: 0x0016E62F File Offset: 0x0016C82F
	public RhythmGameSpeedLevelConfig GetSpeedLevelConfigByIndex(int configIndex)
	{
		if (configIndex < 0)
		{
			return null;
		}
		return this.RhythmGameConfig.SpeedLevelConfig.Get(configIndex);
	}

	// Token: 0x0600419E RID: 16798 RVA: 0x0016E648 File Offset: 0x0016C848
	public int GetScoreMultiplierByLevel(int levelIndex)
	{
		if (levelIndex >= this.ScoreMultipliers.Length)
		{
			return 1;
		}
		return this.ScoreMultipliers[levelIndex];
	}

	// Token: 0x0600419F RID: 16799 RVA: 0x0016E660 File Offset: 0x0016C860
	public void InitializeScoreMultipliers()
	{
		BP_RhythmGameConfig_C rhythmGameConfig = this.RhythmGameConfig;
		FKuroRhythmGameConfig fkuroRhythmGameConfig = (rhythmGameConfig != null) ? rhythmGameConfig.Config : null;
		if (fkuroRhythmGameConfig == null)
		{
			this.ScoreMultipliers = new int[]
			{
				1,
				1,
				1,
				1,
				1
			};
			return;
		}
		FKuroRhythmGameHiddenScore hiddenScore = fkuroRhythmGameConfig.HiddenScore;
		if (hiddenScore == null)
		{
			this.ScoreMultipliers = new int[]
			{
				1,
				1,
				1,
				1,
				1
			};
			return;
		}
		this.ScoreMultipliers = new int[]
		{
			hiddenScore.Level1ScoreMultiplier,
			hiddenScore.Level2ScoreMultiplier,
			hiddenScore.Level3ScoreMultiplier,
			hiddenScore.Level4ScoreMultiplier,
			hiddenScore.Level5ScoreMultiplier
		};
	}

	// Token: 0x17000942 RID: 2370
	// (get) Token: 0x060041A0 RID: 16800 RVA: 0x0016E702 File Offset: 0x0016C902
	[Nullable(1)]
	public static RhythmGameModel Instance
	{
		[NullableContext(1)]
		get
		{
			return RhythmGameModel._Instance;
		}
	}

	// Token: 0x060041A1 RID: 16801 RVA: 0x0016E709 File Offset: 0x0016C909
	[NullableContext(1)]
	public static RhythmGameModel GetOrCreateInstance()
	{
		if (RhythmGameModel._Instance == null)
		{
			RhythmGameModel.CreateInstance();
		}
		return RhythmGameModel._Instance;
	}

	// Token: 0x060041A2 RID: 16802 RVA: 0x0016E71D File Offset: 0x0016C91D
	public static bool CreateInstance()
	{
		if (RhythmGameModel._Instance != null)
		{
			return true;
		}
		RhythmGameModel._Instance = new RhythmGameModel();
		return true;
	}

	// Token: 0x060041A3 RID: 16803 RVA: 0x0016E733 File Offset: 0x0016C933
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060041A4 RID: 16804 RVA: 0x0016E735 File Offset: 0x0016C935
	public static void ResetStaticDefaultValue()
	{
		RhythmGameModel._Instance = null;
	}

	// Token: 0x060041A5 RID: 16805 RVA: 0x0016E73D File Offset: 0x0016C93D
	static RhythmGameModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(RhythmGameModel.CreateStaticDefaultValue), new Action(RhythmGameModel.ResetStaticDefaultValue));
	}

	// Token: 0x04003369 RID: 13161
	public AActor ForceTargetActor;

	// Token: 0x0400336A RID: 13162
	public USplineComponent CurSplineComponent;

	// Token: 0x0400336B RID: 13163
	[Nullable(1)]
	public Vector SplineLocation = Vector.Create();

	// Token: 0x0400336C RID: 13164
	public BP_RhythmGameConfig_C RhythmGameConfig;

	// Token: 0x0400336D RID: 13165
	public bool OnRoadMode;

	// Token: 0x0400336E RID: 13166
	private int CurSpeedLevelConfigIndexValue;

	// Token: 0x0400336F RID: 13167
	public int FeverCeiling;

	// Token: 0x04003370 RID: 13168
	[Nullable(1)]
	private int[] ScoreMultipliers = Array.Empty<int>();

	// Token: 0x04003371 RID: 13169
	private static RhythmGameModel _Instance;
}
