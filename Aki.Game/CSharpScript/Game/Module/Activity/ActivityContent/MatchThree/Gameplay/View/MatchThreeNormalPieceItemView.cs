using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.View
{
	// Token: 0x0200545B RID: 21595
	public class MatchThreeNormalPieceItemView : MatchThreePieceItemView
	{
		// Token: 0x060359AE RID: 219566 RVA: 0x00EF9808 File Offset: 0x00EF7A08
		protected unsafe override void OnRegisterComponent()
		{
			int num = 1;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int index = 0;
			*span[index] = new ValueTuple<int, Type>(0, typeof(UUISprite));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x060359AF RID: 219567 RVA: 0x00EF9850 File Offset: 0x00EF7A50
		protected override UniTask PrepareAppearanceAsync()
		{
			MatchThreeNormalPieceItemView.<PrepareAppearanceAsync>d__3 <PrepareAppearanceAsync>d__;
			<PrepareAppearanceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PrepareAppearanceAsync>d__.<>4__this = this;
			<PrepareAppearanceAsync>d__.<>1__state = -1;
			<PrepareAppearanceAsync>d__.<>t__builder.Start<MatchThreeNormalPieceItemView.<PrepareAppearanceAsync>d__3>(ref <PrepareAppearanceAsync>d__);
			return <PrepareAppearanceAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060359B0 RID: 219568 RVA: 0x00EF9893 File Offset: 0x00EF7A93
		private void OnSpriteLoaded(bool success)
		{
			UUISprite sprite = base.GetSprite(0);
			if (sprite != null)
			{
				sprite.SetUIActive(success);
			}
			UniTaskCompletionSource<bool> spriteLoadPromise = this.SpriteLoadPromise;
			this.SpriteLoadPromise = null;
			if (spriteLoadPromise == null)
			{
				return;
			}
			spriteLoadPromise.TrySetResult(success);
		}

		// Token: 0x060359B1 RID: 219569 RVA: 0x00EF98C4 File Offset: 0x00EF7AC4
		protected override void RefreshAppearance()
		{
			UUISprite sprite = base.GetSprite(0);
			if (sprite == null)
			{
				this.OnSpriteLoaded(false);
				return;
			}
			sprite.SetUIActive(false);
			string item = MatchThreeGameplayDefine.GetPieceRes(this.Type).Item2;
			if (string.IsNullOrEmpty(item))
			{
				this.OnSpriteLoaded(false);
				return;
			}
			this.SetSpriteByPath(UiResourceConfig.Instance.GetResourcePath(item), sprite, false, null, new Action<bool>(this.OnSpriteLoaded));
		}

		// Token: 0x0401C562 RID: 116066
		[Nullable(2)]
		private UniTaskCompletionSource<bool> SpriteLoadPromise;

		// Token: 0x0200B0F3 RID: 45299
		private enum EComponent
		{
			// Token: 0x04036B84 RID: 224132
			SprIcon
		}
	}
}
