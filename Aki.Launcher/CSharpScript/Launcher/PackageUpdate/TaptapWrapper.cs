using System;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.BaseConfig;
using UnrealEngine;

namespace CSharpScript.Launcher.PackageUpdate
{
	// Token: 0x020001A5 RID: 421
	public class TaptapWrapper
	{
		// Token: 0x06000B9D RID: 2973 RVA: 0x0004943C File Offset: 0x0004763C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Init()
		{
			string publicValue = BaseConfigController.Instance.GetPublicValue("TaptapClientId");
			string publicValue2 = BaseConfigController.Instance.GetPublicValue("TaptapClientToken");
			UTapUpdateStaticLibrary.Init(publicValue, publicValue2);
		}

		// Token: 0x06000B9E RID: 2974 RVA: 0x0004946E File Offset: 0x0004766E
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void UpdateGame()
		{
			UTapUpdateStaticLibrary.UpdateGame(null);
		}
	}
}
