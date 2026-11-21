using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.RoleDev
{
	// Token: 0x02003C88 RID: 15496
	[NullableContext(1)]
	public interface IDisplayableItem
	{
		// Token: 0x17005135 RID: 20789
		// (get) Token: 0x06027A21 RID: 162337
		// (set) Token: 0x06027A22 RID: 162338
		string DisplayName { get; set; }

		// Token: 0x17005136 RID: 20790
		// (get) Token: 0x06027A23 RID: 162339
		// (set) Token: 0x06027A24 RID: 162340
		string DisplayIcon { get; set; }

		// Token: 0x17005137 RID: 20791
		// (get) Token: 0x06027A25 RID: 162341
		// (set) Token: 0x06027A26 RID: 162342
		int? DisplayCount { get; set; }

		// Token: 0x17005138 RID: 20792
		// (get) Token: 0x06027A27 RID: 162343
		// (set) Token: 0x06027A28 RID: 162344
		bool IsUnlocked { get; set; }

		// Token: 0x17005139 RID: 20793
		// (get) Token: 0x06027A29 RID: 162345
		// (set) Token: 0x06027A2A RID: 162346
		bool IsEquipped { get; set; }

		// Token: 0x1700513A RID: 20794
		// (get) Token: 0x06027A2B RID: 162347
		// (set) Token: 0x06027A2C RID: 162348
		int? QualityLevel { get; set; }

		// Token: 0x1700513B RID: 20795
		// (get) Token: 0x06027A2D RID: 162349
		// (set) Token: 0x06027A2E RID: 162350
		bool? IsFinished { get; set; }

		// Token: 0x1700513C RID: 20796
		// (get) Token: 0x06027A2F RID: 162351
		// (set) Token: 0x06027A30 RID: 162352
		EClickActionType ClickAction { get; set; }

		// Token: 0x1700513D RID: 20797
		// (get) Token: 0x06027A31 RID: 162353
		// (set) Token: 0x06027A32 RID: 162354
		int? ClickParam { get; set; }
	}
}
