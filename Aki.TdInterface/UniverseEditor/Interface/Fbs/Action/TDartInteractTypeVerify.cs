using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007EAE RID: 32430
	public static class TDartInteractTypeVerify
	{
		// Token: 0x0603A8D0 RID: 239824 RVA: 0x007E1410 File Offset: 0x007DF610
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IDartChampionOwnerInteractTypeVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IDartMachineInteractTypeVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IDartPlayableRoleInteractTypeVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
