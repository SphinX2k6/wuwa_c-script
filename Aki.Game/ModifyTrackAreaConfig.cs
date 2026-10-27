using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest;

// Token: 0x02001D87 RID: 7559
[NullableContext(1)]
[Nullable(0)]
public class ModifyTrackAreaConfig
{
	// Token: 0x0600E559 RID: 58713 RVA: 0x003604C9 File Offset: 0x0035E6C9
	public ModifyTrackAreaConfig(int sourceOfAdd, ITrackAreaText trackConfig)
	{
	}

	// Token: 0x17001253 RID: 4691
	// (get) Token: 0x0600E55A RID: 58714 RVA: 0x003604DF File Offset: 0x0035E6DF
	public string ModifyTrackAreaText
	{
		get
		{
			return PublicUtil.Instance.GetConfigTextByKey(this.TrackConfig.Tid);
		}
	}

	// Token: 0x04006A19 RID: 27161
	public int SourceOfAdd = sourceOfAdd;

	// Token: 0x04006A1A RID: 27162
	public ITrackAreaText TrackConfig = trackConfig;
}
