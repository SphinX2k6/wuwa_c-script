using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Physics
{
	// Token: 0x02004347 RID: 17223
	public static class IAngularConstraintMotionVerify
	{
		// Token: 0x06019892 RID: 104594 RVA: 0x003A7E46 File Offset: 0x003A6046
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
