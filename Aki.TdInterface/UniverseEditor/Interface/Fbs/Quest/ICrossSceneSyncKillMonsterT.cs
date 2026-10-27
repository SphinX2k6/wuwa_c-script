using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003DBF RID: 15807
	public class ICrossSceneSyncKillMonsterT
	{
		// Token: 0x17006D1F RID: 27935
		// (get) Token: 0x060160E7 RID: 90343 RVA: 0x0033096B File Offset: 0x0032EB6B
		// (set) Token: 0x060160E8 RID: 90344 RVA: 0x00330973 File Offset: 0x0032EB73
		public EChildQuest Type { get; set; }

		// Token: 0x17006D20 RID: 27936
		// (get) Token: 0x060160E9 RID: 90345 RVA: 0x0033097C File Offset: 0x0032EB7C
		// (set) Token: 0x060160EA RID: 90346 RVA: 0x00330984 File Offset: 0x0032EB84
		public IConditionGroupT PreConditions { get; set; }

		// Token: 0x17006D21 RID: 27937
		// (get) Token: 0x060160EB RID: 90347 RVA: 0x0033098D File Offset: 0x0032EB8D
		// (set) Token: 0x060160EC RID: 90348 RVA: 0x00330995 File Offset: 0x0032EB95
		public int EntityBundleId { get; set; }

		// Token: 0x17006D22 RID: 27938
		// (get) Token: 0x060160ED RID: 90349 RVA: 0x0033099E File Offset: 0x0032EB9E
		// (set) Token: 0x060160EE RID: 90350 RVA: 0x003309A6 File Offset: 0x0032EBA6
		public int PosEntityId { get; set; }

		// Token: 0x060160EF RID: 90351 RVA: 0x003309AF File Offset: 0x0032EBAF
		public ICrossSceneSyncKillMonsterT()
		{
			this.Type = EChildQuest.DoInteract;
			this.PreConditions = null;
			this.EntityBundleId = 0;
			this.PosEntityId = 0;
		}
	}
}
