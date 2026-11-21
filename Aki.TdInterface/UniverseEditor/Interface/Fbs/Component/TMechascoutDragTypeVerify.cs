using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006281 RID: 25217
	public static class TMechascoutDragTypeVerify
	{
		// Token: 0x0602AE76 RID: 175734 RVA: 0x005DAFD8 File Offset: 0x005D91D8
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IMechascoutDragLongPressVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IMechascoutDragInstantVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
