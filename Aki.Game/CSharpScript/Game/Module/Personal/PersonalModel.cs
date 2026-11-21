using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.LevelGamePlay;
using CSharpScript.Game.Module.LinkedItem;
using CSharpScript.Game.ServerStorage;
using CSharpScript.Game.ServerStorage.Container;

namespace CSharpScript.Game.Module.Personal
{
	// Token: 0x020042BB RID: 17083
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class PersonalModel : ModelBase
	{
		// Token: 0x0602B3B3 RID: 177075 RVA: 0x00C252C8 File Offset: 0x00C234C8
		protected override bool OnInit()
		{
			if (this.PersonalInfoData == null)
			{
				this.PersonalInfoData = new PersonalInfoData();
			}
			return true;
		}

		// Token: 0x0602B3B4 RID: 177076 RVA: 0x00C252E0 File Offset: 0x00C234E0
		public void InitPlayerHeadData(int[] playerHeadIds)
		{
			this.PlayerHeadDataMap.Clear();
			IReadOnlyList<PlayerHeadRe> allPlayerHeadConfig = PersonalConfig.Instance.GetAllPlayerHeadConfig();
			if (allPlayerHeadConfig == null)
			{
				return;
			}
			foreach (PlayerHeadRe config in allPlayerHeadConfig)
			{
				PlayerHeadData playerHeadData = new PlayerHeadData(config);
				this.PlayerHeadDataMap[playerHeadData.Id] = playerHeadData;
			}
			this.InitMainRoleSkinToHeadDataMap();
			this.UpdatePlayerHeadData(playerHeadIds);
		}

		// Token: 0x0602B3B5 RID: 177077 RVA: 0x00C25360 File Offset: 0x00C23560
		private void InitMainRoleSkinToHeadDataMap()
		{
			this.HeadDataToMainRoleSkinMap.Clear();
			foreach (KeyValuePair<int, PlayerHeadData> keyValuePair in this.PlayerHeadDataMap)
			{
				PlayerHeadData value = keyValuePair.Value;
				int roleSkinId = value.Config.RoleSkinId;
				if (roleSkinId > 0)
				{
					RoleSkinData roleSkinData = RoleSkinModel.Instance.GetRoleSkinData(roleSkinId);
					if (roleSkinData != null && RoleModel.Instance.IsMainRole(roleSkinData.GetRoleId()))
					{
						this.HeadDataToMainRoleSkinMap[value.Id] = roleSkinData.GetRoleId();
					}
				}
			}
		}

		// Token: 0x0602B3B6 RID: 177078 RVA: 0x00C25410 File Offset: 0x00C23610
		public void UpdatePlayerHeadData(int[] playerHeadIds)
		{
			foreach (int playerHeadId in playerHeadIds)
			{
				this.UnLockPlayerHeadData(playerHeadId);
			}
		}

		// Token: 0x0602B3B7 RID: 177079 RVA: 0x00C25438 File Offset: 0x00C23638
		public void UnLockPlayerHeadData(int playerHeadId)
		{
			PlayerHeadData playerHeadData = this.GetPlayerHeadData(playerHeadId, true);
			if (playerHeadData == null)
			{
				return;
			}
			playerHeadData.Lock = false;
		}

		// Token: 0x0602B3B8 RID: 177080 RVA: 0x00C25459 File Offset: 0x00C23659
		protected override bool OnClear()
		{
			this.PersonalInfoData = null;
			NewFlagModel.Instance.SaveNewFlagConfig(ELocalStoragePlayerKey.PersonalDataItem);
			return true;
		}

		// Token: 0x0602B3B9 RID: 177081 RVA: 0x00C25470 File Offset: 0x00C23670
		[NullableContext(2)]
		public PersonalInfoData GetPersonalInfoData()
		{
			return this.PersonalInfoData;
		}

		// Token: 0x0602B3BA RID: 177082 RVA: 0x00C25478 File Offset: 0x00C23678
		public void SetRoleShowList(IReadOnlyList<Aki.Protocol.RoleShowEntry> roleShowEntry)
		{
			this.PersonalInfoData.RoleShowList = new List<global::RoleShowEntry>();
			int count = roleShowEntry.Count;
			for (int i = 0; i < count; i++)
			{
				Aki.Protocol.RoleShowEntry roleShowEntry2 = roleShowEntry[i];
				this.PersonalInfoData.RoleShowList.Add(new global::RoleShowEntry(roleShowEntry2.RoleId, roleShowEntry2.Level));
			}
		}

		// Token: 0x0602B3BB RID: 177083 RVA: 0x00C254D4 File Offset: 0x00C236D4
		public void UpdateRoleShowList(int[] roleIdList)
		{
			this.PersonalInfoData.RoleShowList = new List<global::RoleShowEntry>();
			int num = roleIdList.Length;
			for (int i = 0; i < num; i++)
			{
				int num2 = roleIdList[i];
				RoleDataBase roleDataById = RoleModel.Instance.GetRoleDataById(num2, true);
				RoleLevelData roleLevelData = (roleDataById != null) ? roleDataById.GetLevelData() : null;
				if (roleLevelData != null)
				{
					this.PersonalInfoData.RoleShowList.Add(new global::RoleShowEntry(num2, roleLevelData.GetLevel()));
				}
			}
			EventSystem.Instance.Emit(EEventName.OnRoleShowListChange);
		}

		// Token: 0x0602B3BC RID: 177084 RVA: 0x00C2554D File Offset: 0x00C2374D
		public List<global::RoleShowEntry> GetRoleShowList()
		{
			return this.PersonalInfoData.RoleShowList;
		}

		// Token: 0x0602B3BD RID: 177085 RVA: 0x00C2555A File Offset: 0x00C2375A
		public void SetCardShowList(List<int> cardShowList)
		{
			this.PersonalInfoData.CardShowList = cardShowList;
		}

		// Token: 0x0602B3BE RID: 177086 RVA: 0x00C25568 File Offset: 0x00C23768
		public List<int> GetCardShowList()
		{
			return this.PersonalInfoData.CardShowList;
		}

		// Token: 0x0602B3BF RID: 177087 RVA: 0x00C25575 File Offset: 0x00C23775
		public void SetCurCardId(int cardId)
		{
			this.PersonalInfoData.CurCardId = new int?(cardId);
			EventSystem.Instance.Emit(EEventName.OnCardChange);
		}

		// Token: 0x0602B3C0 RID: 177088 RVA: 0x00C25598 File Offset: 0x00C23798
		public int GetCurCardId()
		{
			if (this.PersonalInfoData.CurCardId != null)
			{
				int? curCardId = this.PersonalInfoData.CurCardId;
				int num = 0;
				if (curCardId.GetValueOrDefault() > num & curCardId != null)
				{
					return this.PersonalInfoData.CurCardId.Value;
				}
			}
			return FriendConfig.Instance.GetDefaultBackgroundCardId();
		}

		// Token: 0x0602B3C1 RID: 177089 RVA: 0x00C255F4 File Offset: 0x00C237F4
		public void SetBirthday(int birthday)
		{
			this.PersonalInfoData.Birthday = birthday;
			EventSystem.Instance.Emit(EEventName.OnBirthChange);
		}

		// Token: 0x0602B3C2 RID: 177090 RVA: 0x00C25612 File Offset: 0x00C23812
		public void SetBirthdayDisplay(bool display)
		{
			this.PersonalInfoData.IsBirthdayDisplay = display;
			EventSystem.Instance.Emit(EEventName.OnBirthDisplayChange);
		}

		// Token: 0x0602B3C3 RID: 177091 RVA: 0x00C25630 File Offset: 0x00C23830
		public void SetName(string name)
		{
			this.PersonalInfoData.Name = name;
		}

		// Token: 0x0602B3C4 RID: 177092 RVA: 0x00C2563E File Offset: 0x00C2383E
		public void SetPlayerId(int uid)
		{
			this.PersonalInfoData.PlayerId = uid;
		}

		// Token: 0x0602B3C5 RID: 177093 RVA: 0x00C2564C File Offset: 0x00C2384C
		public void SetModifyNameInfo(long lastModifyNameTime, string modifyName)
		{
			this.PersonalInfoData.LastModifyNameTime = (int)MathUtils.Instance.LongToBigInt(lastModifyNameTime);
			this.PersonalInfoData.ModifyName = modifyName;
			EventSystem.Instance.Emit(EEventName.OnModifyNameStateChange);
		}

		// Token: 0x0602B3C6 RID: 177094 RVA: 0x00C25681 File Offset: 0x00C23881
		public int GetBirthday()
		{
			return this.PersonalInfoData.Birthday;
		}

		// Token: 0x0602B3C7 RID: 177095 RVA: 0x00C2568E File Offset: 0x00C2388E
		public bool GetBirthdayDisplay()
		{
			return this.PersonalInfoData.IsBirthdayDisplay;
		}

		// Token: 0x0602B3C8 RID: 177096 RVA: 0x00C2569B File Offset: 0x00C2389B
		public void SetSignature(string sign)
		{
			this.PersonalInfoData.Signature = sign;
			PlayerInfoModel.Instance.ChangeStringProp(8, sign);
			EventSystem.Instance.Emit(EEventName.OnSignChange);
		}

		// Token: 0x0602B3C9 RID: 177097 RVA: 0x00C256C5 File Offset: 0x00C238C5
		public string GetSignature()
		{
			return this.PersonalInfoData.Signature;
		}

		// Token: 0x0602B3CA RID: 177098 RVA: 0x00C256D2 File Offset: 0x00C238D2
		public void SetHeadPhotoId(int headPhotoId)
		{
			this.PersonalInfoData.HeadPhotoId = new int?(headPhotoId);
			PlayerInfoModel.Instance.ChangeNumberProp(4, headPhotoId);
			EventSystem.Instance.Emit<int>(EEventName.OnHeadIconChange, headPhotoId);
		}

		// Token: 0x0602B3CB RID: 177099 RVA: 0x00C25704 File Offset: 0x00C23904
		public int GetHeadPhotoId()
		{
			if (this.PersonalInfoData.HeadPhotoId == null)
			{
				int? numberPropById = PlayerInfoModel.Instance.GetNumberPropById(EPlayerInfoNumber.HeadPhoto);
				this.PersonalInfoData.HeadPhotoId = numberPropById;
			}
			return this.PersonalInfoData.HeadPhotoId.Value;
		}

		// Token: 0x0602B3CC RID: 177100 RVA: 0x00C2574B File Offset: 0x00C2394B
		[NullableContext(2)]
		public string GetThirdUserId()
		{
			return this.PersonalInfoData.ThirdUserId;
		}

		// Token: 0x0602B3CD RID: 177101 RVA: 0x00C25758 File Offset: 0x00C23958
		public void SetCardUnlockList(CardShowEntry[] cardShowEntryList)
		{
			this.InitCardDataList();
			int num = cardShowEntryList.Length;
			for (int i = 0; i < num; i++)
			{
				CardShowEntry cardShowEntry = cardShowEntryList[i];
				PersonalCardData cardDataById = this.GetCardDataById(cardShowEntry.CardId);
				if (cardDataById == null)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.Personal;
					ELogAuthor author = ELogAuthor.BB;
					string message = "初始化卡牌,无效CardId";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("cardId", cardShowEntry.CardId);
					instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				}
				else
				{
					cardDataById.RefreshData(cardShowEntry.IsRead, true);
				}
			}
		}

		// Token: 0x0602B3CE RID: 177102 RVA: 0x00C257D4 File Offset: 0x00C239D4
		private void InitCardDataList()
		{
			this.PersonalInfoData.CardDataList = new List<PersonalCardData>();
			foreach (BackgroundCard backgroundCard in ConfigBackgroundCardAll.GetConfigList(true))
			{
				this.PersonalInfoData.CardDataList.Add(new PersonalCardData(backgroundCard.Id, false, false));
			}
		}

		// Token: 0x0602B3CF RID: 177103 RVA: 0x00C25848 File Offset: 0x00C23A48
		[NullableContext(2)]
		private PersonalCardData GetCardDataById(int cardId)
		{
			foreach (PersonalCardData personalCardData in this.PersonalInfoData.CardDataList)
			{
				if (personalCardData.CardId == cardId)
				{
					return personalCardData;
				}
			}
			return null;
		}

		// Token: 0x0602B3D0 RID: 177104 RVA: 0x00C258AC File Offset: 0x00C23AAC
		public void UpdateCardUnlockList(int cardId, bool isRead)
		{
			int count = this.PersonalInfoData.CardDataList.Count;
			for (int i = 0; i < count; i++)
			{
				PersonalCardData personalCardData = this.PersonalInfoData.CardDataList[i];
				if (personalCardData.CardId == cardId)
				{
					personalCardData.IsRead = isRead;
					EventSystem.Instance.Emit<int>(EEventName.OnPersonalCardRead, cardId);
					EventSystem.Instance.Emit(EEventName.OnPersonalCardRefreshRedDot);
					return;
				}
			}
		}

		// Token: 0x0602B3D1 RID: 177105 RVA: 0x00C2591C File Offset: 0x00C23B1C
		public void AddCardUnlockList(int cardId, bool isRead)
		{
			PersonalCardData cardDataById = this.GetCardDataById(cardId);
			if (cardDataById == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Personal;
				ELogAuthor author = ELogAuthor.BB;
				string message = "新解锁卡牌,无效CardId";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("cardId", cardId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			cardDataById.RefreshData(isRead, true);
			EventSystem.Instance.Emit(EEventName.OnPersonalCardRefreshRedDot);
		}

		// Token: 0x0602B3D2 RID: 177106 RVA: 0x00C25979 File Offset: 0x00C23B79
		public List<PersonalCardData> GetCardDataList()
		{
			return this.PersonalInfoData.CardDataList;
		}

		// Token: 0x0602B3D3 RID: 177107 RVA: 0x00C25988 File Offset: 0x00C23B88
		public bool GetPersonalCardRedDotState()
		{
			foreach (PersonalCardData personalCardData in this.PersonalInfoData.CardDataList)
			{
				if (personalCardData.IsUnLock && !personalCardData.IsRead)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x0602B3D4 RID: 177108 RVA: 0x00C259F0 File Offset: 0x00C23BF0
		public bool GetPersonalTitleRedDotState()
		{
			if (!FunctionModel.Instance.IsOpen(10082))
			{
				return false;
			}
			ServerStorageUtil.OverrideLocalBooleanToServerBoolean(ELocalStoragePlayerKey.PlayerTitleUnlockRedDot, EClientStorageSystemIdType.PlayerTitleUnlockRedDot, true);
			if ((ServerStorageModel.Instance.Get(EClientStorageSystemIdType.PlayerTitleUnlockRedDot) as ServerStorageBoolean).Get().GetValueOrDefault(true))
			{
				return true;
			}
			Dictionary<int, bool> player = LocalStorage.GetPlayer<Dictionary<int, bool>>(ELocalStoragePlayerKey.PlayerTitleRecord, null);
			if (player != null)
			{
				foreach (KeyValuePair<int, bool> keyValuePair in player)
				{
					if (keyValuePair.Value)
					{
						PersonalPlayerTitleData personalPlayerTitleData = this.PlayerTitleDataMap.ContainsKey(keyValuePair.Key) ? this.PlayerTitleDataMap[keyValuePair.Key] : null;
						if (personalPlayerTitleData == null || !personalPlayerTitleData.IsExpired())
						{
							return true;
						}
					}
				}
				return false;
			}
			return false;
		}

		// Token: 0x0602B3D5 RID: 177109 RVA: 0x00C25AD0 File Offset: 0x00C23CD0
		public EModifyNameState GetPersonalModifyNameState()
		{
			if (this.PersonalInfoData.ModifyName != "")
			{
				return EModifyNameState.UnderModification;
			}
			double serverTime = TimeUtil.Instance.GetServerTime();
			int? intConfig = ConfigCommonParamById.GetIntConfig("NameModifyCd");
			int? num = this.PersonalInfoData.LastModifyNameTime + intConfig;
			double num2 = serverTime;
			int? num3 = num;
			double? num4 = (num3 != null) ? new double?((double)num3.GetValueOrDefault()) : null;
			if (num2 > num4.GetValueOrDefault() & num4 != null)
			{
				return EModifyNameState.CanBeModified;
			}
			return EModifyNameState.UnModifiable;
		}

		// Token: 0x0602B3D6 RID: 177110 RVA: 0x00C25B7A File Offset: 0x00C23D7A
		public void SetLevel(int level)
		{
			this.PersonalInfoData.Level = level;
		}

		// Token: 0x0602B3D7 RID: 177111 RVA: 0x00C25B88 File Offset: 0x00C23D88
		public void SetWorldLevel(int worldLevel)
		{
			this.PersonalInfoData.WorldLevel = worldLevel;
		}

		// Token: 0x0602B3D8 RID: 177112 RVA: 0x00C25B98 File Offset: 0x00C23D98
		public bool CheckCanShowPersonalTip()
		{
			int? intConfig = ConfigCommonParamById.GetIntConfig("IndividualizationReddotConditionGroup");
			if (!LevelGeneralController.Instance.CheckCondition(intConfig.ToString(), null, true, Array.Empty<object>()))
			{
				return false;
			}
			ServerStorageUtil.OverrideLocalBooleanToServerBoolean(ELocalStoragePlayerKey.ShowPersonalTip, EClientStorageSystemIdType.ShowPersonalTip, true);
			return (ServerStorageModel.Instance.Get(EClientStorageSystemIdType.ShowPersonalTip) as ServerStorageBoolean).Get().GetValueOrDefault(true);
		}

		// Token: 0x0602B3D9 RID: 177113 RVA: 0x00C25BFC File Offset: 0x00C23DFC
		public void SetPersonalTipState(bool state)
		{
			if (this.CheckCanShowPersonalTip() == state)
			{
				return;
			}
			(ServerStorageModel.Instance.Get(EClientStorageSystemIdType.ShowPersonalTip) as ServerStorageBoolean).Set(new bool?(state));
			EventSystem.Instance.Emit(EEventName.OnPersonalTipStateSet);
		}

		// Token: 0x0602B3DA RID: 177114 RVA: 0x00C25C34 File Offset: 0x00C23E34
		[NullableContext(2)]
		public PlayerHeadData GetPlayerHeadData(int playerHeadId, bool needLog = true)
		{
			PlayerHeadData playerHeadData;
			this.PlayerHeadDataMap.TryGetValue(playerHeadId, out playerHeadData);
			if (playerHeadData == null && needLog)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Personal;
				ELogAuthor author = ELogAuthor.BB;
				string message = "获取玩家头像数据失败";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("playerHeadId", playerHeadId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			return playerHeadData;
		}

		// Token: 0x0602B3DB RID: 177115 RVA: 0x00C25C88 File Offset: 0x00C23E88
		public List<PlayerHeadData> GetPlayerShowHeadDataList()
		{
			List<PlayerHeadData> list = new List<PlayerHeadData>();
			int? curSelectMainRoleId = RoleModel.Instance.GetCurSelectMainRoleId();
			int sex = this.GetSex();
			foreach (KeyValuePair<int, PlayerHeadData> keyValuePair in this.PlayerHeadDataMap)
			{
				PlayerHeadData value = keyValuePair.Value;
				int num;
				if (!LinkedItemConfig.Instance.ShouldHide(value.Id, !value.Lock) && (!this.HeadDataToMainRoleSkinMap.TryGetValue(value.Id, out num) || (curSelectMainRoleId != null && curSelectMainRoleId.Value == num)))
				{
					int gender = value.Config.Gender;
					if (gender == -1 || gender == sex)
					{
						list.Add(value);
					}
				}
			}
			list.Sort(new Comparison<PlayerHeadData>(this.SortPlayerHeadList));
			return list;
		}

		// Token: 0x0602B3DC RID: 177116 RVA: 0x00C25D78 File Offset: 0x00C23F78
		private int SortPlayerHeadList(PlayerHeadData playerHeadA, PlayerHeadData playerHeadB)
		{
			int num = (playerHeadA.Lock > false) ? 1 : 0;
			int num2 = (playerHeadB.Lock > false) ? 1 : 0;
			if (num != num2)
			{
				return num - num2;
			}
			if (playerHeadB.Config.SortIndex != playerHeadA.Config.SortIndex)
			{
				return playerHeadB.Config.SortIndex - playerHeadA.Config.SortIndex;
			}
			return playerHeadB.Config.Id - playerHeadA.Config.Id;
		}

		// Token: 0x0602B3DD RID: 177117 RVA: 0x00C25DFC File Offset: 0x00C23FFC
		public int GetUnlockHeadNum()
		{
			int num = 0;
			using (List<PlayerHeadData>.Enumerator enumerator = this.GetPlayerShowHeadDataList().GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (!enumerator.Current.Lock)
					{
						num++;
					}
				}
			}
			return num;
		}

		// Token: 0x0602B3DE RID: 177118 RVA: 0x00C25E58 File Offset: 0x00C24058
		public void SetSex(int sex)
		{
			this.PersonalInfoData.Sex = sex;
		}

		// Token: 0x0602B3DF RID: 177119 RVA: 0x00C25E66 File Offset: 0x00C24066
		public int GetSex()
		{
			return this.PersonalInfoData.Sex;
		}

		// Token: 0x0602B3E0 RID: 177120 RVA: 0x00C25E74 File Offset: 0x00C24074
		public void InitPlayerTitleData(PlayerTitleInfo[] playerTitleInfoList, PlayerTitleLimitInfo[] playerTitleLimitInfoList = null)
		{
			this.PlayerTitleDataMap.Clear();
			foreach (PlayerTitleInfo playerTitleInfo in playerTitleInfoList)
			{
				PersonalPlayerTitleData personalPlayerTitleData = new PersonalPlayerTitleData(playerTitleInfo.PlayerTitleId, playerTitleInfo.IsUnlock);
				if (playerTitleInfo.ConditionTask != null)
				{
					if (playerTitleInfo.ConditionTask.Status == ConditionTaskState.ConditionTaskFinish)
					{
						personalPlayerTitleData.SetUnLockProgress(playerTitleInfo.ConditionTask.Target, playerTitleInfo.ConditionTask.Target);
					}
					else
					{
						personalPlayerTitleData.SetUnLockProgress(playerTitleInfo.ConditionTask.Current, playerTitleInfo.ConditionTask.Target);
					}
				}
				if (playerTitleInfo.ExtraInfo != 0)
				{
					personalPlayerTitleData.SetStarLevel(playerTitleInfo.ExtraInfo);
				}
				if (playerTitleInfo.UnlockTime != 0L)
				{
					long num = MathUtils.Instance.LongToNumber(playerTitleInfo.UnlockTime);
					personalPlayerTitleData.SetUnlockTime((double)num);
				}
				this.PlayerTitleDataMap[playerTitleInfo.PlayerTitleId] = personalPlayerTitleData;
			}
			if (playerTitleLimitInfoList != null)
			{
				foreach (PlayerTitleLimitInfo playerTitleLimitInfo in playerTitleLimitInfoList)
				{
					if (this.PlayerTitleDataMap.ContainsKey(playerTitleLimitInfo.PlayerTitleId))
					{
						PersonalPlayerTitleData personalPlayerTitleData2 = this.PlayerTitleDataMap[playerTitleLimitInfo.PlayerTitleId];
						if (playerTitleLimitInfo.BeginTime != 0L && playerTitleLimitInfo.EndTime != 0L)
						{
							double startTime = (double)MathUtils.Instance.LongToNumber(playerTitleLimitInfo.BeginTime);
							double endTime = (double)MathUtils.Instance.LongToNumber(playerTitleLimitInfo.EndTime);
							personalPlayerTitleData2.SetTimeLimit(startTime, endTime);
						}
					}
				}
			}
			this.PersonalInfoData.PlayerTitleDataList = new List<PersonalPlayerTitleData>(this.PlayerTitleDataMap.Values);
			EventSystem.Instance.Emit(EEventName.OnPlayerTitleRefreshRedDot);
		}

		// Token: 0x0602B3E1 RID: 177121 RVA: 0x00C26008 File Offset: 0x00C24208
		public void SetDressedPlayerTitle(int playerTitleId, int? starLevel = null)
		{
			this.PersonalInfoData.CurPlayerTitleId = new int?(playerTitleId);
			this.PersonalInfoData.CurPlayerTitleLevel = starLevel;
			PersonalPlayerTitleData personalPlayerTitleData;
			this.PlayerTitleDataMap.TryGetValue(playerTitleId, out personalPlayerTitleData);
			if (personalPlayerTitleData != null && starLevel != null)
			{
				personalPlayerTitleData.StarLevel = starLevel;
			}
			if (playerTitleId > 0 && personalPlayerTitleData != null && personalPlayerTitleData.IsExpired())
			{
				this.PersonalInfoData.CurPlayerTitleId = new int?(0);
				this.PersonalInfoData.CurPlayerTitleLevel = new int?(0);
				PlayerInfoModel.Instance.ChangeNumberProp(15, 0);
			}
			else
			{
				PlayerInfoModel.Instance.ChangeNumberProp(15, playerTitleId);
			}
			EventSystem.Instance.Emit(EEventName.OnPlayerTitleChange);
		}

		// Token: 0x0602B3E2 RID: 177122 RVA: 0x00C260B4 File Offset: 0x00C242B4
		public void UpdateUnDressedPlayerTitleList(PlayerTitleInfo[] playerTitleInfoList)
		{
			foreach (PlayerTitleInfo playerTitleInfo in playerTitleInfoList)
			{
				PersonalPlayerTitleData personalPlayerTitleData;
				this.PlayerTitleDataMap.TryGetValue(playerTitleInfo.PlayerTitleId, out personalPlayerTitleData);
				if (personalPlayerTitleData == null)
				{
					return;
				}
				if (playerTitleInfo.ExtraInfo != 0)
				{
					personalPlayerTitleData.SetStarLevel(playerTitleInfo.ExtraInfo);
				}
				if (playerTitleInfo.ConditionTask != null)
				{
					if (playerTitleInfo.ConditionTask.Status == ConditionTaskState.ConditionTaskFinish)
					{
						personalPlayerTitleData.SetUnLockProgress(playerTitleInfo.ConditionTask.Target, playerTitleInfo.ConditionTask.Target);
					}
					else
					{
						personalPlayerTitleData.SetUnLockProgress(playerTitleInfo.ConditionTask.Current, playerTitleInfo.ConditionTask.Target);
					}
				}
				if (playerTitleInfo.IsUnlock != personalPlayerTitleData.IsUnLock)
				{
					this.CurrentNewUnLockTitleArray.Add(personalPlayerTitleData);
					long num = MathUtils.Instance.LongToNumber(playerTitleInfo.UnlockTime);
					personalPlayerTitleData.UnLock((double)num);
					Dictionary<int, bool> dictionary = LocalStorage.GetPlayer<Dictionary<int, bool>>(ELocalStoragePlayerKey.PlayerTitleRecord, null) ?? new Dictionary<int, bool>();
					dictionary[playerTitleInfo.PlayerTitleId] = true;
					LocalStorage.SetPlayer<Dictionary<int, bool>>(ELocalStoragePlayerKey.PlayerTitleRecord, dictionary);
					EventSystem.Instance.Emit(EEventName.OnPlayerTitleRefreshRedDot);
					EventSystem.Instance.Emit(EEventName.OnPlayerTitleUnlock);
				}
			}
		}

		// Token: 0x0602B3E3 RID: 177123 RVA: 0x00C261D8 File Offset: 0x00C243D8
		[NullableContext(2)]
		public PersonalPlayerTitleData GetDressedPlayerTitleData()
		{
			int key = 0;
			if (this.PersonalInfoData.CurPlayerTitleId != null)
			{
				int? curPlayerTitleId = this.PersonalInfoData.CurPlayerTitleId;
				int num = 0;
				if (curPlayerTitleId.GetValueOrDefault() > num & curPlayerTitleId != null)
				{
					key = this.PersonalInfoData.CurPlayerTitleId.Value;
				}
			}
			PersonalPlayerTitleData result;
			this.PlayerTitleDataMap.TryGetValue(key, out result);
			return result;
		}

		// Token: 0x0602B3E4 RID: 177124 RVA: 0x00C2623C File Offset: 0x00C2443C
		public int GetDressedPlayerTitleId()
		{
			if (this.PersonalInfoData.CurPlayerTitleId != null)
			{
				int? curPlayerTitleId = this.PersonalInfoData.CurPlayerTitleId;
				int num = 0;
				if (curPlayerTitleId.GetValueOrDefault() > num & curPlayerTitleId != null)
				{
					PersonalPlayerTitleData personalPlayerTitleData;
					this.PlayerTitleDataMap.TryGetValue(this.PersonalInfoData.CurPlayerTitleId.Value, out personalPlayerTitleData);
					if (personalPlayerTitleData != null && personalPlayerTitleData.IsExpired())
					{
						return 0;
					}
					return this.PersonalInfoData.CurPlayerTitleId.Value;
				}
			}
			return 0;
		}

		// Token: 0x0602B3E5 RID: 177125 RVA: 0x00C262BC File Offset: 0x00C244BC
		public int GetDressedPlayerTitleLevel()
		{
			if (this.PersonalInfoData.CurPlayerTitleLevel != null)
			{
				int? curPlayerTitleLevel = this.PersonalInfoData.CurPlayerTitleLevel;
				int num = 0;
				if (curPlayerTitleLevel.GetValueOrDefault() > num & curPlayerTitleLevel != null)
				{
					return this.PersonalInfoData.CurPlayerTitleLevel.Value;
				}
			}
			return 0;
		}

		// Token: 0x0602B3E6 RID: 177126 RVA: 0x00C26310 File Offset: 0x00C24510
		[NullableContext(2)]
		public PersonalPlayerTitleData GetPlayerTitleData(int playerTitleId)
		{
			PersonalPlayerTitleData result;
			this.PlayerTitleDataMap.TryGetValue(playerTitleId, out result);
			return result;
		}

		// Token: 0x0602B3E7 RID: 177127 RVA: 0x00C26330 File Offset: 0x00C24530
		public int GetPlayerTitleStarLevel(int playerTitleId)
		{
			PersonalPlayerTitleData personalPlayerTitleData;
			this.PlayerTitleDataMap.TryGetValue(playerTitleId, out personalPlayerTitleData);
			if (personalPlayerTitleData == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Personal;
				ELogAuthor author = ELogAuthor.CXJ;
				string message = "称号id无效";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("playerTitleId", playerTitleId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return 0;
			}
			return personalPlayerTitleData.StarLevel.GetValueOrDefault();
		}

		// Token: 0x0602B3E8 RID: 177128 RVA: 0x00C26388 File Offset: 0x00C24588
		public List<PersonalPlayerTitleData> GetPlayerTitleList()
		{
			List<PersonalPlayerTitleData> list = new List<PersonalPlayerTitleData>();
			foreach (PersonalPlayerTitleData personalPlayerTitleData in this.PlayerTitleDataMap.Values)
			{
				if (!personalPlayerTitleData.IsExpired())
				{
					list.Add(personalPlayerTitleData);
				}
			}
			list.Sort(delegate(PersonalPlayerTitleData playerTitleDataA, PersonalPlayerTitleData playerTitleDataB)
			{
				bool flag = playerTitleDataA.IsEffective();
				bool flag2 = playerTitleDataB.IsEffective();
				if (flag != flag2)
				{
					return ((flag2 > false) - (flag > false)) ? 1 : 0;
				}
				PlayerTitle? config = ConfigPlayerTitleById.GetConfig(playerTitleDataA.PlayerTitleId, true);
				PlayerTitle? config2 = ConfigPlayerTitleById.GetConfig(playerTitleDataB.PlayerTitleId, true);
				if (config == null || config2 == null)
				{
					return 0;
				}
				if (config != null && config2 != null && config.Value.SortIndex != config2.Value.SortIndex)
				{
					return config2.Value.SortIndex - config.Value.SortIndex;
				}
				return playerTitleDataB.PlayerTitleId - playerTitleDataA.PlayerTitleId;
			});
			return list;
		}

		// Token: 0x0602B3E9 RID: 177129 RVA: 0x00C26414 File Offset: 0x00C24614
		public int GetUnlockTitleDataCount()
		{
			int num = 0;
			using (List<PersonalPlayerTitleData>.Enumerator enumerator = this.GetPlayerTitleList().GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.IsEffective())
					{
						num++;
					}
				}
			}
			return num;
		}

		// Token: 0x0602B3EA RID: 177130 RVA: 0x00C26470 File Offset: 0x00C24670
		public string GetPlayerTitleInfoString(int playerTitleId, int playerTitleStarLevel, bool isNeedLineBreaks = false)
		{
			PlayerTitle? config = ConfigPlayerTitleById.GetConfig(playerTitleId, true);
			string text = null;
			if (!string.IsNullOrEmpty((config != null) ? config.GetValueOrDefault().ActvityName : null))
			{
				text = ConfigMultiTextLang.GetLocalTextNew(config.Value.ActvityName, null);
			}
			string text2 = null;
			if (!string.IsNullOrEmpty((config != null) ? config.GetValueOrDefault().SeasonName : null))
			{
				text2 = ConfigMultiTextLang.GetLocalTextNew(config.Value.SeasonName, null);
			}
			string text3 = StringUtils.Format(ConfigMultiTextLang.GetLocalTextNew(config.Value.HonorDescription, null), new string[]
			{
				playerTitleStarLevel.ToString()
			});
			if (string.IsNullOrEmpty(text) && string.IsNullOrEmpty(text2))
			{
				return text3;
			}
			string text4 = isNeedLineBreaks ? "\n" : "";
			string result;
			if (!string.IsNullOrEmpty(text) && !string.IsNullOrEmpty(text2))
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(3, 4);
				defaultInterpolatedStringHandler.AppendFormatted(text);
				defaultInterpolatedStringHandler.AppendLiteral("·");
				defaultInterpolatedStringHandler.AppendFormatted(text2);
				defaultInterpolatedStringHandler.AppendLiteral("——");
				defaultInterpolatedStringHandler.AppendFormatted(text4);
				defaultInterpolatedStringHandler.AppendFormatted(text3);
				result = defaultInterpolatedStringHandler.ToStringAndClear();
			}
			else
			{
				result = ((!string.IsNullOrEmpty(text)) ? text : text2) + "——" + text4 + text3;
			}
			return result;
		}

		// Token: 0x170056CD RID: 22221
		// (get) Token: 0x0602B3EB RID: 177131 RVA: 0x00C265CD File Offset: 0x00C247CD
		public static PersonalModel Instance
		{
			get
			{
				return PersonalModel._Instance;
			}
		}

		// Token: 0x0602B3EC RID: 177132 RVA: 0x00C265D4 File Offset: 0x00C247D4
		public static PersonalModel GetOrCreateInstance()
		{
			if (PersonalModel._Instance == null)
			{
				PersonalModel.CreateInstance();
			}
			return PersonalModel._Instance;
		}

		// Token: 0x0602B3ED RID: 177133 RVA: 0x00C265E8 File Offset: 0x00C247E8
		public static bool CreateInstance()
		{
			if (PersonalModel._Instance != null)
			{
				return true;
			}
			PersonalModel._Instance = new PersonalModel();
			return true;
		}

		// Token: 0x0602B3EE RID: 177134 RVA: 0x00C265FE File Offset: 0x00C247FE
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602B3EF RID: 177135 RVA: 0x00C26600 File Offset: 0x00C24800
		public static void ResetStaticDefaultValue()
		{
			PersonalModel._Instance = null;
		}

		// Token: 0x0602B3F0 RID: 177136 RVA: 0x00C26608 File Offset: 0x00C24808
		static PersonalModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(PersonalModel.CreateStaticDefaultValue), new Action(PersonalModel.ResetStaticDefaultValue));
		}

		// Token: 0x0401754F RID: 95567
		[Nullable(2)]
		public PersonalInfoData UiCachePersonalData;

		// Token: 0x04017550 RID: 95568
		[Nullable(2)]
		private PersonalInfoData PersonalInfoData;

		// Token: 0x04017551 RID: 95569
		private readonly Dictionary<int, PlayerHeadData> PlayerHeadDataMap = new Dictionary<int, PlayerHeadData>();

		// Token: 0x04017552 RID: 95570
		private readonly Dictionary<int, int> HeadDataToMainRoleSkinMap = new Dictionary<int, int>();

		// Token: 0x04017553 RID: 95571
		private readonly Dictionary<int, PersonalPlayerTitleData> PlayerTitleDataMap = new Dictionary<int, PersonalPlayerTitleData>();

		// Token: 0x04017554 RID: 95572
		public List<PersonalPlayerTitleData> CurrentNewUnLockTitleArray = new List<PersonalPlayerTitleData>();

		// Token: 0x04017555 RID: 95573
		[Nullable(2)]
		private static PersonalModel _Instance;
	}
}
