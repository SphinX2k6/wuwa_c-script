using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007E75 RID: 32373
	public static class TChangeTimerVerify
	{
		// Token: 0x0603A770 RID: 239472 RVA: 0x007DEDA4 File Offset: 0x007DCFA4
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IAddTimeVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IReduceTimeVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = ISetTimeVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
