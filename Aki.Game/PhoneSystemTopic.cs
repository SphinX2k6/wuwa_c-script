using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.PhoneMessage;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002546 RID: 9542
[NullableContext(2)]
[Nullable(0)]
public class PhoneSystemTopic : UiPanelBase
{
	// Token: 0x06013375 RID: 78709 RVA: 0x004C6CB4 File Offset: 0x004C4EB4
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUITexture)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIText)),
			new ValueTuple<int, Type>(4, typeof(UUIText)),
			new ValueTuple<int, Type>(5, typeof(UUIText)),
			new ValueTuple<int, Type>(6, typeof(UUIText)),
			new ValueTuple<int, Type>(7, typeof(UUIText)),
			new ValueTuple<int, Type>(8, typeof(UUIText)),
			new ValueTuple<int, Type>(9, typeof(UUITexture)),
			new ValueTuple<int, Type>(10, typeof(UUIItem)),
			new ValueTuple<int, Type>(11, typeof(UUITexture)),
			new ValueTuple<int, Type>(12, typeof(UUIItem)),
			new ValueTuple<int, Type>(13, typeof(UUITexture)),
			new ValueTuple<int, Type>(14, typeof(UUIItem)),
			new ValueTuple<int, Type>(15, typeof(UUISprite)),
			new ValueTuple<int, Type>(16, typeof(UUITexture)),
			new ValueTuple<int, Type>(17, typeof(UUISprite)),
			new ValueTuple<int, Type>(18, typeof(UUITexture)),
			new ValueTuple<int, Type>(19, typeof(UUITexture)),
			new ValueTuple<int, Type>(20, typeof(UUITexture)),
			new ValueTuple<int, Type>(21, typeof(UUITexture)),
			new ValueTuple<int, Type>(22, typeof(UUITexture)),
			new ValueTuple<int, Type>(23, typeof(UUIItem)),
			new ValueTuple<int, Type>(24, typeof(UUISprite))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>();
	}

	// Token: 0x06013376 RID: 78710 RVA: 0x004C6F10 File Offset: 0x004C5110
	protected override UniTask OnBeforeStartAsync()
	{
		PhoneSystemTopic.<OnBeforeStartAsync>d__17 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<PhoneSystemTopic.<OnBeforeStartAsync>d__17>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06013377 RID: 78711 RVA: 0x004C6F54 File Offset: 0x004C5154
	[NullableContext(1)]
	public void SetChatBg(string chatBgPath)
	{
		UUITexture texture = base.GetTexture(0);
		base.SetTextureByPath(chatBgPath, texture, null, null);
	}

	// Token: 0x06013378 RID: 78712 RVA: 0x004C6F7C File Offset: 0x004C517C
	public void SetSpineByCharmId(int charmId)
	{
		ChatCharm? chatCharmConfig = PhoneMsgConfig.Instance.GetChatCharmConfig(charmId);
		if (chatCharmConfig == null)
		{
			return;
		}
		string spinepre = chatCharmConfig.Value.Spinepre;
		UUIItem item = base.GetItem(23);
		if (item == null)
		{
			return;
		}
		if (spinepre == "")
		{
			if (item != null)
			{
				item.SetUIActive(false);
			}
			PhoneSystemCharm charmPanel = this.CharmPanel;
			if (charmPanel == null)
			{
				return;
			}
			charmPanel.SetActive(false);
			return;
		}
		else
		{
			if (item != null)
			{
				item.SetUIActive(true);
			}
			if (this.charmPrepath != spinepre)
			{
				PhoneSystemCharm charmPanel2 = this.CharmPanel;
				if (charmPanel2 != null)
				{
					charmPanel2.Destroy(null);
				}
				this.CharmPanel = new PhoneSystemCharm();
				this.charmPrepath = spinepre;
				this.CreateCharmAndPlayAsync(spinepre, item, charmId);
				return;
			}
			PhoneSystemCharm charmPanel3 = this.CharmPanel;
			if (charmPanel3 != null)
			{
				charmPanel3.SetActive(true);
			}
			PhoneSystemCharm charmPanel4 = this.CharmPanel;
			if (charmPanel4 == null)
			{
				return;
			}
			charmPanel4.Play(charmId);
			return;
		}
	}

	// Token: 0x06013379 RID: 78713 RVA: 0x004C7050 File Offset: 0x004C5250
	[NullableContext(1)]
	private UniTask CreateCharmAndPlayAsync(string spinepre, UUIItem petItem, int charmId)
	{
		PhoneSystemTopic.<CreateCharmAndPlayAsync>d__20 <CreateCharmAndPlayAsync>d__;
		<CreateCharmAndPlayAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateCharmAndPlayAsync>d__.<>4__this = this;
		<CreateCharmAndPlayAsync>d__.spinepre = spinepre;
		<CreateCharmAndPlayAsync>d__.petItem = petItem;
		<CreateCharmAndPlayAsync>d__.charmId = charmId;
		<CreateCharmAndPlayAsync>d__.<>1__state = -1;
		<CreateCharmAndPlayAsync>d__.<>t__builder.Start<PhoneSystemTopic.<CreateCharmAndPlayAsync>d__20>(ref <CreateCharmAndPlayAsync>d__);
		return <CreateCharmAndPlayAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0601337A RID: 78714 RVA: 0x004C70AB File Offset: 0x004C52AB
	public void TriggerCharmInteract()
	{
		PhoneSystemCharm charmPanel = this.CharmPanel;
		if (charmPanel == null)
		{
			return;
		}
		charmPanel.TriggerInteract();
	}

	// Token: 0x0601337B RID: 78715 RVA: 0x004C70C0 File Offset: 0x004C52C0
	protected override void OnBeforeDestroy()
	{
		PhoneSystemCharm charmPanel = this.CharmPanel;
		if (charmPanel != null)
		{
			charmPanel.Destroy(null);
		}
		this.CharmPanel = null;
		LevelSequencePlayer levelSequencePlayer = this.title1SeqPlayer;
		if (levelSequencePlayer != null)
		{
			levelSequencePlayer.Clear();
		}
		this.title1SeqPlayer = null;
		LevelSequencePlayer levelSequencePlayer2 = this.title2SeqPlayer;
		if (levelSequencePlayer2 != null)
		{
			levelSequencePlayer2.Clear();
		}
		this.title2SeqPlayer = null;
	}

	// Token: 0x0601337C RID: 78716 RVA: 0x004C7118 File Offset: 0x004C5318
	public void RefreshThemeId(int themeId)
	{
		ChatTheme? chatThemeConfig = PhoneMsgConfig.Instance.GetChatThemeConfig(themeId);
		if (chatThemeConfig == null)
		{
			return;
		}
		this.SetTopicTexture(themeId);
		string text = chatThemeConfig.Value.TogChatItemATextcol(3);
		string text2 = chatThemeConfig.Value.TogChatItemATextcol(0);
		string text3 = chatThemeConfig.Value.TogChatItemBTextcol(3);
		string text4 = chatThemeConfig.Value.TogChatItemBTextcol(0);
		string txtTitle = chatThemeConfig.Value.TxtTitle1;
		string txtTitle2 = chatThemeConfig.Value.TxtTitle2;
		if (text != "")
		{
			base.GetText(4).SetColor(FColor.FromHex(text));
		}
		if (text2 != "")
		{
			base.GetText(7).SetColor(FColor.FromHex(text2));
		}
		if (text3 != "")
		{
			base.GetText(5).SetColor(FColor.FromHex(text3));
		}
		if (text4 != "")
		{
			base.GetText(6).SetColor(FColor.FromHex(text4));
		}
		if (txtTitle != "")
		{
			base.GetText(3).SetColor(FColor.FromHex(txtTitle));
		}
		if (txtTitle2 != "")
		{
			base.GetText(8).SetColor(FColor.FromHex(txtTitle2));
		}
		string bgTitle = chatThemeConfig.Value.BgTitle1;
		string prefabTitle = chatThemeConfig.Value.PrefabTitle1;
		UUITexture texture = base.GetTexture(9);
		UUIItem item = base.GetItem(10);
		if (bgTitle != "" && texture != null)
		{
			base.SetTextureByPath(bgTitle, texture, null, null);
			UiPanelBase uiPanelBase = this.title1pre;
			if (uiPanelBase != null)
			{
				uiPanelBase.SetActive(false);
			}
		}
		else if (prefabTitle != "" && item != null)
		{
			if (this.title1prepath != prefabTitle)
			{
				UiPanelBase uiPanelBase2 = this.title1pre;
				if (uiPanelBase2 != null)
				{
					uiPanelBase2.Destroy(null);
				}
				this.title1pre = new UiPanelBase();
				this.CreateTitle1AndPlayAsync(prefabTitle, item);
				this.title1prepath = prefabTitle;
			}
			UiPanelBase uiPanelBase3 = this.title1pre;
			if (uiPanelBase3 != null)
			{
				uiPanelBase3.SetActive(true);
			}
			if (texture != null)
			{
				base.SetTextureByPath(PhoneMsgModel.Instance.GetEmptyTexturePath(), texture, null, null);
			}
		}
		string bgTitle2 = chatThemeConfig.Value.BgTitle2;
		string prefabTitle2 = chatThemeConfig.Value.PrefabTitle2;
		UUITexture texture2 = base.GetTexture(13);
		UUIItem item2 = base.GetItem(14);
		if (bgTitle2 != "" && texture2 != null)
		{
			base.SetTextureByPath(bgTitle2, texture2, null, null);
			UiPanelBase uiPanelBase4 = this.title2pre;
			if (uiPanelBase4 != null)
			{
				uiPanelBase4.SetActive(false);
			}
		}
		else if (prefabTitle2 != "" && item2 != null)
		{
			if (this.title2prepath != prefabTitle2)
			{
				UiPanelBase uiPanelBase5 = this.title2pre;
				if (uiPanelBase5 != null)
				{
					uiPanelBase5.Destroy(null);
				}
				this.title2pre = new UiPanelBase();
				this.CreateTitle2AndPlayAsync(prefabTitle2, item2);
				this.title2prepath = prefabTitle2;
			}
			UiPanelBase uiPanelBase6 = this.title2pre;
			if (uiPanelBase6 != null)
			{
				uiPanelBase6.SetActive(true);
			}
			if (texture2 != null)
			{
				base.SetTextureByPath(PhoneMsgModel.Instance.GetEmptyTexturePath(), texture2, null, null);
			}
		}
		string bgLeftChat = chatThemeConfig.Value.BgLeftChat;
		string prefabLeftChat = chatThemeConfig.Value.PrefabLeftChat;
		UUITexture texture3 = base.GetTexture(11);
		UUIItem item3 = base.GetItem(12);
		if (bgLeftChat != "" && texture3 != null)
		{
			base.SetTextureByPath(bgLeftChat, texture3, null, null);
			UiPanelBase uiPanelBase7 = this.leftchatpre;
			if (uiPanelBase7 != null)
			{
				uiPanelBase7.SetActive(false);
			}
		}
		else if (prefabLeftChat != "" && item3 != null)
		{
			if (this.leftchatprepath != prefabLeftChat)
			{
				UiPanelBase uiPanelBase8 = this.leftchatpre;
				if (uiPanelBase8 != null)
				{
					uiPanelBase8.Destroy(null);
				}
				this.leftchatpre = new UiPanelBase();
				this.leftchatpre.CreateThenShowByPathAsync(prefabLeftChat, item3, false);
				this.leftchatprepath = prefabLeftChat;
			}
			UiPanelBase uiPanelBase9 = this.leftchatpre;
			if (uiPanelBase9 != null)
			{
				uiPanelBase9.SetActive(true);
			}
			if (texture3 != null)
			{
				base.SetTextureByPath(PhoneMsgModel.Instance.GetEmptyTexturePath(), texture3, null, null);
			}
		}
		string bgName = chatThemeConfig.Value.BgName;
		UUISprite sprite = base.GetSprite(24);
		if (bgName != "" && sprite != null)
		{
			this.SetSpriteByPath(bgName, sprite, false, null, null);
			if (sprite != null)
			{
				sprite.SetUIActive(true);
			}
		}
		else if (sprite != null)
		{
			sprite.SetUIActive(false);
		}
		bool flag = PhoneMsgModel.Instance.IsDefaultTheme(themeId);
		UUITexture texture4 = base.GetTexture(21);
		if (texture4 != null)
		{
			texture4.SetUIActive(flag);
		}
		UUITexture texture5 = base.GetTexture(22);
		if (texture5 == null)
		{
			return;
		}
		texture5.SetUIActive(!flag);
	}

	// Token: 0x0601337D RID: 78717 RVA: 0x004C7604 File Offset: 0x004C5804
	[NullableContext(1)]
	private UniTask CreateTitle1AndPlayAsync(string prefabPath, UUIItem parentItem)
	{
		PhoneSystemTopic.<CreateTitle1AndPlayAsync>d__24 <CreateTitle1AndPlayAsync>d__;
		<CreateTitle1AndPlayAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateTitle1AndPlayAsync>d__.<>4__this = this;
		<CreateTitle1AndPlayAsync>d__.prefabPath = prefabPath;
		<CreateTitle1AndPlayAsync>d__.parentItem = parentItem;
		<CreateTitle1AndPlayAsync>d__.<>1__state = -1;
		<CreateTitle1AndPlayAsync>d__.<>t__builder.Start<PhoneSystemTopic.<CreateTitle1AndPlayAsync>d__24>(ref <CreateTitle1AndPlayAsync>d__);
		return <CreateTitle1AndPlayAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0601337E RID: 78718 RVA: 0x004C7658 File Offset: 0x004C5858
	[NullableContext(1)]
	private UniTask CreateTitle2AndPlayAsync(string prefabPath, UUIItem parentItem)
	{
		PhoneSystemTopic.<CreateTitle2AndPlayAsync>d__25 <CreateTitle2AndPlayAsync>d__;
		<CreateTitle2AndPlayAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateTitle2AndPlayAsync>d__.<>4__this = this;
		<CreateTitle2AndPlayAsync>d__.prefabPath = prefabPath;
		<CreateTitle2AndPlayAsync>d__.parentItem = parentItem;
		<CreateTitle2AndPlayAsync>d__.<>1__state = -1;
		<CreateTitle2AndPlayAsync>d__.<>t__builder.Start<PhoneSystemTopic.<CreateTitle2AndPlayAsync>d__25>(ref <CreateTitle2AndPlayAsync>d__);
		return <CreateTitle2AndPlayAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0601337F RID: 78719 RVA: 0x004C76AC File Offset: 0x004C58AC
	private void SetTopicTexture(int themeId)
	{
		ChatTheme? chatThemeConfig = PhoneMsgConfig.Instance.GetChatThemeConfig(themeId);
		if (chatThemeConfig == null)
		{
			return;
		}
		string bgSelected = chatThemeConfig.Value.BgSelected;
		UUISprite sprite = base.GetSprite(17);
		if (bgSelected != "" && sprite != null)
		{
			this.SetSpriteByPath(bgSelected, sprite, false, null, null);
		}
		string bgFilterNml = chatThemeConfig.Value.BgFilterNml;
		UUISprite sprite2 = base.GetSprite(15);
		if (bgFilterNml != "" && sprite2 != null)
		{
			this.SetSpriteByPath(bgFilterNml, sprite2, false, null, null);
		}
		string togChatItemASel = chatThemeConfig.Value.TogChatItemASel;
		UUITexture texture = base.GetTexture(16);
		if (togChatItemASel != "" && texture != null)
		{
			base.SetTextureByPath(togChatItemASel, texture, null, null);
		}
		string togChatItemBSel = chatThemeConfig.Value.TogChatItemBSel;
		UUITexture texture2 = base.GetTexture(18);
		if (togChatItemBSel != "" && texture2 != null)
		{
			base.SetTextureByPath(togChatItemBSel, texture2, null, null);
		}
		string togChatItemBNml = chatThemeConfig.Value.TogChatItemBNml;
		UUITexture texture3 = base.GetTexture(19);
		if (togChatItemBNml != "" && texture3 != null)
		{
			base.SetTextureByPath(togChatItemBNml, texture3, null, null);
		}
		string togChatItemANml = chatThemeConfig.Value.TogChatItemANml;
		UUITexture texture4 = base.GetTexture(20);
		if (togChatItemANml != "" && texture4 != null)
		{
			base.SetTextureByPath(togChatItemANml, texture4, null, null);
		}
	}

	// Token: 0x0400911B RID: 37147
	public SettingPanelChatItem LeftChatItem;

	// Token: 0x0400911C RID: 37148
	public SettingPanelChatRightItem RightChatItem;

	// Token: 0x0400911D RID: 37149
	private PhoneSystemCharm CharmPanel;

	// Token: 0x0400911E RID: 37150
	private string charmPrepath = "";

	// Token: 0x0400911F RID: 37151
	private UiPanelBase title1pre;

	// Token: 0x04009120 RID: 37152
	private UiPanelBase title2pre;

	// Token: 0x04009121 RID: 37153
	private UiPanelBase leftchatpre;

	// Token: 0x04009122 RID: 37154
	private UiPanelBase rightchatpre;

	// Token: 0x04009123 RID: 37155
	[Nullable(1)]
	private string title1prepath = "";

	// Token: 0x04009124 RID: 37156
	private string title2prepath = "";

	// Token: 0x04009125 RID: 37157
	private string leftchatprepath = "";

	// Token: 0x04009126 RID: 37158
	private string rightchatprepath = "";

	// Token: 0x04009127 RID: 37159
	private LevelSequencePlayer title1SeqPlayer;

	// Token: 0x04009128 RID: 37160
	private LevelSequencePlayer title2SeqPlayer;

	// Token: 0x04009129 RID: 37161
	[Nullable(1)]
	private string currenttitlepre = "";

	// Token: 0x02008B00 RID: 35584
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x0402D210 RID: 184848
		TexChatBg,
		// Token: 0x0402D211 RID: 184849
		LeftChatItem,
		// Token: 0x0402D212 RID: 184850
		RightChatItem,
		// Token: 0x0402D213 RID: 184851
		TexTitle,
		// Token: 0x0402D214 RID: 184852
		TogATxt,
		// Token: 0x0402D215 RID: 184853
		TogATxt1,
		// Token: 0x0402D216 RID: 184854
		TogATxt2,
		// Token: 0x0402D217 RID: 184855
		TogBTxt,
		// Token: 0x0402D218 RID: 184856
		TexTitleR,
		// Token: 0x0402D219 RID: 184857
		TexModelT,
		// Token: 0x0402D21A RID: 184858
		TexModelTPrefab,
		// Token: 0x0402D21B RID: 184859
		TexSkinL,
		// Token: 0x0402D21C RID: 184860
		TexSkinLPrefab,
		// Token: 0x0402D21D RID: 184861
		TexSkinRT,
		// Token: 0x0402D21E RID: 184862
		TexSkinRTPrefab,
		// Token: 0x0402D21F RID: 184863
		TexFitter,
		// Token: 0x0402D220 RID: 184864
		Item1,
		// Token: 0x0402D221 RID: 184865
		TexSelected,
		// Token: 0x0402D222 RID: 184866
		Item2,
		// Token: 0x0402D223 RID: 184867
		Item3,
		// Token: 0x0402D224 RID: 184868
		Item4,
		// Token: 0x0402D225 RID: 184869
		TexSkinR,
		// Token: 0x0402D226 RID: 184870
		TexSkinRTopicShow,
		// Token: 0x0402D227 RID: 184871
		PnlPetContent,
		// Token: 0x0402D228 RID: 184872
		SprTxtNameRBg
	}
}
