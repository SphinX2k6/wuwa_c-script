using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Utils
{
	// Token: 0x0200454E RID: 17742
	[NullableContext(1)]
	[Nullable(0)]
	public class PhysicsUtils : Singleton
	{
		// Token: 0x17007551 RID: 30033
		// (get) Token: 0x0602DD87 RID: 187783 RVA: 0x00A8A6D1 File Offset: 0x00A888D1
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

		// Token: 0x0602DD88 RID: 187784 RVA: 0x00A8A6F4 File Offset: 0x00A888F4
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602DD89 RID: 187785 RVA: 0x00A8A6F6 File Offset: 0x00A888F6
		public static void ResetStaticDefaultValue()
		{
			PhysicsUtils instance = PhysicsUtils._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			PhysicsUtils._instance = null;
		}

		// Token: 0x0602DD8A RID: 187786 RVA: 0x00A8A70F File Offset: 0x00A8890F
		static PhysicsUtils()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(PhysicsUtils.CreateStaticDefaultValue), new Action(PhysicsUtils.ResetStaticDefaultValue));
		}

		// Token: 0x040187A9 RID: 100265
		public FHitResult DefaultHitResult = new FHitResult();

		// Token: 0x040187AA RID: 100266
		[Nullable(2)]
		private static PhysicsUtils _instance;
	}
}
