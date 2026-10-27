using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Ui
{
	// Token: 0x020046DF RID: 18143
	[NullableContext(1)]
	[Nullable(0)]
	public class UiSpineLoadModule
	{
		// Token: 0x0602ECAD RID: 191661 RVA: 0x00AD5720 File Offset: 0x00AD3920
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

		// Token: 0x0602ECAE RID: 191662 RVA: 0x00AD577B File Offset: 0x00AD397B
		public void Clear()
		{
			this.AtlasModule.Clear();
			this.SkeletonModule.Clear();
		}

		// Token: 0x0401974E RID: 104270
		private readonly UiSpineAtlasLoadModule AtlasModule = new UiSpineAtlasLoadModule();

		// Token: 0x0401974F RID: 104271
		private readonly UiSpineSkeletonLoadModule SkeletonModule = new UiSpineSkeletonLoadModule();
	}
}
