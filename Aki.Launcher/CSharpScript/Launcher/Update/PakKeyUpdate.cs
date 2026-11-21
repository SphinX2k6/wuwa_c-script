using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Launcher.Update
{
	// Token: 0x02000093 RID: 147
	[NullableContext(1)]
	[Nullable(0)]
	public class PakKeyUpdate : Singleton
	{
		// Token: 0x0600053D RID: 1341 RVA: 0x0003141C File Offset: 0x0002F61C
		public void Init(AppPathMisc pathMisc)
		{
			this.NeedExtPakKeys = UKuroPakKeyLibrary.NeedExtPakKeys();
			this.UpdateCheckInterval = UKuroPakKeyLibrary.GetUpdateInterval();
			this.SavePath = pathMisc.GetPatchSaveDir() + "PakData";
			this.VideoSavePath = pathMisc.GetPatchSaveDir() + "VideoPakData";
			this.LoadCompleteCallbackDelegate = new Action<bool, string>(this.LoadCompleteCallback);
			UKuroPakKeyLibrary.SetLoadCallback(DelegateUtils.ToManualReleaseDelegate<FKuroKeysLoadComplete>(this.LoadCompleteCallbackDelegate));
		}

		// Token: 0x0600053E RID: 1342 RVA: 0x0003148D File Offset: 0x0002F68D
		public void Destroy()
		{
			if (this.LoadCompleteCallbackDelegate != null)
			{
				DelegateUtils.ReleaseManualReleaseDelegate(this.LoadCompleteCallbackDelegate);
				this.LoadCompleteCallbackDelegate = null;
			}
			UKuroPakKeyLibrary.UnbindLoadCallback();
		}

		// Token: 0x0600053F RID: 1343 RVA: 0x000314B0 File Offset: 0x0002F6B0
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

		// Token: 0x06000540 RID: 1344 RVA: 0x00031500 File Offset: 0x0002F700
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

		// Token: 0x06000541 RID: 1345 RVA: 0x00031554 File Offset: 0x0002F754
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

		// Token: 0x06000542 RID: 1346 RVA: 0x000315A0 File Offset: 0x0002F7A0
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

		// Token: 0x06000543 RID: 1347 RVA: 0x000315E4 File Offset: 0x0002F7E4
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

		// Token: 0x06000544 RID: 1348 RVA: 0x00031637 File Offset: 0x0002F837
		private void LoadCompleteCallback(bool success, string tag)
		{
			if (this.LoadFileCallbacks.ContainsKey(tag))
			{
				this.LoadFileCallbacks[tag](success);
				this.LoadFileCallbacks.Remove(tag);
			}
		}

		// Token: 0x06000545 RID: 1349 RVA: 0x00031668 File Offset: 0x0002F868
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

		// Token: 0x06000546 RID: 1350 RVA: 0x000316BC File Offset: 0x0002F8BC
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

		// Token: 0x06000547 RID: 1351 RVA: 0x00031708 File Offset: 0x0002F908
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

		// Token: 0x06000548 RID: 1352 RVA: 0x0003175C File Offset: 0x0002F95C
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

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x06000549 RID: 1353 RVA: 0x000317AA File Offset: 0x0002F9AA
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

		// Token: 0x0600054A RID: 1354 RVA: 0x000317CD File Offset: 0x0002F9CD
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0600054B RID: 1355 RVA: 0x000317CF File Offset: 0x0002F9CF
		public static void ResetStaticDefaultValue()
		{
			PakKeyUpdate instance = PakKeyUpdate._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			PakKeyUpdate._instance = null;
		}

		// Token: 0x0600054C RID: 1356 RVA: 0x000317E8 File Offset: 0x0002F9E8
		static PakKeyUpdate()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(PakKeyUpdate.CreateStaticDefaultValue), new Action(PakKeyUpdate.ResetStaticDefaultValue));
		}

		// Token: 0x04000335 RID: 821
		private const int DOWNLOAD_TRY_COUNT = 3;

		// Token: 0x04000336 RID: 822
		private const int KEYLIST_TRY_COUNT = 3;

		// Token: 0x04000337 RID: 823
		private const int MIN_UPDATE_INTERVAL = 60;

		// Token: 0x04000338 RID: 824
		private bool IsUpdating;

		// Token: 0x04000339 RID: 825
		private double LastUpdateTime;

		// Token: 0x0400033A RID: 826
		public bool NeedExtPakKeys;

		// Token: 0x0400033B RID: 827
		public int UpdateCheckInterval = -1;

		// Token: 0x0400033C RID: 828
		private int KeyListTryCount;

		// Token: 0x0400033D RID: 829
		private string CurDataHash = "";

		// Token: 0x0400033E RID: 830
		private string SavePath = "";

		// Token: 0x0400033F RID: 831
		[Nullable(2)]
		private PakListConfig Config;

		// Token: 0x04000340 RID: 832
		[Nullable(2)]
		private Action UpdateCallback;

		// Token: 0x04000341 RID: 833
		private int VideoKeyListTryCount;

		// Token: 0x04000342 RID: 834
		private bool IsVideoUpdating;

		// Token: 0x04000343 RID: 835
		private double LastVideoUpdateTime;

		// Token: 0x04000344 RID: 836
		private string VideoSavePath = "";

		// Token: 0x04000345 RID: 837
		private string CurVideoDataHash = "";

		// Token: 0x04000346 RID: 838
		[Nullable(2)]
		private PakListConfig VideoConfig;

		// Token: 0x04000347 RID: 839
		[Nullable(2)]
		private Action VideoUpdateCallback;

		// Token: 0x04000348 RID: 840
		private readonly Dictionary<string, Action<bool>> LoadFileCallbacks = new Dictionary<string, Action<bool>>();

		// Token: 0x04000349 RID: 841
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Action<bool, string> LoadCompleteCallbackDelegate;

		// Token: 0x0400034A RID: 842
		[Nullable(2)]
		private static PakKeyUpdate _instance;
	}
}
