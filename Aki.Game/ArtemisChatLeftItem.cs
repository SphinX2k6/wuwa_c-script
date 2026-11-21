using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020005A0 RID: 1440
[NullableContext(2)]
[Nullable(0)]
public class ArtemisChatLeftItem : UiPanelBase
{
	// Token: 0x06004482 RID: 17538 RVA: 0x00179508 File Offset: 0x00177708
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

	// Token: 0x06004483 RID: 17539 RVA: 0x00179638 File Offset: 0x00177838
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

	// Token: 0x06004484 RID: 17540 RVA: 0x001796C3 File Offset: 0x001778C3
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

	// Token: 0x06004485 RID: 17541 RVA: 0x001796F3 File Offset: 0x001778F3
	[NullableContext(1)]
	private void OnPlaySequenceEvent(string sequenceName, string eventName)
	{
		if (eventName == "Dele_M")
		{
			this.LoadTextMaterial(false);
			this.RefreshPlayerTextureCustomMaterial(this.TexturePath, false).Forget();
		}
	}

	// Token: 0x06004486 RID: 17542 RVA: 0x0017971C File Offset: 0x0017791C
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

	// Token: 0x06004487 RID: 17543 RVA: 0x00179844 File Offset: 0x00177A44
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

	// Token: 0x06004488 RID: 17544 RVA: 0x0017987C File Offset: 0x00177A7C
	private void CheckPathSetTexture(string path, int componentIndex)
	{
		string path2 = (path != null && path.Length > 0) ? path : null;
		base.TrySetTextureByPath(path2, base.GetTexture(componentIndex), null, null);
	}

	// Token: 0x06004489 RID: 17545 RVA: 0x001798B2 File Offset: 0x00177AB2
	private void OnClickPictureButton()
	{
		if (!string.IsNullOrEmpty(this.TexturePath))
		{
			InfoDisplayModel.Instance.SetCurrentOpenInformationTexture(this.TexturePath);
			InfoDisplayController.Instance.OpenInfoDisplayImgView();
		}
	}

	// Token: 0x0600448A RID: 17546 RVA: 0x001798DC File Offset: 0x00177ADC
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

	// Token: 0x0600448B RID: 17547 RVA: 0x00179930 File Offset: 0x00177B30
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

	// Token: 0x0600448C RID: 17548 RVA: 0x00179994 File Offset: 0x00177B94
	public void PlayFixDoneLevelSequence()
	{
		LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
		if (levelSequencePlayer == null)
		{
			return;
		}
		levelSequencePlayer.PlayLevelSequenceByName("Fix_Done", false, null, false);
	}

	// Token: 0x040034EB RID: 13547
	private string TexturePath;

	// Token: 0x040034EC RID: 13548
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x02006843 RID: 26691
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x040225FB RID: 140795
		public const int TxtTime = 0;

		// Token: 0x040225FC RID: 140796
		public const int TextureHead = 1;

		// Token: 0x040225FD RID: 140797
		public const int TxtPlayerName = 2;

		// Token: 0x040225FE RID: 140798
		public const int PnlChatContent = 3;

		// Token: 0x040225FF RID: 140799
		public const int TxtChat = 4;

		// Token: 0x04022600 RID: 140800
		public const int SpriteIconState = 5;

		// Token: 0x04022601 RID: 140801
		public const int TextureChatEmote = 6;

		// Token: 0x04022602 RID: 140802
		public const int PnlInput = 7;

		// Token: 0x04022603 RID: 140803
		public const int BtnPic = 8;

		// Token: 0x04022604 RID: 140804
		public const int TextPic = 9;

		// Token: 0x04022605 RID: 140805
		public const int TextMosaicSprite = 10;
	}
}
