using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.TowerDefence
{
	// Token: 0x02003ADA RID: 15066
	[NullableContext(1)]
	[Nullable(0)]
	public class TowerDefensePhantomIconItemData : ITowerDefensePhantomIconItemData
	{
		// Token: 0x17004F21 RID: 20257
		// (get) Token: 0x06026B34 RID: 158516 RVA: 0x00AD6770 File Offset: 0x00AD4970
		// (set) Token: 0x06026B35 RID: 158517 RVA: 0x00AD6778 File Offset: 0x00AD4978
		public int ConfigId { get; set; }

		// Token: 0x17004F22 RID: 20258
		// (get) Token: 0x06026B36 RID: 158518 RVA: 0x00AD6781 File Offset: 0x00AD4981
		// (set) Token: 0x06026B37 RID: 158519 RVA: 0x00AD6789 File Offset: 0x00AD4989
		public string HexColorPath { get; set; }

		// Token: 0x17004F23 RID: 20259
		// (get) Token: 0x06026B38 RID: 158520 RVA: 0x00AD6792 File Offset: 0x00AD4992
		// (set) Token: 0x06026B39 RID: 158521 RVA: 0x00AD679A File Offset: 0x00AD499A
		public bool IsLocked { get; set; }

		// Token: 0x17004F24 RID: 20260
		// (get) Token: 0x06026B3A RID: 158522 RVA: 0x00AD67A3 File Offset: 0x00AD49A3
		// (set) Token: 0x06026B3B RID: 158523 RVA: 0x00AD67AB File Offset: 0x00AD49AB
		public bool IsChosen { get; set; }

		// Token: 0x17004F25 RID: 20261
		// (get) Token: 0x06026B3C RID: 158524 RVA: 0x00AD67B4 File Offset: 0x00AD49B4
		// (set) Token: 0x06026B3D RID: 158525 RVA: 0x00AD67BC File Offset: 0x00AD49BC
		public bool IsOccupied { get; set; }
	}
}
