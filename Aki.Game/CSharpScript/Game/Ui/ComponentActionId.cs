using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Ui
{
	// Token: 0x0200461A RID: 17946
	[NullableContext(1)]
	[Nullable(0)]
	public class ComponentActionId : Singleton
	{
		// Token: 0x170075C5 RID: 30149
		// (get) Token: 0x0602E3D9 RID: 189401 RVA: 0x00AB161E File Offset: 0x00AAF81E
		public static ComponentActionId Instance
		{
			get
			{
				if (ComponentActionId._instance == null)
				{
					ComponentActionId._instance = new ComponentActionId();
					ComponentActionId._instance.OnInit();
				}
				return ComponentActionId._instance;
			}
		}

		// Token: 0x0602E3DA RID: 189402 RVA: 0x00AB1641 File Offset: 0x00AAF841
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602E3DB RID: 189403 RVA: 0x00AB1643 File Offset: 0x00AAF843
		public static void ResetStaticDefaultValue()
		{
			ComponentActionId instance = ComponentActionId._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			ComponentActionId._instance = null;
		}

		// Token: 0x0602E3DC RID: 189404 RVA: 0x00AB165C File Offset: 0x00AAF85C
		static ComponentActionId()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ComponentActionId.CreateStaticDefaultValue), new Action(ComponentActionId.ResetStaticDefaultValue));
		}

		// Token: 0x04018D35 RID: 101685
		public int SelfIncrementId;

		// Token: 0x04018D36 RID: 101686
		[Nullable(2)]
		private static ComponentActionId _instance;
	}
}
