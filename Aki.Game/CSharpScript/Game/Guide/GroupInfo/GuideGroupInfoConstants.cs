using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Guide.GroupInfo
{
	// Token: 0x02003537 RID: 13623
	public class GuideGroupInfoConstants : IStaticVariableResetter
	{
		// Token: 0x06022A9B RID: 141979 RVA: 0x009DD1A7 File Offset: 0x009DB3A7
		static GuideGroupInfoConstants()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(GuideGroupInfoConstants.CreateStaticDefaultValue), new Action(GuideGroupInfoConstants.ResetStaticDefaultValue));
		}

		// Token: 0x06022A9C RID: 141980 RVA: 0x009DD1C6 File Offset: 0x009DB3C6
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

		// Token: 0x06022A9D RID: 141981 RVA: 0x009DD1FB File Offset: 0x009DB3FB
		public static void ResetStaticDefaultValue()
		{
			GuideGroupInfoConstants.stateDesc = null;
		}

		// Token: 0x04013356 RID: 78678
		[Nullable(1)]
		public static string[] stateDesc;
	}
}
