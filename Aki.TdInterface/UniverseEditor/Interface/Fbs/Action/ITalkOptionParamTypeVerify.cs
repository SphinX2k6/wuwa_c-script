using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007333 RID: 29491
	public static class ITalkOptionParamTypeVerify
	{
		// Token: 0x0603584F RID: 219215 RVA: 0x0074A702 File Offset: 0x00748902
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
