using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001E0C RID: 7692
public class HandBookPhotoShareView : UiPanelBase
{
	// Token: 0x0600E9F5 RID: 59893 RVA: 0x00375BC0 File Offset: 0x00373DC0
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

	// Token: 0x0600E9F6 RID: 59894 RVA: 0x00375C5C File Offset: 0x00373E5C
	protected override void OnBeforeShowImplement()
	{
		EventSystem.Instance.Add(EEventName.OnPhotoSaveViewPersonalInfoShowRefresh, new Action(this.OnPersonalInfoShowRefresh));
	}

	// Token: 0x0600E9F7 RID: 59895 RVA: 0x00375C7A File Offset: 0x00373E7A
	protected override void OnAfterHideImplement()
	{
		EventSystem.Instance.Remove(EEventName.OnPhotoSaveViewPersonalInfoShowRefresh, new Action(this.OnPersonalInfoShowRefresh));
	}

	// Token: 0x0600E9F8 RID: 59896 RVA: 0x00375C98 File Offset: 0x00373E98
	private void OnPersonalInfoShowRefresh()
	{
		this.UpdatePersonalInfoShowView();
	}

	// Token: 0x0600E9F9 RID: 59897 RVA: 0x00375CA0 File Offset: 0x00373EA0
	private void UpdatePersonalInfoShowView()
	{
		bool global = LocalStorage.GetGlobal<bool>(ELocalStorageGlobalKey.PhotoAndShareShowPlayerName, true);
		base.GetItem(1).SetUIActive(global);
		base.GetItem(4).SetUIActive(global);
	}

	// Token: 0x0600E9FA RID: 59898 RVA: 0x00375CD0 File Offset: 0x00373ED0
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

	// Token: 0x04006C89 RID: 27785
	[Nullable(2)]
	private HandBookPhotoData HandBookPhotoData;

	// Token: 0x020083C8 RID: 33736
	private enum EComponents
	{
		// Token: 0x0402AE86 RID: 175750
		Texture,
		// Token: 0x0402AE87 RID: 175751
		TitleItem,
		// Token: 0x0402AE88 RID: 175752
		TypeText,
		// Token: 0x0402AE89 RID: 175753
		NameText,
		// Token: 0x0402AE8A RID: 175754
		DateItem,
		// Token: 0x0402AE8B RID: 175755
		DateArtText
	}
}
