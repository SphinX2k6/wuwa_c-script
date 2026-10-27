using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.ResManager;
using CSharpScript.Game.Ui;
using CSharpScript.Launcher;
using CSharpScript.Launcher.DiffPatch.Update;
using CSharpScript.Launcher.Ui.HotFix;
using CSharpScript.Launcher.Update;
using CSharpScript.Launcher.Update.ResourceDiffUpdate;
using CSharpScript.Launcher.Update.ResourceDiffUpdate.Updater;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf;

// Token: 0x02002A91 RID: 10897
[NullableContext(1)]
[Nullable(0)]
public class SubPackageController : UiControllerBase
{
	// Token: 0x06016AF5 RID: 92917 RVA: 0x005BEBD4 File Offset: 0x005BCDD4
	public void DeleteUnneededResourceOnInit()
	{
		if (this.HaveDeleteUnneededResourceOnInit.GetValueOrDefault())
		{
			return;
		}
		if (!VideoResUpdate.Instance.IsVideoClearGrayBoxHit())
		{
			return;
		}
		this.HaveDeleteUnneededResourceOnInit = new bool?(true);
		int valueOrDefault = PlayerInfoModel.Instance.GetId().GetValueOrDefault();
		if (LocalStorage.GetPlayer<bool>(ELocalStoragePlayerKey.SubDownLoadClearOnLogin, false))
		{
			int global = LocalStorage.GetGlobal<int>(ELocalStorageGlobalKey.SubDownLoadClearLastWorldDoneUid, 0);
			if (global != 0 && global != valueOrDefault)
			{
				LocalStorage.SetPlayer<bool>(ELocalStoragePlayerKey.SubDownLoadClearOnLogin, false);
			}
			else
			{
				this.DeleteUnneededResource(true);
			}
		}
		if (valueOrDefault != 0)
		{
			LocalStorage.SetGlobal<int>(ELocalStorageGlobalKey.SubDownLoadClearLastWorldDoneUid, valueOrDefault);
		}
	}

	// Token: 0x06016AF6 RID: 92918 RVA: 0x005BEC5C File Offset: 0x005BCE5C
	private unsafe void DownLoadPackage()
	{
		SubPackageDownLoadModel.Instance.PauseSubPackageId = 0;
		if (SubPackageDownLoadModel.Instance.DownLoadingSubPackageId != 0)
		{
			return;
		}
		if (SubPackageDownLoadModel.Instance.SubPackageDownLoadList.Count == 0)
		{
			return;
		}
		int num = SubPackageDownLoadModel.Instance.SubPackageDownLoadList[0];
		SubPackageDownLoadModel.Instance.SubPackageDownLoadList.RemoveAt(0);
		if (num == 0)
		{
			return;
		}
		if (SubPackageDownLoadModel.Instance.IsKeyPackageDownLoadingPause() && num != 1)
		{
			SubPackageDownLoadModel.Instance.SubPackageDownLoadList.Insert(0, num);
			return;
		}
		if (SubPackageDownLoadModel.Instance.HaveNotEnoughSpace(num))
		{
			SubPackageDownLoadModel.Instance.SetSubPackageDownLoadItemStateMap(num, ESubPackageDownLoadState.Pause);
			if (!UiManager.Instance.IsViewOpen(EUiViewName.SubPackageDownLoadFreeSpaceTipsView))
			{
				UiManager.Instance.OpenView(EUiViewName.SubPackageDownLoadFreeSpaceTipsView, num, null);
			}
			return;
		}
		SubPackageDownLoadModel.Instance.SetSubPackageDownLoadItemStateMap(num, ESubPackageDownLoadState.DownLoading);
		List<ResourceDiffUpdater> list = SubPackageDownLoadModel.Instance.GetSubPackageDownLoadItemUpdater(num) ?? new List<ResourceDiffUpdater>();
		foreach (ResourceDiffUpdater resourceDiffUpdater in list)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.SubPackageDownLoad;
			ELogAuthor author = ELogAuthor.LJQ;
			string message = "update.UpdateResourceProcedure()";
			<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("id", num);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("TotalProgress", resourceDiffUpdater.ViewInfo.TotalSize);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("CurProgress", resourceDiffUpdater.ViewInfo.SavedSize);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("updater", resourceDiffUpdater.Name);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
			resourceDiffUpdater.UpdateResourceProcedure().Forget();
		}
		foreach (ResourceDiffUpdater update in list)
		{
			this.ReportSubPackageDownLoadLogEvent(num, 1, update);
		}
		if (num == 1)
		{
			this.ClearLocalDownLoadList();
			this.ReportSubPackageKeySubPackageLogEvent(0, 1);
			return;
		}
		this.SaveLocalDownLoadList();
	}

	// Token: 0x06016AF7 RID: 92919 RVA: 0x005BEE94 File Offset: 0x005BD094
	public UniTask PushSubPackageDownLoading(List<int> idList, [Nullable(2)] Action callBack = null)
	{
		SubPackageController.<PushSubPackageDownLoading>d__6 <PushSubPackageDownLoading>d__;
		<PushSubPackageDownLoading>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PushSubPackageDownLoading>d__.<>4__this = this;
		<PushSubPackageDownLoading>d__.idList = idList;
		<PushSubPackageDownLoading>d__.callBack = callBack;
		<PushSubPackageDownLoading>d__.<>1__state = -1;
		<PushSubPackageDownLoading>d__.<>t__builder.Start<SubPackageController.<PushSubPackageDownLoading>d__6>(ref <PushSubPackageDownLoading>d__);
		return <PushSubPackageDownLoading>d__.<>t__builder.Task;
	}

	// Token: 0x06016AF8 RID: 92920 RVA: 0x005BEEE8 File Offset: 0x005BD0E8
	[NullableContext(2)]
	public UniTask RestartSubPackageDownLoading(int id, Action callBack = null)
	{
		SubPackageController.<RestartSubPackageDownLoading>d__7 <RestartSubPackageDownLoading>d__;
		<RestartSubPackageDownLoading>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RestartSubPackageDownLoading>d__.<>4__this = this;
		<RestartSubPackageDownLoading>d__.callBack = callBack;
		<RestartSubPackageDownLoading>d__.<>1__state = -1;
		<RestartSubPackageDownLoading>d__.<>t__builder.Start<SubPackageController.<RestartSubPackageDownLoading>d__7>(ref <RestartSubPackageDownLoading>d__);
		return <RestartSubPackageDownLoading>d__.<>t__builder.Task;
	}

	// Token: 0x06016AF9 RID: 92921 RVA: 0x005BEF34 File Offset: 0x005BD134
	public UniTask PrioritySubPackageDownLoading(List<int> idList, [Nullable(2)] Action callBack = null)
	{
		SubPackageController.<PrioritySubPackageDownLoading>d__8 <PrioritySubPackageDownLoading>d__;
		<PrioritySubPackageDownLoading>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PrioritySubPackageDownLoading>d__.<>4__this = this;
		<PrioritySubPackageDownLoading>d__.idList = idList;
		<PrioritySubPackageDownLoading>d__.callBack = callBack;
		<PrioritySubPackageDownLoading>d__.<>1__state = -1;
		<PrioritySubPackageDownLoading>d__.<>t__builder.Start<SubPackageController.<PrioritySubPackageDownLoading>d__8>(ref <PrioritySubPackageDownLoading>d__);
		return <PrioritySubPackageDownLoading>d__.<>t__builder.Task;
	}

	// Token: 0x06016AFA RID: 92922 RVA: 0x005BEF88 File Offset: 0x005BD188
	[NullableContext(2)]
	public void StopSubPackageDownLoading(int id, Action callBack = null)
	{
		if (SubPackageDownLoadModel.Instance.DownLoadingSubPackageId != id || id == 0)
		{
			return;
		}
		SubPackageDownLoadModel.Instance.SetSubPackageDownLoadItemStateMap(id, ESubPackageDownLoadState.Pause);
		foreach (ResourceDiffUpdater resourceDiffUpdater in (SubPackageDownLoadModel.Instance.GetSubPackageDownLoadItemUpdater(id) ?? new List<ResourceDiffUpdater>()))
		{
			resourceDiffUpdater.Stop();
		}
		SubPackageDownLoadModel.Instance.DownLoadingSubPackageId = 0;
		if (callBack != null)
		{
			callBack();
		}
		EventSystem.Instance.Emit(EEventName.OnRefreshSubPackageDownLoadByPriority);
		this.SaveLocalDownLoadList();
	}

	// Token: 0x06016AFB RID: 92923 RVA: 0x005BF030 File Offset: 0x005BD230
	public void CancelSubPackageDownLoading(int id)
	{
		if (SubPackageDownLoadModel.Instance.GetSubPackageDownLoadItemStateById(id) == ESubPackageDownLoadState.Finish)
		{
			return;
		}
		SubPackageDownLoadModel.Instance.SubPackageDownLoadList = (from value in SubPackageDownLoadModel.Instance.SubPackageDownLoadList
		where value != id
		select value).ToList<int>();
		SubPackageDownLoadModel.Instance.SetSubPackageDownLoadItemStateMap(id, ESubPackageDownLoadState.None);
		if (id == SubPackageDownLoadModel.Instance.PauseSubPackageId)
		{
			SubPackageDownLoadModel.Instance.PauseSubPackageId = 0;
			this.DownLoadPackage();
		}
		if (id == SubPackageDownLoadModel.Instance.DownLoadingSubPackageId)
		{
			SubPackageDownLoadModel.Instance.DownLoadingSubPackageId = 0;
			this.DownLoadPackage();
		}
		foreach (ResourceDiffUpdater resourceDiffUpdater in (SubPackageDownLoadModel.Instance.GetSubPackageDownLoadItemUpdater(id) ?? new List<ResourceDiffUpdater>()))
		{
			resourceDiffUpdater.Stop();
		}
		EventSystem.Instance.Emit(EEventName.OnRefreshSubPackageDownLoadByPriority);
		this.SaveLocalDownLoadList();
	}

	// Token: 0x06016AFC RID: 92924 RVA: 0x005BF14C File Offset: 0x005BD34C
	public void CancelSubPackageDownLoadingList(List<int> idList)
	{
		List<int> list = new List<int>();
		foreach (int num in SubPackageDownLoadModel.Instance.SubPackageDownLoadList)
		{
			if (!idList.Contains(num) && SubPackageDownLoadModel.Instance.GetSubPackageDownLoadItemStateById(num) != ESubPackageDownLoadState.Finish)
			{
				list.Add(num);
			}
		}
		SubPackageDownLoadModel.Instance.SubPackageDownLoadList = list;
		foreach (int num2 in idList)
		{
			if (SubPackageDownLoadModel.Instance.GetSubPackageDownLoadItemStateById(num2) != ESubPackageDownLoadState.Finish)
			{
				SubPackageDownLoadModel.Instance.SetSubPackageDownLoadItemStateMap(num2, ESubPackageDownLoadState.None);
				if (num2 == SubPackageDownLoadModel.Instance.PauseSubPackageId)
				{
					SubPackageDownLoadModel.Instance.PauseSubPackageId = 0;
					this.DownLoadPackage();
				}
				if (num2 == SubPackageDownLoadModel.Instance.DownLoadingSubPackageId)
				{
					SubPackageDownLoadModel.Instance.DownLoadingSubPackageId = 0;
					this.DownLoadPackage();
				}
				foreach (ResourceDiffUpdater resourceDiffUpdater in (SubPackageDownLoadModel.Instance.GetSubPackageDownLoadItemUpdater(num2) ?? new List<ResourceDiffUpdater>()))
				{
					resourceDiffUpdater.Stop();
				}
			}
		}
		EventSystem.Instance.Emit(EEventName.OnRefreshSubPackageDownLoadByPriority);
		this.SaveLocalDownLoadList();
	}

	// Token: 0x06016AFD RID: 92925 RVA: 0x005BF2C4 File Offset: 0x005BD4C4
	public unsafe void DeleteUnneededResource(bool isAutoClear)
	{
		this.ReportSubPackageClearSpaceLogEvent();
		List<int> finishQuestList = QuestNewModel.Instance.GetFinishQuestList();
		HashSet<int> protectedQuestIds = isAutoClear ? SubPackageDownLoadModel.Instance.GetRecallProtectedQuestIds() : new HashSet<int>();
		List<int> list = (protectedQuestIds.Count > 0) ? (from questId in finishQuestList
		where !protectedQuestIds.Contains(questId)
		select questId).ToList<int>() : finishQuestList;
		if (protectedQuestIds.Count > 0)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.SubPackageDownLoad;
			ELogAuthor author = ELogAuthor.LJQ;
			string message = "自动清理可删除资源-剔除受保护回顾任务";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("protectedQuestIds", string.Join<int>(",", protectedQuestIds));
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("clearQuestCount", list.Count);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		}
		ResourceManagerController.Instance.DeleteUnneededResource(list);
		if (!isAutoClear)
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("SubPackageDownLoad_Clear_Tips", Array.Empty<object>());
		}
		this.ReportSubPackageClearSpaceFinishLogEvent(isAutoClear);
	}

	// Token: 0x06016AFE RID: 92926 RVA: 0x005BF3D0 File Offset: 0x005BD5D0
	[NullableContext(0)]
	private UniTask<bool> IsNotUseCellData()
	{
		SubPackageController.<IsNotUseCellData>d__13 <IsNotUseCellData>d__;
		<IsNotUseCellData>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<IsNotUseCellData>d__.<>4__this = this;
		<IsNotUseCellData>d__.<>1__state = -1;
		<IsNotUseCellData>d__.<>t__builder.Start<SubPackageController.<IsNotUseCellData>d__13>(ref <IsNotUseCellData>d__);
		return <IsNotUseCellData>d__.<>t__builder.Task;
	}

	// Token: 0x06016AFF RID: 92927 RVA: 0x005BF414 File Offset: 0x005BD614
	private unsafe void OnNetworkTypeChange(byte newType)
	{
		int downLoadingId = SubPackageDownLoadModel.Instance.DownLoadingSubPackageId;
		if (PlayerInfoModel.Instance.GetId().GetValueOrDefault() > 0)
		{
			bool player = LocalStorage.GetPlayer<bool>(ELocalStoragePlayerKey.SubDownLoadAgreeUseCellData, false);
			Log instance = Log.Instance;
			ELogModule module = ELogModule.SubPackageDownLoad;
			ELogAuthor author = ELogAuthor.LJQ;
			string message = "OnNetworkTypeChange";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("newType", newType);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("downLoadingId", downLoadingId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("isAgreeUseCell", player);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			if (newType != 4 && downLoadingId != 0 && !player)
			{
				this.StopSubPackageDownLoading(downLoadingId, null);
				ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.SubPackageDownloadCellNetworkConfirm);
				confirmBoxDataNew.FunctionMap.Add(1, delegate
				{
					ConfirmBoxController.Instance.CloseConfirmBoxView();
				});
				confirmBoxDataNew.FunctionMap.Add(2, delegate
				{
					LocalStorage.SetPlayer<bool>(ELocalStoragePlayerKey.SubDownLoadAgreeUseCellData, true);
					EventSystem.Instance.Emit(EEventName.OnRefreshSubPackUseCellData);
					this.RestartSubPackageDownLoading(downLoadingId, null).Forget();
				});
				ConfirmBoxController.Instance.ShowNetWorkConfirmBoxView(confirmBoxDataNew, null);
			}
			return;
		}
		Log instance2 = Log.Instance;
		ELogModule module2 = ELogModule.SubPackageDownLoad;
		ELogAuthor author2 = ELogAuthor.LJQ;
		string message2 = "OnNetworkTypeChange,playerId未设置";
		<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray3<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("newType", newType);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("downLoadingId", downLoadingId);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("AgreeUseCell", this.AgreeUseCell);
		instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 3));
		if (newType == 3 && downLoadingId != 0 && !this.AgreeUseCell.GetValueOrDefault())
		{
			this.StopSubPackageDownLoading(downLoadingId, null);
			ConfirmBoxDataNew confirmBoxDataNew2 = new ConfirmBoxDataNew(EConfirmBoxConfigId.SubPackageDownloadCellNetworkConfirm);
			confirmBoxDataNew2.FunctionMap.Add(1, delegate
			{
				AppUtil.QuitGame("DownloadSubPackageNotAllowedInCellNetwork");
			});
			confirmBoxDataNew2.FunctionMap.Add(2, delegate
			{
				this.AgreeUseCell = new bool?(true);
				this.RestartSubPackageDownLoading(downLoadingId, null).Forget();
			});
			ConfirmBoxController.Instance.ShowNetWorkConfirmBoxView(confirmBoxDataNew2, null);
			return;
		}
		if ((newType == 0 || newType == 1 || newType == 2) && downLoadingId != 0)
		{
			this.StopSubPackageDownLoading(downLoadingId, null);
			this.ShowDownloadSubPackageNetFailedConfirm(downLoadingId);
		}
	}

	// Token: 0x06016B00 RID: 92928 RVA: 0x005BF69C File Offset: 0x005BD89C
	public void ShowDownloadSubPackageNetFailedConfirm(int downLoadingId)
	{
		ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.LoginResDownLoadFailedConfirm);
		confirmBoxDataNew.FunctionMap.Add(1, delegate
		{
			AppUtil.QuitGame("DownloadSubPackageNetFailed");
		});
		confirmBoxDataNew.FunctionMap.Add(2, delegate
		{
			ENetworkType networkType = (ENetworkType)SubPackageDownLoadModel.Instance.NetworkListener.GetNetworkType();
			if (networkType == ENetworkType.Unknown || networkType == ENetworkType.None || networkType == ENetworkType.AirplaneMode)
			{
				this.ShowDownloadSubPackageNetFailedConfirm(downLoadingId);
				return;
			}
			this.RestartSubPackageDownLoading(downLoadingId, null).Forget();
		});
		ConfirmBoxController.Instance.ShowNetWorkConfirmBoxView(confirmBoxDataNew, null);
	}

	// Token: 0x06016B01 RID: 92929 RVA: 0x005BF718 File Offset: 0x005BD918
	public void AutoDownLoadKeySubPackage()
	{
		this.PrioritySubPackageDownLoading(new List<int>
		{
			1
		}, null).Forget();
		if (PlayerInfoModel.Instance.GetId().GetValueOrDefault() <= 0)
		{
			return;
		}
		if (!LocalStorage.GetPlayer<bool>(ELocalStoragePlayerKey.SubDownLoadAgreeUseCellData, false) && SubPackageDownLoadModel.Instance.NetworkListener.GetNetworkType() == 3)
		{
			SubPackageDownLoadModel.Instance.SetSubPackageDownLoadItemStateMap(1, ESubPackageDownLoadState.Pause);
			EventSystem.Instance.Emit(EEventName.OnRefreshSubPackageDownLoadByPriority);
		}
	}

	// Token: 0x06016B02 RID: 92930 RVA: 0x005BF794 File Offset: 0x005BD994
	protected override void OnRegisterNetEvent()
	{
		Net.Instance.Register(ENotifyMessageId.SceneBlockSplitHumanChangleNotify, new Action<IMessage, Net.CallbackStatus>(this.SceneBlockSplitHumanChangleNotify));
		Net.Instance.Register(ENotifyMessageId.SceneBlockSplitHumanFullNotify, new Action<IMessage, Net.CallbackStatus>(this.SceneBlockSplitHumanFullNotify));
		Net.Instance.Register(ENotifyMessageId.SceneBlockSplitHumanSwitchStateNotify, new Action<IMessage, Net.CallbackStatus>(this.SceneBlockSplitHumanSwitchStateNotify));
		Net.Instance.Register(ENotifyMessageId.SceneBlockSplitPopWindowNotify, new Action<IMessage, Net.CallbackStatus>(this.SceneBlockSplitPopWindowNotify));
	}

	// Token: 0x06016B03 RID: 92931 RVA: 0x005BF814 File Offset: 0x005BDA14
	protected override void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.SceneBlockSplitHumanChangleNotify);
		Net.Instance.UnRegister(ENotifyMessageId.SceneBlockSplitHumanFullNotify);
		Net.Instance.UnRegister(ENotifyMessageId.SceneBlockSplitHumanSwitchStateNotify);
		Net.Instance.UnRegister(ENotifyMessageId.SceneBlockSplitPopWindowNotify);
	}

	// Token: 0x06016B04 RID: 92932 RVA: 0x005BF864 File Offset: 0x005BDA64
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add(EEventName.EnterAreaNotify, new Action<int>(this.EnterAreaNotify));
		EventSystem.Instance.Add(EEventName.OnRoleChangeEnd, new Action(this.OnRoleChangeEnd));
		EventSystem.Instance.Add(EEventName.WorldDoneAndCloseLoading, new Action(this.WorldDoneAndCloseLoading));
		SubPackageDownLoadModel.Instance.NetworkListener.NetworkChangeDelegate.Add(new Action<byte>(this.OnNetworkTypeChange));
	}

	// Token: 0x06016B05 RID: 92933 RVA: 0x005BF8E8 File Offset: 0x005BDAE8
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.EnterAreaNotify, new Action<int>(this.EnterAreaNotify));
		EventSystem.Instance.Remove(EEventName.OnRoleChangeEnd, new Action(this.OnRoleChangeEnd));
		EventSystem.Instance.Remove(EEventName.WorldDoneAndCloseLoading, new Action(this.WorldDoneAndCloseLoading));
		SubPackageDownLoadModel.Instance.NetworkListener.NetworkChangeDelegate.Clear();
	}

	// Token: 0x06016B06 RID: 92934 RVA: 0x005BF95D File Offset: 0x005BDB5D
	[NullableContext(2)]
	private void SceneBlockSplitHumanChangleNotify(IMessage msg, Net.CallbackStatus status)
	{
	}

	// Token: 0x06016B07 RID: 92935 RVA: 0x005BF95F File Offset: 0x005BDB5F
	[NullableContext(2)]
	private void SceneBlockSplitHumanFullNotify(IMessage msg, Net.CallbackStatus status)
	{
	}

	// Token: 0x06016B08 RID: 92936 RVA: 0x005BF961 File Offset: 0x005BDB61
	[NullableContext(2)]
	private void SceneBlockSplitHumanSwitchStateNotify(IMessage msg, Net.CallbackStatus status)
	{
	}

	// Token: 0x06016B09 RID: 92937 RVA: 0x005BF964 File Offset: 0x005BDB64
	[NullableContext(2)]
	private void SceneBlockSplitPopWindowNotify(IMessage msg, Net.CallbackStatus status)
	{
		SceneBlockSplitPopWindowNotify sceneBlockSplitPopWindowNotify = (SceneBlockSplitPopWindowNotify)msg;
		int blockId = sceneBlockSplitPopWindowNotify.BlockId;
		if (ResourceManagerController.Instance.IsNeedReOpenMap(blockId))
		{
			SubPackageDownLoadModel.Instance.OpenBlockNeedReLoginConfirm();
			return;
		}
		SubPackageDownLoadModel.Instance.OpenSubPackageDownLoadConfirm("SubPackageDownLoad_CommonLock_Confirm", new List<int>
		{
			sceneBlockSplitPopWindowNotify.BlockId
		}, null, null);
	}

	// Token: 0x06016B0A RID: 92938 RVA: 0x005BF9CC File Offset: 0x005BDBCC
	public void SceneBlockChangePush(List<int> downloadBlockIdList, [Nullable(2)] List<int> deleteBlockIdList = null)
	{
		SceneBlockChangePush sceneBlockChangePush = Aki.Protocol.SceneBlockChangePush.Create();
		sceneBlockChangePush.DownloadBlockId.AddRange(downloadBlockIdList);
		if (deleteBlockIdList != null)
		{
			sceneBlockChangePush.DeleteBlockId.AddRange(deleteBlockIdList);
		}
		Net.Instance.Send(EPushMessageId.SceneBlockChangePush, sceneBlockChangePush);
	}

	// Token: 0x06016B0B RID: 92939 RVA: 0x005BFA0C File Offset: 0x005BDC0C
	public void SceneBlockSplitClientLoginPush(List<int> downloadBlockIdList)
	{
		SceneBlockSplitClientLoginPush sceneBlockSplitClientLoginPush = Aki.Protocol.SceneBlockSplitClientLoginPush.Create();
		sceneBlockSplitClientLoginPush.DownloadBlockId.AddRange(downloadBlockIdList);
		Net.Instance.Send(EPushMessageId.SceneBlockSplitClientLoginPush, sceneBlockSplitClientLoginPush);
	}

	// Token: 0x06016B0C RID: 92940 RVA: 0x005BFA3C File Offset: 0x005BDC3C
	public void DownLoadFinish()
	{
		int subPackage = SubPackageDownLoadModel.Instance.DownLoadingSubPackageId;
		if (subPackage == 0)
		{
			return;
		}
		using (List<ResourceDiffUpdater>.Enumerator enumerator = (SubPackageDownLoadModel.Instance.GetSubPackageDownLoadItemUpdater(subPackage) ?? new List<ResourceDiffUpdater>()).GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (!enumerator.Current.IsCompleteDownloaded())
				{
					return;
				}
			}
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.SubPackageDownLoad;
		ELogAuthor author = ELogAuthor.LJQ;
		string message = "DownLoadFinish";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", subPackage);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		if (subPackage == 1 && GameModeModel.Instance.WorldDone)
		{
			SubPackageDownLoadModel.Instance.UpdaterDownLoadSize();
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.SubPackageDownloadListFinishConfirm);
			confirmBoxDataNew.FunctionMap.Add(1, delegate
			{
				ConfirmBoxController.Instance.CloseConfirmBoxView();
			});
			confirmBoxDataNew.FunctionMap.Add(2, delegate
			{
				if (UiManager.Instance.IsViewOpen(EUiViewName.SubPackageDownLoadView))
				{
					UiManager.Instance.CloseView(EUiViewName.SubPackageDownLoadView, null);
				}
				CustomPromise loginPrepareResCheckPromise = ResourceManagerController.Instance.LoginPrepareResCheckPromise;
				if (loginPrepareResCheckPromise == null)
				{
					return;
				}
				loginPrepareResCheckPromise.SetResult();
			});
			ConfirmBoxController.Instance.ShowNetWorkConfirmBoxView(confirmBoxDataNew, null);
		}
		SubPackageDownLoadModel.Instance.SetSubPackageDownLoadItemStateMap(subPackage, ESubPackageDownLoadState.Finish);
		SubPackageDownLoadModel.Instance.SubPackageDownLoadList = (from value in SubPackageDownLoadModel.Instance.SubPackageDownLoadList
		where value != subPackage
		select value).ToList<int>();
		if (!SubPackageDefine.IsDynamicRecallId(subPackage))
		{
			DownLoadSubPackage value2 = SubPackageConfig.Instance.GetDownLoadSubPackageById(subPackage).Value;
			if (value2.Type == 4)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("SubPackageDownLoad_Gender_Tips", Array.Empty<object>());
			}
			else
			{
				bool flag = false;
				if (value2.Type == 2)
				{
					List<int> list = new List<int>();
					foreach (int num in value2.Area())
					{
						if (!ResourceManagerController.Instance.IsNeedReOpenMap(num))
						{
							list.Add(num);
							flag = true;
						}
					}
					this.SceneBlockChangePush(list, null);
				}
				if (GameModeModel.Instance.WorldDone)
				{
					string localTextNew = ConfigMultiTextLang.GetLocalTextNew(value2.Title, null);
					if (!flag)
					{
						ScrollingTipsController.Instance.ShowTipsByTextId("SubPackageDownLoad_Finish_Tips", new object[]
						{
							localTextNew
						});
					}
					else
					{
						ScrollingTipsController.Instance.ShowTipsByTextId("SubPackageDownLoad_Finish_Restart_Tips", new object[]
						{
							localTextNew
						});
					}
				}
			}
		}
		else
		{
			RecallConfig? recallConfig;
			string localTextNew2 = ConfigMultiTextLang.GetLocalTextNew(((ConfigRecallConfigByRecallId.GetConfig(SubPackageDefine.RecallIdFromDynamic(subPackage), true) != null) ? recallConfig.GetValueOrDefault().QuestName : null) ?? "", null);
			ScrollingTipsController.Instance.ShowTipsByTextId("SubPackageDownLoad_Finish_Tips", new object[]
			{
				localTextNew2
			});
		}
		ResourceManagerController.Instance.UpdateServerQuestState();
		SubPackageDownLoadModel.Instance.DownLoadingSubPackageId = 0;
		this.DownLoadPackage();
		EventSystem.Instance.Emit(EEventName.OnRefreshSubPackageDownLoadByPriority);
		this.SaveLocalDownLoadList();
	}

	// Token: 0x06016B0D RID: 92941 RVA: 0x005BFD50 File Offset: 0x005BDF50
	private void EnterAreaNotify(int areaId)
	{
		if (ConfirmBoxController.Instance.CheckIsConfirmBoxOpen())
		{
			return;
		}
		int blockBelongToSubPackage = SubPackageDownLoadModel.Instance.GetBlockBelongToSubPackage(areaId);
		if (SubPackageDownLoadModel.Instance.GetSubPackageDownLoadItemStateById(blockBelongToSubPackage) != ESubPackageDownLoadState.DownLoading)
		{
			if (!this.CheckBlockHaveDownLoad(areaId))
			{
				SubPackageDownLoadModel.Instance.OpenSubPackageDownLoadConfirm("SubPackageDownLoad_CommonLock_Confirm", new List<int>
				{
					areaId
				}, null, new double?((double)this.ENTER_AREA_CD));
			}
			if (ResourceManagerController.Instance.IsNeedReOpenMap(areaId))
			{
				SubPackageDownLoadModel.Instance.OpenBlockNeedReLoginConfirm();
			}
			return;
		}
		float? nextCanShowTipsTime = this.NextCanShowTipsTime;
		double? num = (nextCanShowTipsTime != null) ? new double?((double)nextCanShowTipsTime.GetValueOrDefault()) : null;
		double serverTimeStamp = TimeUtil.Instance.GetServerTimeStamp();
		if (num.GetValueOrDefault() > serverTimeStamp & num != null)
		{
			return;
		}
		this.NextCanShowTipsTime = new float?((float)TimeUtil.Instance.GetServerTimeStamp() + this.ENTER_AREA_CD);
		ScrollingTipsController.Instance.ShowTipsByTextId("SubPackageDownLoad_Downloading", Array.Empty<object>());
	}

	// Token: 0x06016B0E RID: 92942 RVA: 0x005BFE51 File Offset: 0x005BE051
	private void OnRoleChangeEnd()
	{
		if (!ResourceDiffUpdaterManager.Instance.IsGrayBoxHit())
		{
			return;
		}
		ResourceManagerController.Instance.UpdateServerQuestState();
	}

	// Token: 0x06016B0F RID: 92943 RVA: 0x005BFE6C File Offset: 0x005BE06C
	private void WorldDoneAndCloseLoading()
	{
		this.DeleteUnneededResourceOnInit();
		if (!ResourceDiffUpdaterManager.Instance.IsGrayBoxHit())
		{
			return;
		}
		if (HotFixManager.HandleAutoClear)
		{
			LocalStorage.SetPlayer<bool>(ELocalStoragePlayerKey.SubDownLoadClearOnLogin, true);
			HotFixManager.HandleAutoClear = false;
		}
		List<int> player = LocalStorage.GetPlayer<List<int>>(ELocalStoragePlayerKey.SubDownLoadLastDownLoadList, null);
		if (player == null || player.Count <= 0)
		{
			return;
		}
		foreach (int num in player)
		{
			if (!SubPackageDefine.IsDynamicRecallId(num) && SubPackageDownLoadModel.Instance.GetSubPackageDownLoadItemStateById(num) != ESubPackageDownLoadState.Finish && num != SubPackageDownLoadModel.Instance.DownLoadingSubPackageId && num != SubPackageDownLoadModel.Instance.PauseSubPackageId && !SubPackageDownLoadModel.Instance.SubPackageDownLoadList.Contains(num))
			{
				SubPackageDownLoadModel.Instance.SubPackageDownLoadList.Add(num);
				SubPackageDownLoadModel.Instance.SetSubPackageDownLoadItemStateMap(num, ESubPackageDownLoadState.Waiting);
			}
		}
		if (SubPackageDownLoadModel.Instance.PauseSubPackageId == 0)
		{
			this.DownLoadPackage();
		}
		EventSystem.Instance.Emit(EEventName.OnRefreshSubPackageDownLoadByPriority);
		this.SaveLocalDownLoadList();
	}

	// Token: 0x06016B10 RID: 92944 RVA: 0x005BFF80 File Offset: 0x005BE180
	public bool CheckBlockHaveDownLoad(int blockId)
	{
		if (!ResourceDiffUpdaterManager.Instance.IsGrayBoxHit())
		{
			return true;
		}
		int blockBelongToSubPackage = SubPackageDownLoadModel.Instance.GetBlockBelongToSubPackage(blockId);
		return SubPackageDownLoadModel.Instance.GetSubPackageDownLoadItemStateById(blockBelongToSubPackage) == ESubPackageDownLoadState.Finish;
	}

	// Token: 0x06016B11 RID: 92945 RVA: 0x005BFFB8 File Offset: 0x005BE1B8
	public void SaveLocalDownLoadList()
	{
		if (PlayerInfoModel.Instance.GetId().GetValueOrDefault() <= 0)
		{
			Log.Instance.Info(ELogModule.SubPackageDownLoad, ELogAuthor.LJQ, "SaveLocalDownLoadList,尚未登录直接返回", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		List<int> list = new List<int>();
		list.AddRange(from id in SubPackageDownLoadModel.Instance.SubPackageDownLoadList
		where !SubPackageDefine.IsDynamicRecallId(id)
		select id);
		int downLoadingSubPackageId = SubPackageDownLoadModel.Instance.DownLoadingSubPackageId;
		if (downLoadingSubPackageId != 0 && !SubPackageDefine.IsDynamicRecallId(downLoadingSubPackageId))
		{
			list.Insert(0, downLoadingSubPackageId);
		}
		LocalStorage.SetPlayer<List<int>>(ELocalStoragePlayerKey.SubDownLoadLastDownLoadList, list);
	}

	// Token: 0x06016B12 RID: 92946 RVA: 0x005C0060 File Offset: 0x005BE260
	public void ClearLocalDownLoadList()
	{
		if (PlayerInfoModel.Instance.GetId().GetValueOrDefault() <= 0)
		{
			Log.Instance.Info(ELogModule.SubPackageDownLoad, ELogAuthor.LJQ, "ClearLocalDownLoadList,尚未登录直接返回", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		LocalStorage.SetPlayer<List<int>>(ELocalStoragePlayerKey.SubDownLoadLastDownLoadList, new List<int>());
	}

	// Token: 0x06016B13 RID: 92947 RVA: 0x005C00B4 File Offset: 0x005BE2B4
	public void ReportSubPackageKeySubPackageLogEvent(int time, int state)
	{
		SubPackageKeySubPackageLogEvent subPackageKeySubPackageLogEvent = new SubPackageKeySubPackageLogEvent();
		subPackageKeySubPackageLogEvent.i_download_time = time;
		subPackageKeySubPackageLogEvent.i_download_status = state;
		subPackageKeySubPackageLogEvent.o_phantoms = SubPackageDownLoadModel.Instance.KeyIncludeSubPackageList;
		LogReportController.Instance.LogReport(subPackageKeySubPackageLogEvent);
	}

	// Token: 0x06016B14 RID: 92948 RVA: 0x005C00F0 File Offset: 0x005BE2F0
	public void ReportSubPackageDownLoadLogEvent(int subPackageId, int state, ResourceDiffUpdater update)
	{
		SubPackageDownLoadLogEvent subPackageDownLoadLogEvent = new SubPackageDownLoadLogEvent();
		subPackageDownLoadLogEvent.s_suit_name = update.Name;
		subPackageDownLoadLogEvent.b_if_storage_alert = SubPackageDownLoadModel.Instance.HaveTipsOutOfSpaceList.Contains(subPackageId);
		subPackageDownLoadLogEvent.i_peak_speed = (int)((double)update.ViewInfo.DownloadSpeedMax / 1048576.0);
		subPackageDownLoadLogEvent.i_download_time = 0;
		subPackageDownLoadLogEvent.i_download_status = state;
		DownLoadSubPackage? downLoadSubPackage = SubPackageDefine.IsDynamicRecallId(subPackageId) ? null : SubPackageConfig.Instance.GetDownLoadSubPackageById(subPackageId);
		subPackageDownLoadLogEvent.i_resource_type = ((downLoadSubPackage != null) ? downLoadSubPackage.Value.Type : 0);
		subPackageDownLoadLogEvent.i_resource_size = (int)((double)update.ViewInfo.TotalSize / 1048576.0);
		subPackageDownLoadLogEvent.i_state = (GameModeModel.Instance.WorldDone ? 2 : 1);
		subPackageDownLoadLogEvent.i_role_id = ((PlayerInfoModel.Instance.GetPlayerGender() == EPlayerGender.Male) ? 1 : 2);
		LogReportController.Instance.LogReport(subPackageDownLoadLogEvent);
	}

	// Token: 0x06016B15 RID: 92949 RVA: 0x005C01E8 File Offset: 0x005BE3E8
	public void ReportSubPackageOutOfSpaceLogEvent(int subPackageId, long requiredSpace, long remainingSpace)
	{
		SubPackageOutOfSpaceLogEvent subPackageOutOfSpaceLogEvent = new SubPackageOutOfSpaceLogEvent();
		subPackageOutOfSpaceLogEvent.s_suit_name = subPackageId.ToString();
		subPackageOutOfSpaceLogEvent.b_if_storage_alert = SubPackageDownLoadModel.Instance.HaveTipsOutOfSpaceList.Contains(subPackageId);
		DownLoadSubPackage? downLoadSubPackage = SubPackageDefine.IsDynamicRecallId(subPackageId) ? null : SubPackageConfig.Instance.GetDownLoadSubPackageById(subPackageId);
		subPackageOutOfSpaceLogEvent.i_resource_type = ((downLoadSubPackage != null) ? downLoadSubPackage.Value.Type : 0);
		subPackageOutOfSpaceLogEvent.i_required_space = (int)((double)requiredSpace / 1048576.0);
		subPackageOutOfSpaceLogEvent.i_remaining_space = (int)((double)remainingSpace / 1048576.0);
		subPackageOutOfSpaceLogEvent.i_role_id = ((PlayerInfoModel.Instance.GetPlayerGender() == EPlayerGender.Male) ? 1 : 2);
		LogReportController.Instance.LogReport(subPackageOutOfSpaceLogEvent);
	}

	// Token: 0x06016B16 RID: 92950 RVA: 0x005C02A8 File Offset: 0x005BE4A8
	public void ReportRecallDownLoadDialogLogEvent(int recallId, long needSize)
	{
		this.RecallDownLoadTraceId = new Random().Next(0, 1000000);
		RecallDownLoadDialogLogEvent recallDownLoadDialogLogEvent = new RecallDownLoadDialogLogEvent();
		recallDownLoadDialogLogEvent.i_recall_id = recallId;
		recallDownLoadDialogLogEvent.b_if_storage_alert = SubPackageDownLoadModel.Instance.HaveTipsOutOfSpaceList.Contains(SubPackageDefine.GetDynamicRecallId(recallId));
		recallDownLoadDialogLogEvent.i_required_space = (int)((double)needSize / 1048576.0);
		recallDownLoadDialogLogEvent.i_remaining_space = (int)((double)VideoResUpdate.Instance.GetFreeSpace() / 1048576.0);
		recallDownLoadDialogLogEvent.s_trace_id = this.RecallDownLoadTraceId.ToString();
		LogReportController.Instance.LogReport(recallDownLoadDialogLogEvent);
	}

	// Token: 0x06016B17 RID: 92951 RVA: 0x005C0340 File Offset: 0x005BE540
	public void ReportSubPackageClearSpaceLogEvent()
	{
		SubPackageClearSpaceLogEvent subPackageClearSpaceLogEvent = new SubPackageClearSpaceLogEvent();
		bool player = LocalStorage.GetPlayer<bool>(ELocalStoragePlayerKey.SubDownLoadClearOnLogin, false);
		subPackageClearSpaceLogEvent.b_if_storage_alert = player;
		subPackageClearSpaceLogEvent.i_required_space = (int)((double)SubPackageDownLoadModel.Instance.GetSubPackageCanClearSpace() / 1048576.0);
		LogReportController.Instance.LogReport(subPackageClearSpaceLogEvent);
	}

	// Token: 0x06016B18 RID: 92952 RVA: 0x005C0390 File Offset: 0x005BE590
	public void ReportSubPackageClearSpaceFinishLogEvent(bool isAuto)
	{
		SubPackageClearSpaceFinishLogEvent subPackageClearSpaceFinishLogEvent = new SubPackageClearSpaceFinishLogEvent();
		subPackageClearSpaceFinishLogEvent.b_if_storage_alert = isAuto;
		subPackageClearSpaceFinishLogEvent.i_required_space = (int)((double)SubPackageDownLoadModel.Instance.GetSubPackageCanClearSpace() / 1048576.0);
		subPackageClearSpaceFinishLogEvent.i_remaining_space = (int)((double)VideoResUpdate.Instance.GetFreeSpace() / 1048576.0);
		LogReportController.Instance.LogReport(subPackageClearSpaceFinishLogEvent);
	}

	// Token: 0x06016B19 RID: 92953 RVA: 0x005C03F0 File Offset: 0x005BE5F0
	public void ReportInitialMobileResCleanUpViewLogEvent(int canCleanSpace, int type)
	{
		InitialMobileResCleanUpViewLogEvent initialMobileResCleanUpViewLogEvent = new InitialMobileResCleanUpViewLogEvent();
		initialMobileResCleanUpViewLogEvent.i_remaining_space = canCleanSpace;
		initialMobileResCleanUpViewLogEvent.i_type = type;
		initialMobileResCleanUpViewLogEvent.s_trace_id = this.MobileResCleanUpTraceId.ToString();
		initialMobileResCleanUpViewLogEvent.unique_id = LoginModel.Instance.GetLoginUid();
		int? num;
		initialMobileResCleanUpViewLogEvent.player_id = (((PlayerInfoModel.Instance.GetId() != null) ? num.GetValueOrDefault().ToString() : null) ?? "");
		LogReportController.Instance.LogReport(initialMobileResCleanUpViewLogEvent);
	}

	// Token: 0x06016B1A RID: 92954 RVA: 0x005C0474 File Offset: 0x005BE674
	public void ReportMobileResCleanUpLogEvent(int selectSpace, List<MobileResCleanUpLogEventContentData> content, int type)
	{
		MobileResCleanUpLogEvent mobileResCleanUpLogEvent = new MobileResCleanUpLogEvent();
		mobileResCleanUpLogEvent.i_required_space = selectSpace;
		mobileResCleanUpLogEvent.o_content = content;
		mobileResCleanUpLogEvent.i_type = type;
		mobileResCleanUpLogEvent.s_trace_id = this.MobileResCleanUpTraceId.ToString();
		mobileResCleanUpLogEvent.unique_id = LoginModel.Instance.GetLoginUid();
		int? num;
		mobileResCleanUpLogEvent.player_id = (((PlayerInfoModel.Instance.GetId() != null) ? num.GetValueOrDefault().ToString() : null) ?? "");
		LogReportController.Instance.LogReport(mobileResCleanUpLogEvent);
	}

	// Token: 0x06016B1B RID: 92955 RVA: 0x005C0500 File Offset: 0x005BE700
	public void ReportMobileResCleanUpFinishLogEvent()
	{
		MobileResCleanUpFinishLogEvent mobileResCleanUpFinishLogEvent = new MobileResCleanUpFinishLogEvent();
		mobileResCleanUpFinishLogEvent.s_trace_id = this.MobileResCleanUpTraceId.ToString();
		mobileResCleanUpFinishLogEvent.unique_id = LoginModel.Instance.GetLoginUid();
		int? num;
		mobileResCleanUpFinishLogEvent.player_id = (((PlayerInfoModel.Instance.GetId() != null) ? num.GetValueOrDefault().ToString() : null) ?? "");
		LogReportController.Instance.LogReport(mobileResCleanUpFinishLogEvent);
	}

	// Token: 0x06016B1C RID: 92956 RVA: 0x005C0574 File Offset: 0x005BE774
	public unsafe void ClearSubPackage(List<int> sceneIdList, bool clearVideo)
	{
		HashSet<int> clearedCandidates = SubPackageDownLoadModel.Instance.SnapshotRecallIdsWithLocalVideoData();
		int num = clearVideo ? ((int)SubPackageDownLoadModel.Instance.GetCanCleanVideoSpace()) : 0;
		foreach (int id in sceneIdList)
		{
			num += (int)SubPackageDownLoadModel.Instance.GetSubPackageHaveDownLoadSpace(id);
		}
		List<MobileResCleanUpLogEventContentData> list = new List<MobileResCleanUpLogEventContentData>();
		HashSet<string> hashSet = new HashSet<string>();
		foreach (int id2 in sceneIdList)
		{
			this.CancelSubPackageDownLoading(id2);
			foreach (int num2 in SubPackageConfig.Instance.GetDownLoadSubPackageById(id2).Value.AreaIter())
			{
				string blockPackName = ResourceDiffUpdaterManager.Instance.BlockModule.GetBlockPackName(num2);
				if (blockPackName != null)
				{
					hashSet.Add(blockPackName);
					list.Add(new MobileResCleanUpLogEventContentData
					{
						Type = 1,
						Id = num2
					});
				}
			}
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.SubPackageDownLoad;
		ELogAuthor author = ELogAuthor.LJQ;
		string message = "ClearSubPackage";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("sceneIdList", sceneIdList);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("packNameSet", hashSet);
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		ResourceDiffUpdaterManager.Instance.BlockModule.Delete(hashSet.ToList<string>());
		if (clearVideo)
		{
			List<int> finishQuestList = QuestNewModel.Instance.GetFinishQuestList();
			HashSet<int> unusedVideos = ResourceDiffUpdaterManager.Instance.VideoModule.GetUnusedVideos(new HashSet<int>(finishQuestList));
			foreach (int id3 in unusedVideos)
			{
				list.Add(new MobileResCleanUpLogEventContentData
				{
					Type = 2,
					Id = id3
				});
			}
			ResourceDiffUpdaterManager.Instance.VideoModule.DeleteByVideoIds(unusedVideos);
		}
		this.ReportMobileResCleanUpLogEvent(num, list, 2);
		this.ReportMobileResCleanUpFinishLogEvent();
		SubPackageDownLoadModel.Instance.RefreshRecallDynamicItemsByStorage(clearedCandidates).Forget();
		EventSystem.Instance.Emit(EEventName.OnRefreshSubPackClearData);
	}

	// Token: 0x17001E38 RID: 7736
	// (get) Token: 0x06016B1D RID: 92957 RVA: 0x005C07FC File Offset: 0x005BE9FC
	public static SubPackageController Instance
	{
		get
		{
			return SubPackageController._Instance;
		}
	}

	// Token: 0x06016B1E RID: 92958 RVA: 0x005C0803 File Offset: 0x005BEA03
	public static SubPackageController GetOrCreateInstance()
	{
		if (SubPackageController._Instance == null)
		{
			SubPackageController.CreateInstance();
		}
		return SubPackageController._Instance;
	}

	// Token: 0x06016B1F RID: 92959 RVA: 0x005C0817 File Offset: 0x005BEA17
	public static bool CreateInstance()
	{
		if (SubPackageController._Instance != null)
		{
			return true;
		}
		SubPackageController._Instance = new SubPackageController();
		return true;
	}

	// Token: 0x06016B20 RID: 92960 RVA: 0x005C082D File Offset: 0x005BEA2D
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06016B21 RID: 92961 RVA: 0x005C082F File Offset: 0x005BEA2F
	public static void ResetStaticDefaultValue()
	{
		SubPackageController._Instance = null;
	}

	// Token: 0x06016B22 RID: 92962 RVA: 0x005C0837 File Offset: 0x005BEA37
	static SubPackageController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(SubPackageController.CreateStaticDefaultValue), new Action(SubPackageController.ResetStaticDefaultValue));
	}

	// Token: 0x0400A856 RID: 43094
	public float ENTER_AREA_CD = 10000f;

	// Token: 0x0400A857 RID: 43095
	private bool? HaveDeleteUnneededResourceOnInit = new bool?(false);

	// Token: 0x0400A858 RID: 43096
	private bool? AgreeUseCell = new bool?(false);

	// Token: 0x0400A859 RID: 43097
	private float? NextCanShowTipsTime = new float?(0f);

	// Token: 0x0400A85A RID: 43098
	public int RecallDownLoadTraceId = -1;

	// Token: 0x0400A85B RID: 43099
	public int MobileResCleanUpTraceId = -1;

	// Token: 0x0400A85C RID: 43100
	[Nullable(2)]
	private static SubPackageController _Instance;
}
