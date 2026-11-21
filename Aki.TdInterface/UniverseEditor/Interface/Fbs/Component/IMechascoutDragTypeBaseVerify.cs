using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005AB8 RID: 23224
	public static class IMechascoutDragTypeBaseVerify
	{
		// Token: 0x06026154 RID: 155988 RVA: 0x00537B36 File Offset: 0x00535D36
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
