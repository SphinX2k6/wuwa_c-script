using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02004DE6 RID: 19942
	[NullableContext(1)]
	public interface IPhantomAttrItemData
	{
		// Token: 0x17007EBD RID: 32445
		// (get) Token: 0x06033777 RID: 210807
		// (set) Token: 0x06033778 RID: 210808
		AffixEntry AffixEntry { get; set; }

		// Token: 0x17007EBE RID: 32446
		// (get) Token: 0x06033779 RID: 210809
		// (set) Token: 0x0603377A RID: 210810
		RoguelikeInfo RoguelikeInfo { get; set; }
	}
}
