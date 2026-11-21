using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B9E RID: 27550
	public static class IDangoAbyssGotoNextFloorVerify
	{
		// Token: 0x0602F6AB RID: 194219 RVA: 0x0067811A File Offset: 0x0067631A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
