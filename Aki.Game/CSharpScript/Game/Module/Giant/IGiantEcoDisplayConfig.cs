using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Giant
{
	// Token: 0x02004943 RID: 18755
	[NullableContext(1)]
	public interface IGiantEcoDisplayConfig
	{
		// Token: 0x17005EFF RID: 24319
		// (get) Token: 0x0602F051 RID: 192593
		// (set) Token: 0x0602F052 RID: 192594
		string OutlineColorHex { get; set; }

		// Token: 0x17005F00 RID: 24320
		// (get) Token: 0x0602F053 RID: 192595
		// (set) Token: 0x0602F054 RID: 192596
		string IconSpriteNormal { get; set; }

		// Token: 0x17005F01 RID: 24321
		// (get) Token: 0x0602F055 RID: 192597
		// (set) Token: 0x0602F056 RID: 192598
		string IconSpriteActive { get; set; }

		// Token: 0x17005F02 RID: 24322
		// (get) Token: 0x0602F057 RID: 192599
		// (set) Token: 0x0602F058 RID: 192600
		string MindsetNameKey { get; set; }

		// Token: 0x17005F03 RID: 24323
		// (get) Token: 0x0602F059 RID: 192601
		// (set) Token: 0x0602F05A RID: 192602
		string PortraitTexture { get; set; }
	}
}
