using System;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x020022D2 RID: 8914
[NullableContext(2)]
[Nullable(0)]
public class NoticeConfig
{
	// Token: 0x06011812 RID: 71698 RVA: 0x0044AD1C File Offset: 0x00448F1C
	public static string GetNoticeTitle()
	{
		return ConfigCommonParamLang.GetLocalText(ConfigCommonParamById.GetIntConfig("NoticeTitle").GetValueOrDefault(), null);
	}

	// Token: 0x06011813 RID: 71699 RVA: 0x0044AD41 File Offset: 0x00448F41
	public static string GetNoticeUrl()
	{
		return ConfigCommonParamById.GetStringConfig("NoticeUrl");
	}
}
