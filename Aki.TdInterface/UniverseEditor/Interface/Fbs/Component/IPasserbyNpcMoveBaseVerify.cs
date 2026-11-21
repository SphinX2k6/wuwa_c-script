using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C95 RID: 23701
	public static class IPasserbyNpcMoveBaseVerify
	{
		// Token: 0x06027506 RID: 161030 RVA: 0x00561FDE File Offset: 0x005601DE
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
