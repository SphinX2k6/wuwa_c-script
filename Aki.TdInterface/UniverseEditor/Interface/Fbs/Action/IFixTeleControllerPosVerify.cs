using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020067DF RID: 26591
	public static class IFixTeleControllerPosVerify
	{
		// Token: 0x0602E4AC RID: 189612 RVA: 0x00652182 File Offset: 0x00650382
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
