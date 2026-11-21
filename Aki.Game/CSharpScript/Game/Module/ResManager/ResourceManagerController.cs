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
	// Token: 0x02003ED8 RID: 16088
	[NullableContext(1)]
	[Nullable(0)]
	[TickController(0)]
	public class ResourceManagerController : ControllerBase
	{
		// Token: 0x06028CAA RID: 167082 RVA: 0x00B71914 File Offset: 0x00B6FB14
		protected override bool OnInit()
		{
			this.InitBlockDownloadState();
			this.AddEvents();
			return true;
		}

		// Token: 0x06028CAB RID: 167083 RVA: 0x00B71923 File Offset: 0x00B6FB23
		protected override bool OnClear()
		{
			this.RemoveEvents();
			return true;
		}

		// Token: 0x06028CAC RID: 167084 RVA: 0x00B7192C File Offset: 0x00B6FB2C
		private void AddEvents()
		{
			EventSystem.Instance.Add(EEventName.OnNormalQuestFinishListNotify, new Action(this.OnQuestFinishListNotify));
			EventSystem.Instance.Add<int, QuestState, EQuestStatusUpdateReason>(EEventName.OnQuestStateChange, new Action<int, QuestState, EQuestStatusUpdateReason>(this.OnQuestStateChange));
		}

		// Token: 0x06028CAD RID: 167085 RVA: 0x00B71966 File Offset: 0x00B6FB66
		private void RemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.OnNormalQuestFinishListNotify, new Action(this.OnQuestFinishListNotify));
			EventSystem.Instance.Remove(EEventName.OnQuestStateChange, new Action<int, QuestState, EQuestStatusUpdateReason>(this.OnQuestStateChange));
		}

		// Token: 0x06028CAE RID: 167086 RVA: 0x00B719A0 File Offset: 0x00B6FBA0
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

		// Token: 0x06028CAF RID: 167087 RVA: 0x00B719F4 File Offset: 0x00B6FBF4
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

		// Token: 0x06028CB0 RID: 167088 RVA: 0x00B71B38 File Offset: 0x00B6FD38
		public UniTask InitSubPackageDownloader()
		{
			ResourceManagerController.<InitSubPackageDownloader>d__8 <InitSubPackageDownloader>d__;
			<InitSubPackageDownloader>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitSubPackageDownloader>d__.<>4__this = this;
			<InitSubPackageDownloader>d__.<>1__state = -1;
			<InitSubPackageDownloader>d__.<>t__builder.Start<ResourceManagerController.<InitSubPackageDownloader>d__8>(ref <InitSubPackageDownloader>d__);
			return <InitSubPackageDownloader>d__.<>t__builder.Task;
		}

		// Token: 0x06028CB1 RID: 167089 RVA: 0x00B71B7B File Offset: 0x00B6FD7B
		protected override void OnTick(float deltaTime)
		{
			this.TickPushCurBlock(deltaTime);
		}

		// Token: 0x06028CB2 RID: 167090 RVA: 0x00B71B84 File Offset: 0x00B6FD84
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

		// Token: 0x06028CB3 RID: 167091 RVA: 0x00B71C7C File Offset: 0x00B6FE7C
		public void PushCurBlock(IReadOnlyList<int> blockIds, [Nullable(2)] string reason)
		{
			Log.Instance.Info(ELogModule.QuestResource, ELogAuthor.HWK, "推送当前地块:" + string.Join<int>(",", blockIds) + " 原因:" + reason, default(ReadOnlySpan<ValueTuple<string, object>>));
			SceneBlockSplitPlayerNeedBlockPush sceneBlockSplitPlayerNeedBlockPush = SceneBlockSplitPlayerNeedBlockPush.Create();
			sceneBlockSplitPlayerNeedBlockPush.PlayerNeedBlockId.AddRange(blockIds);
			Net.Instance.Send(EPushMessageId.SceneBlockSplitPlayerNeedBlockPush, sceneBlockSplitPlayerNeedBlockPush);
		}

		// Token: 0x06028CB4 RID: 167092 RVA: 0x00B71CDD File Offset: 0x00B6FEDD
		public int GetMapBlockFromPosition(int mapId, global::Vector position)
		{
			return ResourceDiffUpdaterManager.Instance.BlockModule.GetMapBlockFromPosition(mapId, position.X, position.Y);
		}

		// Token: 0x06028CB5 RID: 167093 RVA: 0x00B71CFC File Offset: 0x00B6FEFC
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

		// Token: 0x06028CB6 RID: 167094 RVA: 0x00B71D74 File Offset: 0x00B6FF74
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

		// Token: 0x06028CB7 RID: 167095 RVA: 0x00B71DB0 File Offset: 0x00B6FFB0
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

		// Token: 0x06028CB8 RID: 167096 RVA: 0x00B71E24 File Offset: 0x00B70024
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

		// Token: 0x06028CB9 RID: 167097 RVA: 0x00B71E5C File Offset: 0x00B7005C
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

		// Token: 0x06028CBA RID: 167098 RVA: 0x00B71F0C File Offset: 0x00B7010C
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

		// Token: 0x06028CBB RID: 167099 RVA: 0x00B71F57 File Offset: 0x00B70157
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

		// Token: 0x06028CBC RID: 167100 RVA: 0x00B71F80 File Offset: 0x00B70180
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

		// Token: 0x06028CBD RID: 167101 RVA: 0x00B72040 File Offset: 0x00B70240
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

		// Token: 0x06028CBE RID: 167102 RVA: 0x00B721C8 File Offset: 0x00B703C8
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

		// Token: 0x06028CBF RID: 167103 RVA: 0x00B72246 File Offset: 0x00B70446
		public bool IsNeedReOpenMap(int blockId)
		{
			return ResourceManagerModel.Instance.BlockNeedReOpenMap.Contains(blockId);
		}

		// Token: 0x06028CC0 RID: 167104 RVA: 0x00B72258 File Offset: 0x00B70458
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

		// Token: 0x06028CC1 RID: 167105 RVA: 0x00B72460 File Offset: 0x00B70660
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

		// Token: 0x06028CC2 RID: 167106 RVA: 0x00B72650 File Offset: 0x00B70850
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

		// Token: 0x06028CC3 RID: 167107 RVA: 0x00B727A0 File Offset: 0x00B709A0
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

		// Token: 0x06028CC4 RID: 167108 RVA: 0x00B728C4 File Offset: 0x00B70AC4
		public UniTask TestDownload()
		{
			ResourceManagerController.<TestDownload>d__30 <TestDownload>d__;
			<TestDownload>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<TestDownload>d__.<>4__this = this;
			<TestDownload>d__.<>1__state = -1;
			<TestDownload>d__.<>t__builder.Start<ResourceManagerController.<TestDownload>d__30>(ref <TestDownload>d__);
			return <TestDownload>d__.<>t__builder.Task;
		}

		// Token: 0x06028CC5 RID: 167109 RVA: 0x00B72908 File Offset: 0x00B70B08
		public void ChangeHttpTickFrequency()
		{
			Log.Instance.Info(ELogModule.SubPackageDownLoad, ELogAuthor.HWK, "ChangeHttpTickFrequency: set http tick to max", default(ReadOnlySpan<ValueTuple<string, object>>));
			Http.SetHttpThreadActiveMinimumSleepTimeInSeconds(0f);
			Http.SetHttpThreadIdleMinimumSleepTimeInSeconds(0f);
		}

		// Token: 0x06028CC6 RID: 167110 RVA: 0x00B72948 File Offset: 0x00B70B48
		public void RestoreHttpTickFrequency()
		{
			Log.Instance.Info(ELogModule.SubPackageDownLoad, ELogAuthor.HWK, "RestoreHttpTickFrequency: restore http tick to game default", default(ReadOnlySpan<ValueTuple<string, object>>));
			Http.SetHttpThreadActiveMinimumSleepTimeInSeconds(0.005f);
			Http.SetHttpThreadIdleMinimumSleepTimeInSeconds(0.033f);
		}

		// Token: 0x170052E9 RID: 21225
		// (get) Token: 0x06028CC7 RID: 167111 RVA: 0x00B72988 File Offset: 0x00B70B88
		public static ResourceManagerController Instance
		{
			get
			{
				return ResourceManagerController._Instance;
			}
		}

		// Token: 0x06028CC8 RID: 167112 RVA: 0x00B7298F File Offset: 0x00B70B8F
		public static ResourceManagerController GetOrCreateInstance()
		{
			if (ResourceManagerController._Instance == null)
			{
				ResourceManagerController.CreateInstance();
			}
			return ResourceManagerController._Instance;
		}

		// Token: 0x06028CC9 RID: 167113 RVA: 0x00B729A3 File Offset: 0x00B70BA3
		public static bool CreateInstance()
		{
			if (ResourceManagerController._Instance != null)
			{
				return true;
			}
			ResourceManagerController._Instance = new ResourceManagerController();
			return true;
		}

		// Token: 0x06028CCA RID: 167114 RVA: 0x00B729B9 File Offset: 0x00B70BB9
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06028CCB RID: 167115 RVA: 0x00B729BB File Offset: 0x00B70BBB
		public static void ResetStaticDefaultValue()
		{
			ResourceManagerController._Instance = null;
		}

		// Token: 0x06028CCC RID: 167116 RVA: 0x00B729C3 File Offset: 0x00B70BC3
		static ResourceManagerController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ResourceManagerController.CreateStaticDefaultValue), new Action(ResourceManagerController.ResetStaticDefaultValue));
		}

		// Token: 0x04016329 RID: 90921
		private const int CUE_BLOCK_PUSH_TIME = 3000;

		// Token: 0x0401632A RID: 90922
		[Nullable(2)]
		public CustomPromise LoginPrepareResCheckPromise;

		// Token: 0x0401632B RID: 90923
		private float PushCurBlockTimer;

		// Token: 0x0401632C RID: 90924
		private int CurBlockId = -1;

		// Token: 0x0401632D RID: 90925
		[Nullable(2)]
		private static ResourceManagerController _Instance;
	}
}
