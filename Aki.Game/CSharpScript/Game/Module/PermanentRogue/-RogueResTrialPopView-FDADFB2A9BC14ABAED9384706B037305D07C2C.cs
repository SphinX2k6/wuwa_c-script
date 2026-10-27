using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PermanentRogue
{
	// Token: 0x02005337 RID: 21303
	internal static class <RogueResTrialPopView>FDADFB2A9BC14ABAED9384706B037305D07C2C04A563EB30B9F601FAE7EC4A498__TabColorMap
	{
		// Token: 0x06036735 RID: 223029 RVA: 0x00CE46F7 File Offset: 0x00CE28F7
		[NullableContext(1)]
		public static string GetColor(ERogueResTrialType type)
		{
			if (type == ERogueResTrialType.Static)
			{
				return "#323232";
			}
			if (type == ERogueResTrialType.Dynamic)
			{
				return "#ab9664";
			}
			return "#323232";
		}
	}
}
