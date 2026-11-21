using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.HonamiStory
{
	// Token: 0x02004922 RID: 18722
	[NullableContext(1)]
	[Nullable(0)]
	public class HonamiStoryAttrData : IHonamiStoryAttrData
	{
		// Token: 0x17005ED9 RID: 24281
		// (get) Token: 0x0602EF50 RID: 192336 RVA: 0x00D19895 File Offset: 0x00D17A95
		// (set) Token: 0x0602EF51 RID: 192337 RVA: 0x00D1989D File Offset: 0x00D17A9D
		public string Name { get; set; } = string.Empty;

		// Token: 0x17005EDA RID: 24282
		// (get) Token: 0x0602EF52 RID: 192338 RVA: 0x00D198A6 File Offset: 0x00D17AA6
		// (set) Token: 0x0602EF53 RID: 192339 RVA: 0x00D198AE File Offset: 0x00D17AAE
		public string IconPath { get; set; } = string.Empty;

		// Token: 0x17005EDB RID: 24283
		// (get) Token: 0x0602EF54 RID: 192340 RVA: 0x00D198B7 File Offset: 0x00D17AB7
		// (set) Token: 0x0602EF55 RID: 192341 RVA: 0x00D198BF File Offset: 0x00D17ABF
		public int OldValue { get; set; }

		// Token: 0x17005EDC RID: 24284
		// (get) Token: 0x0602EF56 RID: 192342 RVA: 0x00D198C8 File Offset: 0x00D17AC8
		// (set) Token: 0x0602EF57 RID: 192343 RVA: 0x00D198D0 File Offset: 0x00D17AD0
		public int NewValue { get; set; }

		// Token: 0x17005EDD RID: 24285
		// (get) Token: 0x0602EF58 RID: 192344 RVA: 0x00D198D9 File Offset: 0x00D17AD9
		// (set) Token: 0x0602EF59 RID: 192345 RVA: 0x00D198E1 File Offset: 0x00D17AE1
		public bool IsPercent { get; set; }
	}
}
