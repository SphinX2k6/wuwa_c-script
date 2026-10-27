using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020010EC RID: 4332
[NullableContext(2)]
[Nullable(0)]
public class ArtemisChatLeftItem : UiPanelBase
{
	// Token: 0x060070EC RID: 28908 RVA: 0x00170B4C File Offset: 0x0016ED4C
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUITexture)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUISizeControlByOther)),
			new ValueTuple<int, Type>(4, typeof(UUIText)),
			new ValueTuple<int, Type>(5, typeof(UUISprite)),
			new ValueTuple<int, Type>(6, typeof(UUITexture)),
			new ValueTuple<int, Type>(7, typeof(UUIItem)),
			new ValueTuple<int, Type>(8, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(9, typeof(UUITexture)),
			new ValueTuple<int, Type>(10, typeof(UUISprite))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(8, new Action(this.OnClickPictureButton))
		};
	}

	// Token: 0x060070ED RID: 28909 RVA: 0x00170C7C File Offset: 0x0016EE7C
	protected override void OnStart()
	{
		this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
		AUIBaseActor rootActor = this.RootActor;
		if (rootActor != null)
		{
			rootActor.OnSequencePlayEvent.Bind(new Action<string, string>(this.OnPlaySequenceEvent));
		}
		UUIText text = base.GetText(0);
		if (text != null)
		{
			text.SetUIActive(false);
		}
		UUISprite sprite = base.GetSprite(5);
		if (sprite != null)
		{
			sprite.SetUIActive(false);
		}
		UUIItem item = base.GetItem(7);
		if (item != null)
		{
			item.SetUIActive(false);
		}
		UUISprite sprite2 = base.GetSprite(6);
		if (sprite2 == null)
		{
			return;
		}
		sprite2.SetUIActive(false);
	}

	// Token: 0x060070EE RID: 28910 RVA: 0x00170D07 File Offset: 0x0016EF07
	protected override void OnBeforeDestroy()
	{
		AUIBaseActor rootActor = this.RootActor;
		if (rootActor != null)
		{
			rootActor.OnSequencePlayEvent.Unbind();
		}
		LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
		if (levelSequencePlayer != null)
		{
			levelSequencePlayer.Clear();
		}
		this.LevelSequencePlayer = null;
	}

	// Token: 0x060070EF RID: 28911 RVA: 0x00170D37 File Offset: 0x0016EF37
	[NullableContext(1)]
	private void OnPlaySequenceEvent(string sequenceName, string eventName)
	{
		if (eventName == "Dele_M")
		{
			this.LoadTextMaterial(false);
			this.RefreshPlayerTextureCustomMaterial(this.TexturePath, false).Forget();
		}
	}

	// Token: 0x060070F0 RID: 28912 RVA: 0x00170D60 File Offset: 0x0016EF60
	[NullableContext(1)]
	public void SetContent(IArtemisChatItemData data)
	{
		string stringConfig = ConfigCommonParamById.GetStringConfig("ArtemisChatHeadIconPath");
		this.CheckPathSetTexture(stringConfig, 1);
		string stringConfig2 = ConfigCommonParamById.GetStringConfig("ArtemisChatHeadName");
		if (stringConfig2 != null && stringConfig2.Length > 0)
		{
			UUIText text = base.GetText(2);
			if (text != null)
			{
				text.ShowTextNew(stringConfig2);
			}
		}
		base.GetUiSizeControlByOther(3).GetRootComponent().SetUIActive(data.Content.Length > 0);
		this.SetChatContent(data.Content);
		this.TexturePath = data.PicturePath;
		bool flag = data.PicturePath != null && data.PicturePath.Length > 0;
		UUIButtonComponent button = base.GetButton(8);
		if (button != null)
		{
			button.RootUIComp.Get().SetUIActive(flag);
		}
		if (data.IsLock)
		{
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer != null)
			{
				levelSequencePlayer.PlayLevelSequenceByName("Start", false, null, false);
			}
		}
		this.LoadTextMaterial(data.IsLock);
		UUISprite sprite = base.GetSprite(10);
		if (sprite != null)
		{
			sprite.SetAlpha(data.IsShowEffect > false);
		}
		if (flag)
		{
			this.RefreshPlayerTextureCustomMaterial(this.TexturePath, data.IsShowEffect).Forget();
		}
	}

	// Token: 0x060070F1 RID: 28913 RVA: 0x00170E88 File Offset: 0x0016F088
	[NullableContext(1)]
	private void SetChatContent(string content)
	{
		if (content != null && content.Length > 0)
		{
			UUIText text = base.GetText(4);
			if (text != null)
			{
				text.ShowTextNew(content);
			}
			UUIText text2 = base.GetText(4);
			if (text2 == null)
			{
				return;
			}
			text2.SetAlpha(1f);
		}
	}

	// Token: 0x060070F2 RID: 28914 RVA: 0x00170EC0 File Offset: 0x0016F0C0
	private void CheckPathSetTexture(string path, int componentIndex)
	{
		string path2 = (path != null && path.Length > 0) ? path : null;
		base.TrySetTextureByPath(path2, base.GetTexture(componentIndex), null, null);
	}

	// Token: 0x060070F3 RID: 28915 RVA: 0x00170EF6 File Offset: 0x0016F0F6
	private void OnClickPictureButton()
	{
		if (!string.IsNullOrEmpty(this.TexturePath))
		{
			InfoDisplayModel.Instance.SetCurrentOpenInformationTexture(this.TexturePath);
			InfoDisplayController.Instance.OpenInfoDisplayImgView();
		}
	}

	// Token: 0x060070F4 RID: 28916 RVA: 0x00170F20 File Offset: 0x0016F120
	private UniTask RefreshPlayerTextureCustomMaterial(string picturePath, bool isLock)
	{
		ArtemisChatLeftItem.<RefreshPlayerTextureCustomMaterial>d__11 <RefreshPlayerTextureCustomMaterial>d__;
		<RefreshPlayerTextureCustomMaterial>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshPlayerTextureCustomMaterial>d__.<>4__this = this;
		<RefreshPlayerTextureCustomMaterial>d__.picturePath = picturePath;
		<RefreshPlayerTextureCustomMaterial>d__.isLock = isLock;
		<RefreshPlayerTextureCustomMaterial>d__.<>1__state = -1;
		<RefreshPlayerTextureCustomMaterial>d__.<>t__builder.Start<ArtemisChatLeftItem.<RefreshPlayerTextureCustomMaterial>d__11>(ref <RefreshPlayerTextureCustomMaterial>d__);
		return <RefreshPlayerTextureCustomMaterial>d__.<>t__builder.Task;
	}

	// Token: 0x060070F5 RID: 28917 RVA: 0x00170F74 File Offset: 0x0016F174
	private void LoadTextMaterial(bool loadMaterial)
	{
		if (loadMaterial)
		{
			UiResourceConfig instance = UiResourceConfig.Instance;
			string text = (instance != null) ? instance.GetResourcePath("MI_GlitchAimisText") : null;
			if (string.IsNullOrEmpty(text))
			{
				return;
			}
			ResourceSystem.Instance.LoadAsync<UMaterialInterface>(text, delegate([Nullable(2)] UMaterialInterface material, string _)
			{
				UUIText text3 = base.GetText(4);
				if (text3 == null)
				{
					return;
				}
				text3.SetCustomUIMaterial(material);
			}, ResourceSystem.EResourceLoadPriority.Ui, this.MemoryTag);
			return;
		}
		else
		{
			UUIText text2 = base.GetText(4);
			if (text2 == null)
			{
				return;
			}
			text2.SetCustomUIMaterial(null);
			return;
		}
	}

	// Token: 0x060070F6 RID: 28918 RVA: 0x00170FD8 File Offset: 0x0016F1D8
	public void PlayFixDoneLevelSequence()
	{
		LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
		if (levelSequencePlayer == null)
		{
			return;
		}
		levelSequencePlayer.PlayLevelSequenceByName("Fix_Done", false, null, false);
	}

	// Token: 0x04003452 RID: 13394
	private string TexturePath;

	// Token: 0x04003453 RID: 13395
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x020076AF RID: 30383
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x040272B2 RID: 160434
		public const int TxtTime = 0;

		// Token: 0x040272B3 RID: 160435
		public const int TextureHead = 1;

		// Token: 0x040272B4 RID: 160436
		public const int TxtPlayerName = 2;

		// Token: 0x040272B5 RID: 160437
		public const int PnlChatContent = 3;

		// Token: 0x040272B6 RID: 160438
		public const int TxtChat = 4;

		// Token: 0x040272B7 RID: 160439
		public const int SpriteIconState = 5;

		// Token: 0x040272B8 RID: 160440
		public const int TextureChatEmote = 6;

		// Token: 0x040272B9 RID: 160441
		public const int PnlInput = 7;

		// Token: 0x040272BA RID: 160442
		public const int BtnPic = 8;

		// Token: 0x040272BB RID: 160443
		public const int TextPic = 9;

		// Token: 0x040272BC RID: 160444
		public const int TextMosaicSprite = 10;
	}
}
