using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Launcher.DiffPatch.Update;
using CSharpScript.Launcher.Update;
using UnrealEngine;

namespace CSharpScript.Game.Manager
{
	// Token: 0x02006947 RID: 26951
	[NullableContext(1)]
	[Nullable(0)]
	public class PakManager : Singleton
	{
		// Token: 0x0604327C RID: 275068 RVA: 0x0105E49E File Offset: 0x0105C69E
		public void Init()
		{
			if (this.UpdateCheckTimerId != null)
			{
				this.UpdateCheckTimerId.Remove();
				this.UpdateCheckTimerId = null;
			}
			UKuroPakKeyLibrary.BindPakMountedCallback(DelegateUtils.ToManualReleaseDelegate<FKuroPakMountedCallback>(new Action<string>(this.OnPakMounted)));
			this.StartPakKeyCheckTimer();
			this.StartFileSha1CheckTimer();
		}

		// Token: 0x0604327D RID: 275069 RVA: 0x0105E4E0 File Offset: 0x0105C6E0
		private void OnPakMounted(string pakFilename)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Event;
			ELogAuthor author = ELogAuthor.LRA;
			string message = "Pak挂载";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Filename", pakFilename);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			ConfigMultiTextLang.ClearMultiTextLangStatementIdsAndCache();
		}

		// Token: 0x0604327E RID: 275070 RVA: 0x0105E51C File Offset: 0x0105C71C
		public void TestPakMounted()
		{
			Log.Instance.Info(ELogModule.Event, ELogAuthor.LRA, "测试Pak挂载", default(ReadOnlySpan<ValueTuple<string, object>>));
			UKuroPakMountStatic.MountPak(UKuroLauncherLibrary.GameSavedDir() + "Saved/Paks/pakchunk103-WindowsNoEditor.pak", 9999);
		}

		// Token: 0x0604327F RID: 275071 RVA: 0x0105E560 File Offset: 0x0105C760
		private void StartPakKeyCheckTimer()
		{
			if (!PakKeyUpdate.Instance.NeedExtPakKeys)
			{
				return;
			}
			if (PakKeyUpdate.Instance.UpdateCheckInterval > 0)
			{
				Log.Instance.Info(ELogModule.Event, ELogAuthor.LRA, "启动 pak timer.", default(ReadOnlySpan<ValueTuple<string, object>>));
				int num = PakKeyUpdate.Instance.UpdateCheckInterval * 1000;
				this.UpdateCheckTimerId = TimerSystem.GameplayTimeInstance.Forever(delegate(float _)
				{
					PakKeyUpdate.Instance.CheckPakKey(null, null);
					if (VideoResUpdate.Instance.GetIsSeparateVideo())
					{
						PakKeyUpdate.Instance.CheckVideoPakKey(null, null);
					}
				}, (float)num, 1f, null, null, false);
			}
		}

		// Token: 0x06043280 RID: 275072 RVA: 0x0105E5F0 File Offset: 0x0105C7F0
		private void StartFileSha1CheckTimer()
		{
			if (this.FileSha1CheckTimerId != null)
			{
				this.FileSha1CheckTimerId.Remove();
				this.FileSha1CheckTimerId = null;
			}
			this.FileSha1CheckTimerId = TimerSystem.GameplayTimeInstance.Forever(delegate(float _)
			{
				this.ProcessingSha1CheckResult();
			}, 60000f, 1f, null, null, false);
		}

		// Token: 0x06043281 RID: 275073 RVA: 0x0105E644 File Offset: 0x0105C844
		private void ProcessingSha1CheckResult()
		{
			if (UKuroPakMountStatic.IsSha1CheckWorking())
			{
				return;
			}
			int sha1CheckFailedCount = UKuroPakMountStatic.GetSha1CheckFailedCount();
			if (sha1CheckFailedCount > 0)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.ErrorCode;
				ELogAuthor author = ELogAuthor.LRA;
				string message = "文件Sha1校验失败";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Count", sha1CheckFailedCount);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.ErrorCodeTips);
				string localTextNew = ConfigMultiTextLang.GetLocalTextNew("ResourceVerificationFailed_Text", null);
				confirmBoxDataNew.SetTextArgs(new string[]
				{
					localTextNew
				});
				confirmBoxDataNew.FunctionMap[1] = new Action(this.<ProcessingSha1CheckResult>g__ConfirmCallback|8_0);
				ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
				return;
			}
			if (this.FileSha1CheckTimerId != null)
			{
				this.FileSha1CheckTimerId.Remove();
				this.FileSha1CheckTimerId = null;
			}
		}

		// Token: 0x06043282 RID: 275074 RVA: 0x0105E6F3 File Offset: 0x0105C8F3
		private void HandleSha1CheckFailures()
		{
			LoginController.Instance.LogLoginProcessLink(LoginDefine.ELoginStatus.PatchVerifyFail, Aki.Protocol.ErrorCode.Success);
			UKuroPakMountStatic.UnmountAllPaks();
			UKuroPakMountStatic.DeleteSha1CheckFailedFiles();
			AppUtil.QuitGame("Pak");
		}

		// Token: 0x06043283 RID: 275075 RVA: 0x0105E716 File Offset: 0x0105C916
		public void Clear()
		{
			if (this.FileSha1CheckTimerId != null)
			{
				this.FileSha1CheckTimerId.Remove();
				this.FileSha1CheckTimerId = null;
			}
			DelegateUtils.ReleaseManualReleaseDelegate(new Action<string>(this.OnPakMounted));
			UKuroPakKeyLibrary.UnbindPakMountedCallback();
		}

		// Token: 0x170097FB RID: 38907
		// (get) Token: 0x06043284 RID: 275076 RVA: 0x0105E749 File Offset: 0x0105C949
		public static PakManager Instance
		{
			get
			{
				if (PakManager._instance == null)
				{
					PakManager._instance = new PakManager();
					PakManager._instance.OnInit();
				}
				return PakManager._instance;
			}
		}

		// Token: 0x06043285 RID: 275077 RVA: 0x0105E76C File Offset: 0x0105C96C
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06043286 RID: 275078 RVA: 0x0105E76E File Offset: 0x0105C96E
		public static void ResetStaticDefaultValue()
		{
			PakManager instance = PakManager._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			PakManager._instance = null;
		}

		// Token: 0x06043287 RID: 275079 RVA: 0x0105E787 File Offset: 0x0105C987
		static PakManager()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(PakManager.CreateStaticDefaultValue), new Action(PakManager.ResetStaticDefaultValue));
		}

		// Token: 0x0604328A RID: 275082 RVA: 0x0105E7B6 File Offset: 0x0105C9B6
		[CompilerGenerated]
		private void <ProcessingSha1CheckResult>g__ConfirmCallback|8_0()
		{
			this.HandleSha1CheckFailures();
		}

		// Token: 0x04022F99 RID: 143257
		[Nullable(2)]
		private TimerHandle UpdateCheckTimerId;

		// Token: 0x04022F9A RID: 143258
		[Nullable(2)]
		private TimerHandle FileSha1CheckTimerId;

		// Token: 0x04022F9B RID: 143259
		private const int FileSha1CheckTimerInterval = 60000;

		// Token: 0x04022F9C RID: 143260
		[Nullable(2)]
		private static PakManager _instance;
	}
}
