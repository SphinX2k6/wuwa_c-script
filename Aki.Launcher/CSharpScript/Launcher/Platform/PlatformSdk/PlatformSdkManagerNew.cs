using System;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.BaseConfig;
using UnrealEngine;

namespace CSharpScript.Launcher.Platform.PlatformSdk
{
	// Token: 0x02000136 RID: 310
	[NullableContext(1)]
	[Nullable(0)]
	public class PlatformSdkManagerNew : Singleton
	{
		// Token: 0x060009F9 RID: 2553 RVA: 0x000460DC File Offset: 0x000442DC
		public bool Initialize(UObject worldContext)
		{
			if (!this.IsSdkOn)
			{
				LauncherLog.Instance.Info("[PlatformSdkNew] PlatformSdkManagerNew.Initialize: 平台Sdk未开启", default(ReadOnlySpan<ValueTuple<string, object>>));
				return true;
			}
			this.SwitchPlatformSdk();
			PlatformSdkConfig.Instance.Initialize();
			PlatformSdkServer.Instance.Initialize();
			return this.PlatformSdk.Initialize(worldContext);
		}

		// Token: 0x060009FA RID: 2554 RVA: 0x00046136 File Offset: 0x00044336
		public void UnInitialize()
		{
			PlatformSdkNew platformSdk = this.PlatformSdk;
			if (platformSdk == null)
			{
				return;
			}
			platformSdk.UnInitialize();
		}

		// Token: 0x060009FB RID: 2555 RVA: 0x0004614C File Offset: 0x0004434C
		private void SwitchPlatformSdk()
		{
			LauncherLog instance = LauncherLog.Instance;
			string message = "当前平台";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("type", Platform.Instance.Type);
			instance.Info(message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			if (Platform.Instance.Type == EPlatformType.PS5)
			{
				this.PlatformSdk = new PlayStation5Sdk();
			}
		}

		// Token: 0x060009FC RID: 2556 RVA: 0x000461A2 File Offset: 0x000443A2
		public PlatformSdkNew GetPlatformSdk()
		{
			return this.PlatformSdk;
		}

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x060009FD RID: 2557 RVA: 0x000461AA File Offset: 0x000443AA
		public bool IsSdkOn
		{
			get
			{
				return Platform.Instance.Type == EPlatformType.PS5 && BaseConfigController.Instance.GetPublicValue("UseSDK") == "1";
			}
		}

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x060009FE RID: 2558 RVA: 0x000461D4 File Offset: 0x000443D4
		public bool IfNeedPlatformSdkConfig
		{
			get
			{
				return Platform.Instance.Type == EPlatformType.PS5 && BaseConfigController.Instance.GetPublicValue("UseSDK") == "1";
			}
		}

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x060009FF RID: 2559 RVA: 0x000461FE File Offset: 0x000443FE
		public static PlatformSdkManagerNew Instance
		{
			get
			{
				if (PlatformSdkManagerNew._instance == null)
				{
					PlatformSdkManagerNew._instance = new PlatformSdkManagerNew();
					PlatformSdkManagerNew._instance.OnInit();
				}
				return PlatformSdkManagerNew._instance;
			}
		}

		// Token: 0x06000A00 RID: 2560 RVA: 0x00046221 File Offset: 0x00044421
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06000A01 RID: 2561 RVA: 0x00046223 File Offset: 0x00044423
		public static void ResetStaticDefaultValue()
		{
			PlatformSdkManagerNew instance = PlatformSdkManagerNew._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			PlatformSdkManagerNew._instance = null;
		}

		// Token: 0x06000A02 RID: 2562 RVA: 0x0004623C File Offset: 0x0004443C
		static PlatformSdkManagerNew()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(PlatformSdkManagerNew.CreateStaticDefaultValue), new Action(PlatformSdkManagerNew.ResetStaticDefaultValue));
		}

		// Token: 0x040005F6 RID: 1526
		private PlatformSdkNew PlatformSdk = new PlatformSdkNew();

		// Token: 0x040005F7 RID: 1527
		[Nullable(2)]
		private static PlatformSdkManagerNew _instance;
	}
}
