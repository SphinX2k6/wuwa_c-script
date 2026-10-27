using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200779A RID: 30618
	public static class TSpecificScanEffectVerify
	{
		// Token: 0x06037935 RID: 227637 RVA: 0x00784D2C File Offset: 0x00782F2C
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
