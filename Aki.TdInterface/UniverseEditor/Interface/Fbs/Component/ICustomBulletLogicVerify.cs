using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020055B8 RID: 21944
	public static class ICustomBulletLogicVerify
	{
		// Token: 0x06022E8C RID: 142988 RVA: 0x004CE78E File Offset: 0x004CC98E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
