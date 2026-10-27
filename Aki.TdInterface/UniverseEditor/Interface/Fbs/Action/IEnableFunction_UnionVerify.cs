using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006668 RID: 26216
	public static class IEnableFunction_UnionVerify
	{
		// Token: 0x0602D8AA RID: 186538 RVA: 0x0063C4F4 File Offset: 0x0063A6F4
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IEnableFunctionVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = ITeleportDungeonFunctionVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IMotorRadioUiFunctionVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IInteractiveItemsFunctionVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
