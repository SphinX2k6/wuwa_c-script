using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C5C RID: 23644
	public static class TMechascoutDragTypeVerify
	{
		// Token: 0x06028868 RID: 165992 RVA: 0x00592DC0 File Offset: 0x00590FC0
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
