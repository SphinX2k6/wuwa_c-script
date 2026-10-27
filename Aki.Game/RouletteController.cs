using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Functional;
using CSharpScript.Game.Module.SkillButtonUi;
using CSharpScript.Game.NewWorld.Character.Common.Component.Explore;
using CSharpScript.Game.Ui;
using Google.Protobuf;
using Google.Protobuf.Collections;

// Token: 0x02002922 RID: 10530
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class RouletteController : UiControllerBase
{
	// Token: 0x06015BA2 RID: 88994 RVA: 0x0057AF87 File Offset: 0x00579187
	protected override bool OnInit()
	{
		InputManager.Instance.RegisterOpenViewFunc(EUiViewName.PhantomExploreSetView, new Action(this.OpenView));
		return true;
	}

	// Token: 0x06015BA3 RID: 88995 RVA: 0x0057AFA8 File Offset: 0x005791A8
	private void OpenView()
	{
		RouletteController.Instance.OpenAssemblyView(ERouletteType.Explore, null, null, null, false);
	}

	// Token: 0x06015BA4 RID: 88996 RVA: 0x0057AFE0 File Offset: 0x005791E0
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
			RouletteModel.Instance.UpdateRouletteData(exploreSkillRouletteUpdateNotify.RouletteInfo.ToList<ExploreSkillRoulette>());
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
			RouletteModel.Instance.CreateAllUnlockExploreSkill(exploreToolAllNotify.SkillList.ToList<int>());
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

	// Token: 0x06015BA5 RID: 88997 RVA: 0x0057B0AC File Offset: 0x005792AC
	protected override void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.VisionExploreSkillNotify);
		Net.Instance.UnRegister(ENotifyMessageId.ExploreSkillRouletteUpdateNotify);
		Net.Instance.UnRegister(ENotifyMessageId.ExploreToolUpdateNotify);
		Net.Instance.UnRegister(ENotifyMessageId.ExploreToolAllNotify);
	}

	// Token: 0x06015BA6 RID: 88998 RVA: 0x0057B0FC File Offset: 0x005792FC
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add<int, int, bool>(EEventName.CharUseSkill, new Action<int, int, bool>(this.OnCharUseExploreSkill));
		EventSystem.Instance.Add<int, int>(EEventName.OnItemUse, new Action<int, int>(this.OnRefreshExploreSkillButton));
		EventSystem.Instance.Add<int, long, int>(EEventName.OnUseBuffItem, new Action<int, long, int>(this.OnUseBuffItem));
		EventSystem.Instance.Add<ERouletteExploreId, int>(EEventName.OnMapExploreToolPlaceNumUpdated, new Action<ERouletteExploreId, int>(this.OnMapExploreToolPlaceNumUpdated));
		EventSystem.Instance.Add(EEventName.OnRefreshTempFishingPointNum, new Action(this.OnRefreshTempFishingPointNum));
		EventSystem.Instance.Add<int, int>(EEventName.OnCommonItemCountAnyChange, new Action<int, int>(this.OnCommonItemCountAnyChange));
	}

	// Token: 0x06015BA7 RID: 88999 RVA: 0x0057B1B0 File Offset: 0x005793B0
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove<int, int, bool>(EEventName.CharUseSkill, new Action<int, int, bool>(this.OnCharUseExploreSkill));
		EventSystem.Instance.Remove(EEventName.OnItemUse, new <>f__AnonymousDelegate8<int, int>(this.OnRefreshExploreSkillButton));
		EventSystem.Instance.Remove(EEventName.OnUseBuffItem, new Action<int, long, int>(this.OnUseBuffItem));
		EventSystem.Instance.Remove(EEventName.OnMapExploreToolPlaceNumUpdated, new Action<ERouletteExploreId, int>(this.OnMapExploreToolPlaceNumUpdated));
		EventSystem.Instance.Remove(EEventName.OnRefreshTempFishingPointNum, new Action(this.OnRefreshTempFishingPointNum));
		EventSystem.Instance.Remove(EEventName.OnCommonItemCountAnyChange, new Action<int, int>(this.OnCommonItemCountAnyChange));
	}

	// Token: 0x06015BA8 RID: 89000 RVA: 0x0057B264 File Offset: 0x00579464
	[NullableContext(2)]
	public unsafe void ExploreSkillSetRequest(int skillId, Action<bool> callBack = null, bool autoChange = false)
	{
		if (!RouletteController.Instance.CheckCanExploreSkillEquip(skillId))
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
			RouletteListDataBase currentRouletteListData = RouletteModel.Instance.GetCurrentExploreRouletteListData();
			if (!currentRouletteListData.IsExploreSkillIdAllowEquip(skillId))
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
				List<int> onSettingList = RouletteModel.Instance.OnSettingExploreSkillIdList;
				int? num = (onSettingList.Count > 0) ? new int?(onSettingList[onSettingList.Count - 1]) : null;
				if (num == null && RouletteModel.Instance.CurrentExploreSkillId == skillId)
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
							if (visionExploreSkillSetResponse == null)
							{
								Action<bool> callBack6 = callBack;
								if (callBack6 == null)
								{
									return;
								}
								callBack6(false);
								return;
							}
							else
							{
								if (visionExploreSkillSetResponse.ErrCode != Aki.Protocol.ErrorCode.Success)
								{
									Action<bool> callBack7 = callBack;
									if (callBack7 != null)
									{
										callBack7(false);
									}
									ErrorCodeController.Instance.OpenErrorCodeTipView(visionExploreSkillSetResponse.ErrCode, 18650, null, true, true);
									return;
								}
								RouletteModel.Instance.CurrentExploreSkillId = visionExploreSkillSetResponse.SkillId;
								currentRouletteListData.EquipExploreSkillIdServer = visionExploreSkillSetResponse.SkillId;
								Action<bool> callBack8 = callBack;
								if (callBack8 == null)
								{
									return;
								}
								callBack8(true);
								return;
							}
						}, 0);
						return;
					}
					Action<bool> callBack5 = callBack;
					if (callBack5 == null)
					{
						return;
					}
					callBack5(false);
					return;
				}
			}
		}
	}

	// Token: 0x06015BA9 RID: 89001 RVA: 0x0057B430 File Offset: 0x00579630
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
				ErrorCodeController.Instance.OpenErrorCodeTipView(exploreSkillRouletteSetResponse.ErrCode, 24039, null, true, true);
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

	// Token: 0x06015BAA RID: 89002 RVA: 0x0057B4BC File Offset: 0x005796BC
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

	// Token: 0x06015BAB RID: 89003 RVA: 0x0057B4F6 File Offset: 0x005796F6
	public bool TrySetExtraItemIdForReplace(int equipItemId)
	{
		RouletteListDataExplore rouletteListDataExplore = RouletteModel.Instance.RouletteListDataMap[ERouletteType.Explore] as RouletteListDataExplore;
		return rouletteListDataExplore != null && rouletteListDataExplore.SetExtraItemIdReplace(equipItemId);
	}

	// Token: 0x06015BAC RID: 89004 RVA: 0x0057B51C File Offset: 0x0057971C
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

	// Token: 0x06015BAD RID: 89005 RVA: 0x0057B5BD File Offset: 0x005797BD
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

	// Token: 0x06015BAE RID: 89006 RVA: 0x0057B5F7 File Offset: 0x005797F7
	private void OnMapExploreToolPlaceNumUpdated(ERouletteExploreId phantomSkillId, int placeNum)
	{
		if (RouletteModel.Instance.CurrentExploreSkillId == (int)phantomSkillId)
		{
			RouletteController.RefreshExploreSkillButton();
		}
	}

	// Token: 0x06015BAF RID: 89007 RVA: 0x0057B60B File Offset: 0x0057980B
	private void OnRefreshTempFishingPointNum()
	{
		if (RouletteModel.Instance.CurrentExploreSkillId == 1018)
		{
			RouletteController.RefreshExploreSkillButton();
		}
	}

	// Token: 0x06015BB0 RID: 89008 RVA: 0x0057B624 File Offset: 0x00579824
	public static void RefreshExploreSkillButton()
	{
		EventSystem.Instance.Emit(EEventName.OnChangeSelectedExploreId);
		EventSystem.Instance.Emit<ESkillButtonType>(EEventName.OnSkillButtonSkillIdRefresh, ESkillButtonType.幻象1);
		Log.Instance.Info(ELogModule.Phantom, ELogAuthor.YYZ, "刷新探索技能按钮表现", default(ReadOnlySpan<ValueTuple<string, object>>));
	}

	// Token: 0x06015BB1 RID: 89009 RVA: 0x0057B670 File Offset: 0x00579870
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

	// Token: 0x06015BB2 RID: 89010 RVA: 0x0057B704 File Offset: 0x00579904
	private void OnUseBuffItem(int configId, long l, int arg3)
	{
		this.OnRefreshExploreSkillButton(configId, 0);
	}

	// Token: 0x06015BB3 RID: 89011 RVA: 0x0057B710 File Offset: 0x00579910
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

	// Token: 0x06015BB4 RID: 89012 RVA: 0x0057B74D File Offset: 0x0057994D
	private void OnCharUseExploreSkill(int entityId, int skillId, bool isAutonomousProxy)
	{
		RouletteExploreSkillController.Instance.UseExploreSkillId(entityId, skillId);
	}

	// Token: 0x06015BB5 RID: 89013 RVA: 0x0057B75C File Offset: 0x0057995C
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

	// Token: 0x06015BB6 RID: 89014 RVA: 0x0057B894 File Offset: 0x00579A94
	public void OpenEmptyTips()
	{
		ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.ExploreSkillEmptyEquipItemTips);
		confirmBoxDataNew.FunctionMap.Add(2, delegate
		{
			RouletteController.Instance.OpenAssemblyView(ERouletteType.Explore, new int?(7), new int?(3001), null, false);
		});
		ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
	}

	// Token: 0x06015BB7 RID: 89015 RVA: 0x0057B8E4 File Offset: 0x00579AE4
	protected override void OnAddOpenViewCheckFunction()
	{
		UiManager.Instance.AddOpenViewCheckFunction(EUiViewName.PhantomExploreView, new Func<EUiViewName, object, bool>(this.CanOpenView), "RouletteController.CanOpenView");
		UiManager.Instance.AddOpenViewCheckFunction(EUiViewName.PhantomExploreSetView, new Func<EUiViewName, object, bool>(this.CanOpenSetView), "RouletteController.CanOpenSetView");
	}

	// Token: 0x06015BB8 RID: 89016 RVA: 0x0057B931 File Offset: 0x00579B31
	protected override void OnRemoveOpenViewCheckFunction()
	{
		UiManager.Instance.RemoveOpenViewCheckFunction(EUiViewName.PhantomExploreView, new Func<EUiViewName, object, bool>(this.CanOpenView));
		UiManager.Instance.RemoveOpenViewCheckFunction(EUiViewName.PhantomExploreSetView, new Func<EUiViewName, object, bool>(this.CanOpenSetView));
	}

	// Token: 0x06015BB9 RID: 89017 RVA: 0x0057B96C File Offset: 0x00579B6C
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

	// Token: 0x06015BBA RID: 89018 RVA: 0x0057B9A4 File Offset: 0x00579BA4
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

	// Token: 0x06015BBB RID: 89019 RVA: 0x0057B9DA File Offset: 0x00579BDA
	public RouletteMainViewProxyBase GetCurrentRouletteMainViewProxy()
	{
		return RouletteModel.Instance.GetCurrentExploreRouletteListData().GetRouletteMainViewProxy();
	}

	// Token: 0x06015BBC RID: 89020 RVA: 0x0057B9EB File Offset: 0x00579BEB
	public void OpenRouletteMainView(RouletteMainViewProxyBase viewProxy)
	{
		UiManager.Instance.OpenView(EUiViewName.PhantomExploreView, viewProxy, null);
	}

	// Token: 0x06015BBD RID: 89021 RVA: 0x0057BA00 File Offset: 0x00579C00
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

	// Token: 0x06015BBE RID: 89022 RVA: 0x0057BA94 File Offset: 0x00579C94
	public bool CheckCanExploreSkillEquip(int exploreSkillId)
	{
		ExploreTools? exploreConfigById = RouletteConfig.Instance.GetExploreConfigById(exploreSkillId);
		return exploreConfigById != null && (exploreSkillId != 3001 || RouletteModel.Instance.CurrentEquipItemId != 0) && exploreConfigById.Value.CanEquip;
	}

	// Token: 0x17001D31 RID: 7473
	// (get) Token: 0x06015BBF RID: 89023 RVA: 0x0057BADD File Offset: 0x00579CDD
	public static RouletteController Instance
	{
		get
		{
			return RouletteController._Instance;
		}
	}

	// Token: 0x06015BC0 RID: 89024 RVA: 0x0057BAE4 File Offset: 0x00579CE4
	public static RouletteController GetOrCreateInstance()
	{
		if (RouletteController._Instance == null)
		{
			RouletteController.CreateInstance();
		}
		return RouletteController._Instance;
	}

	// Token: 0x06015BC1 RID: 89025 RVA: 0x0057BAF8 File Offset: 0x00579CF8
	public static bool CreateInstance()
	{
		if (RouletteController._Instance != null)
		{
			return true;
		}
		RouletteController._Instance = new RouletteController();
		return true;
	}

	// Token: 0x06015BC2 RID: 89026 RVA: 0x0057BB0E File Offset: 0x00579D0E
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06015BC3 RID: 89027 RVA: 0x0057BB10 File Offset: 0x00579D10
	public static void ResetStaticDefaultValue()
	{
		RouletteController._Instance = null;
	}

	// Token: 0x06015BC4 RID: 89028 RVA: 0x0057BB18 File Offset: 0x00579D18
	static RouletteController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(RouletteController.CreateStaticDefaultValue), new Action(RouletteController.ResetStaticDefaultValue));
	}

	// Token: 0x0400A1D5 RID: 41429
	[Nullable(2)]
	private static RouletteController _Instance;
}
