using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x0200646C RID: 25708
	public static class IPhotoTargetCaptureUiBaseVerify
	{
		// Token: 0x0602BAF5 RID: 178933 RVA: 0x005F1EAA File Offset: 0x005F00AA
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
