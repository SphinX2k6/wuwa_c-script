using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Launcher.DiffPatch.Update;
using CSharpScript.Launcher.Update;
using UnrealEngine;

namespace CSharpScript.Game.Manager
{
	// Token: 0x02005AA2 RID: 23202
	[NullableContext(1)]
	[Nullable(0)]
	public class PakManager : Singleton
	{
		// Token: 0x060392B3 RID: 234163 RVA: 0x0100265D File Offset: 0x0100085D
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

		// Token: 0x060392B4 RID: 234164 RVA: 0x0100269C File Offset: 0x0100089C
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

		// Token: 0x060392B5 RID: 234165 RVA: 0x010026D8 File Offset: 0x010008D8
		public void TestPakMounted()
		{
			Log.Instance.Info(ELogModule.Event, ELogAuthor.LRA, "测试Pak挂载", default(ReadOnlySpan<ValueTuple<string, object>>));
			UKuroPakMountStatic.MountPak(UKuroLauncherLibrary.GameSavedDir() + "Saved/Paks/pakchunk103-WindowsNoEditor.pak", 9999);
		}

		// Token: 0x060392B6 RID: 234166 RVA: 0x0100271C File Offset: 0x0100091C
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

		// Token: 0x060392B7 RID: 234167 RVA: 0x010027AC File Offset: 0x010009AC
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

		// Token: 0x060392B8 RID: 234168 RVA: 0x01002800 File Offset: 0x01000A00
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

		// Token: 0x060392B9 RID: 234169 RVA: 0x010028AF File Offset: 0x01000AAF
		private void HandleSha1CheckFailures()
		{
			LoginController.Instance.LogLoginProcessLink(LoginDefine.ELoginStatus.PatchVerifyFail, Aki.Protocol.ErrorCode.Success);
			UKuroPakMountStatic.UnmountAllPaks();
			UKuroPakMountStatic.DeleteSha1CheckFailedFiles();
			AppUtil.QuitGame("Pak");
		}

		// Token: 0x060392BA RID: 234170 RVA: 0x010028D2 File Offset: 0x01000AD2
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

		// Token: 0x17006CDB RID: 27867
		// (get) Token: 0x060392BB RID: 234171 RVA: 0x01002905 File Offset: 0x01000B05
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

		// Token: 0x060392BC RID: 234172 RVA: 0x01002928 File Offset: 0x01000B28
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x060392BD RID: 234173 RVA: 0x0100292A File Offset: 0x01000B2A
		public static void ResetStaticDefaultValue()
		{
			PakManager instance = PakManager._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			PakManager._instance = null;
		}

		// Token: 0x060392BE RID: 234174 RVA: 0x01002943 File Offset: 0x01000B43
		static PakManager()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(PakManager.CreateStaticDefaultValue), new Action(PakManager.ResetStaticDefaultValue));
		}

		// Token: 0x060392C1 RID: 234177 RVA: 0x01002972 File Offset: 0x01000B72
		[CompilerGenerated]
		private void <ProcessingSha1CheckResult>g__ConfirmCallback|8_0()
		{
			this.HandleSha1CheckFailures();
		}

		// Token: 0x0401E183 RID: 123267
		[Nullable(2)]
		private TimerHandle UpdateCheckTimerId;

		// Token: 0x0401E184 RID: 123268
		[Nullable(2)]
		private TimerHandle FileSha1CheckTimerId;

		// Token: 0x0401E185 RID: 123269
		private const int FileSha1CheckTimerInterval = 60000;

		// Token: 0x0401E186 RID: 123270
		[Nullable(2)]
		private static PakManager _instance;
	}
}
