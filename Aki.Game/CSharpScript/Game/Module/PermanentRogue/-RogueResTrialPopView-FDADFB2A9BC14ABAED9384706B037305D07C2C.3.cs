using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PermanentRogue
{
	// Token: 0x02004309 RID: 17161
	internal static class <RogueResTrialPopView>FDADFB2A9BC14ABAED9384706B037305D07C2C04A563EB30B9F601FAE7EC4A498__TabTextMap
	{
		// Token: 0x0602B633 RID: 177715 RVA: 0x00C320FB File Offset: 0x00C302FB
		[NullableContext(1)]
		public static string GetText(ERogueResTrialType type)
		{
			if (type == ERogueResTrialType.Static)
			{
				return "Rogue_Trial_Role_Resident";
			}
			if (type == ERogueResTrialType.Dynamic)
			{
				return "Rogue_Trial_Role_Limit";
			}
			return "";
		}
	}
}
