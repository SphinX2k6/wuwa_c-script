using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02008041 RID: 32833
	public static class TVehicleEnteringTargetVerify
	{
		// Token: 0x0603B120 RID: 241952 RVA: 0x007EDF24 File Offset: 0x007EC124
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IVehicleEnteringPlayerTargetVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IVehicleEnteringNpcTargetVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
