using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200413D RID: 16701
	public class ISpecialProcessT
	{
		// Token: 0x17007648 RID: 30280
		// (get) Token: 0x060187F0 RID: 100336 RVA: 0x00387ECA File Offset: 0x003860CA
		// (set) Token: 0x060187F1 RID: 100337 RVA: 0x00387ED2 File Offset: 0x003860D2
		public ESpecialProcess Type { get; set; }

		// Token: 0x060187F2 RID: 100338 RVA: 0x00387EDB File Offset: 0x003860DB
		public ISpecialProcessT()
		{
			this.Type = ESpecialProcess.LowMemorySceneSwitch;
		}
	}
}
