using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007057 RID: 28759
	public static class IInteractPointInteractionVerify
	{
		// Token: 0x06031DE8 RID: 204264 RVA: 0x006C036E File Offset: 0x006BE56E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
