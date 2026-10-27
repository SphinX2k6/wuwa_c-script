using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200724C RID: 29260
	public static class ISwingGetUpVerify
	{
		// Token: 0x06033E5D RID: 212573 RVA: 0x006FB282 File Offset: 0x006F9482
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
