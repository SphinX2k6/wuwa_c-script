using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B8F RID: 27535
	public static class ICutCameraTimeParamsVerify
	{
		// Token: 0x0602F62E RID: 194094 RVA: 0x00677282 File Offset: 0x00675482
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
