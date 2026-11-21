using System;
using System.Runtime.CompilerServices;

// Token: 0x02000677 RID: 1655
public class CelebrationUtils
{
	// Token: 0x06004CAC RID: 19628 RVA: 0x001A062A File Offset: 0x0019E82A
	[NullableContext(1)]
	public static string GetActivityLogo()
	{
		if (LanguageSystem.Instance.PackageLanguage == "zh-Hans")
		{
			return "/Game/Aki/UI/UIResources/UiActivity/Image/WelfareB/T_ActivityWelfareBIcon.T_ActivityWelfareBIcon";
		}
		return "/Game/Aki/UI/UIResources/UiActivity/Image/WelfareB/T_ActivityWelfareBIconE.T_ActivityWelfareBIconE";
	}
}
