using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E2C RID: 28204
	public static class IFinishStateVerify
	{
		// Token: 0x06030B36 RID: 199478 RVA: 0x0069C196 File Offset: 0x0069A396
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
