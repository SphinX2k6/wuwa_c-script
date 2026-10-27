using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004D38 RID: 19768
	public static class TCheckJigsawInfoVerify
	{
		// Token: 0x0601F601 RID: 128513 RVA: 0x0045F850 File Offset: 0x0045DA50
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || ICheckJigsawItemPlaceIndexVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = ICheckJigsawItemMoveVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
