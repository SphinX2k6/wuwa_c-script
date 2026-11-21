using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020073A5 RID: 29605
	public static class IOpenSystemBoardWithReturnTypeVerify
	{
		// Token: 0x06033C52 RID: 212050 RVA: 0x006FBD32 File Offset: 0x006F9F32
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
