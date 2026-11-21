using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.VisualNovel
{
	// Token: 0x020037A0 RID: 14240
	[NullableContext(1)]
	[Nullable(0)]
	public sealed class VisualNovelCgImageAssets
	{
		// Token: 0x17004BEF RID: 19439
		// (get) Token: 0x060250A3 RID: 151715 RVA: 0x00A75DDB File Offset: 0x00A73FDB
		public string Level { get; }

		// Token: 0x17004BF0 RID: 19440
		// (get) Token: 0x060250A4 RID: 151716 RVA: 0x00A75DE3 File Offset: 0x00A73FE3
		public UTexture Texture { get; }

		// Token: 0x060250A5 RID: 151717 RVA: 0x00A75DEB File Offset: 0x00A73FEB
		public VisualNovelCgImageAssets(string level, UTexture texture)
		{
			this.Level = level;
			this.Texture = texture;
		}
	}
}
