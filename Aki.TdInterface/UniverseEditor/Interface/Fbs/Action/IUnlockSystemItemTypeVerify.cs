using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007CD9 RID: 31961
	public static class IUnlockSystemItemTypeVerify
	{
		// Token: 0x06039A76 RID: 236150 RVA: 0x007C726E File Offset: 0x007C546E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
