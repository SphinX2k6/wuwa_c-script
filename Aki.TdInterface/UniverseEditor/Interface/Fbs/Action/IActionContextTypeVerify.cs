using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020066D8 RID: 26328
	public static class IActionContextTypeVerify
	{
		// Token: 0x0602C3D3 RID: 181203 RVA: 0x00606172 File Offset: 0x00604372
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
