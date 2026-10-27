using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using CSharpScript.Launcher.BaseConfig;
using CSharpScript.Launcher.NetworkDetection;
using CSharpScript.Launcher.Platform;
using CSharpScript.Launcher.Update;
using CSharpScript.Launcher.Util;
using CSharpScript.Typing;
using UnrealEngine;

namespace CSharpScript.Launcher.LogUpload
{
	// Token: 0x020001BC RID: 444
	[NullableContext(1)]
	[Nullable(0)]
	public class LauncherLogUpload : Singleton
	{
		// Token: 0x06000BED RID: 3053 RVA: 0x0004A7D0 File Offset: 0x000489D0
		public void Init()
		{
			if (AppUtil.IsPioneerApp())
			{
				UKuroStaticLibrary.ResetHttpMaxFlushTimeSeconds();
				this.EnableAutoSend = true;
			}
			UKuroTencentCOSLibrary.EnableAuthorization(false);
			EntryJson cdnReturnConfigInfo = BaseConfigController.Instance.GetCdnReturnConfigInfo();
			ILogReport logReport = (cdnReturnConfigInfo != null) ? cdnReturnConfigInfo.LogReport : null;
			if (logReport != null)
			{
				UKuroTencentCOSLibrary.SetSendLogConfig("", "", logReport.name, logReport.region);
			}
			else
			{
				LauncherLog.Instance.Error("CDN下发数据未配置腾讯云对象存储相关配置！", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			UKuroTencentCOSLibrary.SetAdmissibleValue(5);
			FOnPrepareSendDelegate fonPrepareSendDelegate = DelegateUtils.ToManualReleaseDelegate<FOnPrepareSendDelegate>(new <>A{00000003}<TArray<string>>(this.PreSendFiles));
			FOnPostSended fonPostSended = DelegateUtils.ToManualReleaseDelegate<FOnPostSended>(new <>A{00000003}<TArray<string>>(this.PostSended));
			UKuroTencentCOSLibrary.SetHandleFunc(fonPrepareSendDelegate, fonPostSended);
			if (this.EnableAutoSend)
			{
				if (Platform.Instance.IsPcOrGamepadPlatform())
				{
					UKuroTencentCOSLibrary.EnableAutoSendWhenExit();
				}
				if (Platform.Instance.IsMobilePlatform() && UKuroLauncherLibrary.GetNetworkConnectionType() == 4)
				{
					FOnProgress onProgress = DelegateUtils.ToManualReleaseDelegate<FOnProgress>(new Action<ESendState, float>(this.OnAutoSendProgres));
					this.SendLog(onProgress, new SendLogReason
					{
						Reason = ELauncherLogUploadReason.Manual
					});
				}
			}
		}

		// Token: 0x06000BEE RID: 3054 RVA: 0x0004A8CC File Offset: 0x00048ACC
		public void SetParams(ILogUploadParams params_)
		{
			this.LogUploadParams = params_;
		}

		// Token: 0x06000BEF RID: 3055 RVA: 0x0004A8D5 File Offset: 0x00048AD5
		private string LauncherLogUploadReasonToString(ELauncherLogUploadReason reason)
		{
			switch (reason)
			{
			case ELauncherLogUploadReason.Manual:
				return "C001";
			case ELauncherLogUploadReason.Customer:
				return "KF001";
			case ELauncherLogUploadReason.ErrorPopup:
				return "C002";
			case ELauncherLogUploadReason.ErrorPopupWithCode:
				return "C";
			default:
				return "";
			}
		}

		// Token: 0x06000BF0 RID: 3056 RVA: 0x0004A90C File Offset: 0x00048B0C
		private void SetRuleSuffix(ISendLogReason reason)
		{
			if (reason.Reason != ELauncherLogUploadReason.ErrorPopupWithCode)
			{
				this.RuleSuffix = this.LauncherLogUploadReasonToString(reason.Reason);
				return;
			}
			if (string.IsNullOrEmpty(reason.Info))
			{
				this.RuleSuffix = "";
				LauncherLog.Instance.Warn("[LauncherLogUpload] 以错误码弹窗模式上报，但是忘记传错误码！默认回退成旧版本，不含规则码后缀！", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			if (Regex.IsMatch(reason.Info, "^\\d+$"))
			{
				this.RuleSuffix = this.LauncherLogUploadReasonToString(reason.Reason) + reason.Info;
				return;
			}
			this.RuleSuffix = "";
			LauncherLog.Instance.Warn("[LauncherLogUpload] 以错误码弹窗模式上报，但是错误码格式错误（非纯数字）！默认回退成旧版本，不含规则码后缀！", default(ReadOnlySpan<ValueTuple<string, object>>));
		}

		// Token: 0x06000BF1 RID: 3057 RVA: 0x0004A9BC File Offset: 0x00048BBC
		private void OnAutoSendProgres(ESendState State, float Rate)
		{
			if (State == ESendState.ESS_Done || State == ESendState.ESS_Fail)
			{
				UKuroTencentCOSLibrary.SetIsAutoSend(false);
			}
		}

		// Token: 0x06000BF2 RID: 3058 RVA: 0x0004A9CC File Offset: 0x00048BCC
		public void PostSended(in TArray<string> SendedFiles)
		{
			if (this.SendedLogs == null)
			{
				this.SendedLogs = new ILocalSendedSave
				{
					Paths = new List<string>()
				};
			}
			string logFilename = KuroLoggingLibrary.GetLogFilename();
			int num = SendedFiles.Num();
			for (int i = 0; i < num; i++)
			{
				string text = SendedFiles.Get(i);
				if (!text.EndsWith(logFilename) && !this.SendedLogs.Paths.Contains(text))
				{
					this.SendedLogs.Paths.Add(text);
				}
			}
			UKuroStaticLibrary.SaveStringToFile(LauncherJson.Stringify<ILocalSendedSave>(this.SendedLogs, null), UKuroLauncherLibrary.GameSavedDir() + "Logs/Sendedlogs.json", false);
		}

		// Token: 0x06000BF3 RID: 3059 RVA: 0x0004AA6C File Offset: 0x00048C6C
		public void PreSendFiles(in TArray<string> FileNames)
		{
			TArray<string> tarray = new TArray<string>();
			List<string> list = new List<string>();
			int num = FileNames.Num();
			for (int i = 0; i < num; i++)
			{
				string text = FileNames.Get(i);
				if (!this.IsDir(text))
				{
					string[] array = text.Split('/', StringSplitOptions.None);
					string text2 = array[array.Length - 1].ToLower();
					string[] array2 = text2.Split('.', StringSplitOptions.None);
					string a = null;
					if (array2.Length > 1)
					{
						a = array2[array2.Length - 1];
					}
					if (text2.StartsWith("client") && !text2.StartsWith("client_") && !(a != "log"))
					{
						if (text2.StartsWith("client-"))
						{
							list.Add(text);
						}
						else
						{
							tarray.Add(text);
						}
					}
				}
			}
			string text3 = UKuroLauncherLibrary.GameSavedDir() + "Logs/Sendedlogs.json";
			if (UKuroStaticLibrary.FileExists(text3))
			{
				string text4 = null;
				UKuroStaticLibrary.LoadFileToString(ref text4, text3);
				this.SendedLogs = LauncherJson.Parse<ILocalSendedSave>(text4, null);
				if (this.SendedLogs != null)
				{
					HashSet<string> hashSet = new HashSet<string>(list);
					List<string> paths = this.SendedLogs.Paths;
					this.SendedLogs.Paths = new List<string>();
					foreach (string item in paths)
					{
						if (hashSet.Contains(item))
						{
							this.SendedLogs.Paths.Add(item);
						}
					}
				}
			}
			if (list.Count > 20)
			{
				list.Sort();
				list.RemoveRange(0, list.Count - 20);
			}
			if (this.SendedLogs != null)
			{
				HashSet<string> hashSet2 = new HashSet<string>(this.SendedLogs.Paths);
				List<string> list2 = new List<string>();
				foreach (string item2 in list)
				{
					if (!hashSet2.Contains(item2))
					{
						list2.Add(item2);
					}
				}
				list = list2;
			}
			if (list.Count > 0)
			{
				Match match = Regex.Match(list[0], "\\d{4}.\\d{1,2}.\\d{1,2}-\\d{1,2}.\\d{1,2}.\\d{1,2}");
				if (match.Success && match.Groups.Count > 0)
				{
					this.StartTime = match.Groups[0].Value;
				}
			}
			foreach (string value in list)
			{
				tarray.Add(value);
			}
			bool flag = UKuroTencentCOSLibrary.IsAutoSendWhenExitRunning();
			string suffix = this.LauncherLogUploadReasonToString(ELauncherLogUploadReason.Manual);
			string text5 = flag ? this.GetSendZipName(suffix) : this.GetSendZipName(this.RuleSuffix);
			if (flag)
			{
				UKuroTencentCOSLibrary.SetIsAutoSend(false);
			}
			this.RuleSuffix = "";
			UKuroTencentCOSLibrary.SetFilesToSend(tarray);
			UKuroTencentCOSLibrary.SetSendLogZipName(text5);
			UKuroTencentCOSLibrary.SetCloudPath(this.GetFullPath(text5));
		}

		// Token: 0x06000BF4 RID: 3060 RVA: 0x0004AD68 File Offset: 0x00048F68
		private bool IsDir(string path)
		{
			return UKuroStaticLibrary.DirectoryExists(path);
		}

		// Token: 0x06000BF5 RID: 3061 RVA: 0x0004AD70 File Offset: 0x00048F70
		private string GetSendZipPlatformName()
		{
			string text = KuroApplication.IniPlatformName();
			if (text != null)
			{
				switch (text.Length)
				{
				case 3:
				{
					char c = text[0];
					if (c <= 'M')
					{
						if (c != 'I')
						{
							if (c != 'M')
							{
								goto IL_138;
							}
							if (!(text == "Mac"))
							{
								goto IL_138;
							}
							return text;
						}
						else
						{
							if (!(text == "IOS"))
							{
								goto IL_138;
							}
							return text;
						}
					}
					else if (c != 'P')
					{
						if (c != 'X')
						{
							goto IL_138;
						}
						if (!(text == "XSX"))
						{
							goto IL_138;
						}
					}
					else
					{
						if (!(text == "PS5"))
						{
							goto IL_138;
						}
						return text;
					}
					break;
				}
				case 4:
				case 8:
				case 9:
				case 10:
					goto IL_138;
				case 5:
					if (!(text == "Linux"))
					{
						goto IL_138;
					}
					return text;
				case 6:
					if (!(text == "WinGDK"))
					{
						goto IL_138;
					}
					break;
				case 7:
				{
					char c = text[0];
					if (c != 'A')
					{
						if (c != 'W')
						{
							if (c != 'X')
							{
								goto IL_138;
							}
							if (!(text == "XboxOne"))
							{
								goto IL_138;
							}
						}
						else
						{
							if (!(text == "Windows"))
							{
								goto IL_138;
							}
							return text;
						}
					}
					else
					{
						if (!(text == "Android"))
						{
							goto IL_138;
						}
						return text;
					}
					break;
				}
				case 11:
					if (!(text == "OpenHarmony"))
					{
						goto IL_138;
					}
					return text;
				default:
					goto IL_138;
				}
				return "Xbox";
			}
			IL_138:
			LauncherLog instance = LauncherLog.Instance;
			string message = "未识别的平台, 默认归类到Default分类下";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("平台名", text);
			instance.Error(message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return "Default";
		}

		// Token: 0x06000BF6 RID: 3062 RVA: 0x0004AEE0 File Offset: 0x000490E0
		private string GetSendZipName(string suffix)
		{
			this.UpdateUserId();
			string text = "";
			if (this.StartTime != "")
			{
				text = this.StartTime + "-";
			}
			string text2 = (suffix == "") ? "" : ("-" + suffix);
			DateTime now = DateTime.Now;
			int year = now.Year;
			int month = now.Month;
			int day = now.Day;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(5, 6);
			defaultInterpolatedStringHandler.AppendFormatted<int>(year);
			defaultInterpolatedStringHandler.AppendLiteral(".");
			defaultInterpolatedStringHandler.AppendFormatted<int>(month);
			defaultInterpolatedStringHandler.AppendLiteral(".");
			defaultInterpolatedStringHandler.AppendFormatted<int>(day);
			defaultInterpolatedStringHandler.AppendLiteral("-");
			defaultInterpolatedStringHandler.AppendFormatted<int>(now.Hour);
			defaultInterpolatedStringHandler.AppendLiteral(".");
			defaultInterpolatedStringHandler.AppendFormatted<int>(now.Minute);
			defaultInterpolatedStringHandler.AppendLiteral(".");
			defaultInterpolatedStringHandler.AppendFormatted<int>(now.Second);
			string text3 = defaultInterpolatedStringHandler.ToStringAndClear();
			if (this.UserId == "")
			{
				return text + text3 + text2 + ".zip";
			}
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(5, 4);
			defaultInterpolatedStringHandler.AppendFormatted(this.UserId);
			defaultInterpolatedStringHandler.AppendLiteral("-");
			defaultInterpolatedStringHandler.AppendFormatted(text);
			defaultInterpolatedStringHandler.AppendFormatted(text3);
			defaultInterpolatedStringHandler.AppendFormatted(text2);
			defaultInterpolatedStringHandler.AppendLiteral(".zip");
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}

		// Token: 0x06000BF7 RID: 3063 RVA: 0x0004B060 File Offset: 0x00049260
		private string GetFullPath(string zipName)
		{
			DateTime now = DateTime.Now;
			string text = now.Year.ToString();
			string text2 = now.Month.ToString();
			string text3 = now.Day.ToString();
			return string.Concat(new string[]
			{
				"/",
				text,
				"/",
				text2,
				"/",
				text3,
				"/",
				this.GetSendZipPlatformName(),
				"/",
				zipName
			});
		}

		// Token: 0x06000BF8 RID: 3064 RVA: 0x0004B0F4 File Offset: 0x000492F4
		public void SendLog(FOnProgress OnProgress, [Nullable(2)] ISendLogReason reason = null)
		{
			this.RuleSuffix = "";
			if (reason != null)
			{
				this.SetRuleSuffix(reason);
			}
			UKuroTencentCOSLibrary.SendLogToTencentCOS(OnProgress);
		}

		// Token: 0x06000BF9 RID: 3065 RVA: 0x0004B114 File Offset: 0x00049314
		private void UpdateUserId()
		{
			string str = "";
			if (this.LogUploadParams.Net.IsServerConnected())
			{
				int? num;
				str = (((this.LogUploadParams.PlayerInfoModel.GetId() != null) ? num.GetValueOrDefault().ToString() : null) ?? "");
			}
			else
			{
				int? num2 = this.LogUploadParams.LocalStorage.GetRecentlyLoginUid();
				if (num2 != null)
				{
					str = num2.ToString();
				}
			}
			string str2 = "0";
			if (this.LogUploadParams.KuroSdkController.CanUseSdk())
			{
				ILoginModel loginModel = this.LogUploadParams.LoginModel;
				str2 = (((loginModel != null) ? loginModel.GetSdkLoginConfigUid() : null) ?? "0");
			}
			this.UserId = str2 + "-" + str;
			LauncherLog instance = LauncherLog.Instance;
			string message = "获取日志上传UID";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("UID", this.UserId);
			instance.Info(message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x06000BFA RID: 3066 RVA: 0x0004B227 File Offset: 0x00049427
		public static LauncherLogUpload Instance
		{
			get
			{
				if (LauncherLogUpload._instance == null)
				{
					LauncherLogUpload._instance = new LauncherLogUpload();
					LauncherLogUpload._instance.OnInit();
				}
				return LauncherLogUpload._instance;
			}
		}

		// Token: 0x06000BFB RID: 3067 RVA: 0x0004B24A File Offset: 0x0004944A
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06000BFC RID: 3068 RVA: 0x0004B24C File Offset: 0x0004944C
		public static void ResetStaticDefaultValue()
		{
			LauncherLogUpload instance = LauncherLogUpload._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			LauncherLogUpload._instance = null;
		}

		// Token: 0x06000BFD RID: 3069 RVA: 0x0004B265 File Offset: 0x00049465
		static LauncherLogUpload()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(LauncherLogUpload.CreateStaticDefaultValue), new Action(LauncherLogUpload.ResetStaticDefaultValue));
		}

		// Token: 0x04000791 RID: 1937
		private bool EnableAutoSend;

		// Token: 0x04000792 RID: 1938
		private const int AdmissibleSize = 5;

		// Token: 0x04000793 RID: 1939
		[Nullable(2)]
		private ILogUploadParams LogUploadParams;

		// Token: 0x04000794 RID: 1940
		private string StartTime = "";

		// Token: 0x04000795 RID: 1941
		private const int MaxUploadBackUpLogNum = 20;

		// Token: 0x04000796 RID: 1942
		private string UserId = "";

		// Token: 0x04000797 RID: 1943
		private const string SendedLogPath = "Logs/Sendedlogs.json";

		// Token: 0x04000798 RID: 1944
		[Nullable(2)]
		private ILocalSendedSave SendedLogs;

		// Token: 0x04000799 RID: 1945
		private string RuleSuffix = "";

		// Token: 0x0400079A RID: 1946
		[Nullable(2)]
		private static LauncherLogUpload _instance;
	}
}
