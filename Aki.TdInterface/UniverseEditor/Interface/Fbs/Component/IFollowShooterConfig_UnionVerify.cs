using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200580A RID: 22538
	public static class IFollowShooterConfig_UnionVerify
	{
		// Token: 0x06024757 RID: 149335 RVA: 0x00502900 File Offset: 0x00500B00
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IFollowShooterJellyFishConfigVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IFollowShooterConfigVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
