using System;
using System.Collections.Generic;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200251E RID: 9502
public class SettingPanelChatItem : UiPanelBase
{
	// Token: 0x060131D5 RID: 78293 RVA: 0x004BEC74 File Offset: 0x004BCE74
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUITexture)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIText)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUITexture)),
			new ValueTuple<int, Type>(7, typeof(UUIItem)),
			new ValueTuple<int, Type>(8, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(9, typeof(UUITexture)),
			new ValueTuple<int, Type>(10, typeof(UUISprite)),
			new ValueTuple<int, Type>(11, typeof(UUIText))
		};
	}

	// Token: 0x060131D6 RID: 78294 RVA: 0x004BED98 File Offset: 0x004BCF98
	public void RefreshSpeakerNameTextColor(int bgId)
	{
		bool flag = PhoneMsgModel.Instance.IsDefaultChatBg(bgId);
		base.GetText(2).SetUIActive(flag);
		UUIText text = base.GetText(11);
		if (text == null)
		{
			return;
		}
		text.SetUIActive(!flag);
	}

	// Token: 0x060131D7 RID: 78295 RVA: 0x004BEDD4 File Offset: 0x004BCFD4
	public void OnNameChange()
	{
		string text = FunctionModel.Instance.GetPlayerName() ?? "";
		if (!string.IsNullOrEmpty(text))
		{
			base.GetText(2).SetText(text, true);
			UUIText text2 = base.GetText(11);
			if (text2 != null)
			{
				text2.SetText(text, true);
			}
		}
	}
}
