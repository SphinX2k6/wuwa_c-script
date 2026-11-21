using System;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Map.Marks.MarkItemView.Components
{
	// Token: 0x02004514 RID: 17684
	public class MarkBlueRangeImageComponent : MarkRangeImageComponent
	{
		// Token: 0x0602CA0C RID: 182796 RVA: 0x00C859E4 File Offset: 0x00C83BE4
		protected override UniTask OnBeforeStartAsync()
		{
			MarkBlueRangeImageComponent.<OnBeforeStartAsync>d__0 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MarkBlueRangeImageComponent.<OnBeforeStartAsync>d__0>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602CA0D RID: 182797 RVA: 0x00C85A28 File Offset: 0x00C83C28
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
