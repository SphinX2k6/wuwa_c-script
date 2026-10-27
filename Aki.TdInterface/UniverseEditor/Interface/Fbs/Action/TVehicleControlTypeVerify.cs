using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007800 RID: 30720
	public static class TVehicleControlTypeVerify
	{
		// Token: 0x06037B6F RID: 228207 RVA: 0x007884B0 File Offset: 0x007866B0
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IVehicleExitPathMoveVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IVehicleEnterPathMoveVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
