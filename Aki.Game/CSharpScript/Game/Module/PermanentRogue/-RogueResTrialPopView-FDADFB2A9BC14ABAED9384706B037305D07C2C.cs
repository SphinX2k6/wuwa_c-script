using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PermanentRogue
{
	// Token: 0x02004307 RID: 17159
	internal static class <RogueResTrialPopView>FDADFB2A9BC14ABAED9384706B037305D07C2C04A563EB30B9F601FAE7EC4A498__TabColorMap
	{
		// Token: 0x0602B631 RID: 177713 RVA: 0x00C320C7 File Offset: 0x00C302C7
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
