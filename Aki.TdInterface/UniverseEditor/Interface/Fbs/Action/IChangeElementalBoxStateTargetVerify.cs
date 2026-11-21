using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200694B RID: 26955
	public static class IChangeElementalBoxStateTargetVerify
	{
		// Token: 0x0602E34B RID: 189259 RVA: 0x0064FC22 File Offset: 0x0064DE22
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
