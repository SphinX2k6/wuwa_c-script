using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RoadBook
{
	// Token: 0x020061C3 RID: 25027
	public class ActivityRoadBookDefine : IStaticVariableResetter
	{
		// Token: 0x0603F398 RID: 258968 RVA: 0x00F47025 File Offset: 0x00F45225
		static ActivityRoadBookDefine()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ActivityRoadBookDefine.CreateStaticDefaultValue), new Action(ActivityRoadBookDefine.ResetStaticDefaultValue));
		}

		// Token: 0x0603F399 RID: 258969 RVA: 0x00F47044 File Offset: 0x00F45244
		public static void CreateStaticDefaultValue()
		{
			ActivityRoadBookDefine.RoadBookPhantomColorText = new Dictionary<int, string>
			{
				{
					0,
					"#5F5F62"
				},
				{
					1,
					"#384BFF"
				},
				{
					2,
					"#8A00FF"
				},
				{
					3,
					"#A7974D"
				},
				{
					4,
					"#BE1327"
				}
			};
		}

		// Token: 0x0603F39A RID: 258970 RVA: 0x00F47097 File Offset: 0x00F45297
		public static void ResetStaticDefaultValue()
		{
			ActivityRoadBookDefine.RoadBookPhantomColorText = null;
		}

		// Token: 0x04020F26 RID: 134950
		[Nullable(1)]
		public static Dictionary<int, string> RoadBookPhantomColorText;
	}
}
