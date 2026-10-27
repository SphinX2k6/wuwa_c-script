using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.WheelTower
{
	// Token: 0x02005F2B RID: 24363
	[NullableContext(1)]
	public interface IWheelTowerBossAttrData
	{
		// Token: 0x17008F18 RID: 36632
		// (get) Token: 0x0603DE4F RID: 253519
		// (set) Token: 0x0603DE50 RID: 253520
		string AttrName { get; set; }

		// Token: 0x17008F19 RID: 36633
		// (get) Token: 0x0603DE51 RID: 253521
		// (set) Token: 0x0603DE52 RID: 253522
		int AttrLevel { get; set; }

		// Token: 0x17008F1A RID: 36634
		// (get) Token: 0x0603DE53 RID: 253523
		// (set) Token: 0x0603DE54 RID: 253524
		int ElementId { get; set; }

		// Token: 0x17008F1B RID: 36635
		// (get) Token: 0x0603DE55 RID: 253525
		// (set) Token: 0x0603DE56 RID: 253526
		List<int> TagIdList { get; set; }
	}
}
