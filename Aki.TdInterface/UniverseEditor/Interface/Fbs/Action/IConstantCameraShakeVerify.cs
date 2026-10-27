using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020064C7 RID: 25799
	public static class IConstantCameraShakeVerify
	{
		// Token: 0x0602CBFD RID: 183293 RVA: 0x00626A1E File Offset: 0x00624C1E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
