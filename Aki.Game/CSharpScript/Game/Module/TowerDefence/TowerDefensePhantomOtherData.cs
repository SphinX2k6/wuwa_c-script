using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.TowerDefence
{
	// Token: 0x02003ADC RID: 15068
	[NullableContext(1)]
	[Nullable(0)]
	public class TowerDefensePhantomOtherData : ITowerDefensePhantomOtherData
	{
		// Token: 0x17004F2A RID: 20266
		// (get) Token: 0x06026B47 RID: 158535 RVA: 0x00AD67CD File Offset: 0x00AD49CD
		// (set) Token: 0x06026B48 RID: 158536 RVA: 0x00AD67D5 File Offset: 0x00AD49D5
		public string NameTextId { get; set; }

		// Token: 0x17004F2B RID: 20267
		// (get) Token: 0x06026B49 RID: 158537 RVA: 0x00AD67DE File Offset: 0x00AD49DE
		// (set) Token: 0x06026B4A RID: 158538 RVA: 0x00AD67E6 File Offset: 0x00AD49E6
		public string TypeTextId { get; set; }

		// Token: 0x17004F2C RID: 20268
		// (get) Token: 0x06026B4B RID: 158539 RVA: 0x00AD67EF File Offset: 0x00AD49EF
		// (set) Token: 0x06026B4C RID: 158540 RVA: 0x00AD67F7 File Offset: 0x00AD49F7
		public string TypeIconPath { get; set; }

		// Token: 0x17004F2D RID: 20269
		// (get) Token: 0x06026B4D RID: 158541 RVA: 0x00AD6800 File Offset: 0x00AD4A00
		// (set) Token: 0x06026B4E RID: 158542 RVA: 0x00AD6808 File Offset: 0x00AD4A08
		public bool IsLocked { get; set; }
	}
}
