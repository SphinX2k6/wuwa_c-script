using System;

namespace CSharpScript.Game.Module.InstanceDungeon.Define
{
	// Token: 0x020058D1 RID: 22737
	public interface IInstanceDungeonExitConfirmBoxData
	{
		// Token: 0x17008AB9 RID: 35513
		// (get) Token: 0x06039C82 RID: 236674
		// (set) Token: 0x06039C83 RID: 236675
		EInstanceDungeonExitConfirmBoxParseRule ParseRuleType { get; set; }

		// Token: 0x17008ABA RID: 35514
		// (get) Token: 0x06039C84 RID: 236676
		// (set) Token: 0x06039C85 RID: 236677
		int? UnfinishedBoxId { get; set; }

		// Token: 0x17008ABB RID: 35515
		// (get) Token: 0x06039C86 RID: 236678
		// (set) Token: 0x06039C87 RID: 236679
		int? FinishBoxId { get; set; }

		// Token: 0x17008ABC RID: 35516
		// (get) Token: 0x06039C88 RID: 236680
		// (set) Token: 0x06039C89 RID: 236681
		int? UnfinishedTelBoxId { get; set; }

		// Token: 0x17008ABD RID: 35517
		// (get) Token: 0x06039C8A RID: 236682
		// (set) Token: 0x06039C8B RID: 236683
		int? FinishTelBoxId { get; set; }
	}
}
