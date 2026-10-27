using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003F8E RID: 16270
	public static class IPhotographSubTarget_UnionVerify
	{
		// Token: 0x060173CB RID: 95179 RVA: 0x0035A200 File Offset: 0x00358400
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IPhotographSubTargetVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IPhotographSubTargetSpecificRoleVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IPhotographSubTargetAnyRoleVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
