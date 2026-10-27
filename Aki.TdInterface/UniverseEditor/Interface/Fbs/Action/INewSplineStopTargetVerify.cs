using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006BA2 RID: 27554
	public static class INewSplineStopTargetVerify
	{
		// Token: 0x06030654 RID: 198228 RVA: 0x00692C56 File Offset: 0x00690E56
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
