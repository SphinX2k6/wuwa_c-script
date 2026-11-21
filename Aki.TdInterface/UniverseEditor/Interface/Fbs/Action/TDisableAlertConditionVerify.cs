using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007EB4 RID: 32436
	public static class TDisableAlertConditionVerify
	{
		// Token: 0x0603A8E8 RID: 239848 RVA: 0x007E161C File Offset: 0x007DF81C
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IDisableAlertAreaQuestConditionVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IDisableAlertAreaDungeonConditionVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
