using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Functional;
using CSharpScript.Game.Module.RecallQuest.Model;
using CSharpScript.Game.Module.SkillButtonUi;
using CSharpScript.Game.NewWorld.Character.Common.Component.Explore;
using CSharpScript.Game.Ui;
using Google.Protobuf;
using Google.Protobuf.Collections;

// Token: 0x02001E9D RID: 7837
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class RouletteController : UiControllerBase
{
	// Token: 0x060135A6 RID: 79270 RVA: 0x005A5F03 File Offset: 0x005A4103
	protected override bool OnInit()
	{
		InputManager.Instance.RegisterOpenViewFunc(EUiViewName.PhantomExploreSetView, new Action(this.OpenView));
		return true;
	}

	// Token: 0x060135A7 RID: 79271 RVA: 0x005A5F24 File Offset: 0x005A4124
	private void OpenView()
	{
		RouletteController.Instance.OpenAssemblyView(ERouletteType.Explore, null, null, null, false);
	}

	// Token: 0x060135A8 RID: 79272 RVA: 0x005A5F5C File Offset: 0x005A415C
	protected override void OnRegisterNetEvent()
	{
		Net.Instance.Register(ENotifyMessageId.VisionExploreSkillNotify, delegate(IMessage msg, Net.CallbackStatus status)
		{
			VisionExploreSkillNotify visionExploreSkillNotify = (VisionExploreSkillNotify)msg;
			if (visionExploreSkillNotify == null)
			{
				return;
			}
			Log.Instance.Info(ELogModule.Phantom, ELogAuthor.YYZ, "推送探索技能设置更新信息", default(ReadOnlySpan<ValueTuple<string, object>>));
			int exploreSkill = visionExploreSkillNotify.ExploreSkill;
			RecallQuestModel instance = RecallQuestModel.Instance;
			if (instance.IsInRecallInstance())
			{
				instance.RecallExploreSkillRevision++;
				if (!GameModeModel.Instance.WorldDone)
				{
					instance.CacheRecallExploreSkillId = new int?(exploreSkill);
					Log instance2 = Log.Instance;
					ELogModule module = ELogModule.QuestRecall;
					ELogAuthor author = ELogAuthor.YZY;
					string message = "缓存回顾探索技能，等待替换轮盘初始化";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("SkillId", exploreSkill);
					instance2.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
					return;
				}
			}
			CharacterExploreModel.Instance.SetDefaultExploreSkillId(exploreSkill);
			RouletteModel.Instance.CurrentExploreSkillId = exploreSkill;
		});
		Net.Instance.Register(ENotifyMessageId.ExploreSkillRouletteUpdateNotify, delegate(IMessage msg, Net.CallbackStatus status)
		{
			ExploreSkillRouletteUpdateNotify exploreSkillRouletteUpdateNotify = (ExploreSkillRouletteUpdateNotify)msg;
			if (exploreSkillRouletteUpdateNotify == null)
			{
				return;
			}
			Log.Instance.Info(ELogModule.Phantom, ELogAuthor.YYZ, "推送当前轮盘保存的数据", default(ReadOnlySpan<ValueTuple<string, object>>));
			RouletteModel.Instance.UpdateRouletteData(exploreSkillRouletteUpdateNotify.RouletteInfo);
		});
		Net.Instance.Register(ENotifyMessageId.ExploreToolUpdateNotify, delegate(IMessage msg, Net.CallbackStatus status)
		{
			ExploreToolUpdateNotify exploreToolUpdateNotify = (ExploreToolUpdateNotify)msg;
			if (exploreToolUpdateNotify == null)
			{
				return;
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Phantom;
			ELogAuthor author = ELogAuthor.YYZ;
			string message = "推送探索技能解锁";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Id", exploreToolUpdateNotify.SkillId);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			RouletteModel.Instance.UnlockExploreSkill(exploreToolUpdateNotify.SkillId, true);
		});
		Net.Instance.Register(ENotifyMessageId.ExploreToolAllNotify, delegate(IMessage msg, Net.CallbackStatus status)
		{
			ExploreToolAllNotify exploreToolAllNotify = (ExploreToolAllNotify)msg;
			if (exploreToolAllNotify == null)
			{
				return;
			}
			Log.Instance.Info(ELogModule.Phantom, ELogAuthor.YYZ, "推送所有已解锁的探索技能及当前装备的探索技能", default(ReadOnlySpan<ValueTuple<string, object>>));
			RouletteModel.Instance.CreateAllUnlockExploreSkill(exploreToolAllNotify.SkillList);
			RouletteModel.Instance.CurrentExploreSkillId = exploreToolAllNotify.ExploreSkill;
			RepeatedField<int> newUnlock = exploreToolAllNotify.NewUnlock;
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Phantom;
			ELogAuthor author = ELogAuthor.YYZ;
			string message = "新解锁探索技能";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("NewUnlock", newUnlock);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			foreach (int id in newUnlock)
			{
				RouletteModel.Instance.UnlockExploreSkill(id, true);
			}
		});
	}

	// Token: 0x060135A9 RID: 79273 RVA: 0x005A6028 File Offset: 0x005A4228
	protected override void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.VisionExploreSkillNotify);
		Net.Instance.UnRegister(ENotifyMessageId.ExploreSkillRouletteUpdateNotify);
		Net.Instance.UnRegister(ENotifyMessageId.ExploreToolUpdateNotify);
		Net.Instance.UnRegister(ENotifyMessageId.ExploreToolAllNotify);
	}

	// Token: 0x060135AA RID: 79274 RVA: 0x005A6078 File Offset: 0x005A4278
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add<int, int, bool>(EEventName.CharUseSkill, new Action<int, int, bool>(this.OnCharUseExploreSkill));
		EventSystem.Instance.Add<int, int>(EEventName.OnItemUse, new Action<int, int>(this.OnRefreshExploreSkillButton));
		EventSystem.Instance.Add<int, long, int>(EEventName.OnUseBuffItem, new Action<int, long, int>(this.OnUseBuffItem));
		EventSystem.Instance.Add<ERouletteExploreId, int>(EEventName.OnMapExploreToolPlaceNumUpdated, new Action<ERouletteExploreId, int>(this.OnMapExploreToolPlaceNumUpdated));
		EventSystem.Instance.Add(EEventName.OnRefreshTempFishingPointNum, new Action(this.OnRefreshTempFishingPointNum));
		EventSystem.Instance.Add<int, int>(EEventName.OnCommonItemCountAnyChange, new Action<int, int>(this.OnCommonItemCountAnyChange));
	}

	// Token: 0x060135AB RID: 79275 RVA: 0x005A612C File Offset: 0x005A432C
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove<int, int, bool>(EEventName.CharUseSkill, new Action<int, int, bool>(this.OnCharUseExploreSkill));
		EventSystem.Instance.Remove(EEventName.OnItemUse, new <>f__AnonymousDelegate8<int, int>(this.OnRefreshExploreSkillButton));
		EventSystem.Instance.Remove(EEventName.OnUseBuffItem, new Action<int, long, int>(this.OnUseBuffItem));
		EventSystem.Instance.Remove(EEventName.OnMapExploreToolPlaceNumUpdated, new Action<ERouletteExploreId, int>(this.OnMapExploreToolPlaceNumUpdated));
		EventSystem.Instance.Remove(EEventName.OnRefreshTempFishingPointNum, new Action(this.OnRefreshTempFishingPointNum));
		EventSystem.Instance.Remove(EEventName.OnCommonItemCountAnyChange, new Action<int, int>(this.OnCommonItemCountAnyChange));
	}

	// Token: 0x060135AC RID: 79276 RVA: 0x005A61E0 File Offset: 0x005A43E0
	public void ApplyCachedRecallExploreSkill()
	{
		RecallQuestModel instance = RecallQuestModel.Instance;
		int? cacheRecallExploreSkillId = instance.CacheRecallExploreSkillId;
		if (cacheRecallExploreSkillId == null)
		{
			return;
		}
		CharacterExploreModel.Instance.SetDefaultExploreSkillId(cacheRecallExploreSkillId.Value);
		RouletteModel.Instance.CurrentExploreSkillId = cacheRecallExploreSkillId.Value;
		instance.CacheRecallExploreSkillId = null;
		Log instance2 = Log.Instance;
		ELogModule module = ELogModule.QuestRecall;
		ELogAuthor author = ELogAuthor.YZY;
		string message = "替换轮盘初始化完成，应用回顾探索技能";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("SkillId", cacheRecallExploreSkillId.Value);
		instance2.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
	}

	// Token: 0x060135AD RID: 79277 RVA: 0x005A6264 File Offset: 0x005A4464
	[NullableContext(2)]
	public unsafe void ExploreSkillSetRequest(int skillId, Action<bool> callBack = null, bool autoChange = false)
	{
		RecallQuestModel recallModel = RecallQuestModel.Instance;
		if (recallModel.CacheRecallExploreSkillId != null)
		{
			Action<bool> callBack2 = callBack;
			if (callBack2 == null)
			{
				return;
			}
			callBack2(false);
			return;
		}
		else
		{
			int recallSkillRevision = recallModel.RecallExploreSkillRevision;
			if (!RouletteController.Instance.CheckCanExploreSkillEquip(skillId))
			{
				Action<bool> callBack3 = callBack;
				if (callBack3 == null)
				{
					return;
				}
				callBack3(false);
				return;
			}
			else
			{
				RouletteListDataBase currentRouletteListData = RouletteModel.Instance.GetCurrentExploreRouletteListData();
				if (!currentRouletteListData.IsExploreSkillIdAllowEquip(skillId))
				{
					Action<bool> callBack4 = callBack;
					if (callBack4 == null)
					{
						return;
					}
					callBack4(false);
					return;
				}
				else
				{
					List<int> onSettingList = RouletteModel.Instance.OnSettingExploreSkillIdList;
					int? num = (onSettingList.Count > 0) ? new int?(onSettingList[onSettingList.Count - 1]) : null;
					if (num == null && RouletteModel.Instance.CurrentExploreSkillId == skillId)
					{
						Action<bool> callBack5 = callBack;
						if (callBack5 == null)
						{
							return;
						}
						callBack5(false);
						return;
					}
					else
					{
						int? num2 = num;
						if (!(num2.GetValueOrDefault() == skillId & num2 != null))
						{
							RouletteModel.Instance.OnSettingExploreSkillIdList.Add(skillId);
							VisionExploreSkillSetRequest visionExploreSkillSetRequest = VisionExploreSkillSetRequest.Create();
							visionExploreSkillSetRequest.SkillId = skillId;
							visionExploreSkillSetRequest.IsAutoChange = autoChange;
							visionExploreSkillSetRequest.RouletteType = RouletteDefine.rouletteTypeDefine[currentRouletteListData.RouletteType];
							Log instance = Log.Instance;
							ELogModule module = ELogModule.Phantom;
							ELogAuthor author = ELogAuthor.YYZ;
							string message = "请求设置探索技能";
							<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
							*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("skillId", skillId);
							*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("RouletteType", currentRouletteListData.RouletteType);
							instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
							Net.Instance.Call(ERequestMessageId.VisionExploreSkillSetRequest, visionExploreSkillSetRequest, delegate(IMessage msg, Net.CallbackStatus _)
							{
								VisionExploreSkillSetResponse visionExploreSkillSetResponse = (VisionExploreSkillSetResponse)msg;
								if (onSettingList.Count > 0)
								{
									onSettingList.RemoveAt(0);
								}
								if (recallSkillRevision != recallModel.RecallExploreSkillRevision)
								{
									Action<bool> callBack7 = callBack;
									if (callBack7 == null)
									{
										return;
									}
									callBack7(false);
									return;
								}
								else if (visionExploreSkillSetResponse == null)
								{
									Action<bool> callBack8 = callBack;
									if (callBack8 == null)
									{
										return;
									}
									callBack8(false);
									return;
								}
								else
								{
									if (visionExploreSkillSetResponse.ErrCode != Aki.Protocol.ErrorCode.Success)
									{
										Action<bool> callBack9 = callBack;
										if (callBack9 != null)
										{
											callBack9(false);
										}
										ErrorCodeController.Instance.OpenErrorCodeTipView(visionExploreSkillSetResponse.ErrCode, 18378, null, true, true);
										return;
									}
									RouletteModel.Instance.CurrentExploreSkillId = visionExploreSkillSetResponse.SkillId;
									currentRouletteListData.EquipExploreSkillIdServer = visionExploreSkillSetResponse.SkillId;
									Action<bool> callBack10 = callBack;
									if (callBack10 == null)
									{
										return;
									}
									callBack10(true);
									return;
								}
							}, 0);
							return;
						}
						Action<bool> callBack6 = callBack;
						if (callBack6 == null)
						{
							return;
						}
						callBack6(false);
						return;
					}
				}
			}
		}
	}

	// Token: 0x060135AE RID: 79278 RVA: 0x005A6470 File Offset: 0x005A4670
	public void SaveRouletteDataRequest(IRouletteListSaveData rouletteListData, [Nullable(2)] Action<bool> callback = null)
	{
		ExploreSkillRouletteSetRequest exploreSkillRouletteSetRequest = ExploreSkillRouletteSetRequest.Create();
		ExploreSkillRoulette exploreSkillRoulette = ExploreSkillRoulette.Create();
		exploreSkillRoulette.SkillIds.AddRange(rouletteListData.RouletteIdList);
		exploreSkillRoulette.ExtraItemId = rouletteListData.ExtraItemId;
		exploreSkillRoulette.ExploreSkill = rouletteListData.EquipExploreSkillId;
		exploreSkillRouletteSetRequest.SkillRoulette = exploreSkillRoulette;
		exploreSkillRouletteSetRequest.RouletteType = RouletteDefine.rouletteTypeDefine[rouletteListData.RouletteType];
		Net.Instance.Call(ERequestMessageId.ExploreSkillRouletteSetRequest, exploreSkillRouletteSetRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			ExploreSkillRouletteSetResponse exploreSkillRouletteSetResponse = (ExploreSkillRouletteSetResponse)msg;
			if (exploreSkillRouletteSetResponse == null)
			{
				Action<bool> callback2 = callback;
				if (callback2 == null)
				{
					return;
				}
				callback2(false);
				return;
			}
			else if (exploreSkillRouletteSetResponse.ErrCode == Aki.Protocol.ErrorCode.Success)
			{
				if (exploreSkillRouletteSetResponse.SkillRoulette != null)
				{
					RouletteModel.Instance.UpdateRouletteDataByType((int)exploreSkillRouletteSetResponse.RouletteType, exploreSkillRouletteSetResponse.SkillRoulette);
				}
				Action<bool> callback3 = callback;
				if (callback3 == null)
				{
					return;
				}
				callback3(true);
				return;
			}
			else
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(exploreSkillRouletteSetResponse.ErrCode, 27182, null, true, true);
				Action<bool> callback4 = callback;
				if (callback4 == null)
				{
					return;
				}
				callback4(false);
				return;
			}
		}, 0);
	}

	// Token: 0x060135AF RID: 79279 RVA: 0x005A64FC File Offset: 0x005A46FC
	[NullableContext(2)]
	public void SaveExploreRouletteExtraItemId(int equipItemId, Action<bool> callback = null)
	{
		RouletteListDataBase rouletteListDataBase;
		if (!RouletteModel.Instance.RouletteListDataMap.TryGetValue(ERouletteType.Explore, out rouletteListDataBase))
		{
			return;
		}
		RouletteListDataExplore rouletteListDataExplore = rouletteListDataBase as RouletteListDataExplore;
		if (rouletteListDataExplore == null)
		{
			return;
		}
		rouletteListDataExplore.GetExtraItemIdProxy().SetExtraItemId(equipItemId, callback);
	}

	// Token: 0x060135B0 RID: 79280 RVA: 0x005A6536 File Offset: 0x005A4736
	public bool TrySetExtraItemIdForReplace(int equipItemId)
	{
		RouletteListDataExplore rouletteListDataExplore = RouletteModel.Instance.RouletteListDataMap[ERouletteType.Explore] as RouletteListDataExplore;
		return rouletteListDataExplore != null && rouletteListDataExplore.SetExtraItemIdReplace(equipItemId);
	}

	// Token: 0x060135B1 RID: 79281 RVA: 0x005A655C File Offset: 0x005A475C
	public void FunctionOpenRequest(int funcId)
	{
		if (funcId == 0)
		{
			return;
		}
		FuncMenuWheel? funcDataByFuncId = RouletteModel.Instance.GetFuncDataByFuncId(funcId);
		if (funcDataByFuncId == null)
		{
			return;
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Phantom;
		ELogAuthor author = ELogAuthor.YYZ;
		string message = "轮盘请求打开界面";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Function Id", funcDataByFuncId.Value.UnlockCondition);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		if (funcDataByFuncId.Value.UnlockCondition > 0)
		{
			FunctionController.Instance.OpenFunctionRelateView((EFunctionType)funcDataByFuncId.Value.UnlockCondition);
			return;
		}
		RouletteFunctionOpenController.OpenRelateView((ERouletteFuncId)funcDataByFuncId.Value.FuncId);
	}

	// Token: 0x060135B2 RID: 79282 RVA: 0x005A65FD File Offset: 0x005A47FD
	[NullableContext(2)]
	public void EquipItemSetRequest(int itemId, Action<bool> callBack = null, EExploreSkillLayer layer = EExploreSkillLayer.Roulette)
	{
		if (RouletteModel.Instance.IsEquipItemSelectOn)
		{
			RouletteController.RefreshExploreSkillButton();
			return;
		}
		CharacterExploreModel.Instance.SetExploreSkillId(3001, layer, "EquipItemSetRequest");
		RouletteController.Instance.ExploreSkillSetRequest(3001, callBack, false);
	}

	// Token: 0x060135B3 RID: 79283 RVA: 0x005A6637 File Offset: 0x005A4837
	private void OnMapExploreToolPlaceNumUpdated(ERouletteExploreId phantomSkillId, int placeNum)
	{
		if (RouletteModel.Instance.CurrentExploreSkillId == (int)phantomSkillId)
		{
			RouletteController.RefreshExploreSkillButton();
		}
	}

	// Token: 0x060135B4 RID: 79284 RVA: 0x005A664B File Offset: 0x005A484B
	private void OnRefreshTempFishingPointNum()
	{
		if (RouletteModel.Instance.CurrentExploreSkillId == 1018)
		{
			RouletteController.RefreshExploreSkillButton();
		}
	}

	// Token: 0x060135B5 RID: 79285 RVA: 0x005A6664 File Offset: 0x005A4864
	public static void RefreshExploreSkillButton()
	{
		EventSystem.Instance.Emit(EEventName.OnChangeSelectedExploreId);
		EventSystem.Instance.Emit<ESkillButtonType>(EEventName.OnSkillButtonSkillIdRefresh, ESkillButtonType.幻象1);
		Log.Instance.Info(ELogModule.Phantom, ELogAuthor.YYZ, "刷新探索技能按钮表现", default(ReadOnlySpan<ValueTuple<string, object>>));
	}

	// Token: 0x060135B6 RID: 79286 RVA: 0x005A66B0 File Offset: 0x005A48B0
	private void OnCommonItemCountAnyChange(int configId, int count)
	{
		RouletteController.Instance.OnRefreshExploreSkillButton(configId, 0);
		int currentExploreSkillId = RouletteModel.Instance.CurrentExploreSkillId;
		ExploreTools exploreTools;
		if (!RouletteModel.Instance.UnlockExploreSkillDataMap.TryGetValue(currentExploreSkillId, out exploreTools))
		{
			return;
		}
		Dictionary<int, int> dictionary = exploreTools.Cost();
		if (dictionary != null && dictionary.Count > 0)
		{
			using (Dictionary<int, int>.KeyCollection.Enumerator enumerator = dictionary.Keys.GetEnumerator())
			{
				if (enumerator.MoveNext() && enumerator.Current == configId)
				{
					RouletteController.RefreshExploreSkillButton();
				}
			}
		}
	}

	// Token: 0x060135B7 RID: 79287 RVA: 0x005A6744 File Offset: 0x005A4944
	private void OnUseBuffItem(int configId, long l, int arg3)
	{
		this.OnRefreshExploreSkillButton(configId, 0);
	}

	// Token: 0x060135B8 RID: 79288 RVA: 0x005A6750 File Offset: 0x005A4950
	private void OnRefreshExploreSkillButton(int configId, int _ = 0)
	{
		int currentEquipItemId = RouletteModel.Instance.CurrentEquipItemId;
		if (configId != currentEquipItemId)
		{
			return;
		}
		if (InventoryModel.Instance.GetItemCountByConfigId(configId, 0) == 0)
		{
			RouletteController.Instance.SaveExploreRouletteExtraItemId(0, null);
			return;
		}
		RouletteController.RefreshExploreSkillButton();
	}

	// Token: 0x060135B9 RID: 79289 RVA: 0x005A678D File Offset: 0x005A498D
	private void OnCharUseExploreSkill(int entityId, int skillId, bool isAutonomousProxy)
	{
		RouletteExploreSkillController.Instance.UseExploreSkillId(entityId, skillId);
	}

	// Token: 0x060135BA RID: 79290 RVA: 0x005A679C File Offset: 0x005A499C
	public void OnUseEquipItem()
	{
		int currentEquipItemId = RouletteModel.Instance.CurrentEquipItemId;
		if (!RouletteModel.Instance.IsEquipItemSelectOn)
		{
			return;
		}
		if (!SpecialItemController.Instance.IsSpecialItem(currentEquipItemId))
		{
			if (BuffItemConfig.Instance.IsBuffItem(currentEquipItemId))
			{
				SceneTeamItem getCurrentTeamItem = SceneTeamModel.Instance.GetCurrentTeamItem;
				if (getCurrentTeamItem == null)
				{
					return;
				}
				ItemUseLogic.TryUseBuffItem(currentEquipItemId, 1, true, getCurrentTeamItem.GetConfigId);
			}
			else
			{
				InventoryController.Instance.TryUseItem(currentEquipItemId, 1);
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Phantom;
			ELogAuthor author = ELogAuthor.YYZ;
			string message = "请求使用普通道具";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("道具Id", currentEquipItemId);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			RouletteModel.Instance.SendExploreToolItemUseLogData(currentEquipItemId);
			return;
		}
		SpecialItem? config = SpecialItemConfig.Instance.GetConfig(currentEquipItemId);
		if (config == null)
		{
			return;
		}
		if (GameModeController.Instance.IsInInstance() && !config.Value.UseInstance)
		{
			ScrollingTipsController.Instance.ShowTipsById("CanNotUseInstance", Array.Empty<object>());
			return;
		}
		InventoryController.Instance.RequestItemUse(currentEquipItemId, 1);
		Log instance2 = Log.Instance;
		ELogModule module2 = ELogModule.Phantom;
		ELogAuthor author2 = ELogAuthor.YYZ;
		string message2 = "请求使用特殊道具";
		ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("道具Id", currentEquipItemId);
		instance2.Info(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
		RouletteModel.Instance.SendExploreToolItemUseLogData(currentEquipItemId);
	}

	// Token: 0x060135BB RID: 79291 RVA: 0x005A68D4 File Offset: 0x005A4AD4
	public void OpenEmptyTips()
	{
		ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.ExploreSkillEmptyEquipItemTips);
		confirmBoxDataNew.FunctionMap.Add(2, delegate
		{
			RouletteController.Instance.OpenAssemblyView(ERouletteType.Explore, new int?(7), new int?(3001), null, false);
		});
		ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
	}

	// Token: 0x060135BC RID: 79292 RVA: 0x005A6924 File Offset: 0x005A4B24
	protected override void OnAddOpenViewCheckFunction()
	{
		UiManager.Instance.AddOpenViewCheckFunction(EUiViewName.PhantomExploreView, new Func<EUiViewName, object, bool>(this.CanOpenView), "RouletteController.CanOpenView");
		UiManager.Instance.AddOpenViewCheckFunction(EUiViewName.PhantomExploreSetView, new Func<EUiViewName, object, bool>(this.CanOpenSetView), "RouletteController.CanOpenSetView");
	}

	// Token: 0x060135BD RID: 79293 RVA: 0x005A6971 File Offset: 0x005A4B71
	protected override void OnRemoveOpenViewCheckFunction()
	{
		UiManager.Instance.RemoveOpenViewCheckFunction(EUiViewName.PhantomExploreView, new Func<EUiViewName, object, bool>(this.CanOpenView));
		UiManager.Instance.RemoveOpenViewCheckFunction(EUiViewName.PhantomExploreSetView, new Func<EUiViewName, object, bool>(this.CanOpenSetView));
	}

	// Token: 0x060135BE RID: 79294 RVA: 0x005A69AC File Offset: 0x005A4BAC
	private bool CanOpenView(EUiViewName viewName, object param)
	{
		EntityHandle getCurrentEntity = SceneTeamModel.Instance.GetCurrentEntity;
		if (getCurrentEntity == null || getCurrentEntity.Entity == null)
		{
			return false;
		}
		RouletteMainViewProxyBase rouletteMainViewProxyBase = param as RouletteMainViewProxyBase;
		return rouletteMainViewProxyBase != null && rouletteMainViewProxyBase.CanOpenView();
	}

	// Token: 0x060135BF RID: 79295 RVA: 0x005A69E4 File Offset: 0x005A4BE4
	private bool CanOpenSetView(EUiViewName viewName, object param)
	{
		EntityHandle getCurrentEntity = SceneTeamModel.Instance.GetCurrentEntity;
		if (getCurrentEntity == null || getCurrentEntity.Entity == null)
		{
			return false;
		}
		RouletteAssemblyViewProxy rouletteAssemblyViewProxy = param as RouletteAssemblyViewProxy;
		return rouletteAssemblyViewProxy != null && rouletteAssemblyViewProxy.CanOpenView();
	}

	// Token: 0x060135C0 RID: 79296 RVA: 0x005A6A1A File Offset: 0x005A4C1A
	public RouletteMainViewProxyBase GetCurrentRouletteMainViewProxy()
	{
		return RouletteModel.Instance.GetCurrentExploreRouletteListData().GetRouletteMainViewProxy();
	}

	// Token: 0x060135C1 RID: 79297 RVA: 0x005A6A2B File Offset: 0x005A4C2B
	public void OpenRouletteMainView(RouletteMainViewProxyBase viewProxy)
	{
		UiManager.Instance.OpenView(EUiViewName.PhantomExploreView, viewProxy, null);
	}

	// Token: 0x060135C2 RID: 79298 RVA: 0x005A6A40 File Offset: 0x005A4C40
	public bool OpenAssemblyView(ERouletteType type = ERouletteType.Explore, int? selectIndex = null, int? endSwitchSkillId = null, int? selectGridId = null, bool locateEquippableSpecialItem = false)
	{
		if (UiManager.Instance.IsViewOpen(EUiViewName.PhantomExploreSetView))
		{
			return false;
		}
		RouletteAssemblyViewProxy rouletteAssemblyViewProxy = new RouletteAssemblyViewProxy();
		RouletteAssemblyViewProxy rouletteAssemblyViewProxy2 = rouletteAssemblyViewProxy;
		RouletteAssemblyOpenParam rouletteAssemblyOpenParam = new RouletteAssemblyOpenParam();
		rouletteAssemblyOpenParam.RouletteType = new ERouletteType?(type);
		rouletteAssemblyOpenParam.SelectGridId = selectGridId;
		rouletteAssemblyOpenParam.SelectGridIndex = selectIndex;
		int? num = endSwitchSkillId;
		rouletteAssemblyOpenParam.EndSwitchSkillId = ((num != null) ? new ERouletteExploreId?((ERouletteExploreId)num.GetValueOrDefault()) : null);
		rouletteAssemblyOpenParam.LocateEquippableSpecialItem = new bool?(locateEquippableSpecialItem);
		rouletteAssemblyViewProxy2.OpenParam = rouletteAssemblyOpenParam;
		UiManager.Instance.OpenView(EUiViewName.PhantomExploreSetView, rouletteAssemblyViewProxy, null);
		return false;
	}

	// Token: 0x060135C3 RID: 79299 RVA: 0x005A6AD4 File Offset: 0x005A4CD4
	public bool CheckCanExploreSkillEquip(int exploreSkillId)
	{
		ExploreTools? exploreConfigById = RouletteConfig.Instance.GetExploreConfigById(exploreSkillId);
		return exploreConfigById != null && (exploreSkillId != 3001 || RouletteModel.Instance.CurrentEquipItemId != 0) && exploreConfigById.Value.CanEquip;
	}

	// Token: 0x17001D8B RID: 7563
	// (get) Token: 0x060135C4 RID: 79300 RVA: 0x005A6B1D File Offset: 0x005A4D1D
	public static RouletteController Instance
	{
		get
		{
			return RouletteController._Instance;
		}
	}

	// Token: 0x060135C5 RID: 79301 RVA: 0x005A6B24 File Offset: 0x005A4D24
	public static RouletteController GetOrCreateInstance()
	{
		if (RouletteController._Instance == null)
		{
			RouletteController.CreateInstance();
		}
		return RouletteController._Instance;
	}

	// Token: 0x060135C6 RID: 79302 RVA: 0x005A6B38 File Offset: 0x005A4D38
	public static bool CreateInstance()
	{
		if (RouletteController._Instance != null)
		{
			return true;
		}
		RouletteController._Instance = new RouletteController();
		return true;
	}

	// Token: 0x060135C7 RID: 79303 RVA: 0x005A6B4E File Offset: 0x005A4D4E
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060135C8 RID: 79304 RVA: 0x005A6B50 File Offset: 0x005A4D50
	public static void ResetStaticDefaultValue()
	{
		RouletteController._Instance = null;
	}

	// Token: 0x060135C9 RID: 79305 RVA: 0x005A6B58 File Offset: 0x005A4D58
	static RouletteController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(RouletteController.CreateStaticDefaultValue), new Action(RouletteController.ResetStaticDefaultValue));
	}

	// Token: 0x0400A5C0 RID: 42432
	[Nullable(2)]
	private static RouletteController _Instance;
}
