using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007EC0 RID: 32448
	public static class TEnableFunctionRestrictionVerify
	{
		// Token: 0x0603A91C RID: 239900 RVA: 0x007E1A90 File Offset: 0x007DFC90
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IInteractiveItemsFunctionVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IMotorRadioUiFunctionVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = ITeleportDungeonFunctionVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
