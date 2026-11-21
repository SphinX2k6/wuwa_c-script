using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Launcher.DiffPatch.Data;
using CSharpScript.Launcher.DiffPatch.Update;
using CSharpScript.Launcher.Update;
using CSharpScript.Launcher.Update.ResourceDiffUpdate;
using CSharpScript.Launcher.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x02001B55 RID: 6997
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class QuestResourceModel : ModelBase
{
	// Token: 0x170019DB RID: 6619
	// (get) Token: 0x060116FA RID: 71418 RVA: 0x00524B6D File Offset: 0x00522D6D
	public bool IsSeparateVideo
	{
		get
		{
			return VideoResUpdate.Instance.GetIsSeparateVideo();
		}
	}

	// Token: 0x060116FB RID: 71419 RVA: 0x00524B7C File Offset: 0x00522D7C
	protected override bool OnInit()
	{
		if (!VideoResUpdate.Instance.GetIsSeparateVideo())
		{
			return true;
		}
		IReadOnlyList<QuestRefVideoConfig> configList = ConfigQuestRefVideoConfigAll.GetConfigList(true);
		if (configList == null)
		{
			Log.Instance.Error(ELogModule.QuestResource, ELogAuthor.ZWY, "找不到任务视频对照配置", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		HashSet<string> hashSet = new HashSet<string>();
		HashSet<string> hashSet2 = new HashSet<string>();
		foreach (QuestRefVideoConfig questRefVideoConfig in configList)
		{
			if (questRefVideoConfig.GirlOrBoy == 0)
			{
				if (this.FemaleQuestRef.ContainsKey(questRefVideoConfig.QuestId))
				{
					this.FemaleQuestRef[questRefVideoConfig.QuestId].Add(questRefVideoConfig.PakName);
				}
				else
				{
					List<string> list = new List<string>();
					list.Add(questRefVideoConfig.PakName);
					this.FemaleQuestRef[questRefVideoConfig.QuestId] = list;
				}
				if (!questRefVideoConfig.PakName.EndsWith("2"))
				{
					hashSet2.Add(questRefVideoConfig.PakName);
				}
			}
			else if (questRefVideoConfig.GirlOrBoy == 1)
			{
				if (this.MaleQuestRef.ContainsKey(questRefVideoConfig.QuestId))
				{
					this.MaleQuestRef[questRefVideoConfig.QuestId].Add(questRefVideoConfig.PakName);
				}
				else
				{
					List<string> list2 = new List<string>();
					list2.Add(questRefVideoConfig.PakName);
					this.MaleQuestRef[questRefVideoConfig.QuestId] = list2;
				}
				if (!questRefVideoConfig.PakName.EndsWith("2"))
				{
					hashSet.Add(questRefVideoConfig.PakName);
				}
			}
			string[] array = questRefVideoConfig.PakName.Split('_', StringSplitOptions.None);
			int item;
			if (array.Length != 0 && int.TryParse(array[0], out item))
			{
				if (this.QuestRefCgIds.ContainsKey(questRefVideoConfig.QuestId))
				{
					this.QuestRefCgIds[questRefVideoConfig.QuestId].Add(item);
				}
				else
				{
					HashSet<int> hashSet3 = new HashSet<int>();
					hashSet3.Add(item);
					this.QuestRefCgIds[questRefVideoConfig.QuestId] = hashSet3;
				}
			}
		}
		VideoResUpdate.Instance.SetAllSpecialVideoResPak(EVideoResSizeType.FemalePrepare, new List<string>(hashSet2));
		VideoResUpdate.Instance.SetAllSpecialVideoResPak(EVideoResSizeType.MalePrepare, new List<string>(hashSet));
		VideoResUpdate.Instance.CheckVideoManifestsData();
		this.UserFirstSelectedVideoUpdate = LauncherStorageLib.Instance.GetDeviceSaved<int>(ELauncherStorageDeviceKey.UserFirstSelectedVideoUpdate, 0);
		Log instance = Log.Instance;
		ELogModule module = ELogModule.QuestResource;
		ELogAuthor author = ELogAuthor.ZWY;
		string message = "用户最初选择任务资源状态";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("state", this.UserFirstSelectedVideoUpdate);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		return true;
	}

	// Token: 0x170019DC RID: 6620
	// (get) Token: 0x060116FC RID: 71420 RVA: 0x00524E1C File Offset: 0x0052301C
	public Dictionary<int, List<string>> FemaleQuestIdToPack
	{
		get
		{
			return this.FemaleQuestRef;
		}
	}

	// Token: 0x170019DD RID: 6621
	// (get) Token: 0x060116FD RID: 71421 RVA: 0x00524E24 File Offset: 0x00523024
	public Dictionary<int, List<string>> MaleQuestIdToPack
	{
		get
		{
			return this.MaleQuestRef;
		}
	}

	// Token: 0x170019DE RID: 6622
	// (get) Token: 0x060116FE RID: 71422 RVA: 0x00524E2C File Offset: 0x0052302C
	public Dictionary<int, HashSet<int>> QuestIdToCgIds
	{
		get
		{
			return this.QuestRefCgIds;
		}
	}

	// Token: 0x060116FF RID: 71423 RVA: 0x00524E34 File Offset: 0x00523034
	protected override bool OnClear()
	{
		VideoResUpdate.Instance.GetIsSeparateVideo();
		return true;
	}

	// Token: 0x06011700 RID: 71424 RVA: 0x00524E42 File Offset: 0x00523042
	public void ClearCheckQuests()
	{
		this.LoginQuests.Clear();
	}

	// Token: 0x06011701 RID: 71425 RVA: 0x00524E50 File Offset: 0x00523050
	public void FillCheckQuests(int[] quests)
	{
		this.LoginQuests.Clear();
		foreach (int item in quests)
		{
			this.LoginQuests.Add(item);
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.QuestResource;
		ELogAuthor author = ELogAuthor.ZWY;
		string message = "收到登录任务通知，填充任务视频检查数据";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("questIds", this.LoginQuests);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		this.LoginQuestsInitialed = true;
	}

	// Token: 0x06011702 RID: 71426 RVA: 0x00524EBC File Offset: 0x005230BC
	public void FillFinishedQuests(int[] quests)
	{
		this.LoginFinishedQuests.Clear();
		foreach (int item in quests)
		{
			this.LoginFinishedQuests.Add(item);
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.QuestResource;
		ELogAuthor author = ELogAuthor.HWK;
		string message = "收到登录任务通知，填充已完成任务视频检查数据";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("questIds", this.LoginFinishedQuests);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		this.LoginFinishedQuestsInitialed = true;
	}

	// Token: 0x06011703 RID: 71427 RVA: 0x00524F28 File Offset: 0x00523128
	private List<string> GetLoginPakNamesWithoutFinishedQuests(EPlayerGender gender = EPlayerGender.None)
	{
		HashSet<string> hashSet = new HashSet<string>();
		if (gender == EPlayerGender.Female || gender == EPlayerGender.None)
		{
			foreach (KeyValuePair<int, List<string>> keyValuePair in this.FemaleQuestRef)
			{
				if (!this.LoginFinishedQuests.Contains(keyValuePair.Key))
				{
					foreach (string item in keyValuePair.Value)
					{
						hashSet.Add(item);
					}
				}
			}
		}
		if (gender == EPlayerGender.Male || gender == EPlayerGender.None)
		{
			foreach (KeyValuePair<int, List<string>> keyValuePair2 in this.MaleQuestRef)
			{
				if (!this.LoginFinishedQuests.Contains(keyValuePair2.Key))
				{
					foreach (string item2 in keyValuePair2.Value)
					{
						hashSet.Add(item2);
					}
				}
			}
		}
		if (hashSet.Count > 0)
		{
			return new List<string>(hashSet);
		}
		return new List<string>();
	}

	// Token: 0x06011704 RID: 71428 RVA: 0x00525090 File Offset: 0x00523290
	private List<string> GetLoginQuestsPakNames()
	{
		if (this.LoginQuests.Count == 0)
		{
			return new List<string>();
		}
		HashSet<string> hashSet = new HashSet<string>();
		EPlayerGender playerGender = PlayerInfoModel.Instance.GetPlayerGender();
		if (playerGender == EPlayerGender.Female)
		{
			using (HashSet<int>.Enumerator enumerator = this.LoginQuests.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					int key = enumerator.Current;
					List<string> list;
					if (this.FemaleQuestRef.TryGetValue(key, out list))
					{
						foreach (string item in list)
						{
							hashSet.Add(item);
						}
					}
				}
				goto IL_11A;
			}
		}
		if (playerGender == EPlayerGender.Male)
		{
			foreach (int key2 in this.LoginQuests)
			{
				List<string> list2;
				if (this.MaleQuestRef.TryGetValue(key2, out list2))
				{
					foreach (string item2 in list2)
					{
						hashSet.Add(item2);
					}
				}
			}
		}
		IL_11A:
		if (hashSet.Count > 0)
		{
			return new List<string>(hashSet);
		}
		return new List<string>();
	}

	// Token: 0x06011705 RID: 71429 RVA: 0x00525200 File Offset: 0x00523400
	public bool NeedCheckQuestResource()
	{
		List<string> loginNeedDownloadPakNames = this.GetLoginNeedDownloadPakNames();
		ValueTuple<List<RequireFileInfo>, long, long, List<LocalFileInfo>> valueTuple = VideoResUpdate.Instance.AnalyzeRequireFilesByNames(loginNeedDownloadPakNames);
		return valueTuple.Item2 != valueTuple.Item3;
	}

	// Token: 0x06011706 RID: 71430 RVA: 0x00525231 File Offset: 0x00523431
	public List<string> GetLoginNeedDownloadPakNames()
	{
		if (ResourceDiffUpdaterManager.Instance.IsGrayBoxHit())
		{
			return this.GetLoginQuestsPakNames();
		}
		return this.GetLoginPakNamesWithoutFinishedQuests(EPlayerGender.None);
	}

	// Token: 0x06011707 RID: 71431 RVA: 0x00525250 File Offset: 0x00523450
	public void UserClicked()
	{
		if (this.UserClickPromise != null)
		{
			this.UserClickPromise.SetResult();
			return;
		}
		Log.Instance.Error(ELogModule.QuestResource, ELogAuthor.ZWY, "检查任务数据点击回调错误", default(ReadOnlySpan<ValueTuple<string, object>>));
	}

	// Token: 0x06011708 RID: 71432 RVA: 0x00525290 File Offset: 0x00523490
	public void UserDownloadSuc()
	{
		if (this.UserDownloadSucPromise != null)
		{
			this.UserDownloadSucPromise.SetResult();
			return;
		}
		Log.Instance.Error(ELogModule.QuestResource, ELogAuthor.ZWY, "检查任务下载回调错误", default(ReadOnlySpan<ValueTuple<string, object>>));
	}

	// Token: 0x06011709 RID: 71433 RVA: 0x005252D0 File Offset: 0x005234D0
	public void UserClickOutOfMemoryView(bool result)
	{
		if (this.UserClickOutOfMemoryViewPromise != null)
		{
			this.UserClickOutOfMemoryViewPromise.SetResult(result);
			return;
		}
		Log.Instance.Error(ELogModule.QuestResource, ELogAuthor.ZWY, "检查任务硬盘不足回调错误", default(ReadOnlySpan<ValueTuple<string, object>>));
	}

	// Token: 0x0601170A RID: 71434 RVA: 0x00525310 File Offset: 0x00523510
	public void UserClickNetWorkError(bool result)
	{
		if (this.UserClickNetWorkErrorPromise != null)
		{
			this.UserClickNetWorkErrorPromise.SetResult(result);
			return;
		}
		Log.Instance.Error(ELogModule.QuestResource, ELogAuthor.ZWY, "检查任务网络异常回调错误", default(ReadOnlySpan<ValueTuple<string, object>>));
	}

	// Token: 0x0601170B RID: 71435 RVA: 0x0052534E File Offset: 0x0052354E
	public void SetIsDownloadNotEnoughSpaceError(bool result)
	{
		this.IsDownloadNotEnoughSpaceError = result;
	}

	// Token: 0x0601170C RID: 71436 RVA: 0x00525357 File Offset: 0x00523557
	public void SetIsReportDownloadNotEnoughSpace(bool result)
	{
		this.IsReportDownloadNotEnoughSpace = new bool?(result);
	}

	// Token: 0x0601170D RID: 71437 RVA: 0x00525368 File Offset: 0x00523568
	public UniTask CheckQuestResource()
	{
		QuestResourceModel.<CheckQuestResource>d__41 <CheckQuestResource>d__;
		<CheckQuestResource>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CheckQuestResource>d__.<>4__this = this;
		<CheckQuestResource>d__.<>1__state = -1;
		<CheckQuestResource>d__.<>t__builder.Start<QuestResourceModel.<CheckQuestResource>d__41>(ref <CheckQuestResource>d__);
		return <CheckQuestResource>d__.<>t__builder.Task;
	}

	// Token: 0x0601170E RID: 71438 RVA: 0x005253AC File Offset: 0x005235AC
	private void OpenWaitNetworkTypeUserConfirm()
	{
		Log.Instance.Info(ELogModule.QuestResource, ELogAuthor.ZYL, "检查网络: 打开蜂窝网络下载同意弹窗", default(ReadOnlySpan<ValueTuple<string, object>>));
		CustomPromise<bool> waitUserConfirmNetworkTypePromise = this.WaitUserConfirmNetworkTypePromise;
		if (waitUserConfirmNetworkTypePromise != null && waitUserConfirmNetworkTypePromise.IsPending)
		{
			Log.Instance.Warn(ELogModule.QuestResource, ELogAuthor.ZYL, "检查网络: 已存在蜂窝网络下载同意弹窗的Promise, 不重复打开", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		this.WaitUserConfirmNetworkTypePromise = new CustomPromise<bool>();
		ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.QuestResDownloadCellNetworkConfirm);
		confirmBoxDataNew.FunctionMap.Add(0, new Action(this.<OpenWaitNetworkTypeUserConfirm>g__OnCancelOrClose|42_1));
		confirmBoxDataNew.FunctionMap.Add(1, new Action(this.<OpenWaitNetworkTypeUserConfirm>g__OnCancelOrClose|42_1));
		confirmBoxDataNew.FunctionMap.Add(2, new Action(this.<OpenWaitNetworkTypeUserConfirm>g__OnConfirm|42_0));
		ConfirmBoxController.Instance.ShowNetWorkConfirmBoxView(confirmBoxDataNew, delegate(bool success, int viewId)
		{
			if (!success)
			{
				Log.Instance.Error(ELogModule.QuestResource, ELogAuthor.ZYL, "检查网络: 蜂窝网络下载同意弹窗打开失败", default(ReadOnlySpan<ValueTuple<string, object>>));
				this.<OpenWaitNetworkTypeUserConfirm>g__OnCancelOrClose|42_1();
				return;
			}
			CustomPromise<bool> waitUserConfirmNetworkTypePromise2 = this.WaitUserConfirmNetworkTypePromise;
			if (waitUserConfirmNetworkTypePromise2 == null || !waitUserConfirmNetworkTypePromise2.IsPending)
			{
				ConfirmBoxController.Instance.CloseNetWorkConfirmBoxView(viewId, null);
				return;
			}
			this.WaitUserConfirmNetworkTypeViewId = viewId;
		});
	}

	// Token: 0x0601170F RID: 71439 RVA: 0x0052547C File Offset: 0x0052367C
	private void CloseWaitNetworkTypeUserConfirm(bool bConfirm)
	{
		Log instance = Log.Instance;
		ELogModule module = ELogModule.QuestResource;
		ELogAuthor author = ELogAuthor.ZYL;
		string message = "检查网络: 程序主动关闭蜂窝网络下载同意弹窗";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("bConfirm", bConfirm);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		CustomPromise<bool> waitUserConfirmNetworkTypePromise = this.WaitUserConfirmNetworkTypePromise;
		this.WaitUserConfirmNetworkTypePromise = null;
		ConfirmBoxController.Instance.CloseNetWorkConfirmBoxView(this.WaitUserConfirmNetworkTypeViewId, null);
		if (waitUserConfirmNetworkTypePromise == null)
		{
			return;
		}
		waitUserConfirmNetworkTypePromise.SetResult(bConfirm);
	}

	// Token: 0x06011710 RID: 71440 RVA: 0x005254E0 File Offset: 0x005236E0
	[NullableContext(0)]
	private UniTask<bool> WaitNetworkTypeUserConfirmResult()
	{
		QuestResourceModel.<WaitNetworkTypeUserConfirmResult>d__44 <WaitNetworkTypeUserConfirmResult>d__;
		<WaitNetworkTypeUserConfirmResult>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<WaitNetworkTypeUserConfirmResult>d__.<>4__this = this;
		<WaitNetworkTypeUserConfirmResult>d__.<>1__state = -1;
		<WaitNetworkTypeUserConfirmResult>d__.<>t__builder.Start<QuestResourceModel.<WaitNetworkTypeUserConfirmResult>d__44>(ref <WaitNetworkTypeUserConfirmResult>d__);
		return <WaitNetworkTypeUserConfirmResult>d__.<>t__builder.Task;
	}

	// Token: 0x06011711 RID: 71441 RVA: 0x00525524 File Offset: 0x00523724
	public UniTask TryCheckQuestResource()
	{
		QuestResourceModel.<TryCheckQuestResource>d__45 <TryCheckQuestResource>d__;
		<TryCheckQuestResource>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<TryCheckQuestResource>d__.<>4__this = this;
		<TryCheckQuestResource>d__.<>1__state = -1;
		<TryCheckQuestResource>d__.<>t__builder.Start<QuestResourceModel.<TryCheckQuestResource>d__45>(ref <TryCheckQuestResource>d__);
		return <TryCheckQuestResource>d__.<>t__builder.Task;
	}

	// Token: 0x06011712 RID: 71442 RVA: 0x00525568 File Offset: 0x00523768
	[NullableContext(0)]
	public UniTask<bool> CheckQuestData()
	{
		QuestResourceModel.<CheckQuestData>d__46 <CheckQuestData>d__;
		<CheckQuestData>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<CheckQuestData>d__.<>4__this = this;
		<CheckQuestData>d__.<>1__state = -1;
		<CheckQuestData>d__.<>t__builder.Start<QuestResourceModel.<CheckQuestData>d__46>(ref <CheckQuestData>d__);
		return <CheckQuestData>d__.<>t__builder.Task;
	}

	// Token: 0x06011713 RID: 71443 RVA: 0x005255AC File Offset: 0x005237AC
	[NullableContext(2)]
	private bool HandlePullResourcePackageResponse(ClientPullResourcePackageResponse response)
	{
		if (response == null)
		{
			Log.Instance.Error(ELogModule.QuestResource, ELogAuthor.HWK, "检查任务数据，拉取登录任务数据失败，response为空", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		if (response.ErrorId != Aki.Protocol.ErrorCode.Success)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.QuestResource;
			ELogAuthor author = ELogAuthor.HWK;
			string message = "检查任务数据，拉取登录任务数据失败";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("errCode", response.ErrorId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return false;
		}
		int[] array = new int[response.NeedConfirmQuestIds.Count];
		response.NeedConfirmQuestIds.CopyTo(array, 0);
		this.FillCheckQuests(array);
		int[] array2 = new int[response.FinishMp4QuestIds.Count];
		response.FinishMp4QuestIds.CopyTo(array2, 0);
		this.FillFinishedQuests(array2);
		return true;
	}

	// Token: 0x06011714 RID: 71444 RVA: 0x00525660 File Offset: 0x00523860
	public unsafe void CalcPrepareResource()
	{
		if (!VideoResUpdate.Instance.GetIsSeparateVideo())
		{
			return;
		}
		EPlayerGender playerGender = PlayerInfoModel.Instance.GetPlayerGender();
		if (this.UseCachePrepareResourceSize)
		{
			return;
		}
		HashSet<string> hashSet = new HashSet<string>();
		foreach (KeyValuePair<int, List<string>> keyValuePair in this.FemaleQuestRef)
		{
			bool flag = QuestNewModel.Instance.CheckQuestFinished(keyValuePair.Key);
			bool flag2 = playerGender == EPlayerGender.Female && this.LoginQuests.Contains(keyValuePair.Key);
			Log instance = Log.Instance;
			ELogModule module = ELogModule.QuestResource;
			ELogAuthor author = ELogAuthor.HWK;
			string message = "CalcPrepareResource Female";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("questId", keyValuePair.Key);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("isQuestFinished", flag);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("isLoginFinished", flag2);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			if (!flag && !flag2)
			{
				foreach (string item in keyValuePair.Value)
				{
					hashSet.Add(item);
				}
			}
		}
		ValueTuple<List<RequireFileInfo>, long, long, List<LocalFileInfo>> valueTuple = VideoResUpdate.Instance.AnalyzeRequireFilesByNames(new List<string>(hashSet));
		long item2 = valueTuple.Item2;
		long item3 = valueTuple.Item3;
		VideoResUpdate.Instance.SetVideoResSize(EVideoResSizeType.FemalePrepare, item2);
		VideoResUpdate.Instance.SetVideoResSavedSize(EVideoResSizeType.FemalePrepare, item3);
		VideoResUpdate.Instance.SetVideoResPak(EVideoResSizeType.FemalePrepare, new List<string>(hashSet));
		if (VideoUpdateManager.Instance.GetVideoUpdater(EVideoResSizeType.FemalePrepare).GetDownLoadState() == EVideoDownloadStatus.None)
		{
			VideoUpdateManager.Instance.GetVideoUpdater(EVideoResSizeType.FemalePrepare).SetDownLoadProgress(item3, item2);
		}
		Log instance2 = Log.Instance;
		ELogModule module2 = ELogModule.QuestResource;
		ELogAuthor author2 = ELogAuthor.ZWY;
		string message2 = "VideoDown CalcPrepareRes Female";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("needSize", item2);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("savedSize", item3);
		instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
		HashSet<string> hashSet2 = new HashSet<string>();
		foreach (KeyValuePair<int, List<string>> keyValuePair2 in this.MaleQuestRef)
		{
			bool flag3 = QuestNewModel.Instance.CheckQuestFinished(keyValuePair2.Key);
			bool flag4 = playerGender == EPlayerGender.Male && this.LoginQuests.Contains(keyValuePair2.Key);
			Log instance3 = Log.Instance;
			ELogModule module3 = ELogModule.QuestResource;
			ELogAuthor author3 = ELogAuthor.HWK;
			string message3 = "CalcPrepareResource Male";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray3 = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 0) = new ValueTuple<string, object>("questId", keyValuePair2.Key);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 1) = new ValueTuple<string, object>("isQuestFinished", flag3);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 2) = new ValueTuple<string, object>("isLoginFinished", flag4);
			instance3.Info(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray3, 3));
			if (!flag3 && !flag4)
			{
				foreach (string item4 in keyValuePair2.Value)
				{
					hashSet2.Add(item4);
				}
			}
		}
		ValueTuple<List<RequireFileInfo>, long, long, List<LocalFileInfo>> valueTuple2 = VideoResUpdate.Instance.AnalyzeRequireFilesByNames(new List<string>(hashSet2));
		long item5 = valueTuple2.Item2;
		long item6 = valueTuple2.Item3;
		VideoResUpdate.Instance.SetVideoResSize(EVideoResSizeType.MalePrepare, item5);
		VideoResUpdate.Instance.SetVideoResSavedSize(EVideoResSizeType.MalePrepare, item6);
		VideoResUpdate.Instance.SetVideoResPak(EVideoResSizeType.MalePrepare, new List<string>(hashSet2));
		if (VideoUpdateManager.Instance.GetVideoUpdater(EVideoResSizeType.MalePrepare).GetDownLoadState() == EVideoDownloadStatus.None)
		{
			VideoUpdateManager.Instance.GetVideoUpdater(EVideoResSizeType.MalePrepare).SetDownLoadProgress(item6, item5);
		}
		Log instance4 = Log.Instance;
		ELogModule module4 = ELogModule.QuestResource;
		ELogAuthor author4 = ELogAuthor.ZWY;
		string message4 = "VideoDown CalcPrepareRes Male";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray4 = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 0) = new ValueTuple<string, object>("needSize", item5);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 1) = new ValueTuple<string, object>("savedSize", item6);
		instance4.Info(module4, author4, message4, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray4, 2));
		this.UseCachePrepareResourceSize = true;
	}

	// Token: 0x06011715 RID: 71445 RVA: 0x00525B00 File Offset: 0x00523D00
	public void RefreshCachePrepareResourceSize()
	{
		this.UseCachePrepareResourceSize = false;
	}

	// Token: 0x06011716 RID: 71446 RVA: 0x00525B0C File Offset: 0x00523D0C
	public List<string> GetQuestRefPakNames(int questId, EPlayerGender gender)
	{
		List<string> list = new List<string>();
		List<string> list2;
		if (gender == EPlayerGender.Female && this.FemaleQuestRef.TryGetValue(questId, out list2))
		{
			list = list2;
		}
		List<string> list3;
		if (gender == EPlayerGender.Male && this.MaleQuestRef.TryGetValue(questId, out list3))
		{
			list = list3;
		}
		if (gender == EPlayerGender.None)
		{
			List<string> list4;
			if (this.MaleQuestRef.TryGetValue(questId, out list4))
			{
				list = list4;
			}
			List<string> list5;
			if (this.FemaleQuestRef.TryGetValue(questId, out list5))
			{
				List<string> list6 = new List<string>(list.Count + list5.Count);
				list6.AddRange(list);
				list6.AddRange(list5);
				list = list6;
			}
		}
		List<string> list7 = new List<string>(list.Count);
		HashSet<string> hashSet = new HashSet<string>();
		foreach (string item in list)
		{
			if (hashSet.Add(item))
			{
				list7.Add(item);
			}
		}
		return list7;
	}

	// Token: 0x06011717 RID: 71447 RVA: 0x00525BF8 File Offset: 0x00523DF8
	public int[] GetQuestRefCgIds(int questId)
	{
		HashSet<int> hashSet;
		if (this.QuestRefCgIds.TryGetValue(questId, out hashSet))
		{
			int[] array = new int[hashSet.Count];
			hashSet.CopyTo(array, 0);
			return array;
		}
		return Array.Empty<int>();
	}

	// Token: 0x06011718 RID: 71448 RVA: 0x00525C30 File Offset: 0x00523E30
	public unsafe List<int> FilterVideoByFinishedQuest(IReadOnlyList<int> videoIds)
	{
		List<int> list = new List<int>();
		HashSet<int> hashSet = new HashSet<int>();
		foreach (KeyValuePair<int, HashSet<int>> keyValuePair in this.QuestRefCgIds)
		{
			if (QuestNewModel.Instance.CheckQuestFinished(keyValuePair.Key))
			{
				foreach (int item in keyValuePair.Value)
				{
					hashSet.Add(item);
				}
			}
		}
		foreach (int item2 in videoIds)
		{
			if (!hashSet.Contains(item2))
			{
				list.Add(item2);
			}
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.QuestResource;
		ELogAuthor author = ELogAuthor.HWK;
		string message = "过滤已完成任务视频";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("inputVideos", videoIds);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("outputVideos", list);
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		return list;
	}

	// Token: 0x170019DF RID: 6623
	// (get) Token: 0x06011719 RID: 71449 RVA: 0x00525D80 File Offset: 0x00523F80
	public static QuestResourceModel Instance
	{
		get
		{
			return QuestResourceModel._Instance;
		}
	}

	// Token: 0x0601171A RID: 71450 RVA: 0x00525D87 File Offset: 0x00523F87
	public static QuestResourceModel GetOrCreateInstance()
	{
		if (QuestResourceModel._Instance == null)
		{
			QuestResourceModel.CreateInstance();
		}
		return QuestResourceModel._Instance;
	}

	// Token: 0x0601171B RID: 71451 RVA: 0x00525D9B File Offset: 0x00523F9B
	public static bool CreateInstance()
	{
		if (QuestResourceModel._Instance != null)
		{
			return true;
		}
		QuestResourceModel._Instance = new QuestResourceModel();
		return true;
	}

	// Token: 0x0601171C RID: 71452 RVA: 0x00525DB1 File Offset: 0x00523FB1
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0601171D RID: 71453 RVA: 0x00525DB3 File Offset: 0x00523FB3
	public static void ResetStaticDefaultValue()
	{
		QuestResourceModel._Instance = null;
	}

	// Token: 0x0601171E RID: 71454 RVA: 0x00525DBB File Offset: 0x00523FBB
	static QuestResourceModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(QuestResourceModel.CreateStaticDefaultValue), new Action(QuestResourceModel.ResetStaticDefaultValue));
	}

	// Token: 0x06011720 RID: 71456 RVA: 0x00525E19 File Offset: 0x00524019
	[CompilerGenerated]
	private void <OpenWaitNetworkTypeUserConfirm>g__OnConfirm|42_0()
	{
		this.WaitUserConfirmNetworkTypeViewId = 0;
		CustomPromise<bool> waitUserConfirmNetworkTypePromise = this.WaitUserConfirmNetworkTypePromise;
		if (waitUserConfirmNetworkTypePromise != null && waitUserConfirmNetworkTypePromise.IsPending)
		{
			VideoResUpdate.Instance.SetIsAllowCellDownload(true);
			CustomPromise<bool> waitUserConfirmNetworkTypePromise2 = this.WaitUserConfirmNetworkTypePromise;
			this.WaitUserConfirmNetworkTypePromise = null;
			waitUserConfirmNetworkTypePromise2.SetResult(true);
		}
	}

	// Token: 0x06011721 RID: 71457 RVA: 0x00525E54 File Offset: 0x00524054
	[CompilerGenerated]
	private void <OpenWaitNetworkTypeUserConfirm>g__OnCancelOrClose|42_1()
	{
		this.WaitUserConfirmNetworkTypeViewId = 0;
		CustomPromise<bool> waitUserConfirmNetworkTypePromise = this.WaitUserConfirmNetworkTypePromise;
		if (waitUserConfirmNetworkTypePromise != null && waitUserConfirmNetworkTypePromise.IsPending)
		{
			CustomPromise<bool> waitUserConfirmNetworkTypePromise2 = this.WaitUserConfirmNetworkTypePromise;
			this.WaitUserConfirmNetworkTypePromise = null;
			waitUserConfirmNetworkTypePromise2.SetResult(false);
		}
	}

	// Token: 0x04009907 RID: 39175
	private readonly Dictionary<int, List<string>> MaleQuestRef = new Dictionary<int, List<string>>();

	// Token: 0x04009908 RID: 39176
	private readonly Dictionary<int, List<string>> FemaleQuestRef = new Dictionary<int, List<string>>();

	// Token: 0x04009909 RID: 39177
	private readonly Dictionary<int, HashSet<int>> QuestRefCgIds = new Dictionary<int, HashSet<int>>();

	// Token: 0x0400990A RID: 39178
	private bool UseCachePrepareResourceSize;

	// Token: 0x0400990B RID: 39179
	private int UserFirstSelectedVideoUpdate;

	// Token: 0x0400990C RID: 39180
	[Nullable(2)]
	protected CustomPromise UserClickPromise;

	// Token: 0x0400990D RID: 39181
	[Nullable(2)]
	protected CustomPromise UserDownloadSucPromise;

	// Token: 0x0400990E RID: 39182
	[Nullable(2)]
	protected CustomPromise<bool> UserClickOutOfMemoryViewPromise;

	// Token: 0x0400990F RID: 39183
	[Nullable(2)]
	protected CustomPromise<bool> UserClickNetWorkErrorPromise;

	// Token: 0x04009910 RID: 39184
	public readonly HashSet<int> LoginQuests = new HashSet<int>();

	// Token: 0x04009911 RID: 39185
	public readonly HashSet<int> LoginFinishedQuests = new HashSet<int>();

	// Token: 0x04009912 RID: 39186
	private bool LoginQuestsInitialed;

	// Token: 0x04009913 RID: 39187
	private bool LoginFinishedQuestsInitialed;

	// Token: 0x04009914 RID: 39188
	private QuestResourceUpdateProxy UpdateProxy;

	// Token: 0x04009915 RID: 39189
	private int WaitUserConfirmNetworkTypeViewId;

	// Token: 0x04009916 RID: 39190
	private CustomPromise<bool> WaitUserConfirmNetworkTypePromise;

	// Token: 0x04009917 RID: 39191
	private bool IsDownloadNotEnoughSpaceError;

	// Token: 0x04009918 RID: 39192
	private bool? IsReportDownloadNotEnoughSpace;

	// Token: 0x04009919 RID: 39193
	[Nullable(2)]
	private static QuestResourceModel _Instance;
}
