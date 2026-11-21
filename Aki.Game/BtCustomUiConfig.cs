using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest;

// Token: 0x0200123D RID: 4669
[NullableContext(1)]
[Nullable(0)]
public class BtCustomUiConfig
{
	// Token: 0x0600B96A RID: 47466 RVA: 0x0036BE7D File Offset: 0x0036A07D
	public BtCustomUiConfig(int sourceOfAdd, IQuestScheduleConfig customUiConfig)
	{
	}

	// Token: 0x04006AB2 RID: 27314
	public readonly int SourceOfAdd = sourceOfAdd;

	// Token: 0x04006AB3 RID: 27315
	public IQuestScheduleConfig CustomUiConfig = customUiConfig;
}
