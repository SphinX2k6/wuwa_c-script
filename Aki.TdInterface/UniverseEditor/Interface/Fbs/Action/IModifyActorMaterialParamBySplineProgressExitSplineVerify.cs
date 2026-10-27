using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006AB7 RID: 27319
	public static class IModifyActorMaterialParamBySplineProgressExitSplineVerify
	{
		// Token: 0x0602FE05 RID: 196101 RVA: 0x00683380 File Offset: 0x00681580
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
