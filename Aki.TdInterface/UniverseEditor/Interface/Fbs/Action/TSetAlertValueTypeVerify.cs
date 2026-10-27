using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200777C RID: 30588
	public static class TSetAlertValueTypeVerify
	{
		// Token: 0x060378B1 RID: 227505 RVA: 0x00784174 File Offset: 0x00782374
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
