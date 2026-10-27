using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006304 RID: 25348
	public static class IChangeInteractOptionTextVerify
	{
		// Token: 0x0602BD4A RID: 179530 RVA: 0x00607211 File Offset: 0x00605411
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
