using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E89 RID: 28297
	public static class IFlowDefineNpcHandInHandPerformVerify
	{
		// Token: 0x06030E4F RID: 200271 RVA: 0x006A1D57 File Offset: 0x0069FF57
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 6, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
