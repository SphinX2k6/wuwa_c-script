using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020068FC RID: 26876
	public static class IHideSpecificEntitiesVerify
	{
		// Token: 0x0602EE2E RID: 192046 RVA: 0x006653C9 File Offset: 0x006635C9
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyVectorOfData(tablePos, 4, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
