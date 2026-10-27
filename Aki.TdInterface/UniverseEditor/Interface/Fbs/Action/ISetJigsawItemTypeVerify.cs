using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007015 RID: 28693
	public static class ISetJigsawItemTypeVerify
	{
		// Token: 0x06032C02 RID: 207874 RVA: 0x006D8D02 File Offset: 0x006D6F02
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
