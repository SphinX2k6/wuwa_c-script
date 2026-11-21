using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Skin
{
	// Token: 0x02003B8E RID: 15246
	public static class SkinPreviewUtil
	{
		// Token: 0x06027135 RID: 160053 RVA: 0x00AEF358 File Offset: 0x00AED558
		[return: TupleElementNames(new string[]
		{
			"Success",
			"AtlasPath",
			"SkeletonPath"
		})]
		[return: Nullable(new byte[]
		{
			0,
			1,
			1
		})]
		public unsafe static ValueTuple<bool, string, string> TryGetSpinePreviewResources(RoleSkin skinConfig, bool reportMissingResources = false)
		{
			string smallSpineAtlas = skinConfig.SmallSpineAtlas;
			string spineSkeletonData = skinConfig.SpineSkeletonData;
			if (string.IsNullOrWhiteSpace(smallSpineAtlas) || smallSpineAtlas == "0" || string.IsNullOrWhiteSpace(spineSkeletonData) || spineSkeletonData == "0")
			{
				if (reportMissingResources)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.RoleSkin;
					ELogAuthor author = ELogAuthor.HMQ;
					string message = "[TryGetSpinePreviewResources] Spine预览资源路径配置缺失或为默认值0";
					<>y__InlineArray5<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray5<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Table", "RoleSkin");
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("RoleId", skinConfig.RoleId);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("SkinId", skinConfig.Id);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("SmallSpineAtlas", smallSpineAtlas);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 4) = new ValueTuple<string, object>("SpineSkeletonData", spineSkeletonData);
					instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 5));
				}
				return new ValueTuple<bool, string, string>(false, smallSpineAtlas, spineSkeletonData);
			}
			return new ValueTuple<bool, string, string>(true, smallSpineAtlas, spineSkeletonData);
		}
	}
}
