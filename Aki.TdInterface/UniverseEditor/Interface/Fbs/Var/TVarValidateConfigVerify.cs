using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003B64 RID: 15204
	public static class TVarValidateConfigVerify
	{
		// Token: 0x06014CCA RID: 85194 RVA: 0x003056A8 File Offset: 0x003038A8
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IVarBooleanValidateConfigVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IVarEntityValidateConfigVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IVarFloatValidateConfigVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IVarIntValidateConfigVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = IVarPrefabValidateConfigVerify.Verify(verifier, tablePos);
				break;
			case 6:
				result = IVarQuestStateValidateConfigVerify.Verify(verifier, tablePos);
				break;
			case 7:
				result = IVarQuestValidateConfigVerify.Verify(verifier, tablePos);
				break;
			case 8:
				result = IVarStringValidateConfigVerify.Verify(verifier, tablePos);
				break;
			case 9:
				result = IVarTransformValidateConfigVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
