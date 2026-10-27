using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020064DC RID: 25820
	public static class IControlTrackingSelfVerify
	{
		// Token: 0x0602CCA5 RID: 183461 RVA: 0x00627A72 File Offset: 0x00625C72
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
