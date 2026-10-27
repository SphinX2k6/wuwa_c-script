using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006EF8 RID: 28408
	public class IRoleSceneVoiceT
	{
		// Token: 0x1700D34F RID: 54095
		// (get) Token: 0x0603232D RID: 205613 RVA: 0x006C87EC File Offset: 0x006C69EC
		// (set) Token: 0x0603232E RID: 205614 RVA: 0x006C87F4 File Offset: 0x006C69F4
		public EAudioType Type { get; set; }

		// Token: 0x1700D350 RID: 54096
		// (get) Token: 0x0603232F RID: 205615 RVA: 0x006C87FD File Offset: 0x006C69FD
		// (set) Token: 0x06032330 RID: 205616 RVA: 0x006C8805 File Offset: 0x006C6A05
		public int VoiceGroupData { get; set; }

		// Token: 0x06032331 RID: 205617 RVA: 0x006C880E File Offset: 0x006C6A0E
		public IRoleSceneVoiceT()
		{
			this.Type = EAudioType.RoleSceneVoice;
			this.VoiceGroupData = 0;
		}
	}
}
