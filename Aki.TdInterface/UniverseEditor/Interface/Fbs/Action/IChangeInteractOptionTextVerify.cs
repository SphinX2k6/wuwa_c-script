using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006975 RID: 26997
	public static class IChangeInteractOptionTextVerify
	{
		// Token: 0x0602E4B3 RID: 189619 RVA: 0x0065221D File Offset: 0x0065041D
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
