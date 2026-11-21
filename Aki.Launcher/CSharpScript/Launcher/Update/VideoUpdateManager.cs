using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.DiffPatch.Update;
using CSharpScript.Launcher.Download;

namespace CSharpScript.Launcher.Update
{
	// Token: 0x0200009F RID: 159
	[NullableContext(1)]
	[Nullable(0)]
	public class VideoUpdateManager : Singleton
	{
		// Token: 0x0600058A RID: 1418 RVA: 0x000330D4 File Offset: 0x000312D4
		private VideoUpdater CreateUpdater(string name)
		{
			VideoUpdater videoUpdater = new VideoUpdater();
			videoUpdater.Downloader = new UrlPrefixDownload();
			UpdateReportEvent reportEvent = new UpdateReportEvent(name);
			VideoUpdateUiEvent uiEvent = new VideoUpdateUiEvent();
			videoUpdater.DiffUpdater = new DiffUpdate(new List<ResPackageInfo>(), videoUpdater.Downloader, uiEvent, reportEvent, true, EUpdateType.IndependentLang);
			videoUpdater.Init(uiEvent);
			return videoUpdater;
		}

		// Token: 0x0600058B RID: 1419 RVA: 0x00033123 File Offset: 0x00031323
		public VideoUpdater GetInGameUpdater()
		{
			if (this.InGameUpdater == null)
			{
				this.InGameUpdater = this.CreateUpdater("in-game");
			}
			return this.InGameUpdater;
		}

		// Token: 0x0600058C RID: 1420 RVA: 0x00033144 File Offset: 0x00031344
		public VideoUpdater GetVideoUpdater(EVideoResSizeType resType)
		{
			if (this.VideoUpdaterMap.ContainsKey(resType))
			{
				return this.VideoUpdaterMap[resType];
			}
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 1);
			defaultInterpolatedStringHandler.AppendFormatted<EVideoResSizeType>(resType);
			VideoUpdater videoUpdater = this.CreateUpdater(defaultInterpolatedStringHandler.ToStringAndClear());
			this.VideoUpdaterMap[resType] = videoUpdater;
			return videoUpdater;
		}

		// Token: 0x0600058D RID: 1421 RVA: 0x0003319C File Offset: 0x0003139C
		public VideoUpdater GetVideoUpdaterWithName(EVideoResSizeType resType, string name)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
			defaultInterpolatedStringHandler.AppendFormatted<EVideoResSizeType>(resType);
			defaultInterpolatedStringHandler.AppendLiteral("_");
			defaultInterpolatedStringHandler.AppendFormatted(name);
			string text = defaultInterpolatedStringHandler.ToStringAndClear();
			if (this.VideoUpdaterMapWithName.ContainsKey(text))
			{
				return this.VideoUpdaterMapWithName[text];
			}
			VideoUpdater videoUpdater = this.CreateUpdater(text);
			this.VideoUpdaterMapWithName[text] = videoUpdater;
			return videoUpdater;
		}

		// Token: 0x0600058E RID: 1422 RVA: 0x00033207 File Offset: 0x00031407
		public VideoUpdater GetLoginLoadingUpdater()
		{
			if (this.LoginLoadingUpdater == null)
			{
				this.LoginLoadingUpdater = this.CreateUpdater("login-loading");
			}
			return this.LoginLoadingUpdater;
		}

		// Token: 0x0600058F RID: 1423 RVA: 0x00033228 File Offset: 0x00031428
		public void StopAllDownload()
		{
			if (this.InGameUpdater != null)
			{
				this.InGameUpdater.Pause();
			}
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x06000590 RID: 1424 RVA: 0x0003323D File Offset: 0x0003143D
		public static VideoUpdateManager Instance
		{
			get
			{
				if (VideoUpdateManager._instance == null)
				{
					VideoUpdateManager._instance = new VideoUpdateManager();
					VideoUpdateManager._instance.OnInit();
				}
				return VideoUpdateManager._instance;
			}
		}

		// Token: 0x06000591 RID: 1425 RVA: 0x00033260 File Offset: 0x00031460
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06000592 RID: 1426 RVA: 0x00033262 File Offset: 0x00031462
		public static void ResetStaticDefaultValue()
		{
			VideoUpdateManager instance = VideoUpdateManager._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			VideoUpdateManager._instance = null;
		}

		// Token: 0x06000593 RID: 1427 RVA: 0x0003327B File Offset: 0x0003147B
		static VideoUpdateManager()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(VideoUpdateManager.CreateStaticDefaultValue), new Action(VideoUpdateManager.ResetStaticDefaultValue));
		}

		// Token: 0x0400038E RID: 910
		[Nullable(2)]
		private VideoUpdater LoginLoadingUpdater;

		// Token: 0x0400038F RID: 911
		[Nullable(2)]
		private VideoUpdater InGameUpdater;

		// Token: 0x04000390 RID: 912
		private readonly Dictionary<string, VideoUpdater> VideoUpdaterMapWithName = new Dictionary<string, VideoUpdater>();

		// Token: 0x04000391 RID: 913
		private readonly Dictionary<EVideoResSizeType, VideoUpdater> VideoUpdaterMap = new Dictionary<EVideoResSizeType, VideoUpdater>();

		// Token: 0x04000392 RID: 914
		[Nullable(2)]
		private static VideoUpdateManager _instance;
	}
}
