using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020071F4 RID: 29172
	public static class IModifyMaterialConfigVerify
	{
		// Token: 0x06032C07 RID: 207879 RVA: 0x006DB07E File Offset: 0x006D927E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
