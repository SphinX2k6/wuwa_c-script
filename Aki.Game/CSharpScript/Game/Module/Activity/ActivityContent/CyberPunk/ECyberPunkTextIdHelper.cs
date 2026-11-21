using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.CyberPunk
{
	// Token: 0x0200580A RID: 22538
	public static class ECyberPunkTextIdHelper
	{
		// Token: 0x060379AF RID: 227759 RVA: 0x00F8A908 File Offset: 0x00F88B08
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
