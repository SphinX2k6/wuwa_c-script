using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020072D3 RID: 29395
	public static class IMpcEffectParamBaseVerify
	{
		// Token: 0x0603340A RID: 209930 RVA: 0x006EA106 File Offset: 0x006E8306
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
