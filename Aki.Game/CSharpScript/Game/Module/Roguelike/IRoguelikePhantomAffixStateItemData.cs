using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02003D74 RID: 15732
	[NullableContext(1)]
	public interface IRoguelikePhantomAffixStateItemData
	{
		// Token: 0x1700524F RID: 21071
		// (get) Token: 0x060283E9 RID: 164841
		// (set) Token: 0x060283EA RID: 164842
		AffixEntry AffixEntry { get; set; }

		// Token: 0x17005250 RID: 21072
		// (get) Token: 0x060283EB RID: 164843
		// (set) Token: 0x060283EC RID: 164844
		bool IsUnlock { get; set; }
	}
}
