using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020054CF RID: 21711
	public static class ILevelAiCycleModeTypeVerify
	{
		// Token: 0x06023C83 RID: 146563 RVA: 0x004F24C2 File Offset: 0x004F06C2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
