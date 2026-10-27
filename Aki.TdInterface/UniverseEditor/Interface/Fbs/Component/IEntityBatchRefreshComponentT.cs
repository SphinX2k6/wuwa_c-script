using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200515A RID: 20826
	public class IEntityBatchRefreshComponentT
	{
		// Token: 0x170097EE RID: 38894
		// (get) Token: 0x06021A04 RID: 137732 RVA: 0x004AACA2 File Offset: 0x004A8EA2
		// (set) Token: 0x06021A05 RID: 137733 RVA: 0x004AACAA File Offset: 0x004A8EAA
		public bool Disabled { get; set; }

		// Token: 0x170097EF RID: 38895
		// (get) Token: 0x06021A06 RID: 137734 RVA: 0x004AACB3 File Offset: 0x004A8EB3
		// (set) Token: 0x06021A07 RID: 137735 RVA: 0x004AACBB File Offset: 0x004A8EBB
		public IConditionGroupT StartCondition { get; set; }

		// Token: 0x170097F0 RID: 38896
		// (get) Token: 0x06021A08 RID: 137736 RVA: 0x004AACC4 File Offset: 0x004A8EC4
		// (set) Token: 0x06021A09 RID: 137737 RVA: 0x004AACCC File Offset: 0x004A8ECC
		public IConditionGroupT EndCondition { get; set; }

		// Token: 0x170097F1 RID: 38897
		// (get) Token: 0x06021A0A RID: 137738 RVA: 0x004AACD5 File Offset: 0x004A8ED5
		// (set) Token: 0x06021A0B RID: 137739 RVA: 0x004AACDD File Offset: 0x004A8EDD
		public TEntityBatchRefreshUnion EntityBatchRefresh { get; set; }

		// Token: 0x170097F2 RID: 38898
		// (get) Token: 0x06021A0C RID: 137740 RVA: 0x004AACE6 File Offset: 0x004A8EE6
		// (set) Token: 0x06021A0D RID: 137741 RVA: 0x004AACEE File Offset: 0x004A8EEE
		public byte NullMask { get; set; }

		// Token: 0x06021A0E RID: 137742 RVA: 0x004AACF7 File Offset: 0x004A8EF7
		public IEntityBatchRefreshComponentT()
		{
			this.Disabled = false;
			this.StartCondition = null;
			this.EndCondition = null;
			this.EntityBatchRefresh = null;
			this.NullMask = 0;
		}
	}
}
