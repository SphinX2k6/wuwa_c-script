using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200576D RID: 22381
	public class IExploreSkillRagDollDestroySolidRockT
	{
		// Token: 0x1700A1CC RID: 41420
		// (get) Token: 0x06024178 RID: 147832 RVA: 0x004F6B96 File Offset: 0x004F4D96
		// (set) Token: 0x06024179 RID: 147833 RVA: 0x004F6B9E File Offset: 0x004F4D9E
		public EExploreSkillInteractType Type { get; set; }

		// Token: 0x0602417A RID: 147834 RVA: 0x004F6BA7 File Offset: 0x004F4DA7
		public IExploreSkillRagDollDestroySolidRockT()
		{
			this.Type = EExploreSkillInteractType.PullGiant;
		}
	}
}
