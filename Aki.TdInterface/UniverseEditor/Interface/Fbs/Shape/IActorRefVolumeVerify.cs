using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02003BEB RID: 15339
	public static class IActorRefVolumeVerify
	{
		// Token: 0x06015178 RID: 86392 RVA: 0x0030E6AA File Offset: 0x0030C8AA
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
