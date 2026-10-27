using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest;

// Token: 0x02001D7B RID: 7547
[NullableContext(1)]
[Nullable(0)]
public class BtCustomUiConfig
{
	// Token: 0x0600E54C RID: 58700 RVA: 0x00360229 File Offset: 0x0035E429
	public BtCustomUiConfig(int sourceOfAdd, IQuestScheduleConfig customUiConfig)
	{
	}

	// Token: 0x040069D2 RID: 27090
	public readonly int SourceOfAdd = sourceOfAdd;

	// Token: 0x040069D3 RID: 27091
	public IQuestScheduleConfig CustomUiConfig = customUiConfig;
}
