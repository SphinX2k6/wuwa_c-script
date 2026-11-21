using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200803E RID: 32830
	public static class TVehicleControlTypeVerify
	{
		// Token: 0x0603B114 RID: 241940 RVA: 0x007EDE28 File Offset: 0x007EC028
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
