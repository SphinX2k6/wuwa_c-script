using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D12 RID: 27922
	public static class IEnableTakePhotoClipVerify
	{
		// Token: 0x06030285 RID: 197253 RVA: 0x0068C8DA File Offset: 0x0068AADA
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
