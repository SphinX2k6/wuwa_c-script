using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007667 RID: 30311
	public static class TChangeTimerVerify
	{
		// Token: 0x060372CB RID: 225995 RVA: 0x0077ACA8 File Offset: 0x00778EA8
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
