using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020063C6 RID: 25542
	public static class IClientFollowShooterLeisureInteractType_UnionVerify
	{
		// Token: 0x0602C2E8 RID: 180968 RVA: 0x00610EB8 File Offset: 0x0060F0B8
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
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
