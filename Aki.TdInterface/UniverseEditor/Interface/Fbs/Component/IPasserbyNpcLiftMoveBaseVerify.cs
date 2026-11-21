using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C8C RID: 23692
	public static class IPasserbyNpcLiftMoveBaseVerify
	{
		// Token: 0x060274D2 RID: 160978 RVA: 0x00561ADE File Offset: 0x0055FCDE
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
