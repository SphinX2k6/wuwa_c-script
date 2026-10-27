using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020076A9 RID: 30377
	public static class TDisableAlertConditionVerify
	{
		// Token: 0x06037445 RID: 226373 RVA: 0x0077D4C8 File Offset: 0x0077B6C8
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
