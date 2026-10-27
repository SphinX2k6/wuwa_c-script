using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005943 RID: 22851
	public static class ISpawnConfigTypeVerify
	{
		// Token: 0x06026AB5 RID: 158389 RVA: 0x005534AA File Offset: 0x005516AA
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
