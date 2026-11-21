using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E8C RID: 28300
	public static class IFlowDefineNpcMotorcycleSharingPerformVerify
	{
		// Token: 0x06030E67 RID: 200295 RVA: 0x006A1F8B File Offset: 0x006A018B
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 6, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
