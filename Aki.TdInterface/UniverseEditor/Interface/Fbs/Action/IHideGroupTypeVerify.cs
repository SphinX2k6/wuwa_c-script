using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020068EA RID: 26858
	public static class IHideGroupTypeVerify
	{
		// Token: 0x0602EDAE RID: 191918 RVA: 0x0066477E File Offset: 0x0066297E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
