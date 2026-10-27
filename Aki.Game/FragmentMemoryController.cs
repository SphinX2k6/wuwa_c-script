using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Google.Protobuf;

// Token: 0x02001C1A RID: 7194
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class FragmentMemoryController : ControllerBase
{
	// Token: 0x0600D7CF RID: 55247 RVA: 0x0031F1B1 File Offset: 0x0031D3B1
	protected override bool OnInit()
	{
		this.OnAddEvents();
		this.OnRegisterNetEvent();
		return true;
	}

	// Token: 0x0600D7D0 RID: 55248 RVA: 0x0031F1C0 File Offset: 0x0031D3C0
	protected override bool OnClear()
	{
		this.OnRemoveEvents();
		this.OnUnRegisterNetEvent();
		return true;
	}

	// Token: 0x0600D7D1 RID: 55249 RVA: 0x0031F1D0 File Offset: 0x0031D3D0
	protected void OnAddEvents()
	{
		EventSystem.Instance.Add(EEventName.OnLoadingNetDataDone, new Action(this.OnLoadingNetDataDone));
		EventSystem.Instance.Add(EEventName.ActiveBattleView, new Action(this.OnActiveBattleView));
		EventSystem.Instance.Add(EEventName.OnSpecialItemUse, new Action<int, int>(this.OnItemUse));
		EventSystem.Instance.Add<UiViewBase>(EEventName.CreateViewInstance, new Action<UiViewBase>(this.OnCreateViewInstance));
	}

	// Token: 0x0600D7D2 RID: 55250 RVA: 0x0031F24C File Offset: 0x0031D44C
	protected void OnRemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.OnSpecialItemUse, new Action<int, int>(this.OnItemUse));
		EventSystem.Instance.Remove(EEventName.OnLoadingNetDataDone, new Action(this.OnLoadingNetDataDone));
		EventSystem.Instance.Remove(EEventName.ActiveBattleView, new Action(this.OnActiveBattleView));
		EventSystem.Instance.Remove(EEventName.CreateViewInstance, new Action<UiViewBase>(this.OnCreateViewInstance));
	}

	// Token: 0x0600D7D3 RID: 55251 RVA: 0x0031F2C6 File Offset: 0x0031D4C6
	protected void OnRegisterNetEvent()
	{
		Net.Instance.Register(ENotifyMessageId.PhotoMemoryUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnPhotoMemoryUpdateNotify));
		Net.Instance.Register(ENotifyMessageId.PhotoMemoryCollectNotify, new Action<IMessage, Net.CallbackStatus>(this.OnPhotoMemoryCollectNotify));
	}

	// Token: 0x0600D7D4 RID: 55252 RVA: 0x0031F300 File Offset: 0x0031D500
	protected void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.PhotoMemoryUpdateNotify);
		Net.Instance.UnRegister(ENotifyMessageId.PhotoMemoryCollectNotify);
	}

	// Token: 0x0600D7D5 RID: 55253 RVA: 0x0031F322 File Offset: 0x0031D522
	private void OnLoadingNetDataDone()
	{
		this.RequestPhotoMemory();
	}

	// Token: 0x0600D7D6 RID: 55254 RVA: 0x0031F32C File Offset: 0x0031D52C
	[NullableContext(2)]
	private void OnPhotoMemoryUpdateNotify(IMessage msg, Net.CallbackStatus status)
	{
		PhotoMemoryUpdateNotify notify = (PhotoMemoryUpdateNotify)msg;
		List<int> collectedIds = FragmentMemoryModel.Instance.GetCollectedIds();
		FragmentMemoryModel.Instance.OnPhotoMemoryUpdate(notify);
		List<int> collectedIds2 = FragmentMemoryModel.Instance.GetCollectedIds();
		List<int> list = new List<int>();
		foreach (int item in collectedIds2)
		{
			if (!collectedIds.Contains(item))
			{
				list.Add(item);
			}
		}
		if (list.Count > 0)
		{
			FragmentMemoryModel.Instance.CurrentUnlockCollectId = list[0];
		}
		this.DoShowNewItemView();
		foreach (ActivityBaseData activityBaseData in ActivityModel.Instance.GetAllActivityMap().Values)
		{
			if (activityBaseData is FragmentMemoryActivityData)
			{
				EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, activityBaseData.Id);
			}
		}
	}

	// Token: 0x0600D7D7 RID: 55255 RVA: 0x0031F438 File Offset: 0x0031D638
	private void OnActiveBattleView()
	{
		this.DoShowNewItemView();
	}

	// Token: 0x0600D7D8 RID: 55256 RVA: 0x0031F440 File Offset: 0x0031D640
	private void DoShowNewItemView()
	{
		if (FragmentMemoryModel.Instance.CurrentUnlockCollectId == 0)
		{
			return;
		}
		if (!UiManager.Instance.IsViewShow(EUiViewName.ObtainFragmentView) && UiManager.Instance.IsViewShow(EUiViewName.BattleView))
		{
			if (FragmentMemoryModel.Instance.CurrentUnlockCollectId == FragmentMemoryModel.Instance.CurrentTrackFragmentId)
			{
				FragmentMemoryModel.Instance.TryRemoveCurrentTrackEntity();
			}
			UiManager.Instance.OpenView(EUiViewName.ObtainFragmentView, FragmentMemoryModel.Instance.CurrentUnlockCollectId, null);
		}
	}

	// Token: 0x0600D7D9 RID: 55257 RVA: 0x0031F4BC File Offset: 0x0031D6BC
	[NullableContext(2)]
	private void OnPhotoMemoryCollectNotify(IMessage msg, Net.CallbackStatus status)
	{
		PhotoMemoryCollectNotify notify = (PhotoMemoryCollectNotify)msg;
		FragmentMemoryModel.Instance.OnPhotoMemoryCollectUpdate(notify);
		FragmentMemoryModel.Instance.TryRemoveCurrentTrackEntity();
	}

	// Token: 0x0600D7DA RID: 55258 RVA: 0x0031F4E5 File Offset: 0x0031D6E5
	public void RequestPhotoMemory()
	{
		Net.Instance.Call(ERequestMessageId.PhotoMemoryRequest, PhotoMemoryRequest.Create(), delegate(IMessage msg, Net.CallbackStatus _)
		{
			PhotoMemoryResponse response = (PhotoMemoryResponse)msg;
			FragmentMemoryModel.Instance.OnPhotoMemoryResponse(response);
		}, 0);
	}

	// Token: 0x0600D7DB RID: 55259 RVA: 0x0031F51C File Offset: 0x0031D71C
	public void RequestMemoryReward(int[] ids)
	{
		PhotoMemoryRewardRequest photoMemoryRewardRequest = PhotoMemoryRewardRequest.Create();
		photoMemoryRewardRequest.CollectIds.Clear();
		photoMemoryRewardRequest.CollectIds.AddRange(ids);
		Net.Instance.Call(ERequestMessageId.PhotoMemoryRewardRequest, photoMemoryRewardRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			PhotoMemoryRewardResponse photoMemoryRewardResponse = (PhotoMemoryRewardResponse)msg;
			if (photoMemoryRewardResponse != null && photoMemoryRewardResponse.Error != ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(photoMemoryRewardResponse.Error, 16842, null, true, true);
			}
		}, 0);
	}

	// Token: 0x0600D7DC RID: 55260 RVA: 0x0031F576 File Offset: 0x0031D776
	private void OnItemUse(int configId, int useCount)
	{
		if (configId == 70140004)
		{
			this.OpenFragmentMemoryView();
		}
	}

	// Token: 0x0600D7DD RID: 55261 RVA: 0x0031F586 File Offset: 0x0031D786
	private void OnCreateViewInstance(UiViewBase view)
	{
		if (view.ViewInfo.Name == EUiViewName.CommonActivityView)
		{
			FragmentMemoryModel.Instance.ActivitySubViewTryPlayAnimation = "";
		}
	}

	// Token: 0x0600D7DE RID: 55262 RVA: 0x0031F5AE File Offset: 0x0031D7AE
	public void OpenFragmentMemoryView()
	{
		UiManager.Instance.OpenView(EUiViewName.MemoryDetailView, null, null);
	}

	// Token: 0x170011B5 RID: 4533
	// (get) Token: 0x0600D7DF RID: 55263 RVA: 0x0031F5C1 File Offset: 0x0031D7C1
	public static FragmentMemoryController Instance
	{
		get
		{
			return FragmentMemoryController._Instance;
		}
	}

	// Token: 0x0600D7E0 RID: 55264 RVA: 0x0031F5C8 File Offset: 0x0031D7C8
	public static FragmentMemoryController GetOrCreateInstance()
	{
		if (FragmentMemoryController._Instance == null)
		{
			FragmentMemoryController.CreateInstance();
		}
		return FragmentMemoryController._Instance;
	}

	// Token: 0x0600D7E1 RID: 55265 RVA: 0x0031F5DC File Offset: 0x0031D7DC
	public static bool CreateInstance()
	{
		if (FragmentMemoryController._Instance != null)
		{
			return true;
		}
		FragmentMemoryController._Instance = new FragmentMemoryController();
		return true;
	}

	// Token: 0x0600D7E2 RID: 55266 RVA: 0x0031F5F2 File Offset: 0x0031D7F2
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600D7E3 RID: 55267 RVA: 0x0031F5F4 File Offset: 0x0031D7F4
	public static void ResetStaticDefaultValue()
	{
		FragmentMemoryController._Instance = null;
	}

	// Token: 0x0600D7E4 RID: 55268 RVA: 0x0031F5FC File Offset: 0x0031D7FC
	static FragmentMemoryController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(FragmentMemoryController.CreateStaticDefaultValue), new Action(FragmentMemoryController.ResetStaticDefaultValue));
	}

	// Token: 0x04006281 RID: 25217
	public const int INFO_FRAGMENTMEMORYITEM = 70140004;

	// Token: 0x04006282 RID: 25218
	[Nullable(2)]
	private static FragmentMemoryController _Instance;
}
