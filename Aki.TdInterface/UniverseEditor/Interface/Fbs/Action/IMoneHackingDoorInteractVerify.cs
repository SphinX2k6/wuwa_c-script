using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006ADB RID: 27355
	public static class IMoneHackingDoorInteractVerify
	{
		// Token: 0x0602FF2F RID: 196399 RVA: 0x00685492 File Offset: 0x00683692
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
