using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005DB1 RID: 23985
	public static class IFollowShooterAbilityType_UnionVerify
	{
		// Token: 0x060290D3 RID: 168147 RVA: 0x005A2F44 File Offset: 0x005A1144
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IFollowShooterJellyFishAbilityVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IFollowShooterAbilityTypeVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
