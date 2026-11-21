using System;
using System.Collections.Generic;
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

// Token: 0x0200200D RID: 8205
[NullableContext(1)]
[Nullable(0)]
public class SubPackageController : UiControllerBase
{
	// Token: 0x0601451A RID: 83226 RVA: 0x005EADBC File Offset: 0x005E8FBC
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

	// Token: 0x0601451B RID: 83227 RVA: 0x005EAE44 File Offset: 0x005E9044
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

	// Token: 0x0601451C RID: 83228 RVA: 0x005EB07C File Offset: 0x005E927C
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

	// Token: 0x0601451D RID: 83229 RVA: 0x005EB0D0 File Offset: 0x005E92D0
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

	// Token: 0x0601451E RID: 83230 RVA: 0x005EB11C File Offset: 0x005E931C
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

	// Token: 0x0601451F RID: 83231 RVA: 0x005EB170 File Offset: 0x005E9370
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

	// Token: 0x06014520 RID: 83232 RVA: 0x005EB218 File Offset: 0x005E9418
	public void CancelSubPackageDownLoading(int id)
	{
		if (SubPackageDownLoadModel.Instance.GetSubPackageDownLoadItemStateById(id) == ESubPackageDownLoadState.Finish)
		{
			return;
		}
		List<int> list = new List<int>();
		foreach (int num in SubPackageDownLoadModel.Instance.SubPackageDownLoadList)
		{
			if (num != id)
			{
				list.Add(num);
			}
		}
		SubPackageDownLoadModel.Instance.SubPackageDownLoadList = list;
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

	// Token: 0x06014521 RID: 83233 RVA: 0x005EB340 File Offset: 0x005E9540
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

	// Token: 0x06014522 RID: 83234 RVA: 0x005EB4B8 File Offset: 0x005E96B8
	public unsafe void DeleteUnneededResource(bool isAutoClear)
	{
		this.ReportSubPackageClearSpaceLogEvent();
		List<int> finishQuestList = QuestNewModel.Instance.GetFinishQuestList();
		HashSet<int> hashSet = isAutoClear ? SubPackageDownLoadModel.Instance.GetRecallProtectedQuestIds() : new HashSet<int>();
		List<int> list;
		if (hashSet.Count > 0)
		{
			list = new List<int>();
			using (List<int>.Enumerator enumerator = finishQuestList.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					int item = enumerator.Current;
					if (!hashSet.Contains(item))
					{
						list.Add(item);
					}
				}
				goto IL_75;
			}
		}
		list = finishQuestList;
		IL_75:
		if (hashSet.Count > 0)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.SubPackageDownLoad;
			ELogAuthor author = ELogAuthor.LJQ;
			string message = "自动清理可删除资源-剔除受保护回顾任务";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("protectedQuestIds", string.Join<int>(",", hashSet));
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

	// Token: 0x06014523 RID: 83235 RVA: 0x005EB5E8 File Offset: 0x005E97E8
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

	// Token: 0x06014524 RID: 83236 RVA: 0x005EB62C File Offset: 0x005E982C
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

	// Token: 0x06014525 RID: 83237 RVA: 0x005EB8B4 File Offset: 0x005E9AB4
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

	// Token: 0x06014526 RID: 83238 RVA: 0x005EB930 File Offset: 0x005E9B30
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

	// Token: 0x06014527 RID: 83239 RVA: 0x005EB9AC File Offset: 0x005E9BAC
	protected override void OnRegisterNetEvent()
	{
		Net.Instance.Register(ENotifyMessageId.SceneBlockSplitHumanChangleNotify, new Action<IMessage, Net.CallbackStatus>(this.SceneBlockSplitHumanChangleNotify));
		Net.Instance.Register(ENotifyMessageId.SceneBlockSplitHumanFullNotify, new Action<IMessage, Net.CallbackStatus>(this.SceneBlockSplitHumanFullNotify));
		Net.Instance.Register(ENotifyMessageId.SceneBlockSplitHumanSwitchStateNotify, new Action<IMessage, Net.CallbackStatus>(this.SceneBlockSplitHumanSwitchStateNotify));
		Net.Instance.Register(ENotifyMessageId.SceneBlockSplitPopWindowNotify, new Action<IMessage, Net.CallbackStatus>(this.SceneBlockSplitPopWindowNotify));
	}

	// Token: 0x06014528 RID: 83240 RVA: 0x005EBA2C File Offset: 0x005E9C2C
	protected override void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.SceneBlockSplitHumanChangleNotify);
		Net.Instance.UnRegister(ENotifyMessageId.SceneBlockSplitHumanFullNotify);
		Net.Instance.UnRegister(ENotifyMessageId.SceneBlockSplitHumanSwitchStateNotify);
		Net.Instance.UnRegister(ENotifyMessageId.SceneBlockSplitPopWindowNotify);
	}

	// Token: 0x06014529 RID: 83241 RVA: 0x005EBA7C File Offset: 0x005E9C7C
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add(EEventName.EnterAreaNotify, new Action<int>(this.EnterAreaNotify));
		EventSystem.Instance.Add(EEventName.OnRoleChangeEnd, new Action(this.OnRoleChangeEnd));
		EventSystem.Instance.Add(EEventName.WorldDoneAndCloseLoading, new Action(this.WorldDoneAndCloseLoading));
		EventSystem.Instance.Add(EEventName.BackLoginView, new Action(this.OnBackLoginView));
		SubPackageDownLoadModel.Instance.NetworkListener.NetworkChangeDelegate.Add(new Action<byte>(this.OnNetworkTypeChange));
	}

	// Token: 0x0601452A RID: 83242 RVA: 0x005EBB1C File Offset: 0x005E9D1C
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.EnterAreaNotify, new Action<int>(this.EnterAreaNotify));
		EventSystem.Instance.Remove(EEventName.OnRoleChangeEnd, new Action(this.OnRoleChangeEnd));
		EventSystem.Instance.Remove(EEventName.WorldDoneAndCloseLoading, new Action(this.WorldDoneAndCloseLoading));
		EventSystem.Instance.Remove(EEventName.BackLoginView, new Action(this.OnBackLoginView));
		SubPackageDownLoadModel.Instance.NetworkListener.NetworkChangeDelegate.Clear();
	}

	// Token: 0x0601452B RID: 83243 RVA: 0x005EBBAD File Offset: 0x005E9DAD
	[NullableContext(2)]
	private void SceneBlockSplitHumanChangleNotify(IMessage msg, Net.CallbackStatus status)
	{
	}

	// Token: 0x0601452C RID: 83244 RVA: 0x005EBBAF File Offset: 0x005E9DAF
	[NullableContext(2)]
	private void SceneBlockSplitHumanFullNotify(IMessage msg, Net.CallbackStatus status)
	{
	}

	// Token: 0x0601452D RID: 83245 RVA: 0x005EBBB1 File Offset: 0x005E9DB1
	[NullableContext(2)]
	private void SceneBlockSplitHumanSwitchStateNotify(IMessage msg, Net.CallbackStatus status)
	{
	}

	// Token: 0x0601452E RID: 83246 RVA: 0x005EBBB4 File Offset: 0x005E9DB4
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

	// Token: 0x0601452F RID: 83247 RVA: 0x005EBC1C File Offset: 0x005E9E1C
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

	// Token: 0x06014530 RID: 83248 RVA: 0x005EBC5C File Offset: 0x005E9E5C
	public void SceneBlockSplitClientLoginPush(List<int> downloadBlockIdList)
	{
		SceneBlockSplitClientLoginPush sceneBlockSplitClientLoginPush = Aki.Protocol.SceneBlockSplitClientLoginPush.Create();
		sceneBlockSplitClientLoginPush.DownloadBlockId.AddRange(downloadBlockIdList);
		Net.Instance.Send(EPushMessageId.SceneBlockSplitClientLoginPush, sceneBlockSplitClientLoginPush);
	}

	// Token: 0x06014531 RID: 83249 RVA: 0x005EBC8C File Offset: 0x005E9E8C
	public void DownLoadFinish()
	{
		int downLoadingSubPackageId = SubPackageDownLoadModel.Instance.DownLoadingSubPackageId;
		if (downLoadingSubPackageId == 0)
		{
			return;
		}
		using (List<ResourceDiffUpdater>.Enumerator enumerator = (SubPackageDownLoadModel.Instance.GetSubPackageDownLoadItemUpdater(downLoadingSubPackageId) ?? new List<ResourceDiffUpdater>()).GetEnumerator())
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
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", downLoadingSubPackageId);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		if (downLoadingSubPackageId == 1 && GameModeModel.Instance.WorldDone)
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
		SubPackageDownLoadModel.Instance.SetSubPackageDownLoadItemStateMap(downLoadingSubPackageId, ESubPackageDownLoadState.Finish);
		List<int> list = new List<int>();
		foreach (int num in SubPackageDownLoadModel.Instance.SubPackageDownLoadList)
		{
			if (num != downLoadingSubPackageId)
			{
				list.Add(num);
			}
		}
		SubPackageDownLoadModel.Instance.SubPackageDownLoadList = list;
		if (!SubPackageDefine.IsDynamicRecallId(downLoadingSubPackageId))
		{
			DownLoadSubPackage value = SubPackageConfig.Instance.GetDownLoadSubPackageById(downLoadingSubPackageId).Value;
			if (value.Type == 4)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("SubPackageDownLoad_Gender_Tips", Array.Empty<object>());
			}
			else
			{
				bool flag = false;
				if (value.Type == 2)
				{
					List<int> list2 = new List<int>();
					foreach (int num2 in value.Area())
					{
						if (ResourceManagerController.Instance.IsNeedReOpenMap(num2))
						{
							flag = true;
						}
						else
						{
							list2.Add(num2);
						}
					}
					this.SceneBlockChangePush(list2, null);
				}
				if (GameModeModel.Instance.WorldDone)
				{
					string localTextNew = ConfigMultiTextLang.GetLocalTextNew(value.Title, null);
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
			string localTextNew2 = ConfigMultiTextLang.GetLocalTextNew(((ConfigRecallConfigByRecallId.GetConfig(SubPackageDefine.RecallIdFromDynamic(downLoadingSubPackageId), true) != null) ? recallConfig.GetValueOrDefault().QuestName : null) ?? "", null);
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

	// Token: 0x06014532 RID: 83250 RVA: 0x005EBFA8 File Offset: 0x005EA1A8
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

	// Token: 0x06014533 RID: 83251 RVA: 0x005EC0A9 File Offset: 0x005EA2A9
	private void OnRoleChangeEnd()
	{
		if (!ResourceDiffUpdaterManager.Instance.IsGrayBoxHit())
		{
			return;
		}
		ResourceManagerController.Instance.UpdateServerQuestState();
	}

	// Token: 0x06014534 RID: 83252 RVA: 0x005EC0C4 File Offset: 0x005EA2C4
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
		this.RestorePauseIdFromStorage();
		List<int> player = LocalStorage.GetPlayer<List<int>>(ELocalStoragePlayerKey.SubDownLoadLastDownLoadList, null);
		if (player == null || player.Count <= 0)
		{
			EventSystem.Instance.Emit(EEventName.OnRefreshSubPackageDownLoadByPriority);
			return;
		}
		this.RestoreStaticDownLoadList(player);
		if (SubPackageDownLoadModel.Instance.PauseSubPackageId == 0)
		{
			this.DownLoadPackage();
		}
		EventSystem.Instance.Emit(EEventName.OnRefreshSubPackageDownLoadByPriority);
		this.SaveLocalDownLoadList();
	}

	// Token: 0x06014535 RID: 83253 RVA: 0x005EC15C File Offset: 0x005EA35C
	public void RestoreStaticDownLoadList(List<int> list)
	{
		foreach (int num in list)
		{
			if (!SubPackageDefine.IsDynamicRecallId(num) && SubPackageDownLoadModel.Instance.GetSubPackageDownLoadItemStateById(num) != ESubPackageDownLoadState.Finish && num != SubPackageDownLoadModel.Instance.DownLoadingSubPackageId && num != SubPackageDownLoadModel.Instance.PauseSubPackageId && !SubPackageDownLoadModel.Instance.SubPackageDownLoadList.Contains(num))
			{
				SubPackageDownLoadModel.Instance.SubPackageDownLoadList.Add(num);
				SubPackageDownLoadModel.Instance.SetSubPackageDownLoadItemStateMap(num, ESubPackageDownLoadState.Waiting);
			}
		}
	}

	// Token: 0x06014536 RID: 83254 RVA: 0x005EC204 File Offset: 0x005EA404
	private void OnBackLoginView()
	{
		if (!ResourceDiffUpdaterManager.Instance.IsGrayBoxHit())
		{
			return;
		}
		int downLoadingSubPackageId = SubPackageDownLoadModel.Instance.DownLoadingSubPackageId;
		if (downLoadingSubPackageId == 0)
		{
			return;
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.SubPackageDownLoad;
		ELogAuthor author = ELogAuthor.LJQ;
		string message = "返回登录,停止下载中条目并按下载中落盘";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", downLoadingSubPackageId);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		if (downLoadingSubPackageId != 1)
		{
			this.SaveLocalDownLoadList();
		}
		foreach (ResourceDiffUpdater resourceDiffUpdater in (SubPackageDownLoadModel.Instance.GetSubPackageDownLoadItemUpdater(downLoadingSubPackageId) ?? new List<ResourceDiffUpdater>()))
		{
			resourceDiffUpdater.Stop();
		}
	}

	// Token: 0x06014537 RID: 83255 RVA: 0x005EC2B8 File Offset: 0x005EA4B8
	public bool CheckBlockHaveDownLoad(int blockId)
	{
		if (!ResourceDiffUpdaterManager.Instance.IsGrayBoxHit())
		{
			return true;
		}
		int blockBelongToSubPackage = SubPackageDownLoadModel.Instance.GetBlockBelongToSubPackage(blockId);
		return SubPackageDownLoadModel.Instance.GetSubPackageDownLoadItemStateById(blockBelongToSubPackage) == ESubPackageDownLoadState.Finish;
	}

	// Token: 0x06014538 RID: 83256 RVA: 0x005EC2F0 File Offset: 0x005EA4F0
	public void SaveLocalDownLoadList()
	{
		if (PlayerInfoModel.Instance.GetId().GetValueOrDefault() <= 0)
		{
			Log.Instance.Info(ELogModule.SubPackageDownLoad, ELogAuthor.LJQ, "SaveLocalDownLoadList,尚未登录直接返回", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		List<int> list = new List<int>();
		List<int> list2 = new List<int>();
		foreach (int num in SubPackageDownLoadModel.Instance.SubPackageDownLoadList)
		{
			if (!SubPackageDefine.IsDynamicRecallId(num))
			{
				list.Add(num);
			}
			else
			{
				list2.Add(num);
			}
		}
		int downLoadingSubPackageId = SubPackageDownLoadModel.Instance.DownLoadingSubPackageId;
		if (downLoadingSubPackageId != 0)
		{
			if (SubPackageDefine.IsDynamicRecallId(downLoadingSubPackageId))
			{
				list2.Insert(0, downLoadingSubPackageId);
			}
			else
			{
				list.Insert(0, downLoadingSubPackageId);
			}
		}
		LocalStorage.SetPlayer<List<int>>(ELocalStoragePlayerKey.SubDownLoadLastDownLoadList, list);
		LocalStorage.SetPlayer<List<int>>(ELocalStoragePlayerKey.SubDownLoadLastDynamicDownLoadList, list2);
		LocalStorage.SetPlayer<int>(ELocalStoragePlayerKey.SubDownLoadLastDownLoadingId, (downLoadingSubPackageId != 1) ? downLoadingSubPackageId : 0);
		int pauseSubPackageId = SubPackageDownLoadModel.Instance.PauseSubPackageId;
		if (pauseSubPackageId != 0 && pauseSubPackageId != 1)
		{
			LocalStorage.SetPlayer<int>(ELocalStoragePlayerKey.SubDownLoadLastPauseId, pauseSubPackageId);
			return;
		}
		LocalStorage.SetPlayer<int>(ELocalStoragePlayerKey.SubDownLoadLastPauseId, 0);
	}

	// Token: 0x06014539 RID: 83257 RVA: 0x005EC420 File Offset: 0x005EA620
	public void ClearLocalDownLoadList()
	{
		if (PlayerInfoModel.Instance.GetId().GetValueOrDefault() <= 0)
		{
			Log.Instance.Info(ELogModule.SubPackageDownLoad, ELogAuthor.LJQ, "ClearLocalDownLoadList,尚未登录直接返回", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		LocalStorage.SetPlayer<List<int>>(ELocalStoragePlayerKey.SubDownLoadLastDownLoadList, new List<int>());
		LocalStorage.SetPlayer<int>(ELocalStoragePlayerKey.SubDownLoadLastPauseId, 0);
		LocalStorage.SetPlayer<List<int>>(ELocalStoragePlayerKey.SubDownLoadLastDynamicDownLoadList, new List<int>());
		LocalStorage.SetPlayer<int>(ELocalStoragePlayerKey.SubDownLoadLastDownLoadingId, 0);
	}

	// Token: 0x0601453A RID: 83258 RVA: 0x005EC49C File Offset: 0x005EA69C
	public void RestorePauseIdFromStorage()
	{
		int player = LocalStorage.GetPlayer<int>(ELocalStoragePlayerKey.SubDownLoadLastPauseId, 0);
		if (player == 0 || player == 1 || SubPackageDefine.IsDynamicRecallId(player))
		{
			return;
		}
		SubPackageDownLoadModel.Instance.RestorePauseItemState(player);
	}

	// Token: 0x0601453B RID: 83259 RVA: 0x005EC4D0 File Offset: 0x005EA6D0
	public void ReportSubPackageKeySubPackageLogEvent(int time, int state)
	{
		SubPackageKeySubPackageLogEvent subPackageKeySubPackageLogEvent = new SubPackageKeySubPackageLogEvent();
		subPackageKeySubPackageLogEvent.i_download_time = time;
		subPackageKeySubPackageLogEvent.i_download_status = state;
		subPackageKeySubPackageLogEvent.o_phantoms = SubPackageDownLoadModel.Instance.KeyIncludeSubPackageList;
		LogReportController.Instance.LogReport(subPackageKeySubPackageLogEvent);
	}

	// Token: 0x0601453C RID: 83260 RVA: 0x005EC50C File Offset: 0x005EA70C
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

	// Token: 0x0601453D RID: 83261 RVA: 0x005EC604 File Offset: 0x005EA804
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

	// Token: 0x0601453E RID: 83262 RVA: 0x005EC6C4 File Offset: 0x005EA8C4
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

	// Token: 0x0601453F RID: 83263 RVA: 0x005EC75C File Offset: 0x005EA95C
	public void ReportSubPackageClearSpaceLogEvent()
	{
		SubPackageClearSpaceLogEvent subPackageClearSpaceLogEvent = new SubPackageClearSpaceLogEvent();
		bool player = LocalStorage.GetPlayer<bool>(ELocalStoragePlayerKey.SubDownLoadClearOnLogin, false);
		subPackageClearSpaceLogEvent.b_if_storage_alert = player;
		subPackageClearSpaceLogEvent.i_required_space = (int)((double)SubPackageDownLoadModel.Instance.GetSubPackageCanClearSpace() / 1048576.0);
		LogReportController.Instance.LogReport(subPackageClearSpaceLogEvent);
	}

	// Token: 0x06014540 RID: 83264 RVA: 0x005EC7AC File Offset: 0x005EA9AC
	public void ReportSubPackageClearSpaceFinishLogEvent(bool isAuto)
	{
		SubPackageClearSpaceFinishLogEvent subPackageClearSpaceFinishLogEvent = new SubPackageClearSpaceFinishLogEvent();
		subPackageClearSpaceFinishLogEvent.b_if_storage_alert = isAuto;
		subPackageClearSpaceFinishLogEvent.i_required_space = (int)((double)SubPackageDownLoadModel.Instance.GetSubPackageCanClearSpace() / 1048576.0);
		subPackageClearSpaceFinishLogEvent.i_remaining_space = (int)((double)VideoResUpdate.Instance.GetFreeSpace() / 1048576.0);
		LogReportController.Instance.LogReport(subPackageClearSpaceFinishLogEvent);
	}

	// Token: 0x06014541 RID: 83265 RVA: 0x005EC80C File Offset: 0x005EAA0C
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

	// Token: 0x06014542 RID: 83266 RVA: 0x005EC890 File Offset: 0x005EAA90
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

	// Token: 0x06014543 RID: 83267 RVA: 0x005EC91C File Offset: 0x005EAB1C
	public void ReportMobileResCleanUpFinishLogEvent()
	{
		MobileResCleanUpFinishLogEvent mobileResCleanUpFinishLogEvent = new MobileResCleanUpFinishLogEvent();
		mobileResCleanUpFinishLogEvent.s_trace_id = this.MobileResCleanUpTraceId.ToString();
		mobileResCleanUpFinishLogEvent.unique_id = LoginModel.Instance.GetLoginUid();
		int? num;
		mobileResCleanUpFinishLogEvent.player_id = (((PlayerInfoModel.Instance.GetId() != null) ? num.GetValueOrDefault().ToString() : null) ?? "");
		LogReportController.Instance.LogReport(mobileResCleanUpFinishLogEvent);
	}

	// Token: 0x06014544 RID: 83268 RVA: 0x005EC990 File Offset: 0x005EAB90
	public unsafe void ClearSubPackage(List<int> sceneIdList, bool clearVideo)
	{
		HashSet<int> recallClearedCandidates = SubPackageDownLoadModel.Instance.SnapshotRecallIdsWithLocalVideoData();
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
		ResourceDiffUpdaterManager.Instance.BlockModule.Delete(new List<string>(hashSet));
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
			List<int> recallDynamicIdsByVideoIds = SubPackageDownLoadModel.Instance.GetRecallDynamicIdsByVideoIds(unusedVideos);
			List<ResourceDiffUpdater> list2 = new List<ResourceDiffUpdater>();
			if (recallDynamicIdsByVideoIds.Count > 0)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.SubPackageDownLoad;
				ELogAuthor author2 = ELogAuthor.LJQ;
				string message2 = "清理视频前取消回顾视频动态条目下载";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("dynamicIdList", string.Join<int>(",", recallDynamicIdsByVideoIds));
				instance2.Info(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				foreach (int id4 in recallDynamicIdsByVideoIds)
				{
					foreach (ResourceDiffUpdater resourceDiffUpdater in (SubPackageDownLoadModel.Instance.GetSubPackageDownLoadItemUpdater(id4) ?? new List<ResourceDiffUpdater>()))
					{
						if (resourceDiffUpdater.UpdateStatus == EResDownloadStatus.Downloading)
						{
							list2.Add(resourceDiffUpdater);
						}
					}
					this.CancelSubPackageDownLoading(id4);
				}
			}
			if (list2.Count > 0)
			{
				this.ReportMobileResCleanUpLogEvent(num, list, 2);
				this.ReportMobileResCleanUpFinishLogEvent();
				this.DeleteVideosAfterUpdatersStopped(list2, unusedVideos, recallClearedCandidates);
				return;
			}
			ResourceDiffUpdaterManager.Instance.VideoModule.DeleteByVideoIds(unusedVideos);
		}
		this.ReportMobileResCleanUpLogEvent(num, list, 2);
		this.ReportMobileResCleanUpFinishLogEvent();
		this.RefreshAfterClearVideo(recallClearedCandidates);
	}

	// Token: 0x06014545 RID: 83269 RVA: 0x005ECD1C File Offset: 0x005EAF1C
	private void DeleteVideosAfterUpdatersStopped(List<ResourceDiffUpdater> stoppingUpdaterList, HashSet<int> videoIdList, HashSet<int> recallClearedCandidates)
	{
		int pendingCount = stoppingUpdaterList.Count;
		bool isDone = false;
		TimerHandle timeoutHandle = null;
		Action<EResDownloadStatus> <>9__2;
		foreach (ResourceDiffUpdater resourceDiffUpdater in stoppingUpdaterList)
		{
			Action<EResDownloadStatus> callback;
			if ((callback = <>9__2) == null)
			{
				callback = (<>9__2 = delegate(EResDownloadStatus _)
				{
					int pendingCount = pendingCount;
					pendingCount--;
					if (pendingCount <= 0)
					{
						base.<DeleteVideosAfterUpdatersStopped>g__DoDelete|0(false);
					}
				});
			}
			resourceDiffUpdater.AddOnDownloadFinish(callback);
		}
		timeoutHandle = TimerSystem.Instance.Delay(delegate(float _)
		{
			base.<DeleteVideosAfterUpdatersStopped>g__DoDelete|0(true);
		}, 3000f, null, null, true, 1f);
	}

	// Token: 0x06014546 RID: 83270 RVA: 0x005ECDE4 File Offset: 0x005EAFE4
	private void RefreshAfterClearVideo(HashSet<int> recallClearedCandidates)
	{
		SubPackageDownLoadModel instance = SubPackageDownLoadModel.Instance;
		if (instance != null)
		{
			instance.RefreshRecallDynamicItemsByStorage(recallClearedCandidates).Forget();
		}
		EventSystem.Instance.Emit(EEventName.OnRefreshSubPackClearData);
	}

	// Token: 0x17001E90 RID: 7824
	// (get) Token: 0x06014547 RID: 83271 RVA: 0x005ECE0C File Offset: 0x005EB00C
	public static SubPackageController Instance
	{
		get
		{
			return SubPackageController._Instance;
		}
	}

	// Token: 0x06014548 RID: 83272 RVA: 0x005ECE13 File Offset: 0x005EB013
	public static SubPackageController GetOrCreateInstance()
	{
		if (SubPackageController._Instance == null)
		{
			SubPackageController.CreateInstance();
		}
		return SubPackageController._Instance;
	}

	// Token: 0x06014549 RID: 83273 RVA: 0x005ECE27 File Offset: 0x005EB027
	public static bool CreateInstance()
	{
		if (SubPackageController._Instance != null)
		{
			return true;
		}
		SubPackageController._Instance = new SubPackageController();
		return true;
	}

	// Token: 0x0601454A RID: 83274 RVA: 0x005ECE3D File Offset: 0x005EB03D
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0601454B RID: 83275 RVA: 0x005ECE3F File Offset: 0x005EB03F
	public static void ResetStaticDefaultValue()
	{
		SubPackageController._Instance = null;
	}

	// Token: 0x0601454C RID: 83276 RVA: 0x005ECE47 File Offset: 0x005EB047
	static SubPackageController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(SubPackageController.CreateStaticDefaultValue), new Action(SubPackageController.ResetStaticDefaultValue));
	}

	// Token: 0x0400AC5B RID: 44123
	public float ENTER_AREA_CD = 10000f;

	// Token: 0x0400AC5C RID: 44124
	private bool? HaveDeleteUnneededResourceOnInit = new bool?(false);

	// Token: 0x0400AC5D RID: 44125
	private bool? AgreeUseCell = new bool?(false);

	// Token: 0x0400AC5E RID: 44126
	private float? NextCanShowTipsTime = new float?(0f);

	// Token: 0x0400AC5F RID: 44127
	public int RecallDownLoadTraceId = -1;

	// Token: 0x0400AC60 RID: 44128
	public int MobileResCleanUpTraceId = -1;

	// Token: 0x0400AC61 RID: 44129
	private const float WAIT_UPDATER_STOP_TIMEOUT_MS = 3000f;

	// Token: 0x0400AC62 RID: 44130
	[Nullable(2)]
	private static SubPackageController _Instance;
}
