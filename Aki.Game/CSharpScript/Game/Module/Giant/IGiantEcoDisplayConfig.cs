using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Giant
{
	// Token: 0x0200596A RID: 22890
	[NullableContext(1)]
	public interface IGiantEcoDisplayConfig
	{
		// Token: 0x17008B32 RID: 35634
		// (get) Token: 0x0603A12D RID: 237869
		// (set) Token: 0x0603A12E RID: 237870
		string OutlineColorHex { get; set; }

		// Token: 0x17008B33 RID: 35635
		// (get) Token: 0x0603A12F RID: 237871
		// (set) Token: 0x0603A130 RID: 237872
		string IconSpriteNormal { get; set; }

		// Token: 0x17008B34 RID: 35636
		// (get) Token: 0x0603A131 RID: 237873
		// (set) Token: 0x0603A132 RID: 237874
		string IconSpriteActive { get; set; }

		// Token: 0x17008B35 RID: 35637
		// (get) Token: 0x0603A133 RID: 237875
		// (set) Token: 0x0603A134 RID: 237876
		string MindsetNameKey { get; set; }

		// Token: 0x17008B36 RID: 35638
		// (get) Token: 0x0603A135 RID: 237877
		// (set) Token: 0x0603A136 RID: 237878
		string PortraitTexture { get; set; }
	}
}
