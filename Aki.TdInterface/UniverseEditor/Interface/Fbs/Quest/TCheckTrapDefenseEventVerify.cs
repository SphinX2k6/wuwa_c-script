using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020042BF RID: 17087
	public static class TCheckTrapDefenseEventVerify
	{
		// Token: 0x06019514 RID: 103700 RVA: 0x003A2398 File Offset: 0x003A0598
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || ICheckTrapDefenseEventMonsterKilledVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = ICheckTrapDefenseBdBuffQualityUpVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
