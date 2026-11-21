using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RoadBook
{
	// Token: 0x02005141 RID: 20801
	public class ActivityRoadBookDefine : IStaticVariableResetter
	{
		// Token: 0x06034059 RID: 213081 RVA: 0x00E8DF7D File Offset: 0x00E8C17D
		static ActivityRoadBookDefine()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ActivityRoadBookDefine.CreateStaticDefaultValue), new Action(ActivityRoadBookDefine.ResetStaticDefaultValue));
		}

		// Token: 0x0603405A RID: 213082 RVA: 0x00E8DF9C File Offset: 0x00E8C19C
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

		// Token: 0x0603405B RID: 213083 RVA: 0x00E8DFEF File Offset: 0x00E8C1EF
		public static void ResetStaticDefaultValue()
		{
			ActivityRoadBookDefine.RoadBookPhantomColorText = null;
		}

		// Token: 0x0401B855 RID: 112725
		[Nullable(1)]
		public static Dictionary<int, string> RoadBookPhantomColorText;
	}
}
