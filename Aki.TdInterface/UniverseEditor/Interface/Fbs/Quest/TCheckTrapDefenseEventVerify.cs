using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200471B RID: 18203
	public static class TCheckTrapDefenseEventVerify
	{
		// Token: 0x0601AC80 RID: 109696 RVA: 0x003CDA70 File Offset: 0x003CBC70
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
