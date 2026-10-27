using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006FB2 RID: 28594
	public class ISetAudioEnableT
	{
		// Token: 0x1700D455 RID: 54357
		// (get) Token: 0x0603289F RID: 207007 RVA: 0x006D2037 File Offset: 0x006D0237
		// (set) Token: 0x060328A0 RID: 207008 RVA: 0x006D203F File Offset: 0x006D023F
		public EAudioEnableType SetAudioEnableType { get; set; }

		// Token: 0x1700D456 RID: 54358
		// (get) Token: 0x060328A1 RID: 207009 RVA: 0x006D2048 File Offset: 0x006D0248
		// (set) Token: 0x060328A2 RID: 207010 RVA: 0x006D2050 File Offset: 0x006D0250
		public IRoleSceneVoiceT AudioType { get; set; }

		// Token: 0x060328A3 RID: 207011 RVA: 0x006D2059 File Offset: 0x006D0259
		public ISetAudioEnableT()
		{
			this.SetAudioEnableType = EAudioEnableType.Enable;
			this.AudioType = null;
		}
	}
}
