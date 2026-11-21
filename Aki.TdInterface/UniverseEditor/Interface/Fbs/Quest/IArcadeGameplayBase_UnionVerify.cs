using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200411D RID: 16669
	public static class IArcadeGameplayBase_UnionVerify
	{
		// Token: 0x06016DFA RID: 93690 RVA: 0x003442AC File Offset: 0x003424AC
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
