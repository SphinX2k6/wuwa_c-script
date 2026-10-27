using System;

namespace CSharpScript.Game.Module.RoleDev
{
	// Token: 0x02004CC1 RID: 19649
	public class MaterialItemData : IMaterialItemData
	{
		// Token: 0x17007D33 RID: 32051
		// (get) Token: 0x06032BAC RID: 207788 RVA: 0x00BD51B3 File Offset: 0x00BD33B3
		// (set) Token: 0x06032BAD RID: 207789 RVA: 0x00BD51BB File Offset: 0x00BD33BB
		public int ItemId { get; set; }

		// Token: 0x17007D34 RID: 32052
		// (get) Token: 0x06032BAE RID: 207790 RVA: 0x00BD51C4 File Offset: 0x00BD33C4
		// (set) Token: 0x06032BAF RID: 207791 RVA: 0x00BD51CC File Offset: 0x00BD33CC
		public int RequiredCount { get; set; }
	}
}
