using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PermanentRogue
{
	// Token: 0x02005338 RID: 21304
	internal static class <RogueResTrialPopView>FDADFB2A9BC14ABAED9384706B037305D07C2C04A563EB30B9F601FAE7EC4A498__TxtColorMap
	{
		// Token: 0x06036736 RID: 223030 RVA: 0x00CE4711 File Offset: 0x00CE2911
		[NullableContext(1)]
		public static string GetColor(ERogueResTrialType type)
		{
			if (type == ERogueResTrialType.Static)
			{
				return "#f4f0e5";
			}
			if (type == ERogueResTrialType.Dynamic)
			{
				return "#FFFFFF";
			}
			return "#f4f0e5";
		}
	}
}
