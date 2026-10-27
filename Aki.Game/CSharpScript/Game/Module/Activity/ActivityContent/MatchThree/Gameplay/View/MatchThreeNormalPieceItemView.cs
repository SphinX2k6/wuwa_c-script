using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.View
{
	// Token: 0x020064DD RID: 25821
	public class MatchThreeNormalPieceItemView : MatchThreePieceItemView
	{
		// Token: 0x06040CEA RID: 265450 RVA: 0x00FB27D8 File Offset: 0x00FB09D8
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

		// Token: 0x06040CEB RID: 265451 RVA: 0x00FB2820 File Offset: 0x00FB0A20
		protected override UniTask PrepareAppearanceAsync()
		{
			MatchThreeNormalPieceItemView.<PrepareAppearanceAsync>d__3 <PrepareAppearanceAsync>d__;
			<PrepareAppearanceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PrepareAppearanceAsync>d__.<>4__this = this;
			<PrepareAppearanceAsync>d__.<>1__state = -1;
			<PrepareAppearanceAsync>d__.<>t__builder.Start<MatchThreeNormalPieceItemView.<PrepareAppearanceAsync>d__3>(ref <PrepareAppearanceAsync>d__);
			return <PrepareAppearanceAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06040CEC RID: 265452 RVA: 0x00FB2863 File Offset: 0x00FB0A63
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

		// Token: 0x06040CED RID: 265453 RVA: 0x00FB2894 File Offset: 0x00FB0A94
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

		// Token: 0x04021C31 RID: 138289
		[Nullable(2)]
		private UniTaskCompletionSource<bool> SpriteLoadPromise;

		// Token: 0x0200C70D RID: 50957
		private enum EComponent
		{
			// Token: 0x0403C229 RID: 246313
			SprIcon
		}
	}
}
