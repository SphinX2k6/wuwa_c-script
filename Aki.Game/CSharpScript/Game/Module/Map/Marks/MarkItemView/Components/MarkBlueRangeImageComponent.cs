using System;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Map.Marks.MarkItemView.Components
{
	// Token: 0x02005542 RID: 21826
	public class MarkBlueRangeImageComponent : MarkRangeImageComponent
	{
		// Token: 0x06037B3D RID: 228157 RVA: 0x00D37F10 File Offset: 0x00D36110
		protected override UniTask OnBeforeStartAsync()
		{
			MarkBlueRangeImageComponent.<OnBeforeStartAsync>d__0 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MarkBlueRangeImageComponent.<OnBeforeStartAsync>d__0>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06037B3E RID: 228158 RVA: 0x00D37F54 File Offset: 0x00D36154
		protected override void OnStart()
		{
			this.RootItem.SetAnchorOffset(Vector2D.ZeroVector);
			this.RootItem.SetUIItemScale(Vector.OneVector);
			UUISprite rangeSprite = base.RangeSprite;
			if (rangeSprite != null)
			{
				rangeSprite.SetUIActive(false);
			}
			UUITexture rangeImage = base.RangeImage;
			if (rangeImage == null)
			{
				return;
			}
			rangeImage.SetUIActive(true);
		}
	}
}
