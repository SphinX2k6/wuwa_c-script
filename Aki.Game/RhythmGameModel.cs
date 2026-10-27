using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Gameplay.RhythmGame;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

// Token: 0x02001087 RID: 4231
[NullableContext(2)]
[Nullable(0)]
[Model(0)]
public class RhythmGameModel : ModelBase
{
	// Token: 0x17000921 RID: 2337
	// (get) Token: 0x06006E02 RID: 28162 RVA: 0x00165C8E File Offset: 0x00163E8E
	// (set) Token: 0x06006E03 RID: 28163 RVA: 0x00165C96 File Offset: 0x00163E96
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

	// Token: 0x06006E04 RID: 28164 RVA: 0x00165CBA File Offset: 0x00163EBA
	private void ClearCache()
	{
		this.ForceTargetActor = null;
		this.CurSplineComponent = null;
		this.RhythmGameConfig = null;
	}

	// Token: 0x06006E05 RID: 28165 RVA: 0x00165CD1 File Offset: 0x00163ED1
	protected override bool OnLeaveLevel()
	{
		this.ClearCache();
		return true;
	}

	// Token: 0x06006E06 RID: 28166 RVA: 0x00165CDA File Offset: 0x00163EDA
	protected override bool OnChangeMode()
	{
		this.ClearCache();
		return true;
	}

	// Token: 0x06006E07 RID: 28167 RVA: 0x00165CE3 File Offset: 0x00163EE3
	public RhythmGameSpeedLevelConfig GetCurrentSpeedLevelConfig()
	{
		return this.RhythmGameConfig.SpeedLevelConfig.Get(this.CurSpeedLevelConfigIndex);
	}

	// Token: 0x06006E08 RID: 28168 RVA: 0x00165CFB File Offset: 0x00163EFB
	public RhythmGameSpeedLevelConfig GetSpeedLevelConfigByIndex(int configIndex)
	{
		if (configIndex < 0)
		{
			return null;
		}
		return this.RhythmGameConfig.SpeedLevelConfig.Get(configIndex);
	}

	// Token: 0x06006E09 RID: 28169 RVA: 0x00165D14 File Offset: 0x00163F14
	public int GetScoreMultiplierByLevel(int levelIndex)
	{
		if (levelIndex >= this.ScoreMultipliers.Length)
		{
			return 1;
		}
		return this.ScoreMultipliers[levelIndex];
	}

	// Token: 0x06006E0A RID: 28170 RVA: 0x00165D2C File Offset: 0x00163F2C
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

	// Token: 0x17000922 RID: 2338
	// (get) Token: 0x06006E0B RID: 28171 RVA: 0x00165DCE File Offset: 0x00163FCE
	[Nullable(1)]
	public static RhythmGameModel Instance
	{
		[NullableContext(1)]
		get
		{
			return RhythmGameModel._Instance;
		}
	}

	// Token: 0x06006E0C RID: 28172 RVA: 0x00165DD5 File Offset: 0x00163FD5
	[NullableContext(1)]
	public static RhythmGameModel GetOrCreateInstance()
	{
		if (RhythmGameModel._Instance == null)
		{
			RhythmGameModel.CreateInstance();
		}
		return RhythmGameModel._Instance;
	}

	// Token: 0x06006E0D RID: 28173 RVA: 0x00165DE9 File Offset: 0x00163FE9
	public static bool CreateInstance()
	{
		if (RhythmGameModel._Instance != null)
		{
			return true;
		}
		RhythmGameModel._Instance = new RhythmGameModel();
		return true;
	}

	// Token: 0x06006E0E RID: 28174 RVA: 0x00165DFF File Offset: 0x00163FFF
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06006E0F RID: 28175 RVA: 0x00165E01 File Offset: 0x00164001
	public static void ResetStaticDefaultValue()
	{
		RhythmGameModel._Instance = null;
	}

	// Token: 0x06006E10 RID: 28176 RVA: 0x00165E09 File Offset: 0x00164009
	static RhythmGameModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(RhythmGameModel.CreateStaticDefaultValue), new Action(RhythmGameModel.ResetStaticDefaultValue));
	}

	// Token: 0x040032D0 RID: 13008
	public AActor ForceTargetActor;

	// Token: 0x040032D1 RID: 13009
	public USplineComponent CurSplineComponent;

	// Token: 0x040032D2 RID: 13010
	[Nullable(1)]
	public Vector SplineLocation = Vector.Create();

	// Token: 0x040032D3 RID: 13011
	public BP_RhythmGameConfig_C RhythmGameConfig;

	// Token: 0x040032D4 RID: 13012
	public bool OnRoadMode;

	// Token: 0x040032D5 RID: 13013
	private int CurSpeedLevelConfigIndexValue;

	// Token: 0x040032D6 RID: 13014
	public int FeverCeiling;

	// Token: 0x040032D7 RID: 13015
	[Nullable(1)]
	private int[] ScoreMultipliers = Array.Empty<int>();

	// Token: 0x040032D8 RID: 13016
	private static RhythmGameModel _Instance;
}
