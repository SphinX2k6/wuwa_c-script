using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MowingRisk
{
	// Token: 0x0200533F RID: 21311
	[NullableContext(1)]
	public interface IMowingRiskInstanceDetailData
	{
		// Token: 0x17006727 RID: 26407
		// (get) Token: 0x060350AB RID: 217259
		// (set) Token: 0x060350AC RID: 217260
		string TitleTextId { get; set; }

		// Token: 0x17006728 RID: 26408
		// (get) Token: 0x060350AD RID: 217261
		// (set) Token: 0x060350AE RID: 217262
		string ContentTextId { get; set; }

		// Token: 0x17006729 RID: 26409
		// (get) Token: 0x060350AF RID: 217263
		// (set) Token: 0x060350B0 RID: 217264
		IMowingRiskInstanceDetailAttributeItemData[] AttributeList { get; set; }

		// Token: 0x1700672A RID: 26410
		// (get) Token: 0x060350B1 RID: 217265
		// (set) Token: 0x060350B2 RID: 217266
		IMowingRiskInstanceDetailLockItemData LockData { get; set; }
	}
}
