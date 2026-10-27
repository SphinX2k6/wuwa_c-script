using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Core
{
	// Token: 0x02000128 RID: 296
	[NullableContext(1)]
	[Nullable(0)]
	public class GlobalRefCache : Singleton
	{
		// Token: 0x170000FD RID: 253
		// (get) Token: 0x06000AAB RID: 2731 RVA: 0x00034044 File Offset: 0x00032244
		public static GlobalRefCache Instance
		{
			get
			{
				if (GlobalRefCache._instance == null)
				{
					GlobalRefCache._instance = new GlobalRefCache();
					GlobalRefCache._instance.OnInit();
				}
				return GlobalRefCache._instance;
			}
		}

		// Token: 0x06000AAC RID: 2732 RVA: 0x00034067 File Offset: 0x00032267
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06000AAD RID: 2733 RVA: 0x00034069 File Offset: 0x00032269
		public static void ResetStaticDefaultValue()
		{
			GlobalRefCache instance = GlobalRefCache._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			GlobalRefCache._instance = null;
		}

		// Token: 0x06000AAE RID: 2734 RVA: 0x00034082 File Offset: 0x00032282
		static GlobalRefCache()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(GlobalRefCache.CreateStaticDefaultValue), new Action(GlobalRefCache.ResetStaticDefaultValue));
		}

		// Token: 0x040006A4 RID: 1700
		public FHitResult HitResult = new FHitResult();

		// Token: 0x040006A5 RID: 1701
		[Nullable(2)]
		private static GlobalRefCache _instance;
	}
}
