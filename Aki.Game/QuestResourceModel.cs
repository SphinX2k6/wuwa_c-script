using System;
using System.Collections.Generic;
using System.Linq;
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

// Token: 0x0200266A RID: 9834
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class QuestResourceModel : ModelBase
{
	// Token: 0x170019A3 RID: 6563
	// (get) Token: 0x06014218 RID: 82456 RVA: 0x00515EB5 File Offset: 0x005140B5
	public bool IsSeparateVideo
	{
		get
		{
			return VideoResUpdate.Instance.GetIsSeparateVideo();
		}
	}

	// Token: 0x06014219 RID: 82457 RVA: 0x00515EC4 File Offset: 0x005140C4
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
		VideoResUpdate.Instance.SetAllSpecialVideoResPak(EVideoResSizeType.FemalePrepare, hashSet2.ToList<string>());
		VideoResUpdate.Instance.SetAllSpecialVideoResPak(EVideoResSizeType.MalePrepare, hashSet.ToList<string>());
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

	// Token: 0x170019A4 RID: 6564
	// (get) Token: 0x0601421A RID: 82458 RVA: 0x00516164 File Offset: 0x00514364
	public Dictionary<int, List<string>> FemaleQuestIdToPack
	{
		get
		{
			return this.FemaleQuestRef;
		}
	}

	// Token: 0x170019A5 RID: 6565
	// (get) Token: 0x0601421B RID: 82459 RVA: 0x0051616C File Offset: 0x0051436C
	public Dictionary<int, List<string>> MaleQuestIdToPack
	{
		get
		{
			return this.MaleQuestRef;
		}
	}

	// Token: 0x170019A6 RID: 6566
	// (get) Token: 0x0601421C RID: 82460 RVA: 0x00516174 File Offset: 0x00514374
	public Dictionary<int, HashSet<int>> QuestIdToCgIds
	{
		get
		{
			return this.QuestRefCgIds;
		}
	}

	// Token: 0x0601421D RID: 82461 RVA: 0x0051617C File Offset: 0x0051437C
	protected override bool OnClear()
	{
		VideoResUpdate.Instance.GetIsSeparateVideo();
		return true;
	}

	// Token: 0x0601421E RID: 82462 RVA: 0x0051618A File Offset: 0x0051438A
	public void ClearCheckQuests()
	{
		this.LoginQuests.Clear();
	}

	// Token: 0x0601421F RID: 82463 RVA: 0x00516198 File Offset: 0x00514398
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

	// Token: 0x06014220 RID: 82464 RVA: 0x00516204 File Offset: 0x00514404
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

	// Token: 0x06014221 RID: 82465 RVA: 0x00516270 File Offset: 0x00514470
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
			return hashSet.ToList<string>();
		}
		return new List<string>();
	}

	// Token: 0x06014222 RID: 82466 RVA: 0x005163D8 File Offset: 0x005145D8
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
			return hashSet.ToList<string>();
		}
		return new List<string>();
	}

	// Token: 0x06014223 RID: 82467 RVA: 0x00516548 File Offset: 0x00514748
	public bool NeedCheckQuestResource()
	{
		List<string> loginNeedDownloadPakNames = this.GetLoginNeedDownloadPakNames();
		ValueTuple<List<RequireFileInfo>, long, long, List<LocalFileInfo>> valueTuple = VideoResUpdate.Instance.AnalyzeRequireFilesByNames(loginNeedDownloadPakNames);
		return valueTuple.Item2 != valueTuple.Item3;
	}

	// Token: 0x06014224 RID: 82468 RVA: 0x00516579 File Offset: 0x00514779
	public List<string> GetLoginNeedDownloadPakNames()
	{
		if (ResourceDiffUpdaterManager.Instance.IsGrayBoxHit())
		{
			return this.GetLoginQuestsPakNames();
		}
		return this.GetLoginPakNamesWithoutFinishedQuests(EPlayerGender.None);
	}

	// Token: 0x06014225 RID: 82469 RVA: 0x00516598 File Offset: 0x00514798
	public void UserClicked()
	{
		if (this.UserClickPromise != null)
		{
			this.UserClickPromise.SetResult();
			return;
		}
		Log.Instance.Error(ELogModule.QuestResource, ELogAuthor.ZWY, "检查任务数据点击回调错误", default(ReadOnlySpan<ValueTuple<string, object>>));
	}

	// Token: 0x06014226 RID: 82470 RVA: 0x005165D8 File Offset: 0x005147D8
	public void UserDownloadSuc()
	{
		if (this.UserDownloadSucPromise != null)
		{
			this.UserDownloadSucPromise.SetResult();
			return;
		}
		Log.Instance.Error(ELogModule.QuestResource, ELogAuthor.ZWY, "检查任务下载回调错误", default(ReadOnlySpan<ValueTuple<string, object>>));
	}

	// Token: 0x06014227 RID: 82471 RVA: 0x00516618 File Offset: 0x00514818
	public void UserClickOutOfMemoryView(bool result)
	{
		if (this.UserClickOutOfMemoryViewPromise != null)
		{
			this.UserClickOutOfMemoryViewPromise.SetResult(result);
			return;
		}
		Log.Instance.Error(ELogModule.QuestResource, ELogAuthor.ZWY, "检查任务硬盘不足回调错误", default(ReadOnlySpan<ValueTuple<string, object>>));
	}

	// Token: 0x06014228 RID: 82472 RVA: 0x00516658 File Offset: 0x00514858
	public void UserClickNetWorkError(bool result)
	{
		if (this.UserClickNetWorkErrorPromise != null)
		{
			this.UserClickNetWorkErrorPromise.SetResult(result);
			return;
		}
		Log.Instance.Error(ELogModule.QuestResource, ELogAuthor.ZWY, "检查任务网络异常回调错误", default(ReadOnlySpan<ValueTuple<string, object>>));
	}

	// Token: 0x06014229 RID: 82473 RVA: 0x00516696 File Offset: 0x00514896
	public void SetIsDownloadNotEnoughSpaceError(bool result)
	{
		this.IsDownloadNotEnoughSpaceError = result;
	}

	// Token: 0x0601422A RID: 82474 RVA: 0x0051669F File Offset: 0x0051489F
	public void SetIsReportDownloadNotEnoughSpace(bool result)
	{
		this.IsReportDownloadNotEnoughSpace = new bool?(result);
	}

	// Token: 0x0601422B RID: 82475 RVA: 0x005166B0 File Offset: 0x005148B0
	public UniTask CheckQuestResource()
	{
		QuestResourceModel.<CheckQuestResource>d__41 <CheckQuestResource>d__;
		<CheckQuestResource>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CheckQuestResource>d__.<>4__this = this;
		<CheckQuestResource>d__.<>1__state = -1;
		<CheckQuestResource>d__.<>t__builder.Start<QuestResourceModel.<CheckQuestResource>d__41>(ref <CheckQuestResource>d__);
		return <CheckQuestResource>d__.<>t__builder.Task;
	}

	// Token: 0x0601422C RID: 82476 RVA: 0x005166F4 File Offset: 0x005148F4
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

	// Token: 0x0601422D RID: 82477 RVA: 0x005167C4 File Offset: 0x005149C4
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

	// Token: 0x0601422E RID: 82478 RVA: 0x00516828 File Offset: 0x00514A28
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

	// Token: 0x0601422F RID: 82479 RVA: 0x0051686C File Offset: 0x00514A6C
	public UniTask TryCheckQuestResource()
	{
		QuestResourceModel.<TryCheckQuestResource>d__45 <TryCheckQuestResource>d__;
		<TryCheckQuestResource>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<TryCheckQuestResource>d__.<>4__this = this;
		<TryCheckQuestResource>d__.<>1__state = -1;
		<TryCheckQuestResource>d__.<>t__builder.Start<QuestResourceModel.<TryCheckQuestResource>d__45>(ref <TryCheckQuestResource>d__);
		return <TryCheckQuestResource>d__.<>t__builder.Task;
	}

	// Token: 0x06014230 RID: 82480 RVA: 0x005168B0 File Offset: 0x00514AB0
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

	// Token: 0x06014231 RID: 82481 RVA: 0x005168F4 File Offset: 0x00514AF4
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
		this.FillCheckQuests(response.NeedConfirmQuestIds.ToArray<int>());
		this.FillFinishedQuests(response.FinishMp4QuestIds.ToArray<int>());
		return true;
	}

	// Token: 0x06014232 RID: 82482 RVA: 0x00516980 File Offset: 0x00514B80
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
		ValueTuple<List<RequireFileInfo>, long, long, List<LocalFileInfo>> valueTuple = VideoResUpdate.Instance.AnalyzeRequireFilesByNames(hashSet.ToList<string>());
		long item2 = valueTuple.Item2;
		long item3 = valueTuple.Item3;
		VideoResUpdate.Instance.SetVideoResSize(EVideoResSizeType.FemalePrepare, item2);
		VideoResUpdate.Instance.SetVideoResSavedSize(EVideoResSizeType.FemalePrepare, item3);
		VideoResUpdate.Instance.SetVideoResPak(EVideoResSizeType.FemalePrepare, hashSet.ToList<string>());
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
		ValueTuple<List<RequireFileInfo>, long, long, List<LocalFileInfo>> valueTuple2 = VideoResUpdate.Instance.AnalyzeRequireFilesByNames(hashSet2.ToList<string>());
		long item5 = valueTuple2.Item2;
		long item6 = valueTuple2.Item3;
		VideoResUpdate.Instance.SetVideoResSize(EVideoResSizeType.MalePrepare, item5);
		VideoResUpdate.Instance.SetVideoResSavedSize(EVideoResSizeType.MalePrepare, item6);
		VideoResUpdate.Instance.SetVideoResPak(EVideoResSizeType.MalePrepare, hashSet2.ToList<string>());
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

	// Token: 0x06014233 RID: 82483 RVA: 0x00516E20 File Offset: 0x00515020
	public void RefreshCachePrepareResourceSize()
	{
		this.UseCachePrepareResourceSize = false;
	}

	// Token: 0x06014234 RID: 82484 RVA: 0x00516E2C File Offset: 0x0051502C
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
			List<string> second;
			if (this.FemaleQuestRef.TryGetValue(questId, out second))
			{
				list = list.Concat(second).ToList<string>();
			}
		}
		return list.Distinct<string>().ToList<string>();
	}

	// Token: 0x06014235 RID: 82485 RVA: 0x00516EAC File Offset: 0x005150AC
	public int[] GetQuestRefCgIds(int questId)
	{
		HashSet<int> source;
		if (this.QuestRefCgIds.TryGetValue(questId, out source))
		{
			return source.ToArray<int>();
		}
		return Array.Empty<int>();
	}

	// Token: 0x06014236 RID: 82486 RVA: 0x00516ED8 File Offset: 0x005150D8
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

	// Token: 0x170019A7 RID: 6567
	// (get) Token: 0x06014237 RID: 82487 RVA: 0x00517028 File Offset: 0x00515228
	public static QuestResourceModel Instance
	{
		get
		{
			return QuestResourceModel._Instance;
		}
	}

	// Token: 0x06014238 RID: 82488 RVA: 0x0051702F File Offset: 0x0051522F
	public static QuestResourceModel GetOrCreateInstance()
	{
		if (QuestResourceModel._Instance == null)
		{
			QuestResourceModel.CreateInstance();
		}
		return QuestResourceModel._Instance;
	}

	// Token: 0x06014239 RID: 82489 RVA: 0x00517043 File Offset: 0x00515243
	public static bool CreateInstance()
	{
		if (QuestResourceModel._Instance != null)
		{
			return true;
		}
		QuestResourceModel._Instance = new QuestResourceModel();
		return true;
	}

	// Token: 0x0601423A RID: 82490 RVA: 0x00517059 File Offset: 0x00515259
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0601423B RID: 82491 RVA: 0x0051705B File Offset: 0x0051525B
	public static void ResetStaticDefaultValue()
	{
		QuestResourceModel._Instance = null;
	}

	// Token: 0x0601423C RID: 82492 RVA: 0x00517063 File Offset: 0x00515263
	static QuestResourceModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(QuestResourceModel.CreateStaticDefaultValue), new Action(QuestResourceModel.ResetStaticDefaultValue));
	}

	// Token: 0x0601423E RID: 82494 RVA: 0x005170C1 File Offset: 0x005152C1
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

	// Token: 0x0601423F RID: 82495 RVA: 0x005170FC File Offset: 0x005152FC
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

	// Token: 0x040097AF RID: 38831
	private readonly Dictionary<int, List<string>> MaleQuestRef = new Dictionary<int, List<string>>();

	// Token: 0x040097B0 RID: 38832
	private readonly Dictionary<int, List<string>> FemaleQuestRef = new Dictionary<int, List<string>>();

	// Token: 0x040097B1 RID: 38833
	private readonly Dictionary<int, HashSet<int>> QuestRefCgIds = new Dictionary<int, HashSet<int>>();

	// Token: 0x040097B2 RID: 38834
	private bool UseCachePrepareResourceSize;

	// Token: 0x040097B3 RID: 38835
	private int UserFirstSelectedVideoUpdate;

	// Token: 0x040097B4 RID: 38836
	[Nullable(2)]
	protected CustomPromise UserClickPromise;

	// Token: 0x040097B5 RID: 38837
	[Nullable(2)]
	protected CustomPromise UserDownloadSucPromise;

	// Token: 0x040097B6 RID: 38838
	[Nullable(2)]
	protected CustomPromise<bool> UserClickOutOfMemoryViewPromise;

	// Token: 0x040097B7 RID: 38839
	[Nullable(2)]
	protected CustomPromise<bool> UserClickNetWorkErrorPromise;

	// Token: 0x040097B8 RID: 38840
	public readonly HashSet<int> LoginQuests = new HashSet<int>();

	// Token: 0x040097B9 RID: 38841
	public readonly HashSet<int> LoginFinishedQuests = new HashSet<int>();

	// Token: 0x040097BA RID: 38842
	private bool LoginQuestsInitialed;

	// Token: 0x040097BB RID: 38843
	private bool LoginFinishedQuestsInitialed;

	// Token: 0x040097BC RID: 38844
	private QuestResourceUpdateProxy UpdateProxy;

	// Token: 0x040097BD RID: 38845
	private int WaitUserConfirmNetworkTypeViewId;

	// Token: 0x040097BE RID: 38846
	private CustomPromise<bool> WaitUserConfirmNetworkTypePromise;

	// Token: 0x040097BF RID: 38847
	private bool IsDownloadNotEnoughSpaceError;

	// Token: 0x040097C0 RID: 38848
	private bool? IsReportDownloadNotEnoughSpace;

	// Token: 0x040097C1 RID: 38849
	[Nullable(2)]
	private static QuestResourceModel _Instance;
}
