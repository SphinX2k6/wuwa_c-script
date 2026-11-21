using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E8F RID: 28303
	public static class IFlowDefineNpcSupportedWalkingPerformVerify
	{
		// Token: 0x06030E7F RID: 200319 RVA: 0x006A21BF File Offset: 0x006A03BF
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 6, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
