using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

namespace CSharpScript.Game
{
	// Token: 0x02003449 RID: 13385
	public class Main
	{
		// Token: 0x06022264 RID: 139876 RVA: 0x009AD31A File Offset: 0x009AB51A
		[ModuleInitializer]
		public static void Init()
		{
			Delegate onEnginePreGarbageCollectDelegate = GCEvent.OnEnginePreGarbageCollectDelegate;
			Action<bool> b;
			if ((b = Main.<>O.<0>__OnPreGC) == null)
			{
				b = (Main.<>O.<0>__OnPreGC = new Action<bool>(Main.OnPreGC));
			}
			GCEvent.OnEnginePreGarbageCollectDelegate = (Action<bool>)Delegate.Combine(onEnginePreGarbageCollectDelegate, b);
		}

		// Token: 0x06022265 RID: 139877 RVA: 0x009AD34B File Offset: 0x009AB54B
		private static void OnPreGC(bool IsLowMemory)
		{
			if (IsLowMemory)
			{
				GC.Collect(GC.MaxGeneration);
			}
		}

		// Token: 0x06022266 RID: 139878 RVA: 0x009AD35A File Offset: 0x009AB55A
		[NullableContext(1)]
		[Obfuscation]
		public static void DoMain(UGameInstance gameInstance)
		{
			GameProcedure.Start(gameInstance);
		}

		// Token: 0x020091B4 RID: 37300
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0402DA3A RID: 186938
			public static Action<bool> <0>__OnPreGC;
		}
	}
}
