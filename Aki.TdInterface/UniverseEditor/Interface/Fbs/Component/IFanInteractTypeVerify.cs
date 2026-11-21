using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020057A1 RID: 22433
	public static class IFanInteractTypeVerify
	{
		// Token: 0x0602435E RID: 148318 RVA: 0x004FA642 File Offset: 0x004F8842
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
