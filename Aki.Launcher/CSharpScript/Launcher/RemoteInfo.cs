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
		// (get) Token: 0x060002A7 RID: 679 RVA: 0x0000E044 File Offset: 0x0000C244
		// (set) Token: 0x060002A8 RID: 680 RVA: 0x0000E04C File Offset: 0x0000C24C
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

		// Token: 0x060002A9 RID: 681 RVA: 0x0000E055 File Offset: 0x0000C255
		public bool IsResourceQualityTierEnabled()
		{
			return this.EnableResourceQualityTier && (Platform.Instance.IsWindowsOnlyPlatform() || Platform.Instance.IsIOSPlatform() || Platform.Instance.IsAndroidPlatform());
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x060002AA RID: 682 RVA: 0x0000E085 File Offset: 0x0000C285
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

		// Token: 0x060002AB RID: 683 RVA: 0x0000E0A8 File Offset: 0x0000C2A8
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x060002AC RID: 684 RVA: 0x0000E0AA File Offset: 0x0000C2AA
		public static void ResetStaticDefaultValue()
		{
			RemoteInfo instance = RemoteInfo._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			RemoteInfo._instance = null;
		}

		// Token: 0x060002AD RID: 685 RVA: 0x0000E0C3 File Offset: 0x0000C2C3
		static RemoteInfo()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(RemoteInfo.CreateStaticDefaultValue), new Action(RemoteInfo.ResetStaticDefaultValue));
		}

		// Token: 0x040001B7 RID: 439
		private RemoteVersionConfig VersionConfig;

		// Token: 0x040001B8 RID: 440
		public RemoteConfig Config;

		// Token: 0x040001B9 RID: 441
		public RemoteVersionConfig PreVerConfig;

		// Token: 0x040001BA RID: 442
		public readonly bool EnableResourceQualityTier = true;

		// Token: 0x040001BB RID: 443
		[Nullable(1)]
		public readonly Dictionary<ETier, RemoteVersionConfig> NewTierConfig = new Dictionary<ETier, RemoteVersionConfig>();

		// Token: 0x040001BC RID: 444
		public ETier ActiveTier;

		// Token: 0x040001BD RID: 445
		private static RemoteInfo _instance;
	}
}
