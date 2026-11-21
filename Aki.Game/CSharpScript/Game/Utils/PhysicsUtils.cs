using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Utils
{
	// Token: 0x02003476 RID: 13430
	[NullableContext(1)]
	[Nullable(0)]
	public class PhysicsUtils : Singleton
	{
		// Token: 0x17004808 RID: 18440
		// (get) Token: 0x06022469 RID: 140393 RVA: 0x009B5C01 File Offset: 0x009B3E01
		public static PhysicsUtils Instance
		{
			get
			{
				if (PhysicsUtils._instance == null)
				{
					PhysicsUtils._instance = new PhysicsUtils();
					PhysicsUtils._instance.OnInit();
				}
				return PhysicsUtils._instance;
			}
		}

		// Token: 0x0602246A RID: 140394 RVA: 0x009B5C24 File Offset: 0x009B3E24
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602246B RID: 140395 RVA: 0x009B5C26 File Offset: 0x009B3E26
		public static void ResetStaticDefaultValue()
		{
			PhysicsUtils instance = PhysicsUtils._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			PhysicsUtils._instance = null;
		}

		// Token: 0x0602246C RID: 140396 RVA: 0x009B5C3F File Offset: 0x009B3E3F
		static PhysicsUtils()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(PhysicsUtils.CreateStaticDefaultValue), new Action(PhysicsUtils.ResetStaticDefaultValue));
		}

		// Token: 0x04012DE3 RID: 77283
		public FHitResult DefaultHitResult = new FHitResult();

		// Token: 0x04012DE4 RID: 77284
		[Nullable(2)]
		private static PhysicsUtils _instance;
	}
}
