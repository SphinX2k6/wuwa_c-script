using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003E2E RID: 15918
	public class IFinishArcadeGameplayT
	{
		// Token: 0x17006E10 RID: 28176
		// (get) Token: 0x060164F9 RID: 91385 RVA: 0x003389C5 File Offset: 0x00336BC5
		// (set) Token: 0x060164FA RID: 91386 RVA: 0x003389CD File Offset: 0x00336BCD
		public EChildQuest Type { get; set; }

		// Token: 0x17006E11 RID: 28177
		// (get) Token: 0x060164FB RID: 91387 RVA: 0x003389D6 File Offset: 0x00336BD6
		// (set) Token: 0x060164FC RID: 91388 RVA: 0x003389DE File Offset: 0x00336BDE
		public IConditionGroupT PreConditions { get; set; }

		// Token: 0x17006E12 RID: 28178
		// (get) Token: 0x060164FD RID: 91389 RVA: 0x003389E7 File Offset: 0x00336BE7
		// (set) Token: 0x060164FE RID: 91390 RVA: 0x003389EF File Offset: 0x00336BEF
		public TArcadeGameplayUnion ArcadeGameplay { get; set; }

		// Token: 0x060164FF RID: 91391 RVA: 0x003389F8 File Offset: 0x00336BF8
		public IFinishArcadeGameplayT()
		{
			this.Type = EChildQuest.DoInteract;
			this.PreConditions = null;
			this.ArcadeGameplay = null;
		}
	}
}
