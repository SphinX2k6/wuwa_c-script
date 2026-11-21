using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B56 RID: 27478
	public static class ICreatePrefabConfig_UnionVerify
	{
		// Token: 0x0602F49A RID: 193690 RVA: 0x006749D4 File Offset: 0x00672BD4
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ICreatePrefabConfigVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IPrefabConfigVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IRandomPrefabConfigVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = ITowerDungeonPrefabConfigVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = IRoguePrefabConfigVerify.Verify(verifier, tablePos);
				break;
			case 6:
				result = ISlashTowerPrefabConfigVerify.Verify(verifier, tablePos);
				break;
			case 7:
				result = IRoleTowerPrefabConfigVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
