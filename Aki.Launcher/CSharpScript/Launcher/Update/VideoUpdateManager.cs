using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.DiffPatch.Update;
using CSharpScript.Launcher.Download;

namespace CSharpScript.Launcher.Update
{
	// Token: 0x0200009C RID: 156
	[NullableContext(1)]
	[Nullable(0)]
	public class VideoUpdateManager : Singleton
	{
		// Token: 0x06000573 RID: 1395 RVA: 0x00031B6C File Offset: 0x0002FD6C
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

		// Token: 0x06000574 RID: 1396 RVA: 0x00031BBB File Offset: 0x0002FDBB
		public VideoUpdater GetInGameUpdater()
		{
			if (this.InGameUpdater == null)
			{
				this.InGameUpdater = this.CreateUpdater("in-game");
			}
			return this.InGameUpdater;
		}

		// Token: 0x06000575 RID: 1397 RVA: 0x00031BDC File Offset: 0x0002FDDC
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

		// Token: 0x06000576 RID: 1398 RVA: 0x00031C34 File Offset: 0x0002FE34
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

		// Token: 0x06000577 RID: 1399 RVA: 0x00031C9F File Offset: 0x0002FE9F
		public VideoUpdater GetLoginLoadingUpdater()
		{
			if (this.LoginLoadingUpdater == null)
			{
				this.LoginLoadingUpdater = this.CreateUpdater("login-loading");
			}
			return this.LoginLoadingUpdater;
		}

		// Token: 0x06000578 RID: 1400 RVA: 0x00031CC0 File Offset: 0x0002FEC0
		public void StopAllDownload()
		{
			if (this.InGameUpdater != null)
			{
				this.InGameUpdater.Pause();
			}
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x06000579 RID: 1401 RVA: 0x00031CD5 File Offset: 0x0002FED5
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

		// Token: 0x0600057A RID: 1402 RVA: 0x00031CF8 File Offset: 0x0002FEF8
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0600057B RID: 1403 RVA: 0x00031CFA File Offset: 0x0002FEFA
		public static void ResetStaticDefaultValue()
		{
			VideoUpdateManager instance = VideoUpdateManager._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			VideoUpdateManager._instance = null;
		}

		// Token: 0x0600057C RID: 1404 RVA: 0x00031D13 File Offset: 0x0002FF13
		static VideoUpdateManager()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(VideoUpdateManager.CreateStaticDefaultValue), new Action(VideoUpdateManager.ResetStaticDefaultValue));
		}

		// Token: 0x04000360 RID: 864
		[Nullable(2)]
		private VideoUpdater LoginLoadingUpdater;

		// Token: 0x04000361 RID: 865
		[Nullable(2)]
		private VideoUpdater InGameUpdater;

		// Token: 0x04000362 RID: 866
		private readonly Dictionary<string, VideoUpdater> VideoUpdaterMapWithName = new Dictionary<string, VideoUpdater>();

		// Token: 0x04000363 RID: 867
		private readonly Dictionary<EVideoResSizeType, VideoUpdater> VideoUpdaterMap = new Dictionary<EVideoResSizeType, VideoUpdater>();

		// Token: 0x04000364 RID: 868
		[Nullable(2)]
		private static VideoUpdateManager _instance;
	}
}
