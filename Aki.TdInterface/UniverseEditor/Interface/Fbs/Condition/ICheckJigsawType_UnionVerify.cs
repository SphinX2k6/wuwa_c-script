using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004F8B RID: 20363
	public static class ICheckJigsawType_UnionVerify
	{
		// Token: 0x0601FB72 RID: 129906 RVA: 0x00468854 File Offset: 0x00466A54
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ICheckJigsawTypeVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = ICheckJigsawItemPlaceIndexVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = ICheckJigsawItemMoveVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
