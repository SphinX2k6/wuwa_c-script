using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest;

// Token: 0x02001D86 RID: 7558
[NullableContext(1)]
[Nullable(0)]
public class SilentAreaShowInfo
{
	// Token: 0x0600E558 RID: 58712 RVA: 0x003604B3 File Offset: 0x0035E6B3
	public SilentAreaShowInfo(int sourceOfAdd, IInformationViewType showInfo)
	{
	}

	// Token: 0x04006A17 RID: 27159
	public int SourceOfAdd = sourceOfAdd;

	// Token: 0x04006A18 RID: 27160
	public IInformationViewType ShowInfo = showInfo;
}
