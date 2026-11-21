using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A40 RID: 27200
	public static class IClientFollowShooterLeisureInteractType_UnionVerify
	{
		// Token: 0x0602EA7D RID: 191101 RVA: 0x0065C3F4 File Offset: 0x0065A5F4
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IClientFollowShooterLeisureInteractTypeVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IClientFollowShooterResetToPlayerVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IClientFollowShooterPlayAnimationVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IClientFollowShooterPlaySkillVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
