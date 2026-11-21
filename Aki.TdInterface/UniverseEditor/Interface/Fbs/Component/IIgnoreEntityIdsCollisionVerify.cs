using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200596B RID: 22891
	public static class IIgnoreEntityIdsCollisionVerify
	{
		// Token: 0x060254FE RID: 152830 RVA: 0x0051F319 File Offset: 0x0051D519
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyVectorOfData(tablePos, 4, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
