using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003D6C RID: 15724
	public static class ICheckSpringFestivalGameplayType_UnionVerify
	{
		// Token: 0x06015C24 RID: 89124 RVA: 0x003233E0 File Offset: 0x003215E0
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
