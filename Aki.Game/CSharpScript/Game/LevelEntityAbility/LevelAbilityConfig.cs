using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelEntityAbility
{
	// Token: 0x02006136 RID: 24886
	[NullableContext(2)]
	[Nullable(0)]
	public class LevelAbilityConfig : ILevelAbilityConfig
	{
		// Token: 0x170070B7 RID: 28855
		// (get) Token: 0x0603B9AB RID: 244139 RVA: 0x010E7CC4 File Offset: 0x010E5EC4
		// (set) Token: 0x0603B9AC RID: 244140 RVA: 0x010E7CCC File Offset: 0x010E5ECC
		public EAbilityTickPhase? TickPhase { get; set; }

		// Token: 0x170070B8 RID: 28856
		// (get) Token: 0x0603B9AD RID: 244141 RVA: 0x010E7CD5 File Offset: 0x010E5ED5
		// (set) Token: 0x0603B9AE RID: 244142 RVA: 0x010E7CDD File Offset: 0x010E5EDD
		public int? TickOrder { get; set; }

		// Token: 0x170070B9 RID: 28857
		// (get) Token: 0x0603B9AF RID: 244143 RVA: 0x010E7CE6 File Offset: 0x010E5EE6
		// (set) Token: 0x0603B9B0 RID: 244144 RVA: 0x010E7CEE File Offset: 0x010E5EEE
		public bool? NeedTickActivate { get; set; }

		// Token: 0x170070BA RID: 28858
		// (get) Token: 0x0603B9B1 RID: 244145 RVA: 0x010E7CF7 File Offset: 0x010E5EF7
		// (set) Token: 0x0603B9B2 RID: 244146 RVA: 0x010E7CFF File Offset: 0x010E5EFF
		public List<EEventName> Events { get; set; }

		// Token: 0x170070BB RID: 28859
		// (get) Token: 0x0603B9B3 RID: 244147 RVA: 0x010E7D08 File Offset: 0x010E5F08
		// (set) Token: 0x0603B9B4 RID: 244148 RVA: 0x010E7D10 File Offset: 0x010E5F10
		public List<int> BlockedTags { get; set; }
	}
}
