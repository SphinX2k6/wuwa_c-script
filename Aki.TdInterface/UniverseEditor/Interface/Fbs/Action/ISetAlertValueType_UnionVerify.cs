using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F9B RID: 28571
	public static class ISetAlertValueType_UnionVerify
	{
		// Token: 0x060327E2 RID: 206818 RVA: 0x006D0B54 File Offset: 0x006CED54
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
