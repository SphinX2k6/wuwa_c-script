using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.PhoneMessage;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001A31 RID: 6705
[NullableContext(2)]
[Nullable(0)]
public class PhoneSystemTopic : UiPanelBase
{
	// Token: 0x06010854 RID: 67668 RVA: 0x004D581C File Offset: 0x004D3A1C
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

	// Token: 0x06010855 RID: 67669 RVA: 0x004D5A78 File Offset: 0x004D3C78
	protected override UniTask OnBeforeStartAsync()
	{
		PhoneSystemTopic.<OnBeforeStartAsync>d__17 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<PhoneSystemTopic.<OnBeforeStartAsync>d__17>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06010856 RID: 67670 RVA: 0x004D5ABC File Offset: 0x004D3CBC
	[NullableContext(1)]
	public void SetChatBg(string chatBgPath)
	{
		UUITexture texture = base.GetTexture(0);
		base.SetTextureByPath(chatBgPath, texture, null, null);
	}

	// Token: 0x06010857 RID: 67671 RVA: 0x004D5AE4 File Offset: 0x004D3CE4
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

	// Token: 0x06010858 RID: 67672 RVA: 0x004D5BB8 File Offset: 0x004D3DB8
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

	// Token: 0x06010859 RID: 67673 RVA: 0x004D5C13 File Offset: 0x004D3E13
	public void TriggerCharmInteract()
	{
		PhoneSystemCharm charmPanel = this.CharmPanel;
		if (charmPanel == null)
		{
			return;
		}
		charmPanel.TriggerInteract();
	}

	// Token: 0x0601085A RID: 67674 RVA: 0x004D5C28 File Offset: 0x004D3E28
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

	// Token: 0x0601085B RID: 67675 RVA: 0x004D5C80 File Offset: 0x004D3E80
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

	// Token: 0x0601085C RID: 67676 RVA: 0x004D616C File Offset: 0x004D436C
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

	// Token: 0x0601085D RID: 67677 RVA: 0x004D61C0 File Offset: 0x004D43C0
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

	// Token: 0x0601085E RID: 67678 RVA: 0x004D6214 File Offset: 0x004D4414
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

	// Token: 0x04009274 RID: 37492
	public SettingPanelChatItem LeftChatItem;

	// Token: 0x04009275 RID: 37493
	public SettingPanelChatRightItem RightChatItem;

	// Token: 0x04009276 RID: 37494
	private PhoneSystemCharm CharmPanel;

	// Token: 0x04009277 RID: 37495
	private string charmPrepath = "";

	// Token: 0x04009278 RID: 37496
	private UiPanelBase title1pre;

	// Token: 0x04009279 RID: 37497
	private UiPanelBase title2pre;

	// Token: 0x0400927A RID: 37498
	private UiPanelBase leftchatpre;

	// Token: 0x0400927B RID: 37499
	private UiPanelBase rightchatpre;

	// Token: 0x0400927C RID: 37500
	[Nullable(1)]
	private string title1prepath = "";

	// Token: 0x0400927D RID: 37501
	private string title2prepath = "";

	// Token: 0x0400927E RID: 37502
	private string leftchatprepath = "";

	// Token: 0x0400927F RID: 37503
	private string rightchatprepath = "";

	// Token: 0x04009280 RID: 37504
	private LevelSequencePlayer title1SeqPlayer;

	// Token: 0x04009281 RID: 37505
	private LevelSequencePlayer title2SeqPlayer;

	// Token: 0x04009282 RID: 37506
	[Nullable(1)]
	private string currenttitlepre = "";

	// Token: 0x02007C86 RID: 31878
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x0402851F RID: 165151
		TexChatBg,
		// Token: 0x04028520 RID: 165152
		LeftChatItem,
		// Token: 0x04028521 RID: 165153
		RightChatItem,
		// Token: 0x04028522 RID: 165154
		TexTitle,
		// Token: 0x04028523 RID: 165155
		TogATxt,
		// Token: 0x04028524 RID: 165156
		TogATxt1,
		// Token: 0x04028525 RID: 165157
		TogATxt2,
		// Token: 0x04028526 RID: 165158
		TogBTxt,
		// Token: 0x04028527 RID: 165159
		TexTitleR,
		// Token: 0x04028528 RID: 165160
		TexModelT,
		// Token: 0x04028529 RID: 165161
		TexModelTPrefab,
		// Token: 0x0402852A RID: 165162
		TexSkinL,
		// Token: 0x0402852B RID: 165163
		TexSkinLPrefab,
		// Token: 0x0402852C RID: 165164
		TexSkinRT,
		// Token: 0x0402852D RID: 165165
		TexSkinRTPrefab,
		// Token: 0x0402852E RID: 165166
		TexFitter,
		// Token: 0x0402852F RID: 165167
		Item1,
		// Token: 0x04028530 RID: 165168
		TexSelected,
		// Token: 0x04028531 RID: 165169
		Item2,
		// Token: 0x04028532 RID: 165170
		Item3,
		// Token: 0x04028533 RID: 165171
		Item4,
		// Token: 0x04028534 RID: 165172
		TexSkinR,
		// Token: 0x04028535 RID: 165173
		TexSkinRTopicShow,
		// Token: 0x04028536 RID: 165174
		PnlPetContent,
		// Token: 0x04028537 RID: 165175
		SprTxtNameRBg
	}
}
