using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007036 RID: 28726
	public static class ISetNpcGroupPerformType_UnionVerify
	{
		// Token: 0x06032D15 RID: 208149 RVA: 0x006DAD30 File Offset: 0x006D8F30
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
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
