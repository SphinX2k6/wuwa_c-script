using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004686 RID: 18054
	public static class IResetCurrentDungeonVerify
	{
		// Token: 0x0601B690 RID: 112272 RVA: 0x003E50F2 File Offset: 0x003E32F2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
