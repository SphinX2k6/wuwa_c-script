using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005AC1 RID: 23233
	public static class IMechascoutJavelinTriggerConfigVerify
	{
		// Token: 0x06026186 RID: 156038 RVA: 0x00537F6E File Offset: 0x0053616E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
