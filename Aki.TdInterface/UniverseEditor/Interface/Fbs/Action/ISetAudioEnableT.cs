using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200777B RID: 30587
	public class ISetAudioEnableT
	{
		// Token: 0x1700E029 RID: 57385
		// (get) Token: 0x06035B05 RID: 219909 RVA: 0x00731C7B File Offset: 0x0072FE7B
		// (set) Token: 0x06035B06 RID: 219910 RVA: 0x00731C83 File Offset: 0x0072FE83
		public EAudioEnableType SetAudioEnableType { get; set; }

		// Token: 0x1700E02A RID: 57386
		// (get) Token: 0x06035B07 RID: 219911 RVA: 0x00731C8C File Offset: 0x0072FE8C
		// (set) Token: 0x06035B08 RID: 219912 RVA: 0x00731C94 File Offset: 0x0072FE94
		public IRoleSceneVoiceT AudioType { get; set; }

		// Token: 0x06035B09 RID: 219913 RVA: 0x00731C9D File Offset: 0x0072FE9D
		public ISetAudioEnableT()
		{
			this.SetAudioEnableType = EAudioEnableType.Enable;
			this.AudioType = null;
		}
	}
}
