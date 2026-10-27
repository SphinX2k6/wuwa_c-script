using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.GameStatusDefine
{
	// Token: 0x02004717 RID: 18199
	public static class Record_Int_IntVerify
	{
		// Token: 0x0601BF12 RID: 114450 RVA: 0x003F5F0C File Offset: 0x003F410C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
