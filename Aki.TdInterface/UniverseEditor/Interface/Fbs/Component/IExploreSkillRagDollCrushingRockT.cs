using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200576A RID: 22378
	public class IExploreSkillRagDollCrushingRockT
	{
		// Token: 0x1700A1C9 RID: 41417
		// (get) Token: 0x06024166 RID: 147814 RVA: 0x004F6A1E File Offset: 0x004F4C1E
		// (set) Token: 0x06024167 RID: 147815 RVA: 0x004F6A26 File Offset: 0x004F4C26
		public EExploreSkillInteractType Type { get; set; }

		// Token: 0x06024168 RID: 147816 RVA: 0x004F6A2F File Offset: 0x004F4C2F
		public IExploreSkillRagDollCrushingRockT()
		{
			this.Type = EExploreSkillInteractType.PullGiant;
		}
	}
}
