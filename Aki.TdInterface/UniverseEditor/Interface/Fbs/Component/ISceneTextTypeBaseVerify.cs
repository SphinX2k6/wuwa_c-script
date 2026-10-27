using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020058ED RID: 22765
	public static class ISceneTextTypeBaseVerify
	{
		// Token: 0x0602673B RID: 157499 RVA: 0x0054C672 File Offset: 0x0054A872
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
