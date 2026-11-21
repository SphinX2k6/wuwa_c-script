using System;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004B35 RID: 19253
	public class IUnlockAllExploreSkillT
	{
		// Token: 0x1700870A RID: 34570
		// (get) Token: 0x0601D0BE RID: 118974 RVA: 0x00414F8A File Offset: 0x0041318A
		// (set) Token: 0x0601D0BF RID: 118975 RVA: 0x00414F92 File Offset: 0x00413192
		public EGmCommand Type { get; set; }

		// Token: 0x0601D0C0 RID: 118976 RVA: 0x00414F9B File Offset: 0x0041319B
		public IUnlockAllExploreSkillT()
		{
			this.Type = EGmCommand.SkipToLevelPlayNode;
		}
	}
}
