using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F28 RID: 28456
	public static class IGetOffMotorcycleInteractVerify
	{
		// Token: 0x060313F2 RID: 201714 RVA: 0x006AC2B6 File Offset: 0x006AA4B6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
