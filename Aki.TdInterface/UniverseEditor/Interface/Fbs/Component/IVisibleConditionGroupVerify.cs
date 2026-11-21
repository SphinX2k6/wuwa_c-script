using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006150 RID: 24912
	public static class IVisibleConditionGroupVerify
	{
		// Token: 0x0602A46D RID: 173165 RVA: 0x005C4C61 File Offset: 0x005C2E61
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyVectorOfData(tablePos, 4, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
