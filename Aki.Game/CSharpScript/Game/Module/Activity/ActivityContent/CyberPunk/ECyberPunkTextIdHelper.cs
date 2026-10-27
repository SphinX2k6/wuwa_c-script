using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.CyberPunk
{
	// Token: 0x020068BA RID: 26810
	public static class ECyberPunkTextIdHelper
	{
		// Token: 0x06042E57 RID: 274007 RVA: 0x010492E0 File Offset: 0x010474E0
		[NullableContext(1)]
		public static string ToTextId(ECyberPunkTextId textId)
		{
			string result;
			if (textId != ECyberPunkTextId.REWARD)
			{
				if (textId != ECyberPunkTextId.QUESTFINISH)
				{
					result = string.Empty;
				}
				else
				{
					result = "Edgerunners_QuestFinish";
				}
			}
			else
			{
				result = "Cyberpunk_Reward";
			}
			return result;
		}
	}
}
