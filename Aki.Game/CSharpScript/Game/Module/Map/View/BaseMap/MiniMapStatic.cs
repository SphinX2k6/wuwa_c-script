using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Map.View.BaseMap
{
	// Token: 0x02004471 RID: 17521
	[NullableContext(1)]
	[Nullable(0)]
	public class MiniMapStatic : Singleton
	{
		// Token: 0x17005858 RID: 22616
		// (get) Token: 0x0602C3F5 RID: 181237 RVA: 0x00C6E467 File Offset: 0x00C6C667
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

		// Token: 0x0602C3F6 RID: 181238 RVA: 0x00C6E48A File Offset: 0x00C6C68A
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602C3F7 RID: 181239 RVA: 0x00C6E48C File Offset: 0x00C6C68C
		public static void ResetStaticDefaultValue()
		{
			MiniMapStatic instance = MiniMapStatic._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			MiniMapStatic._instance = null;
		}

		// Token: 0x0602C3F8 RID: 181240 RVA: 0x00C6E4A5 File Offset: 0x00C6C6A5
		static MiniMapStatic()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(MiniMapStatic.CreateStaticDefaultValue), new Action(MiniMapStatic.ResetStaticDefaultValue));
		}

		// Token: 0x04017CB8 RID: 97464
		public int MapMaterialVersion = 2;

		// Token: 0x04017CB9 RID: 97465
		[Nullable(2)]
		private static MiniMapStatic _instance;
	}
}
