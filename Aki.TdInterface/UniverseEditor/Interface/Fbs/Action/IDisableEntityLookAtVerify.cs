using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C49 RID: 27721
	public static class IDisableEntityLookAtVerify
	{
		// Token: 0x0602FB71 RID: 195441 RVA: 0x0067F89D File Offset: 0x0067DA9D
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
