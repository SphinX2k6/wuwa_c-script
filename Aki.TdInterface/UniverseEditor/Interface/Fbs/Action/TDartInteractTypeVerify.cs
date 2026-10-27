using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020076A3 RID: 30371
	public static class TDartInteractTypeVerify
	{
		// Token: 0x0603742D RID: 226349 RVA: 0x0077D2BC File Offset: 0x0077B4BC
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
