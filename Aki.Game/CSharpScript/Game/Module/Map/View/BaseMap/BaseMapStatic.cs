using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Map.View.BaseMap
{
	// Token: 0x0200548C RID: 21644
	[NullableContext(1)]
	[Nullable(0)]
	public class BaseMapStatic : Singleton
	{
		// Token: 0x17008481 RID: 33921
		// (get) Token: 0x0603746A RID: 226410 RVA: 0x00D1E09A File Offset: 0x00D1C29A
		public static BaseMapStatic Instance
		{
			get
			{
				if (BaseMapStatic._instance == null)
				{
					BaseMapStatic._instance = new BaseMapStatic();
					BaseMapStatic._instance.OnInit();
				}
				return BaseMapStatic._instance;
			}
		}

		// Token: 0x0603746B RID: 226411 RVA: 0x00D1E0BD File Offset: 0x00D1C2BD
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603746C RID: 226412 RVA: 0x00D1E0BF File Offset: 0x00D1C2BF
		public static void ResetStaticDefaultValue()
		{
			BaseMapStatic instance = BaseMapStatic._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			BaseMapStatic._instance = null;
		}

		// Token: 0x0603746D RID: 226413 RVA: 0x00D1E0D8 File Offset: 0x00D1C2D8
		static BaseMapStatic()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(BaseMapStatic.CreateStaticDefaultValue), new Action(BaseMapStatic.ResetStaticDefaultValue));
		}

		// Token: 0x0401D209 RID: 119305
		public int MapMaterialVersion = 2;

		// Token: 0x0401D20A RID: 119306
		[Nullable(2)]
		private static BaseMapStatic _instance;
	}
}
