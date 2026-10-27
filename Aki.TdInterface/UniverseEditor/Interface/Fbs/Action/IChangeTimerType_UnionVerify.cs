using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006334 RID: 25396
	public static class IChangeTimerType_UnionVerify
	{
		// Token: 0x0602BEE1 RID: 179937 RVA: 0x00609DA8 File Offset: 0x00607FA8
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IChangeTimerTypeVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IAddTimeVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IReduceTimeVerify.Verify(verifier, tablePos);
				break;
			case 4:
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
