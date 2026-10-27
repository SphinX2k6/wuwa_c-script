using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003D47 RID: 15687
	public class ICheckClientConditionGroupQuestConditionT
	{
		// Token: 0x17006BA3 RID: 27555
		// (get) Token: 0x06015AF9 RID: 88825 RVA: 0x00321014 File Offset: 0x0031F214
		// (set) Token: 0x06015AFA RID: 88826 RVA: 0x0032101C File Offset: 0x0031F21C
		public EChildQuest Type { get; set; }

		// Token: 0x17006BA4 RID: 27556
		// (get) Token: 0x06015AFB RID: 88827 RVA: 0x00321025 File Offset: 0x0031F225
		// (set) Token: 0x06015AFC RID: 88828 RVA: 0x0032102D File Offset: 0x0031F22D
		public IConditionGroupT PreConditions { get; set; }

		// Token: 0x17006BA5 RID: 27557
		// (get) Token: 0x06015AFD RID: 88829 RVA: 0x00321036 File Offset: 0x0031F236
		// (set) Token: 0x06015AFE RID: 88830 RVA: 0x0032103E File Offset: 0x0031F23E
		public IConditionGroupT Condition { get; set; }

		// Token: 0x06015AFF RID: 88831 RVA: 0x00321047 File Offset: 0x0031F247
		public ICheckClientConditionGroupQuestConditionT()
		{
			this.Type = EChildQuest.DoInteract;
			this.PreConditions = null;
			this.Condition = null;
		}
	}
}
