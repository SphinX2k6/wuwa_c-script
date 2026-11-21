using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020073D5 RID: 29653
	public static class IPathLineFacingType_UnionVerify
	{
		// Token: 0x06033DD7 RID: 212439 RVA: 0x006FE79C File Offset: 0x006FC99C
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IPathLineFacingTypeVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IPathLineFacingCurrentDirectionVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IPathLineFacingCustomDirectionVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
