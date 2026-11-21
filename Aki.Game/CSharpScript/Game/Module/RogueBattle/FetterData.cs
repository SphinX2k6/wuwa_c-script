using System;

namespace CSharpScript.Game.Module.RogueBattle
{
	// Token: 0x02003E20 RID: 15904
	public struct FetterData : IFetterData
	{
		// Token: 0x17005289 RID: 21129
		// (get) Token: 0x06028936 RID: 166198 RVA: 0x00B62B06 File Offset: 0x00B60D06
		// (set) Token: 0x06028937 RID: 166199 RVA: 0x00B62B0E File Offset: 0x00B60D0E
		public int Id { readonly get; set; }

		// Token: 0x1700528A RID: 21130
		// (get) Token: 0x06028938 RID: 166200 RVA: 0x00B62B17 File Offset: 0x00B60D17
		// (set) Token: 0x06028939 RID: 166201 RVA: 0x00B62B1F File Offset: 0x00B60D1F
		public int Lv { readonly get; set; }

		// Token: 0x1700528B RID: 21131
		// (get) Token: 0x0602893A RID: 166202 RVA: 0x00B62B28 File Offset: 0x00B60D28
		// (set) Token: 0x0602893B RID: 166203 RVA: 0x00B62B30 File Offset: 0x00B60D30
		public int Star { readonly get; set; }

		// Token: 0x1700528C RID: 21132
		// (get) Token: 0x0602893C RID: 166204 RVA: 0x00B62B39 File Offset: 0x00B60D39
		// (set) Token: 0x0602893D RID: 166205 RVA: 0x00B62B41 File Offset: 0x00B60D41
		public bool IsLevelUp { readonly get; set; }
	}
}
