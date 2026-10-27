using System;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02002A0D RID: 10765
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class SignalDecodeModel : ModelBase
{
	// Token: 0x06016562 RID: 91490 RVA: 0x005A70D0 File Offset: 0x005A52D0
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

	// Token: 0x17001DD0 RID: 7632
	// (get) Token: 0x06016563 RID: 91491 RVA: 0x005A71C0 File Offset: 0x005A53C0
	public static SignalDecodeModel Instance
	{
		get
		{
			return SignalDecodeModel._Instance;
		}
	}

	// Token: 0x06016564 RID: 91492 RVA: 0x005A71C7 File Offset: 0x005A53C7
	public static SignalDecodeModel GetOrCreateInstance()
	{
		if (SignalDecodeModel._Instance == null)
		{
			SignalDecodeModel.CreateInstance();
		}
		return SignalDecodeModel._Instance;
	}

	// Token: 0x06016565 RID: 91493 RVA: 0x005A71DB File Offset: 0x005A53DB
	public static bool CreateInstance()
	{
		if (SignalDecodeModel._Instance != null)
		{
			return true;
		}
		SignalDecodeModel._Instance = new SignalDecodeModel();
		return true;
	}

	// Token: 0x06016566 RID: 91494 RVA: 0x005A71F1 File Offset: 0x005A53F1
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06016567 RID: 91495 RVA: 0x005A71F3 File Offset: 0x005A53F3
	public static void ResetStaticDefaultValue()
	{
		SignalDecodeModel._Instance = null;
	}

	// Token: 0x06016568 RID: 91496 RVA: 0x005A71FB File Offset: 0x005A53FB
	static SignalDecodeModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(SignalDecodeModel.CreateStaticDefaultValue), new Action(SignalDecodeModel.ResetStaticDefaultValue));
	}

	// Token: 0x0400A625 RID: 42533
	public string CurrentGameplayId = "";

	// Token: 0x0400A626 RID: 42534
	public ESignalGameplayType CurrentGameplayType = ESignalGameplayType.Catch;

	// Token: 0x0400A627 RID: 42535
	public string CurrentMorseCode = "";

	// Token: 0x0400A628 RID: 42536
	public int CurrentDifficulty;

	// Token: 0x0400A629 RID: 42537
	public int TargetCompletion = 100;

	// Token: 0x0400A62A RID: 42538
	public float Speed = 100f;

	// Token: 0x0400A62B RID: 42539
	public int StartDecisionSize;

	// Token: 0x0400A62C RID: 42540
	public int EndDecisionSize;

	// Token: 0x0400A62D RID: 42541
	[Nullable(2)]
	private static SignalDecodeModel _Instance;
}
