using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Core.Framework;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.ResManager.Model;
using CSharpScript.Game.Render;
using CSharpScript.Launcher.DiffPatch.Data;
using CSharpScript.Launcher.DiffPatch.Update;
using CSharpScript.Launcher.Update.ResourceDiffUpdate;
using CSharpScript.Launcher.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf;

namespace CSharpScript.Game.Module.ResManager
{
	// Token: 0x02004F0F RID: 20239
	[NullableContext(1)]
	[Nullable(0)]
	[TickController(0)]
	public class ResourceManagerController : ControllerBase
	{
		// Token: 0x06033E3F RID: 212543 RVA: 0x00C28324 File Offset: 0x00C26524
		protected override bool OnInit()
		{
			this.InitBlockDownloadState();
			this.AddEvents();
			return true;
		}

		// Token: 0x06033E40 RID: 212544 RVA: 0x00C28333 File Offset: 0x00C26533
		protected override bool OnClear()
		{
			this.RemoveEvents();
			return true;
		}

		// Token: 0x06033E41 RID: 212545 RVA: 0x00C2833C File Offset: 0x00C2653C
		private void AddEvents()
		{
			EventSystem.Instance.Add(EEventName.OnQuestFinishListNotify, new Action(this.OnQuestFinishListNotify));
			EventSystem.Instance.Add<int, QuestState, EQuestStatusUpdateReason>(EEventName.OnQuestStateChange, new Action<int, QuestState, EQuestStatusUpdateReason>(this.OnQuestStateChange));
		}

		// Token: 0x06033E42 RID: 212546 RVA: 0x00C28376 File Offset: 0x00C26576
		private void RemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.OnQuestFinishListNotify, new Action(this.OnQuestFinishListNotify));
			EventSystem.Instance.Remove(EEventName.OnQuestStateChange, new Action<int, QuestState, EQuestStatusUpdateReason>(this.OnQuestStateChange));
		}

		// Token: 0x06033E43 RID: 212547 RVA: 0x00C283B0 File Offset: 0x00C265B0
		[NullableContext(0)]
		[return: TupleElementNames(new string[]
		{
			"downloaded",
			"needReOpenMap"
		})]
		public ValueTuple<bool, bool> IsBlockResourceDownloaded(int mapId, [Nullable(1)] global::Vector position)
		{
			if (!ResourceDiffUpdaterManager.Instance.IsGrayBoxHit())
			{
				return new ValueTuple<bool, bool>(true, false);
			}
			int mapBlockFromPosition = this.GetMapBlockFromPosition(mapId, position);
			if (mapBlockFromPosition == -1)
			{
				return new ValueTuple<bool, bool>(true, false);
			}
			ResourceManagerModel instance = ResourceManagerModel.Instance;
			return new ValueTuple<bool, bool>(instance.GetBlockDownloadState(mapBlockFromPosition), instance.BlockNeedReOpenMap.Contains(mapBlockFromPosition));
		}

		// Token: 0x06033E44 RID: 212548 RVA: 0x00C28404 File Offset: 0x00C26604
		public List<ResPackageInfo> GetMapBlockResPackageInfos(IReadOnlyList<int> blockIds)
		{
			ResourceManagerModel instance = ResourceManagerModel.Instance;
			List<ResPackageInfo> list = new List<ResPackageInfo>();
			Dictionary<string, ResPackageInfo> optionalDownLoadInfo = ResPackageInfo.OptionalDownLoadInfo;
			HashSet<string> hashSet = new HashSet<string>();
			foreach (int num in blockIds)
			{
				string valueOrDefault = instance.MapBlockIdToPackName.GetValueOrDefault(num);
				if (valueOrDefault != null)
				{
					hashSet.Add(valueOrDefault);
				}
				else
				{
					Log instance2 = Log.Instance;
					ELogModule module = ELogModule.QuestResource;
					ELogAuthor author = ELogAuthor.HWK;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(9, 1);
					defaultInterpolatedStringHandler.AppendLiteral("地块");
					defaultInterpolatedStringHandler.AppendFormatted<int>(num);
					defaultInterpolatedStringHandler.AppendLiteral("没有配置资源包");
					instance2.Warn(module, author, defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
				}
			}
			foreach (string text in hashSet)
			{
				ResPackageInfo valueOrDefault2 = optionalDownLoadInfo.GetValueOrDefault(text);
				if (valueOrDefault2 != null)
				{
					list.Add(valueOrDefault2);
				}
				else
				{
					Log.Instance.Warn(ELogModule.QuestResource, ELogAuthor.HWK, "资源包" + text + "不存在", default(ReadOnlySpan<ValueTuple<string, object>>));
				}
			}
			return list;
		}

		// Token: 0x06033E45 RID: 212549 RVA: 0x00C28548 File Offset: 0x00C26748
		public UniTask InitSubPackageDownloader()
		{
			ResourceManagerController.<InitSubPackageDownloader>d__8 <InitSubPackageDownloader>d__;
			<InitSubPackageDownloader>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitSubPackageDownloader>d__.<>4__this = this;
			<InitSubPackageDownloader>d__.<>1__state = -1;
			<InitSubPackageDownloader>d__.<>t__builder.Start<ResourceManagerController.<InitSubPackageDownloader>d__8>(ref <InitSubPackageDownloader>d__);
			return <InitSubPackageDownloader>d__.<>t__builder.Task;
		}

		// Token: 0x06033E46 RID: 212550 RVA: 0x00C2858B File Offset: 0x00C2678B
		protected override void OnTick(float deltaTime)
		{
			this.TickPushCurBlock(deltaTime);
		}

		// Token: 0x06033E47 RID: 212551 RVA: 0x00C28594 File Offset: 0x00C26794
		private unsafe void TickPushCurBlock(float deltaTime)
		{
			this.PushCurBlockTimer += deltaTime;
			if (this.PushCurBlockTimer >= 3000f)
			{
				this.PushCurBlockTimer = 0f;
				EntityHandle getCurrentEntity = SceneTeamModel.Instance.GetCurrentEntity;
				CharacterActorComponent characterActorComponent;
				if (getCurrentEntity == null)
				{
					characterActorComponent = null;
				}
				else
				{
					WorldEntity entity = getCurrentEntity.Entity;
					characterActorComponent = ((entity != null) ? entity.GetComponent<CharacterActorComponent>() : null);
				}
				CharacterActorComponent characterActorComponent2 = characterActorComponent;
				if (characterActorComponent2 != null)
				{
					int mapBlockFromPosition = this.GetMapBlockFromPosition(GameModeModel.Instance.MapId, characterActorComponent2.ActorLocationProxy);
					if (mapBlockFromPosition >= 0 && mapBlockFromPosition != this.CurBlockId)
					{
						this.CurBlockId = mapBlockFromPosition;
						this.PushCurBlock(new <>z__ReadOnlySingleElementList<int>(mapBlockFromPosition), "地块改变定时推送");
						ResourceDiffUpdaterManager instance = ResourceDiffUpdaterManager.Instance;
						int num = 1;
						List<int> list = new List<int>(num);
						CollectionsMarshal.SetCount<int>(list, num);
						Span<int> span = CollectionsMarshal.AsSpan<int>(list);
						int index = 0;
						*span[index] = mapBlockFromPosition;
						instance.UpdateCurrentBlockIds(list);
					}
					global::Vector actorLocationProxy = characterActorComponent2.ActorLocationProxy;
					ResourceDiffUpdaterManager.Instance.UpdatePositions(GameModeModel.Instance.MapId, actorLocationProxy.X, actorLocationProxy.Y, actorLocationProxy.Z);
				}
			}
		}

		// Token: 0x06033E48 RID: 212552 RVA: 0x00C2868C File Offset: 0x00C2688C
		public void PushCurBlock(IReadOnlyList<int> blockIds, [Nullable(2)] string reason)
		{
			Log.Instance.Info(ELogModule.QuestResource, ELogAuthor.HWK, "推送当前地块:" + string.Join<int>(",", blockIds) + " 原因:" + reason, default(ReadOnlySpan<ValueTuple<string, object>>));
			SceneBlockSplitPlayerNeedBlockPush sceneBlockSplitPlayerNeedBlockPush = SceneBlockSplitPlayerNeedBlockPush.Create();
			sceneBlockSplitPlayerNeedBlockPush.PlayerNeedBlockId.AddRange(blockIds);
			Net.Instance.Send(EPushMessageId.SceneBlockSplitPlayerNeedBlockPush, sceneBlockSplitPlayerNeedBlockPush);
		}

		// Token: 0x06033E49 RID: 212553 RVA: 0x00C286ED File Offset: 0x00C268ED
		public int GetMapBlockFromPosition(int mapId, global::Vector position)
		{
			return ResourceDiffUpdaterManager.Instance.BlockModule.GetMapBlockFromPosition(mapId, position.X, position.Y);
		}

		// Token: 0x06033E4A RID: 212554 RVA: 0x00C2870C File Offset: 0x00C2690C
		[NullableContext(0)]
		public ValueTuple<bool, long, long> GetResourceDownloadStatus([Nullable(1)] string packName)
		{
			ResPackageInfo valueOrDefault = ResPackageInfo.OptionalDownLoadInfo.GetValueOrDefault(packName);
			if (valueOrDefault != null)
			{
				ValueTuple<List<RequireFileInfo>, long, long, long, long, long, long, ValueTuple<long, int>> valueTuple = valueOrDefault.AnalyzeRequireFiles(false, ETier.None);
				long item = valueTuple.Item7;
				long item2 = valueTuple.Rest.Item1;
				return new ValueTuple<bool, long, long>(valueOrDefault.IsCompleteUpdate(), item2, item);
			}
			Log.Instance.Error(ELogModule.QuestResource, ELogAuthor.HWK, "资源包" + packName + "不存在", default(ReadOnlySpan<ValueTuple<string, object>>));
			return new ValueTuple<bool, long, long>(true, 0L, 0L);
		}

		// Token: 0x06033E4B RID: 212555 RVA: 0x00C28784 File Offset: 0x00C26984
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public ValueTuple<long, HashSet<int>> GetUnneededResourceSize(List<int> questIds)
		{
			HashSet<int> unusedVideos = ResourceDiffUpdaterManager.Instance.VideoModule.GetUnusedVideos(new HashSet<int>(questIds));
			return new ValueTuple<long, HashSet<int>>(ResourceDiffUpdaterManager.Instance.VideoModule.GetLocalSizeByVideoIds(unusedVideos), unusedVideos);
		}

		// Token: 0x06033E4C RID: 212556 RVA: 0x00C287C0 File Offset: 0x00C269C0
		public void DeleteUnneededResource(List<int> curQuestIds)
		{
			ValueTuple<long, HashSet<int>> unneededResourceSize = this.GetUnneededResourceSize(curQuestIds);
			long item = unneededResourceSize.Item1;
			HashSet<int> item2 = unneededResourceSize.Item2;
			if (item > 0L)
			{
				ResourceDiffUpdaterManager.Instance.VideoModule.DeleteByVideoIds(item2);
				Log instance = Log.Instance;
				ELogModule module = ELogModule.QuestResource;
				ELogAuthor author = ELogAuthor.HWK;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(16, 1);
				defaultInterpolatedStringHandler.AppendLiteral("删除不需要的视频资源,释放空间:");
				defaultInterpolatedStringHandler.AppendFormatted<long>(item);
				instance.Info(module, author, defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
			}
		}

		// Token: 0x06033E4D RID: 212557 RVA: 0x00C28834 File Offset: 0x00C26A34
		[return: Nullable(new byte[]
		{
			0,
			1,
			1
		})]
		public ValueTuple<int[], int[]> GetQuestRefRes(int questId)
		{
			int[] valueOrDefault = ResourceManagerModel.Instance.QuestsRefBlocks.GetValueOrDefault(questId);
			int[] questRefCgIds = QuestResourceModel.Instance.GetQuestRefCgIds(questId);
			return new ValueTuple<int[], int[]>(valueOrDefault ?? Array.Empty<int>(), questRefCgIds);
		}

		// Token: 0x06033E4E RID: 212558 RVA: 0x00C2886C File Offset: 0x00C26A6C
		[NullableContext(0)]
		public ValueTuple<bool, long, long> GetMp4ResourceDownloadStatus(int videoId)
		{
			List<string> videoResPakByVideoIds = VideoResUpdate.Instance.GetVideoResPakByVideoIds(new List<int>
			{
				videoId
			}, null);
			if (videoResPakByVideoIds.Count <= 0)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.QuestResource;
				ELogAuthor author = ELogAuthor.HWK;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(11, 1);
				defaultInterpolatedStringHandler.AppendLiteral("视频资源");
				defaultInterpolatedStringHandler.AppendFormatted<int>(videoId);
				defaultInterpolatedStringHandler.AppendLiteral("没有配置资源包");
				instance.Error(module, author, defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
				return new ValueTuple<bool, long, long>(true, 0L, 0L);
			}
			ValueTuple<List<RequireFileInfo>, long, long, List<LocalFileInfo>> valueTuple = VideoResUpdate.Instance.AnalyzeRequireFilesByNames(videoResPakByVideoIds);
			long item = valueTuple.Item2;
			long item2 = valueTuple.Item3;
			return new ValueTuple<bool, long, long>(item == item2, item, item2);
		}

		// Token: 0x06033E4F RID: 212559 RVA: 0x00C2891C File Offset: 0x00C26B1C
		private void OnQuestFinishListNotify()
		{
			this.SaveFinishedVideoList();
			List<int> finishQuestList = QuestNewModel.Instance.GetFinishQuestList();
			ResourceDiffUpdaterManager.Instance.UpdateFinishedQuests(finishQuestList);
			if (ResourceDiffUpdaterManager.Instance.IsGrayBoxHit())
			{
				SubPackageDownLoadModel.Instance.UpdaterDownLoadSize();
				this.UpdateToServerResState();
				this.UpdateServerQuestState();
			}
		}

		// Token: 0x06033E50 RID: 212560 RVA: 0x00C28967 File Offset: 0x00C26B67
		private void OnQuestStateChange(int questId, QuestState state, EQuestStatusUpdateReason arg3)
		{
			if (state == QuestState.Finish)
			{
				this.SaveFinishedVideoList();
				ResourceDiffUpdaterManager.Instance.AddFinishedQuest(questId);
				return;
			}
			if (state == QuestState.Progress)
			{
				ResourceDiffUpdaterManager.Instance.AddCurQuest(questId);
			}
		}

		// Token: 0x06033E51 RID: 212561 RVA: 0x00C28990 File Offset: 0x00C26B90
		private unsafe void SaveFinishedVideoList()
		{
			if (KuroSdkController.Instance.CanUseSdk())
			{
				string uid = KuroSdkController.Instance.GetCurrentLoginInfo().Uid;
				List<int> finishQuestList = QuestNewModel.Instance.GetFinishQuestList();
				Dictionary<string, HashSet<int>> dictionary = LauncherStorageLib.Instance.GetGlobal<Dictionary<string, HashSet<int>>>(ELauncherStorageGlobalKey.UserFinishedQuests, null) ?? new Dictionary<string, HashSet<int>>();
				dictionary[uid] = new HashSet<int>(finishQuestList);
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SubPackageDownLoad;
				ELogAuthor author = ELogAuthor.HWK;
				string message = "保存已完成任务列表到本地存储";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("sdkId", uid);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("finishedQuests", finishQuestList);
				instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				LauncherStorageLib.Instance.SetGlobal<Dictionary<string, HashSet<int>>>(ELauncherStorageGlobalKey.UserFinishedQuests, dictionary);
			}
		}

		// Token: 0x06033E52 RID: 212562 RVA: 0x00C28A50 File Offset: 0x00C26C50
		protected void UpdateToServerResState()
		{
			QuestResourceModel instance = QuestResourceModel.Instance;
			instance.RefreshCachePrepareResourceSize();
			instance.CalcPrepareResource();
			long videoResSize = VideoResUpdate.Instance.GetVideoResSize(EVideoResSizeType.MalePrepare);
			long videoResSavedSize = VideoResUpdate.Instance.GetVideoResSavedSize(EVideoResSizeType.MalePrepare);
			long videoResSize2 = VideoResUpdate.Instance.GetVideoResSize(EVideoResSizeType.FemalePrepare);
			long videoResSavedSize2 = VideoResUpdate.Instance.GetVideoResSavedSize(EVideoResSizeType.FemalePrepare);
			bool flag = ResourceDiffUpdaterManager.Instance.BlockModule.IsAllBlockResourceDownloaded();
			EVideoResSizeType newResState = EVideoResSizeType.StartMinNeed;
			if (flag)
			{
				if (VideoResUpdate.Instance.VideoDownloadState == EVideoResSizeType.StartMaxNeed)
				{
					newResState = EVideoResSizeType.StartMaxNeed;
				}
				else if (videoResSize == videoResSavedSize)
				{
					newResState = EVideoResSizeType.MalePrepare;
				}
				else if (videoResSize2 == videoResSavedSize2)
				{
					newResState = EVideoResSizeType.FemalePrepare;
				}
			}
			LauncherStorageLib.Instance.SetDeviceSaved<EVideoResSizeType>(ELauncherStorageDeviceKey.UserSelectedVideoUpdate, newResState);
			Log instance2 = Log.Instance;
			ELogModule module = ELogModule.QuestResource;
			ELogAuthor author = ELogAuthor.ZWY;
			string message = "登录后上报服务器本地资源状态";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ResState", newResState);
			instance2.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			if (newResState != EVideoResSizeType.StartMinNeed)
			{
				SetQuestResourceStateRequest setQuestResourceStateRequest = SetQuestResourceStateRequest.Create();
				setQuestResourceStateRequest.QuestResourceState = (int)newResState;
				Net.Instance.Call(ERequestMessageId.SetQuestResourceStateRequest, setQuestResourceStateRequest, delegate(IMessage msg, Net.CallbackStatus _)
				{
					if ((SetQuestResourceStateResponse)msg != null)
					{
						Log instance4 = Log.Instance;
						ELogModule module3 = ELogModule.QuestResource;
						ELogAuthor author3 = ELogAuthor.ZWY;
						string message3 = "计算出新状态后通知服务器任务资源状态改变";
						ValueTuple<string, object> valueTuple3 = new ValueTuple<string, object>("新状态", newResState);
						instance4.Info(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple3));
					}
				}, 0);
			}
			ESceneBlockSwithState esceneBlockSwithState = ESceneBlockSwithState.BstateAll;
			if (ResourceDiffUpdaterManager.Instance.IsGrayBoxHit())
			{
				esceneBlockSwithState = (flag ? ESceneBlockSwithState.BstateComplete : ESceneBlockSwithState.BstateSimple);
			}
			Log instance3 = Log.Instance;
			ELogModule module2 = ELogModule.QuestResource;
			ELogAuthor author2 = ELogAuthor.ZWY;
			string message2 = "登录后上报服务器地块资源状态";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("BlockState", esceneBlockSwithState);
			instance3.Info(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			SceneBlockSplitSwitchStatePush sceneBlockSplitSwitchStatePush = SceneBlockSplitSwitchStatePush.Create();
			sceneBlockSplitSwitchStatePush.SwitchState = esceneBlockSwithState;
			Net.Instance.Send(EPushMessageId.SceneBlockSplitSwitchStatePush, sceneBlockSplitSwitchStatePush);
		}

		// Token: 0x06033E53 RID: 212563 RVA: 0x00C28BD8 File Offset: 0x00C26DD8
		public void UpdateBlockDownloadState(int blockId, bool downloaded)
		{
			ResourceManagerModel instance = ResourceManagerModel.Instance;
			if (instance.GetBlockDownloadState(blockId) == downloaded)
			{
				return;
			}
			MapBlockInfo? config = ConfigMapBlockInfoById.GetConfig(blockId, true);
			if (config != null)
			{
				instance.SetBlockDownloadState(blockId, downloaded);
				if (config.Value.MapId == GameModeModel.Instance.MapId)
				{
					instance.BlockNeedReOpenMap.Add(blockId);
					return;
				}
				RenderModuleController.Instance.SetWorldPartitionDataLayerState(config.Value.BlockDatalayer, !downloaded, false);
			}
		}

		// Token: 0x06033E54 RID: 212564 RVA: 0x00C28C56 File Offset: 0x00C26E56
		public bool IsNeedReOpenMap(int blockId)
		{
			return ResourceManagerModel.Instance.BlockNeedReOpenMap.Contains(blockId);
		}

		// Token: 0x06033E55 RID: 212565 RVA: 0x00C28C68 File Offset: 0x00C26E68
		public void UpdateServerQuestState()
		{
			if (!ResourceDiffUpdaterManager.Instance.IsGrayBoxHit())
			{
				return;
			}
			QuestResourceModel instance = QuestResourceModel.Instance;
			HashSet<int> hashSet = new HashSet<int>();
			EPlayerGender playerGender = PlayerInfoModel.Instance.GetPlayerGender();
			HashSet<int> hashSet2 = new HashSet<int>();
			if (playerGender == EPlayerGender.Female)
			{
				using (Dictionary<int, List<string>>.Enumerator enumerator = instance.FemaleQuestIdToPack.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						KeyValuePair<int, List<string>> keyValuePair = enumerator.Current;
						int key = keyValuePair.Key;
						hashSet2.Add(key);
						if (!QuestNewModel.Instance.CheckQuestFinished(key) && this.IsQuestResourceDownloaded(key, playerGender))
						{
							hashSet.Add(key);
						}
					}
					goto IL_FB;
				}
			}
			if (playerGender == EPlayerGender.Male)
			{
				foreach (KeyValuePair<int, List<string>> keyValuePair2 in instance.MaleQuestIdToPack)
				{
					int key2 = keyValuePair2.Key;
					hashSet2.Add(key2);
					if (!QuestNewModel.Instance.CheckQuestFinished(key2) && this.IsQuestResourceDownloaded(key2, playerGender))
					{
						hashSet.Add(key2);
					}
				}
			}
			IL_FB:
			foreach (KeyValuePair<int, int[]> keyValuePair3 in ResourceManagerModel.Instance.QuestsRefBlocks)
			{
				int key3 = keyValuePair3.Key;
				if (!hashSet2.Contains(key3) && !QuestNewModel.Instance.CheckQuestFinished(key3) && this.IsQuestResourceDownloaded(key3, playerGender))
				{
					hashSet.Add(key3);
				}
			}
			FinishDownloadQuestResourceRequest finishDownloadQuestResourceRequest = FinishDownloadQuestResourceRequest.Create();
			finishDownloadQuestResourceRequest.QuestIds.AddRange(hashSet);
			Log instance2 = Log.Instance;
			ELogModule module = ELogModule.QuestResource;
			ELogAuthor author = ELogAuthor.ZWY;
			string message = "通知服务器登录任务下载完成";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("LoginQuests", hashSet);
			instance2.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			Net.Instance.Call(ERequestMessageId.FinishDownloadQuestResourceRequest, finishDownloadQuestResourceRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				FinishDownloadQuestResourceResponse finishDownloadQuestResourceResponse = (FinishDownloadQuestResourceResponse)msg;
				if (finishDownloadQuestResourceResponse != null && finishDownloadQuestResourceResponse.ErrorId != Aki.Protocol.ErrorCode.Success)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(finishDownloadQuestResourceResponse.ErrorId, EResponseMessageId.FinishDownloadQuestResourceResponse, null, true, true);
				}
			}, 0);
		}

		// Token: 0x06033E56 RID: 212566 RVA: 0x00C28E70 File Offset: 0x00C27070
		public List<int> GetDownloadedQuestListBeforeLogin(EPlayerGender gender = EPlayerGender.None)
		{
			List<int> list = new List<int>();
			QuestResourceModel instance = QuestResourceModel.Instance;
			ResourceManagerModel instance2 = ResourceManagerModel.Instance;
			HashSet<int> hashSet = new HashSet<int>();
			IEnumerable<QuestResourceWhite> enumerable = ConfigQuestResourceWhiteAll.GetConfigList(true) ?? Array.Empty<QuestResourceWhite>();
			HashSet<int> hashSet2 = new HashSet<int>();
			foreach (QuestResourceWhite questResourceWhite in enumerable)
			{
				hashSet2.Add(questResourceWhite.QuestId);
			}
			foreach (KeyValuePair<int, HashSet<int>> keyValuePair in instance.QuestIdToCgIds)
			{
				if (!hashSet2.Contains(keyValuePair.Key))
				{
					hashSet.Add(keyValuePair.Key);
				}
			}
			foreach (KeyValuePair<int, int[]> keyValuePair2 in instance2.QuestsRefBlocks)
			{
				if (!hashSet2.Contains(keyValuePair2.Key))
				{
					hashSet.Add(keyValuePair2.Key);
				}
			}
			foreach (int num in hashSet)
			{
				if (QuestNewModel.Instance.GetQuestConfig(num) != null && this.IsQuestResourceDownloaded(num, gender))
				{
					list.Add(num);
				}
			}
			Log instance3 = Log.Instance;
			ELogModule module = ELogModule.QuestResource;
			ELogAuthor author = ELogAuthor.HWK;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(21, 2);
			defaultInterpolatedStringHandler.AppendLiteral("登录前已完成资源下载的任务列表:");
			defaultInterpolatedStringHandler.AppendFormatted(string.Join<int>(",", list));
			defaultInterpolatedStringHandler.AppendLiteral(", 性别:");
			defaultInterpolatedStringHandler.AppendFormatted<EPlayerGender>(gender);
			instance3.Info(module, author, defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
			return list;
		}

		// Token: 0x06033E57 RID: 212567 RVA: 0x00C29060 File Offset: 0x00C27260
		public bool IsQuestResourceDownloaded(int questId, EPlayerGender gender)
		{
			ResourceManagerModel instance = ResourceManagerModel.Instance;
			int[] valueOrDefault = instance.QuestsRefBlocks.GetValueOrDefault(questId);
			if (valueOrDefault != null)
			{
				foreach (int num in valueOrDefault)
				{
					string valueOrDefault2 = instance.MapBlockIdToPackName.GetValueOrDefault(num);
					if (valueOrDefault2 != null)
					{
						ResPackageInfo valueOrDefault3 = ResPackageInfo.OptionalDownLoadInfo.GetValueOrDefault(valueOrDefault2);
						if (valueOrDefault3 != null && !valueOrDefault3.IsCompleteDownload())
						{
							Log instance2 = Log.Instance;
							ELogModule module = ELogModule.QuestResource;
							ELogAuthor author = ELogAuthor.HWK;
							DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(13, 2);
							defaultInterpolatedStringHandler.AppendLiteral("任务");
							defaultInterpolatedStringHandler.AppendFormatted<int>(questId);
							defaultInterpolatedStringHandler.AppendLiteral("依赖地块");
							defaultInterpolatedStringHandler.AppendFormatted<int>(num);
							defaultInterpolatedStringHandler.AppendLiteral("资源未下载完成");
							instance2.Info(module, author, defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
							return false;
						}
					}
				}
			}
			List<string> questRefPakNames = QuestResourceModel.Instance.GetQuestRefPakNames(questId, gender);
			ValueTuple<List<RequireFileInfo>, long, long, List<LocalFileInfo>> valueTuple = VideoResUpdate.Instance.AnalyzeRequireFilesByNames(questRefPakNames);
			long item = valueTuple.Item2;
			long item2 = valueTuple.Item3;
			bool flag = item == item2;
			if (!flag)
			{
				Log instance3 = Log.Instance;
				ELogModule module2 = ELogModule.QuestResource;
				ELogAuthor author2 = ELogAuthor.HWK;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(13, 1);
				defaultInterpolatedStringHandler.AppendLiteral("任务");
				defaultInterpolatedStringHandler.AppendFormatted<int>(questId);
				defaultInterpolatedStringHandler.AppendLiteral("依赖视频资源未下载完成");
				instance3.Info(module2, author2, defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			return flag;
		}

		// Token: 0x06033E58 RID: 212568 RVA: 0x00C291B0 File Offset: 0x00C273B0
		public void InitBlockDownloadState()
		{
			ResourceManagerModel instance = ResourceManagerModel.Instance;
			foreach (KeyValuePair<int, string> keyValuePair in instance.MapBlockIdToPackName)
			{
				int key = keyValuePair.Key;
				string value = keyValuePair.Value;
				ResPackageInfo valueOrDefault = ResPackageInfo.OptionalDownLoadInfo.GetValueOrDefault(value);
				if (valueOrDefault != null)
				{
					bool flag = valueOrDefault.IsCompleteDownload();
					instance.SetBlockDownloadState(key, flag);
					MapBlockInfo? config = ConfigMapBlockInfoById.GetConfig(key, true);
					if (config != null)
					{
						RenderModuleController.Instance.SetWorldPartitionDataLayerState(config.Value.BlockDatalayer, !flag, false);
					}
				}
				else
				{
					Log instance2 = Log.Instance;
					ELogModule module = ELogModule.QuestResource;
					ELogAuthor author = ELogAuthor.HWK;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(32, 2);
					defaultInterpolatedStringHandler.AppendLiteral("地块");
					defaultInterpolatedStringHandler.AppendFormatted<int>(key);
					defaultInterpolatedStringHandler.AppendLiteral(",packName:");
					defaultInterpolatedStringHandler.AppendFormatted(value);
					defaultInterpolatedStringHandler.AppendLiteral("对应的ResPackageInfo不存在");
					instance2.Warn(module, author, defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
				}
			}
		}

		// Token: 0x06033E59 RID: 212569 RVA: 0x00C292D4 File Offset: 0x00C274D4
		public UniTask TestDownload()
		{
			ResourceManagerController.<TestDownload>d__30 <TestDownload>d__;
			<TestDownload>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<TestDownload>d__.<>4__this = this;
			<TestDownload>d__.<>1__state = -1;
			<TestDownload>d__.<>t__builder.Start<ResourceManagerController.<TestDownload>d__30>(ref <TestDownload>d__);
			return <TestDownload>d__.<>t__builder.Task;
		}

		// Token: 0x06033E5A RID: 212570 RVA: 0x00C29318 File Offset: 0x00C27518
		public void ChangeHttpTickFrequency()
		{
			Log.Instance.Info(ELogModule.SubPackageDownLoad, ELogAuthor.HWK, "ChangeHttpTickFrequency: set http tick to max", default(ReadOnlySpan<ValueTuple<string, object>>));
			Http.SetHttpThreadActiveMinimumSleepTimeInSeconds(0f);
			Http.SetHttpThreadIdleMinimumSleepTimeInSeconds(0f);
		}

		// Token: 0x06033E5B RID: 212571 RVA: 0x00C29358 File Offset: 0x00C27558
		public void RestoreHttpTickFrequency()
		{
			Log.Instance.Info(ELogModule.SubPackageDownLoad, ELogAuthor.HWK, "RestoreHttpTickFrequency: restore http tick to game default", default(ReadOnlySpan<ValueTuple<string, object>>));
			Http.SetHttpThreadActiveMinimumSleepTimeInSeconds(0.005f);
			Http.SetHttpThreadIdleMinimumSleepTimeInSeconds(0.033f);
		}

		// Token: 0x17007F39 RID: 32569
		// (get) Token: 0x06033E5C RID: 212572 RVA: 0x00C29398 File Offset: 0x00C27598
		public static ResourceManagerController Instance
		{
			get
			{
				return ResourceManagerController._Instance;
			}
		}

		// Token: 0x06033E5D RID: 212573 RVA: 0x00C2939F File Offset: 0x00C2759F
		public static ResourceManagerController GetOrCreateInstance()
		{
			if (ResourceManagerController._Instance == null)
			{
				ResourceManagerController.CreateInstance();
			}
			return ResourceManagerController._Instance;
		}

		// Token: 0x06033E5E RID: 212574 RVA: 0x00C293B3 File Offset: 0x00C275B3
		public static bool CreateInstance()
		{
			if (ResourceManagerController._Instance != null)
			{
				return true;
			}
			ResourceManagerController._Instance = new ResourceManagerController();
			return true;
		}

		// Token: 0x06033E5F RID: 212575 RVA: 0x00C293C9 File Offset: 0x00C275C9
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06033E60 RID: 212576 RVA: 0x00C293CB File Offset: 0x00C275CB
		public static void ResetStaticDefaultValue()
		{
			ResourceManagerController._Instance = null;
		}

		// Token: 0x06033E61 RID: 212577 RVA: 0x00C293D3 File Offset: 0x00C275D3
		static ResourceManagerController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ResourceManagerController.CreateStaticDefaultValue), new Action(ResourceManagerController.ResetStaticDefaultValue));
		}

		// Token: 0x0401B956 RID: 112982
		private const int CUE_BLOCK_PUSH_TIME = 3000;

		// Token: 0x0401B957 RID: 112983
		[Nullable(2)]
		public CustomPromise LoginPrepareResCheckPromise;

		// Token: 0x0401B958 RID: 112984
		private float PushCurBlockTimer;

		// Token: 0x0401B959 RID: 112985
		private int CurBlockId = -1;

		// Token: 0x0401B95A RID: 112986
		[Nullable(2)]
		private static ResourceManagerController _Instance;
	}
}
