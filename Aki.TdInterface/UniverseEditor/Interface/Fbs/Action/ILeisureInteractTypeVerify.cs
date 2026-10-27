using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020069E6 RID: 27110
	public static class ILeisureInteractTypeVerify
	{
		// Token: 0x0602F67A RID: 194170 RVA: 0x00675136 File Offset: 0x00673336
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
