using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004E34 RID: 20020
	public class IBattleTagConditionT
	{
		// Token: 0x17008E99 RID: 36505
		// (get) Token: 0x0601EF5B RID: 126811 RVA: 0x0045305E File Offset: 0x0045125E
		// (set) Token: 0x0601EF5C RID: 126812 RVA: 0x00453066 File Offset: 0x00451266
		public EBattleConditionType Type { get; set; }

		// Token: 0x17008E9A RID: 36506
		// (get) Token: 0x0601EF5D RID: 126813 RVA: 0x0045306F File Offset: 0x0045126F
		// (set) Token: 0x0601EF5E RID: 126814 RVA: 0x00453077 File Offset: 0x00451277
		public int EntityId { get; set; }

		// Token: 0x17008E9B RID: 36507
		// (get) Token: 0x0601EF5F RID: 126815 RVA: 0x00453080 File Offset: 0x00451280
		// (set) Token: 0x0601EF60 RID: 126816 RVA: 0x00453088 File Offset: 0x00451288
		public int TagConfigId { get; set; }

		// Token: 0x0601EF61 RID: 126817 RVA: 0x00453091 File Offset: 0x00451291
		public IBattleTagConditionT()
		{
			this.Type = EBattleConditionType.BattleTag;
			this.EntityId = 0;
			this.TagConfigId = 0;
		}
	}
}
