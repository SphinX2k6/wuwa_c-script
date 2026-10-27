using System;
using System.Collections.Generic;
using System.Linq;
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
using CSharpScript.Module.InstanceDungeon;

// Token: 0x02001A1E RID: 6686
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class DangoAbyssModel : ModelBase
{
	// Token: 0x0600C439 RID: 50233 RVA: 0x002C6D8E File Offset: 0x002C4F8E
	protected override bool OnLeaveLevel()
	{
		this.ChallengeFinish = false;
		this.CurrentRoomId = 0;
		return true;
	}

	// Token: 0x0600C43A RID: 50234 RVA: 0x002C6D9F File Offset: 0x002C4F9F
	public void OnAbyssChallengeResultNotify(AbyssChallengeResultNotify notify)
	{
		this.CurrentAbyssResultInfo = new AbyssChallengeResultData();
		this.CurrentAbyssResultInfo.Phrase(notify.Result);
		this.ChallengeFinish = true;
		this.SetLikeRecord(notify.Result.LikeRecord.ToList<AbyssLikeRecord>());
	}

	// Token: 0x0600C43B RID: 50235 RVA: 0x002C6DDA File Offset: 0x002C4FDA
	public AbyssRankChallengeInfo GetChallengeRankInfo()
	{
		if (this.ChallengeRankInfo == null)
		{
			this.ChallengeRankInfo = new AbyssRankChallengeInfo();
		}
		return this.ChallengeRankInfo;
	}

	// Token: 0x0600C43C RID: 50236 RVA: 0x002C6DF5 File Offset: 0x002C4FF5
	public void OnAnonymousNameStateChange(int challengeId, bool state)
	{
		this.GetChallengeRankInfo().SetIsOpenAnonymousName(challengeId, state);
	}

	// Token: 0x0600C43D RID: 50237 RVA: 0x002C6E04 File Offset: 0x002C5004
	public bool GetChallengeAnonymousNameState(int challengeId)
	{
		return this.GetChallengeRankInfo().GetAnonymousNameMode(challengeId);
	}

	// Token: 0x0600C43E RID: 50238 RVA: 0x002C6E14 File Offset: 0x002C5014
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

	// Token: 0x0600C43F RID: 50239 RVA: 0x002C6E70 File Offset: 0x002C5070
	public List<PayShopGoods> GetPayShopGoods()
	{
		int openShopId = DangoAbyssModel.Instance.GetOpenShopId();
		return PayShopModel.Instance.GetPayShopTabData((PayShopDefine.EPayShopTabType)openShopId, 1, false);
	}

	// Token: 0x0600C440 RID: 50240 RVA: 0x002C6E95 File Offset: 0x002C5095
	public void OnAbyssChallegenRankUpdate(AbyssRankListResponse notify)
	{
		this.GetChallengeRankInfo().OnChallengeRankInfoUpdate(notify);
	}

	// Token: 0x0600C441 RID: 50241 RVA: 0x002C6EA3 File Offset: 0x002C50A3
	public void OnAbyssChallengeSelfRankUpdate(AbyssSelfPassResponse notify)
	{
		this.GetChallengeRankInfo().OnSelfRankInfoUpdate(notify);
	}

	// Token: 0x0600C442 RID: 50242 RVA: 0x002C6EB4 File Offset: 0x002C50B4
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
		this.SetLikeRecord(notify.LikeRecord.ToList<AbyssLikeRecord>());
	}

	// Token: 0x0600C443 RID: 50243 RVA: 0x002C6F3C File Offset: 0x002C513C
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

	// Token: 0x0600C444 RID: 50244 RVA: 0x002C6F6B File Offset: 0x002C516B
	public void OnAbyssFormationRoleSelectUpdateNotify(AbyssRoleSelectUpdateNotify notify)
	{
		this.CurrentFormationSelectInfo = new AbyssFormationInfo();
		this.CurrentFormationSelectInfo.Phrase(notify);
	}

	// Token: 0x0600C445 RID: 50245 RVA: 0x002C6F84 File Offset: 0x002C5184
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

	// Token: 0x0600C446 RID: 50246 RVA: 0x002C6FF8 File Offset: 0x002C51F8
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

	// Token: 0x0600C447 RID: 50247 RVA: 0x002C7038 File Offset: 0x002C5238
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

	// Token: 0x0600C448 RID: 50248 RVA: 0x002C707C File Offset: 0x002C527C
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

	// Token: 0x0600C449 RID: 50249 RVA: 0x002C70C0 File Offset: 0x002C52C0
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

	// Token: 0x0600C44A RID: 50250 RVA: 0x002C7104 File Offset: 0x002C5304
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

	// Token: 0x0600C44B RID: 50251 RVA: 0x002C7148 File Offset: 0x002C5348
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

	// Token: 0x0600C44C RID: 50252 RVA: 0x002C7190 File Offset: 0x002C5390
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

	// Token: 0x0600C44D RID: 50253 RVA: 0x002C71D0 File Offset: 0x002C53D0
	public bool CheckIsSelf(int playerId)
	{
		int? id = PlayerInfoModel.Instance.GetId();
		return id.GetValueOrDefault() == playerId & id != null;
	}

	// Token: 0x0600C44E RID: 50254 RVA: 0x002C71FC File Offset: 0x002C53FC
	public bool CheckInAbyss()
	{
		InstanceDungeon? instanceDungeon;
		return InstanceDungeonConfig.Instance.GetConfig(CreatureModel.Instance.GetInstanceId()) != null && instanceDungeon.GetValueOrDefault().InstSubType == 33 && GameModeController.Instance.IsInInstance();
	}

	// Token: 0x0600C44F RID: 50255 RVA: 0x002C724C File Offset: 0x002C544C
	public bool CheckInAbyssEditFormationState()
	{
		InstanceDungeon? dungeonConfig = BattleTeamModel.Instance.Context.GetDungeonConfig();
		return dungeonConfig != null && dungeonConfig.Value.InstSubType == 33;
	}

	// Token: 0x0600C450 RID: 50256 RVA: 0x002C728C File Offset: 0x002C548C
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

	// Token: 0x0600C451 RID: 50257 RVA: 0x002C736F File Offset: 0x002C556F
	public bool CheckIsInMatch()
	{
		return InstanceDungeonEntranceModel.Instance.GetMatchingState() > EInstanceMatchState.Default;
	}

	// Token: 0x0600C452 RID: 50258 RVA: 0x002C7380 File Offset: 0x002C5580
	public void PhraseRoomInfo(AbyssChallengeRoomInfoNotify data)
	{
		this.CurrentLayer = data.CurFloor;
		this.MaxLayer = data.MaxFloor;
		this.MaxBoxCount = data.MaxBox;
		this.GainBoxCount = data.GainBox;
		this.CurrentRouteId = data.RouteId;
		this.CurrentChallengeId = data.ChallengeId;
		this.RoleSelectDangoMap = data.RoleEquipMap.ToDictionary<int, int>();
		this.MaxScore = data.MaxScore;
		this.CurrentScore = data.CurScore;
		bool currentRoomId = this.CurrentRoomId != 0;
		this.CurrentRoomId = data.RoomId;
		if (!currentRoomId && this.CurrentRoomId != 0)
		{
			EventSystem.Instance.Emit(EEventName.OnAbyssFirstRoomEnter);
		}
		this.SetLikeRecord(data.LikeRecord.ToList<AbyssLikeRecord>());
	}

	// Token: 0x0600C453 RID: 50259 RVA: 0x002C743B File Offset: 0x002C563B
	public Dictionary<int, int> GetRoleSelectDangoMap()
	{
		return this.RoleSelectDangoMap ?? new Dictionary<int, int>();
	}

	// Token: 0x0600C454 RID: 50260 RVA: 0x002C744C File Offset: 0x002C564C
	public int GetAbyssLayer()
	{
		return this.CurrentLayer;
	}

	// Token: 0x0600C455 RID: 50261 RVA: 0x002C7454 File Offset: 0x002C5654
	public int GetMaxLayer()
	{
		return this.MaxLayer;
	}

	// Token: 0x0600C456 RID: 50262 RVA: 0x002C745C File Offset: 0x002C565C
	public float GetCurrentAbyssCompletePercentage()
	{
		return (float)this.CurrentLayer / (float)this.MaxLayer;
	}

	// Token: 0x0600C457 RID: 50263 RVA: 0x002C746D File Offset: 0x002C566D
	public int GetCurrentRoomId()
	{
		return this.CurrentRoomId;
	}

	// Token: 0x0600C458 RID: 50264 RVA: 0x002C7475 File Offset: 0x002C5675
	public int GetGainBoxCount()
	{
		return this.GainBoxCount;
	}

	// Token: 0x0600C459 RID: 50265 RVA: 0x002C747D File Offset: 0x002C567D
	public int GetMaxBoxCount()
	{
		return this.MaxBoxCount;
	}

	// Token: 0x0600C45A RID: 50266 RVA: 0x002C7485 File Offset: 0x002C5685
	public bool GetInAbyssFlow()
	{
		return this.InAbyssFlowInternal;
	}

	// Token: 0x0600C45B RID: 50267 RVA: 0x002C748D File Offset: 0x002C568D
	public void SetInAbyssFlow(bool value)
	{
		this.InAbyssFlowInternal = value;
	}

	// Token: 0x0600C45C RID: 50268 RVA: 0x002C7498 File Offset: 0x002C5698
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

	// Token: 0x0600C45D RID: 50269 RVA: 0x002C7524 File Offset: 0x002C5724
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

	// Token: 0x0600C45E RID: 50270 RVA: 0x002C75CC File Offset: 0x002C57CC
	public CSharpScript.Game.Module.Inventory.ItemConfig GetDangoItemConfig(int itemId)
	{
		return InventoryConfig.Instance.GetItemConfigData(itemId);
	}

	// Token: 0x0600C45F RID: 50271 RVA: 0x002C75DC File Offset: 0x002C57DC
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

	// Token: 0x0600C460 RID: 50272 RVA: 0x002C7628 File Offset: 0x002C5828
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

	// Token: 0x0600C461 RID: 50273 RVA: 0x002C7694 File Offset: 0x002C5894
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

	// Token: 0x0600C462 RID: 50274 RVA: 0x002C76BF File Offset: 0x002C58BF
	private Dictionary<int, AbyssDangoOwnerData> GetPlayerOwnerDataMap(int playerId)
	{
		if (!this.DangoOwnerMap.ContainsKey(playerId))
		{
			this.DangoOwnerMap[playerId] = new Dictionary<int, AbyssDangoOwnerData>();
		}
		return this.DangoOwnerMap[playerId];
	}

	// Token: 0x0600C463 RID: 50275 RVA: 0x002C76EC File Offset: 0x002C58EC
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

	// Token: 0x0600C464 RID: 50276 RVA: 0x002C7748 File Offset: 0x002C5948
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

	// Token: 0x0600C465 RID: 50277 RVA: 0x002C7777 File Offset: 0x002C5977
	[NullableContext(2)]
	public AbyssDangoOwnerData GetRoleOwnerData(int playerId, int roleConfigId)
	{
		return this.GetPlayerRoleCfgOwnerData(playerId, roleConfigId);
	}

	// Token: 0x0600C466 RID: 50278 RVA: 0x002C7784 File Offset: 0x002C5984
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
						AbyssDangoOwnerData abyssDangoOwnerData3 = roleOwnerData;
						MatchRoleContext roleContext3 = matchRoleInfo.RoleContext;
						int[] array;
						if (roleContext3 == null)
						{
							array = null;
						}
						else
						{
							AbyssMatchRoleContext abyssCtx3 = roleContext3.AbyssCtx;
							if (abyssCtx3 == null)
							{
								array = null;
							}
							else
							{
								AbyssRoleInfo roleInfo3 = abyssCtx3.RoleInfo;
								array = ((roleInfo3 != null) ? roleInfo3.EquipItems.ToArray<int>() : null);
							}
						}
						abyssDangoOwnerData3.DangoEquipIds = (array ?? Array.Empty<int>());
					}
				}
			}
		}
	}

	// Token: 0x0600C467 RID: 50279 RVA: 0x002C7960 File Offset: 0x002C5B60
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

	// Token: 0x0600C468 RID: 50280 RVA: 0x002C7A94 File Offset: 0x002C5C94
	public float GetInstanceProgress()
	{
		return Math.Min((float)this.CurrentScore / (float)this.MaxScore, 1f);
	}

	// Token: 0x0600C469 RID: 50281 RVA: 0x002C7AB0 File Offset: 0x002C5CB0
	public string GetInstanceReviveTipTips()
	{
		int currentShareReviveTimes = DeadReviveModel.Instance.CurrentShareReviveTimes;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 1);
		defaultInterpolatedStringHandler.AppendFormatted<int>(currentShareReviveTimes);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x0600C46A RID: 50282 RVA: 0x002C7AE0 File Offset: 0x002C5CE0
	public string GetInstanceFloorProgressText()
	{
		float value = DangoAbyssModel.Instance.GetCurrentAbyssCompletePercentage() * 100f;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
		defaultInterpolatedStringHandler.AppendFormatted<float>(value, "F2");
		defaultInterpolatedStringHandler.AppendLiteral("%");
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x0600C46B RID: 50283 RVA: 0x002C7B28 File Offset: 0x002C5D28
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

	// Token: 0x0600C46C RID: 50284 RVA: 0x002C7B6F File Offset: 0x002C5D6F
	public string GetInstanceFloorDetailProgressText()
	{
		return this.GetInstanceFloorText();
	}

	// Token: 0x0600C46D RID: 50285 RVA: 0x002C7B77 File Offset: 0x002C5D77
	public int GetCurrentChallengeId()
	{
		return this.CurrentChallengeId;
	}

	// Token: 0x0600C46E RID: 50286 RVA: 0x002C7B80 File Offset: 0x002C5D80
	public int GetCurrentAbyssFullTime()
	{
		return DangoAbyssConfig.Instance.GetDangoAbyssInstById(this.CurrentChallengeId).Value.TotalTime;
	}

	// Token: 0x0600C46F RID: 50287 RVA: 0x002C7BB0 File Offset: 0x002C5DB0
	public int GetCurrentAbyssTotalScore()
	{
		return DangoAbyssConfig.Instance.GetDangoAbyssInstById(this.CurrentChallengeId).Value.TotalScore;
	}

	// Token: 0x0600C470 RID: 50288 RVA: 0x002C7BE0 File Offset: 0x002C5DE0
	public Dictionary<int, int> GetCurrentAbyssTreasureMap()
	{
		return DangoAbyssConfig.Instance.GetDangoAbyssInstById(this.CurrentChallengeId).Value.RewardTime();
	}

	// Token: 0x0600C471 RID: 50289 RVA: 0x002C7C10 File Offset: 0x002C5E10
	public bool IsPlanarDungeon()
	{
		return DangoAbyssConfig.Instance.GetDangoAbyssInstByInstId(CreatureModel.Instance.GetInstanceId()).Value.PlanarDungeon;
	}

	// Token: 0x0600C472 RID: 50290 RVA: 0x002C7C44 File Offset: 0x002C5E44
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

	// Token: 0x0600C473 RID: 50291 RVA: 0x002C7CB0 File Offset: 0x002C5EB0
	public string GetCurrentRouteDesc()
	{
		if (this.CurrentRouteId == 0)
		{
			return "";
		}
		return ConfigMultiTextLang.GetLocalTextNew(DangoAbyssConfig.Instance.GetAbyssRouteByRouteIdAndFloorId(this.CurrentRouteId, this.CurrentLayer).Value.Desc, null);
	}

	// Token: 0x0600C474 RID: 50292 RVA: 0x002C7CF8 File Offset: 0x002C5EF8
	public string GetInstanceRemainTimeText()
	{
		double challengeRemainTime = InstanceDungeonModel.Instance.GetInstanceDungeonInfo().Tree.GetChallengeRemainTime(null);
		return TimeUtil.Instance.GetTimeDataFormat(Math.Ceiling(challengeRemainTime));
	}

	// Token: 0x0600C475 RID: 50293 RVA: 0x002C7D34 File Offset: 0x002C5F34
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

	// Token: 0x0600C476 RID: 50294 RVA: 0x002C7D78 File Offset: 0x002C5F78
	public void RefreshOwnDataAfterChange(int playerId)
	{
		foreach (KeyValuePair<int, AbyssDangoOwnerData> keyValuePair in this.GetPlayerOwnerDataMap(playerId))
		{
			this.RefreshOwnData(keyValuePair.Key, keyValuePair.Value);
		}
	}

	// Token: 0x0600C477 RID: 50295 RVA: 0x002C7DDC File Offset: 0x002C5FDC
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

	// Token: 0x0600C478 RID: 50296 RVA: 0x002C7EBC File Offset: 0x002C60BC
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

	// Token: 0x0600C479 RID: 50297 RVA: 0x002C7F3C File Offset: 0x002C613C
	public AbyssDangoRoleData[] GetAllDangoList()
	{
		DangoAbyssActivityData currentOpenAbyssActivityData = this.GetCurrentOpenAbyssActivityData();
		if (currentOpenAbyssActivityData == null)
		{
			return Array.Empty<AbyssDangoRoleData>();
		}
		return currentOpenAbyssActivityData.GetAllDangoList();
	}

	// Token: 0x0600C47A RID: 50298 RVA: 0x002C7F60 File Offset: 0x002C6160
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

	// Token: 0x0600C47B RID: 50299 RVA: 0x002C7F80 File Offset: 0x002C6180
	public AbyssItem? GetPluginItemConfigByIncId(int incId)
	{
		global::AbyssPluginItemInfo pluginItemInfoById = this.GetPluginItemInfoById(incId);
		if (pluginItemInfoById == null)
		{
			return null;
		}
		return pluginItemInfoById.GetConfig().As<AbyssItem>();
	}

	// Token: 0x0600C47C RID: 50300 RVA: 0x002C7FAC File Offset: 0x002C61AC
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

	// Token: 0x0600C47D RID: 50301 RVA: 0x002C8008 File Offset: 0x002C6208
	public global::AbyssPluginItemInfo[] GetAllPluginItemList()
	{
		DangoAbyssActivityData currentOpenAbyssActivityData = this.GetCurrentOpenAbyssActivityData();
		if (currentOpenAbyssActivityData == null)
		{
			return Array.Empty<global::AbyssPluginItemInfo>();
		}
		return currentOpenAbyssActivityData.GetPluginItemInfoAll();
	}

	// Token: 0x0600C47E RID: 50302 RVA: 0x002C802C File Offset: 0x002C622C
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

	// Token: 0x0600C47F RID: 50303 RVA: 0x002C8104 File Offset: 0x002C6304
	public Dictionary<int, Dictionary<int, AbyssDangoOwnerData>> GetCacheDangoOwnerMap()
	{
		return LocalStorage.GetPlayer<Dictionary<int, Dictionary<int, AbyssDangoOwnerData>>>(ELocalStoragePlayerKey.AbyssDangoFormationSelect, null) ?? new Dictionary<int, Dictionary<int, AbyssDangoOwnerData>>();
	}

	// Token: 0x0600C480 RID: 50304 RVA: 0x002C8118 File Offset: 0x002C6318
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

	// Token: 0x0600C481 RID: 50305 RVA: 0x002C81F8 File Offset: 0x002C63F8
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

	// Token: 0x0600C482 RID: 50306 RVA: 0x002C8248 File Offset: 0x002C6448
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

	// Token: 0x0600C483 RID: 50307 RVA: 0x002C82B8 File Offset: 0x002C64B8
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

	// Token: 0x0600C484 RID: 50308 RVA: 0x002C8370 File Offset: 0x002C6570
	private bool CheckLimitPassiveSame(DangoAbyssDefine.IAbyssItemTipsData data)
	{
		global::AbyssPluginItemInfo pluginItemInfoById = DangoAbyssModel.Instance.GetPluginItemInfoById(data.IncId);
		AbyssItem value = pluginItemInfoById.GetConfig().As<AbyssItem>().Value;
		int belongRole = pluginItemInfoById.GetBelongRole();
		bool flag = value.SlotType == 2 && belongRole > 0;
		return belongRole == data.DangoId && flag;
	}

	// Token: 0x0600C485 RID: 50309 RVA: 0x002C83CC File Offset: 0x002C65CC
	private bool CheckLimitPassiveRepeat(DangoAbyssDefine.IAbyssItemTipsData data)
	{
		int roleId = DangoAbyssModel.Instance.GetPluginItemInfoById(data.IncId).GetRoleId();
		bool flag = roleId > 0 && roleId == data.DangoId;
		int[] equipItems = DangoAbyssModel.Instance.GetDangoAbyssRoleData(data.DangoId).GetEquipItems();
		ValueTuple<bool, int> valueTuple = this.CheckRepeatPassivePlugin(equipItems, data.IncId);
		return valueTuple.Item1 && valueTuple.Item2 != data.SlotIndex && !flag;
	}

	// Token: 0x0600C486 RID: 50310 RVA: 0x002C8440 File Offset: 0x002C6640
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

	// Token: 0x0600C487 RID: 50311 RVA: 0x002C84FC File Offset: 0x002C66FC
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

	// Token: 0x0600C488 RID: 50312 RVA: 0x002C8584 File Offset: 0x002C6784
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

	// Token: 0x0600C489 RID: 50313 RVA: 0x002C8600 File Offset: 0x002C6800
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

	// Token: 0x0600C48A RID: 50314 RVA: 0x002C8634 File Offset: 0x002C6834
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

	// Token: 0x0600C48B RID: 50315 RVA: 0x002C871D File Offset: 0x002C691D
	public int GetPluginItemIncIdBySlotIndex(int roleId, int slotIndex)
	{
		AbyssDangoRoleSlotData pluginSlotData = DangoAbyssModel.Instance.GetDangoAbyssRoleData(roleId).GetPluginSlotData(slotIndex);
		if (pluginSlotData == null)
		{
			return 0;
		}
		return pluginSlotData.GetIncId();
	}

	// Token: 0x0600C48C RID: 50316 RVA: 0x002C873C File Offset: 0x002C693C
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

	// Token: 0x0600C48D RID: 50317 RVA: 0x002C87A8 File Offset: 0x002C69A8
	private int GetSlotUnlockCount(int slotIndex)
	{
		if (slotIndex == 0)
		{
			return 9;
		}
		return slotIndex;
	}

	// Token: 0x0600C48E RID: 50318 RVA: 0x002C87B4 File Offset: 0x002C69B4
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

	// Token: 0x0600C48F RID: 50319 RVA: 0x002C87F8 File Offset: 0x002C69F8
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

	// Token: 0x0600C490 RID: 50320 RVA: 0x002C889C File Offset: 0x002C6A9C
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

	// Token: 0x0600C491 RID: 50321 RVA: 0x002C8924 File Offset: 0x002C6B24
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

	// Token: 0x0600C492 RID: 50322 RVA: 0x002C89CC File Offset: 0x002C6BCC
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

	// Token: 0x0600C493 RID: 50323 RVA: 0x002C8A5C File Offset: 0x002C6C5C
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

	// Token: 0x0600C494 RID: 50324 RVA: 0x002C8BC4 File Offset: 0x002C6DC4
	private bool CheckOverMaxValue(int value, int maxValue)
	{
		if (maxValue < 0)
		{
			return value < maxValue;
		}
		return value > maxValue;
	}

	// Token: 0x0600C495 RID: 50325 RVA: 0x002C8BD4 File Offset: 0x002C6DD4
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

	// Token: 0x0600C496 RID: 50326 RVA: 0x002C8E0C File Offset: 0x002C700C
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

	// Token: 0x0600C497 RID: 50327 RVA: 0x002C8E60 File Offset: 0x002C7060
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

	// Token: 0x0600C498 RID: 50328 RVA: 0x002C8EE0 File Offset: 0x002C70E0
	public ConfigPropValue[] GetDangoBaseProp(int roleId)
	{
		return this.GetDangoAbyssRoleData(roleId).GetLevelConfig().Value.Prop();
	}

	// Token: 0x0600C499 RID: 50329 RVA: 0x002C8F0C File Offset: 0x002C710C
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

	// Token: 0x0600C49A RID: 50330 RVA: 0x002C905C File Offset: 0x002C725C
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

	// Token: 0x0600C49B RID: 50331 RVA: 0x002C9144 File Offset: 0x002C7344
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

	// Token: 0x0600C49C RID: 50332 RVA: 0x002C928C File Offset: 0x002C748C
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

	// Token: 0x0600C49D RID: 50333 RVA: 0x002C940C File Offset: 0x002C760C
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

	// Token: 0x0600C49E RID: 50334 RVA: 0x002C94E0 File Offset: 0x002C76E0
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

	// Token: 0x0600C49F RID: 50335 RVA: 0x002C950C File Offset: 0x002C770C
	public global::AbyssPluginItemInfo[] GetPluginItemListBySlotIndex(int slotIndex)
	{
		DangoAbyssDefine.ESlotType slotTypeByIndex = DangoAbyssConfig.Instance.GetSlotTypeByIndex(slotIndex);
		return DangoAbyssModel.Instance.GetPluginItemListByType(slotTypeByIndex);
	}

	// Token: 0x0600C4A0 RID: 50336 RVA: 0x002C9530 File Offset: 0x002C7730
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

	// Token: 0x0600C4A1 RID: 50337 RVA: 0x002C9560 File Offset: 0x002C7760
	public int GetPluginItemPackageCapacity()
	{
		InventoryDefine.EItemMainTypeId itemTypeId = InventoryDefine.EItemMainTypeId.DangoPluginItem;
		int packageId = InventoryConfig.Instance.GetItemMainTypeConfig((int)itemTypeId).Value.PackageId;
		return InventoryConfig.Instance.GetPackageConfig(packageId).Value.Capacity;
	}

	// Token: 0x0600C4A2 RID: 50338 RVA: 0x002C95AC File Offset: 0x002C77AC
	public void SaveFormationSelectRole(int challengeId, List<int> roleId)
	{
		Dictionary<int, int[]> dictionary = LocalStorage.GetPlayer<Dictionary<int, int[]>>(ELocalStoragePlayerKey.AbyssSelectRole, null) ?? new Dictionary<int, int[]>();
		dictionary[challengeId] = roleId.ToArray();
		LocalStorage.SetPlayer<Dictionary<int, int[]>>(ELocalStoragePlayerKey.AbyssSelectRole, dictionary);
	}

	// Token: 0x0600C4A3 RID: 50339 RVA: 0x002C95E8 File Offset: 0x002C77E8
	public int[] GetFormationSelectRoleList(int challengeId)
	{
		int[] result;
		if ((LocalStorage.GetPlayer<Dictionary<int, int[]>>(ELocalStoragePlayerKey.AbyssSelectRole, null) ?? new Dictionary<int, int[]>()).TryGetValue(challengeId, out result))
		{
			return result;
		}
		return Array.Empty<int>();
	}

	// Token: 0x0600C4A4 RID: 50340 RVA: 0x002C961C File Offset: 0x002C781C
	public bool GetDangoIfLock(int roleId)
	{
		AbyssDangoRoleData dangoAbyssRoleData = this.GetDangoAbyssRoleData(roleId);
		return dangoAbyssRoleData == null || dangoAbyssRoleData.GetIfLock();
	}

	// Token: 0x0600C4A5 RID: 50341 RVA: 0x002C963C File Offset: 0x002C783C
	public bool GetDangoDevelopRedDot()
	{
		return this.GetDangoNewRedDot() || this.GetDangoLevelUpRedDot(new bool?(true));
	}

	// Token: 0x0600C4A6 RID: 50342 RVA: 0x002C9654 File Offset: 0x002C7854
	public bool GetDangoRoleRedDot(int roleId)
	{
		return this.GetDangoNewRedDotById(roleId) || this.GetDangoLevelUpRedDotById(roleId, new bool?(true));
	}

	// Token: 0x0600C4A7 RID: 50343 RVA: 0x002C9670 File Offset: 0x002C7870
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

	// Token: 0x0600C4A8 RID: 50344 RVA: 0x002C96A7 File Offset: 0x002C78A7
	public bool GetDangoFormationNewRoleRedDot(int roleId)
	{
		return this.GetDangoFormationNewRedDotById(roleId);
	}

	// Token: 0x0600C4A9 RID: 50345 RVA: 0x002C96B0 File Offset: 0x002C78B0
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

	// Token: 0x0600C4AA RID: 50346 RVA: 0x002C96E7 File Offset: 0x002C78E7
	public bool GetDangoNewRedDotById(int roleId)
	{
		return this.GetDangoAbyssRoleData(roleId) != null && this.GetDangoIfNew(roleId);
	}

	// Token: 0x0600C4AB RID: 50347 RVA: 0x002C96FE File Offset: 0x002C78FE
	public bool GetDangoFormationNewRedDotById(int roleId)
	{
		return this.GetDangoAbyssRoleData(roleId) != null && this.GetDangoFormationIfNew(roleId);
	}

	// Token: 0x0600C4AC RID: 50348 RVA: 0x002C9715 File Offset: 0x002C7915
	public void SetDangoHasCheck(int roleId)
	{
		this.SetDangoIfNew(roleId, false);
		this.SetDangoLevelCheck(roleId);
	}

	// Token: 0x0600C4AD RID: 50349 RVA: 0x002C9728 File Offset: 0x002C7928
	public void SetDangoIfNew(int roleId, bool ifNew)
	{
		AbyssDangoRoleData dangoAbyssRoleData = this.GetDangoAbyssRoleData(roleId);
		if (dangoAbyssRoleData != null && !dangoAbyssRoleData.GetIfLock())
		{
			Dictionary<int, bool> dictionary = LocalStorage.GetPlayer<Dictionary<int, bool>>(ELocalStoragePlayerKey.AbyssDangoRoleNew, null) ?? new Dictionary<int, bool>();
			dictionary[roleId] = ifNew;
			LocalStorage.SetPlayer<Dictionary<int, bool>>(ELocalStoragePlayerKey.AbyssDangoRoleNew, dictionary);
		}
	}

	// Token: 0x0600C4AE RID: 50350 RVA: 0x002C9774 File Offset: 0x002C7974
	public bool GetDangoIfNew(int roleId)
	{
		AbyssDangoRoleData dangoAbyssRoleData = this.GetDangoAbyssRoleData(roleId);
		bool flag;
		return dangoAbyssRoleData != null && !dangoAbyssRoleData.GetIfLock() && (LocalStorage.GetPlayer<Dictionary<int, bool>>(ELocalStoragePlayerKey.AbyssDangoRoleNew, null) ?? new Dictionary<int, bool>()).TryGetValue(roleId, out flag) && flag;
	}

	// Token: 0x0600C4AF RID: 50351 RVA: 0x002C97B7 File Offset: 0x002C79B7
	public bool GetAbyssDangoEnterNew()
	{
		return LocalStorage.GetPlayer<bool>(ELocalStoragePlayerKey.AbyssDangoEnterNew, true);
	}

	// Token: 0x0600C4B0 RID: 50352 RVA: 0x002C97C4 File Offset: 0x002C79C4
	public void SetAbyssDangoEnterNew(bool ifNew)
	{
		LocalStorage.SetPlayer<bool>(ELocalStoragePlayerKey.AbyssDangoEnterNew, ifNew);
	}

	// Token: 0x0600C4B1 RID: 50353 RVA: 0x002C97D4 File Offset: 0x002C79D4
	public void SetDangoFormationIfNew(int dangoId, bool ifNew)
	{
		if (this.GetDangoAbyssRoleData(dangoId) != null)
		{
			Dictionary<int, bool> dictionary = LocalStorage.GetPlayer<Dictionary<int, bool>>(ELocalStoragePlayerKey.AbyssDangoFormationNew, null) ?? new Dictionary<int, bool>();
			dictionary[dangoId] = ifNew;
			LocalStorage.SetPlayer<Dictionary<int, bool>>(ELocalStoragePlayerKey.AbyssDangoFormationNew, dictionary);
		}
		EventSystem.Instance.Emit<int>(EEventName.RefreshAbyssDangoRedDot, dangoId);
	}

	// Token: 0x0600C4B2 RID: 50354 RVA: 0x002C9824 File Offset: 0x002C7A24
	public bool GetDangoFormationIfNew(int dangoId)
	{
		bool flag;
		return this.GetDangoAbyssRoleData(dangoId) != null && (LocalStorage.GetPlayer<Dictionary<int, bool>>(ELocalStoragePlayerKey.AbyssDangoFormationNew, null) ?? new Dictionary<int, bool>()).TryGetValue(dangoId, out flag) && flag;
	}

	// Token: 0x0600C4B3 RID: 50355 RVA: 0x002C9860 File Offset: 0x002C7A60
	public void SetDangoLevelCheck(int roleId)
	{
		AbyssDangoRoleData dangoAbyssRoleData = this.GetDangoAbyssRoleData(roleId);
		bool dangoLevelUpRedDotById = this.GetDangoLevelUpRedDotById(roleId, new bool?(false));
		if (dangoAbyssRoleData == null || !dangoLevelUpRedDotById)
		{
			return;
		}
		int value = dangoAbyssRoleData.GetLevel() + 1;
		Dictionary<int, int> dictionary = LocalStorage.GetPlayer<Dictionary<int, int>>(ELocalStoragePlayerKey.AbyssDangoLevelCheck, null) ?? new Dictionary<int, int>();
		dictionary[roleId] = value;
		LocalStorage.SetPlayer<Dictionary<int, int>>(ELocalStoragePlayerKey.AbyssDangoLevelCheck, dictionary);
	}

	// Token: 0x0600C4B4 RID: 50356 RVA: 0x002C98BC File Offset: 0x002C7ABC
	public int GetDangoLastCheckLevel(int roleId)
	{
		int result;
		if ((LocalStorage.GetPlayer<Dictionary<int, int>>(ELocalStoragePlayerKey.AbyssDangoLevelCheck, null) ?? new Dictionary<int, int>()).TryGetValue(roleId, out result))
		{
			return result;
		}
		return 1;
	}

	// Token: 0x0600C4B5 RID: 50357 RVA: 0x002C98EC File Offset: 0x002C7AEC
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

	// Token: 0x0600C4B6 RID: 50358 RVA: 0x002C9924 File Offset: 0x002C7B24
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

	// Token: 0x0600C4B7 RID: 50359 RVA: 0x002C9978 File Offset: 0x002C7B78
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

	// Token: 0x0600C4B8 RID: 50360 RVA: 0x002C9A18 File Offset: 0x002C7C18
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

	// Token: 0x0600C4B9 RID: 50361 RVA: 0x002C9A90 File Offset: 0x002C7C90
	public int GetRecoveryTimesCountAll(Dictionary<int, int> qualityMap)
	{
		int num = 0;
		foreach (KeyValuePair<int, int> keyValuePair in qualityMap)
		{
			num += (int)Math.Floor((double)keyValuePair.Value / 1.0);
		}
		return num;
	}

	// Token: 0x0600C4BA RID: 50362 RVA: 0x002C9AF8 File Offset: 0x002C7CF8
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

	// Token: 0x0600C4BB RID: 50363 RVA: 0x002C9C04 File Offset: 0x002C7E04
	public bool GetRecoveryAvailable()
	{
		int currentLastFinishChallengeId = this.GetCurrentOpenAbyssActivityData().GetCurrentLastFinishChallengeId();
		AbyssInst? dangoAbyssInstById = DangoAbyssConfig.Instance.GetDangoAbyssInstById(currentLastFinishChallengeId);
		return dangoAbyssInstById != null && dangoAbyssInstById.Value.AbyssSynthesisEntr;
	}

	// Token: 0x0600C4BC RID: 50364 RVA: 0x002C9C44 File Offset: 0x002C7E44
	public bool GetRankOpen()
	{
		int currentLastFinishChallengeId = this.GetCurrentOpenAbyssActivityData().GetCurrentLastFinishChallengeId();
		AbyssInst? dangoAbyssInstById = DangoAbyssConfig.Instance.GetDangoAbyssInstById(currentLastFinishChallengeId);
		return dangoAbyssInstById != null && dangoAbyssInstById.Value.AbyssRank;
	}

	// Token: 0x0600C4BD RID: 50365 RVA: 0x002C9C84 File Offset: 0x002C7E84
	public int GetMainHonorRank(List<IAbyssDescData> dataList, bool addRank = false)
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

	// Token: 0x0600C4BE RID: 50366 RVA: 0x002C9D3C File Offset: 0x002C7F3C
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

	// Token: 0x0600C4BF RID: 50367 RVA: 0x002C9D88 File Offset: 0x002C7F88
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

	// Token: 0x0600C4C0 RID: 50368 RVA: 0x002C9DE8 File Offset: 0x002C7FE8
	public bool GetDangoUpAvailable()
	{
		int currentLastFinishChallengeId = this.GetCurrentOpenAbyssActivityData().GetCurrentLastFinishChallengeId();
		AbyssInst? dangoAbyssInstById = DangoAbyssConfig.Instance.GetDangoAbyssInstById(currentLastFinishChallengeId);
		return dangoAbyssInstById != null && dangoAbyssInstById.Value.AbyssDevelopEntr;
	}

	// Token: 0x0600C4C1 RID: 50369 RVA: 0x002C9E28 File Offset: 0x002C8028
	public bool GetShopAvailable()
	{
		int currentLastFinishChallengeId = this.GetCurrentOpenAbyssActivityData().GetCurrentLastFinishChallengeId();
		AbyssInst? dangoAbyssInstById = DangoAbyssConfig.Instance.GetDangoAbyssInstById(currentLastFinishChallengeId);
		return dangoAbyssInstById != null && dangoAbyssInstById.Value.AbyssStoreEntr;
	}

	// Token: 0x0600C4C2 RID: 50370 RVA: 0x002C9E68 File Offset: 0x002C8068
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

	// Token: 0x0600C4C3 RID: 50371 RVA: 0x002C9E88 File Offset: 0x002C8088
	public void SetLikeRecord(List<AbyssLikeRecord> data)
	{
		List<DangoAbyssDefine.IAbyssLikeRecord> list = new List<DangoAbyssDefine.IAbyssLikeRecord>();
		foreach (AbyssLikeRecord abyssLikeRecord in data)
		{
			DangoAbyssDefine.IAbyssLikeRecord item = new DangoAbyssDefine.IAbyssLikeRecord
			{
				PlayerId = abyssLikeRecord.PlayerId,
				LikedPlayerIdList = abyssLikeRecord.LikedPlayerId.ToList<int>()
			};
			list.Add(item);
		}
		this.AbyssLikedRecord = list.ToArray();
	}

	// Token: 0x0600C4C4 RID: 50372 RVA: 0x002C9F0C File Offset: 0x002C810C
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

	// Token: 0x0600C4C5 RID: 50373 RVA: 0x002C9F8C File Offset: 0x002C818C
	public bool IsChallengeFinish()
	{
		return this.ChallengeFinish;
	}

	// Token: 0x17001053 RID: 4179
	// (get) Token: 0x0600C4C6 RID: 50374 RVA: 0x002C9F94 File Offset: 0x002C8194
	public static DangoAbyssModel Instance
	{
		get
		{
			return DangoAbyssModel._Instance;
		}
	}

	// Token: 0x0600C4C7 RID: 50375 RVA: 0x002C9F9B File Offset: 0x002C819B
	public static DangoAbyssModel GetOrCreateInstance()
	{
		if (DangoAbyssModel._Instance == null)
		{
			DangoAbyssModel.CreateInstance();
		}
		return DangoAbyssModel._Instance;
	}

	// Token: 0x0600C4C8 RID: 50376 RVA: 0x002C9FAF File Offset: 0x002C81AF
	public static bool CreateInstance()
	{
		if (DangoAbyssModel._Instance != null)
		{
			return true;
		}
		DangoAbyssModel._Instance = new DangoAbyssModel();
		return true;
	}

	// Token: 0x0600C4C9 RID: 50377 RVA: 0x002C9FC5 File Offset: 0x002C81C5
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600C4CA RID: 50378 RVA: 0x002C9FC7 File Offset: 0x002C81C7
	public static void ResetStaticDefaultValue()
	{
		DangoAbyssModel._Instance = null;
	}

	// Token: 0x0600C4CB RID: 50379 RVA: 0x002C9FCF File Offset: 0x002C81CF
	static DangoAbyssModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(DangoAbyssModel.CreateStaticDefaultValue), new Action(DangoAbyssModel.ResetStaticDefaultValue));
	}

	// Token: 0x04005AA4 RID: 23204
	public bool LeaveFromAbyssWorld;

	// Token: 0x04005AA5 RID: 23205
	private bool InAbyssFlowInternal;

	// Token: 0x04005AA6 RID: 23206
	public int CurrentSelectEntranceId;

	// Token: 0x04005AA7 RID: 23207
	public int CurrentSelectChallengeId;

	// Token: 0x04005AA8 RID: 23208
	private int CurrentLayer;

	// Token: 0x04005AA9 RID: 23209
	private int MaxLayer;

	// Token: 0x04005AAA RID: 23210
	private int GainBoxCount;

	// Token: 0x04005AAB RID: 23211
	private int MaxBoxCount;

	// Token: 0x04005AAC RID: 23212
	private int CurrentRoomId;

	// Token: 0x04005AAD RID: 23213
	private int CurrentChallengeId = 1;

	// Token: 0x04005AAE RID: 23214
	private int CurrentRouteId;

	// Token: 0x04005AAF RID: 23215
	[Nullable(2)]
	private AbyssRankChallengeInfo ChallengeRankInfo;

	// Token: 0x04005AB0 RID: 23216
	[Nullable(2)]
	private AbyssFormationInfo CurrentFormationSelectInfo;

	// Token: 0x04005AB1 RID: 23217
	[Nullable(2)]
	private AbyssChallengeResultData CurrentAbyssResultInfo;

	// Token: 0x04005AB2 RID: 23218
	public Dictionary<int, Dictionary<int, int>> FormationIndex2DangoIdMapCache = new Dictionary<int, Dictionary<int, int>>();

	// Token: 0x04005AB3 RID: 23219
	[Nullable(2)]
	private Dictionary<int, int> RoleSelectDangoMap;

	// Token: 0x04005AB4 RID: 23220
	private int MaxScore;

	// Token: 0x04005AB5 RID: 23221
	private int CurrentScore;

	// Token: 0x04005AB6 RID: 23222
	private readonly Dictionary<int, Dictionary<int, AbyssDangoOwnerData>> DangoOwnerMap = new Dictionary<int, Dictionary<int, AbyssDangoOwnerData>>();

	// Token: 0x04005AB7 RID: 23223
	private bool ChallengeFinish;

	// Token: 0x04005AB8 RID: 23224
	private DangoAbyssDefine.IAbyssLikeRecord[] AbyssLikedRecord = Array.Empty<DangoAbyssDefine.IAbyssLikeRecord>();

	// Token: 0x04005AB9 RID: 23225
	[Nullable(2)]
	private static DangoAbyssModel _Instance;
}
