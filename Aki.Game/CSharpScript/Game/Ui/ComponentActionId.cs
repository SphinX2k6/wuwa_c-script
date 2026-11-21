using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Ui
{
	// Token: 0x02003543 RID: 13635
	[NullableContext(1)]
	[Nullable(0)]
	public class ComponentActionId : Singleton
	{
		// Token: 0x1700487D RID: 18557
		// (get) Token: 0x06022ACE RID: 142030 RVA: 0x009DDD12 File Offset: 0x009DBF12
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

		// Token: 0x06022ACF RID: 142031 RVA: 0x009DDD35 File Offset: 0x009DBF35
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06022AD0 RID: 142032 RVA: 0x009DDD37 File Offset: 0x009DBF37
		public static void ResetStaticDefaultValue()
		{
			ComponentActionId instance = ComponentActionId._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			ComponentActionId._instance = null;
		}

		// Token: 0x06022AD1 RID: 142033 RVA: 0x009DDD50 File Offset: 0x009DBF50
		static ComponentActionId()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ComponentActionId.CreateStaticDefaultValue), new Action(ComponentActionId.ResetStaticDefaultValue));
		}

		// Token: 0x04013374 RID: 78708
		public int SelfIncrementId;

		// Token: 0x04013375 RID: 78709
		[Nullable(2)]
		private static ComponentActionId _instance;
	}
}
