using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200457E RID: 17790
	public class ISpecialProcessT
	{
		// Token: 0x17007C4E RID: 31822
		// (get) Token: 0x06019E93 RID: 106131 RVA: 0x003B1ED2 File Offset: 0x003B00D2
		// (set) Token: 0x06019E94 RID: 106132 RVA: 0x003B1EDA File Offset: 0x003B00DA
		public ESpecialProcess Type { get; set; }

		// Token: 0x06019E95 RID: 106133 RVA: 0x003B1EE3 File Offset: 0x003B00E3
		public ISpecialProcessT()
		{
			this.Type = ESpecialProcess.LowMemorySceneSwitch;
		}
	}
}
