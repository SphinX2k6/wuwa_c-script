using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004183 RID: 16771
	public static class ICheckSpringFestivalGameplayType_UnionVerify
	{
		// Token: 0x0601715C RID: 94556 RVA: 0x0034A658 File Offset: 0x00348858
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ICheckSpringFestivalGameplayTypeVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = ICheckSpringFestivalMixDrinksCompletedVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = ICheckSpringFestivalGuessJokerCompletedVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
