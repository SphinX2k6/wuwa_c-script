using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Personal;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000C58 RID: 3160
[NullableContext(2)]
[Nullable(0)]
public class ChatContent : UiPanelBase
{
	// Token: 0x0600841D RID: 33821 RVA: 0x00286B4C File Offset: 0x00284D4C
	protected unsafe override void OnRegisterComponent()
	{
		int num = 12;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		if (!Info.Instance.IsInTouch())
		{
			this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(12, typeof(UUIItem)));
		}
	}

	// Token: 0x0600841E RID: 33822 RVA: 0x00286D2C File Offset: 0x00284F2C
	protected override UniTask OnBeforeStartAsync()
	{
		ChatContent.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ChatContent.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600841F RID: 33823 RVA: 0x00286D70 File Offset: 0x00284F70
	protected override void OnStart()
	{
		UUIItem item = base.GetItem(0);
		this.PlayerHeadItem = new PlayerHeadItem(item.GetOwner());
		this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
		this.AddEvents();
	}

	// Token: 0x06008420 RID: 33824 RVA: 0x00286DAD File Offset: 0x00284FAD
	protected override void OnBeforeDestroy()
	{
		this.PlayerHeadItem = null;
		PlayerTitleItem titleItem = this.TitleItem;
		if (titleItem != null)
		{
			titleItem.Destroy(null);
		}
		this.RemoveEvents();
	}

	// Token: 0x06008421 RID: 33825 RVA: 0x00286DCE File Offset: 0x00284FCE
	private void AddEvents()
	{
		EventSystem.Instance.Add<int>(EEventName.OnChatPlayerInfoChanged, new Action<int>(this.OnChatPlayerInfoChanged));
	}

	// Token: 0x06008422 RID: 33826 RVA: 0x00286DEC File Offset: 0x00284FEC
	private void RemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.OnChatPlayerInfoChanged, new Action<int>(this.OnChatPlayerInfoChanged));
	}

	// Token: 0x06008423 RID: 33827 RVA: 0x00286E0A File Offset: 0x0028500A
	private void OnChatPlayerInfoChanged(int playerId)
	{
		this.RefreshPlayerTexture();
		this.RefreshPlayerNameAndTitle();
		this.PlayerStartAnimation();
	}

	// Token: 0x06008424 RID: 33828 RVA: 0x00286E1E File Offset: 0x0028501E
	[NullableContext(1)]
	public void Refresh(ChatContentData data)
	{
		this.ChatContentData = data;
		this.RefreshPlayerTexture();
		this.RefreshContent();
		this.RefreshPlayerNameAndTitle();
		this.RefreshTimeText();
		this.RefreshThirdPartyItem();
	}

	// Token: 0x06008425 RID: 33829 RVA: 0x00286E48 File Offset: 0x00285048
	private void RefreshPlayerTexture()
	{
		PersonalModel instance = PersonalModel.Instance;
		int num = (this.ChatContentData == null) ? 0 : this.ChatContentData.SenderPlayerId;
		PersonalInfoData personalInfoData = instance.GetPersonalInfoData();
		if (personalInfoData != null && personalInfoData.PlayerId == num)
		{
			this.PlayerHeadItem.RefreshByRoleIdUseCard(instance.GetHeadPhotoId());
			return;
		}
		ChatPlayerData chatPlayerData = ChatModel.Instance.GetChatPlayerData(num);
		if (chatPlayerData == null)
		{
			return;
		}
		FriendData friendById = FriendModel.Instance.GetFriendById(num);
		if (friendById != null)
		{
			PlayerHeadItem playerHeadItem = this.PlayerHeadItem;
			if (playerHeadItem != null)
			{
				playerHeadItem.SetIsGray(!friendById.PlayerIsOnline);
			}
		}
		int? num2 = (chatPlayerData != null) ? new int?(chatPlayerData.GetPlayerIcon()) : null;
		if (num2 != null)
		{
			this.PlayerHeadItem.RefreshByRoleIdUseCard(num2.Value);
			return;
		}
		this.PlayerHeadItem.RefreshByPlayerId(num, true);
	}

	// Token: 0x06008426 RID: 33830 RVA: 0x00286F18 File Offset: 0x00285118
	private void RefreshContent()
	{
		UUIItem item = base.GetItem(5);
		UUIItem expressionItem = base.GetItem(3);
		if (this.ChatContentData.ContentType == ChatContentType.Text)
		{
			UUIText text = base.GetText(1);
			string content = this.ChatContentData.Content;
			text.SetText(content, true);
			item.SetUIActive(true);
			expressionItem.SetUIActive(false);
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Chat;
			ELogAuthor author = ELogAuthor.LJQ;
			string message = "表情:" + this.ChatContentData.Content;
			string item2 = "expressionItemActive";
			UUIItem expressionItem2 = expressionItem;
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>(item2, (expressionItem2 != null) ? new bool?(expressionItem2.IsUIActiveSelf()) : null);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}
		if (this.ChatContentData.ContentType == ChatContentType.Emoji)
		{
			UUITexture texture = base.GetTexture(4);
			int num = int.Parse(this.ChatContentData.Content);
			ChatExpression? expressionConfig = ChatConfig.Instance.GetExpressionConfig(num);
			if (expressionConfig == null)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.Chat;
				ELogAuthor author2 = ELogAuthor.LJQ;
				string message2 = "表情表找不到对应的Id";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("expressionId", num);
				instance2.Warn(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				item.SetUIActive(false);
				expressionItem.SetUIActive(false);
				return;
			}
			string expressionTexturePath = expressionConfig.Value.ExpressionTexturePath;
			base.SetTextureByPath(expressionTexturePath, texture, null, delegate(bool result)
			{
				expressionItem.SetUIActive(result);
			});
			item.SetUIActive(false);
		}
	}

	// Token: 0x06008427 RID: 33831 RVA: 0x0028709C File Offset: 0x0028529C
	private void RefreshThirdPartyItem()
	{
		if (KuroSdkController.Instance.NeedShowThirdPartyId())
		{
			string text = this.ChatContentData.ThirdOnlineId;
			PersonalModel instance = PersonalModel.Instance;
			int senderPlayerId = this.ChatContentData.SenderPlayerId;
			PersonalInfoData personalInfoData = instance.GetPersonalInfoData();
			string value = null;
			if (personalInfoData != null && personalInfoData.PlayerId == senderPlayerId)
			{
				value = instance.GetThirdUserId();
			}
			else
			{
				FriendData friendById = FriendModel.Instance.GetFriendById(senderPlayerId);
				if (friendById != null)
				{
					value = friendById.GetSdkUserId();
					text = friendById.GetSdkOnlineId();
				}
			}
			bool flag = !string.IsNullOrEmpty(value) || !string.IsNullOrEmpty(text);
			UUITexture texture = base.GetTexture(9);
			if (texture != null)
			{
				texture.SetUIActive(flag);
			}
			UUIItem item = base.GetItem(8);
			if (item != null)
			{
				item.SetUIActive(true);
			}
			string thirdPartyLogoTexturePath = UiResourceConfig.Instance.GetThirdPartyLogoTexturePath(ELogoSize.Medium);
			base.SetTextureByPath(thirdPartyLogoTexturePath, base.GetTexture(9), null, null);
			UUIText text2 = base.GetText(10);
			if (text2 != null)
			{
				text2.SetUIActive(flag);
			}
			UUIItem item2 = base.GetItem(11);
			if (item2 != null)
			{
				item2.SetUIActive(!flag);
			}
			if (flag)
			{
				UUIText text3 = base.GetText(10);
				if (text3 != null)
				{
					text3.SetText(text, true);
				}
				string thirdPartyTextColor = UiResourceConfig.Instance.GetThirdPartyTextColor(EConsoleColorSet.Set1);
				UUIText text4 = base.GetText(10);
				if (text4 == null)
				{
					return;
				}
				text4.SetColor(FColor.FromHex(thirdPartyTextColor));
				return;
			}
			else
			{
				UUIText text5 = base.GetText(10);
				if (text5 == null)
				{
					return;
				}
				text5.SetText("", true);
				return;
			}
		}
		else
		{
			UUITexture texture2 = base.GetTexture(9);
			if (texture2 != null)
			{
				texture2.SetUIActive(false);
			}
			UUIText text6 = base.GetText(10);
			if (text6 != null)
			{
				text6.SetUIActive(false);
			}
			UUIItem item3 = base.GetItem(8);
			if (item3 != null)
			{
				item3.SetUIActive(false);
			}
			UUIItem item4 = base.GetItem(11);
			if (item4 == null)
			{
				return;
			}
			item4.SetUIActive(false);
			return;
		}
	}

	// Token: 0x06008428 RID: 33832 RVA: 0x00287254 File Offset: 0x00285454
	private void RefreshPlayerNameAndTitle()
	{
		int num = (this.ChatContentData == null) ? 0 : this.ChatContentData.SenderPlayerId;
		UUIText text = base.GetText(6);
		EChatRoomType echatRoomType = (this.ChatContentData == null) ? EChatRoomType.None : this.ChatContentData.ChatRoomType;
		if (echatRoomType == EChatRoomType.Team || echatRoomType == EChatRoomType.World)
		{
			PersonalInfoData personalInfoData = PersonalModel.Instance.GetPersonalInfoData();
			if (personalInfoData != null && personalInfoData.PlayerId == num)
			{
				text.SetText(personalInfoData.Name, true);
				PlayerTitleItem titleItem = this.TitleItem;
				if (titleItem != null)
				{
					titleItem.Refresh(personalInfoData.CurPlayerTitleId, personalInfoData.CurPlayerTitleLevel, new int?(personalInfoData.Sex));
				}
			}
			else
			{
				FriendData friendById = FriendModel.Instance.GetFriendById(num);
				if (friendById != null)
				{
					string friendRemark = friendById.FriendRemark;
					if (!StringUtils.IsEmpty(friendRemark))
					{
						text.SetText(friendRemark, true);
					}
					else
					{
						text.SetText(friendById.PlayerName, true);
					}
					PlayerTitleItem titleItem2 = this.TitleItem;
					if (titleItem2 != null)
					{
						titleItem2.Refresh(new int?(friendById.PlayerTitleId), new int?(friendById.PlayerTitleStarLevel), new int?(friendById.PlayerSex));
					}
				}
				else
				{
					ChatPlayerData chatPlayerData = ChatModel.Instance.GetChatPlayerData(num);
					if (chatPlayerData == null)
					{
						text.SetUIActive(false);
						PlayerTitleItem titleItem3 = this.TitleItem;
						if (titleItem3 == null)
						{
							return;
						}
						titleItem3.GetRootItem().SetUIActive(false);
						return;
					}
					else
					{
						text.SetText(chatPlayerData.GetPlayerName(), true);
						PlayerTitleItem titleItem4 = this.TitleItem;
						if (titleItem4 != null)
						{
							titleItem4.Refresh(new int?(chatPlayerData.GetPlayerTitleId()), chatPlayerData.GetPlayerTitleStarLevel(), new int?(chatPlayerData.GetSex()));
						}
					}
				}
			}
			text.SetUIActive(true);
			return;
		}
		text.SetUIActive(false);
		PlayerTitleItem titleItem5 = this.TitleItem;
		if (titleItem5 == null)
		{
			return;
		}
		titleItem5.GetRootItem().SetUIActive(false);
	}

	// Token: 0x06008429 RID: 33833 RVA: 0x00287400 File Offset: 0x00285600
	private void RefreshTimeText()
	{
		UUIText text = base.GetText(2);
		double timeStamp = this.ChatContentData.TimeStamp;
		double lastTimeStamp = this.ChatContentData.LastTimeStamp;
		double serverTime = TimeUtil.Instance.GetServerTime();
		if (timeStamp - lastTimeStamp < (double)ChatModel.Instance.ShowTimeDifferent && lastTimeStamp != 0.0)
		{
			text.SetUIActive(false);
			return;
		}
		DateTime dataFromTimeStamp = TimeUtil.Instance.GetDataFromTimeStamp(timeStamp);
		DateTime dataFromTimeStamp2 = TimeUtil.Instance.GetDataFromTimeStamp(serverTime);
		if (dataFromTimeStamp.Year == dataFromTimeStamp2.Year && dataFromTimeStamp.Month == dataFromTimeStamp2.Month && dataFromTimeStamp.Day == dataFromTimeStamp2.Day)
		{
			LguiUtil.Instance.SetLocalText(text, "HourText", new <>z__ReadOnlyArray<object>(new object[]
			{
				dataFromTimeStamp.Hour.ToString("D2"),
				dataFromTimeStamp.Minute.ToString("D2")
			}));
			text.SetUIActive(true);
			return;
		}
		if ((dataFromTimeStamp.Month != dataFromTimeStamp2.Month || dataFromTimeStamp.Day != dataFromTimeStamp2.Day) && dataFromTimeStamp.Year == dataFromTimeStamp2.Year)
		{
			LguiUtil.Instance.SetLocalText(text, "DayText", new <>z__ReadOnlyArray<object>(new object[]
			{
				dataFromTimeStamp.Month.ToString("D2"),
				dataFromTimeStamp.Day.ToString("D2"),
				dataFromTimeStamp.Hour.ToString("D2"),
				dataFromTimeStamp.Minute.ToString("D2")
			}));
			text.SetUIActive(true);
			return;
		}
		if (dataFromTimeStamp.Year != dataFromTimeStamp2.Year)
		{
			LguiUtil.Instance.SetLocalText(text, "YearText", new <>z__ReadOnlyArray<object>(new object[]
			{
				dataFromTimeStamp.Year.ToString(),
				dataFromTimeStamp.Month.ToString("D2"),
				dataFromTimeStamp.Day.ToString("D2"),
				dataFromTimeStamp.Hour.ToString("D2"),
				dataFromTimeStamp.Minute.ToString("D2")
			}));
			text.SetUIActive(true);
			return;
		}
		text.SetUIActive(false);
	}

	// Token: 0x0600842A RID: 33834 RVA: 0x00287664 File Offset: 0x00285864
	private void PlayerStartAnimation()
	{
		LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
		if (levelSequencePlayer == null)
		{
			return;
		}
		levelSequencePlayer.PlayLevelSequenceByName("Start", false, null, false);
	}

	// Token: 0x0600842B RID: 33835 RVA: 0x00287691 File Offset: 0x00285891
	public UUIItem GetBtnItem()
	{
		if (!Info.Instance.IsInTouch())
		{
			return base.GetItem(12);
		}
		return null;
	}

	// Token: 0x040050BB RID: 20667
	private ChatContentData ChatContentData;

	// Token: 0x040050BC RID: 20668
	private PlayerHeadItem PlayerHeadItem;

	// Token: 0x040050BD RID: 20669
	private PlayerTitleItem TitleItem;

	// Token: 0x040050BE RID: 20670
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x02006F32 RID: 28466
	[NullableContext(0)]
	private class EChildType
	{
		// Token: 0x0402457F RID: 148863
		public const int PlayerHeadItem = 0;

		// Token: 0x04024580 RID: 148864
		public const int ChatText = 1;

		// Token: 0x04024581 RID: 148865
		public const int TimeText = 2;

		// Token: 0x04024582 RID: 148866
		public const int ExpressionItem = 3;

		// Token: 0x04024583 RID: 148867
		public const int ExpressionTexture = 4;

		// Token: 0x04024584 RID: 148868
		public const int TextContentItem = 5;

		// Token: 0x04024585 RID: 148869
		public const int PlayerNameText = 6;

		// Token: 0x04024586 RID: 148870
		public const int PlayerTitleItem = 7;

		// Token: 0x04024587 RID: 148871
		public const int ThirdPartyItem = 8;

		// Token: 0x04024588 RID: 148872
		public const int ThirdPartyTexture = 9;

		// Token: 0x04024589 RID: 148873
		public const int ThirdPartyText = 10;

		// Token: 0x0402458A RID: 148874
		public const int PcItem = 11;

		// Token: 0x0402458B RID: 148875
		public const int NavItem = 12;
	}
}
