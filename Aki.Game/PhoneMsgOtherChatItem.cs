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

// Token: 0x02001A27 RID: 6695
[NullableContext(2)]
[Nullable(new byte[]
{
	0,
	1
})]
public class PhoneMsgOtherChatItem : SyncGridProxyAbstract<PhoneMsgChatData>, IPhoneMsgChatItem
{
	// Token: 0x06010750 RID: 67408 RVA: 0x004CF994 File Offset: 0x004CDB94
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

	// Token: 0x06010751 RID: 67409 RVA: 0x004CFB94 File Offset: 0x004CDD94
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

	// Token: 0x06010752 RID: 67410 RVA: 0x004CFC33 File Offset: 0x004CDE33
	protected override void OnBeforeDestroy()
	{
		EventSystem.Instance.Remove(EEventName.OnPhoneMsgChatShowChange, new Action(this.RefreshSpeakerNameTextColor));
	}

	// Token: 0x06010753 RID: 67411 RVA: 0x004CFC51 File Offset: 0x004CDE51
	[NullableContext(1)]
	public override void Refresh(PhoneMsgChatData data)
	{
		this.PhoneMsgChatData = data;
		this.RefreshDisplayItem();
		this.RefreshTimeText();
		this.RefreshSpeakerInfo();
		this.RefreshChatContent();
	}

	// Token: 0x06010754 RID: 67412 RVA: 0x004CFC72 File Offset: 0x004CDE72
	public void RefreshVoiceStatus()
	{
		this.RefreshVoiceDisplayItem();
	}

	// Token: 0x06010755 RID: 67413 RVA: 0x004CFC7C File Offset: 0x004CDE7C
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

	// Token: 0x06010756 RID: 67414 RVA: 0x004CFD29 File Offset: 0x004CDF29
	[NullableContext(1)]
	public string GetChatContent()
	{
		return this.PhoneMsgChatData.ContentStr;
	}

	// Token: 0x06010757 RID: 67415 RVA: 0x004CFD36 File Offset: 0x004CDF36
	public int GetChatContentNum()
	{
		return this.PhoneMsgChatData.ContentStr.Length;
	}

	// Token: 0x06010758 RID: 67416 RVA: 0x004CFD48 File Offset: 0x004CDF48
	public EPhoneMsgScrollWaitTimeType GetScrollWaitTimeType()
	{
		return this.PhoneMsgChatData.ScrollWaitTimeType;
	}

	// Token: 0x06010759 RID: 67417 RVA: 0x004CFD55 File Offset: 0x004CDF55
	public float GetScrollWaitTime()
	{
		return (float)this.PhoneMsgChatData.ScrollWaitTime;
	}

	// Token: 0x0601075A RID: 67418 RVA: 0x004CFD63 File Offset: 0x004CDF63
	public bool IsVoiceAndAutoPlay()
	{
		return this.PhoneMsgChatData.ContentType == EChatMsgType.Voice && !this.PhoneMsgChatData.IsVoicePlayed;
	}

	// Token: 0x0601075B RID: 67419 RVA: 0x004CFD84 File Offset: 0x004CDF84
	public EPhoneMessageVoicePushCondition? GetPushCondition()
	{
		return this.PhoneMsgChatData.PushCondition;
	}

	// Token: 0x0601075C RID: 67420 RVA: 0x004CFD94 File Offset: 0x004CDF94
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
			base.GetItem(18).SetUIActive(a == "InformationView" || a == "CoordinateTeleport");
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

	// Token: 0x0601075D RID: 67421 RVA: 0x004CFF2F File Offset: 0x004CE12F
	private void RefreshTimeText()
	{
		base.GetText(0).SetUIActive(false);
	}

	// Token: 0x0601075E RID: 67422 RVA: 0x004CFF40 File Offset: 0x004CE140
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

	// Token: 0x0601075F RID: 67423 RVA: 0x004CFFE0 File Offset: 0x004CE1E0
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
				if (type == "CoordinateTeleport")
				{
					base.GetItem(18).SetUIActive(true);
					this.LinkButton.RefreshCoordinateContent(this.PhoneMsgChatData);
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

	// Token: 0x06010760 RID: 67424 RVA: 0x004D036C File Offset: 0x004CE56C
	private void HideAllItemsExceptInputtingItem()
	{
		base.GetTexture(6).SetUIActive(false);
		base.GetItem(3).SetUIActive(false);
		base.GetButton(8).RootUIComp.Get().SetUIActive(false);
		base.GetItem(18).SetUIActive(false);
		base.GetItem(5).SetUIActive(false);
	}

	// Token: 0x06010761 RID: 67425 RVA: 0x004D03C8 File Offset: 0x004CE5C8
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

	// Token: 0x06010762 RID: 67426 RVA: 0x004D0414 File Offset: 0x004CE614
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

	// Token: 0x06010763 RID: 67427 RVA: 0x004D0462 File Offset: 0x004CE662
	public void StopInputtingAnimation()
	{
		this.LevelSequencePlayer.StopSequenceByKey("Send_Text_1", false, true);
	}

	// Token: 0x06010764 RID: 67428 RVA: 0x004D0478 File Offset: 0x004CE678
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

	// Token: 0x06010765 RID: 67429 RVA: 0x004D0508 File Offset: 0x004CE708
	public UniTask PlayChatContentAnimationAsync()
	{
		PhoneMsgOtherChatItem.<PlayChatContentAnimationAsync>d__30 <PlayChatContentAnimationAsync>d__;
		<PlayChatContentAnimationAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayChatContentAnimationAsync>d__.<>4__this = this;
		<PlayChatContentAnimationAsync>d__.<>1__state = -1;
		<PlayChatContentAnimationAsync>d__.<>t__builder.Start<PhoneMsgOtherChatItem.<PlayChatContentAnimationAsync>d__30>(ref <PlayChatContentAnimationAsync>d__);
		return <PlayChatContentAnimationAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06010766 RID: 67430 RVA: 0x004D054C File Offset: 0x004CE74C
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

	// Token: 0x06010767 RID: 67431 RVA: 0x004D0580 File Offset: 0x004CE780
	public UniTask PlayRedDotAnimationAsync()
	{
		PhoneMsgOtherChatItem.<PlayRedDotAnimationAsync>d__32 <PlayRedDotAnimationAsync>d__;
		<PlayRedDotAnimationAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayRedDotAnimationAsync>d__.<>4__this = this;
		<PlayRedDotAnimationAsync>d__.<>1__state = -1;
		<PlayRedDotAnimationAsync>d__.<>t__builder.Start<PhoneMsgOtherChatItem.<PlayRedDotAnimationAsync>d__32>(ref <PlayRedDotAnimationAsync>d__);
		return <PlayRedDotAnimationAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06010768 RID: 67432 RVA: 0x004D05C3 File Offset: 0x004CE7C3
	public void StopRedDotAnimation()
	{
		PhoneMsgChatData phoneMsgChatData = this.PhoneMsgChatData;
		if (phoneMsgChatData == null || !phoneMsgChatData.IsSendError)
		{
			return;
		}
		this.LevelSequencePlayer.StopSequenceByKey("Red_Tips", false, true);
	}

	// Token: 0x06010769 RID: 67433 RVA: 0x004D05F0 File Offset: 0x004CE7F0
	public UniTask PlayVoicePlayingAnimationAsync()
	{
		PhoneMsgOtherChatItem.<PlayVoicePlayingAnimationAsync>d__34 <PlayVoicePlayingAnimationAsync>d__;
		<PlayVoicePlayingAnimationAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayVoicePlayingAnimationAsync>d__.<>4__this = this;
		<PlayVoicePlayingAnimationAsync>d__.<>1__state = -1;
		<PlayVoicePlayingAnimationAsync>d__.<>t__builder.Start<PhoneMsgOtherChatItem.<PlayVoicePlayingAnimationAsync>d__34>(ref <PlayVoicePlayingAnimationAsync>d__);
		return <PlayVoicePlayingAnimationAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0601076A RID: 67434 RVA: 0x004D0633 File Offset: 0x004CE833
	public void TryPlayVoiceTxtInAnimation()
	{
		base.GetSprite(12).SetUIActive(false);
		base.GetItem(14).SetUIActive(true);
		base.GetItem(15).SetUIActive(true);
		this.LevelSequencePlayer.StopSequenceByKey("Voice_LoadText", false, true);
	}

	// Token: 0x0601076B RID: 67435 RVA: 0x004D0674 File Offset: 0x004CE874
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

	// Token: 0x0601076C RID: 67436 RVA: 0x004D06C2 File Offset: 0x004CE8C2
	public void StopVoicePlayingAnimation()
	{
		this.LevelSequencePlayer.StopSequenceByKey("Voice_Play_Loop", false, true);
	}

	// Token: 0x0601076D RID: 67437 RVA: 0x004D06D8 File Offset: 0x004CE8D8
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

	// Token: 0x0601076E RID: 67438 RVA: 0x004D070A File Offset: 0x004CE90A
	private void OnBtnSelfClick()
	{
		Action<int> onItemClickDelegate = this.OnItemClickDelegate;
		if (onItemClickDelegate != null)
		{
			onItemClickDelegate(base.GridIndex);
		}
		this.RefreshVoiceDisplayItem();
	}

	// Token: 0x0601076F RID: 67439 RVA: 0x004D0729 File Offset: 0x004CE929
	private void RefreshSpeakerNameTextColor()
	{
		base.GetText(2).SetUIActive(PhoneMsgModel.Instance.IsUsingDefaultChatBg);
		base.GetText(11).SetUIActive(!PhoneMsgModel.Instance.IsUsingDefaultChatBg);
	}

	// Token: 0x06010770 RID: 67440 RVA: 0x004D075C File Offset: 0x004CE95C
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

	// Token: 0x0400920C RID: 37388
	protected PhoneMsgChatData PhoneMsgChatData;

	// Token: 0x0400920D RID: 37389
	protected LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x0400920E RID: 37390
	private TimerHandle InputHandle;

	// Token: 0x0400920F RID: 37391
	private TimerHandle VoiceHandle;

	// Token: 0x04009210 RID: 37392
	private CustomPromise<bool> InputPromise;

	// Token: 0x04009211 RID: 37393
	private CustomPromise<bool> VoicePlayPromise;

	// Token: 0x04009212 RID: 37394
	protected PhoneMsgLinkButton LinkButton;

	// Token: 0x04009213 RID: 37395
	public int ItemIndex = -1;

	// Token: 0x04009214 RID: 37396
	public Action<int> OnItemClickDelegate;
}
