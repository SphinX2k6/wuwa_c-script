using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006EB3 RID: 28339
	public static class IFlowTemplateTransitionEffectVerify
	{
		// Token: 0x0603106E RID: 200814 RVA: 0x006A63EA File Offset: 0x006A45EA
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
