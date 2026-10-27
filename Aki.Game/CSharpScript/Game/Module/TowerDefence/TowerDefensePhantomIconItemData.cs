using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.TowerDefence
{
	// Token: 0x02004B32 RID: 19250
	[NullableContext(1)]
	[Nullable(0)]
	public class TowerDefensePhantomIconItemData : ITowerDefensePhantomIconItemData
	{
		// Token: 0x17007B74 RID: 31604
		// (get) Token: 0x06031DA4 RID: 204196 RVA: 0x00B9270C File Offset: 0x00B9090C
		// (set) Token: 0x06031DA5 RID: 204197 RVA: 0x00B92714 File Offset: 0x00B90914
		public int ConfigId { get; set; }

		// Token: 0x17007B75 RID: 31605
		// (get) Token: 0x06031DA6 RID: 204198 RVA: 0x00B9271D File Offset: 0x00B9091D
		// (set) Token: 0x06031DA7 RID: 204199 RVA: 0x00B92725 File Offset: 0x00B90925
		public string HexColorPath { get; set; }

		// Token: 0x17007B76 RID: 31606
		// (get) Token: 0x06031DA8 RID: 204200 RVA: 0x00B9272E File Offset: 0x00B9092E
		// (set) Token: 0x06031DA9 RID: 204201 RVA: 0x00B92736 File Offset: 0x00B90936
		public bool IsLocked { get; set; }

		// Token: 0x17007B77 RID: 31607
		// (get) Token: 0x06031DAA RID: 204202 RVA: 0x00B9273F File Offset: 0x00B9093F
		// (set) Token: 0x06031DAB RID: 204203 RVA: 0x00B92747 File Offset: 0x00B90947
		public bool IsChosen { get; set; }

		// Token: 0x17007B78 RID: 31608
		// (get) Token: 0x06031DAC RID: 204204 RVA: 0x00B92750 File Offset: 0x00B90950
		// (set) Token: 0x06031DAD RID: 204205 RVA: 0x00B92758 File Offset: 0x00B90958
		public bool IsOccupied { get; set; }
	}
}
