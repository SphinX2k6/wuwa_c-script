using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200775E RID: 30558
	public static class ISetAlertValueTypeVerify
	{
		// Token: 0x06035A20 RID: 219680 RVA: 0x00730382 File Offset: 0x0072E582
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
