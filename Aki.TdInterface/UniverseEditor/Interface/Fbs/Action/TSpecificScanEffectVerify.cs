using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007FD2 RID: 32722
	public static class TSpecificScanEffectVerify
	{
		// Token: 0x0603AEB0 RID: 241328 RVA: 0x007EA22C File Offset: 0x007E842C
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IFlyingFeatherScanEffectVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IChargeSlashScanEffectVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
