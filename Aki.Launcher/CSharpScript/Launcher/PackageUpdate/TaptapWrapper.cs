using System;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.BaseConfig;
using UnrealEngine;

namespace CSharpScript.Launcher.PackageUpdate
{
	// Token: 0x020001A9 RID: 425
	public class TaptapWrapper
	{
		// Token: 0x06000BD4 RID: 3028 RVA: 0x0004BC2C File Offset: 0x00049E2C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Init()
		{
			string publicValue = BaseConfigController.Instance.GetPublicValue("TaptapClientId");
			string publicValue2 = BaseConfigController.Instance.GetPublicValue("TaptapClientToken");
			UTapUpdateStaticLibrary.Init(publicValue, publicValue2);
		}

		// Token: 0x06000BD5 RID: 3029 RVA: 0x0004BC5E File Offset: 0x00049E5E
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void UpdateGame()
		{
			UTapUpdateStaticLibrary.UpdateGame(null);
		}
	}
}
