using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.VisualNovel
{
	// Token: 0x020037A7 RID: 14247
	[NullableContext(1)]
	[Nullable(0)]
	public readonly struct VisualNovelCharacterResource
	{
		// Token: 0x17004C07 RID: 19463
		// (get) Token: 0x060250FD RID: 151805 RVA: 0x00A76804 File Offset: 0x00A74A04
		public string AtlasPath { get; }

		// Token: 0x17004C08 RID: 19464
		// (get) Token: 0x060250FE RID: 151806 RVA: 0x00A7680C File Offset: 0x00A74A0C
		public string SkeletonDataPath { get; }

		// Token: 0x17004C09 RID: 19465
		// (get) Token: 0x060250FF RID: 151807 RVA: 0x00A76814 File Offset: 0x00A74A14
		public string TexturePath { get; }

		// Token: 0x17004C0A RID: 19466
		// (get) Token: 0x06025100 RID: 151808 RVA: 0x00A7681C File Offset: 0x00A74A1C
		public VisualNovelTransform? PortraitTransform { get; }

		// Token: 0x06025101 RID: 151809 RVA: 0x00A76824 File Offset: 0x00A74A24
		public VisualNovelCharacterResource(string atlasPath, string skeletonDataPath, string texturePath, VisualNovelTransform? portraitTransform)
		{
			this.AtlasPath = atlasPath;
			this.SkeletonDataPath = skeletonDataPath;
			this.TexturePath = texturePath;
			this.PortraitTransform = portraitTransform;
		}
	}
}
