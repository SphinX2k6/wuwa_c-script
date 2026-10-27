using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x0200483D RID: 18493
	public static class IComponentFieldModificationVerify
	{
		// Token: 0x0601C978 RID: 117112 RVA: 0x0040AB44 File Offset: 0x00408D44
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 8, false) && verifier.VerifyString(tablePos, 10, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
