using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020054BD RID: 21693
	public static class ILetGoDestroyConditionVerify
	{
		// Token: 0x06023BF7 RID: 146423 RVA: 0x004F15EE File Offset: 0x004EF7EE
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
