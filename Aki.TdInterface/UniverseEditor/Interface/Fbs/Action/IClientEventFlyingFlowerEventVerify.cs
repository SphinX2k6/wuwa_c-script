using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A0A RID: 27146
	public static class IClientEventFlyingFlowerEventVerify
	{
		// Token: 0x0602E932 RID: 190770 RVA: 0x0065A26E File Offset: 0x0065846E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
