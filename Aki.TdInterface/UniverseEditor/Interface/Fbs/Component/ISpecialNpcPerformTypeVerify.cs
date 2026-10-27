using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005973 RID: 22899
	public static class ISpecialNpcPerformTypeVerify
	{
		// Token: 0x06026C32 RID: 158770 RVA: 0x00556116 File Offset: 0x00554316
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
