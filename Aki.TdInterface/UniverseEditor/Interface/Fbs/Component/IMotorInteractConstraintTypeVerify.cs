using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020055C2 RID: 21954
	public static class IMotorInteractConstraintTypeVerify
	{
		// Token: 0x060245EE RID: 148974 RVA: 0x005053FE File Offset: 0x005035FE
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
