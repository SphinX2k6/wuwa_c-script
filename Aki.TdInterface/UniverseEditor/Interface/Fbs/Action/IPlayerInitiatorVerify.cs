using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006CF8 RID: 27896
	public static class IPlayerInitiatorVerify
	{
		// Token: 0x0603130A RID: 201482 RVA: 0x006AC5BE File Offset: 0x006AA7BE
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
