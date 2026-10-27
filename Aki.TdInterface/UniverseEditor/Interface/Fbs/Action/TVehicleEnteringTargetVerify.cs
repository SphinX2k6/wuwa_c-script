using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007803 RID: 30723
	public static class TVehicleEnteringTargetVerify
	{
		// Token: 0x06037B7B RID: 228219 RVA: 0x007885AC File Offset: 0x007867AC
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
