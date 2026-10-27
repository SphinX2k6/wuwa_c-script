using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003D50 RID: 15696
	public class ICheckLevelPlayQuestConditionT
	{
		// Token: 0x17006BB9 RID: 27577
		// (get) Token: 0x06015B57 RID: 88919 RVA: 0x00321D24 File Offset: 0x0031FF24
		// (set) Token: 0x06015B58 RID: 88920 RVA: 0x00321D2C File Offset: 0x0031FF2C
		public EChildQuest Type { get; set; }

		// Token: 0x17006BBA RID: 27578
		// (get) Token: 0x06015B59 RID: 88921 RVA: 0x00321D35 File Offset: 0x0031FF35
		// (set) Token: 0x06015B5A RID: 88922 RVA: 0x00321D3D File Offset: 0x0031FF3D
		public IConditionGroupT PreConditions { get; set; }

		// Token: 0x17006BBB RID: 27579
		// (get) Token: 0x06015B5B RID: 88923 RVA: 0x00321D46 File Offset: 0x0031FF46
		// (set) Token: 0x06015B5C RID: 88924 RVA: 0x00321D4E File Offset: 0x0031FF4E
		public List<int> LevelPlayIds { get; set; }

		// Token: 0x17006BBC RID: 27580
		// (get) Token: 0x06015B5D RID: 88925 RVA: 0x00321D57 File Offset: 0x0031FF57
		// (set) Token: 0x06015B5E RID: 88926 RVA: 0x00321D5F File Offset: 0x0031FF5F
		public int CompleteNumber { get; set; }

		// Token: 0x06015B5F RID: 88927 RVA: 0x00321D68 File Offset: 0x0031FF68
		public ICheckLevelPlayQuestConditionT()
		{
			this.Type = EChildQuest.DoInteract;
			this.PreConditions = null;
			this.LevelPlayIds = null;
			this.CompleteNumber = 0;
		}
	}
}
