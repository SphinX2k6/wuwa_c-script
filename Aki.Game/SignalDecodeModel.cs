using System;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02001F88 RID: 8072
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class SignalDecodeModel : ModelBase
{
	// Token: 0x06013F69 RID: 81769 RVA: 0x005D20A8 File Offset: 0x005D02A8
	public void GameplayStart(string id)
	{
		this.CurrentGameplayId = id;
		CatchSignalGameplay? gameplayConfig = SignalDecodeConfig.Instance.GetGameplayConfig(id);
		if (gameplayConfig == null)
		{
			return;
		}
		this.CurrentGameplayType = (ESignalGameplayType)gameplayConfig.Value.Type;
		this.CurrentMorseCode = (gameplayConfig.Value.MorseCode ?? "");
		this.CurrentDifficulty = gameplayConfig.Value.Difficulty;
		CatchSignalDifficulty? difficultyConfig = SignalDecodeConfig.Instance.GetDifficultyConfig(gameplayConfig.Value.Difficulty);
		if (difficultyConfig == null)
		{
			return;
		}
		this.TargetCompletion = difficultyConfig.Value.TargetCompletion;
		this.Speed = difficultyConfig.Value.SpeedRate * 100f;
		this.StartDecisionSize = difficultyConfig.Value.PressTimeWindow;
		this.EndDecisionSize = difficultyConfig.Value.ReleaseTimeWindow;
	}

	// Token: 0x17001E29 RID: 7721
	// (get) Token: 0x06013F6A RID: 81770 RVA: 0x005D2198 File Offset: 0x005D0398
	public static SignalDecodeModel Instance
	{
		get
		{
			return SignalDecodeModel._Instance;
		}
	}

	// Token: 0x06013F6B RID: 81771 RVA: 0x005D219F File Offset: 0x005D039F
	public static SignalDecodeModel GetOrCreateInstance()
	{
		if (SignalDecodeModel._Instance == null)
		{
			SignalDecodeModel.CreateInstance();
		}
		return SignalDecodeModel._Instance;
	}

	// Token: 0x06013F6C RID: 81772 RVA: 0x005D21B3 File Offset: 0x005D03B3
	public static bool CreateInstance()
	{
		if (SignalDecodeModel._Instance != null)
		{
			return true;
		}
		SignalDecodeModel._Instance = new SignalDecodeModel();
		return true;
	}

	// Token: 0x06013F6D RID: 81773 RVA: 0x005D21C9 File Offset: 0x005D03C9
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06013F6E RID: 81774 RVA: 0x005D21CB File Offset: 0x005D03CB
	public static void ResetStaticDefaultValue()
	{
		SignalDecodeModel._Instance = null;
	}

	// Token: 0x06013F6F RID: 81775 RVA: 0x005D21D3 File Offset: 0x005D03D3
	static SignalDecodeModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(SignalDecodeModel.CreateStaticDefaultValue), new Action(SignalDecodeModel.ResetStaticDefaultValue));
	}

	// Token: 0x0400AA0F RID: 43535
	public string CurrentGameplayId = "";

	// Token: 0x0400AA10 RID: 43536
	public ESignalGameplayType CurrentGameplayType = ESignalGameplayType.Catch;

	// Token: 0x0400AA11 RID: 43537
	public string CurrentMorseCode = "";

	// Token: 0x0400AA12 RID: 43538
	public int CurrentDifficulty;

	// Token: 0x0400AA13 RID: 43539
	public int TargetCompletion = 100;

	// Token: 0x0400AA14 RID: 43540
	public float Speed = 100f;

	// Token: 0x0400AA15 RID: 43541
	public int StartDecisionSize;

	// Token: 0x0400AA16 RID: 43542
	public int EndDecisionSize;

	// Token: 0x0400AA17 RID: 43543
	[Nullable(2)]
	private static SignalDecodeModel _Instance;
}
