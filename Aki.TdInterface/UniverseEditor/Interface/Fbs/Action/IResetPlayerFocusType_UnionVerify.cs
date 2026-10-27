using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E9C RID: 28316
	public static class IResetPlayerFocusType_UnionVerify
	{
		// Token: 0x060320B8 RID: 204984 RVA: 0x006C4A80 File Offset: 0x006C2C80
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
