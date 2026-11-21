using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005D5A RID: 23898
	public static class IPointChooseTypeVerify
	{
		// Token: 0x06027C8A RID: 162954 RVA: 0x00571602 File Offset: 0x0056F802
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
