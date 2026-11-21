using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020068F7 RID: 26871
	public static class ICameraLockTargetBaseVerify
	{
		// Token: 0x0602E041 RID: 188481 RVA: 0x00649F96 File Offset: 0x00648196
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
