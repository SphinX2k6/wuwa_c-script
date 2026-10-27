using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020067F7 RID: 26615
	public static class IFlowCameraShakeVerify
	{
		// Token: 0x0602E582 RID: 189826 RVA: 0x006537F9 File Offset: 0x006519F9
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
