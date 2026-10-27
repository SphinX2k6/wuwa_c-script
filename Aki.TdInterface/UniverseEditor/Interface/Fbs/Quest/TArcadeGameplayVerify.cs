using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020042B5 RID: 17077
	public static class TArcadeGameplayVerify
	{
		// Token: 0x060194D8 RID: 103640 RVA: 0x003A1D80 File Offset: 0x0039FF80
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
