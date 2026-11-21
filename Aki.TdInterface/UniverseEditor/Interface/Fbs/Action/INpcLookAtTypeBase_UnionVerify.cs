using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200733C RID: 29500
	public static class INpcLookAtTypeBase_UnionVerify
	{
		// Token: 0x0603371D RID: 210717 RVA: 0x006EF510 File Offset: 0x006ED710
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = INpcLookAtTypeBaseVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = INpcLookAtPlayerVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = INpcLookAtEntityVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = INpcLookAtPositionVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
