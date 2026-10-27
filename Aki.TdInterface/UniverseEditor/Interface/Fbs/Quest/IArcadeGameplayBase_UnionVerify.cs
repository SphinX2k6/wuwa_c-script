using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003D06 RID: 15622
	public static class IArcadeGameplayBase_UnionVerify
	{
		// Token: 0x060158C2 RID: 88258 RVA: 0x0031D034 File Offset: 0x0031B234
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IArcadeGameplayBaseVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IArcadeGameplayDropCatchVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IArcadeGameplayTetrisBoardGameVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
