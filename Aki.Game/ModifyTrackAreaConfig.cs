using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest;

// Token: 0x02001249 RID: 4681
[NullableContext(1)]
[Nullable(0)]
public class ModifyTrackAreaConfig
{
	// Token: 0x0600B977 RID: 47479 RVA: 0x0036C11D File Offset: 0x0036A31D
	public ModifyTrackAreaConfig(int sourceOfAdd, ITrackAreaText trackConfig)
	{
	}

	// Token: 0x1700127D RID: 4733
	// (get) Token: 0x0600B978 RID: 47480 RVA: 0x0036C133 File Offset: 0x0036A333
	public string ModifyTrackAreaText
	{
		get
		{
			return PublicUtil.Instance.GetConfigTextByKey(this.TrackConfig.Tid);
		}
	}

	// Token: 0x04006AFA RID: 27386
	public int SourceOfAdd = sourceOfAdd;

	// Token: 0x04006AFB RID: 27387
	public ITrackAreaText TrackConfig = trackConfig;
}
