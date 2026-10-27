using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004297 RID: 17047
	public static class IWarningPreformTypeVerify
	{
		// Token: 0x06019426 RID: 103462 RVA: 0x003A0CAE File Offset: 0x0039EEAE
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
