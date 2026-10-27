using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003E85 RID: 16005
	public class IGuideConditionT
	{
		// Token: 0x17006F07 RID: 28423
		// (get) Token: 0x06016908 RID: 92424 RVA: 0x00342AF1 File Offset: 0x00340CF1
		// (set) Token: 0x06016909 RID: 92425 RVA: 0x00342AF9 File Offset: 0x00340CF9
		public EChildQuest Type { get; set; }

		// Token: 0x17006F08 RID: 28424
		// (get) Token: 0x0601690A RID: 92426 RVA: 0x00342B02 File Offset: 0x00340D02
		// (set) Token: 0x0601690B RID: 92427 RVA: 0x00342B0A File Offset: 0x00340D0A
		public IConditionGroupT PreConditions { get; set; }

		// Token: 0x17006F09 RID: 28425
		// (get) Token: 0x0601690C RID: 92428 RVA: 0x00342B13 File Offset: 0x00340D13
		// (set) Token: 0x0601690D RID: 92429 RVA: 0x00342B1B File Offset: 0x00340D1B
		public int GuideGroupId { get; set; }

		// Token: 0x0601690E RID: 92430 RVA: 0x00342B24 File Offset: 0x00340D24
		public IGuideConditionT()
		{
			this.Type = EChildQuest.DoInteract;
			this.PreConditions = null;
			this.GuideGroupId = 0;
		}
	}
}
