using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007F8A RID: 32650
	public static class TPrefabConfigVerify
	{
		// Token: 0x0603AD6E RID: 241006 RVA: 0x007E8580 File Offset: 0x007E6780
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IPrefabConfigVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IRandomPrefabConfigVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IRoguePrefabConfigVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IRoleTowerPrefabConfigVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = ISlashTowerPrefabConfigVerify.Verify(verifier, tablePos);
				break;
			case 6:
				result = ITowerDungeonPrefabConfigVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
