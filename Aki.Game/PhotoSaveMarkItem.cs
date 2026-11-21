using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001AC6 RID: 6854
public class PhotoSaveMarkItem : UiPanelBase
{
	// Token: 0x06010FDF RID: 69599 RVA: 0x004FCA60 File Offset: 0x004FAC60
	protected override void OnRegisterComponent()
	{
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUITexture)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIText))
		};
		if (!string.IsNullOrEmpty(this.DateText))
		{
			list.Add(new ValueTuple<int, Type>(3, typeof(UUIText)));
		}
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06010FE0 RID: 69600 RVA: 0x004FCAE0 File Offset: 0x004FACE0
	protected override void OnStart()
	{
		string logoPathByLanguage = UiResourceConfig.Instance.GetLogoPathByLanguage(this.LogoConfigName);
		UUITexture logoTexture = base.GetTexture(0);
		logoTexture.SetUIActive(false);
		base.SetTextureByPath(logoPathByLanguage, base.GetTexture(0), null, delegate(bool _)
		{
			if (logoTexture == null)
			{
				return;
			}
			logoTexture.SetUIActive(true);
			logoTexture.SetSizeFromTexture();
		});
		base.GetText(1).SetText(FunctionModel.Instance.GetPlayerName() ?? "", true);
		LguiUtil.Instance.SetLocalText(base.GetText(2), "FriendMyUid", new <>z__ReadOnlySingleElementList<object>(FunctionModel.Instance.PlayerId));
		UUIText text = base.GetText(3);
		if (!string.IsNullOrEmpty(this.DateText) && text != null)
		{
			text.SetText(this.DateText, true);
		}
	}

	// Token: 0x06010FE1 RID: 69601 RVA: 0x004FCBB0 File Offset: 0x004FADB0
	protected override void OnAfterShow()
	{
		bool global = LocalStorage.GetGlobal<bool>(ELocalStorageGlobalKey.PhotoAndShareShowPlayerName, true);
		base.SetUiActive(global);
	}

	// Token: 0x040095A2 RID: 38306
	[Nullable(2)]
	public string DateText;

	// Token: 0x040095A3 RID: 38307
	[Nullable(1)]
	public string LogoConfigName = "PhotoLogo";

	// Token: 0x02007D82 RID: 32130
	private enum EChildType
	{
		// Token: 0x04028A2B RID: 166443
		LogoTexture,
		// Token: 0x04028A2C RID: 166444
		PlayerNameText,
		// Token: 0x04028A2D RID: 166445
		PlayerUidText,
		// Token: 0x04028A2E RID: 166446
		DateText
	}
}
