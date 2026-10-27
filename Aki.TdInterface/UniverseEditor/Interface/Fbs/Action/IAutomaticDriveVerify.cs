using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020061BD RID: 25021
	public static class IAutomaticDriveVerify
	{
		// Token: 0x0602B1CF RID: 176591 RVA: 0x005F1AB2 File Offset: 0x005EFCB2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
