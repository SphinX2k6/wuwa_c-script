using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020061B4 RID: 25012
	public static class IAudioStateGroupVerify
	{
		// Token: 0x0602B19F RID: 176543 RVA: 0x005F16B0 File Offset: 0x005EF8B0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false) && verifier.VerifyVectorOfStrings(tablePos, 6, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
