using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020042BC RID: 17084
	public static class TCheckSpringFestivalGameplayTypeVerify
	{
		// Token: 0x06019508 RID: 103688 RVA: 0x003A229C File Offset: 0x003A049C
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || ICheckSpringFestivalMixDrinksCompletedVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = ICheckSpringFestivalGuessJokerCompletedVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
