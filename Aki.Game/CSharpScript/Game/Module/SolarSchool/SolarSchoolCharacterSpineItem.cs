using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.VisualNovel;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x02005A11 RID: 23057
	[NullableContext(2)]
	[Nullable(0)]
	public sealed class SolarSchoolCharacterSpineItem : UiPanelBase
	{
		// Token: 0x17006C6B RID: 27755
		// (get) Token: 0x06038C73 RID: 232563 RVA: 0x00FE4EB8 File Offset: 0x00FE30B8
		// (set) Token: 0x06038C74 RID: 232564 RVA: 0x00FE4EC0 File Offset: 0x00FE30C0
		public VisualNovelSpineCharacter Character { get; private set; }

		// Token: 0x06038C75 RID: 232565 RVA: 0x00FE4ECC File Offset: 0x00FE30CC
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(USpineSkeletonAnimationComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06038C76 RID: 232566 RVA: 0x00FE4F78 File Offset: 0x00FE3178
		protected override UniTask OnBeforeStartAsync()
		{
			USpineSkeletonAnimationComponent spine = base.GetSpine(1);
			UUIItem rootItem = base.GetRootItem();
			UUIItem item = base.GetItem(0);
			this.SequencePlayer = new LevelSequencePlayer(rootItem);
			this.Character = new VisualNovelSpineCharacter(rootItem, item, spine, this.SequencePlayer, () => this.AssetCache, this.ShouldApplyPortraitTransform, this.ShouldPinRootToOrigin);
			this.ShowChatBubble(null);
			return UniTask.CompletedTask;
		}

		// Token: 0x06038C77 RID: 232567 RVA: 0x00FE4FE0 File Offset: 0x00FE31E0
		public void EnablePortraitTransform()
		{
			this.ShouldApplyPortraitTransform = true;
		}

		// Token: 0x06038C78 RID: 232568 RVA: 0x00FE4FE9 File Offset: 0x00FE31E9
		public void EnableRootPinnedToOrigin()
		{
			this.ShouldPinRootToOrigin = true;
		}

		// Token: 0x06038C79 RID: 232569 RVA: 0x00FE4FF2 File Offset: 0x00FE31F2
		public void SetChatBubbleEnabled(bool enabled)
		{
			if (this.ShouldShowChatBubble == enabled)
			{
				return;
			}
			this.ShouldShowChatBubble = enabled;
			this.ApplyChatBubble();
		}

		// Token: 0x06038C7A RID: 232570 RVA: 0x00FE500B File Offset: 0x00FE320B
		[NullableContext(1)]
		public void SetAssetCache(VisualNovelAssetCache assetCache)
		{
			if (this.OwnsAssetCache)
			{
				VisualNovelAssetCache assetCache2 = this.AssetCache;
				if (assetCache2 != null)
				{
					assetCache2.Clear();
				}
				this.OwnsAssetCache = false;
			}
			this.AssetCache = assetCache;
		}

		// Token: 0x06038C7B RID: 232571 RVA: 0x00FE5034 File Offset: 0x00FE3234
		[NullableContext(0)]
		public UniTask<bool> ShowByRoleSpineAsync(int roleSpineId, bool playVoice = true)
		{
			SolarSchoolCharacterSpineItem.<ShowByRoleSpineAsync>d__20 <ShowByRoleSpineAsync>d__;
			<ShowByRoleSpineAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ShowByRoleSpineAsync>d__.<>4__this = this;
			<ShowByRoleSpineAsync>d__.roleSpineId = roleSpineId;
			<ShowByRoleSpineAsync>d__.playVoice = playVoice;
			<ShowByRoleSpineAsync>d__.<>1__state = -1;
			<ShowByRoleSpineAsync>d__.<>t__builder.Start<SolarSchoolCharacterSpineItem.<ShowByRoleSpineAsync>d__20>(ref <ShowByRoleSpineAsync>d__);
			return <ShowByRoleSpineAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06038C7C RID: 232572 RVA: 0x00FE5088 File Offset: 0x00FE3288
		[return: Nullable(0)]
		private UniTask<bool> ShowCoreAsync(int version, int speakerId, int animationId, string textKey, string audioId, bool playVoice)
		{
			SolarSchoolCharacterSpineItem.<ShowCoreAsync>d__21 <ShowCoreAsync>d__;
			<ShowCoreAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ShowCoreAsync>d__.<>4__this = this;
			<ShowCoreAsync>d__.version = version;
			<ShowCoreAsync>d__.speakerId = speakerId;
			<ShowCoreAsync>d__.animationId = animationId;
			<ShowCoreAsync>d__.textKey = textKey;
			<ShowCoreAsync>d__.audioId = audioId;
			<ShowCoreAsync>d__.playVoice = playVoice;
			<ShowCoreAsync>d__.<>1__state = -1;
			<ShowCoreAsync>d__.<>t__builder.Start<SolarSchoolCharacterSpineItem.<ShowCoreAsync>d__21>(ref <ShowCoreAsync>d__);
			return <ShowCoreAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06038C7D RID: 232573 RVA: 0x00FE5100 File Offset: 0x00FE3300
		public UniTask HideAsync(float fadeDuration = 0f)
		{
			SolarSchoolCharacterSpineItem.<HideAsync>d__22 <HideAsync>d__;
			<HideAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<HideAsync>d__.<>4__this = this;
			<HideAsync>d__.fadeDuration = fadeDuration;
			<HideAsync>d__.<>1__state = -1;
			<HideAsync>d__.<>t__builder.Start<SolarSchoolCharacterSpineItem.<HideAsync>d__22>(ref <HideAsync>d__);
			return <HideAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06038C7E RID: 232574 RVA: 0x00FE514C File Offset: 0x00FE334C
		private UniTask HideInternalAsync(float fadeDuration)
		{
			SolarSchoolCharacterSpineItem.<HideInternalAsync>d__23 <HideInternalAsync>d__;
			<HideInternalAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<HideInternalAsync>d__.<>4__this = this;
			<HideInternalAsync>d__.fadeDuration = fadeDuration;
			<HideInternalAsync>d__.<>1__state = -1;
			<HideInternalAsync>d__.<>t__builder.Start<SolarSchoolCharacterSpineItem.<HideInternalAsync>d__23>(ref <HideInternalAsync>d__);
			return <HideInternalAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06038C7F RID: 232575 RVA: 0x00FE5197 File Offset: 0x00FE3397
		private void ShowChatBubble(string textKey)
		{
			this.CurrentChatTextKey = textKey;
			this.ApplyChatBubble();
		}

		// Token: 0x06038C80 RID: 232576 RVA: 0x00FE51A8 File Offset: 0x00FE33A8
		private void ApplyChatBubble()
		{
			UUIItem item = base.GetItem(2);
			string text = this.ShouldShowChatBubble ? SolarSchoolUtils.GetTextWithPlaceholder(this.CurrentChatTextKey) : string.Empty;
			item.SetUIActive(!string.IsNullOrEmpty(text));
			base.GetText(3).SetText(text, true);
		}

		// Token: 0x06038C81 RID: 232577 RVA: 0x00FE51F3 File Offset: 0x00FE33F3
		[NullableContext(1)]
		private VisualNovelAssetCache EnsureAssetCache()
		{
			if (this.AssetCache == null)
			{
				this.AssetCache = new VisualNovelAssetCache(new SolarSchoolVisualNovelConfigCenter());
				this.OwnsAssetCache = true;
			}
			return this.AssetCache;
		}

		// Token: 0x06038C82 RID: 232578 RVA: 0x00FE521C File Offset: 0x00FE341C
		protected override void OnBeforeDestroy()
		{
			VisualNovelSpineCharacter character = this.Character;
			if (character != null)
			{
				character.Destroy();
			}
			this.Character = null;
			LevelSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer != null)
			{
				sequencePlayer.Clear();
			}
			this.SequencePlayer = null;
			if (this.OwnsAssetCache)
			{
				VisualNovelAssetCache assetCache = this.AssetCache;
				if (assetCache != null)
				{
					assetCache.Clear();
				}
				this.OwnsAssetCache = false;
			}
			this.AssetCache = null;
			this.ShowRequestVersion = 0;
			this.CurrentChatTextKey = null;
		}

		// Token: 0x0401DE37 RID: 122423
		[Nullable(1)]
		public const string ResourceId = "PnlSpineParentItem";

		// Token: 0x0401DE39 RID: 122425
		private LevelSequencePlayer SequencePlayer;

		// Token: 0x0401DE3A RID: 122426
		private bool ShouldApplyPortraitTransform;

		// Token: 0x0401DE3B RID: 122427
		private bool ShouldPinRootToOrigin;

		// Token: 0x0401DE3C RID: 122428
		private bool ShouldShowChatBubble = true;

		// Token: 0x0401DE3D RID: 122429
		private VisualNovelAssetCache AssetCache;

		// Token: 0x0401DE3E RID: 122430
		private bool OwnsAssetCache;

		// Token: 0x0401DE3F RID: 122431
		private int ShowRequestVersion;

		// Token: 0x0401DE40 RID: 122432
		private string CurrentChatTextKey;

		// Token: 0x0200B5CB RID: 46539
		[NullableContext(0)]
		private static class EComponents
		{
			// Token: 0x04038384 RID: 230276
			public const int SpineParentItem = 0;

			// Token: 0x04038385 RID: 230277
			public const int Spine = 1;

			// Token: 0x04038386 RID: 230278
			public const int PnlChat = 2;

			// Token: 0x04038387 RID: 230279
			public const int TxtChat = 3;
		}
	}
}
