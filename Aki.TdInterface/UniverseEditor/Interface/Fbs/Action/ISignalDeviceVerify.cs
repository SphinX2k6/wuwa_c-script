using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200710E RID: 28942
	public static class ISignalDeviceVerify
	{
		// Token: 0x060334F4 RID: 210164 RVA: 0x006EABEE File Offset: 0x006E8DEE
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyVectorOfData(tablePos, 6, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
