using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B98 RID: 27544
	public static class IDangoAbyssActivatePortalVerify
	{
		// Token: 0x0602F691 RID: 194193 RVA: 0x00677F4A File Offset: 0x0067614A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
