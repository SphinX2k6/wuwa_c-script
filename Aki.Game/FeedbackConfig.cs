using System;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02001AD8 RID: 6872
[NullableContext(2)]
[Nullable(0)]
public class FeedbackConfig
{
	// Token: 0x0600CBED RID: 52205 RVA: 0x002E8BCC File Offset: 0x002E6DCC
	public static string GetFeedbackTitle()
	{
		return ConfigCommonParamLang.GetLocalText(ConfigCommonParamById.GetIntConfig("FeedbackTitle").GetValueOrDefault(), null);
	}

	// Token: 0x0600CBEE RID: 52206 RVA: 0x002E8BF1 File Offset: 0x002E6DF1
	public static string GetFeedbackPreUrl()
	{
		return ConfigCommonParamById.GetStringConfig("FeedbackUrl");
	}
}
