using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest;

// Token: 0x02001248 RID: 4680
[NullableContext(1)]
[Nullable(0)]
public class SilentAreaShowInfo
{
	// Token: 0x0600B976 RID: 47478 RVA: 0x0036C107 File Offset: 0x0036A307
	public SilentAreaShowInfo(int sourceOfAdd, IInformationViewType showInfo)
	{
	}

	// Token: 0x04006AF8 RID: 27384
	public int SourceOfAdd = sourceOfAdd;

	// Token: 0x04006AF9 RID: 27385
	public IInformationViewType ShowInfo = showInfo;
}
