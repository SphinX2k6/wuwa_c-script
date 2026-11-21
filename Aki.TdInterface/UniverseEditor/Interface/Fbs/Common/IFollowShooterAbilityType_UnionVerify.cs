using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x020063EE RID: 25582
	public static class IFollowShooterAbilityType_UnionVerify
	{
		// Token: 0x0602B75D RID: 178013 RVA: 0x005EBC74 File Offset: 0x005E9E74
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
