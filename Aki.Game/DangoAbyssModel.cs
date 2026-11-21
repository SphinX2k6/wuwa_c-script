using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.SolarisSpeed;
using CSharpScript.Game.Module.DeadRevive;
using CSharpScript.Game.Module.InstanceDungeon;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.PayShop;
using CSharpScript.Game.ServerStorage;
using CSharpScript.Game.ServerStorage.Container;
using CSharpScript.Module.InstanceDungeon;
using Google.Protobuf.Collections;

// Token: 0x02000EDD RID: 3805
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class DangoAbyssModel : ModelBase
{
	// Token: 0x06009849 RID: 38985 RVA: 0x002D1E42 File Offset: 0x002D0042
	protected override bool OnLeaveLevel()
	{
		this.ChallengeFinish = false;
		this.CurrentRoomId = 0;
		return true;
	}

	// Token: 0x0600984A RID: 38986 RVA: 0x002D1E53 File Offset: 0x002D0053
	public void OnAbyssChallengeResultNotify(AbyssChallengeResultNotify notify)
	{
		this.CurrentAbyssResultInfo = new AbyssChallengeResultData();
		this.CurrentAbyssResultInfo.Phrase(notify.Result);
		this.ChallengeFinish = true;
		this.SetLikeRecord(notify.Result.LikeRecord);
	}

	// Token: 0x0600984B RID: 38987 RVA: 0x002D1E89 File Offset: 0x002D0089
	public AbyssRankChallengeInfo GetChallengeRankInfo()
	{
		if (this.ChallengeRankInfo == null)
		{
			this.ChallengeRankInfo = new AbyssRankChallengeInfo();
		}
		return this.ChallengeRankInfo;
	}

	// Token: 0x0600984C RID: 38988 RVA: 0x002D1EA4 File Offset: 0x002D00A4
	public void OnAnonymousNameStateChange(int challengeId, bool state)
	{
		this.GetChallengeRankInfo().SetIsOpenAnonymousName(challengeId, state);
	}

	// Token: 0x0600984D RID: 38989 RVA: 0x002D1EB3 File Offset: 0x002D00B3
	public bool GetChallengeAnonymousNameState(int challengeId)
	{
		return this.GetChallengeRankInfo().GetAnonymousNameMode(challengeId);
	}

	// Token: 0x0600984E RID: 38990 RVA: 0x002D1EC4 File Offset: 0x002D00C4
	public bool CheckPayShopRedDot()
	{
		using (List<PayShopGoods>.Enumerator enumerator = this.GetPayShopGoods().GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current.GetIfNeedRemind())
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x0600984F RID: 38991 RVA: 0x002D1F20 File Offset: 0x002D0120
	public List<PayShopGoods> GetPayShopGoods()
	{
		int openShopId = DangoAbyssModel.Instance.GetOpenShopId();
		return PayShopModel.Instance.GetPayShopTabData((PayShopDefine.EPayShopTabType)openShopId, 1, false);
	}

	// Token: 0x06009850 RID: 38992 RVA: 0x002D1F45 File Offset: 0x002D0145
	public void OnAbyssChallegenRankUpdate(AbyssRankListResponse notify)
	{
		this.GetChallengeRankInfo().OnChallengeRankInfoUpdate(notify);
	}

	// Token: 0x06009851 RID: 38993 RVA: 0x002D1F53 File Offset: 0x002D0153
	public void OnAbyssChallengeSelfRankUpdate(AbyssSelfPassResponse notify)
	{
		this.GetChallengeRankInfo().OnSelfRankInfoUpdate(notify);
	}

	// Token: 0x06009852 RID: 38994 RVA: 0x002D1F64 File Offset: 0x002D0164
	public void OnAbyssLikeNotify(AbyssLikeNotify notify)
	{
		if (this.CurrentAbyssResultInfo == null)
		{
			Log.Instance.Error(ELogModule.Activity, ELogAuthor.YZY, "没有结算数据但是收到了喜欢通知", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		global::AbyssChallengeResultPlayerInfo playerInfoByPlayerId = this.CurrentAbyssResultInfo.GetPlayerInfoByPlayerId(notify.PlayerId);
		if (playerInfoByPlayerId == null)
		{
			Log.Instance.Error(ELogModule.Activity, ELogAuthor.YZY, "没有找到玩家数据", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		playerInfoByPlayerId.SetLikeCount(notify.LikeCount);
		this.SetLikeRecord(notify.LikeRecord);
	}

	// Token: 0x06009853 RID: 38995 RVA: 0x002D1FE8 File Offset: 0x002D01E8
	public int GetPlayerLikeCount(int playerId)
	{
		if (this.CurrentAbyssResultInfo == null)
		{
			return 0;
		}
		global::AbyssChallengeResultPlayerInfo playerInfoByPlayerId = this.CurrentAbyssResultInfo.GetPlayerInfoByPlayerId(playerId);
		if (playerInfoByPlayerId == null)
		{
			return 0;
		}
		return playerInfoByPlayerId.GetLikeCount();
	}

	// Token: 0x06009854 RID: 38996 RVA: 0x002D2017 File Offset: 0x002D0217
	public void OnAbyssFormationRoleSelectUpdateNotify(AbyssRoleSelectUpdateNotify notify)
	{
		this.CurrentFormationSelectInfo = new AbyssFormationInfo();
		this.CurrentFormationSelectInfo.Phrase(notify);
	}

	// Token: 0x06009855 RID: 38997 RVA: 0x002D2030 File Offset: 0x002D0230
	[NullableContext(2)]
	public DangoAbyssActivityData GetCurrentOpenAbyssActivityData()
	{
		foreach (KeyValuePair<int, ActivityBaseData> keyValuePair in ActivityModel.Instance.GetAllActivityMap())
		{
			if (keyValuePair.Value.Type == ActivityType.Abyss)
			{
				return keyValuePair.Value as DangoAbyssActivityData;
			}
		}
		return null;
	}

	// Token: 0x06009856 RID: 38998 RVA: 0x002D20A4 File Offset: 0x002D02A4
	[NullableContext(2)]
	public AbyssDangoRoleData GetDangoAbyssRoleData(int id)
	{
		DangoAbyssActivityData currentOpenAbyssActivityData = this.GetCurrentOpenAbyssActivityData();
		if (currentOpenAbyssActivityData == null)
		{
			Log.Instance.Info(ELogModule.Activity, ELogAuthor.YZY, "当前深渊团子没有开启", default(ReadOnlySpan<ValueTuple<string, object>>));
			return null;
		}
		return currentOpenAbyssActivityData.GetRoleDataById(id);
	}

	// Token: 0x06009857 RID: 38999 RVA: 0x002D20E4 File Offset: 0x002D02E4
	public bool GetAbyssUnLockState(int id)
	{
		DangoAbyssActivityData currentOpenAbyssActivityData = this.GetCurrentOpenAbyssActivityData();
		if (currentOpenAbyssActivityData == null)
		{
			Log.Instance.Info(ELogModule.Activity, ELogAuthor.YZY, "当前深渊团子没有开启", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		return currentOpenAbyssActivityData.GetAbyssChallengeDataById(id).GetIfUnlock();
	}

	// Token: 0x06009858 RID: 39000 RVA: 0x002D2128 File Offset: 0x002D0328
	public int GetAbyssMaxProgress(int id)
	{
		DangoAbyssActivityData currentOpenAbyssActivityData = this.GetCurrentOpenAbyssActivityData();
		if (currentOpenAbyssActivityData == null)
		{
			Log.Instance.Info(ELogModule.Activity, ELogAuthor.YZY, "当前深渊团子没有开启", default(ReadOnlySpan<ValueTuple<string, object>>));
			return 0;
		}
		return currentOpenAbyssActivityData.GetAbyssChallengeDataById(id).GetMaxProgress();
	}

	// Token: 0x06009859 RID: 39001 RVA: 0x002D216C File Offset: 0x002D036C
	public bool GetAbyssTimeLimitState(int id)
	{
		DangoAbyssActivityData currentOpenAbyssActivityData = this.GetCurrentOpenAbyssActivityData();
		if (currentOpenAbyssActivityData == null)
		{
			Log.Instance.Info(ELogModule.Activity, ELogAuthor.YZY, "当前深渊团子没有开启", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		return currentOpenAbyssActivityData.GetAbyssChallengeDataById(id).GetOverUnlockTime();
	}

	// Token: 0x0600985A RID: 39002 RVA: 0x002D21B0 File Offset: 0x002D03B0
	public bool GetAbyssConditionFinishState(int id)
	{
		DangoAbyssActivityData currentOpenAbyssActivityData = this.GetCurrentOpenAbyssActivityData();
		if (currentOpenAbyssActivityData == null)
		{
			Log.Instance.Info(ELogModule.Activity, ELogAuthor.YZY, "当前深渊团子没有开启", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		return currentOpenAbyssActivityData.GetAbyssChallengeDataById(id).GetConditionFinishState();
	}

	// Token: 0x0600985B RID: 39003 RVA: 0x002D21F4 File Offset: 0x002D03F4
	public string GetAbyssUnlockTimeText(int id)
	{
		DangoAbyssActivityData currentOpenAbyssActivityData = this.GetCurrentOpenAbyssActivityData();
		if (currentOpenAbyssActivityData == null)
		{
			Log.Instance.Info(ELogModule.Activity, ELogAuthor.YZY, "当前深渊团子没有开启", default(ReadOnlySpan<ValueTuple<string, object>>));
			return "";
		}
		return currentOpenAbyssActivityData.GetAbyssChallengeDataById(id).GetLeftTimeText();
	}

	// Token: 0x0600985C RID: 39004 RVA: 0x002D223C File Offset: 0x002D043C
	public bool GetAbyssPreChallengeFinishState(int id)
	{
		DangoAbyssActivityData currentOpenAbyssActivityData = this.GetCurrentOpenAbyssActivityData();
		if (currentOpenAbyssActivityData == null)
		{
			Log.Instance.Info(ELogModule.Activity, ELogAuthor.YZY, "当前深渊团子没有开启", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		return currentOpenAbyssActivityData.GetPreChallengeFinishState(id);
	}

	// Token: 0x0600985D RID: 39005 RVA: 0x002D227C File Offset: 0x002D047C
	public bool CheckIsSelf(int playerId)
	{
		int? id = PlayerInfoModel.Instance.GetId();
		return id.GetValueOrDefault() == playerId & id != null;
	}

	// Token: 0x0600985E RID: 39006 RVA: 0x002D22A8 File Offset: 0x002D04A8
	public bool CheckInAbyss()
	{
		InstanceDungeon? instanceDungeon;
		return InstanceDungeonConfig.Instance.GetConfig(CreatureModel.Instance.GetInstanceId()) != null && instanceDungeon.GetValueOrDefault().InstSubType == 33 && GameModeController.Instance.IsInInstance();
	}

	// Token: 0x0600985F RID: 39007 RVA: 0x002D22F8 File Offset: 0x002D04F8
	public bool CheckInAbyssEditFormationState()
	{
		InstanceDungeon? dungeonConfig = BattleTeamModel.Instance.Context.GetDungeonConfig();
		return dungeonConfig != null && dungeonConfig.Value.InstSubType == 33;
	}

	// Token: 0x06009860 RID: 39008 RVA: 0x002D2338 File Offset: 0x002D0538
	public bool CheckAllDangoReady()
	{
		List<BattleRoleSlotData> allSlots = BattleTeamModel.Instance.GetAllSlots();
		int count = allSlots.Count;
		for (int i = 0; i < count; i++)
		{
			BattleRoleData roleData = allSlots[i].RoleData;
			int? num = (roleData != null) ? new int?(roleData.PlayerId) : null;
			int? num2 = num;
			int num3 = 0;
			if (!(num2.GetValueOrDefault() == num3 & num2 != null) && num != null)
			{
				num2 = num;
				int? id = PlayerInfoModel.Instance.GetId();
				if (num2.GetValueOrDefault() == id.GetValueOrDefault() & num2 != null == (id != null))
				{
					int? roleConfigId = allSlots[i].RoleConfigId;
					AbyssDangoOwnerData roleOwnerData = this.GetRoleOwnerData(num.Value, roleConfigId.Value);
					if (roleOwnerData == null || roleOwnerData.DangoId <= 0)
					{
						return false;
					}
				}
			}
		}
		return true;
	}

	// Token: 0x06009861 RID: 39009 RVA: 0x002D241B File Offset: 0x002D061B
	public bool CheckIsInMatch()
	{
		return InstanceDungeonEntranceModel.Instance.GetMatchingState() > EInstanceMatchState.Default;
	}

	// Token: 0x06009862 RID: 39010 RVA: 0x002D242C File Offset: 0x002D062C
	public void PhraseRoomInfo(AbyssChallengeRoomInfoNotify data)
	{
		this.CurrentLayer = data.CurFloor;
		this.MaxLayer = data.MaxFloor;
		this.MaxBoxCount = data.MaxBox;
		this.GainBoxCount = data.GainBox;
		this.CurrentRouteId = data.RouteId;
		this.CurrentChallengeId = data.ChallengeId;
		this.RoleSelectDangoMap = new Dictionary<int, int>(data.RoleEquipMap);
		this.MaxScore = data.MaxScore;
		this.CurrentScore = data.CurScore;
		bool currentRoomId = this.CurrentRoomId != 0;
		this.CurrentRoomId = data.RoomId;
		if (!currentRoomId && this.CurrentRoomId != 0)
		{
			EventSystem.Instance.Emit(EEventName.OnAbyssFirstRoomEnter);
		}
		this.SetLikeRecord(data.LikeRecord);
	}

	// Token: 0x06009863 RID: 39011 RVA: 0x002D24E2 File Offset: 0x002D06E2
	public Dictionary<int, int> GetRoleSelectDangoMap()
	{
		return this.RoleSelectDangoMap ?? new Dictionary<int, int>();
	}

	// Token: 0x06009864 RID: 39012 RVA: 0x002D24F3 File Offset: 0x002D06F3
	public int GetAbyssLayer()
	{
		return this.CurrentLayer;
	}

	// Token: 0x06009865 RID: 39013 RVA: 0x002D24FB File Offset: 0x002D06FB
	public int GetMaxLayer()
	{
		return this.MaxLayer;
	}

	// Token: 0x06009866 RID: 39014 RVA: 0x002D2503 File Offset: 0x002D0703
	public float GetCurrentAbyssCompletePercentage()
	{
		return (float)this.CurrentLayer / (float)this.MaxLayer;
	}

	// Token: 0x06009867 RID: 39015 RVA: 0x002D2514 File Offset: 0x002D0714
	public int GetCurrentRoomId()
	{
		return this.CurrentRoomId;
	}

	// Token: 0x06009868 RID: 39016 RVA: 0x002D251C File Offset: 0x002D071C
	public int GetGainBoxCount()
	{
		return this.GainBoxCount;
	}

	// Token: 0x06009869 RID: 39017 RVA: 0x002D2524 File Offset: 0x002D0724
	public int GetMaxBoxCount()
	{
		return this.MaxBoxCount;
	}

	// Token: 0x0600986A RID: 39018 RVA: 0x002D252C File Offset: 0x002D072C
	public bool GetInAbyssFlow()
	{
		return this.InAbyssFlowInternal;
	}

	// Token: 0x0600986B RID: 39019 RVA: 0x002D2534 File Offset: 0x002D0734
	public void SetInAbyssFlow(bool value)
	{
		this.InAbyssFlowInternal = value;
	}

	// Token: 0x0600986C RID: 39020 RVA: 0x002D2540 File Offset: 0x002D0740
	public AttrListScrollData[] GetPluginShowAttributeList(int id)
	{
		List<AttrListScrollData> list = new List<AttrListScrollData>();
		AbyssItem? dangoItemById = DangoAbyssConfig.Instance.GetDangoItemById(id);
		if (dangoItemById == null)
		{
			return Array.Empty<AttrListScrollData>();
		}
		foreach (ConfigPropValue configPropValue in dangoItemById.Value.Prop())
		{
			list.Add(new AttrListScrollData(configPropValue.Id, (double)configPropValue.Value, 0.0, 0, configPropValue.IsRatio, CommonComponentDefine.EAttributeType.NormalType));
		}
		return list.ToArray();
	}

	// Token: 0x0600986D RID: 39021 RVA: 0x002D25CC File Offset: 0x002D07CC
	public DangoAbyssDefine.DangoAbyssTagData[] GetPluginShowTagDataList(int itemId)
	{
		List<DangoAbyssDefine.DangoAbyssTagData> list = new List<DangoAbyssDefine.DangoAbyssTagData>();
		AbyssItem? dangoItemById = DangoAbyssConfig.Instance.GetDangoItemById(itemId);
		if (dangoItemById == null)
		{
			return Array.Empty<DangoAbyssDefine.DangoAbyssTagData>();
		}
		foreach (KeyValuePair<int, int> keyValuePair in dangoItemById.Value.AddTag())
		{
			list.Add(new DangoAbyssDefine.DangoAbyssTagData
			{
				TagId = keyValuePair.Key,
				Value = keyValuePair.Value
			});
		}
		return list.ToArray();
	}

	// Token: 0x0600986E RID: 39022 RVA: 0x002D2674 File Offset: 0x002D0874
	public CSharpScript.Game.Module.Inventory.ItemConfig GetDangoItemConfig(int itemId)
	{
		return InventoryConfig.Instance.GetItemConfigData(itemId);
	}

	// Token: 0x0600986F RID: 39023 RVA: 0x002D2684 File Offset: 0x002D0884
	public int GetDangoItemBelongId(int incId)
	{
		DangoAbyssActivityData currentOpenAbyssActivityData = this.GetCurrentOpenAbyssActivityData();
		int? num;
		if (currentOpenAbyssActivityData == null)
		{
			num = null;
		}
		else
		{
			global::AbyssPluginItemInfo pluginItemInfoById = currentOpenAbyssActivityData.GetPluginItemInfoById(incId);
			num = ((pluginItemInfoById != null) ? new int?(pluginItemInfoById.GetBelongRole()) : null);
		}
		int? num2 = num;
		return num2.GetValueOrDefault();
	}

	// Token: 0x06009870 RID: 39024 RVA: 0x002D26D0 File Offset: 0x002D08D0
	public int GetDangoBelongRoleId(int playerId, int id)
	{
		Dictionary<int, AbyssDangoOwnerData> playerOwnerDataMap = this.GetPlayerOwnerDataMap(playerId);
		int result = 0;
		foreach (KeyValuePair<int, AbyssDangoOwnerData> keyValuePair in playerOwnerDataMap)
		{
			if (keyValuePair.Value.DangoId == id)
			{
				result = keyValuePair.Key;
				break;
			}
		}
		return result;
	}

	// Token: 0x06009871 RID: 39025 RVA: 0x002D273C File Offset: 0x002D093C
	public bool GetDangoItemLockState(int incId)
	{
		DangoAbyssActivityData currentOpenAbyssActivityData = this.GetCurrentOpenAbyssActivityData();
		if (currentOpenAbyssActivityData == null)
		{
			return false;
		}
		global::AbyssPluginItemInfo pluginItemInfoById = currentOpenAbyssActivityData.GetPluginItemInfoById(incId);
		return pluginItemInfoById != null && pluginItemInfoById.GetIsLock();
	}

	// Token: 0x06009872 RID: 39026 RVA: 0x002D2767 File Offset: 0x002D0967
	private Dictionary<int, AbyssDangoOwnerData> GetPlayerOwnerDataMap(int playerId)
	{
		if (!this.DangoOwnerMap.ContainsKey(playerId))
		{
			this.DangoOwnerMap[playerId] = new Dictionary<int, AbyssDangoOwnerData>();
		}
		return this.DangoOwnerMap[playerId];
	}

	// Token: 0x06009873 RID: 39027 RVA: 0x002D2794 File Offset: 0x002D0994
	[NullableContext(2)]
	public AbyssDangoOwnerData GetPlayerRoleCfgOwnerData(int playerId, int roleCfgId)
	{
		if (roleCfgId == 0)
		{
			return null;
		}
		if (!this.DangoOwnerMap.ContainsKey(playerId))
		{
			this.DangoOwnerMap[playerId] = new Dictionary<int, AbyssDangoOwnerData>();
		}
		Dictionary<int, AbyssDangoOwnerData> dictionary = this.DangoOwnerMap[playerId];
		if (!dictionary.ContainsKey(roleCfgId))
		{
			dictionary[roleCfgId] = new AbyssDangoOwnerData();
		}
		return dictionary[roleCfgId];
	}

	// Token: 0x06009874 RID: 39028 RVA: 0x002D27F0 File Offset: 0x002D09F0
	private void ResetDangoOwnerDataByRoleId(int playerId, int roleConfigId)
	{
		AbyssDangoOwnerData roleOwnerData = this.GetRoleOwnerData(playerId, roleConfigId);
		if (roleOwnerData == null)
		{
			return;
		}
		roleOwnerData.PlayerId = playerId;
		roleOwnerData.RoleCfgId = roleConfigId;
		roleOwnerData.DangoId = 0;
	}

	// Token: 0x06009875 RID: 39029 RVA: 0x002D281F File Offset: 0x002D0A1F
	[NullableContext(2)]
	public AbyssDangoOwnerData GetRoleOwnerData(int playerId, int roleConfigId)
	{
		return this.GetPlayerRoleCfgOwnerData(playerId, roleConfigId);
	}

	// Token: 0x06009876 RID: 39030 RVA: 0x002D282C File Offset: 0x002D0A2C
	[NullableContext(2)]
	public void RefreshOwnerListByMatchTeamInfo(MatchTeamInfo matchTeamInfo)
	{
		if (matchTeamInfo != null)
		{
			foreach (MatchPlayerInfo matchPlayerInfo in matchTeamInfo.PlayerInfos)
			{
				int playerId = matchPlayerInfo.PlayerId;
				foreach (MatchRoleInfo matchRoleInfo in matchPlayerInfo.RoleInfo)
				{
					this.ResetDangoOwnerDataByRoleId(playerId, matchRoleInfo.RoleId);
					AbyssDangoOwnerData roleOwnerData = this.GetRoleOwnerData(playerId, matchRoleInfo.RoleId);
					int roleId = matchRoleInfo.RoleId;
					if (roleOwnerData != null)
					{
						roleOwnerData.PlayerId = playerId;
						roleOwnerData.RoleCfgId = roleId;
						AbyssDangoOwnerData abyssDangoOwnerData = roleOwnerData;
						MatchRoleContext roleContext = matchRoleInfo.RoleContext;
						int? num;
						if (roleContext == null)
						{
							num = null;
						}
						else
						{
							AbyssMatchRoleContext abyssCtx = roleContext.AbyssCtx;
							if (abyssCtx == null)
							{
								num = null;
							}
							else
							{
								AbyssRoleInfo roleInfo = abyssCtx.RoleInfo;
								num = ((roleInfo != null) ? new int?(roleInfo.Id) : null);
							}
						}
						int? num2 = num;
						abyssDangoOwnerData.DangoId = num2.GetValueOrDefault();
						AbyssDangoOwnerData abyssDangoOwnerData2 = roleOwnerData;
						MatchRoleContext roleContext2 = matchRoleInfo.RoleContext;
						int? num3;
						if (roleContext2 == null)
						{
							num3 = null;
						}
						else
						{
							AbyssMatchRoleContext abyssCtx2 = roleContext2.AbyssCtx;
							if (abyssCtx2 == null)
							{
								num3 = null;
							}
							else
							{
								AbyssRoleInfo roleInfo2 = abyssCtx2.RoleInfo;
								num3 = ((roleInfo2 != null) ? new int?(roleInfo2.Level) : null);
							}
						}
						num2 = num3;
						abyssDangoOwnerData2.DangoLevel = num2.GetValueOrDefault();
						MatchRoleContext roleContext3 = matchRoleInfo.RoleContext;
						RepeatedField<int> repeatedField;
						if (roleContext3 == null)
						{
							repeatedField = null;
						}
						else
						{
							AbyssMatchRoleContext abyssCtx3 = roleContext3.AbyssCtx;
							if (abyssCtx3 == null)
							{
								repeatedField = null;
							}
							else
							{
								AbyssRoleInfo roleInfo3 = abyssCtx3.RoleInfo;
								repeatedField = ((roleInfo3 != null) ? roleInfo3.EquipItems : null);
							}
						}
						RepeatedField<int> repeatedField2 = repeatedField;
						if (repeatedField2 != null)
						{
							int[] array = new int[repeatedField2.Count];
							repeatedField2.CopyTo(array, 0);
							roleOwnerData.DangoEquipIds = array;
						}
						else
						{
							roleOwnerData.DangoEquipIds = Array.Empty<int>();
						}
					}
				}
			}
		}
	}

	// Token: 0x06009877 RID: 39031 RVA: 0x002D2A28 File Offset: 0x002D0C28
	public Dictionary<int, int[]> CacheDangoSelect(int playerId, int roleConfigId, int dangoId)
	{
		Dictionary<int, int[]> dictionary = new Dictionary<int, int[]>();
		Dictionary<int, AbyssDangoOwnerData> playerOwnerDataMap = this.GetPlayerOwnerDataMap(playerId);
		int num = 0;
		if (dangoId != 0)
		{
			AbyssDangoOwnerData roleOwnerData = this.GetRoleOwnerData(playerId, roleConfigId);
			int? num2 = (roleOwnerData != null) ? new int?(roleOwnerData.DangoId) : null;
			foreach (KeyValuePair<int, AbyssDangoOwnerData> keyValuePair in playerOwnerDataMap)
			{
				if (keyValuePair.Value.DangoId == dangoId && keyValuePair.Value.RoleCfgId != roleConfigId)
				{
					keyValuePair.Value.DangoId = 0;
					keyValuePair.Value.PlayerId = playerId;
					num = keyValuePair.Key;
					break;
				}
			}
			AbyssDangoOwnerData playerRoleCfgOwnerData = this.GetPlayerRoleCfgOwnerData(playerId, num);
			if (playerRoleCfgOwnerData != null)
			{
				playerRoleCfgOwnerData.DangoId = num2.GetValueOrDefault();
			}
		}
		AbyssDangoOwnerData playerRoleCfgOwnerData2 = this.GetPlayerRoleCfgOwnerData(playerId, roleConfigId);
		if (playerRoleCfgOwnerData2 != null)
		{
			playerRoleCfgOwnerData2.DangoId = dangoId;
			playerRoleCfgOwnerData2.PlayerId = playerId;
		}
		List<int> list = new List<int>();
		list.Add(roleConfigId);
		if (num != 0)
		{
			list.Add(num);
		}
		dictionary[playerId] = new int[]
		{
			roleConfigId,
			num
		};
		this.RefreshOwnDataAfterChange(playerId);
		return dictionary;
	}

	// Token: 0x06009878 RID: 39032 RVA: 0x002D2B5C File Offset: 0x002D0D5C
	public float GetInstanceProgress()
	{
		return Math.Min((float)this.CurrentScore / (float)this.MaxScore, 1f);
	}

	// Token: 0x06009879 RID: 39033 RVA: 0x002D2B78 File Offset: 0x002D0D78
	public string GetInstanceReviveTipTips()
	{
		int currentShareReviveTimes = DeadReviveModel.Instance.CurrentShareReviveTimes;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 1);
		defaultInterpolatedStringHandler.AppendFormatted<int>(currentShareReviveTimes);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x0600987A RID: 39034 RVA: 0x002D2BA8 File Offset: 0x002D0DA8
	public string GetInstanceFloorProgressText()
	{
		float value = DangoAbyssModel.Instance.GetCurrentAbyssCompletePercentage() * 100f;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
		defaultInterpolatedStringHandler.AppendFormatted<float>(value, "F2");
		defaultInterpolatedStringHandler.AppendLiteral("%");
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x0600987B RID: 39035 RVA: 0x002D2BF0 File Offset: 0x002D0DF0
	public string GetInstanceFloorText()
	{
		int abyssLayer = this.GetAbyssLayer();
		int maxLayer = this.GetMaxLayer();
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
		defaultInterpolatedStringHandler.AppendFormatted<int>(abyssLayer);
		defaultInterpolatedStringHandler.AppendLiteral("/");
		defaultInterpolatedStringHandler.AppendFormatted<int>(maxLayer);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x0600987C RID: 39036 RVA: 0x002D2C37 File Offset: 0x002D0E37
	public string GetInstanceFloorDetailProgressText()
	{
		return this.GetInstanceFloorText();
	}

	// Token: 0x0600987D RID: 39037 RVA: 0x002D2C3F File Offset: 0x002D0E3F
	public int GetCurrentChallengeId()
	{
		return this.CurrentChallengeId;
	}

	// Token: 0x0600987E RID: 39038 RVA: 0x002D2C48 File Offset: 0x002D0E48
	public int GetCurrentAbyssFullTime()
	{
		return DangoAbyssConfig.Instance.GetDangoAbyssInstById(this.CurrentChallengeId).Value.TotalTime;
	}

	// Token: 0x0600987F RID: 39039 RVA: 0x002D2C78 File Offset: 0x002D0E78
	public int GetCurrentAbyssTotalScore()
	{
		return DangoAbyssConfig.Instance.GetDangoAbyssInstById(this.CurrentChallengeId).Value.TotalScore;
	}

	// Token: 0x06009880 RID: 39040 RVA: 0x002D2CA8 File Offset: 0x002D0EA8
	public Dictionary<int, int> GetCurrentAbyssTreasureMap()
	{
		return DangoAbyssConfig.Instance.GetDangoAbyssInstById(this.CurrentChallengeId).Value.RewardTime();
	}

	// Token: 0x06009881 RID: 39041 RVA: 0x002D2CD8 File Offset: 0x002D0ED8
	public bool IsPlanarDungeon()
	{
		return DangoAbyssConfig.Instance.GetDangoAbyssInstByInstId(CreatureModel.Instance.GetInstanceId()).Value.PlanarDungeon;
	}

	// Token: 0x06009882 RID: 39042 RVA: 0x002D2D0C File Offset: 0x002D0F0C
	public string GetCurrentAbyssName()
	{
		if (this.CurrentChallengeId == 0)
		{
			return "";
		}
		string title = DangoAbyssConfig.Instance.GetDangoAbyssInstById(this.CurrentChallengeId).Value.Title;
		string localTextNew = ConfigMultiTextLang.GetLocalTextNew("DangoInfoName", null);
		if (string.IsNullOrEmpty(localTextNew))
		{
			return "";
		}
		return StringUtils.Format(localTextNew, new string[]
		{
			ConfigMultiTextLang.GetLocalTextNew(title, null)
		});
	}

	// Token: 0x06009883 RID: 39043 RVA: 0x002D2D78 File Offset: 0x002D0F78
	public string GetCurrentRouteDesc()
	{
		if (this.CurrentRouteId == 0)
		{
			return "";
		}
		return ConfigMultiTextLang.GetLocalTextNew(DangoAbyssConfig.Instance.GetAbyssRouteByRouteIdAndFloorId(this.CurrentRouteId, this.CurrentLayer).Value.Desc, null);
	}

	// Token: 0x06009884 RID: 39044 RVA: 0x002D2DC0 File Offset: 0x002D0FC0
	public string GetInstanceRemainTimeText()
	{
		double challengeRemainTime = InstanceDungeonModel.Instance.GetInstanceDungeonInfo().Tree.GetChallengeRemainTime(null);
		return TimeUtil.Instance.GetTimeDataFormat(Math.Ceiling(challengeRemainTime));
	}

	// Token: 0x06009885 RID: 39045 RVA: 0x002D2DFC File Offset: 0x002D0FFC
	public int GetOpenShopId()
	{
		DangoAbyssActivityData currentOpenAbyssActivityData = this.GetCurrentOpenAbyssActivityData();
		int num = (currentOpenAbyssActivityData != null) ? currentOpenAbyssActivityData.Id : 0;
		if (num > 0)
		{
			return DangoAbyssConfig.Instance.GetAbyssActivityData(num).Value.ShopId;
		}
		return 0;
	}

	// Token: 0x06009886 RID: 39046 RVA: 0x002D2E40 File Offset: 0x002D1040
	public void RefreshOwnDataAfterChange(int playerId)
	{
		foreach (KeyValuePair<int, AbyssDangoOwnerData> keyValuePair in this.GetPlayerOwnerDataMap(playerId))
		{
			this.RefreshOwnData(keyValuePair.Key, keyValuePair.Value);
		}
	}

	// Token: 0x06009887 RID: 39047 RVA: 0x002D2EA4 File Offset: 0x002D10A4
	private void RefreshOwnData(int roleId, AbyssDangoOwnerData data)
	{
		List<BattleRoleSlotData> allSlots = BattleTeamModel.Instance.GetAllSlots();
		int playerId = data.PlayerId;
		int? num = PlayerInfoModel.Instance.GetId();
		if (playerId == num.GetValueOrDefault() & num != null)
		{
			AbyssDangoRoleData dangoAbyssRoleData = DangoAbyssModel.Instance.GetDangoAbyssRoleData(data.DangoId);
			if (dangoAbyssRoleData != null)
			{
				bool flag = false;
				foreach (BattleRoleSlotData battleRoleSlotData in allSlots)
				{
					num = battleRoleSlotData.RoleConfigId;
					if (num.GetValueOrDefault() == roleId & num != null)
					{
						flag = true;
						break;
					}
				}
				if (!flag)
				{
					this.GetPlayerOwnerDataMap(data.PlayerId).Remove(roleId);
					return;
				}
				data.DangoLevel = dangoAbyssRoleData.GetLevel();
				data.DangoEquipIds = dangoAbyssRoleData.GetEquipItemConfigIdList();
			}
		}
	}

	// Token: 0x06009888 RID: 39048 RVA: 0x002D2F84 File Offset: 0x002D1184
	[return: Nullable(2)]
	public AbyssMatchChangeRoleContext GetMatchDangoRoleOwnData(int playerId, List<int> roleIdList)
	{
		AbyssMatchChangeRoleContext abyssMatchChangeRoleContext = AbyssMatchChangeRoleContext.Create();
		Dictionary<int, int> dictionary = new Dictionary<int, int>();
		foreach (int num in roleIdList)
		{
			AbyssDangoOwnerData roleOwnerData = this.GetRoleOwnerData(playerId, num);
			dictionary[num] = ((roleOwnerData != null) ? roleOwnerData.DangoId : 0);
		}
		abyssMatchChangeRoleContext.RoleEquipMap.Add(dictionary);
		return abyssMatchChangeRoleContext;
	}

	// Token: 0x06009889 RID: 39049 RVA: 0x002D3004 File Offset: 0x002D1204
	public AbyssDangoRoleData[] GetAllDangoList()
	{
		DangoAbyssActivityData currentOpenAbyssActivityData = this.GetCurrentOpenAbyssActivityData();
		if (currentOpenAbyssActivityData == null)
		{
			return Array.Empty<AbyssDangoRoleData>();
		}
		return currentOpenAbyssActivityData.GetAllDangoList();
	}

	// Token: 0x0600988A RID: 39050 RVA: 0x002D3028 File Offset: 0x002D1228
	[NullableContext(2)]
	public global::AbyssPluginItemInfo GetPluginItemInfoById(int incId)
	{
		DangoAbyssActivityData currentOpenAbyssActivityData = this.GetCurrentOpenAbyssActivityData();
		if (currentOpenAbyssActivityData == null)
		{
			return null;
		}
		return currentOpenAbyssActivityData.GetPluginItemInfoById(incId);
	}

	// Token: 0x0600988B RID: 39051 RVA: 0x002D3048 File Offset: 0x002D1248
	public AbyssItem? GetPluginItemConfigByIncId(int incId)
	{
		global::AbyssPluginItemInfo pluginItemInfoById = this.GetPluginItemInfoById(incId);
		if (pluginItemInfoById == null)
		{
			return null;
		}
		return pluginItemInfoById.GetConfig().As<AbyssItem>();
	}

	// Token: 0x0600988C RID: 39052 RVA: 0x002D3074 File Offset: 0x002D1274
	public global::AbyssPluginItemInfo[] GetPluginItemListByType(DangoAbyssDefine.ESlotType slotType)
	{
		global::AbyssPluginItemInfo[] allPluginItemList = this.GetAllPluginItemList();
		List<global::AbyssPluginItemInfo> list = new List<global::AbyssPluginItemInfo>();
		foreach (global::AbyssPluginItemInfo abyssPluginItemInfo in allPluginItemList)
		{
			if (abyssPluginItemInfo.GetConfig().As<AbyssItem>().Value.SlotType == (int)slotType)
			{
				list.Add(abyssPluginItemInfo);
			}
		}
		return list.ToArray();
	}

	// Token: 0x0600988D RID: 39053 RVA: 0x002D30D0 File Offset: 0x002D12D0
	public global::AbyssPluginItemInfo[] GetAllPluginItemList()
	{
		DangoAbyssActivityData currentOpenAbyssActivityData = this.GetCurrentOpenAbyssActivityData();
		if (currentOpenAbyssActivityData == null)
		{
			return Array.Empty<global::AbyssPluginItemInfo>();
		}
		return currentOpenAbyssActivityData.GetPluginItemInfoAll();
	}

	// Token: 0x0600988E RID: 39054 RVA: 0x002D30F4 File Offset: 0x002D12F4
	public void InitCacheDangoOwnerMap()
	{
		this.DangoOwnerMap.Clear();
		foreach (KeyValuePair<int, Dictionary<int, AbyssDangoOwnerData>> keyValuePair in this.GetCacheDangoOwnerMap())
		{
			foreach (KeyValuePair<int, AbyssDangoOwnerData> keyValuePair2 in keyValuePair.Value)
			{
				if (keyValuePair2.Value.DangoId != 0 && !this.GetDangoAbyssRoleData(keyValuePair2.Value.DangoId).GetIfLock())
				{
					this.DangoOwnerMap[keyValuePair.Key] = keyValuePair.Value;
				}
			}
		}
	}

	// Token: 0x0600988F RID: 39055 RVA: 0x002D31CC File Offset: 0x002D13CC
	public Dictionary<int, Dictionary<int, AbyssDangoOwnerData>> GetCacheDangoOwnerMap()
	{
		return LocalStorage.GetPlayer<Dictionary<int, Dictionary<int, AbyssDangoOwnerData>>>(ELocalStoragePlayerKey.AbyssDangoFormationSelect, null) ?? new Dictionary<int, Dictionary<int, AbyssDangoOwnerData>>();
	}

	// Token: 0x06009890 RID: 39056 RVA: 0x002D31E0 File Offset: 0x002D13E0
	public void SaveCacheDangoOwnerMap()
	{
		Dictionary<int, Dictionary<int, AbyssDangoOwnerData>> dictionary = new Dictionary<int, Dictionary<int, AbyssDangoOwnerData>>();
		foreach (KeyValuePair<int, Dictionary<int, AbyssDangoOwnerData>> keyValuePair in this.DangoOwnerMap)
		{
			if (keyValuePair.Key == PlayerInfoModel.Instance.GetId().Value)
			{
				Dictionary<int, AbyssDangoOwnerData> dictionary2 = new Dictionary<int, AbyssDangoOwnerData>();
				foreach (KeyValuePair<int, AbyssDangoOwnerData> keyValuePair2 in keyValuePair.Value)
				{
					dictionary2[keyValuePair2.Key] = keyValuePair2.Value;
				}
				dictionary[keyValuePair.Key] = dictionary2;
			}
		}
		LocalStorage.SetPlayer<Dictionary<int, Dictionary<int, AbyssDangoOwnerData>>>(ELocalStoragePlayerKey.AbyssDangoFormationSelect, dictionary);
	}

	// Token: 0x06009891 RID: 39057 RVA: 0x002D32C0 File Offset: 0x002D14C0
	public bool CheckInDangoAbyssInstance()
	{
		int instanceId = CreatureModel.Instance.GetInstanceId();
		if (instanceId == 0)
		{
			return false;
		}
		InstanceDungeon? config = InstanceDungeonConfig.Instance.GetConfig(instanceId);
		return config != null && config.GetValueOrDefault().InstSubType == 33;
	}

	// Token: 0x06009892 RID: 39058 RVA: 0x002D3310 File Offset: 0x002D1510
	public bool CheckIfInSmallWorldInstance()
	{
		int instanceId = CreatureModel.Instance.GetInstanceId();
		if (instanceId == 0)
		{
			return false;
		}
		InstanceDungeon? config = InstanceDungeonConfig.Instance.GetConfig(instanceId);
		return config != null && config.GetValueOrDefault().InstSubType == 12 && (config != null && config.GetValueOrDefault().WorldDungeonSubType == 1);
	}

	// Token: 0x06009893 RID: 39059 RVA: 0x002D3380 File Offset: 0x002D1580
	public DangoAbyssDefine.EAbyssItemTipsState GetDangoAbyssItemTipsConfirmState(DangoAbyssDefine.IAbyssItemTipsData data)
	{
		if (data.IncId == 0 || data.DangoId < 0 || data.SlotIndex < 0)
		{
			return DangoAbyssDefine.EAbyssItemTipsState.None;
		}
		AbyssItem value = DangoAbyssModel.Instance.GetPluginItemInfoById(data.IncId).GetConfig().As<AbyssItem>().Value;
		DangoAbyssDefine.ESlotType slotTypeByIndex = DangoAbyssConfig.Instance.GetSlotTypeByIndex(data.SlotIndex);
		if (value.SlotType != (int)slotTypeByIndex)
		{
			return DangoAbyssDefine.EAbyssItemTipsState.None;
		}
		int dangoItemBelongId = DangoAbyssModel.Instance.GetDangoItemBelongId(data.IncId);
		if (dangoItemBelongId != 0 && data.DangoId != dangoItemBelongId && value.SlotType == 1)
		{
			return DangoAbyssDefine.EAbyssItemTipsState.ErrorDango;
		}
		if (this.CheckLimitPassiveSame(data))
		{
			return DangoAbyssDefine.EAbyssItemTipsState.Same;
		}
		if (this.CheckLimitPassiveRepeat(data))
		{
			return DangoAbyssDefine.EAbyssItemTipsState.Repeat;
		}
		return this.GetItemTipsAvailableConfirmState(data);
	}

	// Token: 0x06009894 RID: 39060 RVA: 0x002D3438 File Offset: 0x002D1638
	private bool CheckLimitPassiveSame(DangoAbyssDefine.IAbyssItemTipsData data)
	{
		global::AbyssPluginItemInfo pluginItemInfoById = DangoAbyssModel.Instance.GetPluginItemInfoById(data.IncId);
		AbyssItem value = pluginItemInfoById.GetConfig().As<AbyssItem>().Value;
		int belongRole = pluginItemInfoById.GetBelongRole();
		bool flag = value.SlotType == 2 && belongRole > 0;
		return belongRole == data.DangoId && flag;
	}

	// Token: 0x06009895 RID: 39061 RVA: 0x002D3494 File Offset: 0x002D1694
	private bool CheckLimitPassiveRepeat(DangoAbyssDefine.IAbyssItemTipsData data)
	{
		int roleId = DangoAbyssModel.Instance.GetPluginItemInfoById(data.IncId).GetRoleId();
		bool flag = roleId > 0 && roleId == data.DangoId;
		int[] equipItems = DangoAbyssModel.Instance.GetDangoAbyssRoleData(data.DangoId).GetEquipItems();
		ValueTuple<bool, int> valueTuple = this.CheckRepeatPassivePlugin(equipItems, data.IncId);
		return valueTuple.Item1 && valueTuple.Item2 != data.SlotIndex && !flag;
	}

	// Token: 0x06009896 RID: 39062 RVA: 0x002D3508 File Offset: 0x002D1708
	private DangoAbyssDefine.EAbyssItemTipsState GetItemTipsAvailableConfirmState(DangoAbyssDefine.IAbyssItemTipsData data)
	{
		global::AbyssPluginItemInfo pluginItemInfoById = DangoAbyssModel.Instance.GetPluginItemInfoById(data.IncId);
		AbyssItem value = pluginItemInfoById.GetConfig().As<AbyssItem>().Value;
		int roleId = pluginItemInfoById.GetRoleId();
		int pluginItemIncIdBySlotIndex = this.GetPluginItemIncIdBySlotIndex(data.DangoId, data.SlotIndex);
		if (roleId > 0 && roleId != data.DangoId)
		{
			return DangoAbyssDefine.EAbyssItemTipsState.DiffDango;
		}
		if (roleId > 0 && roleId == data.DangoId)
		{
			if (pluginItemIncIdBySlotIndex > 0 && pluginItemIncIdBySlotIndex == data.IncId)
			{
				return DangoAbyssDefine.EAbyssItemTipsState.TakeOff;
			}
			if (pluginItemIncIdBySlotIndex > 0 && pluginItemIncIdBySlotIndex != data.IncId)
			{
				return DangoAbyssDefine.EAbyssItemTipsState.Switch;
			}
			return DangoAbyssDefine.EAbyssItemTipsState.Move;
		}
		else
		{
			int belongRole = pluginItemInfoById.GetBelongRole();
			if (value.SlotType == 2 && belongRole > 0)
			{
				return this.GetLimitPassiveItemTipsConfirmState(data);
			}
			if (roleId != 0)
			{
				return DangoAbyssDefine.EAbyssItemTipsState.None;
			}
			if (pluginItemIncIdBySlotIndex > 0)
			{
				return DangoAbyssDefine.EAbyssItemTipsState.Replace;
			}
			return DangoAbyssDefine.EAbyssItemTipsState.PutOn;
		}
	}

	// Token: 0x06009897 RID: 39063 RVA: 0x002D35C4 File Offset: 0x002D17C4
	private DangoAbyssDefine.EAbyssItemTipsState GetLimitPassiveItemTipsConfirmState(DangoAbyssDefine.IAbyssItemTipsData data)
	{
		int pluginItemIncIdBySlotIndex = this.GetPluginItemIncIdBySlotIndex(data.DangoId, data.SlotIndex);
		if (DangoAbyssModel.Instance.GetPluginItemInfoById(data.IncId).GetBelongRole() == data.DangoId)
		{
			return DangoAbyssDefine.EAbyssItemTipsState.Same;
		}
		int[] equipItems = DangoAbyssModel.Instance.GetDangoAbyssRoleData(data.DangoId).GetEquipItems();
		ValueTuple<bool, int> valueTuple = this.CheckRepeatPassivePlugin(equipItems, data.IncId);
		if (!valueTuple.Item1)
		{
			if (pluginItemIncIdBySlotIndex > 0)
			{
				return DangoAbyssDefine.EAbyssItemTipsState.Replace;
			}
			return DangoAbyssDefine.EAbyssItemTipsState.PutOn;
		}
		else
		{
			if (valueTuple.Item2 == data.SlotIndex)
			{
				return DangoAbyssDefine.EAbyssItemTipsState.Replace;
			}
			return DangoAbyssDefine.EAbyssItemTipsState.Repeat;
		}
	}

	// Token: 0x06009898 RID: 39064 RVA: 0x002D364C File Offset: 0x002D184C
	[NullableContext(0)]
	private ValueTuple<bool, int> CheckRepeatPassivePlugin([Nullable(1)] int[] incIdList, int newIncId)
	{
		int belongRole = DangoAbyssModel.Instance.GetPluginItemInfoById(newIncId).GetBelongRole();
		for (int i = 0; i < incIdList.Length; i++)
		{
			int num = incIdList[i];
			if (num > 0)
			{
				global::AbyssPluginItemInfo pluginItemInfoById = DangoAbyssModel.Instance.GetPluginItemInfoById(num);
				int belongRole2 = pluginItemInfoById.GetBelongRole();
				if (pluginItemInfoById.GetConfig().As<AbyssItem>().Value.SlotType == 2 && belongRole2 > 0 && belongRole2 == belongRole)
				{
					return new ValueTuple<bool, int>(true, i);
				}
			}
		}
		return new ValueTuple<bool, int>(false, -1);
	}

	// Token: 0x06009899 RID: 39065 RVA: 0x002D36C8 File Offset: 0x002D18C8
	private int[] SwitchIndexWithValue(int[] list, int value, int newIndex)
	{
		int num = -1;
		int num2 = list[newIndex];
		for (int i = 0; i < list.Length; i++)
		{
			if (list[i] == value)
			{
				num = i;
			}
		}
		list[newIndex] = value;
		list[num] = num2;
		return list;
	}

	// Token: 0x0600989A RID: 39066 RVA: 0x002D36FC File Offset: 0x002D18FC
	public unsafe int[] GetDangoAbyssItemNewEquip(DangoAbyssDefine.IAbyssItemTipsData data, DangoAbyssDefine.EAbyssItemTipsState state)
	{
		List<int> list = new List<int>(DangoAbyssModel.Instance.GetDangoAbyssRoleData(data.DangoId).GetEquipItems());
		int slotIndex = data.SlotIndex;
		if (state == DangoAbyssDefine.EAbyssItemTipsState.DiffDango || state == DangoAbyssDefine.EAbyssItemTipsState.Replace || state == DangoAbyssDefine.EAbyssItemTipsState.PutOn)
		{
			list[slotIndex] = data.IncId;
		}
		else if (state == DangoAbyssDefine.EAbyssItemTipsState.Switch || state == DangoAbyssDefine.EAbyssItemTipsState.Move)
		{
			list = new List<int>(this.SwitchIndexWithValue(list.ToArray(), data.IncId, slotIndex));
		}
		else if (state == DangoAbyssDefine.EAbyssItemTipsState.TakeOff)
		{
			list[slotIndex] = 0;
		}
		else
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Activity;
			ELogAuthor author = ELogAuthor.WDX;
			string message = "非法的插件装备状态";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("dangoId", data.DangoId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("state", (int)state);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		}
		return list.ToArray();
	}

	// Token: 0x0600989B RID: 39067 RVA: 0x002D37E5 File Offset: 0x002D19E5
	public int GetPluginItemIncIdBySlotIndex(int roleId, int slotIndex)
	{
		AbyssDangoRoleSlotData pluginSlotData = DangoAbyssModel.Instance.GetDangoAbyssRoleData(roleId).GetPluginSlotData(slotIndex);
		if (pluginSlotData == null)
		{
			return 0;
		}
		return pluginSlotData.GetIncId();
	}

	// Token: 0x0600989C RID: 39068 RVA: 0x002D3804 File Offset: 0x002D1A04
	public int GetSlotUnlockLevel(int dangoId, int slotIndex)
	{
		AbyssDangoRoleData dangoAbyssRoleData = this.GetDangoAbyssRoleData(dangoId);
		int slotUnlockCount = this.GetSlotUnlockCount(slotIndex);
		foreach (AbyssRoleLevel abyssRoleLevel in dangoAbyssRoleData.GetLevelGroupConfigs())
		{
			if (abyssRoleLevel.PluginNum == slotUnlockCount)
			{
				return abyssRoleLevel.Level;
			}
		}
		return -1;
	}

	// Token: 0x0600989D RID: 39069 RVA: 0x002D3870 File Offset: 0x002D1A70
	private int GetSlotUnlockCount(int slotIndex)
	{
		if (slotIndex == 0)
		{
			return 9;
		}
		return slotIndex;
	}

	// Token: 0x0600989E RID: 39070 RVA: 0x002D387C File Offset: 0x002D1A7C
	public bool GetSlotLockState(int dangoId, int slotIndex)
	{
		AbyssDangoRoleData dangoAbyssRoleData = this.GetDangoAbyssRoleData(dangoId);
		if (dangoAbyssRoleData == null || dangoAbyssRoleData.GetIfLock())
		{
			return true;
		}
		AbyssRoleLevel? levelConfig = dangoAbyssRoleData.GetLevelConfig();
		int slotUnlockCount = this.GetSlotUnlockCount(slotIndex);
		return levelConfig.Value.PluginNum < slotUnlockCount;
	}

	// Token: 0x0600989F RID: 39071 RVA: 0x002D38C0 File Offset: 0x002D1AC0
	public string GetPluginItemQualityIcon(int itemId)
	{
		AbyssItem? dangoItemById = DangoAbyssConfig.Instance.GetDangoItemById(itemId);
		if (dangoItemById == null)
		{
			return "";
		}
		AbyssQuality? abyssQualityById = DangoAbyssConfig.Instance.GetAbyssQualityById(dangoItemById.Value.QualityId);
		if (abyssQualityById == null)
		{
			return "";
		}
		string result = abyssQualityById.Value.AbyssItemBg;
		int slotType = dangoItemById.Value.SlotType;
		if (slotType != 1)
		{
			if (slotType == 2)
			{
				result = abyssQualityById.Value.AbyssPassiveItemBg;
			}
		}
		else
		{
			result = abyssQualityById.Value.AbyssCoreItemBg;
		}
		return result;
	}

	// Token: 0x060098A0 RID: 39072 RVA: 0x002D3964 File Offset: 0x002D1B64
	public bool IsPluginHasValidTag(int roleId, global::AbyssPluginItemInfo item)
	{
		Dictionary<int, int> dictionary = this.GetPluginItemConfigByIncId(item.GetUniqueId()).Value.AddTag();
		if (dictionary.Count > 0)
		{
			foreach (int tagId in dictionary.Keys)
			{
				if (this.IsTagTypeCorrect(roleId, tagId, DangoAbyssDefine.ETagDataGetType.Valid))
				{
					return true;
				}
			}
			return false;
		}
		return false;
	}

	// Token: 0x060098A1 RID: 39073 RVA: 0x002D39EC File Offset: 0x002D1BEC
	private bool IsTagTypeCorrect(int roleId, int tagId, DangoAbyssDefine.ETagDataGetType getType)
	{
		AbyssPluginPropDesc? dangoPluginPropDescById = DangoAbyssConfig.Instance.GetDangoPluginPropDescById(tagId);
		AbyssDangoRoleData dangoAbyssRoleData = this.GetDangoAbyssRoleData(roleId);
		if (dangoPluginPropDescById == null || dangoAbyssRoleData == null)
		{
			return false;
		}
		int addType = dangoPluginPropDescById.Value.AddType;
		int[] array = dangoAbyssRoleData.GetConfig().Value.TagList();
		if (addType == 5 || addType == 4)
		{
			return getType != DangoAbyssDefine.ETagDataGetType.InValid;
		}
		bool flag = false;
		int[] array2 = array;
		for (int i = 0; i < array2.Length; i++)
		{
			if (array2[i] == tagId)
			{
				flag = true;
				break;
			}
		}
		return (flag && getType != DangoAbyssDefine.ETagDataGetType.InValid) || (!flag && getType == DangoAbyssDefine.ETagDataGetType.InValid);
	}

	// Token: 0x060098A2 RID: 39074 RVA: 0x002D3A94 File Offset: 0x002D1C94
	private Dictionary<int, int> AddTagsToMap(Dictionary<int, int> map, Dictionary<int, int> tags)
	{
		foreach (KeyValuePair<int, int> keyValuePair in tags)
		{
			if (map.ContainsKey(keyValuePair.Key))
			{
				map[keyValuePair.Key] = map[keyValuePair.Key] + keyValuePair.Value;
			}
			else
			{
				map[keyValuePair.Key] = keyValuePair.Value;
			}
		}
		return map;
	}

	// Token: 0x060098A3 RID: 39075 RVA: 0x002D3B24 File Offset: 0x002D1D24
	public DangoAbyssDefine.DangoAbyssTagData[] GetDangoTagData(int roleId, DangoAbyssDefine.ETagDataGetType getType)
	{
		AbyssDangoRoleData dangoAbyssRoleData = this.GetDangoAbyssRoleData(roleId);
		AbyssLittleRole? config = dangoAbyssRoleData.GetConfig();
		int[] equipItems = dangoAbyssRoleData.GetEquipItems();
		int[] array = config.Value.TagList();
		Dictionary<int, int> dictionary = new Dictionary<int, int>();
		if (array.Length != 0 && getType != DangoAbyssDefine.ETagDataGetType.InValid)
		{
			foreach (int key in array)
			{
				dictionary[key] = 0;
			}
		}
		foreach (int num in equipItems)
		{
			if (num > 0)
			{
				Dictionary<int, int> dictionary2 = this.GetPluginItemConfigByIncId(num).Value.AddTag();
				if (dictionary2.Count > 0)
				{
					dictionary = this.AddTagsToMap(dictionary, dictionary2);
				}
			}
		}
		List<DangoAbyssDefine.DangoAbyssTagData> list = new List<DangoAbyssDefine.DangoAbyssTagData>();
		foreach (KeyValuePair<int, int> keyValuePair in dictionary)
		{
			if (this.IsTagTypeCorrect(roleId, keyValuePair.Key, getType))
			{
				list.Add(new DangoAbyssDefine.DangoAbyssTagData
				{
					TagId = keyValuePair.Key,
					Value = keyValuePair.Value
				});
			}
		}
		list.Sort(delegate(DangoAbyssDefine.DangoAbyssTagData dataA, DangoAbyssDefine.DangoAbyssTagData dataB)
		{
			AbyssPluginPropDesc? dangoPluginPropDescById = DangoAbyssConfig.Instance.GetDangoPluginPropDescById(dataA.TagId);
			return DangoAbyssConfig.Instance.GetDangoPluginPropDescById(dataB.TagId).Value.AddType - dangoPluginPropDescById.Value.AddType;
		});
		return list.ToArray();
	}

	// Token: 0x060098A4 RID: 39076 RVA: 0x002D3C8C File Offset: 0x002D1E8C
	private bool CheckOverMaxValue(int value, int maxValue)
	{
		if (maxValue < 0)
		{
			return value < maxValue;
		}
		return value > maxValue;
	}

	// Token: 0x060098A5 RID: 39077 RVA: 0x002D3C9C File Offset: 0x002D1E9C
	public string GetFormatAttributeValueByTagId(int value, int tagId, bool? hideMax = null)
	{
		AbyssPluginPropDesc? dangoPluginPropDescById = DangoAbyssConfig.Instance.GetDangoPluginPropDescById(tagId);
		if (dangoPluginPropDescById == null)
		{
			return "";
		}
		if (dangoPluginPropDescById.Value.AddType == 5)
		{
			AbyssDangoRoleData dangoAbyssRoleData = this.GetDangoAbyssRoleData(value);
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler;
			if (dangoAbyssRoleData != null && dangoAbyssRoleData.GetConfig() != null)
			{
				string result;
				if ((result = ConfigMultiTextLang.GetLocalTextNew(dangoAbyssRoleData.GetConfig().Value.Name, null)) == null)
				{
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 1);
					defaultInterpolatedStringHandler.AppendLiteral("id");
					defaultInterpolatedStringHandler.AppendFormatted<int>(value);
					result = defaultInterpolatedStringHandler.ToStringAndClear();
				}
				return result;
			}
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 1);
			defaultInterpolatedStringHandler.AppendLiteral("id");
			defaultInterpolatedStringHandler.AppendFormatted<int>(value);
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}
		else
		{
			string id = dangoPluginPropDescById.Value.TextFormat;
			if (hideMax.GetValueOrDefault() || dangoPluginPropDescById.Value.AddType == 4)
			{
				id = dangoPluginPropDescById.Value.NoMaxTextFormat;
			}
			else if (this.CheckOverMaxValue(value, dangoPluginPropDescById.Value.MaxValue))
			{
				id = dangoPluginPropDescById.Value.MaxTextFormat;
			}
			string text = value.ToString();
			string text2 = dangoPluginPropDescById.Value.MaxValue.ToString();
			if (dangoPluginPropDescById.Value.AddType == 1)
			{
				text = TipsDataTool.GetPropRatioValue((double)value, false).ToString();
				text2 = TipsDataTool.GetPropRatioValue((double)dangoPluginPropDescById.Value.MaxValue, false).ToString();
			}
			else if (dangoPluginPropDescById.Value.AddType == 2)
			{
				text = TipsDataTool.GetPropRatioValue((double)value, true).ToString();
				text2 = TipsDataTool.GetPropRatioValue((double)dangoPluginPropDescById.Value.MaxValue, true).ToString();
			}
			string result2 = "";
			string localTextNew = ConfigMultiTextLang.GetLocalTextNew(id, null);
			if (string.IsNullOrEmpty(localTextNew))
			{
				return result2;
			}
			if (hideMax.GetValueOrDefault())
			{
				result2 = StringUtils.Format(localTextNew, new string[]
				{
					text
				});
			}
			else
			{
				result2 = StringUtils.Format(localTextNew, new string[]
				{
					text,
					text2
				});
			}
			return result2;
		}
	}

	// Token: 0x060098A6 RID: 39078 RVA: 0x002D3ED4 File Offset: 0x002D20D4
	[NullableContext(2)]
	public DangoAbyssDefine.ESlotSwitchType GetSlotSwitchTypeByData(AbyssDangoRoleSlotData oldData, AbyssDangoRoleSlotData newData)
	{
		if (newData == null || oldData == newData)
		{
			return DangoAbyssDefine.ESlotSwitchType.None;
		}
		int num = (oldData != null) ? oldData.GetIncId() : 0;
		int num2 = (newData != null) ? newData.GetIncId() : 0;
		if (num <= 0 && num2 > 0)
		{
			return DangoAbyssDefine.ESlotSwitchType.PutOn;
		}
		if (num > 0 && num2 <= 0)
		{
			return DangoAbyssDefine.ESlotSwitchType.TakeOff;
		}
		if (num > 0 && num2 > 0 && num != num2)
		{
			return DangoAbyssDefine.ESlotSwitchType.Replace;
		}
		return DangoAbyssDefine.ESlotSwitchType.None;
	}

	// Token: 0x060098A7 RID: 39079 RVA: 0x002D3F28 File Offset: 0x002D2128
	public ConfigPropValue[] GetDangoAddPropData(int roleId)
	{
		int[] equipItems = this.GetDangoAbyssRoleData(roleId).GetEquipItems();
		List<ConfigPropValue> list = new List<ConfigPropValue>();
		foreach (int num in equipItems)
		{
			if (num > 0)
			{
				foreach (ConfigPropValue item in this.GetPluginItemConfigByIncId(num).Value.Prop())
				{
					list.Add(item);
				}
			}
		}
		return list.ToArray();
	}

	// Token: 0x060098A8 RID: 39080 RVA: 0x002D3FA8 File Offset: 0x002D21A8
	public ConfigPropValue[] GetDangoBaseProp(int roleId)
	{
		return this.GetDangoAbyssRoleData(roleId).GetLevelConfig().Value.Prop();
	}

	// Token: 0x060098A9 RID: 39081 RVA: 0x002D3FD4 File Offset: 0x002D21D4
	public AttrListScrollData[] GetDangoShowAttributeList(int roleId)
	{
		List<AttrListScrollData> list = new List<AttrListScrollData>();
		ConfigPropValue[] dangoBaseProp = this.GetDangoBaseProp(roleId);
		ConfigPropValue[] dangoAddPropData = this.GetDangoAddPropData(roleId);
		foreach (ConfigPropValue configPropValue in dangoBaseProp)
		{
			double propRatioValue = TipsDataTool.GetPropRatioValue((double)configPropValue.Value, configPropValue.IsRatio);
			list.Add(new RoleAttrListScrollData(configPropValue.Id, propRatioValue, 0.0, 0, configPropValue.IsRatio, CommonComponentDefine.EAttributeType.NormalType));
		}
		foreach (ConfigPropValue configPropValue2 in dangoAddPropData)
		{
			bool flag = false;
			double propRatioValue2 = TipsDataTool.GetPropRatioValue((double)configPropValue2.Value, configPropValue2.IsRatio);
			foreach (AttrListScrollData attrListScrollData in list)
			{
				if (attrListScrollData.Id == configPropValue2.Id && attrListScrollData.IsRatio == configPropValue2.IsRatio)
				{
					attrListScrollData.AddValue += propRatioValue2;
					flag = true;
				}
			}
			if (!flag)
			{
				list.Add(new RoleAttrListScrollData(configPropValue2.Id, 0.0, propRatioValue2, 0, configPropValue2.IsRatio, CommonComponentDefine.EAttributeType.NormalType));
			}
		}
		return list.ToArray();
	}

	// Token: 0x060098AA RID: 39082 RVA: 0x002D4124 File Offset: 0x002D2324
	private AttrListScrollData[] GetEquipViewAttributeScrollData(int roleId)
	{
		ConfigPropValue[] dangoAddPropData = this.GetDangoAddPropData(roleId);
		List<AttrListScrollData> list = new List<AttrListScrollData>();
		foreach (ConfigPropValue configPropValue in dangoAddPropData)
		{
			bool flag = false;
			foreach (AttrListScrollData attrListScrollData in list)
			{
				if (attrListScrollData.Id == configPropValue.Id && attrListScrollData.IsRatio == configPropValue.IsRatio)
				{
					attrListScrollData.AddValue += (double)configPropValue.Value;
					flag = true;
				}
			}
			if (!flag)
			{
				list.Add(new AttrListScrollData(configPropValue.Id, 0.0, (double)configPropValue.Value, 0, configPropValue.IsRatio, CommonComponentDefine.EAttributeType.NormalType));
			}
		}
		return list.ToArray();
	}

	// Token: 0x060098AB RID: 39083 RVA: 0x002D420C File Offset: 0x002D240C
	public List<DangoAbyssDefine.EquipViewAttributeData> GetEquipViewAttributeDataById(int roleId)
	{
		DangoAbyssDefine.EquipViewAttributeData equipViewAttributeData = new DangoAbyssDefine.EquipViewAttributeData();
		equipViewAttributeData.IsValid = true;
		AttrListScrollData[] equipViewAttributeScrollData = this.GetEquipViewAttributeScrollData(roleId);
		DangoAbyssDefine.DangoAbyssTagData[] dangoTagData = this.GetDangoTagData(roleId, DangoAbyssDefine.ETagDataGetType.Valid);
		List<DangoAbyssDefine.EquipViewAttributeData> list = new List<DangoAbyssDefine.EquipViewAttributeData>();
		if (equipViewAttributeScrollData.Length + dangoTagData.Length > 0)
		{
			list = new List<DangoAbyssDefine.EquipViewAttributeData>
			{
				equipViewAttributeData
			};
			foreach (DangoAbyssDefine.DangoAbyssTagData tag in dangoTagData)
			{
				list.Add(new DangoAbyssDefine.EquipViewAttributeData
				{
					IsValid = true,
					Tag = tag
				});
			}
			foreach (AttrListScrollData attribute in equipViewAttributeScrollData)
			{
				list.Add(new DangoAbyssDefine.EquipViewAttributeData
				{
					IsValid = true,
					Attribute = attribute
				});
			}
		}
		DangoAbyssDefine.EquipViewAttributeData equipViewAttributeData2 = new DangoAbyssDefine.EquipViewAttributeData();
		equipViewAttributeData2.IsValid = false;
		DangoAbyssDefine.DangoAbyssTagData[] dangoTagData2 = this.GetDangoTagData(roleId, DangoAbyssDefine.ETagDataGetType.InValid);
		List<DangoAbyssDefine.EquipViewAttributeData> list2 = new List<DangoAbyssDefine.EquipViewAttributeData>();
		if (dangoTagData2.Length != 0)
		{
			list2 = new List<DangoAbyssDefine.EquipViewAttributeData>
			{
				equipViewAttributeData2
			};
			foreach (DangoAbyssDefine.DangoAbyssTagData tag2 in dangoTagData2)
			{
				list2.Add(new DangoAbyssDefine.EquipViewAttributeData
				{
					IsValid = false,
					Tag = tag2
				});
			}
		}
		List<DangoAbyssDefine.EquipViewAttributeData> list3 = new List<DangoAbyssDefine.EquipViewAttributeData>(list2);
		list3.AddRange(list);
		return list3;
	}

	// Token: 0x060098AC RID: 39084 RVA: 0x002D4354 File Offset: 0x002D2554
	private bool GetSameIdDataInList(List<DangoAbyssDefine.EquipViewAttributeData> dataList, int checkId, float checkValue, bool isTag)
	{
		foreach (DangoAbyssDefine.EquipViewAttributeData equipViewAttributeData in dataList)
		{
			DangoAbyssDefine.DangoAbyssTagData tag = equipViewAttributeData.Tag;
			int? num = (tag != null) ? new int?(tag.TagId) : null;
			AttrListScrollData attribute = equipViewAttributeData.Attribute;
			int? num2 = (attribute != null) ? new int?(attribute.Id) : null;
			if (!isTag)
			{
				int? num3 = num2;
				if (num3.GetValueOrDefault() == checkId & num3 != null)
				{
					AttrListScrollData attribute2 = equipViewAttributeData.Attribute;
					double? num4 = (attribute2 != null) ? new double?(attribute2.AddValue) : null;
					double num5 = (double)checkValue;
					return num4.GetValueOrDefault() == num5 & num4 != null;
				}
			}
			if (isTag)
			{
				int? num3 = num;
				if (num3.GetValueOrDefault() == checkId & num3 != null)
				{
					DangoAbyssDefine.DangoAbyssTagData tag2 = equipViewAttributeData.Tag;
					num3 = ((tag2 != null) ? new int?(tag2.Value) : null);
					float? num6 = (num3 != null) ? new float?((float)num3.GetValueOrDefault()) : null;
					return num6.GetValueOrDefault() == checkValue & num6 != null;
				}
			}
		}
		return false;
	}

	// Token: 0x060098AD RID: 39085 RVA: 0x002D44D4 File Offset: 0x002D26D4
	public List<DangoAbyssDefine.EquipViewAttributeData> SetEquipViewAttributeType(List<DangoAbyssDefine.EquipViewAttributeData> oldList, List<DangoAbyssDefine.EquipViewAttributeData> newList)
	{
		foreach (DangoAbyssDefine.EquipViewAttributeData equipViewAttributeData in newList)
		{
			equipViewAttributeData.IsChange = false;
			if (equipViewAttributeData.Attribute != null || equipViewAttributeData.Tag != null)
			{
				int checkId = 0;
				bool isTag = false;
				float checkValue = 0f;
				if (equipViewAttributeData.Attribute != null)
				{
					checkId = equipViewAttributeData.Attribute.Id;
					isTag = false;
					checkValue = (float)equipViewAttributeData.Attribute.AddValue;
				}
				else if (equipViewAttributeData.Tag != null)
				{
					checkId = equipViewAttributeData.Tag.TagId;
					isTag = true;
					checkValue = (float)equipViewAttributeData.Tag.Value;
				}
				bool sameIdDataInList = this.GetSameIdDataInList(oldList, checkId, checkValue, isTag);
				equipViewAttributeData.IsChange = !sameIdDataInList;
			}
		}
		return newList;
	}

	// Token: 0x060098AE RID: 39086 RVA: 0x002D45A8 File Offset: 0x002D27A8
	[NullableContext(2)]
	public string GetSlotTypeTextIdBySlotIndex(int slotIndex)
	{
		DangoAbyssDefine.ESlotType slotTypeByIndex = DangoAbyssConfig.Instance.GetSlotTypeByIndex(slotIndex);
		string result;
		if (DangoAbyssDefine.textSlotType.TryGetValue(slotTypeByIndex, out result))
		{
			return result;
		}
		return null;
	}

	// Token: 0x060098AF RID: 39087 RVA: 0x002D45D4 File Offset: 0x002D27D4
	public global::AbyssPluginItemInfo[] GetPluginItemListBySlotIndex(int slotIndex)
	{
		DangoAbyssDefine.ESlotType slotTypeByIndex = DangoAbyssConfig.Instance.GetSlotTypeByIndex(slotIndex);
		return DangoAbyssModel.Instance.GetPluginItemListByType(slotTypeByIndex);
	}

	// Token: 0x060098B0 RID: 39088 RVA: 0x002D45F8 File Offset: 0x002D27F8
	public bool GetIfSlotTypeChange(int slotIndexOld, int slotIndexNew)
	{
		if (slotIndexOld < 0)
		{
			return true;
		}
		DangoAbyssDefine.ESlotType slotTypeByIndex = DangoAbyssConfig.Instance.GetSlotTypeByIndex(slotIndexOld);
		DangoAbyssDefine.ESlotType slotTypeByIndex2 = DangoAbyssConfig.Instance.GetSlotTypeByIndex(slotIndexNew);
		return slotTypeByIndex != slotTypeByIndex2;
	}

	// Token: 0x060098B1 RID: 39089 RVA: 0x002D4628 File Offset: 0x002D2828
	public int GetPluginItemPackageCapacity()
	{
		InventoryDefine.EItemMainTypeId itemTypeId = InventoryDefine.EItemMainTypeId.DangoPluginItem;
		int packageId = InventoryConfig.Instance.GetItemMainTypeConfig((int)itemTypeId).Value.PackageId;
		return InventoryConfig.Instance.GetPackageConfig(packageId).Value.Capacity;
	}

	// Token: 0x060098B2 RID: 39090 RVA: 0x002D4674 File Offset: 0x002D2874
	public void SaveFormationSelectRole(int challengeId, List<int> roleId)
	{
		Dictionary<int, int[]> dictionary = LocalStorage.GetPlayer<Dictionary<int, int[]>>(ELocalStoragePlayerKey.AbyssSelectRole, null) ?? new Dictionary<int, int[]>();
		dictionary[challengeId] = roleId.ToArray();
		LocalStorage.SetPlayer<Dictionary<int, int[]>>(ELocalStoragePlayerKey.AbyssSelectRole, dictionary);
	}

	// Token: 0x060098B3 RID: 39091 RVA: 0x002D46B0 File Offset: 0x002D28B0
	public int[] GetFormationSelectRoleList(int challengeId)
	{
		int[] result;
		if ((LocalStorage.GetPlayer<Dictionary<int, int[]>>(ELocalStoragePlayerKey.AbyssSelectRole, null) ?? new Dictionary<int, int[]>()).TryGetValue(challengeId, out result))
		{
			return result;
		}
		return Array.Empty<int>();
	}

	// Token: 0x060098B4 RID: 39092 RVA: 0x002D46E4 File Offset: 0x002D28E4
	public bool GetDangoIfLock(int roleId)
	{
		AbyssDangoRoleData dangoAbyssRoleData = this.GetDangoAbyssRoleData(roleId);
		return dangoAbyssRoleData == null || dangoAbyssRoleData.GetIfLock();
	}

	// Token: 0x060098B5 RID: 39093 RVA: 0x002D4704 File Offset: 0x002D2904
	public bool GetDangoDevelopRedDot()
	{
		return this.GetDangoNewRedDot() || this.GetDangoLevelUpRedDot(new bool?(true));
	}

	// Token: 0x060098B6 RID: 39094 RVA: 0x002D471C File Offset: 0x002D291C
	public bool GetDangoRoleRedDot(int roleId)
	{
		return this.GetDangoNewRedDotById(roleId) || this.GetDangoLevelUpRedDotById(roleId, new bool?(true));
	}

	// Token: 0x060098B7 RID: 39095 RVA: 0x002D4738 File Offset: 0x002D2938
	public bool GetDangoFormationNewRedDot()
	{
		foreach (AbyssDangoRoleData abyssDangoRoleData in this.GetAllDangoList())
		{
			if (this.GetDangoFormationNewRoleRedDot(abyssDangoRoleData.GetId()))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x060098B8 RID: 39096 RVA: 0x002D476F File Offset: 0x002D296F
	public bool GetDangoFormationNewRoleRedDot(int roleId)
	{
		return this.GetDangoFormationNewRedDotById(roleId);
	}

	// Token: 0x060098B9 RID: 39097 RVA: 0x002D4778 File Offset: 0x002D2978
	public bool GetDangoNewRedDot()
	{
		foreach (AbyssDangoRoleData abyssDangoRoleData in this.GetAllDangoList())
		{
			if (this.GetDangoNewRedDotById(abyssDangoRoleData.GetId()))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x060098BA RID: 39098 RVA: 0x002D47AF File Offset: 0x002D29AF
	public bool GetDangoNewRedDotById(int roleId)
	{
		return this.GetDangoAbyssRoleData(roleId) != null && this.GetDangoIfNew(roleId);
	}

	// Token: 0x060098BB RID: 39099 RVA: 0x002D47C6 File Offset: 0x002D29C6
	public bool GetDangoFormationNewRedDotById(int roleId)
	{
		return this.GetDangoAbyssRoleData(roleId) != null && this.GetDangoFormationIfNew(roleId);
	}

	// Token: 0x060098BC RID: 39100 RVA: 0x002D47DD File Offset: 0x002D29DD
	public void SetDangoHasCheck(int roleId)
	{
		this.SetDangoIfNew(roleId, false);
		this.SetDangoLevelCheck(roleId);
	}

	// Token: 0x060098BD RID: 39101 RVA: 0x002D47F0 File Offset: 0x002D29F0
	public void SetDangoIfNew(int roleId, bool ifNew)
	{
		AbyssDangoRoleData dangoAbyssRoleData = this.GetDangoAbyssRoleData(roleId);
		if (dangoAbyssRoleData != null && !dangoAbyssRoleData.GetIfLock())
		{
			ServerStorageUtil.OverrideLocalBoolMapToServerSet(ELocalStoragePlayerKey.AbyssDangoRoleNew, EClientStorageSystemIdType.AbyssDangoRoleNew, true);
			ServerStorageSet serverStorageSet = ServerStorageModel.Instance.Get(EClientStorageSystemIdType.AbyssDangoRoleNew) as ServerStorageSet;
			if (ifNew)
			{
				serverStorageSet.Add(roleId);
				return;
			}
			serverStorageSet.Remove(roleId);
		}
	}

	// Token: 0x060098BE RID: 39102 RVA: 0x002D4844 File Offset: 0x002D2A44
	public bool GetDangoIfNew(int roleId)
	{
		AbyssDangoRoleData dangoAbyssRoleData = this.GetDangoAbyssRoleData(roleId);
		if (dangoAbyssRoleData != null && !dangoAbyssRoleData.GetIfLock())
		{
			ServerStorageUtil.OverrideLocalBoolMapToServerSet(ELocalStoragePlayerKey.AbyssDangoRoleNew, EClientStorageSystemIdType.AbyssDangoRoleNew, true);
			return (ServerStorageModel.Instance.Get(EClientStorageSystemIdType.AbyssDangoRoleNew) as ServerStorageSet).Has(roleId);
		}
		return false;
	}

	// Token: 0x060098BF RID: 39103 RVA: 0x002D488C File Offset: 0x002D2A8C
	public bool GetAbyssDangoEnterNew()
	{
		ServerStorageUtil.OverrideLocalBooleanToServerBoolean(ELocalStoragePlayerKey.AbyssDangoEnterNew, EClientStorageSystemIdType.AbyssDangoEnterNew, true);
		return (ServerStorageModel.Instance.Get(EClientStorageSystemIdType.AbyssDangoEnterNew) as ServerStorageBoolean).Get().GetValueOrDefault(true);
	}

	// Token: 0x060098C0 RID: 39104 RVA: 0x002D48C6 File Offset: 0x002D2AC6
	public void SetAbyssDangoEnterNew(bool ifNew)
	{
		(ServerStorageModel.Instance.Get(EClientStorageSystemIdType.AbyssDangoEnterNew) as ServerStorageBoolean).Set(new bool?(ifNew));
	}

	// Token: 0x060098C1 RID: 39105 RVA: 0x002D48E4 File Offset: 0x002D2AE4
	public void SetDangoFormationIfNew(int dangoId, bool ifNew)
	{
		if (this.GetDangoAbyssRoleData(dangoId) != null)
		{
			ServerStorageUtil.OverrideLocalBoolMapToServerSet(ELocalStoragePlayerKey.AbyssDangoFormationNew, EClientStorageSystemIdType.AbyssDangoFormationNew, true);
			ServerStorageSet serverStorageSet = ServerStorageModel.Instance.Get(EClientStorageSystemIdType.AbyssDangoFormationNew) as ServerStorageSet;
			if (ifNew)
			{
				serverStorageSet.Add(dangoId);
			}
			else
			{
				serverStorageSet.Remove(dangoId);
			}
		}
		EventSystem.Instance.Emit<int>(EEventName.RefreshAbyssDangoRedDot, dangoId);
	}

	// Token: 0x060098C2 RID: 39106 RVA: 0x002D493E File Offset: 0x002D2B3E
	public bool GetDangoFormationIfNew(int dangoId)
	{
		if (this.GetDangoAbyssRoleData(dangoId) != null)
		{
			ServerStorageUtil.OverrideLocalBoolMapToServerSet(ELocalStoragePlayerKey.AbyssDangoFormationNew, EClientStorageSystemIdType.AbyssDangoFormationNew, true);
			return (ServerStorageModel.Instance.Get(EClientStorageSystemIdType.AbyssDangoFormationNew) as ServerStorageSet).Has(dangoId);
		}
		return false;
	}

	// Token: 0x060098C3 RID: 39107 RVA: 0x002D4970 File Offset: 0x002D2B70
	public void SetDangoLevelCheck(int roleId)
	{
		AbyssDangoRoleData dangoAbyssRoleData = this.GetDangoAbyssRoleData(roleId);
		bool dangoLevelUpRedDotById = this.GetDangoLevelUpRedDotById(roleId, new bool?(false));
		if (dangoAbyssRoleData == null || !dangoLevelUpRedDotById)
		{
			return;
		}
		int value = dangoAbyssRoleData.GetLevel() + 1;
		ServerStorageUtil.OverrideLocalMapToServerMap(ELocalStoragePlayerKey.AbyssDangoLevelCheck, EClientStorageSystemIdType.AbyssDangoLevelCheck, true);
		(ServerStorageModel.Instance.Get(EClientStorageSystemIdType.AbyssDangoLevelCheck) as ServerStorageMap).Set(roleId, value);
	}

	// Token: 0x060098C4 RID: 39108 RVA: 0x002D49CC File Offset: 0x002D2BCC
	public int GetDangoLastCheckLevel(int roleId)
	{
		ServerStorageUtil.OverrideLocalMapToServerMap(ELocalStoragePlayerKey.AbyssDangoLevelCheck, EClientStorageSystemIdType.AbyssDangoLevelCheck, true);
		return (ServerStorageModel.Instance.Get(EClientStorageSystemIdType.AbyssDangoLevelCheck) as ServerStorageMap).Get(roleId).GetValueOrDefault(1);
	}

	// Token: 0x060098C5 RID: 39109 RVA: 0x002D4A08 File Offset: 0x002D2C08
	public bool GetDangoLevelUpRedDot(bool? needCheck = null)
	{
		foreach (AbyssDangoRoleData abyssDangoRoleData in this.GetAllDangoList())
		{
			if (this.GetDangoLevelUpRedDotById(abyssDangoRoleData.GetId(), needCheck))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x060098C6 RID: 39110 RVA: 0x002D4A40 File Offset: 0x002D2C40
	public bool GetDangoLevelUpRedDotById(int roleId, bool? needCheck = null)
	{
		AbyssDangoRoleData dangoAbyssRoleData = this.GetDangoAbyssRoleData(roleId);
		if (dangoAbyssRoleData == null || dangoAbyssRoleData.GetIfLock())
		{
			return false;
		}
		bool ifCanLevelUp = dangoAbyssRoleData.GetIfCanLevelUp();
		bool ifLevelUpEnough = dangoAbyssRoleData.GetIfLevelUpEnough();
		return ifCanLevelUp && ifLevelUpEnough && (!needCheck.GetValueOrDefault() || this.GetDangoLastCheckLevel(roleId) < dangoAbyssRoleData.GetLevel() + 1);
	}

	// Token: 0x060098C7 RID: 39111 RVA: 0x002D4A94 File Offset: 0x002D2C94
	public Dictionary<int, int> GetRecoverySelectionCountMap(List<ISelectedData> dataList)
	{
		Dictionary<int, int> dictionary = new Dictionary<int, int>();
		foreach (ISelectedData selectedData in dataList)
		{
			AbyssItem? pluginItemConfigByIncId = this.GetPluginItemConfigByIncId(selectedData.IncId);
			if (pluginItemConfigByIncId != null)
			{
				int qualityId = pluginItemConfigByIncId.Value.QualityId;
				if (dictionary.ContainsKey(qualityId))
				{
					dictionary[qualityId]++;
				}
				else
				{
					dictionary[qualityId] = 1;
				}
			}
		}
		return dictionary;
	}

	// Token: 0x060098C8 RID: 39112 RVA: 0x002D4B34 File Offset: 0x002D2D34
	public Dictionary<int, int> GetRecoveryTimesCountMap(Dictionary<int, int> qualityMap)
	{
		Dictionary<int, int> dictionary = new Dictionary<int, int>();
		foreach (KeyValuePair<int, int> keyValuePair in qualityMap)
		{
			double num = Math.Floor((double)keyValuePair.Value / 1.0);
			dictionary[keyValuePair.Key] = (int)num;
		}
		return dictionary;
	}

	// Token: 0x060098C9 RID: 39113 RVA: 0x002D4BAC File Offset: 0x002D2DAC
	public int GetRecoveryTimesCountAll(Dictionary<int, int> qualityMap)
	{
		int num = 0;
		foreach (KeyValuePair<int, int> keyValuePair in qualityMap)
		{
			num += (int)Math.Floor((double)keyValuePair.Value / 1.0);
		}
		return num;
	}

	// Token: 0x060098CA RID: 39114 RVA: 0x002D4C14 File Offset: 0x002D2E14
	public Dictionary<int, int> GetRecoveryRewardItemMap(Dictionary<int, int> timesMap)
	{
		Dictionary<int, int> dictionary = new Dictionary<int, int>();
		foreach (KeyValuePair<int, int> keyValuePair in timesMap)
		{
			int value = keyValuePair.Value;
			int key = keyValuePair.Key;
			if (value > 0)
			{
				AbyssSynthesis? abyssSynthesisByQualityId = DangoAbyssConfig.Instance.GetAbyssSynthesisByQualityId(key);
				if (abyssSynthesisByQualityId != null)
				{
					for (int i = 0; i < abyssSynthesisByQualityId.Value.DecomposeInfoLength; i++)
					{
						DicIntInt? dicIntInt = abyssSynthesisByQualityId.Value.DecomposeInfo(i);
						int key2 = dicIntInt.Value.Key;
						int value2 = dicIntInt.Value.Value;
						if (dictionary.ContainsKey(key2))
						{
							dictionary[key2] += value * value2;
						}
						else
						{
							dictionary[key2] = value * value2;
						}
					}
				}
			}
		}
		return dictionary;
	}

	// Token: 0x060098CB RID: 39115 RVA: 0x002D4D20 File Offset: 0x002D2F20
	public bool GetRecoveryAvailable()
	{
		int currentLastFinishChallengeId = this.GetCurrentOpenAbyssActivityData().GetCurrentLastFinishChallengeId();
		AbyssInst? dangoAbyssInstById = DangoAbyssConfig.Instance.GetDangoAbyssInstById(currentLastFinishChallengeId);
		return dangoAbyssInstById != null && dangoAbyssInstById.Value.AbyssSynthesisEntr;
	}

	// Token: 0x060098CC RID: 39116 RVA: 0x002D4D60 File Offset: 0x002D2F60
	public bool GetRankOpen()
	{
		int currentLastFinishChallengeId = this.GetCurrentOpenAbyssActivityData().GetCurrentLastFinishChallengeId();
		AbyssInst? dangoAbyssInstById = DangoAbyssConfig.Instance.GetDangoAbyssInstById(currentLastFinishChallengeId);
		return dangoAbyssInstById != null && dangoAbyssInstById.Value.AbyssRank;
	}

	// Token: 0x060098CD RID: 39117 RVA: 0x002D4DA0 File Offset: 0x002D2FA0
	public int GetMainHonorRank(IReadOnlyList<IAbyssDescData> dataList, bool addRank = false)
	{
		if (dataList.Count == 0)
		{
			return 0;
		}
		int id = dataList[0].Id;
		int count = dataList[0].Count;
		Dictionary<int, string> dictionary = DangoAbyssConfig.Instance.GetAbyssSettleById(id).Value.Title();
		int num = addRank ? -1 : 3;
		foreach (KeyValuePair<int, string> keyValuePair in dictionary)
		{
			if (count >= keyValuePair.Key)
			{
				if (addRank)
				{
					num++;
				}
				else
				{
					num--;
				}
			}
		}
		num = Math.Max(0, Math.Min(2, num));
		return num;
	}

	// Token: 0x060098CE RID: 39118 RVA: 0x002D4E58 File Offset: 0x002D3058
	public ItemTipsParam GetPluginItemTipsData(int itemId, int incId, int? slotIndex = null, int? dangoId = null)
	{
		DangoExtraParam extraParam = new DangoExtraParam
		{
			DangoId = dangoId.GetValueOrDefault(-1),
			SlotIndex = slotIndex.GetValueOrDefault(-1)
		};
		return new ItemTipsParam
		{
			ItemId = itemId,
			ItemUid = incId,
			ExtraParam = extraParam
		};
	}

	// Token: 0x060098CF RID: 39119 RVA: 0x002D4EA4 File Offset: 0x002D30A4
	public string GetSkillDescByDangoId(int dangoId)
	{
		AbyssLittleRole? dangoRoleById = DangoAbyssConfig.Instance.GetDangoRoleById(dangoId);
		if (dangoRoleById == null)
		{
			return "";
		}
		int phantomItemId = dangoRoleById.Value.PhantomItemId;
		Aki.Config.PhantomItem? phantomItemById = PhantomBattleConfig.Instance.GetPhantomItemById(phantomItemId);
		return PhantomBattleConfig.Instance.GetPhantomSkillDescStringBySkillIdAndQuality(phantomItemById.Value.SkillId, 2);
	}

	// Token: 0x060098D0 RID: 39120 RVA: 0x002D4F04 File Offset: 0x002D3104
	public bool GetDangoUpAvailable()
	{
		int currentLastFinishChallengeId = this.GetCurrentOpenAbyssActivityData().GetCurrentLastFinishChallengeId();
		AbyssInst? dangoAbyssInstById = DangoAbyssConfig.Instance.GetDangoAbyssInstById(currentLastFinishChallengeId);
		return dangoAbyssInstById != null && dangoAbyssInstById.Value.AbyssDevelopEntr;
	}

	// Token: 0x060098D1 RID: 39121 RVA: 0x002D4F44 File Offset: 0x002D3144
	public bool GetShopAvailable()
	{
		int currentLastFinishChallengeId = this.GetCurrentOpenAbyssActivityData().GetCurrentLastFinishChallengeId();
		AbyssInst? dangoAbyssInstById = DangoAbyssConfig.Instance.GetDangoAbyssInstById(currentLastFinishChallengeId);
		return dangoAbyssInstById != null && dangoAbyssInstById.Value.AbyssStoreEntr;
	}

	// Token: 0x060098D2 RID: 39122 RVA: 0x002D4F84 File Offset: 0x002D3184
	[NullableContext(2)]
	public global::AbyssRewardInfo GetRewardInfoById(int rewardId)
	{
		DangoAbyssActivityData currentOpenAbyssActivityData = this.GetCurrentOpenAbyssActivityData();
		if (currentOpenAbyssActivityData == null)
		{
			return null;
		}
		return currentOpenAbyssActivityData.GetRewardInfoById(rewardId);
	}

	// Token: 0x060098D3 RID: 39123 RVA: 0x002D4FA4 File Offset: 0x002D31A4
	public void SetLikeRecord(IEnumerable<AbyssLikeRecord> data)
	{
		List<DangoAbyssDefine.IAbyssLikeRecord> list = new List<DangoAbyssDefine.IAbyssLikeRecord>();
		foreach (AbyssLikeRecord abyssLikeRecord in data)
		{
			DangoAbyssDefine.IAbyssLikeRecord item = new DangoAbyssDefine.IAbyssLikeRecord
			{
				PlayerId = abyssLikeRecord.PlayerId,
				LikedPlayerIdList = new List<int>(abyssLikeRecord.LikedPlayerId)
			};
			list.Add(item);
		}
		this.AbyssLikedRecord = list.ToArray();
	}

	// Token: 0x060098D4 RID: 39124 RVA: 0x002D5024 File Offset: 0x002D3224
	public bool GetPlayerIfLikePlayer(int playerId, int targetPlayerId)
	{
		if (playerId == targetPlayerId)
		{
			return true;
		}
		foreach (DangoAbyssDefine.IAbyssLikeRecord abyssLikeRecord in this.AbyssLikedRecord)
		{
			if (abyssLikeRecord.PlayerId == targetPlayerId)
			{
				using (List<int>.Enumerator enumerator = abyssLikeRecord.LikedPlayerIdList.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						if (enumerator.Current == playerId)
						{
							return true;
						}
					}
				}
			}
		}
		return false;
	}

	// Token: 0x060098D5 RID: 39125 RVA: 0x002D50A4 File Offset: 0x002D32A4
	public bool IsChallengeFinish()
	{
		return this.ChallengeFinish;
	}

	// Token: 0x17001078 RID: 4216
	// (get) Token: 0x060098D6 RID: 39126 RVA: 0x002D50AC File Offset: 0x002D32AC
	public static DangoAbyssModel Instance
	{
		get
		{
			return DangoAbyssModel._Instance;
		}
	}

	// Token: 0x060098D7 RID: 39127 RVA: 0x002D50B3 File Offset: 0x002D32B3
	public static DangoAbyssModel GetOrCreateInstance()
	{
		if (DangoAbyssModel._Instance == null)
		{
			DangoAbyssModel.CreateInstance();
		}
		return DangoAbyssModel._Instance;
	}

	// Token: 0x060098D8 RID: 39128 RVA: 0x002D50C7 File Offset: 0x002D32C7
	public static bool CreateInstance()
	{
		if (DangoAbyssModel._Instance != null)
		{
			return true;
		}
		DangoAbyssModel._Instance = new DangoAbyssModel();
		return true;
	}

	// Token: 0x060098D9 RID: 39129 RVA: 0x002D50DD File Offset: 0x002D32DD
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060098DA RID: 39130 RVA: 0x002D50DF File Offset: 0x002D32DF
	public static void ResetStaticDefaultValue()
	{
		DangoAbyssModel._Instance = null;
	}

	// Token: 0x060098DB RID: 39131 RVA: 0x002D50E7 File Offset: 0x002D32E7
	static DangoAbyssModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(DangoAbyssModel.CreateStaticDefaultValue), new Action(DangoAbyssModel.ResetStaticDefaultValue));
	}

	// Token: 0x04005B73 RID: 23411
	public bool LeaveFromAbyssWorld;

	// Token: 0x04005B74 RID: 23412
	private bool InAbyssFlowInternal;

	// Token: 0x04005B75 RID: 23413
	public int CurrentSelectEntranceId;

	// Token: 0x04005B76 RID: 23414
	public int CurrentSelectChallengeId;

	// Token: 0x04005B77 RID: 23415
	private int CurrentLayer;

	// Token: 0x04005B78 RID: 23416
	private int MaxLayer;

	// Token: 0x04005B79 RID: 23417
	private int GainBoxCount;

	// Token: 0x04005B7A RID: 23418
	private int MaxBoxCount;

	// Token: 0x04005B7B RID: 23419
	private int CurrentRoomId;

	// Token: 0x04005B7C RID: 23420
	private int CurrentChallengeId = 1;

	// Token: 0x04005B7D RID: 23421
	private int CurrentRouteId;

	// Token: 0x04005B7E RID: 23422
	[Nullable(2)]
	private AbyssRankChallengeInfo ChallengeRankInfo;

	// Token: 0x04005B7F RID: 23423
	[Nullable(2)]
	private AbyssFormationInfo CurrentFormationSelectInfo;

	// Token: 0x04005B80 RID: 23424
	[Nullable(2)]
	private AbyssChallengeResultData CurrentAbyssResultInfo;

	// Token: 0x04005B81 RID: 23425
	public Dictionary<int, Dictionary<int, int>> FormationIndex2DangoIdMapCache = new Dictionary<int, Dictionary<int, int>>();

	// Token: 0x04005B82 RID: 23426
	[Nullable(2)]
	private Dictionary<int, int> RoleSelectDangoMap;

	// Token: 0x04005B83 RID: 23427
	private int MaxScore;

	// Token: 0x04005B84 RID: 23428
	private int CurrentScore;

	// Token: 0x04005B85 RID: 23429
	private readonly Dictionary<int, Dictionary<int, AbyssDangoOwnerData>> DangoOwnerMap = new Dictionary<int, Dictionary<int, AbyssDangoOwnerData>>();

	// Token: 0x04005B86 RID: 23430
	private bool ChallengeFinish;

	// Token: 0x04005B87 RID: 23431
	private DangoAbyssDefine.IAbyssLikeRecord[] AbyssLikedRecord = Array.Empty<DangoAbyssDefine.IAbyssLikeRecord>();

	// Token: 0x04005B88 RID: 23432
	[Nullable(2)]
	private static DangoAbyssModel _Instance;
}
