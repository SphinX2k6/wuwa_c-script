using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005ABB RID: 23227
	public static class IMechascoutDragTypeBase_UnionVerify
	{
		// Token: 0x06026162 RID: 156002 RVA: 0x00537C5C File Offset: 0x00535E5C
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IMechascoutDragTypeBaseVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IMechascoutDragInstantVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IMechascoutDragLongPressVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
