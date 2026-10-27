using System;
using System.Runtime.CompilerServices;

// Token: 0x020011C3 RID: 4547
public class CelebrationUtils
{
	// Token: 0x06007915 RID: 30997 RVA: 0x0019797A File Offset: 0x00195B7A
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
