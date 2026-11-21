using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Google.Protobuf;

// Token: 0x020010D9 RID: 4313
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class FragmentMemoryController : ControllerBase
{
	// Token: 0x0600ABE3 RID: 44003 RVA: 0x0032A501 File Offset: 0x00328701
	protected override bool OnInit()
	{
		this.OnAddEvents();
		this.OnRegisterNetEvent();
		return true;
	}

	// Token: 0x0600ABE4 RID: 44004 RVA: 0x0032A510 File Offset: 0x00328710
	protected override bool OnClear()
	{
		this.OnRemoveEvents();
		this.OnUnRegisterNetEvent();
		return true;
	}

	// Token: 0x0600ABE5 RID: 44005 RVA: 0x0032A520 File Offset: 0x00328720
	protected void OnAddEvents()
	{
		EventSystem.Instance.Add(EEventName.OnLoadingNetDataDone, new Action(this.OnLoadingNetDataDone));
		EventSystem.Instance.Add(EEventName.ActiveBattleView, new Action(this.OnActiveBattleView));
		EventSystem.Instance.Add(EEventName.OnSpecialItemUse, new Action<int, int>(this.OnItemUse));
		EventSystem.Instance.Add<UiViewBase>(EEventName.CreateViewInstance, new Action<UiViewBase>(this.OnCreateViewInstance));
		EventSystem.Instance.Add(EEventName.OnWorldMapClose, new Action(this.OnWorldMapClose));
	}

	// Token: 0x0600ABE6 RID: 44006 RVA: 0x0032A5B8 File Offset: 0x003287B8
	protected void OnRemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.OnSpecialItemUse, new Action<int, int>(this.OnItemUse));
		EventSystem.Instance.Remove(EEventName.OnLoadingNetDataDone, new Action(this.OnLoadingNetDataDone));
		EventSystem.Instance.Remove(EEventName.ActiveBattleView, new Action(this.OnActiveBattleView));
		EventSystem.Instance.Remove(EEventName.CreateViewInstance, new Action<UiViewBase>(this.OnCreateViewInstance));
		EventSystem.Instance.Remove(EEventName.OnWorldMapClose, new Action(this.OnWorldMapClose));
	}

	// Token: 0x0600ABE7 RID: 44007 RVA: 0x0032A64E File Offset: 0x0032884E
	protected void OnRegisterNetEvent()
	{
		Net.Instance.Register(ENotifyMessageId.PhotoMemoryUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnPhotoMemoryUpdateNotify));
		Net.Instance.Register(ENotifyMessageId.PhotoMemoryCollectNotify, new Action<IMessage, Net.CallbackStatus>(this.OnPhotoMemoryCollectNotify));
	}

	// Token: 0x0600ABE8 RID: 44008 RVA: 0x0032A688 File Offset: 0x00328888
	protected void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.PhotoMemoryUpdateNotify);
		Net.Instance.UnRegister(ENotifyMessageId.PhotoMemoryCollectNotify);
	}

	// Token: 0x0600ABE9 RID: 44009 RVA: 0x0032A6AA File Offset: 0x003288AA
	private void OnLoadingNetDataDone()
	{
		this.RequestPhotoMemory();
	}

	// Token: 0x0600ABEA RID: 44010 RVA: 0x0032A6B2 File Offset: 0x003288B2
	private void OnWorldMapClose()
	{
		FragmentMemoryModel.Instance.TryRemoveUntrackedCurrentTrackEntity();
	}

	// Token: 0x0600ABEB RID: 44011 RVA: 0x0032A6C0 File Offset: 0x003288C0
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

	// Token: 0x0600ABEC RID: 44012 RVA: 0x0032A7CC File Offset: 0x003289CC
	private void OnActiveBattleView()
	{
		this.DoShowNewItemView();
	}

	// Token: 0x0600ABED RID: 44013 RVA: 0x0032A7D4 File Offset: 0x003289D4
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

	// Token: 0x0600ABEE RID: 44014 RVA: 0x0032A850 File Offset: 0x00328A50
	[NullableContext(2)]
	private void OnPhotoMemoryCollectNotify(IMessage msg, Net.CallbackStatus status)
	{
		PhotoMemoryCollectNotify notify = (PhotoMemoryCollectNotify)msg;
		FragmentMemoryModel.Instance.OnPhotoMemoryCollectUpdate(notify);
		FragmentMemoryModel.Instance.TryRemoveCurrentTrackEntity();
	}

	// Token: 0x0600ABEF RID: 44015 RVA: 0x0032A879 File Offset: 0x00328A79
	public void RequestPhotoMemory()
	{
		Net.Instance.Call(ERequestMessageId.PhotoMemoryRequest, PhotoMemoryRequest.Create(), delegate(IMessage msg, Net.CallbackStatus _)
		{
			PhotoMemoryResponse response = (PhotoMemoryResponse)msg;
			FragmentMemoryModel.Instance.OnPhotoMemoryResponse(response);
		}, 0);
	}

	// Token: 0x0600ABF0 RID: 44016 RVA: 0x0032A8B0 File Offset: 0x00328AB0
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
				ErrorCodeController.Instance.OpenErrorCodeTipView(photoMemoryRewardResponse.Error, 15832, null, true, true);
			}
		}, 0);
	}

	// Token: 0x0600ABF1 RID: 44017 RVA: 0x0032A90A File Offset: 0x00328B0A
	private void OnItemUse(int configId, int useCount)
	{
		if (configId == 70140004)
		{
			this.OpenFragmentMemoryView();
		}
	}

	// Token: 0x0600ABF2 RID: 44018 RVA: 0x0032A91A File Offset: 0x00328B1A
	private void OnCreateViewInstance(UiViewBase view)
	{
		if (view.ViewInfo.Name == EUiViewName.CommonActivityView)
		{
			FragmentMemoryModel.Instance.ActivitySubViewTryPlayAnimation = "";
		}
	}

	// Token: 0x0600ABF3 RID: 44019 RVA: 0x0032A942 File Offset: 0x00328B42
	public void OpenFragmentMemoryView()
	{
		UiManager.Instance.OpenView(EUiViewName.MemoryDetailView, null, null);
	}

	// Token: 0x170011DB RID: 4571
	// (get) Token: 0x0600ABF4 RID: 44020 RVA: 0x0032A955 File Offset: 0x00328B55
	public static FragmentMemoryController Instance
	{
		get
		{
			return FragmentMemoryController._Instance;
		}
	}

	// Token: 0x0600ABF5 RID: 44021 RVA: 0x0032A95C File Offset: 0x00328B5C
	public static FragmentMemoryController GetOrCreateInstance()
	{
		if (FragmentMemoryController._Instance == null)
		{
			FragmentMemoryController.CreateInstance();
		}
		return FragmentMemoryController._Instance;
	}

	// Token: 0x0600ABF6 RID: 44022 RVA: 0x0032A970 File Offset: 0x00328B70
	public static bool CreateInstance()
	{
		if (FragmentMemoryController._Instance != null)
		{
			return true;
		}
		FragmentMemoryController._Instance = new FragmentMemoryController();
		return true;
	}

	// Token: 0x0600ABF7 RID: 44023 RVA: 0x0032A986 File Offset: 0x00328B86
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600ABF8 RID: 44024 RVA: 0x0032A988 File Offset: 0x00328B88
	public static void ResetStaticDefaultValue()
	{
		FragmentMemoryController._Instance = null;
	}

	// Token: 0x0600ABF9 RID: 44025 RVA: 0x0032A990 File Offset: 0x00328B90
	static FragmentMemoryController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(FragmentMemoryController.CreateStaticDefaultValue), new Action(FragmentMemoryController.ResetStaticDefaultValue));
	}

	// Token: 0x04006353 RID: 25427
	public const int INFO_FRAGMENTMEMORYITEM = 70140004;

	// Token: 0x04006354 RID: 25428
	[Nullable(2)]
	private static FragmentMemoryController _Instance;
}
