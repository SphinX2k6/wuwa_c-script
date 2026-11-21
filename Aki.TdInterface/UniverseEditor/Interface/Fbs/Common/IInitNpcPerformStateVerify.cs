using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02006445 RID: 25669
	public static class IInitNpcPerformStateVerify
	{
		// Token: 0x0602B9D5 RID: 178645 RVA: 0x005EFDB2 File Offset: 0x005EDFB2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false) && verifier.VerifyString(tablePos, 6, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
