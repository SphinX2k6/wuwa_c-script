using System;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Menu.SubViews
{
	// Token: 0x0200542A RID: 21546
	[NullableContext(2)]
	[Nullable(0)]
	public class MenuDetailPopViewItemView
	{
		// Token: 0x060370AB RID: 225451 RVA: 0x00D0B2CF File Offset: 0x00D094CF
		public MenuDetailPopViewItemView(UUIText textComponent, UUITexture textureComponent, [Nullable(1)] Action<string, UUITexture> setTextureHandler)
		{
			this.TextComponent = textComponent;
			this.TextureComponent = textureComponent;
			this.SetTextureHandler = setTextureHandler;
		}

		// Token: 0x060370AC RID: 225452 RVA: 0x00D0B2F4 File Offset: 0x00D094F4
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

		// Token: 0x060370AD RID: 225453 RVA: 0x00D0B415 File Offset: 0x00D09615
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

		// Token: 0x060370AE RID: 225454 RVA: 0x00D0B438 File Offset: 0x00D09638
		private UniTask LoadMaterial()
		{
			MenuDetailPopViewItemView.<LoadMaterial>d__9 <LoadMaterial>d__;
			<LoadMaterial>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<LoadMaterial>d__.<>4__this = this;
			<LoadMaterial>d__.<>1__state = -1;
			<LoadMaterial>d__.<>t__builder.Start<MenuDetailPopViewItemView.<LoadMaterial>d__9>(ref <LoadMaterial>d__);
			return <LoadMaterial>d__.<>t__builder.Task;
		}

		// Token: 0x060370AF RID: 225455 RVA: 0x00D0B47B File Offset: 0x00D0967B
		private void CancelLoad()
		{
			if (this.HandleId != -1)
			{
				ResourceSystem.Instance.CancelAsyncLoad(this.HandleId);
				this.HandleId = -1;
			}
		}

		// Token: 0x0401D0B8 RID: 118968
		[Nullable(1)]
		private const string VIDEO_NAME = "MenuDetailPopViewItemPanel";

		// Token: 0x0401D0B9 RID: 118969
		private readonly UUIText TextComponent;

		// Token: 0x0401D0BA RID: 118970
		private readonly UUITexture TextureComponent;

		// Token: 0x0401D0BB RID: 118971
		[Nullable(1)]
		private readonly Action<string, UUITexture> SetTextureHandler;

		// Token: 0x0401D0BC RID: 118972
		private MediaPlayer MediaPlayer;

		// Token: 0x0401D0BD RID: 118973
		private int HandleId = -1;
	}
}
