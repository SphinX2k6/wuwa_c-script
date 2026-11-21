using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.BigStuffedDoll
{
	// Token: 0x020060CC RID: 24780
	[NullableContext(1)]
	[Nullable(0)]
	public class BrokenRockJsonConfig : IBrokenRockJsonConfig
	{
		// Token: 0x17007098 RID: 28824
		// (get) Token: 0x0603B6AA RID: 243370 RVA: 0x010CFEC7 File Offset: 0x010CE0C7
		// (set) Token: 0x0603B6AB RID: 243371 RVA: 0x010CFECF File Offset: 0x010CE0CF
		public BrokenRockConfig[] Config { get; set; }

		// Token: 0x17007099 RID: 28825
		// (get) Token: 0x0603B6AC RID: 243372 RVA: 0x010CFED8 File Offset: 0x010CE0D8
		// (set) Token: 0x0603B6AD RID: 243373 RVA: 0x010CFEE0 File Offset: 0x010CE0E0
		public BrokenRockRingConfig[] Rings { get; set; }
	}
}
