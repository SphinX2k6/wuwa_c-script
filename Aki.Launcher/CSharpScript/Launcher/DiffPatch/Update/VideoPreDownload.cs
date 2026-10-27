using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.DiffPatch.Data;
using CSharpScript.Launcher.Update.ResourceDiffUpdate;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Launcher.DiffPatch.Update
{
	// Token: 0x02000211 RID: 529
	[NullableContext(1)]
	[Nullable(0)]
	public class VideoPreDownload : Singleton
	{
		// Token: 0x06000DBC RID: 3516 RVA: 0x0005321C File Offset: 0x0005141C
		public UniTask InitVideoPreDownload(string mixUri, string appVersion, string platform)
		{
			VideoPreDownload.<InitVideoPreDownload>d__4 <InitVideoPreDownload>d__;
			<InitVideoPreDownload>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitVideoPreDownload>d__.<>4__this = this;
			<InitVideoPreDownload>d__.mixUri = mixUri;
			<InitVideoPreDownload>d__.appVersion = appVersion;
			<InitVideoPreDownload>d__.platform = platform;
			<InitVideoPreDownload>d__.<>1__state = -1;
			<InitVideoPreDownload>d__.<>t__builder.Start<VideoPreDownload.<InitVideoPreDownload>d__4>(ref <InitVideoPreDownload>d__);
			return <InitVideoPreDownload>d__.<>t__builder.Task;
		}

		// Token: 0x06000DBD RID: 3517 RVA: 0x00053278 File Offset: 0x00051478
		[return: Nullable(new byte[]
		{
			0,
			1,
			1,
			1,
			1
		})]
		public ValueTuple<List<LocalFileInfo>, List<RequireFileInfo>> AnalyzePreDownloadRequireFiles()
		{
			List<LocalFileInfo> list = new List<LocalFileInfo>();
			List<RequireFileInfo> list2 = new List<RequireFileInfo>();
			HashSet<int> unusedVideos = ResourceDiffUpdaterManager.Instance.VideoModule.GetUnusedVideos(ResourceDiffUpdaterManager.Instance.Context.FinishedQuests);
			foreach (KeyValuePair<string, VideoResourceInfo> keyValuePair in this.Video)
			{
				if (!VideoResUpdate.Instance.VideoMap.ContainsKey(keyValuePair.Key))
				{
					string key = keyValuePair.Key;
					VideoResourceInfo value = keyValuePair.Value;
					int item;
					if (!int.TryParse(key.Split('_', StringSplitOptions.None)[0], out item))
					{
						LauncherLog instance = LauncherLog.Instance;
						string message = "VideoRes invalid video id";
						ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("res", key);
						instance.Warn(message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
					}
					else if (!unusedVideos.Contains(item))
					{
						ValueTuple<List<LocalFileInfo>, List<RequireFileInfo>, long, long> valueTuple2 = VideoResUpdate.Instance.AnalyzeSingle(value);
						List<LocalFileInfo> item2 = valueTuple2.Item1;
						List<RequireFileInfo> item3 = valueTuple2.Item2;
						list.AddRange(item2);
						list2.AddRange(item3);
					}
				}
			}
			return new ValueTuple<List<LocalFileInfo>, List<RequireFileInfo>>(list, list2);
		}

		// Token: 0x1700014C RID: 332
		// (get) Token: 0x06000DBE RID: 3518 RVA: 0x0005339C File Offset: 0x0005159C
		public static VideoPreDownload Instance
		{
			get
			{
				if (VideoPreDownload._instance == null)
				{
					VideoPreDownload._instance = new VideoPreDownload();
					VideoPreDownload._instance.OnInit();
				}
				return VideoPreDownload._instance;
			}
		}

		// Token: 0x06000DBF RID: 3519 RVA: 0x000533BF File Offset: 0x000515BF
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06000DC0 RID: 3520 RVA: 0x000533C1 File Offset: 0x000515C1
		public static void ResetStaticDefaultValue()
		{
			VideoPreDownload instance = VideoPreDownload._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			VideoPreDownload._instance = null;
		}

		// Token: 0x06000DC1 RID: 3521 RVA: 0x000533DA File Offset: 0x000515DA
		static VideoPreDownload()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(VideoPreDownload.CreateStaticDefaultValue), new Action(VideoPreDownload.ResetStaticDefaultValue));
		}

		// Token: 0x0400089B RID: 2203
		[Nullable(2)]
		private RemoteVideoConfigUpdateTime ConfigUpdateInfo;

		// Token: 0x0400089C RID: 2204
		private readonly Dictionary<string, VideoResourceInfo> Video = new Dictionary<string, VideoResourceInfo>();

		// Token: 0x0400089D RID: 2205
		private bool Inited;

		// Token: 0x0400089E RID: 2206
		private string Platform = "";

		// Token: 0x0400089F RID: 2207
		[Nullable(2)]
		private static VideoPreDownload _instance;
	}
}
