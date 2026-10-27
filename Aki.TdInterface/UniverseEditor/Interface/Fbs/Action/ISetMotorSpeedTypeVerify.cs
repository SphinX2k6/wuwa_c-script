using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007027 RID: 28711
	public static class ISetMotorSpeedTypeVerify
	{
		// Token: 0x06032CAA RID: 208042 RVA: 0x006DA18A File Offset: 0x006D838A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
