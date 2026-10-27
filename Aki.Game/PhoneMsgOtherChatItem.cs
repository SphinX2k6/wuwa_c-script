using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Aki.Config;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Personal;
using CSharpScript.Game.Module.PhoneMessage;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200253E RID: 9534
[NullableContext(2)]
[Nullable(new byte[]
{
	0,
	1
})]
public class PhoneMsgOtherChatItem : SyncGridProxyAbstract<PhoneMsgChatData>, IPhoneMsgChatItem
{
	// Token: 0x0601327D RID: 78461 RVA: 0x004C13D0 File Offset: 0x004BF5D0
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
			new ValueTuple<int, Type>(11, typeof(UUIText)),
			new ValueTuple<int, Type>(12, typeof(UUISprite)),
			new ValueTuple<int, Type>(13, typeof(UUIItem)),
			new ValueTuple<int, Type>(14, typeof(UUIItem)),
			new ValueTuple<int, Type>(15, typeof(UUIItem)),
			new ValueTuple<int, Type>(16, typeof(UUIText)),
			new ValueTuple<int, Type>(17, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(18, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(8, new Action(this.OnBtnPicClick)),
			new ValueTuple<int, Delegate>(17, new Action(this.OnBtnSelfClick))
		};
	}

	// Token: 0x0601327E RID: 78462 RVA: 0x004C15D0 File Offset: 0x004BF7D0
	protected override void OnStart()
	{
		this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
		this.LinkButton = new PhoneMsgLinkButton();
		UUIText text = base.GetText(4);
		UUIText text2 = base.GetText(2);
		UUIText text3 = base.GetText(11);
		text.bGameRichText = true;
		text.richText = true;
		text2.bGameRichText = true;
		text2.richText = true;
		text3.bGameRichText = true;
		text3.richText = true;
		EventSystem.Instance.Add(EEventName.OnPhoneMsgChatShowChange, new Action(this.RefreshSpeakerNameTextColor));
		this.LinkButton.CreateByActor(base.GetItem(18).GetOwner(), null);
	}

	// Token: 0x0601327F RID: 78463 RVA: 0x004C166F File Offset: 0x004BF86F
	protected override void OnBeforeDestroy()
	{
		EventSystem.Instance.Remove(EEventName.OnPhoneMsgChatShowChange, new Action(this.RefreshSpeakerNameTextColor));
	}

	// Token: 0x06013280 RID: 78464 RVA: 0x004C168D File Offset: 0x004BF88D
	[NullableContext(1)]
	public override void Refresh(PhoneMsgChatData data)
	{
		this.PhoneMsgChatData = data;
		this.RefreshDisplayItem();
		this.RefreshTimeText();
		this.RefreshSpeakerInfo();
		this.RefreshChatContent();
	}

	// Token: 0x06013281 RID: 78465 RVA: 0x004C16AE File Offset: 0x004BF8AE
	public void RefreshVoiceStatus()
	{
		this.RefreshVoiceDisplayItem();
	}

	// Token: 0x06013282 RID: 78466 RVA: 0x004C16B8 File Offset: 0x004BF8B8
	private void RefreshVoiceDisplayItem()
	{
		if (this.PhoneMsgChatData == null)
		{
			return;
		}
		UUIItem item = base.GetItem(13);
		if (item == null)
		{
			return;
		}
		bool flag = this.PhoneMsgChatData.ContentType == EChatMsgType.Voice;
		item.SetUIActive(flag);
		if (flag)
		{
			UUISprite sprite = base.GetSprite(12);
			if (sprite != null)
			{
				sprite.SetUIActive(!this.PhoneMsgChatData.IsVoicePlayed);
			}
			UUIItem item2 = base.GetItem(14);
			if (item2 != null)
			{
				item2.SetUIActive(this.PhoneMsgChatData.IsVoicePlayed);
			}
			UUIItem item3 = base.GetItem(15);
			if (item3 != null)
			{
				item3.SetUIActive(false);
			}
			UUIItem item4 = base.GetItem(16);
			if (item4 == null)
			{
				return;
			}
			item4.SetUIActive(this.PhoneMsgChatData.IsVoicePlayed);
		}
	}

	// Token: 0x06013283 RID: 78467 RVA: 0x004C1765 File Offset: 0x004BF965
	[NullableContext(1)]
	public string GetChatContent()
	{
		return this.PhoneMsgChatData.ContentStr;
	}

	// Token: 0x06013284 RID: 78468 RVA: 0x004C1772 File Offset: 0x004BF972
	public int GetChatContentNum()
	{
		return this.PhoneMsgChatData.ContentStr.Length;
	}

	// Token: 0x06013285 RID: 78469 RVA: 0x004C1784 File Offset: 0x004BF984
	public EPhoneMsgScrollWaitTimeType GetScrollWaitTimeType()
	{
		return this.PhoneMsgChatData.ScrollWaitTimeType;
	}

	// Token: 0x06013286 RID: 78470 RVA: 0x004C1791 File Offset: 0x004BF991
	public float GetScrollWaitTime()
	{
		return (float)this.PhoneMsgChatData.ScrollWaitTime;
	}

	// Token: 0x06013287 RID: 78471 RVA: 0x004C179F File Offset: 0x004BF99F
	public bool IsVoiceAndAutoPlay()
	{
		return this.PhoneMsgChatData.ContentType == EChatMsgType.Voice && !this.PhoneMsgChatData.IsVoicePlayed;
	}

	// Token: 0x06013288 RID: 78472 RVA: 0x004C17C0 File Offset: 0x004BF9C0
	public EPhoneMessageVoicePushCondition? GetPushCondition()
	{
		return this.PhoneMsgChatData.PushCondition;
	}

	// Token: 0x06013289 RID: 78473 RVA: 0x004C17D0 File Offset: 0x004BF9D0
	public void RefreshDisplayItem()
	{
		EChatMsgType contentType = this.PhoneMsgChatData.ContentType;
		base.GetItem(7).SetUIActive(false);
		base.GetItem(5).SetUIActive(this.PhoneMsgChatData.IsSendError);
		base.GetTexture(6).SetUIActive(contentType == EChatMsgType.Emoji);
		if (contentType == EChatMsgType.Attachment)
		{
			PhoneMessageAttachment? config = ConfigPhoneMessageAttachmentById.GetConfig(this.PhoneMsgChatData.ContentNum, true);
			string a = (config != null) ? config.GetValueOrDefault().Type : null;
			base.GetButton(8).RootUIComp.Get().SetUIActive(a == "Image" || a == "Spine");
			base.GetItem(18).SetUIActive(a == "InformationView");
		}
		else
		{
			base.GetButton(8).RootUIComp.Get().SetUIActive(false);
			base.GetItem(18).SetUIActive(false);
		}
		bool flag = contentType == EChatMsgType.Voice;
		bool isVoicePlayed = this.PhoneMsgChatData.IsVoicePlayed;
		base.GetItem(13).SetUIActive(flag);
		base.GetItem(3).SetUIActive(contentType == EChatMsgType.Text || flag);
		base.GetSprite(12).SetUIActive(flag && !isVoicePlayed);
		base.GetItem(14).SetUIActive(flag && isVoicePlayed);
		base.GetItem(15).SetUIActive(false);
		base.GetItem(16).SetUIActive(flag && isVoicePlayed);
		base.GetButton(17).SetSelfInteractive(contentType != EChatMsgType.Text);
	}

	// Token: 0x0601328A RID: 78474 RVA: 0x004C195A File Offset: 0x004BFB5A
	private void RefreshTimeText()
	{
		base.GetText(0).SetUIActive(false);
	}

	// Token: 0x0601328B RID: 78475 RVA: 0x004C196C File Offset: 0x004BFB6C
	private void RefreshSpeakerInfo()
	{
		base.GetText(2).SetText(this.PhoneMsgChatData.SpeakerName, true);
		base.GetText(11).SetText(this.PhoneMsgChatData.SpeakerName, true);
		this.RefreshSpeakerNameTextColor();
		UUITexture texture = base.GetTexture(1);
		int speakerIcon = this.PhoneMsgChatData.SpeakerIcon;
		if (speakerIcon != 0)
		{
			PlayerHeadData playerHeadData = PersonalModel.Instance.GetPlayerHeadData(speakerIcon, false);
			if (playerHeadData != null)
			{
				base.SetTextureShowUntilLoaded(playerHeadData.GetRoleHeadIconCircle(), texture, null);
				return;
			}
		}
		else
		{
			string speakerHeadIconPath = this.PhoneMsgChatData.SpeakerHeadIconPath;
			if (StringUtils.IsEmpty(speakerHeadIconPath))
			{
				texture.SetUIActive(false);
				return;
			}
			base.SetTextureShowUntilLoaded(speakerHeadIconPath, texture, null);
		}
	}

	// Token: 0x0601328C RID: 78476 RVA: 0x004C1A0C File Offset: 0x004BFC0C
	private void RefreshChatContent()
	{
		EChatMsgType contentType = this.PhoneMsgChatData.ContentType;
		bool uiactive = contentType == EChatMsgType.Voice;
		base.GetItem(13).SetUIActive(uiactive);
		switch (contentType)
		{
		case EChatMsgType.Text:
			base.GetText(4).SetText(this.PhoneMsgChatData.ContentStr, true);
			return;
		case EChatMsgType.Emoji:
		{
			int contentNum = this.PhoneMsgChatData.ContentNum;
			string emojiTexturePathByEmojiId = PhoneMsgModel.Instance.GetEmojiTexturePathByEmojiId(contentNum);
			if (!string.IsNullOrEmpty(emojiTexturePathByEmojiId))
			{
				base.SetTextureByPath(emojiTexturePathByEmojiId, base.GetTexture(6), null, null);
				return;
			}
			break;
		}
		case EChatMsgType.Attachment:
		{
			PhoneMessageAttachment? config = ConfigPhoneMessageAttachmentById.GetConfig(this.PhoneMsgChatData.ContentNum, true);
			if (config != null)
			{
				PhoneMessageAttachment value = config.Value;
				bool flag = PlayerInfoModel.Instance.GetPlayerGender() == EPlayerGender.Male;
				string type = value.Type;
				if (type == "Image" || type == "Spine")
				{
					base.GetButton(8).RootUIComp.Get().SetUIActive(true);
					string text = value.ThumbnailMaleVariant;
					if (string.IsNullOrEmpty(text))
					{
						text = value.Thumbnail;
					}
					else
					{
						text = (flag ? value.ThumbnailMaleVariant : value.Thumbnail);
					}
					base.SetTextureByPath(text, base.GetTexture(9), null, null);
					return;
				}
				if (type == "InformationView")
				{
					base.GetItem(18).SetUIActive(true);
					int id = value.Id;
					string textKey;
					int infoId;
					if (value.InformationViewIdMaleVariant == 0)
					{
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(52, 1);
						defaultInterpolatedStringHandler.AppendLiteral("PhoneMessageAttachment_");
						defaultInterpolatedStringHandler.AppendFormatted<int>(id);
						defaultInterpolatedStringHandler.AppendLiteral("_InformationViewHyperlinkText");
						textKey = defaultInterpolatedStringHandler.ToStringAndClear();
						infoId = value.InformationViewId;
					}
					else if (flag)
					{
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(63, 1);
						defaultInterpolatedStringHandler.AppendLiteral("PhoneMessageAttachment_");
						defaultInterpolatedStringHandler.AppendFormatted<int>(id);
						defaultInterpolatedStringHandler.AppendLiteral("_InformationViewHyperlinkTextMaleVariant");
						textKey = defaultInterpolatedStringHandler.ToStringAndClear();
						infoId = value.InformationViewIdMaleVariant;
					}
					else
					{
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(52, 1);
						defaultInterpolatedStringHandler.AppendLiteral("PhoneMessageAttachment_");
						defaultInterpolatedStringHandler.AppendFormatted<int>(id);
						defaultInterpolatedStringHandler.AppendLiteral("_InformationViewHyperlinkText");
						textKey = defaultInterpolatedStringHandler.ToStringAndClear();
						infoId = value.InformationViewId;
					}
					this.LinkButton.RefreshContent(textKey, infoId, this.PhoneMsgChatData);
					return;
				}
			}
			break;
		}
		default:
		{
			if (contentType != EChatMsgType.Voice)
			{
				return;
			}
			if (this.VoicePlayPromise != null)
			{
				return;
			}
			UUIText text2 = base.GetText(4);
			UUIText text3 = base.GetText(16);
			int num = (int)Math.Round((double)(this.PhoneMsgChatData.VoiceDuration / 1000f), MidpointRounding.AwayFromZero);
			num = Math.Max(num, 1);
			int valueOrDefault = ConfigCommonParamById.GetIntConfig("OneSecondToSpace").GetValueOrDefault(1);
			int valueOrDefault2 = ConfigCommonParamById.GetIntConfig("MaxTimeLength").GetValueOrDefault(40);
			StringBuilder stringBuilder = new StringBuilder();
			StringBuilder stringBuilder2 = stringBuilder;
			StringBuilder stringBuilder3 = stringBuilder2;
			StringBuilder.AppendInterpolatedStringHandler appendInterpolatedStringHandler = new StringBuilder.AppendInterpolatedStringHandler(1, 1, stringBuilder2);
			appendInterpolatedStringHandler.AppendFormatted<int>(num);
			appendInterpolatedStringHandler.AppendLiteral("″");
			stringBuilder3.Append(ref appendInterpolatedStringHandler);
			if (num > 1)
			{
				int num2 = Math.Min(num - 1, valueOrDefault2);
				stringBuilder.Append(' ', num2 * valueOrDefault);
			}
			text2.SetText(stringBuilder.ToString(), true);
			text3.SetText(this.PhoneMsgChatData.ContentStr, true);
			break;
		}
		}
	}

	// Token: 0x0601328D RID: 78477 RVA: 0x004C1D68 File Offset: 0x004BFF68
	private void HideAllItemsExceptInputtingItem()
	{
		base.GetTexture(6).SetUIActive(false);
		base.GetItem(3).SetUIActive(false);
		base.GetButton(8).RootUIComp.Get().SetUIActive(false);
		base.GetItem(18).SetUIActive(false);
		base.GetItem(5).SetUIActive(false);
	}

	// Token: 0x0601328E RID: 78478 RVA: 0x004C1DC4 File Offset: 0x004BFFC4
	public UniTask PlayInputtingAnimationAsync(float delayTime)
	{
		PhoneMsgOtherChatItem.<PlayInputtingAnimationAsync>d__26 <PlayInputtingAnimationAsync>d__;
		<PlayInputtingAnimationAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayInputtingAnimationAsync>d__.<>4__this = this;
		<PlayInputtingAnimationAsync>d__.delayTime = delayTime;
		<PlayInputtingAnimationAsync>d__.<>1__state = -1;
		<PlayInputtingAnimationAsync>d__.<>t__builder.Start<PhoneMsgOtherChatItem.<PlayInputtingAnimationAsync>d__26>(ref <PlayInputtingAnimationAsync>d__);
		return <PlayInputtingAnimationAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0601328F RID: 78479 RVA: 0x004C1E10 File Offset: 0x004C0010
	public void SkipInputtingAnimationTask()
	{
		if (this.InputPromise != null)
		{
			this.InputPromise.SetResult(false);
			this.InputPromise = null;
		}
		this.StopInputtingAnimation();
		if (this.InputHandle != null)
		{
			TimerSystem.GameplayTimeInstance.Remove(this.InputHandle);
			this.InputHandle = null;
		}
	}

	// Token: 0x06013290 RID: 78480 RVA: 0x004C1E5E File Offset: 0x004C005E
	public void StopInputtingAnimation()
	{
		this.LevelSequencePlayer.StopSequenceByKey("Send_Text_1", false, true);
	}

	// Token: 0x06013291 RID: 78481 RVA: 0x004C1E74 File Offset: 0x004C0074
	[NullableContext(1)]
	private string GetChatContentSequenceName()
	{
		EChatMsgType contentType = this.PhoneMsgChatData.ContentType;
		switch (contentType)
		{
		case EChatMsgType.Text:
			return "Send_Text_2";
		case EChatMsgType.Emoji:
			return "Emote_In";
		case EChatMsgType.Attachment:
		{
			PhoneMessageAttachment? config = ConfigPhoneMessageAttachmentById.GetConfig(this.PhoneMsgChatData.ContentNum, true);
			if (((config != null) ? config.GetValueOrDefault().Type : null) == "InformationView")
			{
				return "Info_In";
			}
			return "Pic_In";
		}
		default:
			if (contentType != EChatMsgType.Voice)
			{
				return "";
			}
			return "Send_Text_2";
		}
	}

	// Token: 0x06013292 RID: 78482 RVA: 0x004C1F04 File Offset: 0x004C0104
	public UniTask PlayChatContentAnimationAsync()
	{
		PhoneMsgOtherChatItem.<PlayChatContentAnimationAsync>d__30 <PlayChatContentAnimationAsync>d__;
		<PlayChatContentAnimationAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayChatContentAnimationAsync>d__.<>4__this = this;
		<PlayChatContentAnimationAsync>d__.<>1__state = -1;
		<PlayChatContentAnimationAsync>d__.<>t__builder.Start<PhoneMsgOtherChatItem.<PlayChatContentAnimationAsync>d__30>(ref <PlayChatContentAnimationAsync>d__);
		return <PlayChatContentAnimationAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06013293 RID: 78483 RVA: 0x004C1F48 File Offset: 0x004C0148
	public void StopChatContentAnimation()
	{
		string chatContentSequenceName = this.GetChatContentSequenceName();
		if (StringUtils.IsEmpty(chatContentSequenceName))
		{
			return;
		}
		this.LevelSequencePlayer.StopSequenceByKey(chatContentSequenceName, false, true);
		this.StopRedDotAnimation();
	}

	// Token: 0x06013294 RID: 78484 RVA: 0x004C1F7C File Offset: 0x004C017C
	public UniTask PlayRedDotAnimationAsync()
	{
		PhoneMsgOtherChatItem.<PlayRedDotAnimationAsync>d__32 <PlayRedDotAnimationAsync>d__;
		<PlayRedDotAnimationAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayRedDotAnimationAsync>d__.<>4__this = this;
		<PlayRedDotAnimationAsync>d__.<>1__state = -1;
		<PlayRedDotAnimationAsync>d__.<>t__builder.Start<PhoneMsgOtherChatItem.<PlayRedDotAnimationAsync>d__32>(ref <PlayRedDotAnimationAsync>d__);
		return <PlayRedDotAnimationAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06013295 RID: 78485 RVA: 0x004C1FBF File Offset: 0x004C01BF
	public void StopRedDotAnimation()
	{
		PhoneMsgChatData phoneMsgChatData = this.PhoneMsgChatData;
		if (phoneMsgChatData == null || !phoneMsgChatData.IsSendError)
		{
			return;
		}
		this.LevelSequencePlayer.StopSequenceByKey("Red_Tips", false, true);
	}

	// Token: 0x06013296 RID: 78486 RVA: 0x004C1FEC File Offset: 0x004C01EC
	public UniTask PlayVoicePlayingAnimationAsync()
	{
		PhoneMsgOtherChatItem.<PlayVoicePlayingAnimationAsync>d__34 <PlayVoicePlayingAnimationAsync>d__;
		<PlayVoicePlayingAnimationAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayVoicePlayingAnimationAsync>d__.<>4__this = this;
		<PlayVoicePlayingAnimationAsync>d__.<>1__state = -1;
		<PlayVoicePlayingAnimationAsync>d__.<>t__builder.Start<PhoneMsgOtherChatItem.<PlayVoicePlayingAnimationAsync>d__34>(ref <PlayVoicePlayingAnimationAsync>d__);
		return <PlayVoicePlayingAnimationAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06013297 RID: 78487 RVA: 0x004C202F File Offset: 0x004C022F
	public void TryPlayVoiceTxtInAnimation()
	{
		base.GetSprite(12).SetUIActive(false);
		base.GetItem(14).SetUIActive(true);
		base.GetItem(15).SetUIActive(true);
		this.LevelSequencePlayer.StopSequenceByKey("Voice_LoadText", false, true);
	}

	// Token: 0x06013298 RID: 78488 RVA: 0x004C2070 File Offset: 0x004C0270
	public void SkipVoicePlayingAnimation()
	{
		if (this.VoicePlayPromise != null)
		{
			this.VoicePlayPromise.SetResult(false);
			this.VoicePlayPromise = null;
		}
		this.StopVoicePlayingAnimation();
		if (this.VoiceHandle != null)
		{
			TimerSystem.GameplayTimeInstance.Remove(this.VoiceHandle);
			this.VoiceHandle = null;
		}
	}

	// Token: 0x06013299 RID: 78489 RVA: 0x004C20BE File Offset: 0x004C02BE
	public void StopVoicePlayingAnimation()
	{
		this.LevelSequencePlayer.StopSequenceByKey("Voice_Play_Loop", false, true);
	}

	// Token: 0x0601329A RID: 78490 RVA: 0x004C20D4 File Offset: 0x004C02D4
	private void OnBtnPicClick()
	{
		if (this.PhoneMsgChatData == null)
		{
			return;
		}
		int contentNum = this.PhoneMsgChatData.ContentNum;
		if (contentNum <= 0)
		{
			return;
		}
		PhoneMsgController.Instance.OpenAttachmentImgView(contentNum);
	}

	// Token: 0x0601329B RID: 78491 RVA: 0x004C2106 File Offset: 0x004C0306
	private void OnBtnSelfClick()
	{
		Action<int> onItemClickDelegate = this.OnItemClickDelegate;
		if (onItemClickDelegate != null)
		{
			onItemClickDelegate(base.GridIndex);
		}
		this.RefreshVoiceDisplayItem();
	}

	// Token: 0x0601329C RID: 78492 RVA: 0x004C2125 File Offset: 0x004C0325
	private void RefreshSpeakerNameTextColor()
	{
		base.GetText(2).SetUIActive(PhoneMsgModel.Instance.IsUsingDefaultChatBg);
		base.GetText(11).SetUIActive(!PhoneMsgModel.Instance.IsUsingDefaultChatBg);
	}

	// Token: 0x0601329D RID: 78493 RVA: 0x004C2158 File Offset: 0x004C0358
	public UniTask ShowVoiceTextPanel(Action afterShow = null)
	{
		PhoneMsgOtherChatItem.<ShowVoiceTextPanel>d__41 <ShowVoiceTextPanel>d__;
		<ShowVoiceTextPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<ShowVoiceTextPanel>d__.<>4__this = this;
		<ShowVoiceTextPanel>d__.afterShow = afterShow;
		<ShowVoiceTextPanel>d__.<>1__state = -1;
		<ShowVoiceTextPanel>d__.<>t__builder.Start<PhoneMsgOtherChatItem.<ShowVoiceTextPanel>d__41>(ref <ShowVoiceTextPanel>d__);
		return <ShowVoiceTextPanel>d__.<>t__builder.Task;
	}

	// Token: 0x040090B2 RID: 37042
	protected PhoneMsgChatData PhoneMsgChatData;

	// Token: 0x040090B3 RID: 37043
	protected LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x040090B4 RID: 37044
	private TimerHandle InputHandle;

	// Token: 0x040090B5 RID: 37045
	private TimerHandle VoiceHandle;

	// Token: 0x040090B6 RID: 37046
	private CustomPromise<bool> InputPromise;

	// Token: 0x040090B7 RID: 37047
	private CustomPromise<bool> VoicePlayPromise;

	// Token: 0x040090B8 RID: 37048
	protected PhoneMsgLinkButton LinkButton;

	// Token: 0x040090B9 RID: 37049
	public int ItemIndex = -1;

	// Token: 0x040090BA RID: 37050
	public Action<int> OnItemClickDelegate;
}
