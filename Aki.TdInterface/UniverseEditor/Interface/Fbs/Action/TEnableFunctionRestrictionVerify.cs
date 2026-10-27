using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020076B5 RID: 30389
	public static class TEnableFunctionRestrictionVerify
	{
		// Token: 0x06037479 RID: 226425 RVA: 0x0077D93C File Offset: 0x0077BB3C
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
