using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003F54 RID: 16212
	public static class TEnergyFishStateVerify
	{
		// Token: 0x060160DA RID: 90330 RVA: 0x0032A8A4 File Offset: 0x00328AA4
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IEnergyFishSplineStateVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IEnergyFishFollowStateVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
