using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Ui
{
	// Token: 0x020046DD RID: 18141
	public class UiSpineAtlasLoadModule : UiResourceLoadModule
	{
		// Token: 0x0602ECA9 RID: 191657 RVA: 0x00AD5668 File Offset: 0x00AD3868
		[NullableContext(1)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public UniTask<USpineAtlasAsset> LoadAtlasAssetAsync(string atlasPath, USpineSkeletonAnimationComponent spine)
		{
			UiSpineAtlasLoadModule.<LoadAtlasAssetAsync>d__0 <LoadAtlasAssetAsync>d__;
			<LoadAtlasAssetAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<USpineAtlasAsset>.Create();
			<LoadAtlasAssetAsync>d__.<>4__this = this;
			<LoadAtlasAssetAsync>d__.atlasPath = atlasPath;
			<LoadAtlasAssetAsync>d__.spine = spine;
			<LoadAtlasAssetAsync>d__.<>1__state = -1;
			<LoadAtlasAssetAsync>d__.<>t__builder.Start<UiSpineAtlasLoadModule.<LoadAtlasAssetAsync>d__0>(ref <LoadAtlasAssetAsync>d__);
			return <LoadAtlasAssetAsync>d__.<>t__builder.Task;
		}
	}
}
