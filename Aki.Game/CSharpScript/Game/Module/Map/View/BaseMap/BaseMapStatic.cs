using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Map.View.BaseMap
{
	// Token: 0x0200446F RID: 17519
	[NullableContext(1)]
	[Nullable(0)]
	public class BaseMapStatic : Singleton
	{
		// Token: 0x1700584D RID: 22605
		// (get) Token: 0x0602C3B4 RID: 181172 RVA: 0x00C6D775 File Offset: 0x00C6B975
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

		// Token: 0x0602C3B5 RID: 181173 RVA: 0x00C6D798 File Offset: 0x00C6B998
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602C3B6 RID: 181174 RVA: 0x00C6D79A File Offset: 0x00C6B99A
		public static void ResetStaticDefaultValue()
		{
			BaseMapStatic instance = BaseMapStatic._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			BaseMapStatic._instance = null;
		}

		// Token: 0x0602C3B7 RID: 181175 RVA: 0x00C6D7B3 File Offset: 0x00C6B9B3
		static BaseMapStatic()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(BaseMapStatic.CreateStaticDefaultValue), new Action(BaseMapStatic.ResetStaticDefaultValue));
		}

		// Token: 0x04017CA2 RID: 97442
		public int MapMaterialVersion = 2;

		// Token: 0x04017CA3 RID: 97443
		[Nullable(2)]
		private static BaseMapStatic _instance;
	}
}
