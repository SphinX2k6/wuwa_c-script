using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006CD9 RID: 27865
	public static class IEnableFunction_UnionVerify
	{
		// Token: 0x0603007B RID: 196731 RVA: 0x0068905C File Offset: 0x0068725C
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
