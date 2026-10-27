using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Map.View.BaseMap
{
	// Token: 0x0200548E RID: 21646
	[NullableContext(1)]
	[Nullable(0)]
	public class MiniMapStatic : Singleton
	{
		// Token: 0x1700848C RID: 33932
		// (get) Token: 0x060374A9 RID: 226473 RVA: 0x00D1ECF7 File Offset: 0x00D1CEF7
		public static MiniMapStatic Instance
		{
			get
			{
				if (MiniMapStatic._instance == null)
				{
					MiniMapStatic._instance = new MiniMapStatic();
					MiniMapStatic._instance.OnInit();
				}
				return MiniMapStatic._instance;
			}
		}

		// Token: 0x060374AA RID: 226474 RVA: 0x00D1ED1A File Offset: 0x00D1CF1A
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x060374AB RID: 226475 RVA: 0x00D1ED1C File Offset: 0x00D1CF1C
		public static void ResetStaticDefaultValue()
		{
			MiniMapStatic instance = MiniMapStatic._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			MiniMapStatic._instance = null;
		}

		// Token: 0x060374AC RID: 226476 RVA: 0x00D1ED35 File Offset: 0x00D1CF35
		static MiniMapStatic()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(MiniMapStatic.CreateStaticDefaultValue), new Action(MiniMapStatic.ResetStaticDefaultValue));
		}

		// Token: 0x0401D21E RID: 119326
		public int MapMaterialVersion = 2;

		// Token: 0x0401D21F RID: 119327
		[Nullable(2)]
		private static MiniMapStatic _instance;
	}
}
