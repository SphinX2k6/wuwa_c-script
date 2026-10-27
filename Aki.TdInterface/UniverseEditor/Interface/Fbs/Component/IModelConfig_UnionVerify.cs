using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005562 RID: 21858
	public static class IModelConfig_UnionVerify
	{
		// Token: 0x06024272 RID: 148082 RVA: 0x004FE628 File Offset: 0x004FC828
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IModelConfigVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = ILevelPrefabVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IModelIdVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = INpcModelVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = IAnimalModelVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
