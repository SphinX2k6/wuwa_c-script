using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006993 RID: 27027
	public static class IChangeSelfEntityStateVerify
	{
		// Token: 0x0602E5C5 RID: 189893 RVA: 0x00654049 File Offset: 0x00652249
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
