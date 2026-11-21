using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003F5A RID: 16218
	public static class TParamsPresetVerify
	{
		// Token: 0x06016104 RID: 90372 RVA: 0x0032AC98 File Offset: 0x00328E98
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IDecalParamsVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IEnergyFishParamsVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IFireBoxLampParamsVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IFishParamsVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = ILightPlateParamsVerify.Verify(verifier, tablePos);
				break;
			case 6:
				result = IRushWarningEffectParamsVerify.Verify(verifier, tablePos);
				break;
			case 7:
				result = IScoreDisplayMaterialParamsVerify.Verify(verifier, tablePos);
				break;
			case 8:
				result = ITimeDisplayMaterialParamsVerify.Verify(verifier, tablePos);
				break;
			case 9:
				result = IWoodenBoxProliferateParamsVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
