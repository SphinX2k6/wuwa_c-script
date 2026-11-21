using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Personal;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020005A1 RID: 1441
public class ArtemisChatRightItem : UiPanelBase
{
	// Token: 0x0600448F RID: 17551 RVA: 0x001799E0 File Offset: 0x00177BE0
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

	// Token: 0x06004490 RID: 17552 RVA: 0x00179AF8 File Offset: 0x00177CF8
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

	// Token: 0x06004491 RID: 17553 RVA: 0x00179B50 File Offset: 0x00177D50
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

	// Token: 0x06004492 RID: 17554 RVA: 0x00179C08 File Offset: 0x00177E08
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

	// Token: 0x06004493 RID: 17555 RVA: 0x00179C90 File Offset: 0x00177E90
	private void OnClickPictureButton()
	{
		if (!string.IsNullOrEmpty(this.TexturePath))
		{
			InfoDisplayModel.Instance.SetCurrentOpenInformationTexture(this.TexturePath);
			InfoDisplayController.Instance.OpenInfoDisplayImgView();
		}
	}

	// Token: 0x040034ED RID: 13549
	[Nullable(2)]
	private string TexturePath;

	// Token: 0x02006845 RID: 26693
	private class EComponents
	{
		// Token: 0x0402260C RID: 140812
		public const int TxtTime = 0;

		// Token: 0x0402260D RID: 140813
		public const int TextureHead = 1;

		// Token: 0x0402260E RID: 140814
		public const int TxtPlayerName = 2;

		// Token: 0x0402260F RID: 140815
		public const int PnlChatContent = 3;

		// Token: 0x04022610 RID: 140816
		public const int TxtChat = 4;

		// Token: 0x04022611 RID: 140817
		public const int SpriteIconState = 5;

		// Token: 0x04022612 RID: 140818
		public const int TextureChatEmote = 6;

		// Token: 0x04022613 RID: 140819
		public const int PnlInput = 7;

		// Token: 0x04022614 RID: 140820
		public const int BtnPic = 8;

		// Token: 0x04022615 RID: 140821
		public const int TextPic = 9;
	}
}
