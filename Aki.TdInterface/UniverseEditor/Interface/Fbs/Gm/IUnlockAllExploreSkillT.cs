using System;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x020046CD RID: 18125
	public class IUnlockAllExploreSkillT
	{
		// Token: 0x170080C9 RID: 32969
		// (get) Token: 0x0601B8E9 RID: 112873 RVA: 0x003E8CEE File Offset: 0x003E6EEE
		// (set) Token: 0x0601B8EA RID: 112874 RVA: 0x003E8CF6 File Offset: 0x003E6EF6
		public EGmCommand Type { get; set; }

		// Token: 0x0601B8EB RID: 112875 RVA: 0x003E8CFF File Offset: 0x003E6EFF
		public IUnlockAllExploreSkillT()
		{
			this.Type = EGmCommand.SkipToLevelPlayNode;
		}
	}
}
