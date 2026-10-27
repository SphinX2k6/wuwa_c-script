using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Personal;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020010ED RID: 4333
public class ArtemisChatRightItem : UiPanelBase
{
	// Token: 0x060070F9 RID: 28921 RVA: 0x00171024 File Offset: 0x0016F224
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
			new ValueTuple<int, Type>(9, typeof(UUITexture))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(8, new Action(this.OnClickPictureButton))
		};
	}

	// Token: 0x060070FA RID: 28922 RVA: 0x0017113C File Offset: 0x0016F33C
	protected override void OnStart()
	{
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

	// Token: 0x060070FB RID: 28923 RVA: 0x00171194 File Offset: 0x0016F394
	[NullableContext(1)]
	public void SetContent(IArtemisChatItemData data)
	{
		this.SetPlayerHead();
		base.GetUiSizeControlByOther(3).GetRootComponent().SetUIActive(!string.IsNullOrEmpty(data.Content));
		if (!string.IsNullOrEmpty(data.Content))
		{
			UUIText text = base.GetText(4);
			if (text != null)
			{
				text.ShowTextNew(data.Content);
			}
		}
		bool flag = !string.IsNullOrEmpty(data.PicturePath);
		this.TexturePath = data.PicturePath;
		UUIButtonComponent button = base.GetButton(8);
		if (button != null)
		{
			button.RootUIComp.Get().SetUIActive(flag);
		}
		string path = flag ? null : data.PicturePath;
		base.TrySetTextureByPath(path, base.GetTexture(9), null, null);
	}

	// Token: 0x060070FC RID: 28924 RVA: 0x0017124C File Offset: 0x0016F44C
	private void SetPlayerHead()
	{
		int? numberPropById = PlayerInfoModel.Instance.GetNumberPropById(EPlayerInfoNumber.HeadPhoto);
		PlayerHeadData playerHeadData = PersonalModel.Instance.GetPlayerHeadData(numberPropById.GetValueOrDefault(), true);
		UUITexture headTexture = base.GetTexture(1);
		UUITexture headTexture3 = headTexture;
		if (headTexture3 != null)
		{
			headTexture3.SetUIActive(false);
		}
		if (playerHeadData != null)
		{
			base.SetTextureShowUntilLoaded(playerHeadData.GetRoleHeadIconCircle(), headTexture, delegate(bool _)
			{
				UUITexture headTexture2 = headTexture;
				if (headTexture2 == null)
				{
					return;
				}
				headTexture2.SetUIActive(true);
			});
			UUIText text = base.GetText(2);
			if (text == null)
			{
				return;
			}
			text.ShowTextNew("Activity_ArtemisChatRoverName");
		}
	}

	// Token: 0x060070FD RID: 28925 RVA: 0x001712D4 File Offset: 0x0016F4D4
	private void OnClickPictureButton()
	{
		if (!string.IsNullOrEmpty(this.TexturePath))
		{
			InfoDisplayModel.Instance.SetCurrentOpenInformationTexture(this.TexturePath);
			InfoDisplayController.Instance.OpenInfoDisplayImgView();
		}
	}

	// Token: 0x04003454 RID: 13396
	[Nullable(2)]
	private string TexturePath;

	// Token: 0x020076B1 RID: 30385
	private class EComponents
	{
		// Token: 0x040272C3 RID: 160451
		public const int TxtTime = 0;

		// Token: 0x040272C4 RID: 160452
		public const int TextureHead = 1;

		// Token: 0x040272C5 RID: 160453
		public const int TxtPlayerName = 2;

		// Token: 0x040272C6 RID: 160454
		public const int PnlChatContent = 3;

		// Token: 0x040272C7 RID: 160455
		public const int TxtChat = 4;

		// Token: 0x040272C8 RID: 160456
		public const int SpriteIconState = 5;

		// Token: 0x040272C9 RID: 160457
		public const int TextureChatEmote = 6;

		// Token: 0x040272CA RID: 160458
		public const int PnlInput = 7;

		// Token: 0x040272CB RID: 160459
		public const int BtnPic = 8;

		// Token: 0x040272CC RID: 160460
		public const int TextPic = 9;
	}
}
