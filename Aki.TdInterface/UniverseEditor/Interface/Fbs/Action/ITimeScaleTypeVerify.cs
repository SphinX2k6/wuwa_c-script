using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020073E7 RID: 29671
	public static class ITimeScaleTypeVerify
	{
		// Token: 0x06035E68 RID: 220776 RVA: 0x00755E7A File Offset: 0x0075407A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
