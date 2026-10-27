using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020058C6 RID: 22726
	public static class ISceneItemInhalationVerify
	{
		// Token: 0x060265A1 RID: 157089 RVA: 0x005490D6 File Offset: 0x005472D6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
