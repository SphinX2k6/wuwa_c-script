using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006EE3 RID: 28387
	public static class IFollowShooterLeisureInteractType_UnionVerify
	{
		// Token: 0x060311D0 RID: 201168 RVA: 0x006A8920 File Offset: 0x006A6B20
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IFollowShooterLeisureInteractTypeVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IFollowShooterResetToPlayerVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IFollowShooterLeaveThrowInteractionPointVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
