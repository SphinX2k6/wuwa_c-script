using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B60 RID: 23392
	public static class IMotorInteractConstraintTypeVerify
	{
		// Token: 0x060267FB RID: 157691 RVA: 0x00545976 File Offset: 0x00543B76
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
