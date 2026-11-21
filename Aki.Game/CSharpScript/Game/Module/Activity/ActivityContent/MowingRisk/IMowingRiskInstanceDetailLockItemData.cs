using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MowingRisk
{
	// Token: 0x02005345 RID: 21317
	[NullableContext(1)]
	public interface IMowingRiskInstanceDetailLockItemData
	{
		// Token: 0x17006739 RID: 26425
		// (get) Token: 0x060350D2 RID: 217298
		// (set) Token: 0x060350D3 RID: 217299
		bool IsUnlock { get; set; }

		// Token: 0x1700673A RID: 26426
		// (get) Token: 0x060350D4 RID: 217300
		// (set) Token: 0x060350D5 RID: 217301
		string LockDescriptionTextId { get; set; }

		// Token: 0x1700673B RID: 26427
		// (get) Token: 0x060350D6 RID: 217302
		// (set) Token: 0x060350D7 RID: 217303
		string[] LockDescriptionTextArgs { get; set; }
	}
}
