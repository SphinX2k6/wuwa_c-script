using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020071DA RID: 29146
	public static class IStopMotorCruiseVerify
	{
		// Token: 0x06033B2B RID: 211755 RVA: 0x006F5E7A File Offset: 0x006F407A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
