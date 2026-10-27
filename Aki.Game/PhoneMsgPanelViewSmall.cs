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

// Token: 0x0200251A RID: 9498
[NullableContext(2)]
[Nullable(0)]
public class PhoneMsgPanelViewSmall : UiViewBase
{
	// Token: 0x0601317D RID: 78205 RVA: 0x004BBDC2 File Offset: 0x004B9FC2
	[NullableContext(1)]
	public PhoneMsgPanelViewSmall(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0601317E RID: 78206 RVA: 0x004BBDEC File Offset: 0x004B9FEC
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

	// Token: 0x0601317F RID: 78207 RVA: 0x004BBF04 File Offset: 0x004BA104
	protected override UniTask OnBeforeStartAsync()
	{
		PhoneMsgPanelViewSmall.<OnBeforeStartAsync>d__14 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<PhoneMsgPanelViewSmall.<OnBeforeStartAsync>d__14>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06013180 RID: 78208 RVA: 0x004BBF48 File Offset: 0x004BA148
	private UniTask LoadChatDataAsync()
	{
		PhoneMsgPanelViewSmall.<LoadChatDataAsync>d__15 <LoadChatDataAsync>d__;
		<LoadChatDataAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<LoadChatDataAsync>d__.<>4__this = this;
		<LoadChatDataAsync>d__.<>1__state = -1;
		<LoadChatDataAsync>d__.<>t__builder.Start<PhoneMsgPanelViewSmall.<LoadChatDataAsync>d__15>(ref <LoadChatDataAsync>d__);
		return <LoadChatDataAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06013181 RID: 78209 RVA: 0x004BBF8B File Offset: 0x004BA18B
	protected override void OnStart()
	{
	}

	// Token: 0x06013182 RID: 78210 RVA: 0x004BBF8D File Offset: 0x004BA18D
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnPhoneMsgChatShowChange, new Action(this.RefreshChatShow));
	}

	// Token: 0x06013183 RID: 78211 RVA: 0x004BBFAB File Offset: 0x004BA1AB
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnPhoneMsgChatShowChange, new Action(this.RefreshChatShow));
	}

	// Token: 0x06013184 RID: 78212 RVA: 0x004BBFC9 File Offset: 0x004BA1C9
	protected override void OnBeforeShow()
	{
		GameSettingsDeviceRender.Instance.TemporaryDisableFrameGeneration("PhoneMsgPanelViewSmall");
		this.RefreshChatShow();
	}

	// Token: 0x06013185 RID: 78213 RVA: 0x004BBFE0 File Offset: 0x004BA1E0
	private void RefreshChatShow()
	{
		this.RefreshByTheme(PhoneMsgModel.Instance.CurrentUsingChatThemeId);
		this.SetSpineByCharmId(PhoneMsgModel.Instance.CurrentUsingChatCharmId);
	}

	// Token: 0x06013186 RID: 78214 RVA: 0x004BC004 File Offset: 0x004BA204
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

	// Token: 0x06013187 RID: 78215 RVA: 0x004BC0D8 File Offset: 0x004BA2D8
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

	// Token: 0x06013188 RID: 78216 RVA: 0x004BC134 File Offset: 0x004BA334
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

	// Token: 0x06013189 RID: 78217 RVA: 0x004BC2AC File Offset: 0x004BA4AC
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

	// Token: 0x0601318A RID: 78218 RVA: 0x004BC2FF File Offset: 0x004BA4FF
	protected override void OnAfterHide()
	{
		GameSettingsDeviceRender.Instance.CancelTemporaryDisableFrameGeneration("PhoneMsgPanelViewSmall");
	}

	// Token: 0x0601318B RID: 78219 RVA: 0x004BC310 File Offset: 0x004BA510
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

	// Token: 0x0601318C RID: 78220 RVA: 0x004BC350 File Offset: 0x004BA550
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

	// Token: 0x0601318D RID: 78221 RVA: 0x004BC3A6 File Offset: 0x004BA5A6
	private void OnClickCloseBtn()
	{
		base.CloseMe(null);
	}

	// Token: 0x04009026 RID: 36902
	private PhoneMsgPanelViewData MsgData;

	// Token: 0x04009027 RID: 36903
	private PhoneSystemChatPanel ChatPanel;

	// Token: 0x04009028 RID: 36904
	private PhoneMsgTipViewA PopTipViewA;

	// Token: 0x04009029 RID: 36905
	private LevelSequencePlayer SeqPlayer;

	// Token: 0x0400902A RID: 36906
	private PhoneSystemCharm CharmPanel;

	// Token: 0x0400902B RID: 36907
	private string charmPrepath = "";

	// Token: 0x0400902C RID: 36908
	private UiPanelBase title1pre;

	// Token: 0x0400902D RID: 36909
	private UiPanelBase rightchatpre;

	// Token: 0x0400902E RID: 36910
	[Nullable(1)]
	private string title1prepath = "";

	// Token: 0x0400902F RID: 36911
	private string rightchatprepath = "";

	// Token: 0x04009030 RID: 36912
	private LevelSequencePlayer title1SeqPlayer;

	// Token: 0x02008AA5 RID: 35493
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x0402D05E RID: 184414
		BtnMask,
		// Token: 0x0402D05F RID: 184415
		BtnClose,
		// Token: 0x0402D060 RID: 184416
		PanelPhoneSystemChatPanel,
		// Token: 0x0402D061 RID: 184417
		ItemPopA,
		// Token: 0x0402D062 RID: 184418
		TexModelT,
		// Token: 0x0402D063 RID: 184419
		TxtTitle,
		// Token: 0x0402D064 RID: 184420
		PnlContentSkinTitle,
		// Token: 0x0402D065 RID: 184421
		TexSkinBg,
		// Token: 0x0402D066 RID: 184422
		TexSkinBgTopic,
		// Token: 0x0402D067 RID: 184423
		PnlPetContent
	}
}
