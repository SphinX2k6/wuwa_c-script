using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02004DAC RID: 19884
	[NullableContext(1)]
	[Nullable(0)]
	public class RoguelikePhantomAffixStateItemData : IRoguelikePhantomAffixStateItemData
	{
		// Token: 0x17007EA1 RID: 32417
		// (get) Token: 0x06033580 RID: 210304 RVA: 0x00BFCD16 File Offset: 0x00BFAF16
		// (set) Token: 0x06033581 RID: 210305 RVA: 0x00BFCD1E File Offset: 0x00BFAF1E
		public AffixEntry AffixEntry { get; set; }

		// Token: 0x17007EA2 RID: 32418
		// (get) Token: 0x06033582 RID: 210306 RVA: 0x00BFCD27 File Offset: 0x00BFAF27
		// (set) Token: 0x06033583 RID: 210307 RVA: 0x00BFCD2F File Offset: 0x00BFAF2F
		public bool IsUnlock { get; set; }
	}
}
