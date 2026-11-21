using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003F27 RID: 16167
	public static class IVarValidateConfig_UnionVerify
	{
		// Token: 0x06015F7C RID: 89980 RVA: 0x00328300 File Offset: 0x00326500
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IVarValidateConfigVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IVarIntValidateConfigVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IVarFloatValidateConfigVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IVarStringValidateConfigVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = IVarBooleanValidateConfigVerify.Verify(verifier, tablePos);
				break;
			case 6:
				result = IVarEntityValidateConfigVerify.Verify(verifier, tablePos);
				break;
			case 7:
				result = IVarQuestValidateConfigVerify.Verify(verifier, tablePos);
				break;
			case 8:
				result = IVarQuestStateValidateConfigVerify.Verify(verifier, tablePos);
				break;
			case 9:
				result = IVarTransformValidateConfigVerify.Verify(verifier, tablePos);
				break;
			case 10:
				result = IVarPrefabValidateConfigVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
