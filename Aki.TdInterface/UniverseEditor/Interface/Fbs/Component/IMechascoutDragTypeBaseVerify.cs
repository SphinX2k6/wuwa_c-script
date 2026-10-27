using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005532 RID: 21810
	public static class IMechascoutDragTypeBaseVerify
	{
		// Token: 0x0602409A RID: 147610 RVA: 0x004FAA12 File Offset: 0x004F8C12
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
