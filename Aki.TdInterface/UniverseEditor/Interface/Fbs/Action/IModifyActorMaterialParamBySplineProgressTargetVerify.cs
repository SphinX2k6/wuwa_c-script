using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020071E5 RID: 29157
	public static class IModifyActorMaterialParamBySplineProgressTargetVerify
	{
		// Token: 0x06032B93 RID: 207763 RVA: 0x006DA16E File Offset: 0x006D836E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
