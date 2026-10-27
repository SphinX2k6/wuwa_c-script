using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020056C7 RID: 22215
	public static class IPasserbyNpcMoveBaseVerify
	{
		// Token: 0x060251C3 RID: 152003 RVA: 0x0051FA26 File Offset: 0x0051DC26
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
