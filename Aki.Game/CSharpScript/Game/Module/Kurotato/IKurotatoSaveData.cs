using System;

namespace CSharpScript.Game.Module.Kurotato
{
	// Token: 0x02005712 RID: 22290
	public interface IKurotatoSaveData
	{
		// Token: 0x17008850 RID: 34896
		// (get) Token: 0x06038A8F RID: 232079
		// (set) Token: 0x06038A90 RID: 232080
		long SaveTimestamp { get; set; }

		// Token: 0x17008851 RID: 34897
		// (get) Token: 0x06038A91 RID: 232081
		// (set) Token: 0x06038A92 RID: 232082
		int RoleLevel { get; set; }

		// Token: 0x17008852 RID: 34898
		// (get) Token: 0x06038A93 RID: 232083
		// (set) Token: 0x06038A94 RID: 232084
		int WaveNum { get; set; }
	}
}
