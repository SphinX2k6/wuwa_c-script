using System;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Menu.SubViews
{
	// Token: 0x0200440D RID: 17421
	[NullableContext(2)]
	[Nullable(0)]
	public class MenuDetailPopViewItemView
	{
		// Token: 0x0602BFF4 RID: 180212 RVA: 0x00C5A6EF File Offset: 0x00C588EF
		public MenuDetailPopViewItemView(UUIText textComponent, UUITexture textureComponent, [Nullable(1)] Action<string, UUITexture> setTextureHandler)
		{
			this.TextComponent = textComponent;
			this.TextureComponent = textureComponent;
			this.SetTextureHandler = setTextureHandler;
		}

		// Token: 0x0602BFF5 RID: 180213 RVA: 0x00C5A714 File Offset: 0x00C58914
		[NullableContext(1)]
		public void RefreshByData(MenuDetailPopItemData data)
		{
			UUIText textComponent = this.TextComponent;
			if (textComponent != null)
			{
				textComponent.SetUIActive(data.Title.Length > 0);
			}
			if (textComponent != null && data.Title.Length > 0)
			{
				LguiUtil.Instance.SetLocalTextNew(textComponent, data.Title, Array.Empty<object>());
			}
			if (data.ShowType == EMenuDetailItemShowType.Picture)
			{
				this.SetTextureHandler(data.ResourcePath, this.TextureComponent);
				return;
			}
			if (data.ShowType == EMenuDetailItemShowType.Video || data.ShowType == EMenuDetailItemShowType.WideVideo)
			{
				this.MediaPlayer = (this.MediaPlayer ?? new MediaPlayer(this.TextureComponent));
				if (Info.Instance.PlatformType == ESourcePlatformType.Android)
				{
					this.LoadMaterial().ContinueWith(delegate()
					{
						MediaPlayer mediaPlayer2 = this.MediaPlayer;
						if (mediaPlayer2 == null)
						{
							return;
						}
						mediaPlayer2.PlayVideo("MenuDetailPopViewItemPanel", data.ResourcePath, true);
					}).Forget();
					return;
				}
				MediaPlayer mediaPlayer = this.MediaPlayer;
				if (mediaPlayer == null)
				{
					return;
				}
				mediaPlayer.PlayVideo("MenuDetailPopViewItemPanel", data.ResourcePath, true);
			}
		}

		// Token: 0x0602BFF6 RID: 180214 RVA: 0x00C5A835 File Offset: 0x00C58A35
		public void Clear()
		{
			MediaPlayer mediaPlayer = this.MediaPlayer;
			if (mediaPlayer != null)
			{
				mediaPlayer.Clear();
			}
			this.MediaPlayer = null;
			this.CancelLoad();
		}

		// Token: 0x0602BFF7 RID: 180215 RVA: 0x00C5A858 File Offset: 0x00C58A58
		private UniTask LoadMaterial()
		{
			MenuDetailPopViewItemView.<LoadMaterial>d__9 <LoadMaterial>d__;
			<LoadMaterial>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<LoadMaterial>d__.<>4__this = this;
			<LoadMaterial>d__.<>1__state = -1;
			<LoadMaterial>d__.<>t__builder.Start<MenuDetailPopViewItemView.<LoadMaterial>d__9>(ref <LoadMaterial>d__);
			return <LoadMaterial>d__.<>t__builder.Task;
		}

		// Token: 0x0602BFF8 RID: 180216 RVA: 0x00C5A89B File Offset: 0x00C58A9B
		private void CancelLoad()
		{
			if (this.HandleId != -1)
			{
				ResourceSystem.Instance.CancelAsyncLoad(this.HandleId);
				this.HandleId = -1;
			}
		}

		// Token: 0x04017B51 RID: 97105
		[Nullable(1)]
		private const string VIDEO_NAME = "MenuDetailPopViewItemPanel";

		// Token: 0x04017B52 RID: 97106
		private readonly UUIText TextComponent;

		// Token: 0x04017B53 RID: 97107
		private readonly UUITexture TextureComponent;

		// Token: 0x04017B54 RID: 97108
		[Nullable(1)]
		private readonly Action<string, UUITexture> SetTextureHandler;

		// Token: 0x04017B55 RID: 97109
		private MediaPlayer MediaPlayer;

		// Token: 0x04017B56 RID: 97110
		private int HandleId = -1;
	}
}
