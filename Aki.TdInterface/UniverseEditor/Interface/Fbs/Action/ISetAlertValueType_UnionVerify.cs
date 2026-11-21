using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007761 RID: 30561
	public static class ISetAlertValueType_UnionVerify
	{
		// Token: 0x06035A32 RID: 219698 RVA: 0x0073050C File Offset: 0x0072E70C
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ISetAlertValueTypeVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IAddOrSubAlertValueVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = ICustomAlertValueVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IMinAlertValueVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = IMaxAlertValueVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
