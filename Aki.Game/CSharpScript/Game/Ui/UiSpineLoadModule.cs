using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Ui
{
	// Token: 0x0200360F RID: 13839
	[NullableContext(1)]
	[Nullable(0)]
	public class UiSpineLoadModule
	{
		// Token: 0x060233E8 RID: 144360 RVA: 0x00A031F8 File Offset: 0x00A013F8
		public UniTask LoadSpineAssetAsync(string atlasPath, string skeletonPath, USpineSkeletonAnimationComponent spine)
		{
			UiSpineLoadModule.<LoadSpineAssetAsync>d__2 <LoadSpineAssetAsync>d__;
			<LoadSpineAssetAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<LoadSpineAssetAsync>d__.<>4__this = this;
			<LoadSpineAssetAsync>d__.atlasPath = atlasPath;
			<LoadSpineAssetAsync>d__.skeletonPath = skeletonPath;
			<LoadSpineAssetAsync>d__.spine = spine;
			<LoadSpineAssetAsync>d__.<>1__state = -1;
			<LoadSpineAssetAsync>d__.<>t__builder.Start<UiSpineLoadModule.<LoadSpineAssetAsync>d__2>(ref <LoadSpineAssetAsync>d__);
			return <LoadSpineAssetAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060233E9 RID: 144361 RVA: 0x00A03253 File Offset: 0x00A01453
		public void Clear()
		{
			this.AtlasModule.Clear();
			this.SkeletonModule.Clear();
		}

		// Token: 0x04013DEC RID: 81388
		private readonly UiSpineAtlasLoadModule AtlasModule = new UiSpineAtlasLoadModule();

		// Token: 0x04013DED RID: 81389
		private readonly UiSpineSkeletonLoadModule SkeletonModule = new UiSpineSkeletonLoadModule();
	}
}
