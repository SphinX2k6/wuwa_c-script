using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Map.Container
{
	// Token: 0x02005594 RID: 21908
	[NullableContext(1)]
	[Nullable(0)]
	public class MarkSpritePoolObj : IMarkSpritePoolObj
	{
		// Token: 0x1700866F RID: 34415
		// (get) Token: 0x06037D6F RID: 228719 RVA: 0x00D3C4A6 File Offset: 0x00D3A6A6
		// (set) Token: 0x06037D70 RID: 228720 RVA: 0x00D3C4AE File Offset: 0x00D3A6AE
		public string SpritePath { get; set; }

		// Token: 0x17008670 RID: 34416
		// (get) Token: 0x06037D71 RID: 228721 RVA: 0x00D3C4B7 File Offset: 0x00D3A6B7
		// (set) Token: 0x06037D72 RID: 228722 RVA: 0x00D3C4BF File Offset: 0x00D3A6BF
		public double RecycleTimeStamp { get; set; }

		// Token: 0x17008671 RID: 34417
		// (get) Token: 0x06037D73 RID: 228723 RVA: 0x00D3C4C8 File Offset: 0x00D3A6C8
		// (set) Token: 0x06037D74 RID: 228724 RVA: 0x00D3C4D0 File Offset: 0x00D3A6D0
		public ULGUISpriteData_BaseObject Obj { get; set; }

		// Token: 0x17008672 RID: 34418
		// (get) Token: 0x06037D75 RID: 228725 RVA: 0x00D3C4D9 File Offset: 0x00D3A6D9
		// (set) Token: 0x06037D76 RID: 228726 RVA: 0x00D3C4E1 File Offset: 0x00D3A6E1
		public int Ref { get; set; }
	}
}
