using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200775E RID: 30558
	public static class TPrefabConfigVerify
	{
		// Token: 0x06037825 RID: 227365 RVA: 0x007834B0 File Offset: 0x007816B0
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
