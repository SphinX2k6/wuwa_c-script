using System;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02000F97 RID: 3991
[NullableContext(2)]
[Nullable(0)]
public class FeedbackConfig
{
	// Token: 0x06009FFE RID: 40958 RVA: 0x002F3D60 File Offset: 0x002F1F60
	public static string GetFeedbackTitle()
	{
		return ConfigCommonParamLang.GetLocalText(ConfigCommonParamById.GetIntConfig("FeedbackTitle").GetValueOrDefault(), null);
	}

	// Token: 0x06009FFF RID: 40959 RVA: 0x002F3D85 File Offset: 0x002F1F85
	public static string GetFeedbackPreUrl()
	{
		return ConfigCommonParamById.GetStringConfig("FeedbackUrl");
	}
}
