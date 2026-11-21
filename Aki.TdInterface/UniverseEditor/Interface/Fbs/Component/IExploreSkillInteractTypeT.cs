using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005755 RID: 22357
	public class IExploreSkillInteractTypeT
	{
		// Token: 0x1700A19F RID: 41375
		// (get) Token: 0x06024088 RID: 147592 RVA: 0x004F4E62 File Offset: 0x004F3062
		// (set) Token: 0x06024089 RID: 147593 RVA: 0x004F4E6A File Offset: 0x004F306A
		public EExploreSkillInteractType Type { get; set; }

		// Token: 0x0602408A RID: 147594 RVA: 0x004F4E73 File Offset: 0x004F3073
		public IExploreSkillInteractTypeT()
		{
			this.Type = EExploreSkillInteractType.PullGiant;
		}
	}
}
