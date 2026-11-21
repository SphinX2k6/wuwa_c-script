using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;

// Token: 0x02001539 RID: 5433
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class LevelUpController : UiControllerBase
{
	// Token: 0x0600D996 RID: 55702 RVA: 0x004081C4 File Offset: 0x004063C4
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add<int, int, int, int, int, int, int>(EEventName.OnPlayerLevelChanged, new Action<int, int, int, int, int, int, int>(this.OnPlayerLevelChanged));
		EventSystem.Instance.Add<int, int, int>(EEventName.OnPlayerExpChanged, new Action<int, int, int>(this.OnPlayerExpChanged));
		EventSystem.Instance.Add(EEventName.OnFinishLoadingState, new Action(this.OnShowLevelOnly));
	}

	// Token: 0x0600D997 RID: 55703 RVA: 0x00408228 File Offset: 0x00406428
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.OnPlayerLevelChanged, new Action<int, int, int, int, int, int, int>(this.OnPlayerLevelChanged));
		EventSystem.Instance.Remove(EEventName.OnPlayerExpChanged, new Action<int, int, int>(this.OnPlayerExpChanged));
		EventSystem.Instance.Remove(EEventName.OnFinishLoadingState, new Action(this.OnShowLevelOnly));
	}

	// Token: 0x0600D998 RID: 55704 RVA: 0x0040828C File Offset: 0x0040648C
	private void OnPlayerExpChanged(int currentExp, int lastExp, int maxExp)
	{
		int? playerLevel = FunctionModel.Instance.GetPlayerLevel();
		int? hiddenLevelUpLevel = LevelUpConfig.Instance.GetHiddenLevelUpLevel();
		if (hiddenLevelUpLevel != null && playerLevel.GetValueOrDefault() < hiddenLevelUpLevel.Value)
		{
			return;
		}
		int differenceExp = FunctionConfig.Instance.GetDifferenceExp(playerLevel.Value, lastExp, playerLevel.Value, currentExp);
		LevelUpModel.Instance.SetExpChange(playerLevel.Value, currentExp, lastExp, maxExp, differenceExp);
	}

	// Token: 0x0600D999 RID: 55705 RVA: 0x004082FC File Offset: 0x004064FC
	private void OnPlayerLevelChanged(int lastLevel, int currentLevel, int currentExp, int lastExp, int addExp, int currentMaxExp, int lastMaxExp)
	{
		KuroSdkReport.Instance.OnPlayerLevelChange(currentLevel);
		int? hiddenLevelUpLevel = LevelUpConfig.Instance.GetHiddenLevelUpLevel();
		if (hiddenLevelUpLevel != null && currentLevel < hiddenLevelUpLevel.Value)
		{
			return;
		}
		int differenceExp = FunctionConfig.Instance.GetDifferenceExp(lastLevel, lastExp, currentLevel, currentExp);
		LevelUpModel.Instance.SetLevelUp(lastLevel, currentLevel, currentExp, lastExp, addExp, currentMaxExp, lastMaxExp, differenceExp);
	}

	// Token: 0x0600D99A RID: 55706 RVA: 0x0040835C File Offset: 0x0040655C
	private void OnShowLevelOnly()
	{
		int? playerLevel = FunctionModel.Instance.GetPlayerLevel();
		int? hiddenLevelUpLevel = LevelUpConfig.Instance.GetHiddenLevelUpLevel();
		if (hiddenLevelUpLevel != null && playerLevel.GetValueOrDefault() < hiddenLevelUpLevel.Value)
		{
			return;
		}
		LevelUpModel.Instance.SetShowLevelOnly(playerLevel.Value);
	}

	// Token: 0x1700144A RID: 5194
	// (get) Token: 0x0600D99B RID: 55707 RVA: 0x004083AA File Offset: 0x004065AA
	public static LevelUpController Instance
	{
		get
		{
			return LevelUpController._Instance;
		}
	}

	// Token: 0x0600D99C RID: 55708 RVA: 0x004083B1 File Offset: 0x004065B1
	public static LevelUpController GetOrCreateInstance()
	{
		if (LevelUpController._Instance == null)
		{
			LevelUpController.CreateInstance();
		}
		return LevelUpController._Instance;
	}

	// Token: 0x0600D99D RID: 55709 RVA: 0x004083C5 File Offset: 0x004065C5
	public static bool CreateInstance()
	{
		if (LevelUpController._Instance != null)
		{
			return true;
		}
		LevelUpController._Instance = new LevelUpController();
		return true;
	}

	// Token: 0x0600D99E RID: 55710 RVA: 0x004083DB File Offset: 0x004065DB
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600D99F RID: 55711 RVA: 0x004083DD File Offset: 0x004065DD
	public static void ResetStaticDefaultValue()
	{
		LevelUpController._Instance = null;
	}

	// Token: 0x0600D9A0 RID: 55712 RVA: 0x004083E5 File Offset: 0x004065E5
	static LevelUpController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(LevelUpController.CreateStaticDefaultValue), new Action(LevelUpController.ResetStaticDefaultValue));
	}

	// Token: 0x04007989 RID: 31113
	[Nullable(2)]
	private static LevelUpController _Instance;
}
