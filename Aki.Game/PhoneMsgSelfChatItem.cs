using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Aki.Config;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Personal;
using CSharpScript.Game.Module.PhoneMessage;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001A2A RID: 6698
[NullableContext(2)]
[Nullable(new byte[]
{
	0,
	1
})]
public class PhoneMsgSelfChatItem : SyncGridProxyAbstract<PhoneMsgChatData>, IPhoneMsgChatItem
{
	// Token: 0x06010777 RID: 67447 RVA: 0x004D082C File Offset: 0x004CEA2C
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
			new ValueTuple<int, Type>(12, typeof(UUIItem)),
			new ValueTuple<int, Type>(13, typeof(UUIScrollViewWithScrollbarComponent)),
			new ValueTuple<int, Type>(14, typeof(UUILayoutBase)),
			new ValueTuple<int, Type>(15, typeof(UUIItem)),
			new ValueTuple<int, Type>(16, typeof(UUIItem)),
			new ValueTuple<int, Type>(17, typeof(UUIScrollViewWithScrollbarComponent)),
			new ValueTuple<int, Type>(18, typeof(UUILayoutBase)),
			new ValueTuple<int, Type>(19, typeof(UUIItem)),
			new ValueTuple<int, Type>(20, typeof(UUIItem)),
			new ValueTuple<int, Type>(21, typeof(UUIItem)),
			new ValueTuple<int, Type>(22, typeof(UUIItem)),
			new ValueTuple<int, Type>(23, typeof(UUIItem)),
			new ValueTuple<int, Type>(24, typeof(UUIItem)),
			new ValueTuple<int, Type>(25, typeof(UUIText)),
			new ValueTuple<int, Type>(26, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(27, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(8, new Action(this.OnBtnPicClick)),
			new ValueTuple<int, Delegate>(26, new Action(this.OnBtnSelfClick))
		};
	}

	// Token: 0x06010778 RID: 67448 RVA: 0x004D0AFC File Offset: 0x004CECFC
	protected override void OnStart()
	{
		this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
		this.LinkButton = new PhoneMsgLinkButton();
		UUIText text = base.GetText(4);
		UUIText text2 = base.GetText(2);
		text.bGameRichText = true;
		text.richText = true;
		text2.bGameRichText = true;
		text2.richText = true;
		this.EmojiLayout = new GenericLayout<PhoneMsgEmojiItem, int>(base.GetLayoutBase(18), new Func<PhoneMsgEmojiItem>(this.CreatePhoneMsgEmojiItem), null, false, true);
		this.PhraseLayout = new GenericLayout<PhoneMsgPhraseItem, string>(base.GetLayoutBase(14), new Func<PhoneMsgPhraseItem>(this.CreatePhoneMsgPhraseItem), null, false, true);
		UUIItem item = base.GetItem(20);
		this.TextOptionAnimItemAlpha = item.Alpha;
		this.TextOptionAnimItemAnchorOffsetY = item.GetAnchorOffsetY();
		UUIItem item2 = base.GetItem(16);
		this.EmojiOptionAnimItemAlpha = item2.Alpha;
		this.EmojiOptionAnimItemStretchBottom = item2.GetStretchBottom();
		EventSystem.Instance.Add(EEventName.OnPhoneMsgChatShowChange, new Action(this.RefreshChatDialogShowAfterChange));
		EventSystem.Instance.Add(EEventName.OnNameChange, new Action(this.RefreshSpeakerName));
		this.RootActor.OnSequencePlayEvent.Bind(new Action<string, string>(this.OnEventSequence));
		this.LinkButton.CreateByActor(base.GetItem(27).GetOwner(), null);
	}

	// Token: 0x06010779 RID: 67449 RVA: 0x004D0C42 File Offset: 0x004CEE42
	protected override void OnBeforeDestroy()
	{
		EventSystem.Instance.Remove(EEventName.OnPhoneMsgChatShowChange, new Action(this.RefreshChatDialogShowAfterChange));
		EventSystem.Instance.Remove(EEventName.OnNameChange, new Action(this.RefreshSpeakerName));
	}

	// Token: 0x0601077A RID: 67450 RVA: 0x004D0C7C File Offset: 0x004CEE7C
	[NullableContext(1)]
	public override void Refresh(PhoneMsgChatData data)
	{
		this.PhoneMsgChatData = data;
		this.IsUnPlayStart = true;
		this.UpdateOptionData();
		this.RefreshDisplayItem();
		this.ResetTextOptionAnimItem();
		this.ResetEmojiOptionAnimItem();
		this.RefreshTimeText();
		this.RefreshSpeakerInfo();
		this.RefreshChatContent();
		this.RefreshChatDialogShow();
	}

	// Token: 0x0601077B RID: 67451 RVA: 0x004D0CBC File Offset: 0x004CEEBC
	private void UpdateOptionData()
	{
		if (this.PhoneMsgChatData == null || this.PhoneMsgChatData.TalkItem == null)
		{
			return;
		}
		List<ITalkOption> options = this.PhoneMsgChatData.TalkItem.Options;
		if (options == null || options.Count == 0)
		{
			return;
		}
		this.PhraseDataList.Clear();
		this.EmojiDataList.Clear();
		int count = options.Count;
		for (int i = 0; i < count; i++)
		{
			ITalkOption talkOption = options[i];
			if (talkOption.TypeParams == null)
			{
				if (talkOption.TidTalkOption.Length > 0)
				{
					string item = PublicUtil.Instance.GetFlowConfigLocalText(talkOption.TidTalkOption) ?? "";
					this.PhraseDataList.Add(item);
				}
			}
			else if (talkOption.TypeParams.Type == ETalkOptionParamType.PhoneMessageEmoji)
			{
				int valueOrDefault = ((ITalkOptionPhoneMessageEmoji)talkOption.TypeParams).EmojiId.GetValueOrDefault();
				this.EmojiDataList.Add(valueOrDefault);
			}
		}
	}

	// Token: 0x0601077C RID: 67452 RVA: 0x004D0DA9 File Offset: 0x004CEFA9
	private void RefreshTimeText()
	{
		base.GetText(0).SetUIActive(false);
	}

	// Token: 0x0601077D RID: 67453 RVA: 0x004D0DB8 File Offset: 0x004CEFB8
	private void RefreshSpeakerInfo()
	{
		base.GetText(2).SetText(this.PhoneMsgChatData.SpeakerName, true);
		UUIText text = base.GetText(11);
		if (text != null)
		{
			text.SetText(this.PhoneMsgChatData.SpeakerName, true);
		}
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

	// Token: 0x0601077E RID: 67454 RVA: 0x004D0E5C File Offset: 0x004CF05C
	private void RefreshSpeakerName()
	{
		string text = FunctionModel.Instance.GetPlayerName() ?? "";
		if (!string.IsNullOrEmpty(text) && this.PhoneMsgChatData != null)
		{
			this.PhoneMsgChatData.SpeakerName = text;
			base.GetText(2).SetText(text, true);
			UUIText text2 = base.GetText(11);
			if (text2 != null)
			{
				text2.SetText(text, true);
			}
		}
	}

	// Token: 0x0601077F RID: 67455 RVA: 0x004D0EBC File Offset: 0x004CF0BC
	public void RefreshChatDialogShow()
	{
		int currentUsingChatDialogId = PhoneMsgModel.Instance.CurrentUsingChatDialogId;
		ChatDialog? chatDialogConfig = PhoneMsgConfig.Instance.GetChatDialogConfig(currentUsingChatDialogId);
		if (chatDialogConfig == null)
		{
			return;
		}
		string bgPath = chatDialogConfig.Value.BgPath;
		this.SetSpriteByPath(bgPath, base.GetSprite(10), false, null, null);
		base.GetText(4).SetColor(FColor.FromHex(chatDialogConfig.Value.TextColor));
		base.GetItem(22).SetColor(FColor.FromHex(chatDialogConfig.Value.TextColor));
		this.TryLoadDynamicDialogNode(chatDialogConfig.Value.SpineItemPath);
		bool isUsingDefaultChatBg = PhoneMsgModel.Instance.IsUsingDefaultChatBg;
		base.GetText(2).SetUIActive(isUsingDefaultChatBg);
		UUIText text = base.GetText(11);
		if (text == null)
		{
			return;
		}
		text.SetUIActive(!isUsingDefaultChatBg);
	}

	// Token: 0x06010780 RID: 67456 RVA: 0x004D0F9D File Offset: 0x004CF19D
	public void RefreshChatDialogShowAfterChange()
	{
		this.RefreshChatDialogShow();
	}

	// Token: 0x06010781 RID: 67457 RVA: 0x004D0FA8 File Offset: 0x004CF1A8
	private void TryLoadDynamicDialogNode(string path)
	{
		PhoneMsgSelfChatItem.<>c__DisplayClass29_0 CS$<>8__locals1 = new PhoneMsgSelfChatItem.<>c__DisplayClass29_0();
		CS$<>8__locals1.<>4__this = this;
		CS$<>8__locals1.path = path;
		UiAsyncTask task = new UiAsyncTask("PhoneMsgSelfChatItem.TryLoadDynamicDialogNode", delegate()
		{
			PhoneMsgSelfChatItem.<>c__DisplayClass29_0.<<TryLoadDynamicDialogNode>b__0>d <<TryLoadDynamicDialogNode>b__0>d;
			<<TryLoadDynamicDialogNode>b__0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<<TryLoadDynamicDialogNode>b__0>d.<>4__this = CS$<>8__locals1;
			<<TryLoadDynamicDialogNode>b__0>d.<>1__state = -1;
			<<TryLoadDynamicDialogNode>b__0>d.<>t__builder.Start<PhoneMsgSelfChatItem.<>c__DisplayClass29_0.<<TryLoadDynamicDialogNode>b__0>d>(ref <<TryLoadDynamicDialogNode>b__0>d);
			return <<TryLoadDynamicDialogNode>b__0>d.<>t__builder.Task;
		}, null);
		base.RunAsyncTask(task).Forget();
	}

	// Token: 0x06010782 RID: 67458 RVA: 0x004D0FF0 File Offset: 0x004CF1F0
	private UniTask TryLoadDynamicDialogNodeAsync(string path)
	{
		PhoneMsgSelfChatItem.<TryLoadDynamicDialogNodeAsync>d__30 <TryLoadDynamicDialogNodeAsync>d__;
		<TryLoadDynamicDialogNodeAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<TryLoadDynamicDialogNodeAsync>d__.<>4__this = this;
		<TryLoadDynamicDialogNodeAsync>d__.path = path;
		<TryLoadDynamicDialogNodeAsync>d__.<>1__state = -1;
		<TryLoadDynamicDialogNodeAsync>d__.<>t__builder.Start<PhoneMsgSelfChatItem.<TryLoadDynamicDialogNodeAsync>d__30>(ref <TryLoadDynamicDialogNodeAsync>d__);
		return <TryLoadDynamicDialogNodeAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06010783 RID: 67459 RVA: 0x004D103B File Offset: 0x004CF23B
	private void DestroyDynamicDialogActor()
	{
		if (this.DynamicDialogActor != null && this.DynamicDialogActor.IsValid())
		{
			ULGUIBPLibrary.DestroyActorWithHierarchy(this.DynamicDialogActor, true);
			this.DynamicDialogActor = null;
		}
	}

	// Token: 0x06010784 RID: 67460 RVA: 0x004D1068 File Offset: 0x004CF268
	private void RefreshDisplayItem()
	{
		EChatMsgType contentType = this.PhoneMsgChatData.ContentType;
		base.GetItem(12).SetUIActive(contentType == EChatMsgType.TextOption);
		base.GetItem(16).SetUIActive(contentType == EChatMsgType.EmojiOption);
		base.GetItem(7).SetUIActive(false);
		base.GetItem(5).SetUIActive(this.PhoneMsgChatData.IsSendError);
		base.GetTexture(6).SetUIActive(contentType == EChatMsgType.Emoji);
		if (contentType == EChatMsgType.Attachment)
		{
			PhoneMessageAttachment? config = ConfigPhoneMessageAttachmentById.GetConfig(this.PhoneMsgChatData.ContentNum, true);
			string a = (config != null) ? config.GetValueOrDefault().Type : null;
			base.GetButton(8).RootUIComp.Get().SetUIActive(a == "Image" || a == "Spine");
			base.GetItem(27).SetUIActive(a == "InformationView" || a == "CoordinateTeleport");
		}
		else
		{
			base.GetButton(8).RootUIComp.Get().SetUIActive(false);
			base.GetItem(27).SetUIActive(false);
		}
		bool flag = contentType == EChatMsgType.Voice;
		base.GetItem(3).SetUIActive(contentType == EChatMsgType.Text || flag);
		base.GetButton(26).SetSelfInteractive(contentType != EChatMsgType.Text);
		base.GetItem(22).SetUIActive(flag);
		base.GetItem(23).SetUIActive(flag);
		base.GetItem(24).SetUIActive(false);
		base.GetText(25).SetUIActive(flag);
	}

	// Token: 0x06010785 RID: 67461 RVA: 0x004D11FC File Offset: 0x004CF3FC
	private void RefreshChatContent()
	{
		switch (this.PhoneMsgChatData.ContentType)
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
					base.GetItem(27).SetUIActive(true);
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
					base.GetItem(27).SetUIActive(true);
					this.LinkButton.RefreshCoordinateContent(this.PhoneMsgChatData);
					return;
				}
			}
			break;
		}
		case EChatMsgType.Task:
		case EChatMsgType.Birthday:
		case EChatMsgType.Reward:
		case EChatMsgType.Tips:
			break;
		case EChatMsgType.TextOption:
			this.PhraseLayout.RefreshByData(this.PhraseDataList, null, false);
			return;
		case EChatMsgType.EmojiOption:
			this.EmojiLayout.RefreshByData(this.EmojiDataList, null, false);
			return;
		case EChatMsgType.Voice:
		{
			UUIText text2 = base.GetText(4);
			UUIText text3 = base.GetText(25);
			int num = (int)Math.Round((double)(this.PhoneMsgChatData.VoiceDuration / 1000f), MidpointRounding.AwayFromZero);
			num = Math.Max(num, 1);
			int valueOrDefault = ConfigCommonParamById.GetIntConfig("OneSecondToSpace").GetValueOrDefault(1);
			int valueOrDefault2 = ConfigCommonParamById.GetIntConfig("MaxTimeLength").GetValueOrDefault(40);
			StringBuilder stringBuilder = new StringBuilder();
			if (num > 1)
			{
				int num2 = Math.Min(num - 1, valueOrDefault2);
				stringBuilder.Append(' ', num2 * valueOrDefault);
			}
			StringBuilder stringBuilder2 = stringBuilder;
			StringBuilder stringBuilder3 = stringBuilder2;
			StringBuilder.AppendInterpolatedStringHandler appendInterpolatedStringHandler = new StringBuilder.AppendInterpolatedStringHandler(1, 1, stringBuilder2);
			appendInterpolatedStringHandler.AppendFormatted<int>(num);
			appendInterpolatedStringHandler.AppendLiteral("″");
			stringBuilder3.Append(ref appendInterpolatedStringHandler);
			text2.SetText(stringBuilder.ToString(), true);
			text3.SetText(this.PhoneMsgChatData.ContentStr, true);
			break;
		}
		default:
			return;
		}
	}

	// Token: 0x06010786 RID: 67462 RVA: 0x004D15A4 File Offset: 0x004CF7A4
	[NullableContext(1)]
	private PhoneMsgEmojiItem CreatePhoneMsgEmojiItem()
	{
		return new PhoneMsgEmojiItem
		{
			OnClickDelegate = new Action<int>(this.OnOptionItemClickInternal)
		};
	}

	// Token: 0x06010787 RID: 67463 RVA: 0x004D15BD File Offset: 0x004CF7BD
	[NullableContext(1)]
	private PhoneMsgPhraseItem CreatePhoneMsgPhraseItem()
	{
		return new PhoneMsgPhraseItem
		{
			OnClickDelegate = new Action<int>(this.OnOptionItemClickInternal)
		};
	}

	// Token: 0x06010788 RID: 67464 RVA: 0x004D15D6 File Offset: 0x004CF7D6
	private void OnOptionItemClickInternal(int selectedIndex)
	{
		Action<int, int> onOptionItemClickDelegate = this.OnOptionItemClickDelegate;
		if (onOptionItemClickDelegate == null)
		{
			return;
		}
		onOptionItemClickDelegate(base.GridIndex, selectedIndex);
	}

	// Token: 0x06010789 RID: 67465 RVA: 0x004D15EF File Offset: 0x004CF7EF
	private void ResetTextOptionAnimItem()
	{
		UUIItem item = base.GetItem(20);
		item.SetAlpha(this.TextOptionAnimItemAlpha);
		item.SetAnchorOffsetY(this.TextOptionAnimItemAnchorOffsetY);
	}

	// Token: 0x0601078A RID: 67466 RVA: 0x004D1610 File Offset: 0x004CF810
	private void ResetEmojiOptionAnimItem()
	{
		UUIItem item = base.GetItem(16);
		item.SetAlpha(this.EmojiOptionAnimItemAlpha);
		item.SetStretchBottom(this.EmojiOptionAnimItemStretchBottom);
	}

	// Token: 0x0601078B RID: 67467 RVA: 0x004D1634 File Offset: 0x004CF834
	[NullableContext(1)]
	public string GetChatContentSequenceName(bool afterAnswer = false)
	{
		switch (this.PhoneMsgChatData.ContentType)
		{
		case EChatMsgType.Text:
			if (!afterAnswer)
			{
				return "Send_Text";
			}
			return "Send_Text_NoHead";
		case EChatMsgType.Emoji:
			if (!afterAnswer)
			{
				return "Emote_In";
			}
			return "Emote_In_NoHead";
		case EChatMsgType.Attachment:
		{
			PhoneMessageAttachment? config = ConfigPhoneMessageAttachmentById.GetConfig(this.PhoneMsgChatData.ContentNum, true);
			if (((config != null) ? config.GetValueOrDefault().Type : null) == "InformationView")
			{
				if (!afterAnswer)
				{
					return "Info_In";
				}
				return "Info_In_NoHead";
			}
			else
			{
				if (!afterAnswer)
				{
					return "Pic_In";
				}
				return "Pic_In_NoHead";
			}
			break;
		}
		case EChatMsgType.TextOption:
			return "Reply_In";
		case EChatMsgType.EmojiOption:
			if (!afterAnswer)
			{
				return "Reply_Emote_In";
			}
			return "Reply_Emote_In";
		case EChatMsgType.Voice:
			if (!afterAnswer)
			{
				return "Send_Text";
			}
			return "Send_Text_NoHead";
		}
		return "";
	}

	// Token: 0x0601078C RID: 67468 RVA: 0x004D1720 File Offset: 0x004CF920
	[NullableContext(1)]
	private void OnEventSequence(string sequenceName, string eventName)
	{
		if (this.DialogSequencePlayer != null && eventName == "Sequence_bubble_In" && this.IsUnPlayStart)
		{
			this.IsUnPlayStart = false;
			this.DialogSequencePlayer.StopCurrentSequence(false, false);
			this.DialogSequencePlayer.PlayLevelSequenceByName("Start", false, null, false);
		}
	}

	// Token: 0x0601078D RID: 67469 RVA: 0x004D177C File Offset: 0x004CF97C
	public UniTask PlayChatContentAnimationAsync()
	{
		PhoneMsgSelfChatItem.<PlayChatContentAnimationAsync>d__41 <PlayChatContentAnimationAsync>d__;
		<PlayChatContentAnimationAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayChatContentAnimationAsync>d__.<>4__this = this;
		<PlayChatContentAnimationAsync>d__.<>1__state = -1;
		<PlayChatContentAnimationAsync>d__.<>t__builder.Start<PhoneMsgSelfChatItem.<PlayChatContentAnimationAsync>d__41>(ref <PlayChatContentAnimationAsync>d__);
		return <PlayChatContentAnimationAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0601078E RID: 67470 RVA: 0x004D17C0 File Offset: 0x004CF9C0
	public UniTask PlayChatContentAnimationAsync(bool afterAnswer)
	{
		PhoneMsgSelfChatItem.<PlayChatContentAnimationAsync>d__42 <PlayChatContentAnimationAsync>d__;
		<PlayChatContentAnimationAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayChatContentAnimationAsync>d__.<>4__this = this;
		<PlayChatContentAnimationAsync>d__.afterAnswer = afterAnswer;
		<PlayChatContentAnimationAsync>d__.<>1__state = -1;
		<PlayChatContentAnimationAsync>d__.<>t__builder.Start<PhoneMsgSelfChatItem.<PlayChatContentAnimationAsync>d__42>(ref <PlayChatContentAnimationAsync>d__);
		return <PlayChatContentAnimationAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0601078F RID: 67471 RVA: 0x004D180B File Offset: 0x004CFA0B
	public void StopChatContentAnimation()
	{
		this.StopChatContentAnimation(false);
	}

	// Token: 0x06010790 RID: 67472 RVA: 0x004D1814 File Offset: 0x004CFA14
	public void StopChatContentAnimation(bool afterAnswer)
	{
		string chatContentSequenceName = this.GetChatContentSequenceName(afterAnswer);
		if (StringUtils.IsEmpty(chatContentSequenceName))
		{
			return;
		}
		this.LevelSequencePlayer.StopSequenceByKey(chatContentSequenceName, false, true);
		this.StopRedDotAnimation();
	}

	// Token: 0x06010791 RID: 67473 RVA: 0x004D1848 File Offset: 0x004CFA48
	public UniTask PlayRedDotAnimationAsync()
	{
		PhoneMsgSelfChatItem.<PlayRedDotAnimationAsync>d__45 <PlayRedDotAnimationAsync>d__;
		<PlayRedDotAnimationAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayRedDotAnimationAsync>d__.<>4__this = this;
		<PlayRedDotAnimationAsync>d__.<>1__state = -1;
		<PlayRedDotAnimationAsync>d__.<>t__builder.Start<PhoneMsgSelfChatItem.<PlayRedDotAnimationAsync>d__45>(ref <PlayRedDotAnimationAsync>d__);
		return <PlayRedDotAnimationAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06010792 RID: 67474 RVA: 0x004D188B File Offset: 0x004CFA8B
	public void StopRedDotAnimation()
	{
		PhoneMsgChatData phoneMsgChatData = this.PhoneMsgChatData;
		if (phoneMsgChatData == null || !phoneMsgChatData.IsSendError)
		{
			return;
		}
		this.LevelSequencePlayer.StopSequenceByKey("Red_Tips", false, true);
	}

	// Token: 0x06010793 RID: 67475 RVA: 0x004D18B8 File Offset: 0x004CFAB8
	public UniTask PlayTextOptionAnimationAsync()
	{
		PhoneMsgSelfChatItem.<PlayTextOptionAnimationAsync>d__47 <PlayTextOptionAnimationAsync>d__;
		<PlayTextOptionAnimationAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayTextOptionAnimationAsync>d__.<>4__this = this;
		<PlayTextOptionAnimationAsync>d__.<>1__state = -1;
		<PlayTextOptionAnimationAsync>d__.<>t__builder.Start<PhoneMsgSelfChatItem.<PlayTextOptionAnimationAsync>d__47>(ref <PlayTextOptionAnimationAsync>d__);
		return <PlayTextOptionAnimationAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06010794 RID: 67476 RVA: 0x004D18FB File Offset: 0x004CFAFB
	public void StopTextOptionAnimation()
	{
		this.LevelSequencePlayer.StopSequenceByKey("Reply_Out", false, true);
	}

	// Token: 0x06010795 RID: 67477 RVA: 0x004D1910 File Offset: 0x004CFB10
	public UniTask PlayEmojiOptionAnimationAsync()
	{
		PhoneMsgSelfChatItem.<PlayEmojiOptionAnimationAsync>d__49 <PlayEmojiOptionAnimationAsync>d__;
		<PlayEmojiOptionAnimationAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayEmojiOptionAnimationAsync>d__.<>4__this = this;
		<PlayEmojiOptionAnimationAsync>d__.<>1__state = -1;
		<PlayEmojiOptionAnimationAsync>d__.<>t__builder.Start<PhoneMsgSelfChatItem.<PlayEmojiOptionAnimationAsync>d__49>(ref <PlayEmojiOptionAnimationAsync>d__);
		return <PlayEmojiOptionAnimationAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06010796 RID: 67478 RVA: 0x004D1953 File Offset: 0x004CFB53
	public void StopEmojiOptionAnimation()
	{
		this.LevelSequencePlayer.StopSequenceByKey("Reply_Emote_Out", false, true);
	}

	// Token: 0x06010797 RID: 67479 RVA: 0x004D1968 File Offset: 0x004CFB68
	public UniTask PlayOptionHideAnimationAsync()
	{
		PhoneMsgSelfChatItem.<PlayOptionHideAnimationAsync>d__51 <PlayOptionHideAnimationAsync>d__;
		<PlayOptionHideAnimationAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayOptionHideAnimationAsync>d__.<>4__this = this;
		<PlayOptionHideAnimationAsync>d__.<>1__state = -1;
		<PlayOptionHideAnimationAsync>d__.<>t__builder.Start<PhoneMsgSelfChatItem.<PlayOptionHideAnimationAsync>d__51>(ref <PlayOptionHideAnimationAsync>d__);
		return <PlayOptionHideAnimationAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06010798 RID: 67480 RVA: 0x004D19AB File Offset: 0x004CFBAB
	public void StopOptionHideAnimation()
	{
		if (this.PhoneMsgChatData.ContentType == EChatMsgType.TextOption)
		{
			this.StopTextOptionAnimation();
			return;
		}
		if (this.PhoneMsgChatData.ContentType == EChatMsgType.EmojiOption)
		{
			this.StopEmojiOptionAnimation();
		}
	}

	// Token: 0x06010799 RID: 67481 RVA: 0x004D19D8 File Offset: 0x004CFBD8
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

	// Token: 0x0601079A RID: 67482 RVA: 0x004D1A0A File Offset: 0x004CFC0A
	private void OnBtnSelfClick()
	{
		Action<int> onItemClickDelegate = this.OnItemClickDelegate;
		if (onItemClickDelegate == null)
		{
			return;
		}
		onItemClickDelegate(base.GridIndex);
	}

	// Token: 0x0601079B RID: 67483 RVA: 0x004D1A24 File Offset: 0x004CFC24
	public UniTask PlayVoicePlayingAnimationAsync()
	{
		PhoneMsgSelfChatItem.<PlayVoicePlayingAnimationAsync>d__55 <PlayVoicePlayingAnimationAsync>d__;
		<PlayVoicePlayingAnimationAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayVoicePlayingAnimationAsync>d__.<>4__this = this;
		<PlayVoicePlayingAnimationAsync>d__.<>1__state = -1;
		<PlayVoicePlayingAnimationAsync>d__.<>t__builder.Start<PhoneMsgSelfChatItem.<PlayVoicePlayingAnimationAsync>d__55>(ref <PlayVoicePlayingAnimationAsync>d__);
		return <PlayVoicePlayingAnimationAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0601079C RID: 67484 RVA: 0x004D1A68 File Offset: 0x004CFC68
	public void SkipVoicePlayingAnimation()
	{
		if (this.VoiceCustomPromise != null)
		{
			this.VoiceCustomPromise.SetResult(false);
			this.VoiceCustomPromise = null;
		}
		this.StopVoicePlayingAnimation();
		if (this.VoiceHandle != null)
		{
			TimerSystem.GameplayTimeInstance.Remove(this.VoiceHandle);
			this.VoiceHandle = null;
		}
	}

	// Token: 0x0601079D RID: 67485 RVA: 0x004D1AB6 File Offset: 0x004CFCB6
	public void StopVoicePlayingAnimation()
	{
		this.LevelSequencePlayer.StopSequenceByKey("Voice_Play_Loop", false, true);
	}

	// Token: 0x0601079E RID: 67486 RVA: 0x004D1ACC File Offset: 0x004CFCCC
	public UniTask ShowVoiceTextPanel(Action afterShow = null)
	{
		PhoneMsgSelfChatItem.<ShowVoiceTextPanel>d__58 <ShowVoiceTextPanel>d__;
		<ShowVoiceTextPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<ShowVoiceTextPanel>d__.<>1__state = -1;
		<ShowVoiceTextPanel>d__.<>t__builder.Start<PhoneMsgSelfChatItem.<ShowVoiceTextPanel>d__58>(ref <ShowVoiceTextPanel>d__);
		return <ShowVoiceTextPanel>d__.<>t__builder.Task;
	}

	// Token: 0x04009234 RID: 37428
	protected PhoneMsgChatData PhoneMsgChatData;

	// Token: 0x04009235 RID: 37429
	protected LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x04009236 RID: 37430
	private AActor DynamicDialogActor;

	// Token: 0x04009237 RID: 37431
	private LevelSequencePlayer DialogSequencePlayer;

	// Token: 0x04009238 RID: 37432
	[Nullable(1)]
	private readonly List<string> PhraseDataList = new List<string>();

	// Token: 0x04009239 RID: 37433
	[Nullable(1)]
	private readonly List<int> EmojiDataList = new List<int>();

	// Token: 0x0400923A RID: 37434
	private bool IsUnPlayStart = true;

	// Token: 0x0400923B RID: 37435
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<PhoneMsgPhraseItem, string> PhraseLayout;

	// Token: 0x0400923C RID: 37436
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<PhoneMsgEmojiItem, int> EmojiLayout;

	// Token: 0x0400923D RID: 37437
	private float TextOptionAnimItemAlpha;

	// Token: 0x0400923E RID: 37438
	private float TextOptionAnimItemAnchorOffsetY;

	// Token: 0x0400923F RID: 37439
	private float EmojiOptionAnimItemAlpha;

	// Token: 0x04009240 RID: 37440
	private float EmojiOptionAnimItemStretchBottom;

	// Token: 0x04009241 RID: 37441
	private TimerHandle VoiceHandle;

	// Token: 0x04009242 RID: 37442
	private CustomPromise<bool> VoiceCustomPromise;

	// Token: 0x04009243 RID: 37443
	protected PhoneMsgLinkButton LinkButton;

	// Token: 0x04009244 RID: 37444
	public Action<int, int> OnOptionItemClickDelegate;

	// Token: 0x04009245 RID: 37445
	public Action<int> OnItemClickDelegate;

	// Token: 0x04009246 RID: 37446
	[Nullable(1)]
	private string DynamicDialogActorPath = string.Empty;
}
