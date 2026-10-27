using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;

// Token: 0x02002066 RID: 8294
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class LevelUpController : UiControllerBase
{
	// Token: 0x0601052E RID: 66862 RVA: 0x003FBD7C File Offset: 0x003F9F7C
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add<int, int, int, int, int, int, int>(EEventName.OnPlayerLevelChanged, new Action<int, int, int, int, int, int, int>(this.OnPlayerLevelChanged));
		EventSystem.Instance.Add<int, int, int>(EEventName.OnPlayerExpChanged, new Action<int, int, int>(this.OnPlayerExpChanged));
		EventSystem.Instance.Add(EEventName.OnFinishLoadingState, new Action(this.OnShowLevelOnly));
	}

	// Token: 0x0601052F RID: 66863 RVA: 0x003FBDE0 File Offset: 0x003F9FE0
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.OnPlayerLevelChanged, new Action<int, int, int, int, int, int, int>(this.OnPlayerLevelChanged));
		EventSystem.Instance.Remove(EEventName.OnPlayerExpChanged, new Action<int, int, int>(this.OnPlayerExpChanged));
		EventSystem.Instance.Remove(EEventName.OnFinishLoadingState, new Action(this.OnShowLevelOnly));
	}

	// Token: 0x06010530 RID: 66864 RVA: 0x003FBE44 File Offset: 0x003FA044
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

	// Token: 0x06010531 RID: 66865 RVA: 0x003FBEB4 File Offset: 0x003FA0B4
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

	// Token: 0x06010532 RID: 66866 RVA: 0x003FBF14 File Offset: 0x003FA114
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

	// Token: 0x1700141D RID: 5149
	// (get) Token: 0x06010533 RID: 66867 RVA: 0x003FBF62 File Offset: 0x003FA162
	public static LevelUpController Instance
	{
		get
		{
			return LevelUpController._Instance;
		}
	}

	// Token: 0x06010534 RID: 66868 RVA: 0x003FBF69 File Offset: 0x003FA169
	public static LevelUpController GetOrCreateInstance()
	{
		if (LevelUpController._Instance == null)
		{
			LevelUpController.CreateInstance();
		}
		return LevelUpController._Instance;
	}

	// Token: 0x06010535 RID: 66869 RVA: 0x003FBF7D File Offset: 0x003FA17D
	public static bool CreateInstance()
	{
		if (LevelUpController._Instance != null)
		{
			return true;
		}
		LevelUpController._Instance = new LevelUpController();
		return true;
	}

	// Token: 0x06010536 RID: 66870 RVA: 0x003FBF93 File Offset: 0x003FA193
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06010537 RID: 66871 RVA: 0x003FBF95 File Offset: 0x003FA195
	public static void ResetStaticDefaultValue()
	{
		LevelUpController._Instance = null;
	}

	// Token: 0x06010538 RID: 66872 RVA: 0x003FBF9D File Offset: 0x003FA19D
	static LevelUpController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(LevelUpController.CreateStaticDefaultValue), new Action(LevelUpController.ResetStaticDefaultValue));
	}

	// Token: 0x040078A0 RID: 30880
	[Nullable(2)]
	private static LevelUpController _Instance;
}
