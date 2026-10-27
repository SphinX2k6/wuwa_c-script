using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C6E RID: 27758
	public static class IPathLineFacingType_UnionVerify
	{
		// Token: 0x06030E7C RID: 200316 RVA: 0x006A429C File Offset: 0x006A249C
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
