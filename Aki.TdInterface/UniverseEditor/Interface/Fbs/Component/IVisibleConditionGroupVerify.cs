using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B3A RID: 23354
	public static class IVisibleConditionGroupVerify
	{
		// Token: 0x06027EA9 RID: 163497 RVA: 0x0057D1D1 File Offset: 0x0057B3D1
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyVectorOfData(tablePos, 4, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
