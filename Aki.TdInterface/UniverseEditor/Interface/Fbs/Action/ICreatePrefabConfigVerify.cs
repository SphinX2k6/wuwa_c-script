using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B53 RID: 27475
	public static class ICreatePrefabConfigVerify
	{
		// Token: 0x0602F484 RID: 193668 RVA: 0x006747E2 File Offset: 0x006729E2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
