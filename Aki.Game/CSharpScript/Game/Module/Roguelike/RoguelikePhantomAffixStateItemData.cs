using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02003D75 RID: 15733
	[NullableContext(1)]
	[Nullable(0)]
	public class RoguelikePhantomAffixStateItemData : IRoguelikePhantomAffixStateItemData
	{
		// Token: 0x17005251 RID: 21073
		// (get) Token: 0x060283ED RID: 164845 RVA: 0x00B46248 File Offset: 0x00B44448
		// (set) Token: 0x060283EE RID: 164846 RVA: 0x00B46250 File Offset: 0x00B44450
		public AffixEntry AffixEntry { get; set; }

		// Token: 0x17005252 RID: 21074
		// (get) Token: 0x060283EF RID: 164847 RVA: 0x00B46259 File Offset: 0x00B44459
		// (set) Token: 0x060283F0 RID: 164848 RVA: 0x00B46261 File Offset: 0x00B44461
		public bool IsUnlock { get; set; }
	}
}
