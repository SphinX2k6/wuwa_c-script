using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005008 RID: 20488
	public class ICheckRoverRogueAbilitySelectConditionT
	{
		// Token: 0x17009291 RID: 37521
		// (get) Token: 0x0601FF99 RID: 130969 RVA: 0x00470106 File Offset: 0x0046E306
		// (set) Token: 0x0601FF9A RID: 130970 RVA: 0x0047010E File Offset: 0x0046E30E
		public ECondition Type { get; set; }

		// Token: 0x17009292 RID: 37522
		// (get) Token: 0x0601FF9B RID: 130971 RVA: 0x00470117 File Offset: 0x0046E317
		// (set) Token: 0x0601FF9C RID: 130972 RVA: 0x0047011F File Offset: 0x0046E31F
		public ERoverRogueAbilitySelectType SelectType { get; set; }

		// Token: 0x17009293 RID: 37523
		// (get) Token: 0x0601FF9D RID: 130973 RVA: 0x00470128 File Offset: 0x0046E328
		// (set) Token: 0x0601FF9E RID: 130974 RVA: 0x00470130 File Offset: 0x0046E330
		public bool IsReceived { get; set; }

		// Token: 0x0601FF9F RID: 130975 RVA: 0x00470139 File Offset: 0x0046E339
		public ICheckRoverRogueAbilitySelectConditionT()
		{
			this.Type = ECondition.CompareVar;
			this.SelectType = ERoverRogueAbilitySelectType.Shop;
			this.IsReceived = false;
		}
	}
}
