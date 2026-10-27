using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006322 RID: 25378
	public static class IChangeSelfEntityStateVerify
	{
		// Token: 0x0602BE5C RID: 179804 RVA: 0x0060903D File Offset: 0x0060723D
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
