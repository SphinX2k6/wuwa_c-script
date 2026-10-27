using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004B21 RID: 19233
	public class ICheckRoverRogueAbilitySelectConditionT
	{
		// Token: 0x17008B81 RID: 35713
		// (get) Token: 0x0601E40E RID: 123918 RVA: 0x0043D95A File Offset: 0x0043BB5A
		// (set) Token: 0x0601E40F RID: 123919 RVA: 0x0043D962 File Offset: 0x0043BB62
		public ECondition Type { get; set; }

		// Token: 0x17008B82 RID: 35714
		// (get) Token: 0x0601E410 RID: 123920 RVA: 0x0043D96B File Offset: 0x0043BB6B
		// (set) Token: 0x0601E411 RID: 123921 RVA: 0x0043D973 File Offset: 0x0043BB73
		public ERoverRogueAbilitySelectType SelectType { get; set; }

		// Token: 0x17008B83 RID: 35715
		// (get) Token: 0x0601E412 RID: 123922 RVA: 0x0043D97C File Offset: 0x0043BB7C
		// (set) Token: 0x0601E413 RID: 123923 RVA: 0x0043D984 File Offset: 0x0043BB84
		public bool IsReceived { get; set; }

		// Token: 0x0601E414 RID: 123924 RVA: 0x0043D98D File Offset: 0x0043BB8D
		public ICheckRoverRogueAbilitySelectConditionT()
		{
			this.Type = ECondition.CompareVar;
			this.SelectType = ERoverRogueAbilitySelectType.Shop;
			this.IsReceived = false;
		}
	}
}
