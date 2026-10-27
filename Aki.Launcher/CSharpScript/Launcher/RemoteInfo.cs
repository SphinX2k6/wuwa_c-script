using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.Platform;
using CSharpScript.Launcher.Util;

namespace CSharpScript.Launcher
{
	// Token: 0x02000066 RID: 102
	[NullableContext(2)]
	[Nullable(0)]
	public class RemoteInfo : Singleton
	{
		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060002A6 RID: 678 RVA: 0x0000DD24 File Offset: 0x0000BF24
		// (set) Token: 0x060002A7 RID: 679 RVA: 0x0000DD2C File Offset: 0x0000BF2C
		public RemoteVersionConfig NewConfig
		{
			get
			{
				return this.VersionConfig;
			}
			set
			{
				this.VersionConfig = value;
			}
		}

		// Token: 0x060002A8 RID: 680 RVA: 0x0000DD35 File Offset: 0x0000BF35
		public bool IsResourceQualityTierEnabled()
		{
			return this.EnableResourceQualityTier && (Platform.Instance.IsWindowsOnlyPlatform() || Platform.Instance.IsIOSPlatform() || Platform.Instance.IsAndroidPlatform());
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x060002A9 RID: 681 RVA: 0x0000DD65 File Offset: 0x0000BF65
		[Nullable(1)]
		public static RemoteInfo Instance
		{
			[NullableContext(1)]
			get
			{
				if (RemoteInfo._instance == null)
				{
					RemoteInfo._instance = new RemoteInfo();
					RemoteInfo._instance.OnInit();
				}
				return RemoteInfo._instance;
			}
		}

		// Token: 0x060002AA RID: 682 RVA: 0x0000DD88 File Offset: 0x0000BF88
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x060002AB RID: 683 RVA: 0x0000DD8A File Offset: 0x0000BF8A
		public static void ResetStaticDefaultValue()
		{
			RemoteInfo instance = RemoteInfo._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			RemoteInfo._instance = null;
		}

		// Token: 0x060002AC RID: 684 RVA: 0x0000DDA3 File Offset: 0x0000BFA3
		static RemoteInfo()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(RemoteInfo.CreateStaticDefaultValue), new Action(RemoteInfo.ResetStaticDefaultValue));
		}

		// Token: 0x040001AB RID: 427
		private RemoteVersionConfig VersionConfig;

		// Token: 0x040001AC RID: 428
		public RemoteConfig Config;

		// Token: 0x040001AD RID: 429
		public RemoteVersionConfig PreVerConfig;

		// Token: 0x040001AE RID: 430
		public readonly bool EnableResourceQualityTier = true;

		// Token: 0x040001AF RID: 431
		[Nullable(1)]
		public readonly Dictionary<ETier, RemoteVersionConfig> NewTierConfig = new Dictionary<ETier, RemoteVersionConfig>();

		// Token: 0x040001B0 RID: 432
		public ETier ActiveTier;

		// Token: 0x040001B1 RID: 433
		private static RemoteInfo _instance;
	}
}
