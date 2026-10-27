using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007785 RID: 30597
	public static class TSetNpcGroupPerformTypeVerify
	{
		// Token: 0x060378DB RID: 227547 RVA: 0x0078452C File Offset: 0x0078272C
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ISetNpcHandInHandPerformVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = ISetNpcHighFivePerformVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = ISetNpcHuggingBearPerformVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = ISetNpcSupportedWalkingPerformVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = ISetNpcTwoPersonPerformVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
