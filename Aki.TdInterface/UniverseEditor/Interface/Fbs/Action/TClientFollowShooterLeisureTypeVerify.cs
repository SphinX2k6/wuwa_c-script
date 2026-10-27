using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007679 RID: 30329
	public static class TClientFollowShooterLeisureTypeVerify
	{
		// Token: 0x06037319 RID: 226073 RVA: 0x0077B374 File Offset: 0x00779574
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IClientFollowShooterResetToPlayerVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IClientFollowShooterPlayAnimationVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
