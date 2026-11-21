using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020073D2 RID: 29650
	public static class IPathLineFacingTypeVerify
	{
		// Token: 0x06033DC9 RID: 212425 RVA: 0x006FE676 File Offset: 0x006FC876
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
