using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006746 RID: 26438
	public static class IFaceExpressionAnimSequenceConfigVerify
	{
		// Token: 0x0602DFC4 RID: 188356 RVA: 0x00648E17 File Offset: 0x00647017
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 6, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
