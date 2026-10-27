using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006BD8 RID: 27608
	public static class INpcLookAtTypeBase_UnionVerify
	{
		// Token: 0x06030801 RID: 198657 RVA: 0x00695C10 File Offset: 0x00693E10
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
