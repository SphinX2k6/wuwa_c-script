using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B50 RID: 27472
	public static class IMoveOperationTypeVerify
	{
		// Token: 0x0603038A RID: 197514 RVA: 0x0068D6CE File Offset: 0x0068B8CE
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
