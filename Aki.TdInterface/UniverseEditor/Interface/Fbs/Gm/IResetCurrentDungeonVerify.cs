using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004AEE RID: 19182
	public static class IResetCurrentDungeonVerify
	{
		// Token: 0x0601CE65 RID: 118373 RVA: 0x0041138E File Offset: 0x0040F58E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
