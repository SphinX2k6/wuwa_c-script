using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004269 RID: 17001
	public class IFinishArcadeGameplayT
	{
		// Token: 0x170073F6 RID: 29686
		// (get) Token: 0x06017B26 RID: 97062 RVA: 0x003615BD File Offset: 0x0035F7BD
		// (set) Token: 0x06017B27 RID: 97063 RVA: 0x003615C5 File Offset: 0x0035F7C5
		public EChildQuest Type { get; set; }

		// Token: 0x170073F7 RID: 29687
		// (get) Token: 0x06017B28 RID: 97064 RVA: 0x003615CE File Offset: 0x0035F7CE
		// (set) Token: 0x06017B29 RID: 97065 RVA: 0x003615D6 File Offset: 0x0035F7D6
		public IConditionGroupT PreConditions { get; set; }

		// Token: 0x170073F8 RID: 29688
		// (get) Token: 0x06017B2A RID: 97066 RVA: 0x003615DF File Offset: 0x0035F7DF
		// (set) Token: 0x06017B2B RID: 97067 RVA: 0x003615E7 File Offset: 0x0035F7E7
		public TArcadeGameplayUnion ArcadeGameplay { get; set; }

		// Token: 0x06017B2C RID: 97068 RVA: 0x003615F0 File Offset: 0x0035F7F0
		public IFinishArcadeGameplayT()
		{
			this.Type = EChildQuest.DoInteract;
			this.PreConditions = null;
			this.ArcadeGameplay = null;
		}
	}
}
