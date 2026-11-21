using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007E87 RID: 32391
	public static class TClientFollowShooterLeisureTypeVerify
	{
		// Token: 0x0603A7C0 RID: 239552 RVA: 0x007DF4A8 File Offset: 0x007DD6A8
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IClientFollowShooterPlayAnimationVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IClientFollowShooterPlaySkillVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IClientFollowShooterResetToPlayerVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
