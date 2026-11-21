using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007FB4 RID: 32692
	public static class TSetAlertValueTypeVerify
	{
		// Token: 0x0603AE2A RID: 241194 RVA: 0x007E9634 File Offset: 0x007E7834
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IAddOrSubAlertValueVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = ICustomAlertValueVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IMaxAlertValueVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IMinAlertValueVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
