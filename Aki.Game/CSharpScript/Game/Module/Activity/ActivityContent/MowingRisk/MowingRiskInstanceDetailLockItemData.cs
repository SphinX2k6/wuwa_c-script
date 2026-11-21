using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MowingRisk
{
	// Token: 0x02005346 RID: 21318
	[NullableContext(1)]
	[Nullable(0)]
	public class MowingRiskInstanceDetailLockItemData : IMowingRiskInstanceDetailLockItemData
	{
		// Token: 0x1700673C RID: 26428
		// (get) Token: 0x060350D8 RID: 217304 RVA: 0x00ED2872 File Offset: 0x00ED0A72
		// (set) Token: 0x060350D9 RID: 217305 RVA: 0x00ED287A File Offset: 0x00ED0A7A
		public bool IsUnlock { get; set; }

		// Token: 0x1700673D RID: 26429
		// (get) Token: 0x060350DA RID: 217306 RVA: 0x00ED2883 File Offset: 0x00ED0A83
		// (set) Token: 0x060350DB RID: 217307 RVA: 0x00ED288B File Offset: 0x00ED0A8B
		public string LockDescriptionTextId { get; set; }

		// Token: 0x1700673E RID: 26430
		// (get) Token: 0x060350DC RID: 217308 RVA: 0x00ED2894 File Offset: 0x00ED0A94
		// (set) Token: 0x060350DD RID: 217309 RVA: 0x00ED289C File Offset: 0x00ED0A9C
		public string[] LockDescriptionTextArgs { get; set; }
	}
}
