using System;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x0200219F RID: 8607
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class TutorialConfig : ConfigBase
{
	// Token: 0x060152E7 RID: 86759 RVA: 0x006293B8 File Offset: 0x006275B8
	public GuideTutorial? GetTutorial(int tutorialId)
	{
		return ConfigGuideTutorialById.GetConfig(tutorialId, true);
	}

	// Token: 0x060152E8 RID: 86760 RVA: 0x006293C4 File Offset: 0x006275C4
	public bool HasUnlockReward(int tutorialId)
	{
		GuideTutorial? tutorial = this.GetTutorial(tutorialId);
		return tutorial != null && !tutorial.GetValueOrDefault().DisableDropReward;
	}

	// Token: 0x1700200C RID: 8204
	// (get) Token: 0x060152E9 RID: 86761 RVA: 0x006293F6 File Offset: 0x006275F6
	public static TutorialConfig Instance
	{
		get
		{
			return TutorialConfig._Instance;
		}
	}

	// Token: 0x060152EA RID: 86762 RVA: 0x006293FD File Offset: 0x006275FD
	public static TutorialConfig GetOrCreateInstance()
	{
		if (TutorialConfig._Instance == null)
		{
			TutorialConfig.CreateInstance();
		}
		return TutorialConfig._Instance;
	}

	// Token: 0x060152EB RID: 86763 RVA: 0x00629411 File Offset: 0x00627611
	public static bool CreateInstance()
	{
		if (TutorialConfig._Instance != null)
		{
			return true;
		}
		TutorialConfig._Instance = new TutorialConfig();
		return true;
	}

	// Token: 0x060152EC RID: 86764 RVA: 0x00629427 File Offset: 0x00627627
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060152ED RID: 86765 RVA: 0x00629429 File Offset: 0x00627629
	public static void ResetStaticDefaultValue()
	{
		TutorialConfig._Instance = null;
	}

	// Token: 0x060152EE RID: 86766 RVA: 0x00629431 File Offset: 0x00627631
	static TutorialConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(TutorialConfig.CreateStaticDefaultValue), new Action(TutorialConfig.ResetStaticDefaultValue));
	}

	// Token: 0x0400B3A8 RID: 45992
	[Nullable(2)]
	private static TutorialConfig _Instance;
}
