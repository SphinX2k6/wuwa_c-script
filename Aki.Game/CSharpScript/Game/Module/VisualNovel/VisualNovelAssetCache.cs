using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.TDConfigMgr.Action;
using AkiClient.Game.Aki.Data.SpineMouthAnimation.Struct;
using CSharpScript.Game.Module.Plot;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.VisualNovel
{
	// Token: 0x0200379C RID: 14236
	[NullableContext(1)]
	[Nullable(0)]
	public sealed class VisualNovelAssetCache
	{
		// Token: 0x17004BE9 RID: 19433
		// (get) Token: 0x06025060 RID: 151648 RVA: 0x00A74CDC File Offset: 0x00A72EDC
		internal VisualNovelConfigCenter ConfigCenter { get; }

		// Token: 0x17004BEA RID: 19434
		// (get) Token: 0x06025061 RID: 151649 RVA: 0x00A74CE4 File Offset: 0x00A72EE4
		public int ClearVersion
		{
			get
			{
				return this.LoadVersion;
			}
		}

		// Token: 0x06025062 RID: 151650 RVA: 0x00A74CEC File Offset: 0x00A72EEC
		public VisualNovelAssetCache(VisualNovelConfigCenter configCenter)
		{
			this.ConfigCenter = configCenter;
		}

		// Token: 0x06025063 RID: 151651 RVA: 0x00A74D54 File Offset: 0x00A72F54
		public UniTask PreloadAsync(VisualNovelItem item)
		{
			VisualNovelAssetCache.<PreloadAsync>d__16 <PreloadAsync>d__;
			<PreloadAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PreloadAsync>d__.<>4__this = this;
			<PreloadAsync>d__.item = item;
			<PreloadAsync>d__.<>1__state = -1;
			<PreloadAsync>d__.<>t__builder.Start<VisualNovelAssetCache.<PreloadAsync>d__16>(ref <PreloadAsync>d__);
			return <PreloadAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06025064 RID: 151652 RVA: 0x00A74DA0 File Offset: 0x00A72FA0
		private void RemoveUnusedAssets(HashSet<int> characterIds, HashSet<int> cgIds)
		{
			foreach (int num in this.SpineAssetsByCharacterId.Keys)
			{
				if (!characterIds.Contains(num))
				{
					this.SpineAssetsByCharacterId.Remove(num);
				}
			}
			foreach (int num2 in this.CharacterTextures.Keys)
			{
				if (!characterIds.Contains(num2))
				{
					this.CharacterTextures.Remove(num2);
				}
			}
			foreach (int num3 in this.CgImageAssetsById.Keys)
			{
				if (!cgIds.Contains(num3))
				{
					this.CgImageAssetsById.Remove(num3);
				}
			}
		}

		// Token: 0x06025065 RID: 151653 RVA: 0x00A74EB8 File Offset: 0x00A730B8
		[NullableContext(2)]
		public VisualNovelSpineCharacterAssets GetSpineAssets(int characterId)
		{
			VisualNovelSpineCharacterAssets result;
			if (!this.SpineAssetsByCharacterId.TryGetValue(characterId, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x06025066 RID: 151654 RVA: 0x00A74ED8 File Offset: 0x00A730D8
		[NullableContext(2)]
		public UTexture GetCharacterTexture(int characterId)
		{
			return this.CharacterTextures.GetValueOrDefault(characterId);
		}

		// Token: 0x06025067 RID: 151655 RVA: 0x00A74EE6 File Offset: 0x00A730E6
		public int GetTextureCharacterCount()
		{
			return this.CharacterTextures.Count;
		}

		// Token: 0x06025068 RID: 151656 RVA: 0x00A74EF4 File Offset: 0x00A730F4
		[NullableContext(2)]
		public VisualNovelCgImageAssets GetCgImage(int cgId)
		{
			VisualNovelCgImageAssets result;
			if (!this.CgImageAssetsById.TryGetValue(cgId, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x06025069 RID: 151657 RVA: 0x00A74F14 File Offset: 0x00A73114
		[return: Nullable(2)]
		public SpineMouthAnimation GetMouthAnimation(string mediaName)
		{
			if (!(this.MouthAnimationMediaName == mediaName))
			{
				return null;
			}
			return this.MouthAnimation;
		}

		// Token: 0x0602506A RID: 151658 RVA: 0x00A74F2C File Offset: 0x00A7312C
		[NullableContext(0)]
		public UniTask<bool> EnsureCharacterAsync(int characterId)
		{
			VisualNovelAssetCache.<EnsureCharacterAsync>d__23 <EnsureCharacterAsync>d__;
			<EnsureCharacterAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<EnsureCharacterAsync>d__.<>4__this = this;
			<EnsureCharacterAsync>d__.characterId = characterId;
			<EnsureCharacterAsync>d__.<>1__state = -1;
			<EnsureCharacterAsync>d__.<>t__builder.Start<VisualNovelAssetCache.<EnsureCharacterAsync>d__23>(ref <EnsureCharacterAsync>d__);
			return <EnsureCharacterAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602506B RID: 151659 RVA: 0x00A74F78 File Offset: 0x00A73178
		public void Clear()
		{
			this.LoadVersion++;
			this.ClearMouthAnimation();
			LoadAsyncPromise<UTexture>[] array = this.TextureLoadPromises.ToArray();
			for (int i = 0; i < array.Length; i++)
			{
				array[i].CancelAsyncLoad();
			}
			LoadAsyncPromise<USpineAtlasAsset>[] array2 = this.AtlasLoadPromises.ToArray();
			for (int i = 0; i < array2.Length; i++)
			{
				array2[i].CancelAsyncLoad();
			}
			LoadAsyncPromise<USpineSkeletonDataAsset>[] array3 = this.SkeletonLoadPromises.ToArray();
			for (int i = 0; i < array3.Length; i++)
			{
				array3[i].CancelAsyncLoad();
			}
			this.TextureLoadPromises.Clear();
			this.AtlasLoadPromises.Clear();
			this.SkeletonLoadPromises.Clear();
			this.SpineAssetsByCharacterId.Clear();
			this.CharacterTextures.Clear();
			this.CgImageAssetsById.Clear();
		}

		// Token: 0x0602506C RID: 151660 RVA: 0x00A75044 File Offset: 0x00A73244
		private UniTask PreloadMouthAnimationAsync(VisualNovelItem item)
		{
			VisualNovelAssetCache.<PreloadMouthAnimationAsync>d__25 <PreloadMouthAnimationAsync>d__;
			<PreloadMouthAnimationAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PreloadMouthAnimationAsync>d__.<>4__this = this;
			<PreloadMouthAnimationAsync>d__.item = item;
			<PreloadMouthAnimationAsync>d__.<>1__state = -1;
			<PreloadMouthAnimationAsync>d__.<>t__builder.Start<VisualNovelAssetCache.<PreloadMouthAnimationAsync>d__25>(ref <PreloadMouthAnimationAsync>d__);
			return <PreloadMouthAnimationAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602506D RID: 151661 RVA: 0x00A75090 File Offset: 0x00A73290
		private static string GetMouthAnimationMediaName(VisualNovelItem item)
		{
			if (!item.PlayVoice || item.SpeakerId == 0 || string.IsNullOrEmpty(item.TextKey))
			{
				return string.Empty;
			}
			PlotAudio? config = ConfigPlotAudioById.GetConfig(item.TextKey, true);
			if (config == null || !config.Value.GenLipSync)
			{
				return string.Empty;
			}
			return PlotAudioModel.Instance.GetExternalSourcesMediaName(config.Value);
		}

		// Token: 0x0602506E RID: 151662 RVA: 0x00A750FE File Offset: 0x00A732FE
		private void ClearMouthAnimation()
		{
			this.MouthAnimationMediaName = string.Empty;
			this.MouthAnimation = null;
			LoadAsyncPromise<BP_SpineMouthAnimation_C> mouthAnimationLoadPromise = this.MouthAnimationLoadPromise;
			this.MouthAnimationLoadPromise = null;
			if (mouthAnimationLoadPromise == null)
			{
				return;
			}
			mouthAnimationLoadPromise.CancelAsyncLoad();
		}

		// Token: 0x0602506F RID: 151663 RVA: 0x00A7512C File Offset: 0x00A7332C
		private UniTask PreloadCgImageAsync(int cgId)
		{
			VisualNovelAssetCache.<PreloadCgImageAsync>d__28 <PreloadCgImageAsync>d__;
			<PreloadCgImageAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PreloadCgImageAsync>d__.<>4__this = this;
			<PreloadCgImageAsync>d__.cgId = cgId;
			<PreloadCgImageAsync>d__.<>1__state = -1;
			<PreloadCgImageAsync>d__.<>t__builder.Start<VisualNovelAssetCache.<PreloadCgImageAsync>d__28>(ref <PreloadCgImageAsync>d__);
			return <PreloadCgImageAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06025070 RID: 151664 RVA: 0x00A75178 File Offset: 0x00A73378
		private UniTask PreloadCharacterAsync(int characterId)
		{
			VisualNovelAssetCache.<PreloadCharacterAsync>d__29 <PreloadCharacterAsync>d__;
			<PreloadCharacterAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PreloadCharacterAsync>d__.<>4__this = this;
			<PreloadCharacterAsync>d__.characterId = characterId;
			<PreloadCharacterAsync>d__.<>1__state = -1;
			<PreloadCharacterAsync>d__.<>t__builder.Start<VisualNovelAssetCache.<PreloadCharacterAsync>d__29>(ref <PreloadCharacterAsync>d__);
			return <PreloadCharacterAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06025071 RID: 151665 RVA: 0x00A751C4 File Offset: 0x00A733C4
		private UniTask PreloadCharacterTextureAsync(int characterId, string path)
		{
			VisualNovelAssetCache.<PreloadCharacterTextureAsync>d__30 <PreloadCharacterTextureAsync>d__;
			<PreloadCharacterTextureAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PreloadCharacterTextureAsync>d__.<>4__this = this;
			<PreloadCharacterTextureAsync>d__.characterId = characterId;
			<PreloadCharacterTextureAsync>d__.path = path;
			<PreloadCharacterTextureAsync>d__.<>1__state = -1;
			<PreloadCharacterTextureAsync>d__.<>t__builder.Start<VisualNovelAssetCache.<PreloadCharacterTextureAsync>d__30>(ref <PreloadCharacterTextureAsync>d__);
			return <PreloadCharacterTextureAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06025072 RID: 151666 RVA: 0x00A75217 File Offset: 0x00A73417
		private static void CollectCharacterIds(VisualNovelItem item, HashSet<int> characterIds)
		{
			if (item.Type == ETalkItemType.VisualNovelTalk && item.SpeakerId != 0)
			{
				characterIds.Add(item.SpeakerId);
			}
			VisualNovelAssetCache.CollectEnterCharacters(item.StartPerformances, characterIds);
			VisualNovelAssetCache.CollectEnterCharacters(item.EndPerformances, characterIds);
		}

		// Token: 0x06025073 RID: 151667 RVA: 0x00A75250 File Offset: 0x00A73450
		private static void CollectEnterCharacters([Nullable(new byte[]
		{
			2,
			1
		})] IReadOnlyList<IVisualNovelPerformanceBase> performances, HashSet<int> characterIds)
		{
			if (performances == null)
			{
				return;
			}
			foreach (IVisualNovelPerformanceBase visualNovelPerformanceBase in performances)
			{
				IVisualNovelPerformanceEnter visualNovelPerformanceEnter = visualNovelPerformanceBase as IVisualNovelPerformanceEnter;
				if (visualNovelPerformanceEnter != null)
				{
					characterIds.Add(visualNovelPerformanceEnter.WhoId);
				}
			}
		}

		// Token: 0x040147AA RID: 83882
		private readonly Dictionary<int, VisualNovelSpineCharacterAssets> SpineAssetsByCharacterId = new Dictionary<int, VisualNovelSpineCharacterAssets>();

		// Token: 0x040147AB RID: 83883
		private readonly Dictionary<int, UTexture> CharacterTextures = new Dictionary<int, UTexture>();

		// Token: 0x040147AC RID: 83884
		private readonly Dictionary<int, VisualNovelCgImageAssets> CgImageAssetsById = new Dictionary<int, VisualNovelCgImageAssets>();

		// Token: 0x040147AD RID: 83885
		private readonly List<LoadAsyncPromise<UTexture>> TextureLoadPromises = new List<LoadAsyncPromise<UTexture>>();

		// Token: 0x040147AE RID: 83886
		private readonly List<LoadAsyncPromise<USpineAtlasAsset>> AtlasLoadPromises = new List<LoadAsyncPromise<USpineAtlasAsset>>();

		// Token: 0x040147AF RID: 83887
		private readonly List<LoadAsyncPromise<USpineSkeletonDataAsset>> SkeletonLoadPromises = new List<LoadAsyncPromise<USpineSkeletonDataAsset>>();

		// Token: 0x040147B0 RID: 83888
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private LoadAsyncPromise<BP_SpineMouthAnimation_C> MouthAnimationLoadPromise;

		// Token: 0x040147B1 RID: 83889
		private string MouthAnimationMediaName = string.Empty;

		// Token: 0x040147B2 RID: 83890
		[Nullable(2)]
		private SpineMouthAnimation MouthAnimation;

		// Token: 0x040147B3 RID: 83891
		private int LoadVersion;
	}
}
