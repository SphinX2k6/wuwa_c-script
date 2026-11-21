using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.DiffPatch.Data;
using CSharpScript.Launcher.Update.ResourceDiffUpdate;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Launcher.DiffPatch.Update
{
	// Token: 0x02000216 RID: 534
	[NullableContext(1)]
	[Nullable(0)]
	public class VideoPreDownload : Singleton
	{
		// Token: 0x06000DFD RID: 3581 RVA: 0x00055D10 File Offset: 0x00053F10
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

		// Token: 0x06000DFE RID: 3582 RVA: 0x00055D6C File Offset: 0x00053F6C
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

		// Token: 0x17000152 RID: 338
		// (get) Token: 0x06000DFF RID: 3583 RVA: 0x00055E90 File Offset: 0x00054090
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

		// Token: 0x06000E00 RID: 3584 RVA: 0x00055EB3 File Offset: 0x000540B3
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06000E01 RID: 3585 RVA: 0x00055EB5 File Offset: 0x000540B5
		public static void ResetStaticDefaultValue()
		{
			VideoPreDownload instance = VideoPreDownload._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			VideoPreDownload._instance = null;
		}

		// Token: 0x06000E02 RID: 3586 RVA: 0x00055ECE File Offset: 0x000540CE
		static VideoPreDownload()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(VideoPreDownload.CreateStaticDefaultValue), new Action(VideoPreDownload.ResetStaticDefaultValue));
		}

		// Token: 0x040008DC RID: 2268
		[Nullable(2)]
		private RemoteVideoConfigUpdateTime ConfigUpdateInfo;

		// Token: 0x040008DD RID: 2269
		private readonly Dictionary<string, VideoResourceInfo> Video = new Dictionary<string, VideoResourceInfo>();

		// Token: 0x040008DE RID: 2270
		private bool Inited;

		// Token: 0x040008DF RID: 2271
		private string Platform = "";

		// Token: 0x040008E0 RID: 2272
		[Nullable(2)]
		private static VideoPreDownload _instance;
	}
}
