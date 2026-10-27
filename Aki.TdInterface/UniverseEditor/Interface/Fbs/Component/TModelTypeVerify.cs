using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C62 RID: 23650
	public static class TModelTypeVerify
	{
		// Token: 0x06028884 RID: 166020 RVA: 0x00593024 File Offset: 0x00591224
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IAnimalModelVerify.Verify(verifier, tablePos);
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
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
