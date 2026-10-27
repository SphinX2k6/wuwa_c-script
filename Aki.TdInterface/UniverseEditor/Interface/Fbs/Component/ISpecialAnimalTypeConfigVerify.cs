using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200596D RID: 22893
	public static class ISpecialAnimalTypeConfigVerify
	{
		// Token: 0x06026C14 RID: 158740 RVA: 0x00555EA2 File Offset: 0x005540A2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
