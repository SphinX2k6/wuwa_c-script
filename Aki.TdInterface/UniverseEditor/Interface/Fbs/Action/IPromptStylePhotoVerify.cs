using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006DD6 RID: 28118
	public static class IPromptStylePhotoVerify
	{
		// Token: 0x06031AA4 RID: 203428 RVA: 0x006BA2D6 File Offset: 0x006B84D6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
