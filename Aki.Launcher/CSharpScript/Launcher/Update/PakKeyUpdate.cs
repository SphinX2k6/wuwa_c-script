using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Launcher.Update
{
	// Token: 0x02000090 RID: 144
	[NullableContext(1)]
	[Nullable(0)]
	public class PakKeyUpdate : Singleton
	{
		// Token: 0x06000526 RID: 1318 RVA: 0x0002FEB4 File Offset: 0x0002E0B4
		public void Init(AppPathMisc pathMisc)
		{
			this.NeedExtPakKeys = UKuroPakKeyLibrary.NeedExtPakKeys();
			this.UpdateCheckInterval = UKuroPakKeyLibrary.GetUpdateInterval();
			this.SavePath = pathMisc.GetPatchSaveDir() + "PakData";
			this.VideoSavePath = pathMisc.GetPatchSaveDir() + "VideoPakData";
			this.LoadCompleteCallbackDelegate = new Action<bool, string>(this.LoadCompleteCallback);
			UKuroPakKeyLibrary.SetLoadCallback(DelegateUtils.ToManualReleaseDelegate<FKuroKeysLoadComplete>(this.LoadCompleteCallbackDelegate));
		}

		// Token: 0x06000527 RID: 1319 RVA: 0x0002FF25 File Offset: 0x0002E125
		public void Destroy()
		{
			if (this.LoadCompleteCallbackDelegate != null)
			{
				DelegateUtils.ReleaseManualReleaseDelegate(this.LoadCompleteCallbackDelegate);
				this.LoadCompleteCallbackDelegate = null;
			}
			UKuroPakKeyLibrary.UnbindLoadCallback();
		}

		// Token: 0x06000528 RID: 1320 RVA: 0x0002FF48 File Offset: 0x0002E148
		private void Finish(bool isDone)
		{
			this.IsUpdating = false;
			this.Config = null;
			this.KeyListTryCount = 0;
			if (isDone)
			{
				this.LastUpdateTime = 0.0;
				if (this.UpdateCallback != null)
				{
					this.UpdateCallback();
					this.UpdateCallback = null;
				}
			}
		}

		// Token: 0x06000529 RID: 1321 RVA: 0x0002FF98 File Offset: 0x0002E198
		[NullableContext(2)]
		[return: Nullable(0)]
		public UniTask<bool> CheckPakKey(Action callback, Action failCallback)
		{
			PakKeyUpdate.<CheckPakKey>d__24 <CheckPakKey>d__;
			<CheckPakKey>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<CheckPakKey>d__.<>4__this = this;
			<CheckPakKey>d__.callback = callback;
			<CheckPakKey>d__.failCallback = failCallback;
			<CheckPakKey>d__.<>1__state = -1;
			<CheckPakKey>d__.<>t__builder.Start<PakKeyUpdate.<CheckPakKey>d__24>(ref <CheckPakKey>d__);
			return <CheckPakKey>d__.<>t__builder.Task;
		}

		// Token: 0x0600052A RID: 1322 RVA: 0x0002FFEC File Offset: 0x0002E1EC
		[NullableContext(0)]
		public UniTask<bool> GetKeyListInfo(int urlIndex = 0)
		{
			PakKeyUpdate.<GetKeyListInfo>d__25 <GetKeyListInfo>d__;
			<GetKeyListInfo>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<GetKeyListInfo>d__.<>4__this = this;
			<GetKeyListInfo>d__.urlIndex = urlIndex;
			<GetKeyListInfo>d__.<>1__state = -1;
			<GetKeyListInfo>d__.<>t__builder.Start<PakKeyUpdate.<GetKeyListInfo>d__25>(ref <GetKeyListInfo>d__);
			return <GetKeyListInfo>d__.<>t__builder.Task;
		}

		// Token: 0x0600052B RID: 1323 RVA: 0x00030038 File Offset: 0x0002E238
		[NullableContext(0)]
		private UniTask<bool> GetKeyListConfig()
		{
			PakKeyUpdate.<GetKeyListConfig>d__26 <GetKeyListConfig>d__;
			<GetKeyListConfig>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<GetKeyListConfig>d__.<>4__this = this;
			<GetKeyListConfig>d__.<>1__state = -1;
			<GetKeyListConfig>d__.<>t__builder.Start<PakKeyUpdate.<GetKeyListConfig>d__26>(ref <GetKeyListConfig>d__);
			return <GetKeyListConfig>d__.<>t__builder.Task;
		}

		// Token: 0x0600052C RID: 1324 RVA: 0x0003007C File Offset: 0x0002E27C
		[NullableContext(2)]
		[return: Nullable(0)]
		public UniTask<bool> TryDownloadFile(Action callback, Action failCallback)
		{
			PakKeyUpdate.<TryDownloadFile>d__27 <TryDownloadFile>d__;
			<TryDownloadFile>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<TryDownloadFile>d__.<>4__this = this;
			<TryDownloadFile>d__.callback = callback;
			<TryDownloadFile>d__.failCallback = failCallback;
			<TryDownloadFile>d__.<>1__state = -1;
			<TryDownloadFile>d__.<>t__builder.Start<PakKeyUpdate.<TryDownloadFile>d__27>(ref <TryDownloadFile>d__);
			return <TryDownloadFile>d__.<>t__builder.Task;
		}

		// Token: 0x0600052D RID: 1325 RVA: 0x000300CF File Offset: 0x0002E2CF
		private void LoadCompleteCallback(bool success, string tag)
		{
			if (this.LoadFileCallbacks.ContainsKey(tag))
			{
				this.LoadFileCallbacks[tag](success);
				this.LoadFileCallbacks.Remove(tag);
			}
		}

		// Token: 0x0600052E RID: 1326 RVA: 0x00030100 File Offset: 0x0002E300
		[NullableContext(2)]
		[return: Nullable(0)]
		public UniTask<bool> CheckVideoPakKey(Action callback, Action failCallback)
		{
			PakKeyUpdate.<CheckVideoPakKey>d__29 <CheckVideoPakKey>d__;
			<CheckVideoPakKey>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<CheckVideoPakKey>d__.<>4__this = this;
			<CheckVideoPakKey>d__.callback = callback;
			<CheckVideoPakKey>d__.failCallback = failCallback;
			<CheckVideoPakKey>d__.<>1__state = -1;
			<CheckVideoPakKey>d__.<>t__builder.Start<PakKeyUpdate.<CheckVideoPakKey>d__29>(ref <CheckVideoPakKey>d__);
			return <CheckVideoPakKey>d__.<>t__builder.Task;
		}

		// Token: 0x0600052F RID: 1327 RVA: 0x00030154 File Offset: 0x0002E354
		[NullableContext(0)]
		private UniTask<bool> GetVideoKeyListInfo(int urlIndex = 0)
		{
			PakKeyUpdate.<GetVideoKeyListInfo>d__30 <GetVideoKeyListInfo>d__;
			<GetVideoKeyListInfo>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<GetVideoKeyListInfo>d__.<>4__this = this;
			<GetVideoKeyListInfo>d__.urlIndex = urlIndex;
			<GetVideoKeyListInfo>d__.<>1__state = -1;
			<GetVideoKeyListInfo>d__.<>t__builder.Start<PakKeyUpdate.<GetVideoKeyListInfo>d__30>(ref <GetVideoKeyListInfo>d__);
			return <GetVideoKeyListInfo>d__.<>t__builder.Task;
		}

		// Token: 0x06000530 RID: 1328 RVA: 0x000301A0 File Offset: 0x0002E3A0
		[NullableContext(2)]
		[return: Nullable(0)]
		public UniTask<bool> TryDownloadVideoFile(Action callback, Action failCallback)
		{
			PakKeyUpdate.<TryDownloadVideoFile>d__31 <TryDownloadVideoFile>d__;
			<TryDownloadVideoFile>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<TryDownloadVideoFile>d__.<>4__this = this;
			<TryDownloadVideoFile>d__.callback = callback;
			<TryDownloadVideoFile>d__.failCallback = failCallback;
			<TryDownloadVideoFile>d__.<>1__state = -1;
			<TryDownloadVideoFile>d__.<>t__builder.Start<PakKeyUpdate.<TryDownloadVideoFile>d__31>(ref <TryDownloadVideoFile>d__);
			return <TryDownloadVideoFile>d__.<>t__builder.Task;
		}

		// Token: 0x06000531 RID: 1329 RVA: 0x000301F4 File Offset: 0x0002E3F4
		private void VideoFinish(bool isDone)
		{
			this.IsVideoUpdating = false;
			this.VideoConfig = null;
			this.VideoKeyListTryCount = 0;
			if (isDone)
			{
				this.LastVideoUpdateTime = 0.0;
				if (this.VideoUpdateCallback != null)
				{
					this.VideoUpdateCallback();
					this.VideoUpdateCallback = null;
				}
			}
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x06000532 RID: 1330 RVA: 0x00030242 File Offset: 0x0002E442
		public static PakKeyUpdate Instance
		{
			get
			{
				if (PakKeyUpdate._instance == null)
				{
					PakKeyUpdate._instance = new PakKeyUpdate();
					PakKeyUpdate._instance.OnInit();
				}
				return PakKeyUpdate._instance;
			}
		}

		// Token: 0x06000533 RID: 1331 RVA: 0x00030265 File Offset: 0x0002E465
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06000534 RID: 1332 RVA: 0x00030267 File Offset: 0x0002E467
		public static void ResetStaticDefaultValue()
		{
			PakKeyUpdate instance = PakKeyUpdate._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			PakKeyUpdate._instance = null;
		}

		// Token: 0x06000535 RID: 1333 RVA: 0x00030280 File Offset: 0x0002E480
		static PakKeyUpdate()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(PakKeyUpdate.CreateStaticDefaultValue), new Action(PakKeyUpdate.ResetStaticDefaultValue));
		}

		// Token: 0x04000307 RID: 775
		private const int DOWNLOAD_TRY_COUNT = 3;

		// Token: 0x04000308 RID: 776
		private const int KEYLIST_TRY_COUNT = 3;

		// Token: 0x04000309 RID: 777
		private const int MIN_UPDATE_INTERVAL = 60;

		// Token: 0x0400030A RID: 778
		private bool IsUpdating;

		// Token: 0x0400030B RID: 779
		private double LastUpdateTime;

		// Token: 0x0400030C RID: 780
		public bool NeedExtPakKeys;

		// Token: 0x0400030D RID: 781
		public int UpdateCheckInterval = -1;

		// Token: 0x0400030E RID: 782
		private int KeyListTryCount;

		// Token: 0x0400030F RID: 783
		private string CurDataHash = "";

		// Token: 0x04000310 RID: 784
		private string SavePath = "";

		// Token: 0x04000311 RID: 785
		[Nullable(2)]
		private PakListConfig Config;

		// Token: 0x04000312 RID: 786
		[Nullable(2)]
		private Action UpdateCallback;

		// Token: 0x04000313 RID: 787
		private int VideoKeyListTryCount;

		// Token: 0x04000314 RID: 788
		private bool IsVideoUpdating;

		// Token: 0x04000315 RID: 789
		private double LastVideoUpdateTime;

		// Token: 0x04000316 RID: 790
		private string VideoSavePath = "";

		// Token: 0x04000317 RID: 791
		private string CurVideoDataHash = "";

		// Token: 0x04000318 RID: 792
		[Nullable(2)]
		private PakListConfig VideoConfig;

		// Token: 0x04000319 RID: 793
		[Nullable(2)]
		private Action VideoUpdateCallback;

		// Token: 0x0400031A RID: 794
		private readonly Dictionary<string, Action<bool>> LoadFileCallbacks = new Dictionary<string, Action<bool>>();

		// Token: 0x0400031B RID: 795
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Action<bool, string> LoadCompleteCallbackDelegate;

		// Token: 0x0400031C RID: 796
		[Nullable(2)]
		private static PakKeyUpdate _instance;
	}
}
