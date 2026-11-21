using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006CBB RID: 27835
	public static class IEnableAllMotorRadioOperationVerify
	{
		// Token: 0x0602FF99 RID: 196505 RVA: 0x006878CA File Offset: 0x00685ACA
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
