using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020067EE RID: 26606
	public static class IFlowActionContextVerify
	{
		// Token: 0x0602E528 RID: 189736 RVA: 0x00652DBD File Offset: 0x00650FBD
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
