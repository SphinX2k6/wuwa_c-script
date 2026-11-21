using System;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x020017B6 RID: 6070
[NullableContext(2)]
[Nullable(0)]
public class NoticeConfig
{
	// Token: 0x0600ECA9 RID: 60585 RVA: 0x00457A24 File Offset: 0x00455C24
	public static string GetNoticeTitle()
	{
		return ConfigCommonParamLang.GetLocalText(ConfigCommonParamById.GetIntConfig("NoticeTitle").GetValueOrDefault(), null);
	}

	// Token: 0x0600ECAA RID: 60586 RVA: 0x00457A49 File Offset: 0x00455C49
	public static string GetNoticeUrl()
	{
		return ConfigCommonParamById.GetStringConfig("NoticeUrl");
	}
}
