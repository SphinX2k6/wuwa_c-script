using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004711 RID: 18193
	public static class TArcadeGameplayVerify
	{
		// Token: 0x0601AC44 RID: 109636 RVA: 0x003CD458 File Offset: 0x003CB658
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IArcadeGameplayTetrisBoardGameVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IArcadeGameplayDropCatchVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
