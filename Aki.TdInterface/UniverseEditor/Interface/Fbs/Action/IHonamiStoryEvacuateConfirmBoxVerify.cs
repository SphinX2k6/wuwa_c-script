using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006923 RID: 26915
	public static class IHonamiStoryEvacuateConfirmBoxVerify
	{
		// Token: 0x0602EFC4 RID: 192452 RVA: 0x0066807A File Offset: 0x0066627A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
