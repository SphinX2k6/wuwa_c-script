using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020051F2 RID: 20978
	public static class ITargetEntityType_UnionVerify
	{
		// Token: 0x06021098 RID: 135320 RVA: 0x00490DD0 File Offset: 0x0048EFD0
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ITargetEntityTypeVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = ITargetEntityVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = ISelfEntityVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = ITriggeredEntityVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = IPlayerEntityVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
