using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Map.Container
{
	// Token: 0x02004568 RID: 17768
	[NullableContext(1)]
	public interface IMarkSpritePoolObj
	{
		// Token: 0x17005A32 RID: 23090
		// (get) Token: 0x0602CC5F RID: 183391
		// (set) Token: 0x0602CC60 RID: 183392
		string SpritePath { get; set; }

		// Token: 0x17005A33 RID: 23091
		// (get) Token: 0x0602CC61 RID: 183393
		// (set) Token: 0x0602CC62 RID: 183394
		double RecycleTimeStamp { get; set; }

		// Token: 0x17005A34 RID: 23092
		// (get) Token: 0x0602CC63 RID: 183395
		// (set) Token: 0x0602CC64 RID: 183396
		ULGUISpriteData_BaseObject Obj { get; set; }

		// Token: 0x17005A35 RID: 23093
		// (get) Token: 0x0602CC65 RID: 183397
		// (set) Token: 0x0602CC66 RID: 183398
		int Ref { get; set; }
	}
}
