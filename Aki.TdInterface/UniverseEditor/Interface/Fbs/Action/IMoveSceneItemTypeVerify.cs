using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200729F RID: 29343
	public static class IMoveSceneItemTypeVerify
	{
		// Token: 0x06033229 RID: 209449 RVA: 0x006E6536 File Offset: 0x006E4736
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
