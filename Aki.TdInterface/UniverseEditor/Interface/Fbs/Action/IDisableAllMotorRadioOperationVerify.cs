using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C3A RID: 27706
	public static class IDisableAllMotorRadioOperationVerify
	{
		// Token: 0x0602FACD RID: 195277 RVA: 0x0067E656 File Offset: 0x0067C856
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
