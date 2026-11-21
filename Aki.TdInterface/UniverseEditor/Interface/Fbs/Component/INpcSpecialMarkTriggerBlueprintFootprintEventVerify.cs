using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005BF9 RID: 23545
	public static class INpcSpecialMarkTriggerBlueprintFootprintEventVerify
	{
		// Token: 0x06026E21 RID: 159265 RVA: 0x005528B7 File Offset: 0x00550AB7
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 6, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
