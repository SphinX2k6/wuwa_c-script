using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006094 RID: 24724
	public static class IActivateResetPointVerify
	{
		// Token: 0x0602A332 RID: 172850 RVA: 0x005D18EA File Offset: 0x005CFAEA
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
