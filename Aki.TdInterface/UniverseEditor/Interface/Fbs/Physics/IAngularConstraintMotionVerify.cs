using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Physics
{
	// Token: 0x020047A9 RID: 18345
	public static class IAngularConstraintMotionVerify
	{
		// Token: 0x0601B020 RID: 110624 RVA: 0x003D386E File Offset: 0x003D1A6E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
