using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020065DB RID: 26075
	public static class IDisableCameraOperationVerify
	{
		// Token: 0x0602D397 RID: 185239 RVA: 0x00632CCE File Offset: 0x00630ECE
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
