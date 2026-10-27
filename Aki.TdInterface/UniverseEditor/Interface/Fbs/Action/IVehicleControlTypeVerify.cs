using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020074FB RID: 29947
	public static class IVehicleControlTypeVerify
	{
		// Token: 0x06036748 RID: 223048 RVA: 0x00765CE6 File Offset: 0x00763EE6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
