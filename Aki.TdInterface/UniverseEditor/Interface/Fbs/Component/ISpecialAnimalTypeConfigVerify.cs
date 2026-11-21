using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005F7A RID: 24442
	public static class ISpecialAnimalTypeConfigVerify
	{
		// Token: 0x0602917E RID: 168318 RVA: 0x0059CB0E File Offset: 0x0059AD0E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
