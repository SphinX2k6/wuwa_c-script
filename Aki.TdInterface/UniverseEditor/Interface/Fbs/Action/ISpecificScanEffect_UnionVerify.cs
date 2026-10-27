using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200717D RID: 29053
	public static class ISpecificScanEffect_UnionVerify
	{
		// Token: 0x06033824 RID: 210980 RVA: 0x006F03E0 File Offset: 0x006EE5E0
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
