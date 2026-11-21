using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E26 RID: 28198
	public static class IFinishDoInteractVerify
	{
		// Token: 0x06030B17 RID: 199447 RVA: 0x0069BF32 File Offset: 0x0069A132
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
