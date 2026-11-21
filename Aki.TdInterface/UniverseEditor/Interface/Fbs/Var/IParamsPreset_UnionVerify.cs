using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003EB2 RID: 16050
	public static class IParamsPreset_UnionVerify
	{
		// Token: 0x06015B55 RID: 88917 RVA: 0x00320100 File Offset: 0x0031E300
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IParamsPresetVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IDecalParamsVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IRushWarningEffectParamsVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = ITimeDisplayMaterialParamsVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = IScoreDisplayMaterialParamsVerify.Verify(verifier, tablePos);
				break;
			case 6:
				result = ILightPlateParamsVerify.Verify(verifier, tablePos);
				break;
			case 7:
				result = IFireBoxLampParamsVerify.Verify(verifier, tablePos);
				break;
			case 8:
				result = IWoodenBoxProliferateParamsVerify.Verify(verifier, tablePos);
				break;
			case 9:
				result = IFishParamsVerify.Verify(verifier, tablePos);
				break;
			case 10:
				result = IEnergyFishParamsVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
