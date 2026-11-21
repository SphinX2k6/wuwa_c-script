using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B32 RID: 27442
	public static class IConstantCameraShakeVerify
	{
		// Token: 0x0602F381 RID: 193409 RVA: 0x00672B46 File Offset: 0x00670D46
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
