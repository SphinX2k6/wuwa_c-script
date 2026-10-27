using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200562B RID: 22059
	public static class INpcModelConfigVerify
	{
		// Token: 0x06024A0A RID: 150026 RVA: 0x0050D94E File Offset: 0x0050BB4E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
