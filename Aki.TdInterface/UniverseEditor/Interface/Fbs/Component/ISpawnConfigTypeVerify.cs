using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005F50 RID: 24400
	public static class ISpawnConfigTypeVerify
	{
		// Token: 0x0602901F RID: 167967 RVA: 0x0059A116 File Offset: 0x00598316
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
