using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007213 RID: 29203
	public static class ISubScreenModeConfigVerify
	{
		// Token: 0x06033CC9 RID: 212169 RVA: 0x006F8A12 File Offset: 0x006F6C12
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
