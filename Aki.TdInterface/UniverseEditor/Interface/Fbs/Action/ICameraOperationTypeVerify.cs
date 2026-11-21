using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006906 RID: 26886
	public static class ICameraOperationTypeVerify
	{
		// Token: 0x0602E0F5 RID: 188661 RVA: 0x0064B682 File Offset: 0x00649882
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
