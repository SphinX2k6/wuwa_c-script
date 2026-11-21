using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.VisualNovel
{
	// Token: 0x020037C1 RID: 14273
	[NullableContext(1)]
	[Nullable(0)]
	public sealed class VisualNovelSpineCharacterAssets
	{
		// Token: 0x17004C8A RID: 19594
		// (get) Token: 0x060252B0 RID: 152240 RVA: 0x00A7C575 File Offset: 0x00A7A775
		public USpineAtlasAsset Atlas { get; }

		// Token: 0x17004C8B RID: 19595
		// (get) Token: 0x060252B1 RID: 152241 RVA: 0x00A7C57D File Offset: 0x00A7A77D
		public USpineSkeletonDataAsset SkeletonData { get; }

		// Token: 0x17004C8C RID: 19596
		// (get) Token: 0x060252B2 RID: 152242 RVA: 0x00A7C585 File Offset: 0x00A7A785
		public VisualNovelTransform? PortraitTransform { get; }

		// Token: 0x060252B3 RID: 152243 RVA: 0x00A7C58D File Offset: 0x00A7A78D
		public VisualNovelSpineCharacterAssets(USpineAtlasAsset atlas, USpineSkeletonDataAsset skeletonData, VisualNovelTransform? portraitTransform)
		{
			this.Atlas = atlas;
			this.SkeletonData = skeletonData;
			this.PortraitTransform = portraitTransform;
		}
	}
}
