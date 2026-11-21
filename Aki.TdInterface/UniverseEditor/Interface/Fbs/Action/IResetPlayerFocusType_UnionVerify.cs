using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007620 RID: 30240
	public static class IResetPlayerFocusType_UnionVerify
	{
		// Token: 0x060350F8 RID: 217336 RVA: 0x007207B4 File Offset: 0x0071E9B4
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IResetPlayerFocusTypeVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IResetPlayerFocusToDefaultDirectionVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IResetPlayerFocusToFixedDirectionVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
