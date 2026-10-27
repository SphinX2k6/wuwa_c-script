using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006AAE RID: 27310
	public static class IModifyActorMaterialParamBySplineProgressConfigVerify
	{
		// Token: 0x0602FDC1 RID: 196033 RVA: 0x00682C00 File Offset: 0x00680E00
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
