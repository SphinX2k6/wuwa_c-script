using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.BaseConfig;
using CSharpScript.Launcher.HotPatchKuroSdk;
using CSharpScript.Launcher.Platform;
using UnrealEngine;

namespace CSharpScript.Launcher
{
	// Token: 0x02000043 RID: 67
	[NullableContext(1)]
	[Nullable(0)]
	public class AppLinks : Singleton
	{
		// Token: 0x06000247 RID: 583 RVA: 0x0000B5E0 File Offset: 0x000097E0
		public void Init()
		{
			if (this.Initialized)
			{
				return;
			}
			if (!Platform.Instance.IsMobilePlatform())
			{
				return;
			}
			bool flag = BaseConfigController.Instance.GetPublicValue("SdkArea") != "CN";
			if (Platform.Instance.IsIOSPlatform() && flag)
			{
				UKuroLauncherLibrary.IsFirstIntoLauncher();
				return;
			}
			if (!HotPatchKuroSdk.Instance.CanUseSdk())
			{
				return;
			}
			UKuroSDKManager.Get().OnActivatedByApplinksDelegate.Clear();
			UKuroSDKManager.Get().OnActivatedByApplinksDelegate.Add(delegate(string host, string deepValue, string source)
			{
				AppLinks.Instance.ReportApplinksActivation(host, deepValue, source);
			});
			if (Platform.Instance.IsAndroidPlatform())
			{
				UKuroSDKManager.CheckApplinksActivation();
			}
			else if (Platform.Instance.IsIOSPlatform())
			{
				UKuroLauncherLibrary.IsFirstIntoLauncher();
			}
			this.Initialized = true;
		}

		// Token: 0x06000248 RID: 584 RVA: 0x0000B6A8 File Offset: 0x000098A8
		public void Destroy()
		{
			if (!this.Initialized)
			{
				return;
			}
			UKuroSDKManager.Get().OnActivatedByApplinksDelegate.Clear();
			this.DeepValueHandleMap.Clear();
			this.Initialized = false;
		}

		// Token: 0x06000249 RID: 585 RVA: 0x0000B6D4 File Offset: 0x000098D4
		public void ReportApplinksActivation(string host, string deepValue, string source)
		{
			if (host == "mc.kurogame.com" || host == "wutheringwaves.kurogame.com")
			{
				HotPatchLogReport.Instance.ReportAppLinksEvent(deepValue, source);
				if (deepValue != "" && this.DeepValueHandleMap.ContainsKey(deepValue))
				{
					this.DeepValueHandleMap[deepValue](deepValue, source);
				}
			}
			LauncherLog instance = LauncherLog.Instance;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(39, 3);
			defaultInterpolatedStringHandler.AppendLiteral("Application Activated By AppLinks: ");
			defaultInterpolatedStringHandler.AppendFormatted(host);
			defaultInterpolatedStringHandler.AppendLiteral(", ");
			defaultInterpolatedStringHandler.AppendFormatted(deepValue);
			defaultInterpolatedStringHandler.AppendLiteral(", ");
			defaultInterpolatedStringHandler.AppendFormatted(source);
			instance.Info(defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
		}

		// Token: 0x0600024A RID: 586 RVA: 0x0000B798 File Offset: 0x00009998
		public void SetDeepValueHandle(string deepValue, Action<string, string> handle)
		{
			if (this.DeepValueHandleMap.ContainsKey(deepValue))
			{
				LauncherLog.Instance.Error("Try to set duplicated handle for deepvalue: " + deepValue, default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			this.DeepValueHandleMap[deepValue] = handle;
		}

		// Token: 0x0600024B RID: 587 RVA: 0x0000B7E0 File Offset: 0x000099E0
		public void RemoveDeepValueHandle(string deepValue)
		{
			if (!this.DeepValueHandleMap.ContainsKey(deepValue))
			{
				LauncherLog.Instance.Error("Can't find handle for deepvalue: " + deepValue, default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			this.DeepValueHandleMap.Remove(deepValue);
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x0600024C RID: 588 RVA: 0x0000B827 File Offset: 0x00009A27
		public static AppLinks Instance
		{
			get
			{
				if (AppLinks._instance == null)
				{
					AppLinks._instance = new AppLinks();
					AppLinks._instance.OnInit();
				}
				return AppLinks._instance;
			}
		}

		// Token: 0x0600024D RID: 589 RVA: 0x0000B84A File Offset: 0x00009A4A
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0600024E RID: 590 RVA: 0x0000B84C File Offset: 0x00009A4C
		public static void ResetStaticDefaultValue()
		{
			AppLinks instance = AppLinks._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			AppLinks._instance = null;
		}

		// Token: 0x0600024F RID: 591 RVA: 0x0000B865 File Offset: 0x00009A65
		static AppLinks()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(AppLinks.CreateStaticDefaultValue), new Action(AppLinks.ResetStaticDefaultValue));
		}

		// Token: 0x040000F2 RID: 242
		private const string APP_LINKS_HOST = "mc.kurogame.com";

		// Token: 0x040000F3 RID: 243
		private const string APP_LINKS_HOST_GLOBAL = "wutheringwaves.kurogame.com";

		// Token: 0x040000F4 RID: 244
		private bool Initialized;

		// Token: 0x040000F5 RID: 245
		private readonly Dictionary<string, Action<string, string>> DeepValueHandleMap = new Dictionary<string, Action<string, string>>();

		// Token: 0x040000F6 RID: 246
		[Nullable(2)]
		private static AppLinks _instance;
	}
}
