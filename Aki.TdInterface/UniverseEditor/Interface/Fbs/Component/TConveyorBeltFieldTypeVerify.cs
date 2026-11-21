using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200621E RID: 25118
	public static class TConveyorBeltFieldTypeVerify
	{
		// Token: 0x0602AC5C RID: 175196 RVA: 0x005D7AE4 File Offset: 0x005D5CE4
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IPointFieldVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IDirectionalFieldVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
