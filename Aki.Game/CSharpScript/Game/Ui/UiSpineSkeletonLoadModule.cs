using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Ui
{
	// Token: 0x0200360E RID: 13838
	public class UiSpineSkeletonLoadModule : UiResourceLoadModule
	{
		// Token: 0x060233E6 RID: 144358 RVA: 0x00A0319C File Offset: 0x00A0139C
		[NullableContext(1)]
		[return: Nullable(new byte[]
		{
			0,
			2
		})]
		public UniTask<USpineSkeletonDataAsset> LoadAtlasAssetAsync(string skeletonPath, USpineSkeletonAnimationComponent spine)
		{
			UiSpineSkeletonLoadModule.<LoadAtlasAssetAsync>d__0 <LoadAtlasAssetAsync>d__;
			<LoadAtlasAssetAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<USpineSkeletonDataAsset>.Create();
			<LoadAtlasAssetAsync>d__.<>4__this = this;
			<LoadAtlasAssetAsync>d__.skeletonPath = skeletonPath;
			<LoadAtlasAssetAsync>d__.spine = spine;
			<LoadAtlasAssetAsync>d__.<>1__state = -1;
			<LoadAtlasAssetAsync>d__.<>t__builder.Start<UiSpineSkeletonLoadModule.<LoadAtlasAssetAsync>d__0>(ref <LoadAtlasAssetAsync>d__);
			return <LoadAtlasAssetAsync>d__.<>t__builder.Task;
		}
	}
}
