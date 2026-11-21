using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02003DB0 RID: 15792
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomAttrItemData : IPhantomAttrItemData
	{
		// Token: 0x1700526F RID: 21103
		// (get) Token: 0x060285E6 RID: 165350 RVA: 0x00B4FAAF File Offset: 0x00B4DCAF
		// (set) Token: 0x060285E7 RID: 165351 RVA: 0x00B4FAB7 File Offset: 0x00B4DCB7
		public AffixEntry AffixEntry { get; set; }

		// Token: 0x17005270 RID: 21104
		// (get) Token: 0x060285E8 RID: 165352 RVA: 0x00B4FAC0 File Offset: 0x00B4DCC0
		// (set) Token: 0x060285E9 RID: 165353 RVA: 0x00B4FAC8 File Offset: 0x00B4DCC8
		public RoguelikeInfo RoguelikeInfo { get; set; }
	}
}
