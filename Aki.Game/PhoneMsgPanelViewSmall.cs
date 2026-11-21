using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.PhoneMessage;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001A01 RID: 6657
[NullableContext(2)]
[Nullable(0)]
public class PhoneMsgPanelViewSmall : UiViewBase
{
	// Token: 0x0601063B RID: 67131 RVA: 0x004C9AA4 File Offset: 0x004C7CA4
	[NullableContext(1)]
	public PhoneMsgPanelViewSmall(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0601063C RID: 67132 RVA: 0x004C9AD0 File Offset: 0x004C7CD0
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(1, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUITexture)),
			new ValueTuple<int, Type>(5, typeof(UUIText)),
			new ValueTuple<int, Type>(6, typeof(UUIItem)),
			new ValueTuple<int, Type>(7, typeof(UUITexture)),
			new ValueTuple<int, Type>(8, typeof(UUITexture)),
			new ValueTuple<int, Type>(9, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(1, new Action(this.OnClickCloseBtn))
		};
	}

	// Token: 0x0601063D RID: 67133 RVA: 0x004C9BE8 File Offset: 0x004C7DE8
	protected override UniTask OnBeforeStartAsync()
	{
		PhoneMsgPanelViewSmall.<OnBeforeStartAsync>d__14 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<PhoneMsgPanelViewSmall.<OnBeforeStartAsync>d__14>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0601063E RID: 67134 RVA: 0x004C9C2C File Offset: 0x004C7E2C
	private UniTask LoadChatDataAsync()
	{
		PhoneMsgPanelViewSmall.<LoadChatDataAsync>d__15 <LoadChatDataAsync>d__;
		<LoadChatDataAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<LoadChatDataAsync>d__.<>4__this = this;
		<LoadChatDataAsync>d__.<>1__state = -1;
		<LoadChatDataAsync>d__.<>t__builder.Start<PhoneMsgPanelViewSmall.<LoadChatDataAsync>d__15>(ref <LoadChatDataAsync>d__);
		return <LoadChatDataAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0601063F RID: 67135 RVA: 0x004C9C6F File Offset: 0x004C7E6F
	protected override void OnStart()
	{
	}

	// Token: 0x06010640 RID: 67136 RVA: 0x004C9C71 File Offset: 0x004C7E71
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnPhoneMsgChatShowChange, new Action(this.RefreshChatShow));
	}

	// Token: 0x06010641 RID: 67137 RVA: 0x004C9C8F File Offset: 0x004C7E8F
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnPhoneMsgChatShowChange, new Action(this.RefreshChatShow));
	}

	// Token: 0x06010642 RID: 67138 RVA: 0x004C9CAD File Offset: 0x004C7EAD
	protected override void OnBeforeShow()
	{
		GameSettingsDeviceRender.Instance.TemporaryDisableFrameGeneration("PhoneMsgPanelViewSmall");
		this.RefreshChatShow();
	}

	// Token: 0x06010643 RID: 67139 RVA: 0x004C9CC4 File Offset: 0x004C7EC4
	private void RefreshChatShow()
	{
		this.RefreshByTheme(PhoneMsgModel.Instance.CurrentUsingChatThemeId);
		this.SetSpineByCharmId(PhoneMsgModel.Instance.CurrentUsingChatCharmId);
	}

	// Token: 0x06010644 RID: 67140 RVA: 0x004C9CE8 File Offset: 0x004C7EE8
	public void SetSpineByCharmId(int charmId)
	{
		ChatCharm? chatCharmConfig = PhoneMsgConfig.Instance.GetChatCharmConfig(charmId);
		if (chatCharmConfig == null)
		{
			return;
		}
		string spinepre = chatCharmConfig.Value.Spinepre;
		UUIItem item = base.GetItem(9);
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

	// Token: 0x06010645 RID: 67141 RVA: 0x004C9DBC File Offset: 0x004C7FBC
	[NullableContext(1)]
	private UniTask CreateCharmAndPlayAsync(string spinepre, UUIItem petItem, int charmId)
	{
		PhoneMsgPanelViewSmall.<CreateCharmAndPlayAsync>d__22 <CreateCharmAndPlayAsync>d__;
		<CreateCharmAndPlayAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateCharmAndPlayAsync>d__.<>4__this = this;
		<CreateCharmAndPlayAsync>d__.spinepre = spinepre;
		<CreateCharmAndPlayAsync>d__.petItem = petItem;
		<CreateCharmAndPlayAsync>d__.charmId = charmId;
		<CreateCharmAndPlayAsync>d__.<>1__state = -1;
		<CreateCharmAndPlayAsync>d__.<>t__builder.Start<PhoneMsgPanelViewSmall.<CreateCharmAndPlayAsync>d__22>(ref <CreateCharmAndPlayAsync>d__);
		return <CreateCharmAndPlayAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06010646 RID: 67142 RVA: 0x004C9E18 File Offset: 0x004C8018
	private void RefreshByTheme(int themeId)
	{
		ChatTheme? chatThemeConfig = PhoneMsgConfig.Instance.GetChatThemeConfig(themeId);
		string bgTitleSmall = chatThemeConfig.Value.BgTitleSmall1;
		string prefabTitleSmall = chatThemeConfig.Value.PrefabTitleSmall1;
		UUITexture texture = base.GetTexture(4);
		UUIItem item = base.GetItem(6);
		if (bgTitleSmall != "" && texture != null)
		{
			base.SetTextureByPath(bgTitleSmall, texture, null, null);
			UiPanelBase uiPanelBase = this.title1pre;
			if (uiPanelBase != null)
			{
				uiPanelBase.SetActive(false);
			}
		}
		else if (prefabTitleSmall != "" && item != null)
		{
			if (this.title1prepath != prefabTitleSmall)
			{
				UiPanelBase uiPanelBase2 = this.title1pre;
				if (uiPanelBase2 != null)
				{
					uiPanelBase2.Destroy(null);
				}
				this.title1pre = new UiPanelBase();
				this.CreateTitle1AndPlayAsync(prefabTitleSmall, item);
				this.title1prepath = prefabTitleSmall;
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
		string txtTitle = chatThemeConfig.Value.TxtTitle1;
		UUIText text = base.GetText(5);
		if (txtTitle != "" && text != null)
		{
			text.SetColor(FColor.FromHex(txtTitle));
		}
		bool flag = PhoneMsgModel.Instance.IsDefaultTheme(themeId);
		UUITexture texture2 = base.GetTexture(7);
		if (texture2 != null)
		{
			texture2.SetUIActive(flag);
		}
		UUITexture texture3 = base.GetTexture(8);
		if (texture3 == null)
		{
			return;
		}
		texture3.SetUIActive(!flag);
	}

	// Token: 0x06010647 RID: 67143 RVA: 0x004C9F90 File Offset: 0x004C8190
	[NullableContext(1)]
	private UniTask CreateTitle1AndPlayAsync(string prefabPath, UUIItem parentItem)
	{
		PhoneMsgPanelViewSmall.<CreateTitle1AndPlayAsync>d__24 <CreateTitle1AndPlayAsync>d__;
		<CreateTitle1AndPlayAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateTitle1AndPlayAsync>d__.<>4__this = this;
		<CreateTitle1AndPlayAsync>d__.prefabPath = prefabPath;
		<CreateTitle1AndPlayAsync>d__.parentItem = parentItem;
		<CreateTitle1AndPlayAsync>d__.<>1__state = -1;
		<CreateTitle1AndPlayAsync>d__.<>t__builder.Start<PhoneMsgPanelViewSmall.<CreateTitle1AndPlayAsync>d__24>(ref <CreateTitle1AndPlayAsync>d__);
		return <CreateTitle1AndPlayAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06010648 RID: 67144 RVA: 0x004C9FE3 File Offset: 0x004C81E3
	protected override void OnAfterHide()
	{
		GameSettingsDeviceRender.Instance.CancelTemporaryDisableFrameGeneration("PhoneMsgPanelViewSmall");
	}

	// Token: 0x06010649 RID: 67145 RVA: 0x004C9FF4 File Offset: 0x004C81F4
	[NullableContext(1)]
	private void PlayLevelSequenceByName(string sequenceName)
	{
		LevelSequencePlayer seqPlayer = this.SeqPlayer;
		if (seqPlayer != null)
		{
			seqPlayer.StopSequenceByKey(sequenceName, false, false);
		}
		LevelSequencePlayer seqPlayer2 = this.SeqPlayer;
		if (seqPlayer2 == null)
		{
			return;
		}
		seqPlayer2.PlayLevelSequenceByName(sequenceName, false, null, false);
	}

	// Token: 0x0601064A RID: 67146 RVA: 0x004CA034 File Offset: 0x004C8234
	protected override void OnBeforeDestroy()
	{
		PhoneSystemCharm charmPanel = this.CharmPanel;
		if (charmPanel != null)
		{
			charmPanel.Destroy(null);
		}
		this.CharmPanel = null;
		LevelSequencePlayer seqPlayer = this.SeqPlayer;
		if (seqPlayer != null)
		{
			seqPlayer.Clear();
		}
		this.SeqPlayer = null;
		LevelSequencePlayer levelSequencePlayer = this.title1SeqPlayer;
		if (levelSequencePlayer != null)
		{
			levelSequencePlayer.Clear();
		}
		this.title1SeqPlayer = null;
	}

	// Token: 0x0601064B RID: 67147 RVA: 0x004CA08A File Offset: 0x004C828A
	private void OnClickCloseBtn()
	{
		base.CloseMe(null);
	}

	// Token: 0x0400917B RID: 37243
	private PhoneMsgPanelViewData MsgData;

	// Token: 0x0400917C RID: 37244
	private PhoneSystemChatPanel ChatPanel;

	// Token: 0x0400917D RID: 37245
	private PhoneMsgTipViewA PopTipViewA;

	// Token: 0x0400917E RID: 37246
	private LevelSequencePlayer SeqPlayer;

	// Token: 0x0400917F RID: 37247
	private PhoneSystemCharm CharmPanel;

	// Token: 0x04009180 RID: 37248
	private string charmPrepath = "";

	// Token: 0x04009181 RID: 37249
	private UiPanelBase title1pre;

	// Token: 0x04009182 RID: 37250
	private UiPanelBase rightchatpre;

	// Token: 0x04009183 RID: 37251
	[Nullable(1)]
	private string title1prepath = "";

	// Token: 0x04009184 RID: 37252
	private string rightchatprepath = "";

	// Token: 0x04009185 RID: 37253
	private LevelSequencePlayer title1SeqPlayer;

	// Token: 0x02007C2C RID: 31788
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x04028372 RID: 164722
		BtnMask,
		// Token: 0x04028373 RID: 164723
		BtnClose,
		// Token: 0x04028374 RID: 164724
		PanelPhoneSystemChatPanel,
		// Token: 0x04028375 RID: 164725
		ItemPopA,
		// Token: 0x04028376 RID: 164726
		TexModelT,
		// Token: 0x04028377 RID: 164727
		TxtTitle,
		// Token: 0x04028378 RID: 164728
		PnlContentSkinTitle,
		// Token: 0x04028379 RID: 164729
		TexSkinBg,
		// Token: 0x0402837A RID: 164730
		TexSkinBgTopic,
		// Token: 0x0402837B RID: 164731
		PnlPetContent
	}
}
