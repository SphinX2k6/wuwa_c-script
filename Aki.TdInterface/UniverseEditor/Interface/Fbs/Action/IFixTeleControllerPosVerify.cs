using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E5F RID: 28255
	public static class IFixTeleControllerPosVerify
	{
		// Token: 0x06030CF2 RID: 199922 RVA: 0x0069F8C6 File Offset: 0x0069DAC6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
