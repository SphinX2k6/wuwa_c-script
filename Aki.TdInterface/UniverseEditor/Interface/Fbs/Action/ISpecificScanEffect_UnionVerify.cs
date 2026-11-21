using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200794C RID: 31052
	public static class ISpecificScanEffect_UnionVerify
	{
		// Token: 0x06036AFE RID: 223998 RVA: 0x00751370 File Offset: 0x0074F570
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ISpecificScanEffectVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IChargeSlashScanEffectVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IFlyingFeatherScanEffectVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
