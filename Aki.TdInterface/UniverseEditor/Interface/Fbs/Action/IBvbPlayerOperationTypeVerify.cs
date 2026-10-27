using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006250 RID: 25168
	public static class IBvbPlayerOperationTypeVerify
	{
		// Token: 0x0602B67B RID: 177787 RVA: 0x005F9952 File Offset: 0x005F7B52
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
