using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020066E7 RID: 26343
	public static class IActionParamsVerify
	{
		// Token: 0x0602C464 RID: 181348 RVA: 0x0060715E File Offset: 0x0060535E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
