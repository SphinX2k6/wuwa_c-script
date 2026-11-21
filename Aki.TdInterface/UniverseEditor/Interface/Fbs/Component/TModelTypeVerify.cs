using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006287 RID: 25223
	public static class TModelTypeVerify
	{
		// Token: 0x0602AE94 RID: 175764 RVA: 0x005DB28C File Offset: 0x005D948C
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
