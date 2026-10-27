using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020067FA RID: 26618
	public static class IFlowDefineNpcCancelMotorcycleSharingPerformVerify
	{
		// Token: 0x0602E59A RID: 189850 RVA: 0x00653A1B File Offset: 0x00651C1B
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 6, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
