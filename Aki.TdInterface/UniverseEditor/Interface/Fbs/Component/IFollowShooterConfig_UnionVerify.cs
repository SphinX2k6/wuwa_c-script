using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020052A2 RID: 21154
	public static class IFollowShooterConfig_UnionVerify
	{
		// Token: 0x060227BD RID: 141245 RVA: 0x004C7D90 File Offset: 0x004C5F90
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
