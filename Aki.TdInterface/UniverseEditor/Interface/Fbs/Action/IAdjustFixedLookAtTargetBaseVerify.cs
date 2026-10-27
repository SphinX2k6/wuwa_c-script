using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200615A RID: 24922
	public static class IAdjustFixedLookAtTargetBaseVerify
	{
		// Token: 0x0602ACF9 RID: 175353 RVA: 0x005E6FA6 File Offset: 0x005E51A6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
