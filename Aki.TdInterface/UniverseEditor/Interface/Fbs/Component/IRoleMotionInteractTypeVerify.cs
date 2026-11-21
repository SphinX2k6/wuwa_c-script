using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005E8B RID: 24203
	public static class IRoleMotionInteractTypeVerify
	{
		// Token: 0x06028825 RID: 165925 RVA: 0x00589F5E File Offset: 0x0058815E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
