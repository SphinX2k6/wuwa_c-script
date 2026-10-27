using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020052AE RID: 21166
	public static class IFollowTrackEndTypeVerify
	{
		// Token: 0x06022826 RID: 141350 RVA: 0x004C89E6 File Offset: 0x004C6BE6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
