using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004718 RID: 18200
	public static class TCheckSpringFestivalGameplayTypeVerify
	{
		// Token: 0x0601AC74 RID: 109684 RVA: 0x003CD974 File Offset: 0x003CBB74
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
