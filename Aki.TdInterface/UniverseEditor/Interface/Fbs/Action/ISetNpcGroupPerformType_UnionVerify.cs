using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020077FF RID: 30719
	public static class ISetNpcGroupPerformType_UnionVerify
	{
		// Token: 0x06035F7E RID: 221054 RVA: 0x0073AA00 File Offset: 0x00738C00
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ISetNpcGroupPerformTypeVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = ISetNpcHandInHandPerformVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = ISetNpcHighFivePerformVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = ISetNpcHuggingBearPerformVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = ISetNpcTwoPersonPerformVerify.Verify(verifier, tablePos);
				break;
			case 6:
				result = ISetNpcSupportedWalkingPerformVerify.Verify(verifier, tablePos);
				break;
			case 7:
				result = ISetNpcSequencePerformVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
