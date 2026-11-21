using System;

namespace CSharpScript.Game.Module.InstanceDungeon.Define
{
	// Token: 0x020048A9 RID: 18601
	public interface IInstanceDungeonExitConfirmBoxData
	{
		// Token: 0x17005E85 RID: 24197
		// (get) Token: 0x0602EBA5 RID: 191397
		// (set) Token: 0x0602EBA6 RID: 191398
		EInstanceDungeonExitConfirmBoxParseRule ParseRuleType { get; set; }

		// Token: 0x17005E86 RID: 24198
		// (get) Token: 0x0602EBA7 RID: 191399
		// (set) Token: 0x0602EBA8 RID: 191400
		int? UnfinishedBoxId { get; set; }

		// Token: 0x17005E87 RID: 24199
		// (get) Token: 0x0602EBA9 RID: 191401
		// (set) Token: 0x0602EBAA RID: 191402
		int? FinishBoxId { get; set; }

		// Token: 0x17005E88 RID: 24200
		// (get) Token: 0x0602EBAB RID: 191403
		// (set) Token: 0x0602EBAC RID: 191404
		int? UnfinishedTelBoxId { get; set; }

		// Token: 0x17005E89 RID: 24201
		// (get) Token: 0x0602EBAD RID: 191405
		// (set) Token: 0x0602EBAE RID: 191406
		int? FinishTelBoxId { get; set; }
	}
}
