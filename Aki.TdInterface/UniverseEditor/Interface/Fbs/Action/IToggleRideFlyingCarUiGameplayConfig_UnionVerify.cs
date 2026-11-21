using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007C07 RID: 31751
	public static class IToggleRideFlyingCarUiGameplayConfig_UnionVerify
	{
		// Token: 0x060393A5 RID: 234405 RVA: 0x007BB02C File Offset: 0x007B922C
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IToggleRideFlyingCarUiGameplayConfigVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IEnableRideFlyingCarUiGameplayVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IDisableRideFlyingCarUiGameplayVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
