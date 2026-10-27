using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005535 RID: 21813
	public static class IMechascoutDragTypeBase_UnionVerify
	{
		// Token: 0x060240A8 RID: 147624 RVA: 0x004FAB38 File Offset: 0x004F8D38
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
