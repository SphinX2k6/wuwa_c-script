using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MowingRisk
{
	// Token: 0x02005340 RID: 21312
	[NullableContext(1)]
	[Nullable(0)]
	public class MowingRiskInstanceDetailData : IMowingRiskInstanceDetailData
	{
		// Token: 0x1700672B RID: 26411
		// (get) Token: 0x060350B3 RID: 217267 RVA: 0x00ED27C1 File Offset: 0x00ED09C1
		// (set) Token: 0x060350B4 RID: 217268 RVA: 0x00ED27C9 File Offset: 0x00ED09C9
		public string TitleTextId { get; set; }

		// Token: 0x1700672C RID: 26412
		// (get) Token: 0x060350B5 RID: 217269 RVA: 0x00ED27D2 File Offset: 0x00ED09D2
		// (set) Token: 0x060350B6 RID: 217270 RVA: 0x00ED27DA File Offset: 0x00ED09DA
		public string ContentTextId { get; set; }

		// Token: 0x1700672D RID: 26413
		// (get) Token: 0x060350B7 RID: 217271 RVA: 0x00ED27E3 File Offset: 0x00ED09E3
		// (set) Token: 0x060350B8 RID: 217272 RVA: 0x00ED27EB File Offset: 0x00ED09EB
		public IMowingRiskInstanceDetailAttributeItemData[] AttributeList { get; set; }

		// Token: 0x1700672E RID: 26414
		// (get) Token: 0x060350B9 RID: 217273 RVA: 0x00ED27F4 File Offset: 0x00ED09F4
		// (set) Token: 0x060350BA RID: 217274 RVA: 0x00ED27FC File Offset: 0x00ED09FC
		public IMowingRiskInstanceDetailLockItemData LockData { get; set; }
	}
}
