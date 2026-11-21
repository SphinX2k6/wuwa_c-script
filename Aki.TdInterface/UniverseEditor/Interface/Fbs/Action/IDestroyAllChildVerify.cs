using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006BE9 RID: 27625
	public static class IDestroyAllChildVerify
	{
		// Token: 0x0602F8BA RID: 194746 RVA: 0x0067B386 File Offset: 0x00679586
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
