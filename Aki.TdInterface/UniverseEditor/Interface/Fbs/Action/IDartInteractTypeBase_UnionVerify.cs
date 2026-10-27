using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006542 RID: 25922
	public static class IDartInteractTypeBase_UnionVerify
	{
		// Token: 0x0602CF83 RID: 184195 RVA: 0x0062C7FC File Offset: 0x0062A9FC
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IDartInteractTypeBaseVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IDartMachineInteractTypeVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IDartChampionOwnerInteractTypeVerify.Verify(verifier, tablePos);
				break;
			case 4:
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
