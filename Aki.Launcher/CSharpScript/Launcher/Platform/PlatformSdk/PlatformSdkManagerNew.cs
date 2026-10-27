using System;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.BaseConfig;
using UnrealEngine;

namespace CSharpScript.Launcher.Platform.PlatformSdk
{
	// Token: 0x02000132 RID: 306
	[NullableContext(1)]
	[Nullable(0)]
	public class PlatformSdkManagerNew : Singleton
	{
		// Token: 0x060009C5 RID: 2501 RVA: 0x00043CC8 File Offset: 0x00041EC8
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

		// Token: 0x060009C6 RID: 2502 RVA: 0x00043D22 File Offset: 0x00041F22
		public void UnInitialize()
		{
			PlatformSdkNew platformSdk = this.PlatformSdk;
			if (platformSdk == null)
			{
				return;
			}
			platformSdk.UnInitialize();
		}

		// Token: 0x060009C7 RID: 2503 RVA: 0x00043D38 File Offset: 0x00041F38
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

		// Token: 0x060009C8 RID: 2504 RVA: 0x00043D8E File Offset: 0x00041F8E
		public PlatformSdkNew GetPlatformSdk()
		{
			return this.PlatformSdk;
		}

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x060009C9 RID: 2505 RVA: 0x00043D96 File Offset: 0x00041F96
		public bool IsSdkOn
		{
			get
			{
				return Platform.Instance.Type == EPlatformType.PS5 && BaseConfigController.Instance.GetPublicValue("UseSDK") == "1";
			}
		}

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x060009CA RID: 2506 RVA: 0x00043DC0 File Offset: 0x00041FC0
		public bool IfNeedPlatformSdkConfig
		{
			get
			{
				return Platform.Instance.Type == EPlatformType.PS5 && BaseConfigController.Instance.GetPublicValue("UseSDK") == "1";
			}
		}

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x060009CB RID: 2507 RVA: 0x00043DEA File Offset: 0x00041FEA
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

		// Token: 0x060009CC RID: 2508 RVA: 0x00043E0D File Offset: 0x0004200D
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x060009CD RID: 2509 RVA: 0x00043E0F File Offset: 0x0004200F
		public static void ResetStaticDefaultValue()
		{
			PlatformSdkManagerNew instance = PlatformSdkManagerNew._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			PlatformSdkManagerNew._instance = null;
		}

		// Token: 0x060009CE RID: 2510 RVA: 0x00043E28 File Offset: 0x00042028
		static PlatformSdkManagerNew()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(PlatformSdkManagerNew.CreateStaticDefaultValue), new Action(PlatformSdkManagerNew.ResetStaticDefaultValue));
		}

		// Token: 0x040005BB RID: 1467
		private PlatformSdkNew PlatformSdk = new PlatformSdkNew();

		// Token: 0x040005BC RID: 1468
		[Nullable(2)]
		private static PlatformSdkManagerNew _instance;
	}
}
