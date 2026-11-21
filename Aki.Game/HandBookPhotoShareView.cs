using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020012CE RID: 4814
public class HandBookPhotoShareView : UiPanelBase
{
	// Token: 0x0600BE14 RID: 48660 RVA: 0x003818C8 File Offset: 0x0037FAC8
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUITexture)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIText)),
			new ValueTuple<int, Type>(5, typeof(UUIArtText)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIItem))
		};
	}

	// Token: 0x0600BE15 RID: 48661 RVA: 0x00381964 File Offset: 0x0037FB64
	protected override void OnBeforeShowImplement()
	{
		EventSystem.Instance.Add(EEventName.OnPhotoSaveViewPersonalInfoShowRefresh, new Action(this.OnPersonalInfoShowRefresh));
	}

	// Token: 0x0600BE16 RID: 48662 RVA: 0x00381982 File Offset: 0x0037FB82
	protected override void OnAfterHideImplement()
	{
		EventSystem.Instance.Remove(EEventName.OnPhotoSaveViewPersonalInfoShowRefresh, new Action(this.OnPersonalInfoShowRefresh));
	}

	// Token: 0x0600BE17 RID: 48663 RVA: 0x003819A0 File Offset: 0x0037FBA0
	private void OnPersonalInfoShowRefresh()
	{
		this.UpdatePersonalInfoShowView();
	}

	// Token: 0x0600BE18 RID: 48664 RVA: 0x003819A8 File Offset: 0x0037FBA8
	private void UpdatePersonalInfoShowView()
	{
		bool global = LocalStorage.GetGlobal<bool>(ELocalStorageGlobalKey.PhotoAndShareShowPlayerName, true);
		base.GetItem(1).SetUIActive(global);
		base.GetItem(4).SetUIActive(global);
	}

	// Token: 0x0600BE19 RID: 48665 RVA: 0x003819D8 File Offset: 0x0037FBD8
	protected override void OnStart()
	{
		this.HandBookPhotoData = (this.OpenParam as HandBookPhotoData);
		if (this.HandBookPhotoData == null)
		{
			return;
		}
		int index = this.HandBookPhotoData.Index;
		base.GetText(2).SetText(this.HandBookPhotoData.TypeText[index], true);
		base.GetText(3).SetText(this.HandBookPhotoData.NameText[index], true);
		EHandBookTabType handBookType = this.HandBookPhotoData.HandBookType;
		int id = this.HandBookPhotoData.ConfigId[index];
		HandBookEntry handBookInfo = HandBookModel.Instance.GetHandBookInfo(handBookType, id);
		string text = TimeUtil.Instance.DateFormat9String(handBookInfo.CreateTimeStampSecond);
		UUIArtText artText = base.GetArtText(5);
		if (artText != null)
		{
			artText.SetText(text);
		}
		UUITexture texture = base.GetTexture(0);
		base.SetTextureByPath(this.HandBookPhotoData.TextureList[index], texture, null, null);
		this.UpdatePersonalInfoShowView();
	}

	// Token: 0x04006D6A RID: 28010
	[Nullable(2)]
	private HandBookPhotoData HandBookPhotoData;

	// Token: 0x0200754D RID: 30029
	private enum EComponents
	{
		// Token: 0x040261A9 RID: 156073
		Texture,
		// Token: 0x040261AA RID: 156074
		TitleItem,
		// Token: 0x040261AB RID: 156075
		TypeText,
		// Token: 0x040261AC RID: 156076
		NameText,
		// Token: 0x040261AD RID: 156077
		DateItem,
		// Token: 0x040261AE RID: 156078
		DateArtText
	}
}
