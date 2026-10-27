using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.LevelGamePlay;

namespace CSharpScript.Game.Module.Personal
{
	// Token: 0x020052EB RID: 21227
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class PersonalModel : ModelBase
	{
		// Token: 0x060364B8 RID: 222392 RVA: 0x00CD7BA4 File Offset: 0x00CD5DA4
		protected override bool OnInit()
		{
			if (this.PersonalInfoData == null)
			{
				this.PersonalInfoData = new PersonalInfoData();
			}
			return true;
		}

		// Token: 0x060364B9 RID: 222393 RVA: 0x00CD7BBC File Offset: 0x00CD5DBC
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

		// Token: 0x060364BA RID: 222394 RVA: 0x00CD7C3C File Offset: 0x00CD5E3C
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

		// Token: 0x060364BB RID: 222395 RVA: 0x00CD7CEC File Offset: 0x00CD5EEC
		public void UpdatePlayerHeadData(int[] playerHeadIds)
		{
			foreach (int playerHeadId in playerHeadIds)
			{
				this.UnLockPlayerHeadData(playerHeadId);
			}
		}

		// Token: 0x060364BC RID: 222396 RVA: 0x00CD7D14 File Offset: 0x00CD5F14
		public void UnLockPlayerHeadData(int playerHeadId)
		{
			PlayerHeadData playerHeadData = this.GetPlayerHeadData(playerHeadId, true);
			if (playerHeadData == null)
			{
				return;
			}
			playerHeadData.Lock = false;
		}

		// Token: 0x060364BD RID: 222397 RVA: 0x00CD7D35 File Offset: 0x00CD5F35
		protected override bool OnClear()
		{
			this.PersonalInfoData = null;
			NewFlagModel.Instance.SaveNewFlagConfig(ELocalStoragePlayerKey.PersonalDataItem);
			return true;
		}

		// Token: 0x060364BE RID: 222398 RVA: 0x00CD7D4C File Offset: 0x00CD5F4C
		[NullableContext(2)]
		public PersonalInfoData GetPersonalInfoData()
		{
			return this.PersonalInfoData;
		}

		// Token: 0x060364BF RID: 222399 RVA: 0x00CD7D54 File Offset: 0x00CD5F54
		public void SetRoleShowList(List<Aki.Protocol.RoleShowEntry> roleShowEntry)
		{
			this.PersonalInfoData.RoleShowList = new List<global::RoleShowEntry>();
			int count = roleShowEntry.Count;
			for (int i = 0; i < count; i++)
			{
				Aki.Protocol.RoleShowEntry roleShowEntry2 = roleShowEntry[i];
				this.PersonalInfoData.RoleShowList.Add(new global::RoleShowEntry(roleShowEntry2.RoleId, roleShowEntry2.Level));
			}
		}

		// Token: 0x060364C0 RID: 222400 RVA: 0x00CD7DB0 File Offset: 0x00CD5FB0
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

		// Token: 0x060364C1 RID: 222401 RVA: 0x00CD7E29 File Offset: 0x00CD6029
		public List<global::RoleShowEntry> GetRoleShowList()
		{
			return this.PersonalInfoData.RoleShowList;
		}

		// Token: 0x060364C2 RID: 222402 RVA: 0x00CD7E36 File Offset: 0x00CD6036
		public void SetCardShowList(List<int> cardShowList)
		{
			this.PersonalInfoData.CardShowList = cardShowList;
		}

		// Token: 0x060364C3 RID: 222403 RVA: 0x00CD7E44 File Offset: 0x00CD6044
		public List<int> GetCardShowList()
		{
			return this.PersonalInfoData.CardShowList;
		}

		// Token: 0x060364C4 RID: 222404 RVA: 0x00CD7E51 File Offset: 0x00CD6051
		public void SetCurCardId(int cardId)
		{
			this.PersonalInfoData.CurCardId = new int?(cardId);
			EventSystem.Instance.Emit(EEventName.OnCardChange);
		}

		// Token: 0x060364C5 RID: 222405 RVA: 0x00CD7E74 File Offset: 0x00CD6074
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

		// Token: 0x060364C6 RID: 222406 RVA: 0x00CD7ED0 File Offset: 0x00CD60D0
		public void SetBirthday(int birthday)
		{
			this.PersonalInfoData.Birthday = birthday;
			EventSystem.Instance.Emit(EEventName.OnBirthChange);
		}

		// Token: 0x060364C7 RID: 222407 RVA: 0x00CD7EEE File Offset: 0x00CD60EE
		public void SetBirthdayDisplay(bool display)
		{
			this.PersonalInfoData.IsBirthdayDisplay = display;
			EventSystem.Instance.Emit(EEventName.OnBirthDisplayChange);
		}

		// Token: 0x060364C8 RID: 222408 RVA: 0x00CD7F0C File Offset: 0x00CD610C
		public void SetName(string name)
		{
			this.PersonalInfoData.Name = name;
		}

		// Token: 0x060364C9 RID: 222409 RVA: 0x00CD7F1A File Offset: 0x00CD611A
		public void SetPlayerId(int uid)
		{
			this.PersonalInfoData.PlayerId = uid;
		}

		// Token: 0x060364CA RID: 222410 RVA: 0x00CD7F28 File Offset: 0x00CD6128
		public void SetModifyNameInfo(long lastModifyNameTime, string modifyName)
		{
			this.PersonalInfoData.LastModifyNameTime = (int)MathUtils.Instance.LongToBigInt(lastModifyNameTime);
			this.PersonalInfoData.ModifyName = modifyName;
			EventSystem.Instance.Emit(EEventName.OnModifyNameStateChange);
		}

		// Token: 0x060364CB RID: 222411 RVA: 0x00CD7F5D File Offset: 0x00CD615D
		public int GetBirthday()
		{
			return this.PersonalInfoData.Birthday;
		}

		// Token: 0x060364CC RID: 222412 RVA: 0x00CD7F6A File Offset: 0x00CD616A
		public bool GetBirthdayDisplay()
		{
			return this.PersonalInfoData.IsBirthdayDisplay;
		}

		// Token: 0x060364CD RID: 222413 RVA: 0x00CD7F77 File Offset: 0x00CD6177
		public void SetSignature(string sign)
		{
			this.PersonalInfoData.Signature = sign;
			PlayerInfoModel.Instance.ChangeStringProp(8, sign);
			EventSystem.Instance.Emit(EEventName.OnSignChange);
		}

		// Token: 0x060364CE RID: 222414 RVA: 0x00CD7FA1 File Offset: 0x00CD61A1
		public string GetSignature()
		{
			return this.PersonalInfoData.Signature;
		}

		// Token: 0x060364CF RID: 222415 RVA: 0x00CD7FAE File Offset: 0x00CD61AE
		public void SetHeadPhotoId(int headPhotoId)
		{
			this.PersonalInfoData.HeadPhotoId = new int?(headPhotoId);
			PlayerInfoModel.Instance.ChangeNumberProp(4, headPhotoId);
			EventSystem.Instance.Emit<int>(EEventName.OnHeadIconChange, headPhotoId);
		}

		// Token: 0x060364D0 RID: 222416 RVA: 0x00CD7FE0 File Offset: 0x00CD61E0
		public int GetHeadPhotoId()
		{
			if (this.PersonalInfoData.HeadPhotoId == null)
			{
				int? numberPropById = PlayerInfoModel.Instance.GetNumberPropById(EPlayerInfoNumber.HeadPhoto);
				this.PersonalInfoData.HeadPhotoId = numberPropById;
			}
			return this.PersonalInfoData.HeadPhotoId.Value;
		}

		// Token: 0x060364D1 RID: 222417 RVA: 0x00CD8027 File Offset: 0x00CD6227
		[NullableContext(2)]
		public string GetThirdUserId()
		{
			return this.PersonalInfoData.ThirdUserId;
		}

		// Token: 0x060364D2 RID: 222418 RVA: 0x00CD8034 File Offset: 0x00CD6234
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

		// Token: 0x060364D3 RID: 222419 RVA: 0x00CD80B0 File Offset: 0x00CD62B0
		private void InitCardDataList()
		{
			this.PersonalInfoData.CardDataList = new List<PersonalCardData>();
			foreach (BackgroundCard backgroundCard in ConfigBackgroundCardAll.GetConfigList(true))
			{
				this.PersonalInfoData.CardDataList.Add(new PersonalCardData(backgroundCard.Id, false, false));
			}
		}

		// Token: 0x060364D4 RID: 222420 RVA: 0x00CD8124 File Offset: 0x00CD6324
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

		// Token: 0x060364D5 RID: 222421 RVA: 0x00CD8188 File Offset: 0x00CD6388
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

		// Token: 0x060364D6 RID: 222422 RVA: 0x00CD81F8 File Offset: 0x00CD63F8
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

		// Token: 0x060364D7 RID: 222423 RVA: 0x00CD8255 File Offset: 0x00CD6455
		public List<PersonalCardData> GetCardDataList()
		{
			return this.PersonalInfoData.CardDataList;
		}

		// Token: 0x060364D8 RID: 222424 RVA: 0x00CD8264 File Offset: 0x00CD6464
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

		// Token: 0x060364D9 RID: 222425 RVA: 0x00CD82CC File Offset: 0x00CD64CC
		public bool GetPersonalTitleRedDotState()
		{
			if (!FunctionModel.Instance.IsOpen(10082))
			{
				return false;
			}
			if (LocalStorage.GetPlayer<bool>(ELocalStoragePlayerKey.PlayerTitleUnlockRedDot, true))
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

		// Token: 0x060364DA RID: 222426 RVA: 0x00CD8388 File Offset: 0x00CD6588
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

		// Token: 0x060364DB RID: 222427 RVA: 0x00CD8432 File Offset: 0x00CD6632
		public void SetLevel(int level)
		{
			this.PersonalInfoData.Level = level;
		}

		// Token: 0x060364DC RID: 222428 RVA: 0x00CD8440 File Offset: 0x00CD6640
		public void SetWorldLevel(int worldLevel)
		{
			this.PersonalInfoData.WorldLevel = worldLevel;
		}

		// Token: 0x060364DD RID: 222429 RVA: 0x00CD8450 File Offset: 0x00CD6650
		public bool CheckCanShowPersonalTip()
		{
			int? intConfig = ConfigCommonParamById.GetIntConfig("IndividualizationReddotConditionGroup");
			return LevelGeneralController.Instance.CheckCondition(intConfig.ToString(), null, true, Array.Empty<object>()) && LocalStorage.GetPlayer<bool>(ELocalStoragePlayerKey.ShowPersonalTip, true);
		}

		// Token: 0x060364DE RID: 222430 RVA: 0x00CD8492 File Offset: 0x00CD6692
		public void SetPersonalTipState(bool state)
		{
			if (this.CheckCanShowPersonalTip() == state)
			{
				return;
			}
			LocalStorage.SetPlayer<bool>(ELocalStoragePlayerKey.ShowPersonalTip, state);
			EventSystem.Instance.Emit(EEventName.OnPersonalTipStateSet);
		}

		// Token: 0x060364DF RID: 222431 RVA: 0x00CD84B8 File Offset: 0x00CD66B8
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

		// Token: 0x060364E0 RID: 222432 RVA: 0x00CD850C File Offset: 0x00CD670C
		public List<PlayerHeadData> GetPlayerShowHeadDataList()
		{
			List<PlayerHeadData> list = new List<PlayerHeadData>();
			int? curSelectMainRoleId = RoleModel.Instance.GetCurSelectMainRoleId();
			int sex = this.GetSex();
			foreach (KeyValuePair<int, PlayerHeadData> keyValuePair in this.PlayerHeadDataMap)
			{
				PlayerHeadData value = keyValuePair.Value;
				int num;
				if (!this.HeadDataToMainRoleSkinMap.TryGetValue(value.Id, out num) || (curSelectMainRoleId != null && curSelectMainRoleId.Value == num))
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

		// Token: 0x060364E1 RID: 222433 RVA: 0x00CD85DC File Offset: 0x00CD67DC
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

		// Token: 0x060364E2 RID: 222434 RVA: 0x00CD8660 File Offset: 0x00CD6860
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

		// Token: 0x060364E3 RID: 222435 RVA: 0x00CD86BC File Offset: 0x00CD68BC
		public void SetSex(int sex)
		{
			this.PersonalInfoData.Sex = sex;
		}

		// Token: 0x060364E4 RID: 222436 RVA: 0x00CD86CA File Offset: 0x00CD68CA
		public int GetSex()
		{
			return this.PersonalInfoData.Sex;
		}

		// Token: 0x060364E5 RID: 222437 RVA: 0x00CD86D8 File Offset: 0x00CD68D8
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
			this.PersonalInfoData.PlayerTitleDataList = this.PlayerTitleDataMap.Values.ToList<PersonalPlayerTitleData>();
			EventSystem.Instance.Emit(EEventName.OnPlayerTitleRefreshRedDot);
		}

		// Token: 0x060364E6 RID: 222438 RVA: 0x00CD886C File Offset: 0x00CD6A6C
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

		// Token: 0x060364E7 RID: 222439 RVA: 0x00CD8918 File Offset: 0x00CD6B18
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

		// Token: 0x060364E8 RID: 222440 RVA: 0x00CD8A3C File Offset: 0x00CD6C3C
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

		// Token: 0x060364E9 RID: 222441 RVA: 0x00CD8AA0 File Offset: 0x00CD6CA0
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

		// Token: 0x060364EA RID: 222442 RVA: 0x00CD8B20 File Offset: 0x00CD6D20
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

		// Token: 0x060364EB RID: 222443 RVA: 0x00CD8B74 File Offset: 0x00CD6D74
		[NullableContext(2)]
		public PersonalPlayerTitleData GetPlayerTitleData(int playerTitleId)
		{
			PersonalPlayerTitleData result;
			this.PlayerTitleDataMap.TryGetValue(playerTitleId, out result);
			return result;
		}

		// Token: 0x060364EC RID: 222444 RVA: 0x00CD8B94 File Offset: 0x00CD6D94
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

		// Token: 0x060364ED RID: 222445 RVA: 0x00CD8BEC File Offset: 0x00CD6DEC
		public List<PersonalPlayerTitleData> GetPlayerTitleList()
		{
			List<PersonalPlayerTitleData> list = (from playerTitleData in this.PlayerTitleDataMap.Values
			where !playerTitleData.IsExpired()
			select playerTitleData).ToList<PersonalPlayerTitleData>();
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

		// Token: 0x060364EE RID: 222446 RVA: 0x00CD8C54 File Offset: 0x00CD6E54
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

		// Token: 0x060364EF RID: 222447 RVA: 0x00CD8CB0 File Offset: 0x00CD6EB0
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

		// Token: 0x1700830D RID: 33549
		// (get) Token: 0x060364F0 RID: 222448 RVA: 0x00CD8E0D File Offset: 0x00CD700D
		public static PersonalModel Instance
		{
			get
			{
				return PersonalModel._Instance;
			}
		}

		// Token: 0x060364F1 RID: 222449 RVA: 0x00CD8E14 File Offset: 0x00CD7014
		public static PersonalModel GetOrCreateInstance()
		{
			if (PersonalModel._Instance == null)
			{
				PersonalModel.CreateInstance();
			}
			return PersonalModel._Instance;
		}

		// Token: 0x060364F2 RID: 222450 RVA: 0x00CD8E28 File Offset: 0x00CD7028
		public static bool CreateInstance()
		{
			if (PersonalModel._Instance != null)
			{
				return true;
			}
			PersonalModel._Instance = new PersonalModel();
			return true;
		}

		// Token: 0x060364F3 RID: 222451 RVA: 0x00CD8E3E File Offset: 0x00CD703E
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x060364F4 RID: 222452 RVA: 0x00CD8E40 File Offset: 0x00CD7040
		public static void ResetStaticDefaultValue()
		{
			PersonalModel._Instance = null;
		}

		// Token: 0x060364F5 RID: 222453 RVA: 0x00CD8E48 File Offset: 0x00CD7048
		static PersonalModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(PersonalModel.CreateStaticDefaultValue), new Action(PersonalModel.ResetStaticDefaultValue));
		}

		// Token: 0x0401CB1A RID: 117530
		[Nullable(2)]
		public PersonalInfoData UiCachePersonalData;

		// Token: 0x0401CB1B RID: 117531
		[Nullable(2)]
		private PersonalInfoData PersonalInfoData;

		// Token: 0x0401CB1C RID: 117532
		private readonly Dictionary<int, PlayerHeadData> PlayerHeadDataMap = new Dictionary<int, PlayerHeadData>();

		// Token: 0x0401CB1D RID: 117533
		private readonly Dictionary<int, int> HeadDataToMainRoleSkinMap = new Dictionary<int, int>();

		// Token: 0x0401CB1E RID: 117534
		private readonly Dictionary<int, PersonalPlayerTitleData> PlayerTitleDataMap = new Dictionary<int, PersonalPlayerTitleData>();

		// Token: 0x0401CB1F RID: 117535
		public List<PersonalPlayerTitleData> CurrentNewUnLockTitleArray = new List<PersonalPlayerTitleData>();

		// Token: 0x0401CB20 RID: 117536
		[Nullable(2)]
		private static PersonalModel _Instance;
	}
}
