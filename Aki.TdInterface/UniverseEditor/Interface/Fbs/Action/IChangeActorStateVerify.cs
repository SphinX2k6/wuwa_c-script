using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006939 RID: 26937
	public static class IChangeActorStateVerify
	{
		// Token: 0x0602E2B5 RID: 189109 RVA: 0x0064ECCD File Offset: 0x0064CECD
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
