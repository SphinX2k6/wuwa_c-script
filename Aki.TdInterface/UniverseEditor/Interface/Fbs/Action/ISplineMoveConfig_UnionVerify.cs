using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007952 RID: 31058
	public static class ISplineMoveConfig_UnionVerify
	{
		// Token: 0x06036B2D RID: 224045 RVA: 0x007519E4 File Offset: 0x0074FBE4
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ISplineMoveConfigVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IOpenSplineMoveVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = ICloseSplineMoveVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
