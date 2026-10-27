using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020025DB RID: 9691
public class PhotoSaveMarkItem : UiPanelBase
{
	// Token: 0x06013AFF RID: 80639 RVA: 0x004EDE04 File Offset: 0x004EC004
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

	// Token: 0x06013B00 RID: 80640 RVA: 0x004EDE84 File Offset: 0x004EC084
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

	// Token: 0x06013B01 RID: 80641 RVA: 0x004EDF54 File Offset: 0x004EC154
	protected override void OnAfterShow()
	{
		bool global = LocalStorage.GetGlobal<bool>(ELocalStorageGlobalKey.PhotoAndShareShowPlayerName, true);
		base.SetUiActive(global);
	}

	// Token: 0x0400944C RID: 37964
	[Nullable(2)]
	public string DateText;

	// Token: 0x0400944D RID: 37965
	[Nullable(1)]
	public string LogoConfigName = "PhotoLogo";

	// Token: 0x02008BFA RID: 35834
	private enum EChildType
	{
		// Token: 0x0402D716 RID: 186134
		LogoTexture,
		// Token: 0x0402D717 RID: 186135
		PlayerNameText,
		// Token: 0x0402D718 RID: 186136
		PlayerUidText,
		// Token: 0x0402D719 RID: 186137
		DateText
	}
}
