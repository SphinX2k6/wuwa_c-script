using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E83 RID: 28291
	public static class IFlowDefineNpcGroupPerformTypeVerify
	{
		// Token: 0x06030E23 RID: 200227 RVA: 0x006A191E File Offset: 0x0069FB1E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
