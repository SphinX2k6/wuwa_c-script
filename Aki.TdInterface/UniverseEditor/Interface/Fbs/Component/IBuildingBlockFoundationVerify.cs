using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005468 RID: 21608
	public static class IBuildingBlockFoundationVerify
	{
		// Token: 0x06021F06 RID: 139014 RVA: 0x004AD756 File Offset: 0x004AB956
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
