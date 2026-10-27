using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B20 RID: 27424
	public static class IMotorParamsChangeConfigVerify
	{
		// Token: 0x0603022D RID: 197165 RVA: 0x0068B022 File Offset: 0x00689222
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
