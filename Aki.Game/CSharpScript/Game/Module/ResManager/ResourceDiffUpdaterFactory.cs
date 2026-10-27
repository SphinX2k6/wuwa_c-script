using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.DiffPatch.Update;
using CSharpScript.Launcher.Update.ResourceDiffUpdate.Updater;
using CSharpScript.Launcher.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.ResManager
{
	// Token: 0x02004F10 RID: 20240
	[NullableContext(1)]
	[Nullable(0)]
	public class ResourceDiffUpdaterFactory
	{
		// Token: 0x06033E63 RID: 212579 RVA: 0x00C29404 File Offset: 0x00C27604
		[return: Nullable(new byte[]
		{
			0,
			1,
			1
		})]
		public static UniTask<ResourceDiffUpdater[]> CreateCoreUpdaters()
		{
			ResourceDiffUpdaterFactory.<CreateCoreUpdaters>d__0 <CreateCoreUpdaters>d__;
			<CreateCoreUpdaters>d__.<>t__builder = AsyncUniTaskMethodBuilder<ResourceDiffUpdater[]>.Create();
			<CreateCoreUpdaters>d__.<>1__state = -1;
			<CreateCoreUpdaters>d__.<>t__builder.Start<ResourceDiffUpdaterFactory.<CreateCoreUpdaters>d__0>(ref <CreateCoreUpdaters>d__);
			return <CreateCoreUpdaters>d__.<>t__builder.Task;
		}

		// Token: 0x06033E64 RID: 212580 RVA: 0x00C29440 File Offset: 0x00C27640
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static UniTask<ResourceDiffUpdater> CreateMapBlockUpdater(string name, int[] blockIds, int priority)
		{
			ResourceDiffUpdaterFactory.<CreateMapBlockUpdater>d__1 <CreateMapBlockUpdater>d__;
			<CreateMapBlockUpdater>d__.<>t__builder = AsyncUniTaskMethodBuilder<ResourceDiffUpdater>.Create();
			<CreateMapBlockUpdater>d__.name = name;
			<CreateMapBlockUpdater>d__.blockIds = blockIds;
			<CreateMapBlockUpdater>d__.priority = priority;
			<CreateMapBlockUpdater>d__.<>1__state = -1;
			<CreateMapBlockUpdater>d__.<>t__builder.Start<ResourceDiffUpdaterFactory.<CreateMapBlockUpdater>d__1>(ref <CreateMapBlockUpdater>d__);
			return <CreateMapBlockUpdater>d__.<>t__builder.Task;
		}

		// Token: 0x06033E65 RID: 212581 RVA: 0x00C29494 File Offset: 0x00C27694
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static UniTask<VideoResourceDiffUpdater> CreateVideoUpdater(string name, int priority, EVideoResSizeType videoResType, IReadOnlyList<int> videoIds, bool skipFilter = false)
		{
			ResourceDiffUpdaterFactory.<CreateVideoUpdater>d__2 <CreateVideoUpdater>d__;
			<CreateVideoUpdater>d__.<>t__builder = AsyncUniTaskMethodBuilder<VideoResourceDiffUpdater>.Create();
			<CreateVideoUpdater>d__.name = name;
			<CreateVideoUpdater>d__.priority = priority;
			<CreateVideoUpdater>d__.videoResType = videoResType;
			<CreateVideoUpdater>d__.videoIds = videoIds;
			<CreateVideoUpdater>d__.skipFilter = skipFilter;
			<CreateVideoUpdater>d__.<>1__state = -1;
			<CreateVideoUpdater>d__.<>t__builder.Start<ResourceDiffUpdaterFactory.<CreateVideoUpdater>d__2>(ref <CreateVideoUpdater>d__);
			return <CreateVideoUpdater>d__.<>t__builder.Task;
		}

		// Token: 0x06033E66 RID: 212582 RVA: 0x00C294F8 File Offset: 0x00C276F8
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static UniTask<CompositeResourceDiffUpdater> CreateCompositeUpdater(string name, int priority, int[] blockIds, EVideoResSizeType videoResType, int[] videoIds)
		{
			ResourceDiffUpdaterFactory.<CreateCompositeUpdater>d__3 <CreateCompositeUpdater>d__;
			<CreateCompositeUpdater>d__.<>t__builder = AsyncUniTaskMethodBuilder<CompositeResourceDiffUpdater>.Create();
			<CreateCompositeUpdater>d__.name = name;
			<CreateCompositeUpdater>d__.priority = priority;
			<CreateCompositeUpdater>d__.blockIds = blockIds;
			<CreateCompositeUpdater>d__.videoResType = videoResType;
			<CreateCompositeUpdater>d__.videoIds = videoIds;
			<CreateCompositeUpdater>d__.<>1__state = -1;
			<CreateCompositeUpdater>d__.<>t__builder.Start<ResourceDiffUpdaterFactory.<CreateCompositeUpdater>d__3>(ref <CreateCompositeUpdater>d__);
			return <CreateCompositeUpdater>d__.<>t__builder.Task;
		}

		// Token: 0x06033E67 RID: 212583 RVA: 0x00C2955C File Offset: 0x00C2775C
		[return: Nullable(new byte[]
		{
			0,
			2
		})]
		public static UniTask<ResourceDiffUpdater> CreateRoleVoiceUpdater(string name, string[] packKeys, int priority)
		{
			ResourceDiffUpdaterFactory.<CreateRoleVoiceUpdater>d__4 <CreateRoleVoiceUpdater>d__;
			<CreateRoleVoiceUpdater>d__.<>t__builder = AsyncUniTaskMethodBuilder<ResourceDiffUpdater>.Create();
			<CreateRoleVoiceUpdater>d__.name = name;
			<CreateRoleVoiceUpdater>d__.packKeys = packKeys;
			<CreateRoleVoiceUpdater>d__.priority = priority;
			<CreateRoleVoiceUpdater>d__.<>1__state = -1;
			<CreateRoleVoiceUpdater>d__.<>t__builder.Start<ResourceDiffUpdaterFactory.<CreateRoleVoiceUpdater>d__4>(ref <CreateRoleVoiceUpdater>d__);
			return <CreateRoleVoiceUpdater>d__.<>t__builder.Task;
		}

		// Token: 0x06033E68 RID: 212584 RVA: 0x00C295B0 File Offset: 0x00C277B0
		private static IReadOnlyList<int> FilterLauncherDownloadedVideos(IReadOnlyList<int> videoIds)
		{
			HashSet<int> global = LauncherStorageLib.Instance.GetGlobal<HashSet<int>>(ELauncherStorageGlobalKey.UserFinishedVideoList, null);
			if (global == null)
			{
				return videoIds;
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.SubPackageDownLoad;
			ELogAuthor author = ELogAuthor.HWK;
			string message = "热更阶段已下载视频列表";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("finishedVideoList", global);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			List<int> list = new List<int>();
			foreach (int item in videoIds)
			{
				if (!global.Contains(item))
				{
					list.Add(item);
				}
			}
			return list;
		}
	}
}
