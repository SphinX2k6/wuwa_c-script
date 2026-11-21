using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007FBD RID: 32701
	public static class TSetNpcGroupPerformTypeVerify
	{
		// Token: 0x0603AE56 RID: 241238 RVA: 0x007E9A20 File Offset: 0x007E7C20
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
				result = ISetNpcSequencePerformVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = ISetNpcSupportedWalkingPerformVerify.Verify(verifier, tablePos);
				break;
			case 6:
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
