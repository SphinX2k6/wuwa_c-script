using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007551 RID: 30033
	public static class IPromptStylePhotoVerify
	{
		// Token: 0x06034AA0 RID: 215712 RVA: 0x007159BE File Offset: 0x00713BBE
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
