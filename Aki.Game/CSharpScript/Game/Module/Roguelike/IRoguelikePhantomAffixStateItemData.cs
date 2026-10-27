using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02004DAB RID: 19883
	[NullableContext(1)]
	public interface IRoguelikePhantomAffixStateItemData
	{
		// Token: 0x17007E9F RID: 32415
		// (get) Token: 0x0603357C RID: 210300
		// (set) Token: 0x0603357D RID: 210301
		AffixEntry AffixEntry { get; set; }

		// Token: 0x17007EA0 RID: 32416
		// (get) Token: 0x0603357E RID: 210302
		// (set) Token: 0x0603357F RID: 210303
		bool IsUnlock { get; set; }
	}
}
