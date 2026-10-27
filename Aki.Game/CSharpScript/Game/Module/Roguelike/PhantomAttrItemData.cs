using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02004DE7 RID: 19943
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomAttrItemData : IPhantomAttrItemData
	{
		// Token: 0x17007EBF RID: 32447
		// (get) Token: 0x0603377B RID: 210811 RVA: 0x00C0659F File Offset: 0x00C0479F
		// (set) Token: 0x0603377C RID: 210812 RVA: 0x00C065A7 File Offset: 0x00C047A7
		public AffixEntry AffixEntry { get; set; }

		// Token: 0x17007EC0 RID: 32448
		// (get) Token: 0x0603377D RID: 210813 RVA: 0x00C065B0 File Offset: 0x00C047B0
		// (set) Token: 0x0603377E RID: 210814 RVA: 0x00C065B8 File Offset: 0x00C047B8
		public RoguelikeInfo RoguelikeInfo { get; set; }
	}
}
