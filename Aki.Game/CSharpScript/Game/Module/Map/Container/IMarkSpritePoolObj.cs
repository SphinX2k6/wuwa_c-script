using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Map.Container
{
	// Token: 0x02005592 RID: 21906
	[NullableContext(1)]
	public interface IMarkSpritePoolObj
	{
		// Token: 0x1700866B RID: 34411
		// (get) Token: 0x06037D61 RID: 228705
		// (set) Token: 0x06037D62 RID: 228706
		string SpritePath { get; set; }

		// Token: 0x1700866C RID: 34412
		// (get) Token: 0x06037D63 RID: 228707
		// (set) Token: 0x06037D64 RID: 228708
		double RecycleTimeStamp { get; set; }

		// Token: 0x1700866D RID: 34413
		// (get) Token: 0x06037D65 RID: 228709
		// (set) Token: 0x06037D66 RID: 228710
		ULGUISpriteData_BaseObject Obj { get; set; }

		// Token: 0x1700866E RID: 34414
		// (get) Token: 0x06037D67 RID: 228711
		// (set) Token: 0x06037D68 RID: 228712
		int Ref { get; set; }
	}
}
