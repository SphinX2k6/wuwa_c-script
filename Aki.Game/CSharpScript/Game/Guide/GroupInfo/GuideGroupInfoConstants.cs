using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Guide.GroupInfo
{
	// Token: 0x0200460E RID: 17934
	public class GuideGroupInfoConstants : IStaticVariableResetter
	{
		// Token: 0x0602E3A6 RID: 189350 RVA: 0x00AB0AB3 File Offset: 0x00AAECB3
		static GuideGroupInfoConstants()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(GuideGroupInfoConstants.CreateStaticDefaultValue), new Action(GuideGroupInfoConstants.ResetStaticDefaultValue));
		}

		// Token: 0x0602E3A7 RID: 189351 RVA: 0x00AB0AD2 File Offset: 0x00AAECD2
		public static void CreateStaticDefaultValue()
		{
			GuideGroupInfoConstants.stateDesc = new string[]
			{
				"Init",
				"Opening",
				"Executing",
				"Pending",
				"Finishing"
			};
		}

		// Token: 0x0602E3A8 RID: 189352 RVA: 0x00AB0B07 File Offset: 0x00AAED07
		public static void ResetStaticDefaultValue()
		{
			GuideGroupInfoConstants.stateDesc = null;
		}

		// Token: 0x04018D17 RID: 101655
		[Nullable(1)]
		public static string[] stateDesc;
	}
}
