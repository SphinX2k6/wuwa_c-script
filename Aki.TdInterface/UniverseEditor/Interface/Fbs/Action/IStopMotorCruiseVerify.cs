using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020079AF RID: 31151
	public static class IStopMotorCruiseVerify
	{
		// Token: 0x06036E2D RID: 224813 RVA: 0x007571DA File Offset: 0x007553DA
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
