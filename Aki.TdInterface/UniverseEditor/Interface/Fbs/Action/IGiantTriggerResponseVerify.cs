using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006893 RID: 26771
	public static class IGiantTriggerResponseVerify
	{
		// Token: 0x0602EB0B RID: 191243 RVA: 0x0065DB49 File Offset: 0x0065BD49
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyVectorOfData(tablePos, 4, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
