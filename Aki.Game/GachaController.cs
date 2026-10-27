using System;
using System.Collections.Generic;
using System.Linq;
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

// Token: 0x02001C76 RID: 7286
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class GachaController : UiControllerBase
{
	// Token: 0x0600DBBD RID: 56253 RVA: 0x00331FEC File Offset: 0x003301EC
	protected override bool OnInit()
	{
		this.GachaRoleRecord = new HashSet<int>();
		InputManager.Instance.RegisterOpenViewFunc(EUiViewName.GachaMainView, new Action(this.OpenView));
		return true;
	}

	// Token: 0x0600DBBE RID: 56254 RVA: 0x00332015 File Offset: 0x00330215
	private void OpenView()
	{
		this.OpenGachaMainView(true);
	}

	// Token: 0x0600DBBF RID: 56255 RVA: 0x00332020 File Offset: 0x00330220
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add<EFunctionType, bool>(EEventName.OnFunctionOpenSet, new Action<EFunctionType, bool>(this.OnFunctionOpenDataUpdate));
		EventSystem.Instance.Add<EFunctionType, bool>(EEventName.OnFunctionOpenUpdate, new Action<EFunctionType, bool>(this.OnFunctionOpenDataUpdate));
		EventSystem.Instance.Add(EEventName.CrossDay, new Action(this.RefreshGachaMainView));
		EventSystem.Instance.Add(EEventName.AfterCloseGachaScene, new Action(this.OnAfterCloseGachaScent));
		EventSystem.Instance.Add(EEventName.WorldDoneAndCloseLoading, new Action(this.OnWorldDone));
	}

	// Token: 0x0600DBC0 RID: 56256 RVA: 0x003320BC File Offset: 0x003302BC
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.OnFunctionOpenSet, new Action<EFunctionType, bool>(this.OnFunctionOpenDataUpdate));
		EventSystem.Instance.Remove(EEventName.OnFunctionOpenUpdate, new Action<EFunctionType, bool>(this.OnFunctionOpenDataUpdate));
		EventSystem.Instance.Remove(EEventName.CrossDay, new Action(this.RefreshGachaMainView));
		EventSystem.Instance.Remove(EEventName.AfterCloseGachaScene, new Action(this.OnAfterCloseGachaScent));
		EventSystem.Instance.Remove(EEventName.WorldDoneAndCloseLoading, new Action(this.OnWorldDone));
	}

	// Token: 0x0600DBC1 RID: 56257 RVA: 0x00332158 File Offset: 0x00330358
	protected override void OnRegisterNetEvent()
	{
		Net.Instance.Register(ENotifyMessageId.GachaResultNotify, new Action<IMessage, Net.CallbackStatus>(this.OnGachaResultNotify));
		Net.Instance.Register(ENotifyMessageId.GachaNewNotify, new Action<IMessage, Net.CallbackStatus>(this.OnGachaNewNotify));
		Net.Instance.Register(ENotifyMessageId.GachaDiscountNotify, new Action<IMessage, Net.CallbackStatus>(this.OnGachaDiscountNotify));
	}

	// Token: 0x0600DBC2 RID: 56258 RVA: 0x003321B9 File Offset: 0x003303B9
	protected override void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.GachaResultNotify);
		Net.Instance.UnRegister(ENotifyMessageId.GachaNewNotify);
		Net.Instance.UnRegister(ENotifyMessageId.GachaDiscountNotify);
	}

	// Token: 0x0600DBC3 RID: 56259 RVA: 0x003321EB File Offset: 0x003303EB
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

	// Token: 0x0600DBC4 RID: 56260 RVA: 0x00332218 File Offset: 0x00330418
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

	// Token: 0x0600DBC5 RID: 56261 RVA: 0x003322A0 File Offset: 0x003304A0
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
				Proto_TransformRewards = gachaResult.TransformRewards.ToArray<GachaReward>(),
				Proto_ExtraRewards = gachaResult.ExtraRewards.ToArray<GachaReward>()
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

	// Token: 0x0600DBC6 RID: 56262 RVA: 0x003323BC File Offset: 0x003305BC
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
		GachaDiscountInfo[] array = gachaDiscountNotify.GachaDiscountInfos.ToArray<GachaDiscountInfo>();
		List<GachaDiscountInfo> list = gachaInfo.GachaDiscountInfos.ToList<GachaDiscountInfo>();
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

	// Token: 0x0600DBC7 RID: 56263 RVA: 0x003324E9 File Offset: 0x003306E9
	private void OnFunctionOpenDataUpdate(EFunctionType functionType, bool isOpen)
	{
		if (functionType == EFunctionType.Gacha && isOpen)
		{
			GachaModel.Instance.InitGachaPoolOpenRecord();
			this.GachaInfoRequest(false, false);
		}
	}

	// Token: 0x0600DBC8 RID: 56264 RVA: 0x00332509 File Offset: 0x00330709
	private void RefreshGachaMainView()
	{
		if (!UiManager.Instance.IsViewOpen(EUiViewName.GachaMainView))
		{
			return;
		}
		this.GachaInfoRequest(false, false);
	}

	// Token: 0x0600DBC9 RID: 56265 RVA: 0x00332525 File Offset: 0x00330725
	public bool CanCloseView()
	{
		if (!GachaModel.Instance.CanCloseView)
		{
			EventSystem.Instance.Emit(EEventName.CloseGachaSceneView);
			return false;
		}
		return true;
	}

	// Token: 0x0600DBCA RID: 56266 RVA: 0x00332546 File Offset: 0x00330746
	public void GachaHistoryRequest(int gachaId)
	{
	}

	// Token: 0x0600DBCB RID: 56267 RVA: 0x00332548 File Offset: 0x00330748
	public bool IsNewRole(int roleId)
	{
		bool flag = !this.GachaRoleRecord.Contains(roleId);
		if (flag)
		{
			this.GachaRoleRecord.Add(roleId);
		}
		return flag;
	}

	// Token: 0x0600DBCC RID: 56268 RVA: 0x0033256C File Offset: 0x0033076C
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

	// Token: 0x0600DBCD RID: 56269 RVA: 0x003325C7 File Offset: 0x003307C7
	public void OpenGachaMainView(bool isFunctionViewOpen = false)
	{
		if (!FunctionModel.Instance.IsOpen(10009))
		{
			return;
		}
		this.GachaInfoRequest(true, isFunctionViewOpen);
	}

	// Token: 0x0600DBCE RID: 56270 RVA: 0x003325E4 File Offset: 0x003307E4
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

	// Token: 0x0600DBCF RID: 56271 RVA: 0x00332628 File Offset: 0x00330828
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
				ErrorCodeController.Instance.OpenErrorCodeTipView(gachaInfoResponse.ErrorCode, 18695, null, true, true);
				return;
			}
			if (LoadingModel.Instance.IsLoading)
			{
				Log.Instance.Info(ELogModule.Gacha, ELogAuthor.LPH, "[GachaController.GachaInfoRequest] 在Loading中,打开抽卡界面取消", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			GachaModel.Instance.InitGachaInfoMap(gachaInfoResponse.GachaInfos.ToArray<GachaInfo>());
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

	// Token: 0x0600DBD0 RID: 56272 RVA: 0x003326BC File Offset: 0x003308BC
	public UniTask GachaInfoRequestAsync()
	{
		GachaController.<GachaInfoRequestAsync>d__22 <GachaInfoRequestAsync>d__;
		<GachaInfoRequestAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<GachaInfoRequestAsync>d__.<>4__this = this;
		<GachaInfoRequestAsync>d__.<>1__state = -1;
		<GachaInfoRequestAsync>d__.<>t__builder.Start<GachaController.<GachaInfoRequestAsync>d__22>(ref <GachaInfoRequestAsync>d__);
		return <GachaInfoRequestAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600DBD1 RID: 56273 RVA: 0x00332700 File Offset: 0x00330900
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
				ErrorCodeController.Instance.OpenErrorCodeTipView(gachaInfoResponse.ErrorCode, 18695, null, true, true);
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
				GachaModel.Instance.InitGachaInfoMap(gachaInfoResponse.GachaInfos.ToArray<GachaInfo>());
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

	// Token: 0x0600DBD2 RID: 56274 RVA: 0x0033277C File Offset: 0x0033097C
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

	// Token: 0x0600DBD3 RID: 56275 RVA: 0x003327A8 File Offset: 0x003309A8
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
				ErrorCodeController.Instance.OpenErrorCodeTipView(gachaUsePoolResponse.ErrorCode, 25952, null, true, true);
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

	// Token: 0x0600DBD4 RID: 56276 RVA: 0x00332804 File Offset: 0x00330A04
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

	// Token: 0x0600DBD5 RID: 56277 RVA: 0x00332990 File Offset: 0x00330B90
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

	// Token: 0x0600DBD6 RID: 56278 RVA: 0x00332B0C File Offset: 0x00330D0C
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

	// Token: 0x0600DBD7 RID: 56279 RVA: 0x00332B74 File Offset: 0x00330D74
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

	// Token: 0x170011E1 RID: 4577
	// (get) Token: 0x0600DBD8 RID: 56280 RVA: 0x00332BC2 File Offset: 0x00330DC2
	public static GachaController Instance
	{
		get
		{
			return GachaController._Instance;
		}
	}

	// Token: 0x0600DBD9 RID: 56281 RVA: 0x00332BC9 File Offset: 0x00330DC9
	public static GachaController GetOrCreateInstance()
	{
		if (GachaController._Instance == null)
		{
			GachaController.CreateInstance();
		}
		return GachaController._Instance;
	}

	// Token: 0x0600DBDA RID: 56282 RVA: 0x00332BDD File Offset: 0x00330DDD
	public static bool CreateInstance()
	{
		if (GachaController._Instance != null)
		{
			return true;
		}
		GachaController._Instance = new GachaController();
		return true;
	}

	// Token: 0x0600DBDB RID: 56283 RVA: 0x00332BF3 File Offset: 0x00330DF3
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600DBDC RID: 56284 RVA: 0x00332BF5 File Offset: 0x00330DF5
	public static void ResetStaticDefaultValue()
	{
		GachaController._Instance = null;
	}

	// Token: 0x0600DBDD RID: 56285 RVA: 0x00332BFD File Offset: 0x00330DFD
	static GachaController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(GachaController.CreateStaticDefaultValue), new Action(GachaController.ResetStaticDefaultValue));
	}

	// Token: 0x040064C6 RID: 25798
	private HashSet<int> GachaRoleRecord;

	// Token: 0x040064C7 RID: 25799
	private double LastGetInfoTime;

	// Token: 0x040064C8 RID: 25800
	private const int MinGetInfoInterval = 1;

	// Token: 0x040064C9 RID: 25801
	[Nullable(2)]
	private static GachaController _Instance;
}
