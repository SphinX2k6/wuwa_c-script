using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200595A RID: 22874
	public class ISpawnMonsterPreConditonTypeT
	{
		// Token: 0x1700ABB7 RID: 43959
		// (get) Token: 0x06026B89 RID: 158601 RVA: 0x00554FBA File Offset: 0x005531BA
		// (set) Token: 0x06026B8A RID: 158602 RVA: 0x00554FC2 File Offset: 0x005531C2
		public ESpawnMonsterPreCondition Type { get; set; }

		// Token: 0x06026B8B RID: 158603 RVA: 0x00554FCB File Offset: 0x005531CB
		public ISpawnMonsterPreConditonTypeT()
		{
			this.Type = ESpawnMonsterPreCondition.DependOnPreceding;
		}
	}
}
