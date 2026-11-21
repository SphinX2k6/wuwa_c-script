using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200614A RID: 24906
	public static class IViewDistanceModeVerify
	{
		// Token: 0x0602A439 RID: 173113 RVA: 0x005C43EA File Offset: 0x005C25EA
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
