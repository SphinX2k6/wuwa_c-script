using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf;
using UnrealEngine;

// Token: 0x02001135 RID: 4405
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class GachaController : UiControllerBase
{
	// Token: 0x0600AFD3 RID: 45011 RVA: 0x0033D438 File Offset: 0x0033B638
	protected override bool OnInit()
	{
		this.GachaRoleRecord = new HashSet<int>();
		InputManager.Instance.RegisterOpenViewFunc(EUiViewName.GachaMainView, new Action(this.OpenView));
		return true;
	}

	// Token: 0x0600AFD4 RID: 45012 RVA: 0x0033D461 File Offset: 0x0033B661
	private void OpenView()
	{
		this.OpenGachaMainView(true);
	}

	// Token: 0x0600AFD5 RID: 45013 RVA: 0x0033D46C File Offset: 0x0033B66C
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add<EFunctionType, bool>(EEventName.OnFunctionOpenSet, new Action<EFunctionType, bool>(this.OnFunctionOpenDataUpdate));
		EventSystem.Instance.Add<EFunctionType, bool>(EEventName.OnFunctionOpenUpdate, new Action<EFunctionType, bool>(this.OnFunctionOpenDataUpdate));
		EventSystem.Instance.Add(EEventName.CrossDay, new Action(this.RefreshGachaMainView));
		EventSystem.Instance.Add(EEventName.AfterCloseGachaScene, new Action(this.OnAfterCloseGachaScent));
		EventSystem.Instance.Add(EEventName.WorldDoneAndCloseLoading, new Action(this.OnWorldDone));
	}

	// Token: 0x0600AFD6 RID: 45014 RVA: 0x0033D508 File Offset: 0x0033B708
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.OnFunctionOpenSet, new Action<EFunctionType, bool>(this.OnFunctionOpenDataUpdate));
		EventSystem.Instance.Remove(EEventName.OnFunctionOpenUpdate, new Action<EFunctionType, bool>(this.OnFunctionOpenDataUpdate));
		EventSystem.Instance.Remove(EEventName.CrossDay, new Action(this.RefreshGachaMainView));
		EventSystem.Instance.Remove(EEventName.AfterCloseGachaScene, new Action(this.OnAfterCloseGachaScent));
		EventSystem.Instance.Remove(EEventName.WorldDoneAndCloseLoading, new Action(this.OnWorldDone));
	}

	// Token: 0x0600AFD7 RID: 45015 RVA: 0x0033D5A4 File Offset: 0x0033B7A4
	protected override void OnRegisterNetEvent()
	{
		Net.Instance.Register(ENotifyMessageId.GachaResultNotify, new Action<IMessage, Net.CallbackStatus>(this.OnGachaResultNotify));
		Net.Instance.Register(ENotifyMessageId.GachaNewNotify, new Action<IMessage, Net.CallbackStatus>(this.OnGachaNewNotify));
		Net.Instance.Register(ENotifyMessageId.GachaDiscountNotify, new Action<IMessage, Net.CallbackStatus>(this.OnGachaDiscountNotify));
	}

	// Token: 0x0600AFD8 RID: 45016 RVA: 0x0033D605 File Offset: 0x0033B805
	protected override void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.GachaResultNotify);
		Net.Instance.UnRegister(ENotifyMessageId.GachaNewNotify);
		Net.Instance.UnRegister(ENotifyMessageId.GachaDiscountNotify);
	}

	// Token: 0x0600AFD9 RID: 45017 RVA: 0x0033D637 File Offset: 0x0033B837
	private void OnWorldDone()
	{
		if (!FunctionModel.Instance.IsOpen(10009))
		{
			return;
		}
		if (!UiManager.Instance.IsViewOpen(EUiViewName.GachaMainView))
		{
			this.GachaInfoRequest(false, false);
		}
	}

	// Token: 0x0600AFDA RID: 45018 RVA: 0x0033D664 File Offset: 0x0033B864
	[NullableContext(2)]
	private void OnGachaNewNotify(IMessage msg, Net.CallbackStatus status)
	{
		if (!FunctionModel.Instance.IsOpen(10009))
		{
			return;
		}
		if (UiManager.Instance.IsViewOpen(EUiViewName.DrawMainView) || UiManager.Instance.IsViewOpen(EUiViewName.GachaScanView) || UiManager.Instance.IsViewOpen(EUiViewName.GachaResultView))
		{
			GachaModel.Instance.IsCacheShowNewNotify = true;
			return;
		}
		if (!UiManager.Instance.IsViewOpen(EUiViewName.GachaMainView))
		{
			this.GachaInfoRequest(false, false);
			return;
		}
		EventSystem.Instance.Emit(EEventName.GachaNewNotify);
	}

	// Token: 0x0600AFDB RID: 45019 RVA: 0x0033D6EC File Offset: 0x0033B8EC
	[NullableContext(2)]
	private void OnGachaResultNotify(IMessage msg, Net.CallbackStatus status)
	{
		GachaResultNotify gachaResultNotify = (GachaResultNotify)msg;
		List<global::GachaResult> list = new List<global::GachaResult>();
		foreach (Aki.Protocol.GachaResult gachaResult in gachaResultNotify.GachaResults)
		{
			list.Add(new global::GachaResult
			{
				Proto_GachaReward = gachaResult.GachaReward,
				Proto_BottomExtraReward = gachaResult.BottomExtraReward,
				Proto_TransformRewards = new List<GachaReward>(gachaResult.TransformRewards),
				Proto_ExtraRewards = new List<GachaReward>(gachaResult.ExtraRewards)
			});
		}
		if (UiManager.Instance.IsViewOpen(EUiViewName.DrawMainView) || UiManager.Instance.IsViewOpen(EUiViewName.GachaScanView))
		{
			IGachaViewOpenData resultViewData = new GachaViewOpenData
			{
				SkipOnLoadResourceFinish = false,
				ResultViewHideExtraReward = false,
				IsOnlyShowGold = false
			};
			GachaModel.Instance.CacheGachaInfo(new CommonShowRoleInfo
			{
				ResultViewData = resultViewData,
				GachaResult = list.ToArray()
			});
			return;
		}
		GachaModel.Instance.CurGachaResult = list.ToArray();
		UiManager.Instance.OpenView(EUiViewName.DrawMainView, null, null);
	}

	// Token: 0x0600AFDC RID: 45020 RVA: 0x0033D808 File Offset: 0x0033BA08
	[NullableContext(2)]
	private void OnGachaDiscountNotify(IMessage msg, Net.CallbackStatus status)
	{
		GachaDiscountNotify gachaDiscountNotify = (GachaDiscountNotify)msg;
		ProtoGachaInfo gachaInfo = GachaModel.Instance.GetGachaInfo(gachaDiscountNotify.GachaId);
		if (gachaInfo == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Gacha;
			ELogAuthor author = ELogAuthor.LPH;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(52, 1);
			defaultInterpolatedStringHandler.AppendLiteral("OnGachaDiscountNotify: GachaInfo not found, gachaId=");
			defaultInterpolatedStringHandler.AppendFormatted<int>(gachaDiscountNotify.GachaId);
			instance.Error(module, author, defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		GachaDiscountInfo[] array = new GachaDiscountInfo[gachaDiscountNotify.GachaDiscountInfos.Count];
		gachaDiscountNotify.GachaDiscountInfos.CopyTo(array, 0);
		List<GachaDiscountInfo> list = new List<GachaDiscountInfo>(gachaInfo.GachaDiscountInfos);
		GachaDiscountInfo[] array2 = array;
		for (int i = 0; i < array2.Length; i++)
		{
			GachaDiscountInfo next = array2[i];
			GachaDiscountInfo gachaDiscountInfo = list.Find((GachaDiscountInfo discount) => discount.Times == next.Times);
			if (gachaDiscountInfo != null)
			{
				gachaDiscountInfo.UsedTimes = next.UsedTimes;
				gachaDiscountInfo.LimitTimes = next.LimitTimes;
				gachaDiscountInfo.DiscountConsume = next.DiscountConsume;
			}
			else
			{
				list.Add(next);
			}
		}
		gachaInfo.GachaDiscountInfos = list.ToArray();
		EventSystem.Instance.Emit(EEventName.RefreshGachaMainView);
	}

	// Token: 0x0600AFDD RID: 45021 RVA: 0x0033D949 File Offset: 0x0033BB49
	private void OnFunctionOpenDataUpdate(EFunctionType functionType, bool isOpen)
	{
		if (functionType == EFunctionType.Gacha && isOpen)
		{
			GachaModel.Instance.InitGachaPoolOpenRecord();
			this.GachaInfoRequest(false, false);
		}
	}

	// Token: 0x0600AFDE RID: 45022 RVA: 0x0033D969 File Offset: 0x0033BB69
	private void RefreshGachaMainView()
	{
		if (!UiManager.Instance.IsViewOpen(EUiViewName.GachaMainView))
		{
			return;
		}
		this.GachaInfoRequest(false, false);
	}

	// Token: 0x0600AFDF RID: 45023 RVA: 0x0033D985 File Offset: 0x0033BB85
	public bool CanCloseView()
	{
		if (!GachaModel.Instance.CanCloseView)
		{
			EventSystem.Instance.Emit(EEventName.CloseGachaSceneView);
			return false;
		}
		return true;
	}

	// Token: 0x0600AFE0 RID: 45024 RVA: 0x0033D9A6 File Offset: 0x0033BBA6
	public void GachaHistoryRequest(int gachaId)
	{
	}

	// Token: 0x0600AFE1 RID: 45025 RVA: 0x0033D9A8 File Offset: 0x0033BBA8
	public bool IsNewRole(int roleId)
	{
		bool flag = !this.GachaRoleRecord.Contains(roleId);
		if (flag)
		{
			this.GachaRoleRecord.Add(roleId);
		}
		return flag;
	}

	// Token: 0x0600AFE2 RID: 45026 RVA: 0x0033D9CC File Offset: 0x0033BBCC
	public UniTask GachaRequest(int gachaId, int gachaTimes, int poolId)
	{
		GachaController.<GachaRequest>d__18 <GachaRequest>d__;
		<GachaRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<GachaRequest>d__.<>4__this = this;
		<GachaRequest>d__.gachaId = gachaId;
		<GachaRequest>d__.gachaTimes = gachaTimes;
		<GachaRequest>d__.poolId = poolId;
		<GachaRequest>d__.<>1__state = -1;
		<GachaRequest>d__.<>t__builder.Start<GachaController.<GachaRequest>d__18>(ref <GachaRequest>d__);
		return <GachaRequest>d__.<>t__builder.Task;
	}

	// Token: 0x0600AFE3 RID: 45027 RVA: 0x0033DA27 File Offset: 0x0033BC27
	public void OpenGachaMainView(bool isFunctionViewOpen = false)
	{
		if (!FunctionModel.Instance.IsOpen(10009))
		{
			return;
		}
		this.GachaInfoRequest(true, isFunctionViewOpen);
	}

	// Token: 0x0600AFE4 RID: 45028 RVA: 0x0033DA44 File Offset: 0x0033BC44
	[return: Nullable(new byte[]
	{
		0,
		1
	})]
	public UniTask<GachaPoolDetailResponse> GachaPoolDetailRequestAsync(int poolId)
	{
		GachaController.<GachaPoolDetailRequestAsync>d__20 <GachaPoolDetailRequestAsync>d__;
		<GachaPoolDetailRequestAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<GachaPoolDetailResponse>.Create();
		<GachaPoolDetailRequestAsync>d__.poolId = poolId;
		<GachaPoolDetailRequestAsync>d__.<>1__state = -1;
		<GachaPoolDetailRequestAsync>d__.<>t__builder.Start<GachaController.<GachaPoolDetailRequestAsync>d__20>(ref <GachaPoolDetailRequestAsync>d__);
		return <GachaPoolDetailRequestAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600AFE5 RID: 45029 RVA: 0x0033DA88 File Offset: 0x0033BC88
	public void GachaInfoRequest(bool openView, bool isFunctionViewOpen = false)
	{
		double num = TimeUtil.Instance.GetServerTime() - this.LastGetInfoTime;
		this.LastGetInfoTime = TimeUtil.Instance.GetServerTime();
		if (num < 1.0)
		{
			if (openView && !UiManager.Instance.IsViewOpen(EUiViewName.GachaMainView))
			{
				UiManager.Instance.OpenView(EUiViewName.GachaMainView, null, null);
			}
			return;
		}
		GachaInfoRequest message = Aki.Protocol.GachaInfoRequest.Create();
		Net.Instance.Call(ERequestMessageId.GachaInfoRequest, message, delegate(IMessage msg, Net.CallbackStatus _)
		{
			GachaInfoResponse gachaInfoResponse = (GachaInfoResponse)msg;
			if (gachaInfoResponse == null)
			{
				Log.Instance.Error(ELogModule.Gacha, ELogAuthor.ZJC, "请求抽奖数据失败", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			if (gachaInfoResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(gachaInfoResponse.ErrorCode, 22256, null, true, true);
				return;
			}
			if (LoadingModel.Instance.IsLoading)
			{
				Log.Instance.Info(ELogModule.Gacha, ELogAuthor.LPH, "[GachaController.GachaInfoRequest] 在Loading中,打开抽卡界面取消", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			GachaModel.Instance.InitGachaInfoMap(gachaInfoResponse.GachaInfos);
			GachaModel.Instance.TodayResultCount = gachaInfoResponse.DailyTotalLeftTimes;
			GachaModel.Instance.RecordId = gachaInfoResponse.RecordId;
			EventSystem.Instance.Emit(EEventName.RefreshGachaMainView);
			EventSystem.Instance.Emit(EEventName.OnOpenGachaChanged);
			if (openView && !UiManager.Instance.IsViewOpen(EUiViewName.GachaMainView))
			{
				UiManager.Instance.OpenView(EUiViewName.GachaMainView, null, null);
			}
		}, 0);
	}

	// Token: 0x0600AFE6 RID: 45030 RVA: 0x0033DB1C File Offset: 0x0033BD1C
	public UniTask GachaInfoRequestAsync()
	{
		GachaController.<GachaInfoRequestAsync>d__22 <GachaInfoRequestAsync>d__;
		<GachaInfoRequestAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<GachaInfoRequestAsync>d__.<>4__this = this;
		<GachaInfoRequestAsync>d__.<>1__state = -1;
		<GachaInfoRequestAsync>d__.<>t__builder.Start<GachaController.<GachaInfoRequestAsync>d__22>(ref <GachaInfoRequestAsync>d__);
		return <GachaInfoRequestAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600AFE7 RID: 45031 RVA: 0x0033DB60 File Offset: 0x0033BD60
	[NullableContext(2)]
	public void TryGachaInfoRequest(Action<bool> callback = null)
	{
		double num = TimeUtil.Instance.GetServerTime() - this.LastGetInfoTime;
		this.LastGetInfoTime = TimeUtil.Instance.GetServerTime();
		if (num < 1.0)
		{
			Action<bool> callback2 = callback;
			if (callback2 != null)
			{
				callback2(true);
			}
		}
		GachaInfoRequest message = Aki.Protocol.GachaInfoRequest.Create();
		Net.Instance.Call(ERequestMessageId.GachaInfoRequest, message, delegate(IMessage msg, Net.CallbackStatus _)
		{
			GachaInfoResponse gachaInfoResponse = (GachaInfoResponse)msg;
			if (gachaInfoResponse == null)
			{
				Log.Instance.Error(ELogModule.Gacha, ELogAuthor.ZJC, "请求抽奖数据失败", default(ReadOnlySpan<ValueTuple<string, object>>));
				Action<bool> callback3 = callback;
				if (callback3 == null)
				{
					return;
				}
				callback3(false);
				return;
			}
			else if (gachaInfoResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(gachaInfoResponse.ErrorCode, 22256, null, true, true);
				Action<bool> callback4 = callback;
				if (callback4 == null)
				{
					return;
				}
				callback4(false);
				return;
			}
			else if (LoadingModel.Instance.IsLoading)
			{
				Log.Instance.Info(ELogModule.Gacha, ELogAuthor.LPH, "[GachaController.GachaInfoRequest] 在Loading中,打开抽卡界面取消", default(ReadOnlySpan<ValueTuple<string, object>>));
				Action<bool> callback5 = callback;
				if (callback5 == null)
				{
					return;
				}
				callback5(false);
				return;
			}
			else
			{
				GachaModel.Instance.InitGachaInfoMap(gachaInfoResponse.GachaInfos);
				GachaModel.Instance.TodayResultCount = gachaInfoResponse.DailyTotalLeftTimes;
				GachaModel.Instance.RecordId = gachaInfoResponse.RecordId;
				EventSystem.Instance.Emit(EEventName.RefreshGachaMainView);
				EventSystem.Instance.Emit(EEventName.OnOpenGachaChanged);
				Action<bool> callback6 = callback;
				if (callback6 == null)
				{
					return;
				}
				callback6(true);
				return;
			}
		}, 0);
	}

	// Token: 0x0600AFE8 RID: 45032 RVA: 0x0033DBDC File Offset: 0x0033BDDC
	public void OpenGachaView(int openData = 0)
	{
		this.TryGachaInfoRequest(delegate(bool isSuccess)
		{
			if (isSuccess && !UiManager.Instance.IsViewOpen(EUiViewName.GachaMainView))
			{
				UiManager.Instance.OpenView(EUiViewName.GachaMainView, openData, null);
			}
		});
	}

	// Token: 0x0600AFE9 RID: 45033 RVA: 0x0033DC08 File Offset: 0x0033BE08
	public void GachaUsePoolRequest(int gachaId, int poolId)
	{
		GachaUsePoolRequest gachaUsePoolRequest = Aki.Protocol.GachaUsePoolRequest.Create();
		gachaUsePoolRequest.GachaId = gachaId;
		gachaUsePoolRequest.PoolId = poolId;
		Net.Instance.Call(ERequestMessageId.GachaUsePoolRequest, gachaUsePoolRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			GachaUsePoolResponse gachaUsePoolResponse = (GachaUsePoolResponse)msg;
			if (gachaUsePoolResponse == null)
			{
				Log.Instance.Error(ELogModule.Gacha, ELogAuthor.LZK, "选择卡池失败", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			if (gachaUsePoolResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(gachaUsePoolResponse.ErrorCode, 19735, null, true, true);
				return;
			}
			ProtoGachaInfo gachaInfo = GachaModel.Instance.GetGachaInfo(gachaId);
			if (gachaInfo == null)
			{
				Log.Instance.Error(ELogModule.Gacha, ELogAuthor.LZK, "卡池设置失败", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			gachaInfo.UsePoolId = poolId;
			EventSystem.Instance.Emit<int, int>(EEventName.GachaPoolSelectResponse, gachaId, poolId);
		}, 0);
	}

	// Token: 0x0600AFEA RID: 45034 RVA: 0x0033DC64 File Offset: 0x0033BE64
	public void PreloadGachaResultResource(Action<EUiRoleLoadResult> callback)
	{
		List<string> list = new List<string>();
		Dictionary<int, bool> dictionary = new Dictionary<int, bool>();
		global::GachaResult[] curGachaResult = GachaModel.Instance.CurGachaResult;
		for (int i = 0; i < curGachaResult.Length; i++)
		{
			int itemId = curGachaResult[i].Proto_GachaReward.ItemId;
			switch (GachaConfig.Instance.GetItemIdType(itemId))
			{
			case InventoryDefine.EItemDataType.RoleItem:
			{
				RoleInfo value = GachaConfig.Instance.GetRoleInfoById(itemId).Value;
				if (!dictionary.ContainsKey(itemId))
				{
					dictionary.Add(itemId, true);
					list.AddRange(UiModelResourcesManager.Instance.GetRoleResourcesPath(value.Id));
				}
				int value2 = WeaponModel.Instance.GetWeaponIdByRoleDataId(value.Id).Value;
				string[] collection = UiModelResourcesManager.Instance.GetWeaponResourcesPath(value2).ToArray();
				if (!dictionary.ContainsKey(itemId))
				{
					dictionary.Add(itemId, true);
					list.AddRange(collection);
				}
				RoleInfo? roleConfig = RoleConfig.Instance.GetRoleConfig(value.Id);
				list.AddRange(UiModelResourcesManager.Instance.GetHuluResourcesPath(CharacterUtils.GetHuluModelId(roleConfig.Value.PartyId)));
				break;
			}
			case InventoryDefine.EItemDataType.WeaponItem:
			{
				string[] collection = UiModelResourcesManager.Instance.GetWeaponResourcesPath(itemId).ToArray();
				if (!dictionary.ContainsKey(itemId))
				{
					dictionary.Add(itemId, true);
					list.AddRange(collection);
				}
				break;
			}
			}
		}
		UiModelResourcesManager.Instance.LoadUiModelResources(list, delegate(EUiRoleLoadResult result, Dictionary<string, UObject> _)
		{
			callback(result);
		});
	}

	// Token: 0x0600AFEB RID: 45035 RVA: 0x0033DDF0 File Offset: 0x0033BFF0
	public void CommonShowRoleResult(RewardItemPackage itemPackage, bool skipOpenAnime, bool hideExtraReward)
	{
		int id = itemPackage.RewardItem.Id;
		if (InventoryConfig.Instance.GetItemDataTypeByConfigId(new int?(id)) == InventoryDefine.EItemDataType.RoleItem)
		{
			List<global::GachaResult> list = new List<global::GachaResult>();
			global::GachaResult gachaResult = new global::GachaResult();
			GachaReward gachaReward = GachaReward.Create();
			gachaReward.ItemId = id;
			gachaReward.ItemCount = 1;
			gachaResult.Proto_GachaReward = gachaReward;
			List<GachaReward> list2 = new List<GachaReward>();
			foreach (Aki.Protocol.RewardItem rewardItem in itemPackage.RewardItems)
			{
				GachaReward gachaReward2 = GachaReward.Create();
				gachaReward2.ItemId = rewardItem.Id;
				gachaReward2.ItemCount = rewardItem.Count;
				list2.Add(gachaReward2);
			}
			gachaResult.Proto_TransformRewards = list2.ToArray();
			list.Add(gachaResult);
			IGachaViewOpenData gachaViewOpenData = new GachaViewOpenData
			{
				SkipOnLoadResourceFinish = skipOpenAnime,
				ResultViewHideExtraReward = hideExtraReward,
				IsOnlyShowGold = false
			};
			if (UiManager.Instance.IsViewOpen(EUiViewName.DrawMainView) || UiManager.Instance.IsViewOpen(EUiViewName.GachaScanView))
			{
				GachaModel.Instance.CacheGachaInfo(new CommonShowRoleInfo
				{
					ResultViewData = gachaViewOpenData,
					GachaResult = list.ToArray()
				});
				return;
			}
			GachaModel.Instance.CurGachaResult = list.ToArray();
			if (gachaViewOpenData.SkipOnLoadResourceFinish)
			{
				UiManager.Instance.OpenView(EUiViewName.GachaScanView, gachaViewOpenData, null);
				return;
			}
			UiManager.Instance.OpenView(EUiViewName.DrawMainView, gachaViewOpenData, null);
		}
	}

	// Token: 0x0600AFEC RID: 45036 RVA: 0x0033DF6C File Offset: 0x0033C16C
	private void OnAfterCloseGachaScent()
	{
		ICommonShowRoleInfo cachedGachaInfo = GachaModel.Instance.GetCachedGachaInfo();
		if (cachedGachaInfo != null)
		{
			GachaModel.Instance.CurGachaResult = cachedGachaInfo.GachaResult;
			if (cachedGachaInfo.ResultViewData.SkipOnLoadResourceFinish)
			{
				UiManager.Instance.OpenView(EUiViewName.GachaScanView, cachedGachaInfo.ResultViewData, null);
				return;
			}
			UiManager.Instance.OpenView(EUiViewName.DrawMainView, cachedGachaInfo.ResultViewData, null);
		}
	}

	// Token: 0x0600AFED RID: 45037 RVA: 0x0033DFD4 File Offset: 0x0033C1D4
	public void OpenGachaSelectionView(ProtoGachaInfo gachaInfo)
	{
		if (!UiManager.Instance.IsViewOpen(EUiViewName.GachaSelectionView))
		{
			GachaSelectionViewData gachaSelectionViewData = new GachaSelectionViewData();
			gachaSelectionViewData.GachaInfo = gachaInfo;
			UiManager.Instance.OpenView(EUiViewName.GachaSelectionView, gachaSelectionViewData, null);
			return;
		}
		EventSystem.Instance.Emit<ProtoGachaInfo>(EEventName.GachaSelectionViewRefresh, gachaInfo);
	}

	// Token: 0x17001207 RID: 4615
	// (get) Token: 0x0600AFEE RID: 45038 RVA: 0x0033E022 File Offset: 0x0033C222
	public static GachaController Instance
	{
		get
		{
			return GachaController._Instance;
		}
	}

	// Token: 0x0600AFEF RID: 45039 RVA: 0x0033E029 File Offset: 0x0033C229
	public static GachaController GetOrCreateInstance()
	{
		if (GachaController._Instance == null)
		{
			GachaController.CreateInstance();
		}
		return GachaController._Instance;
	}

	// Token: 0x0600AFF0 RID: 45040 RVA: 0x0033E03D File Offset: 0x0033C23D
	public static bool CreateInstance()
	{
		if (GachaController._Instance != null)
		{
			return true;
		}
		GachaController._Instance = new GachaController();
		return true;
	}

	// Token: 0x0600AFF1 RID: 45041 RVA: 0x0033E053 File Offset: 0x0033C253
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600AFF2 RID: 45042 RVA: 0x0033E055 File Offset: 0x0033C255
	public static void ResetStaticDefaultValue()
	{
		GachaController._Instance = null;
	}

	// Token: 0x0600AFF3 RID: 45043 RVA: 0x0033E05D File Offset: 0x0033C25D
	static GachaController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(GachaController.CreateStaticDefaultValue), new Action(GachaController.ResetStaticDefaultValue));
	}

	// Token: 0x04006598 RID: 26008
	private HashSet<int> GachaRoleRecord;

	// Token: 0x04006599 RID: 26009
	private double LastGetInfoTime;

	// Token: 0x0400659A RID: 26010
	private const int MinGetInfoInterval = 1;

	// Token: 0x0400659B RID: 26011
	[Nullable(2)]
	private static GachaController _Instance;
}
