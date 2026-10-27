using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020064E8 RID: 25832
	public static class ICreatePrefabConfigVerify
	{
		// Token: 0x0602CD00 RID: 183552 RVA: 0x006286BA File Offset: 0x006268BA
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
