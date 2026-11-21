using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006BB3 RID: 27571
	public static class IDartInteractTypeBase_UnionVerify
	{
		// Token: 0x0602F737 RID: 194359 RVA: 0x00678EA8 File Offset: 0x006770A8
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
