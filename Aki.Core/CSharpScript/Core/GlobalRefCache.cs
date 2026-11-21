using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Core
{
	// Token: 0x02000129 RID: 297
	[NullableContext(1)]
	[Nullable(0)]
	public class GlobalRefCache : Singleton
	{
		// Token: 0x17000110 RID: 272
		// (get) Token: 0x06000B02 RID: 2818 RVA: 0x00034AB8 File Offset: 0x00032CB8
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

		// Token: 0x06000B03 RID: 2819 RVA: 0x00034ADB File Offset: 0x00032CDB
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06000B04 RID: 2820 RVA: 0x00034ADD File Offset: 0x00032CDD
		public static void ResetStaticDefaultValue()
		{
			GlobalRefCache instance = GlobalRefCache._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			GlobalRefCache._instance = null;
		}

		// Token: 0x06000B05 RID: 2821 RVA: 0x00034AF6 File Offset: 0x00032CF6
		static GlobalRefCache()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(GlobalRefCache.CreateStaticDefaultValue), new Action(GlobalRefCache.ResetStaticDefaultValue));
		}

		// Token: 0x040006B2 RID: 1714
		public FHitResult HitResult = new FHitResult();

		// Token: 0x040006B3 RID: 1715
		[Nullable(2)]
		private static GlobalRefCache _instance;
	}
}
