using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003D33 RID: 15667
	public static class IBindingProgressTypeVerify
	{
		// Token: 0x06015A3A RID: 88634 RVA: 0x0031F98A File Offset: 0x0031DB8A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
