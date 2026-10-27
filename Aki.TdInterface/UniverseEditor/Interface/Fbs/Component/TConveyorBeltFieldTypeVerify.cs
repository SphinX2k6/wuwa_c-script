using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005BFF RID: 23551
	public static class TConveyorBeltFieldTypeVerify
	{
		// Token: 0x0602866C RID: 165484 RVA: 0x0058FB9C File Offset: 0x0058DD9C
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
