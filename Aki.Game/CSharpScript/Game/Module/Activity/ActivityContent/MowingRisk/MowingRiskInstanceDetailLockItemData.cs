using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MowingRisk
{
	// Token: 0x020063C8 RID: 25544
	[NullableContext(1)]
	[Nullable(0)]
	public class MowingRiskInstanceDetailLockItemData : IMowingRiskInstanceDetailLockItemData
	{
		// Token: 0x170093DA RID: 37850
		// (get) Token: 0x06040417 RID: 263191 RVA: 0x00F8B8DA File Offset: 0x00F89ADA
		// (set) Token: 0x06040418 RID: 263192 RVA: 0x00F8B8E2 File Offset: 0x00F89AE2
		public bool IsUnlock { get; set; }

		// Token: 0x170093DB RID: 37851
		// (get) Token: 0x06040419 RID: 263193 RVA: 0x00F8B8EB File Offset: 0x00F89AEB
		// (set) Token: 0x0604041A RID: 263194 RVA: 0x00F8B8F3 File Offset: 0x00F89AF3
		public string LockDescriptionTextId { get; set; }

		// Token: 0x170093DC RID: 37852
		// (get) Token: 0x0604041B RID: 263195 RVA: 0x00F8B8FC File Offset: 0x00F89AFC
		// (set) Token: 0x0604041C RID: 263196 RVA: 0x00F8B904 File Offset: 0x00F89B04
		public string[] LockDescriptionTextArgs { get; set; }
	}
}
