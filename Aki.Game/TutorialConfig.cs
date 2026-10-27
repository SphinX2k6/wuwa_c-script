using System;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02002C24 RID: 11300
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class TutorialConfig : ConfigBase
{
	// Token: 0x060178B5 RID: 96437 RVA: 0x005FC994 File Offset: 0x005FAB94
	public GuideTutorial? GetTutorial(int tutorialId)
	{
		return ConfigGuideTutorialById.GetConfig(tutorialId, true);
	}

	// Token: 0x060178B6 RID: 96438 RVA: 0x005FC9A0 File Offset: 0x005FABA0
	public bool HasUnlockReward(int tutorialId)
	{
		GuideTutorial? tutorial = this.GetTutorial(tutorialId);
		return tutorial != null && !tutorial.GetValueOrDefault().DisableDropReward;
	}

	// Token: 0x17001FB4 RID: 8116
	// (get) Token: 0x060178B7 RID: 96439 RVA: 0x005FC9D2 File Offset: 0x005FABD2
	public static TutorialConfig Instance
	{
		get
		{
			return TutorialConfig._Instance;
		}
	}

	// Token: 0x060178B8 RID: 96440 RVA: 0x005FC9D9 File Offset: 0x005FABD9
	public static TutorialConfig GetOrCreateInstance()
	{
		if (TutorialConfig._Instance == null)
		{
			TutorialConfig.CreateInstance();
		}
		return TutorialConfig._Instance;
	}

	// Token: 0x060178B9 RID: 96441 RVA: 0x005FC9ED File Offset: 0x005FABED
	public static bool CreateInstance()
	{
		if (TutorialConfig._Instance != null)
		{
			return true;
		}
		TutorialConfig._Instance = new TutorialConfig();
		return true;
	}

	// Token: 0x060178BA RID: 96442 RVA: 0x005FCA03 File Offset: 0x005FAC03
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060178BB RID: 96443 RVA: 0x005FCA05 File Offset: 0x005FAC05
	public static void ResetStaticDefaultValue()
	{
		TutorialConfig._Instance = null;
	}

	// Token: 0x060178BC RID: 96444 RVA: 0x005FCA0D File Offset: 0x005FAC0D
	static TutorialConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(TutorialConfig.CreateStaticDefaultValue), new Action(TutorialConfig.ResetStaticDefaultValue));
	}

	// Token: 0x0400AFA3 RID: 44963
	[Nullable(2)]
	private static TutorialConfig _Instance;
}
